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
    public partial class frmMenuGranPremio : Form
    {
        private MenuGranPremioCn MenuGranPremioCn = new MenuGranPremioCn();
        private MySqlConnection conexion;
        public frmMenuGranPremio()
        {
            InitializeComponent();
            ConexionMysql conexionMysql = new ConexionMysql();
            conexion = conexionMysql.Conexion();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            frmDelGranPremio frmDelGranPremio = new frmDelGranPremio();
            frmDelGranPremio.ShowDialog();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            frmAddGranPremio frmAddGranPremio = new frmAddGranPremio();
            frmAddGranPremio.ShowDialog(this);
        }

        public void AgregarBotonAlPanel(Button botton)
        {
            flowLayoutPanel1.Controls.Add(botton);
        }

        private void frmMenuGranPremio_Load(object sender, EventArgs e)
        {

            CargarGranPremio();
        }

        private void CargarGranPremio()
        {
            var escuderias = MenuGranPremioCn.ObtenerGranPrmeioCN(conexion);

            foreach (var escuderia in escuderias)
            {
                comboBox1.Items.Add(escuderia);
            }
        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string nombreGranPremio = comboBox1.SelectedItem.ToString();

            frmGranPremio frmGranPremio = new frmGranPremio(nombreGranPremio);
            frmGranPremio.Show();
        }
    }
}
