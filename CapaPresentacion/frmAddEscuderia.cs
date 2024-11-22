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
using static CapaEntidad.Temporada;

namespace CapaPresentacion
{
    public partial class frmAddEscuderia : Form
    {
        private Image selectedImage;
        private AddEscuderiaCN escuderiaNegocio = new AddEscuderiaCN();
        private readonly MySqlConnection conexion;

        public frmAddEscuderia()
        {
            InitializeComponent();
            ConexionMysql conexionMysql = new ConexionMysql();
            conexion = conexionMysql.Conexion();
        }

        private void frmAddEscuderia_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string nombreEscuderia = textBoxNombreEscuderia.Text;
            string pais = textBoxPais.Text;
            string jefeEquipo = textBoxJefeEquipo.Text;

            if (string.IsNullOrWhiteSpace(nombreEscuderia) || string.IsNullOrWhiteSpace(pais) || string.IsNullOrWhiteSpace(jefeEquipo))
            {
                MessageBox.Show("Complete todos los campos");
                return;
            }

            if (selectedImage == null)
            {
                MessageBox.Show("Por favor, selecciona una imagen para la escudería.");
                return;
            }

            CapaEntidad.Escuderia nuevaEscuderia = new CapaEntidad.Escuderia
            {
                Nombre = nombreEscuderia,
                Pais = pais,
                JefeEquipo = jefeEquipo
            };

            if (escuderiaNegocio.AgregarEscuderia(conexion, nuevaEscuderia))
            {
                MessageBox.Show($"¡Hey, bienvenido {nombreEscuderia} a la Formula 1!", "Bienvenida");
                frmAddPilotos frmAddPilotos = new frmAddPilotos(nombreEscuderia);
                frmAddPilotos.Show();
                this.Hide();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog dialogoImagen = new OpenFileDialog())
            {
                dialogoImagen.Filter = "Archivo de imagen |*.jpg;*.jpeg;*.png";

                if (dialogoImagen.ShowDialog() == DialogResult.OK)
                {
                    selectedImage = Image.FromFile(dialogoImagen.FileName);
                }
            }
        }
    }
}
