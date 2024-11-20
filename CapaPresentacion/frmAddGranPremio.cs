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
                Id = 0,
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

            if (granPremioCN.AgregarGranPremio(nuevoGranPremio))
            {
                MessageBox.Show("Agregado el nuevo circuito!");
                AgregarBotonMenu(nuevoGranPremio.Id, nuevoGranPremio.Nombre);
                this.Hide();
                frmAddPuntosGranPremio frmPuntosGranPremio = new frmAddPuntosGranPremio();
                frmPuntosGranPremio.Show();
            }
            else
            {
                MessageBox.Show("Error al agregar el Gran Premio.");
            }
        }

        private void AgregarBotonMenu(int idGranPremio, string nombreGranPremio)
        {
            Button nuevoBoton = new Button
            {
                Text = nombreGranPremio,
                BackColor = Color.DarkRed,
                ForeColor = Color.White,
                Size = new Size(168, 29)
            };

            nuevoBoton.Click += (s, e) => AbrirCircuito(idGranPremio, nombreGranPremio);
            nuevoBoton.Show();

            frmMenuGranPremio menuPrincipal = (frmMenuGranPremio)Application.OpenForms["frmMenuGranPremio"];
            menuPrincipal.AgregarBotonAlPanel(nuevoBoton);
        }

        private void AbrirCircuito(int idGranPremio, string nombreGranPremio)
        {
            frmGranPremio circuito = new frmGranPremio(idGranPremio);
            circuito.Text = nombreGranPremio;
            circuito.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            // Ruta de destino
            string destinoDirectorio = @"C:\Users\Lab15-PC01\Source\Repos\SirFrancis2007\EternalDrivers\CapaPresentacion\GranPremio\";

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
