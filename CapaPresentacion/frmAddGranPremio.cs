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
    public partial class frmAddGranPremio : Form
    {
        private MySqlConnection conexion;
        private AddGranPremioCN granPremioCN = new AddGranPremioCN();
        public frmAddGranPremio()
        {
            InitializeComponent();
            ConexionMysql conexionMysql = new ConexionMysql();
            conexion = conexionMysql.Conexion();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void frmAddGranPremio_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!float.TryParse(lbLongitud.Text, out float longitud))
            {
                MessageBox.Show("Por favor, ingrese un valor numérico válido para la longitud.");
                return;
            }

            GranPremio nuevoGranPremio = new GranPremio
            {
                Nombre = lbNombreGP.Text,
                Descripcion = lbDescripcion.Text,
                Longitud = longitud,
                Pais = lbPais.Text
            };

            if (string.IsNullOrWhiteSpace(lbNombreGP.Text) || string.IsNullOrWhiteSpace(lbDescripcion.Text) || string.IsNullOrWhiteSpace(lbPais.Text))
            {
                MessageBox.Show("Por favor, completa todos los campos.");
                return;
            }

            if (granPremioCN.AgregarGranPremio(nuevoGranPremio))
            {
                MessageBox.Show("Agregado el nuevo circuito!");
                //AgregarBotonMenu(nuevoGranPremio.Nombre);
                this.Hide();
                frmAddPuntosGranPremio frmPuntosGranPremio = new frmAddPuntosGranPremio();
                frmPuntosGranPremio.Show();
            }
            else
            {
                MessageBox.Show("Error al agregar el Gran Premio.");
            }
        }
    }
}
