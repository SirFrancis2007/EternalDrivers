using CapaDatos;
using CapaEntidad;
using CapaNegocio;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaPresentacion
{
    public partial class frmAddMonoplaza : Form
    {
        private readonly int _escuderiaId;
        private readonly AddMonoplazaCN _monoplazaCN = new AddMonoplazaCN();

        public frmAddMonoplaza(int idEscuderia)
        {
            InitializeComponent();
            this._escuderiaId = idEscuderia;
        }

        private void frmAddMonoplaza_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string version = textBoxVMonoplaza.Text;
            string hp = textBoxHPMotor.Text;
            string motor = textBoxDMotor.Text;

            if (string.IsNullOrWhiteSpace(motor) || string.IsNullOrWhiteSpace(version) || string.IsNullOrWhiteSpace(hp))
            {
                MessageBox.Show("Por favor, completa todos los campos.");
                return;
            }
            // Crea un objeto Monoplaza con los datos capturados.
            Monoplaza monoplaza = new Monoplaza
            {
                Version = version,
                HP = hp,
                Motor = motor,
                EscuderiaId = _escuderiaId
            };

            // Conecta a la base de datos y envía el objeto Monoplaza para agregarlo.
            using (MySqlConnection conn = new ConexionMysql().Conexion())
            {
                if (_monoplazaCN.AgregarMonoplaza(conn, monoplaza))
                {
                    MessageBox.Show("¡Monoplaza agregado exitosamente!");
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Error al agregar el monoplaza.");
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog dialogoImagen = new OpenFileDialog())
            {
                dialogoImagen.Filter = "Archivo de imagen |*.png";

                if (dialogoImagen.ShowDialog() == DialogResult.OK)
                {
                    string rutaOriginal = dialogoImagen.FileName;
                    string extension = Path.GetExtension(rutaOriginal);

                    // Obtener el nombre de la escudería
                    string nombreEscuderia;
                    using (MySqlConnection conn = new ConexionMysql().Conexion())
                    {
                        nombreEscuderia = _monoplazaCN.ObtenerNombreEscuderia(conn, _escuderiaId);
                    }

                    if (string.IsNullOrEmpty(nombreEscuderia))
                    {
                        MessageBox.Show("No se pudo obtener el nombre de la escudería.");
                        return;
                    }

                    // Generar el nuevo nombre del archivo
                    string directorio = Path.GetDirectoryName(rutaOriginal);
                    string nuevoNombreArchivo = Path.Combine(directorio, nombreEscuderia + extension);

                    try
                    {
                        // Renombrar el archivo
                        File.Move(rutaOriginal, nuevoNombreArchivo);
                        MessageBox.Show($"Archivo renombrado a: {nuevoNombreArchivo}");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Error al renombrar el archivo: {ex.Message}");
                    }
                }
            }
        }
    }
}
