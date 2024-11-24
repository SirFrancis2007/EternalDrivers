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
    public partial class frmDelGranPremio : Form
    {
        private FlowLayoutPanel flowLayoutPaneGP;
        private DelGranPremioCN granPremioNegocio = new DelGranPremioCN();
        private MySqlConnection conexion;

        public frmDelGranPremio()
        {
            InitializeComponent();
            ConexionMysql conexionMysql = new ConexionMysql();
            conexion = conexionMysql.Conexion();
        }

        private void frmDelGranPremio_Load(object sender, EventArgs e)
        {
            CargarGranPremios();
        }

        private void CargarGranPremios()
        {
            var granPremios = granPremioNegocio.ObtenerGranPremios(conexion);
            foreach (var gp in granPremios)
            {
                comboBox1.Items.Add(gp);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem != null)
            {
                string nombreGranPremio = comboBox1.SelectedItem.ToString();
                DialogResult result = MessageBox.Show("¡Advertencia: Si elimina este circuito, también se eliminarán los resultados de la carrera asociada! ¿Desea continuar?",
                                                      "Confirmar Eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (result == DialogResult.Yes)
                {
                    bool eliminado = granPremioNegocio.EliminarGranPremio(nombreGranPremio, conexion);
                    if (eliminado)
                    {
                        MessageBox.Show("Circuito eliminado exitosamente.");
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Error al eliminar el circuito.");
                    }
                }
            }
            else
            {
                MessageBox.Show("Por favor, selecciona un circuito.");
            }
        }
    }
}
