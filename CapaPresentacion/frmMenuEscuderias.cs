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
    public partial class frmMenuEscuderias : Form
    {
        private MenuEscuderiaCN MenuEscuderiaCN = new MenuEscuderiaCN();
        private MySqlConnection conexion;

        public frmMenuEscuderias()
        {
            InitializeComponent();
            ConexionMysql conexionMysql = new ConexionMysql();
            conexion = conexionMysql.Conexion();
        }
        private void frmMenuEscuderias_Load(object sender, EventArgs e)
        {
            CargarEscuderias();
        }

        private void CargarEscuderias()
        {
            var escuderias = MenuEscuderiaCN.ObtenerEscuderiaCN(conexion);

            foreach (var escuderia in escuderias)
            {
                comboBox1.Items.Add(escuderia);
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            frmUpdTraspaso frmUpdTraspaso = new frmUpdTraspaso();
            frmUpdTraspaso.ShowDialog();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            frmDelEscuderia frmDelEscuderia = new frmDelEscuderia();
            frmDelEscuderia.ShowDialog();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            frmAddEscuderia frmAddEscuderia = new frmAddEscuderia();
            frmAddEscuderia.ShowDialog();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            frmDelPiloto frmDelPiloto = new frmDelPiloto();
            frmDelPiloto.ShowDialog();
        }

        public void AgregarBotonEscuderia(Button button)
        {
            flowLayoutPanel1.Controls.Add(button);
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string nombreEscuderia = comboBox1.SelectedItem.ToString();

            frmEscuderia frmEscuderia = new frmEscuderia(nombreEscuderia);
            frmEscuderia.Show();
        }
    }
}
