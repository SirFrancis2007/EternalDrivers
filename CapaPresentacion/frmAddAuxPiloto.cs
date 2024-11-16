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
            /*Botton de corredor Titular*/
            using (OpenFileDialog dialogoImagen = new OpenFileDialog())
            {
                dialogoImagen.Filter = "Archivo de imagen |.png";

                if (dialogoImagen.ShowDialog() == DialogResult.OK)
                {
                    imagenpiloto = Image.FromFile(dialogoImagen.FileName);
                    string path = dialogoImagen.FileName;
                    string extension = Path.GetExtension(path);
                    // cambiarlo por el nombre de los corredores
                    string nuevoNombreArchivo = Path.Combine(Path.GetDirectoryName(path), TbnombreCorredor1.Text + extension);

                    imagenpiloto.Save(nuevoNombreArchivo);

                    SaveImageToFolder(imagenpiloto, "Corredor1");
                }
            }
        }

        private void SaveImageToFolder(Image image, string nombreCorredor)
        {
            try
            {
                //string carpetaDestino = "C:\\Users\\Lab15-PC01\\Source\\Repos\\SirFrancis2007\\FormulaUnoLaboratorio\\FormulaUnoLaboratorio\\Corredores\\";
                string carpetaDestino = "C:\\Users\\Usuario\\Source\\Repos\\SirFrancis2007\\FormulaUnoLaboratorio\\FormulaUnoLaboratorio\\Corredores\\";

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
    }
}
