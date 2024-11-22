using CapaDatos;
using CapaEntidad;
using CapaNegocio;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
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

            Monoplaza monoplaza = new Monoplaza
            {
                Version = version,
                HP = hp,
                Motor = motor,
                EscuderiaId = _escuderiaId
            };

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
            // Ruta de destino
            //string destinoDirectorio = @"C:\Users\Lab15-PC01\Source\Repos\SirFrancis2007\EternalDrivers\CapaPresentacion\Monoplaza\";
            string destinoDirectorio = "C:\\Users\\Usuario\\source\\repos\\EternalDrivers\\CapaPresentacion\\Monoplaza\\";

            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "Imágenes PNG (*.png)|*.png";

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        string rutaOrigen = openFileDialog.FileName;

                        string nombreEscuderia;
                        using (MySqlConnection conn = new ConexionMysql().Conexion())
                        {
                            nombreEscuderia = _monoplazaCN.ObtenerNombreEscuderia(conn, _escuderiaId);
                        }

                        if (string.IsNullOrWhiteSpace(textBoxVMonoplaza.Text))
                        {
                            MessageBox.Show("Por favor, ingrese el nombre del Monoplaza antes de seleccionar una imagen.");
                            return;
                        }

                        string extension = Path.GetExtension(rutaOrigen).ToLower();
                        if (extension != ".png")
                        {
                            MessageBox.Show("Solo se permiten imágenes en formato PNG.");
                            return;
                        }

                        string nombreArchivo = textBoxVMonoplaza.Text;
                        string rutaDestino = Path.Combine(destinoDirectorio, nombreEscuderia + ".png");

                        using (Image imagen = Image.FromFile(rutaOrigen))
                        {
                            imagen.Save(rutaDestino);
                        }

                        MessageBox.Show("Imagen añadida y guardada correctamente como: " + nombreArchivo + ".png");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error al procesar la imagen: " + ex.Message);
                    }
                }
            }
        }
    }
}
