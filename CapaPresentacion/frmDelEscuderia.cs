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
    public partial class frmDelEscuderia : Form
    {
        //private FlowLayoutPanel flowLayoutPanelEscuderias;
        private DelEscuderiaCN escuderiaNegocio = new DelEscuderiaCN();
        private MySqlConnection conexion;

        public frmDelEscuderia()
        {
            InitializeComponent();
            //this.flowLayoutPanelEscuderias = flowPanel;
            ConexionMysql conexionMysql = new ConexionMysql();
            conexion = conexionMysql.Conexion();
        }

        private void frmDelEscuderia_Load(object sender, EventArgs e)
        {
            CargarEscuderias();
        }

        private void CargarEscuderias()
        {
            var escuderias = escuderiaNegocio.ObtenerEscuderias(conexion);

            foreach (var escuderia in escuderias)
            {
                comboBox1.Items.Add(escuderia);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem != null)
            {
                string nombreEscuderia = comboBox1.SelectedItem.ToString();
                DialogResult result = MessageBox.Show("¡Advertencia: Si llega a eliminar esta escudería, también se eliminarán sus pilotos asociados, monoplazas y los resultados de carrera! ¿Desea continuar?",
                                                      "Confirmar Eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (result == DialogResult.Yes)
                {
                    bool eliminado = escuderiaNegocio.EliminarEscuderia(nombreEscuderia, conexion);
                    if (eliminado)
                    {
                        //EliminarBotonEscuderia(nombreEscuderia);
                        MessageBox.Show("Escudería eliminada exitosamente.");
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Error al eliminar la escudería.");
                    }
                }
            }
            else
            {
                MessageBox.Show("Por favor, selecciona una escudería.");
            }
        }
    }
}
