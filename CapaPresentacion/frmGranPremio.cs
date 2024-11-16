﻿using CapaDatos;
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
    public partial class frmGranPremio : Form
    {
        private int idGranPremio;
        private DatosGranPremioCN granPremioCN = new DatosGranPremioCN();

        public frmGranPremio(int idGranPremio)
        {
            InitializeComponent();
            this.idGranPremio = idGranPremio;
        }

        private void frmGranPremio_Load(object sender, EventArgs e)
        {
            ConexionMysql conexion = new ConexionMysql();
            MySqlConnection conn = conexion.Conexion();

            CargarDatosGranPremio(conn);
            ObtenerDatosGranPremio(conn);

            lbDescripcion.AutoSize = true;
            lbDescripcion.MaximumSize = new Size(700, 0);
        }

        private void CargarDatosGranPremio(MySqlConnection conn)
        {
            try
            {
                DataTable resultados = granPremioCN.ObtenerResultadosCarrera(conn, idGranPremio);
                MessageBox.Show("Filas encontradas: " + resultados.Rows.Count);
                dataGridView1.DataSource = resultados;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al traer los datos del Gran Premio: " + ex.Message);
            }
            finally
            {
                conn?.Close();
            }
        }

        private void ObtenerDatosGranPremio(MySqlConnection conn)
        {
            try
            {
                DataRow granPremio = granPremioCN.ObtenerDatosGranPremio(conn, idGranPremio);
                if (granPremio != null)
                {
                    lbTituloGp.Text = granPremio["GranPremio"].ToString();
                    lbPais.Text = granPremio["Pais"].ToString();
                    lbLongitud.Text = granPremio["Longitud"].ToString();
                    lbDescripcion.Text = granPremio["Descripcion"].ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al obtener los detalles del Gran Premio: " + ex.Message);
            }
            finally
            {
                conn?.Close();
            }
        }
    }
}