using CapaDatos;
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
    public partial class frmAddPilotos : Form
    {
        private readonly AddPilotosCN _pilotosCN = new AddPilotosCN();
        private MySqlConnection conexion;
        private Image selectedImageCorredor1;
        private Image selectedImageCorredor2;
        public string nameEscuderia;

        public frmAddPilotos(string nombreEscuderia)
        {
            InitializeComponent();
            this.nameEscuderia = nombreEscuderia;
            conexion = new ConexionMysql().Conexion();
        }

        private void frmAddPilotos_Load(object sender, EventArgs e)
        {
            using (MySqlConnection conn = new ConexionMysql().Conexion())
            {
                mtdEscuderiaOK(conn);
            }
        }

        private void mtdEscuderiaOK(MySqlConnection conexion)
        {
            List<string> escuderias = _pilotosCN.ObtenerEscuderiasDisponibles(conexion);
            comboBox1.Items.AddRange(escuderias.ToArray());
            comboBox2.Items.AddRange(escuderias.ToArray());
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string nombre1 = TbnombreCorredor1.Text;
            string nombre2 = TbnombreCorredor2.Text;
            string pais1 = tbPais1.Text;
            string pais2 = tbPais2.Text;

            if (nombre1 == nombre2)
            {
                MessageBox.Show("No se puede agregar piltoos repetidos!");
                return;
            }

            if (string.IsNullOrWhiteSpace(nombre1) || string.IsNullOrWhiteSpace(nombre2) ||
                string.IsNullOrWhiteSpace(pais1) || string.IsNullOrWhiteSpace(pais2))
            {
                MessageBox.Show("Por favor, completa todos los campos.");
                return;
            }

            if (comboBox1.SelectedItem != null)
            {
                string nombreEscuderia = comboBox1.SelectedItem.ToString();

                var resultado = _pilotosCN.AgregarPilotos(conexion, nombre1, nombre2, pais1, pais2, nombreEscuderia);

                if (resultado.success)
                {
                    MessageBox.Show("¡Pilotos agregados exitosamente!");
                    this.Hide();
                    frmAddMonoplaza nuevoMonoplaza = new frmAddMonoplaza(_pilotosCN.ObtenerIdEscuderia(conexion, nombreEscuderia));
                    nuevoMonoplaza.Show();
                }
                else
                {
                    MessageBox.Show(resultado.mensajeError);
                }
            }
            else
            {
                MessageBox.Show("Seleccione una escudería.");
            }
        }

        /*Imagen Corredor Titular*/
        private void button2_Click(object sender, EventArgs e)
        {
            //string carpetaDestino = "C:\\Users\\Lab15-PC01\\Source\\Repos\\SirFrancis2007\\EternalDrivers\\CapaPresentacion\\Pilotos\\";
            string carpetaDestino = "C:\\Users\\Usuario\\source\\repos\\EternalDrivers\\CapaPresentacion\\Pilotos\\";

            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                // Solo permite seleccionar archivos PNG
                openFileDialog.Filter = "Imágenes PNG (*.png)|*.png";

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        string rutaOrigen = openFileDialog.FileName;

                        // Verificar que el nombre del corredor no esté vacío
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

                        string nombreArchivo = TbnombreCorredor1.Text.Trim();
                        string rutaDestino = Path.Combine(carpetaDestino, nombreArchivo + ".png");

                        if (!Directory.Exists(carpetaDestino))
                        {
                            Directory.CreateDirectory(carpetaDestino);
                        }

                        using (Image imagen = Image.FromFile(rutaOrigen))
                        {
                            imagen.Save(rutaDestino, System.Drawing.Imaging.ImageFormat.Png);
                        }

                        MessageBox.Show("Imagen añadida y guardada correctamente como: " + nombreArchivo + ".png");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error al procesar la imagen: " + ex.Message);
                    }
                }
            }

            /*Botton de corredor Titular*/

        }

        /*Imagen Corredor 2*/
        private void button3_Click(object sender, EventArgs e)
        {
            //string carpetaDestino = "C:\\Users\\Lab15-PC01\\Source\\Repos\\SirFrancis2007\\EternalDrivers\\CapaPresentacion\\Pilotos\\";
            string carpetaDestino = "C:\\Users\\Usuario\\source\\repos\\EternalDrivers\\CapaPresentacion\\Pilotos\\";

            /*imagen corredor suplente*/
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                // Solo permite seleccionar archivos PNG
                openFileDialog.Filter = "Imágenes PNG (*.png)|*.png";

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        string rutaOrigen = openFileDialog.FileName;

                        if (string.IsNullOrWhiteSpace(TbnombreCorredor2.Text))
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

                        string nombreArchivo = TbnombreCorredor2.Text;
                        string rutaDestino = Path.Combine(carpetaDestino, nombreArchivo + ".png");

                        using (Image imagen = Image.FromFile(rutaOrigen))
                        {
                            imagen.Save(rutaDestino, System.Drawing.Imaging.ImageFormat.Png);
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

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            string nombreEscuderia = comboBox2.SelectedItem.ToString().Trim();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string nombreEscuderia = comboBox1.SelectedItem.ToString().Trim();
        }
    }
}
