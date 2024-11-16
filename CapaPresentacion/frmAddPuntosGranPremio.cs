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
    public partial class frmAddPuntosGranPremio : Form
    {
        private MySqlConnection conexion;

        private AddPuntosGranPremioCN puntosgpCN = new AddPuntosGranPremioCN();
        // a medida que se ingrese se almacenan los piltoos que flatan por añadir
        private List<string> pilotosRestantes;
        private Dictionary<string, int> pilotosConPosicion;

        public frmAddPuntosGranPremio()
        {
            InitializeComponent();
        }

        private void frmAddPuntosGranPremio_Load(object sender, EventArgs e)
        {
            ConexionMysql conexionMysql = new ConexionMysql();
            conexion = conexionMysql.Conexion();
            pilotosRestantes = puntosgpCN.ObtenerPilotos(conexion);
            pilotosConPosicion = new Dictionary<string, int>();
            comboBoxPilotos.DataSource = new BindingSource(pilotosRestantes, null);

            dataGridViewResultados.Columns.Add("NombrePiloto", "Piloto");
            dataGridViewResultados.Columns.Add("Posicion", "Posición");
            dataGridViewResultados.Columns.Add("Puntos", "Puntos");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (comboBoxPilotos.SelectedItem == null)
            {
                MessageBox.Show("Por favor, selecciona un piloto y asigna su posición.");
                return;
            }


            string pilotoSeleccionado = comboBoxPilotos.SelectedItem.ToString();

            if (pilotosConPosicion.ContainsKey(pilotoSeleccionado))
            {
                MessageBox.Show("Este piloto ya tiene una posición asignada.");
                return;
            }

            int cantidadDeFilas = comboBoxPilotos.Items.Count;

            if (!int.TryParse(txtPosicion.Text, out int posicion) || posicion < 1 || posicion > 24)
            {
                MessageBox.Show($"Por favor, ingresa una posición válida entre 1 y 24.");
                return;
            }

            if (pilotosConPosicion.ContainsValue(posicion))
            {
                MessageBox.Show("Esta posición ya ha sido asignada a otro piloto.");
                return;
            }

            Pilotos resultado = puntosgpCN.AsignarPuntos(pilotoSeleccionado, posicion);

            dataGridViewResultados.Rows.Add(resultado.Nombre, resultado.Posicion, resultado.PuntosTotales);

            pilotosConPosicion[pilotoSeleccionado] = posicion;
            pilotosRestantes.Remove(pilotoSeleccionado);
            comboBoxPilotos.DataSource = null;
            comboBoxPilotos.DataSource = new BindingSource(pilotosRestantes, null);

            txtPosicion.Clear();

            if (cantidadDeFilas < 1)
            {
                MessageBox.Show("Agregado todos los pilotos! Dirigete al index para ver el Gran Premio");
                this.Hide();
            }
        }
    }
}
