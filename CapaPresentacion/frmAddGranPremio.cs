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
    public partial class frmAddGranPremio : Form
    {
        private MySqlConnection conexion;
        private AddGranPremioCN granPremioCN = new AddGranPremioCN();
        public frmAddGranPremio()
        {
            InitializeComponent();
            ConexionMysql conexionMysql = new ConexionMysql();
            conexion = conexionMysql.Conexion();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void frmAddGranPremio_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!float.TryParse(lbLongitud.Text, out float longitud))
            {
                MessageBox.Show("Por favor, ingrese un valor numérico válido para la longitud.");
                return;
            }

            GranPremio nuevoGranPremio = new GranPremio
            {
                Nombre = lbNombreGP.Text,
                Descripcion = lbDescripcion.Text,
                Longitud = longitud,
                Pais = lbPais.Text
            };

            if (string.IsNullOrWhiteSpace(lbNombreGP.Text) || string.IsNullOrWhiteSpace(lbDescripcion.Text) || string.IsNullOrWhiteSpace(lbPais.Text))
            {
                MessageBox.Show("Por favor, completa todos los campos.");
                return;
            }

            // Usamos el método para agregar el Gran Premio y obtener el id
            int idGranPremio;
            if (granPremioCN.AgregarGranPremio(nuevoGranPremio, out idGranPremio))
            {
                MessageBox.Show("Agregado el nuevo circuito!");

                // Ahora pasamos el idGranPremio a la siguiente ventana
                frmAddPuntosGranPremio frmAddPuntosGranPremio = new frmAddPuntosGranPremio(idGranPremio);
                frmAddPuntosGranPremio.ShowDialog();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Error al agregar el Gran Premio.");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            // Ruta de destino
            //string destinoDirectorio = @"C:\Users\Lab15-PC01\Source\Repos\SirFrancis2007\EternalDrivers\CapaPresentacion\GranPremio\";
            string destinoDirectorio = "C:\\Users\\Usuario\\source\\repos\\EternalDrivers\\CapaPresentacion\\GranPremio\\";

            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "Imágenes PNG (*.png)|*.png";

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        string rutaOrigen = openFileDialog.FileName;

                        if (string.IsNullOrWhiteSpace(lbNombreGP.Text))
                        {
                            MessageBox.Show("Por favor, ingrese el nombre del Gran Premio antes de seleccionar una imagen.");
                            return;
                        }

                        string extension = Path.GetExtension(rutaOrigen).ToLower();
                        if (extension != ".png")
                        {
                            MessageBox.Show("Solo se permiten imágenes en formato PNG.");
                            return;
                        }

                        string nombreArchivo = lbNombreGP.Text;
                        string rutaDestino = Path.Combine(destinoDirectorio, nombreArchivo + extension);

                        using (Image imagen = Image.FromFile(rutaOrigen))
                        {
                            imagen.Save(rutaDestino);
                        }

                        MessageBox.Show("Imagen añadida y guardada correctamente como: " + nombreArchivo + extension);
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
