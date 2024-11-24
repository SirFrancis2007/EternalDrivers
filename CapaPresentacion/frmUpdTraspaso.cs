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
    public partial class frmUpdTraspaso : Form
    {
        private UpdTraspasoCN UpdTraspasoCN = new UpdTraspasoCN();
        public frmUpdTraspaso()
        {
            InitializeComponent();
        }

        private void frmUpdTraspaso_Load(object sender, EventArgs e)
        {
            using (MySqlConnection conn = new ConexionMysql().Conexion())
            {
                CargarPilotosEnCombos(conn);
                CargarPilotosEnTabla(conn);
            }
        }

        private void CargarPilotosEnTabla(MySqlConnection conn)
        {
            DataTable dt = UpdTraspasoCN.ObtenerPilotos(conn);
            //MessageBox.Show("Filas encontradas: " + dt.Rows.Count);
            dataGridViewPilotos.DataSource = dt;
        }

        private void CargarPilotosEnCombos(MySqlConnection conn)
        {
            List<Pilotos> pilotos = UpdTraspasoCN.ObtenerListaPilotos(conn);

            comboBoxNombreCorredorA.DataSource = pilotos;
            comboBoxNombreCorredorA.DisplayMember = "Nombre";
            comboBoxNombreCorredorA.ValueMember = "IDPiloto";

            comboBoxNombreCorredorB.DataSource = new List<Pilotos>(pilotos); // Crear una copia para el segundo combo
            comboBoxNombreCorredorB.DisplayMember = "Nombre";
            comboBoxNombreCorredorB.ValueMember = "IDPiloto";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (MySqlConnection conn = new ConexionMysql().Conexion())
            {
                try
                {
                    int idPilotoA = (int)comboBoxNombreCorredorA.SelectedValue;
                    int idPilotoB = (int)comboBoxNombreCorredorB.SelectedValue;

                    UpdTraspasoCN.TraspasarPilotos(conn, idPilotoA, idPilotoB);

                    MessageBox.Show("Traspaso realizado");
                    CargarPilotosEnTabla(conn);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error al transferir los pilotos: {ex.Message}");
                }
            }
        }
    }
}
