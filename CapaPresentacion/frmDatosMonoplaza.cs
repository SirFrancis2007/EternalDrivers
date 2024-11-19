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
    public partial class frmDatosMonoplaza : Form
    {
        private DatosMonoplazaCN DatosMonoplazaCN = new DatosMonoplazaCN(); 
        public frmDatosMonoplaza()
        {
            InitializeComponent();
        }

        private void frmDatosMonoplaza_Load(object sender, EventArgs e)
        {
            ConexionMysql conexion = new ConexionMysql();
            MySqlConnection conn = conexion.Conexion();
            this.dataGridView1.DefaultCellStyle.WrapMode = DataGridViewTriState.True;


            mtdDatosMonoplaza(conn);
        }

        private void mtdDatosMonoplaza(MySqlConnection conexion)
        {
            try
            {
                DataTable resultados = DatosMonoplazaCN.mtdDatosMonoplaza(conexion);
                MessageBox.Show("Filas encontradas: " + resultados.Rows.Count);
                dataGridView1.DataSource = resultados;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al traer los datos del Gran Premio: " + ex.Message);
            }
            finally
            {
                conexion?.Close();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
