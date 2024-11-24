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
    public partial class frmGranPremio : Form
    {
        private string GranPremio;
        private DatosGranPremioCN granPremioCN = new DatosGranPremioCN();

        public frmGranPremio(string nombreGranPremio)
        {
            InitializeComponent();
            this.GranPremio = nombreGranPremio;
        }

        private void frmGranPremio_Load(object sender, EventArgs e)
        {
            ConexionMysql conexion = new ConexionMysql();
            MySqlConnection conn = conexion.Conexion();

            CargarDatosGranPremio(conn);
            ObtenerDatosGranPremio(conn);

            lbDescripcion.AutoSize = true;
            lbDescripcion.MaximumSize = new Size(700, 0);
        }

        private void CargarDatosGranPremio(MySqlConnection conn)
        {
            try
            {
                DataTable resultados = granPremioCN.ObtenerResultadosCarrera(conn, GranPremio);
                //MessageBox.Show("Filas encontradas: " + resultados.Rows.Count);
                dataGridView1.DataSource = resultados;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al traer los datos del Gran Premio: " + ex.Message);
            }
            finally
            {
                conn?.Close();
            }
        }

        private void ObtenerDatosGranPremio(MySqlConnection conn)
        {
            try
            {
                DataRow granPremio = granPremioCN.ObtenerDatosGranPremio(conn, GranPremio);
                if (granPremio != null)
                {
                    lbTituloGp.Text = granPremio["GranPremio"].ToString();
                    lbPais.Text = granPremio["Pais"].ToString();
                    lbLongitud.Text = granPremio["Longitud"].ToString();
                    lbDescripcion.Text = granPremio["Descripcion"].ToString();

                    CargarImagenGranPremio((string)granPremio["Pais"]);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al obtener los detalles del Gran Premio: " + ex.Message);
            }
            finally
            {
                conn?.Close();
            }
        }

        private void CargarImagenGranPremio(string GranPremio)
        {
            try
            {
                //cambiar por la dir correcta
                //string rutaCarpetaImagenes = "C:\\Users\\Lab15-PC01\\Source\\Repos\\SirFrancis2007\\EternalDrivers\\CapaPresentacion\\GranPremio\\";
                string rutaCarpetaImagenes = "C:\\Users\\Usuario\\source\\repos\\EternalDrivers\\CapaPresentacion\\GranPremio\\";

               string nombreImagen = GranPremio.Trim() + ".png";

                string rutaImagen = Path.Combine(rutaCarpetaImagenes, nombreImagen);

                if (File.Exists(rutaImagen))
                {
                    pictureBoxGranPremio.Image = Image.FromFile(rutaImagen);
                }
                else
                {
                    MessageBox.Show("No encontrada!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar la imagen: {ex.Message}");
            }
        }

        private void pictureBoxGranPremio_Click(object sender, EventArgs e)
        {

        }
    }
}
