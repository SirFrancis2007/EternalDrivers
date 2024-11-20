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
    public partial class frmAddAuxPiloto : Form
    {
        private string escuderiaSeleccionada;
        private AddAuxPilotoCN nuevopiloto = new AddAuxPilotoCN();
        private Image imagenpiloto;

        public frmAddAuxPiloto()
        {
            InitializeComponent();
        }

        private void frmAddAuxPiloto_Load(object sender, EventArgs e)
        {
            using (MySqlConnection conn = new ConexionMysql().Conexion())
            {
                CargarEscuderias(conn);
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            escuderiaSeleccionada = comboBox1.SelectedItem.ToString();
        }

        private void CargarEscuderias(MySqlConnection conn)
        {
            List<string> escuderias = nuevopiloto.mtdEscuderiaCN(conn);
            comboBox1.Items.AddRange(escuderias.ToArray());
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem == null)
            {
                MessageBox.Show("Por favor, selecciona una escudería.");
                return;
            }

            Pilotos nuevoPiloto = new Pilotos
            {
                Nombre = TbnombreCorredor1.Text,
                Nacionalidad = tbPais.Text,
                Escuderia = escuderiaSeleccionada
            };

            if (string.IsNullOrWhiteSpace(TbnombreCorredor1.Text) || string.IsNullOrWhiteSpace(tbPais.Text))
            {
                MessageBox.Show("Complete todos los campos.");
            }

            using (MySqlConnection conn = new ConexionMysql().Conexion())
            {
                if (nuevopiloto.AgregarPiloto(conn, nuevoPiloto))
                {
                    MessageBox.Show("¡Piloto agregado a la escudería!");
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Error al agregar piloto o escudería no encontrada.");
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string carpetaDestino = "C:\\Users\\Lab15-PC01\\Source\\Repos\\SirFrancis2007\\EternalDrivers\\CapaPresentacion\\Pilotos\\";

            /*Botton de corredor Titular*/
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                // Solo permite seleccionar archivos PNG
                openFileDialog.Filter = "Imágenes PNG (*.png)|*.png";

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        string rutaOrigen = openFileDialog.FileName;

                        if (string.IsNullOrWhiteSpace(TbnombreCorredor1.Text))
                        {
                            MessageBox.Show("Por favor, ingrese el nombre del corredor antes de seleccionar una imagen.");
                            return;
                        }

                        string extension = Path.GetExtension(rutaOrigen).ToLower();
                        if (extension != ".png")
                        {
                            MessageBox.Show("Solo se permiten imágenes en formato PNG.");
                            return;
                        }

                        string nombreArchivo = TbnombreCorredor1.Text;
                        string rutaDestino = Path.Combine(carpetaDestino, nombreArchivo + ".png");

                        if (!Directory.Exists(carpetaDestino))
                        {
                            Directory.CreateDirectory(carpetaDestino);
                        }

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
