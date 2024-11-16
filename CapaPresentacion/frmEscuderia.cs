﻿using CapaDatos;
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
    public partial class frmEscuderia : Form
    {
        private int idEscuderia;
        private DatosEscuderiaCN _escuderiasCN = new DatosEscuderiaCN();
        public frmEscuderia(int idEscuderia)
        {
            InitializeComponent();
            this.idEscuderia = idEscuderia;
        }

        private void frmEscuderia_Load(object sender, EventArgs e)
        {
            ConexionMysql conexion = new ConexionMysql();
            MySqlConnection conn = conexion.Conexion();

            CargarDatosEscuderia(conn);
            CargarCorredores(conn);

            lbMotor.AutoSize = true;
            lbMotor.MaximumSize = new Size(550, 0);
        }

        private void CargarDatosEscuderia(MySqlConnection conn)
        {
            Dictionary<string, string> datosEscuderia = _escuderiasCN.ObtenerDatosEscuderia(conn, idEscuderia);

            if (datosEscuderia.Count > 0)
            {
                lbEscuderia.Text = datosEscuderia["Escuderia"];
                lbpais.Text = datosEscuderia["Pais"];
                lbJedeEquipo.Text = datosEscuderia["JefeDeEquipo"];
                LbMonoplaza.Text = datosEscuderia["Monoplaza"];
                lbPotencia.Text = datosEscuderia["Potencia"];
                lbMotor.Text = datosEscuderia["Motor"];

                CargarImagenEscuderia(datosEscuderia["Escuderia"]);
            }
            else
            {
                MessageBox.Show("No se encontraron datos de la escudería.");
            }
        }

        private void CargarCorredores(MySqlConnection conn)
        {
            List<string> corredores = _escuderiasCN.ObtenerCorredores(conn, idEscuderia);

            if (corredores.Count >= 2)
            {
                lbCorredor1.Text = corredores[0];
                lbCorredor2.Text = corredores[1];

                CargarImagenCorredor(corredores[0], pictureBoxCorredor1);
                CargarImagenCorredor(corredores[1], pictureBoxCorredor2);
            }
            else
            {
                lbCorredor1.Text = "No asignado";
                lbCorredor2.Text = "No asignado";
            }
        }

        private void CargarImagenEscuderia(string nombreEscuderia)
        {
            try
            {
                //string rutaCarpetaImagenes = "C:\\Users\\Lab15-PC01\\Source\\Repos\\SirFrancis2007\\FormulaUnoLaboratorio\\FormulaUnoLaboratorio\\Monoplazas\\";
                string rutaCarpetaImagenes = "C:\\Users\\Usuario\\Source\\Repos\\SirFrancis2007\\FormulaUnoLaboratorio\\FormulaUnoLaboratorio\\Monoplazas\\";


                string nombreImagen = nombreEscuderia.Trim().Replace(" ", "") + ".png";

                string rutaImagen = Path.Combine(rutaCarpetaImagenes, nombreImagen);

                if (File.Exists(rutaImagen))
                {
                    pictureBoxAuto.Image = Image.FromFile(rutaImagen);
                }
                else
                {
                    MessageBox.Show("No encontrada!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar la imagen: {ex.Message}");
            }
        }

        private void CargarImagenCorredor(string nombreCorredor, PictureBox pictureBox)
        {
            try
            {
                //string rutaCarpetaImagenes = "C:\\Users\\Lab15-PC01\\Source\\Repos\\SirFrancis2007\\FormulaUnoLaboratorio\\FormulaUnoLaboratorio\\Corredores\\";
                string rutaCarpetaImagenes = "C:\\Users\\Usuario\\Source\\Repos\\SirFrancis2007\\FormulaUnoLaboratorio\\FormulaUnoLaboratorio\\Corredores\\";


                string nombreImagen = nombreCorredor + ".png";

                string rutaImagen = Path.Combine(rutaCarpetaImagenes, nombreImagen);

                if (File.Exists(rutaImagen))
                {
                    pictureBox.Image = Image.FromFile(rutaImagen);
                }
                else
                {
                    MessageBox.Show("No encontrados los pilotos");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar la imagen del corredor: {ex.Message}");
            }
        }
    }
}