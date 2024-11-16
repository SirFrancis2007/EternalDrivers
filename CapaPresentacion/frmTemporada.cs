using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaDatos;
using CapaEntidad;
using CapaNegocio;
using MySql.Data.MySqlClient;
using static CapaEntidad.Temporada;

namespace CapaPresentacion
{
    public partial class frmTemporada : Form
    {
        private DatosTemporadaCN temporadanegocio;
        private MySqlConnection conexion;

        public frmTemporada()
        {
            InitializeComponent();
            temporadanegocio = new DatosTemporadaCN();
            ConexionMysql conexionMysql = new ConexionMysql();
            conexion = conexionMysql.Conexion();
        }

        private void frmTemporada_Load(object sender, EventArgs e)
        {
            CargarDataTemporada();
            CargarMundialConstructores();
        }

        private void CargarDataTemporada()
        {
            try
            {
                List<Piloto> pilotos = DatosTemporadaCN.ObtenerDatosTemporada(conexion);
                dataGridView1.DataSource = pilotos;
                MessageBox.Show("Filas encontradas: " + pilotos.Count);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar los datos de la temporada: " + ex.Message);
            }
        }

        private void CargarMundialConstructores()
        {
            try
            {
                List<Temporada.Escuderia> escuderias = DatosTemporadaCN.ObtenerMundialConstructores(conexion);
                dataGridView2.DataSource = escuderias;
                MessageBox.Show("Filas encontradas: " + escuderias.Count);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar el mundial de constructores: " + ex.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmIndex frmIndex = new frmIndex();
            frmIndex.ShowDialog();  
        }
    }
}
