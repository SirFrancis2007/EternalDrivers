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
            /*Botton de corredor Titular*/
            using (OpenFileDialog dialogoImagen = new OpenFileDialog())
            {
                dialogoImagen.Filter = "Archivo de imagen |*.jpg;*.jpeg;*.png";

                if (dialogoImagen.ShowDialog() == DialogResult.OK)
                {
                    selectedImageCorredor1 = Image.FromFile(dialogoImagen.FileName);
                    string path = dialogoImagen.FileName;
                    string extension = Path.GetExtension(path);
                    // cambiarlo por el nombre de los corredores
                    string nuevoNombreArchivo = Path.Combine(Path.GetDirectoryName(path), TbnombreCorredor1.Text + extension);

                    selectedImageCorredor1.Save(nuevoNombreArchivo);

                    SaveImageToFolder(selectedImageCorredor1, "Corredor1");
                }
            }
        }

        /*Imagen Corredor 2*/
        private void button3_Click(object sender, EventArgs e)
        {
            /*imagen corredor suplente*/
            using (OpenFileDialog dialogoImagen = new OpenFileDialog())
            {
                dialogoImagen.Filter = "Archivo de imagen |*.jpg;*.jpeg;*.png";

                if (dialogoImagen.ShowDialog() == DialogResult.OK)
                {
                    selectedImageCorredor2 = Image.FromFile(dialogoImagen.FileName);
                    string path = dialogoImagen.FileName;
                    string extension = Path.GetExtension(path);
                    string nuevoNombreArchivo = Path.Combine(Path.GetDirectoryName(path), TbnombreCorredor2.Text + extension);

                    selectedImageCorredor2.Save(nuevoNombreArchivo);

                    SaveImageToFolder(selectedImageCorredor1, "Corredor2");
                }
            }
        }

        private void SaveImageToFolder(Image image, string nombreCorredor)
        {
            try
            {
                //string carpetaDestino = "C:\\Users\\Lab15-PC01\\Source\\Repos\\SirFrancis2007\\FormulaUnoLaboratorio\\FormulaUnoLaboratorio\\Corredores\\";
                string carpetaDestino = "C:\\Users\\Usuario\\source\\repos\\EternalDrivers\\CapaPresentacion\\Pilotos\\";
                //agregar dir de carpeta

                if (!Directory.Exists(carpetaDestino))
                {
                    Directory.CreateDirectory(carpetaDestino);
                }

                string nombreImagen = $"{nombreCorredor}_{Guid.NewGuid()}.png";
                string rutaFinal = Path.Combine(carpetaDestino, nombreImagen);

                image.Save(rutaFinal, System.Drawing.Imaging.ImageFormat.Png);

                MessageBox.Show($"Imagen guardada exitosamente en: {rutaFinal}");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al guardar la imagen: {ex.Message}");
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
