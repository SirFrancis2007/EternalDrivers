using CapaDatos;
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
    public partial class frmDelPiloto : Form
    {
        private DelAuxPilotoDAO pilotoNegocio = new DelAuxPilotoDAO();
        private string escuderiaSeleccionada;

        public frmDelPiloto()
        {
            InitializeComponent();
        }

        private void frmDelPiloto_Load(object sender, EventArgs e)
        {
            using (MySqlConnection conn = new ConexionMysql().Conexion())
            {
                CargarEscuderias(conn);
            }
        }

        private void CargarEscuderias(MySqlConnection conn)
        {
            List<string> escuderias = pilotoNegocio.ObtenerEscuderias(conn);
            comboBoxEscuderias.Items.AddRange(escuderias.ToArray());
        }

        private void CargarPilotos(MySqlConnection conn, string escuderia)
        {
            comboBoxPilotos.Items.Clear();

            List<string> pilotos = pilotoNegocio.ObtenerPilotosPorEscuderia(conn, escuderia);

            if (pilotos.Count > 0)
            {
                comboBoxPilotos.Items.AddRange(pilotos.ToArray());
            }
            else
            {
                MessageBox.Show("No hay pilotos disponibles para la escudería seleccionada.");
            }
        }

        private void comboBoxEscuderias_SelectedIndexChanged(object sender, EventArgs e)
        {
            escuderiaSeleccionada = comboBoxEscuderias.SelectedItem.ToString();

            using (MySqlConnection conn = new ConexionMysql().Conexion())
            {
                if (conn.State == ConnectionState.Closed)
                {
                    conn.Open();
                }

                CargarPilotos(conn, escuderiaSeleccionada);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (comboBoxPilotos.SelectedItem != null)
            {
                string nombrePiloto = comboBoxPilotos.SelectedItem.ToString();
                using (MySqlConnection conn = new ConexionMysql().Conexion())
                {
                    if (pilotoNegocio.EliminarPiloto(conn, nombrePiloto, escuderiaSeleccionada))
                    {
                        MessageBox.Show("Piloto eliminado correctamente.");
                        this.Hide();
                        frmAddAuxPiloto frmAddAuxPiloto = new frmAddAuxPiloto();
                        frmAddAuxPiloto.Show();
                    }
                    else
                    {
                        MessageBox.Show("No se puede eliminar el último piloto.");
                    }
                }
            }
            else
            {
                MessageBox.Show("Por favor, selecciona un piloto.");
            }
        }
    }
}
