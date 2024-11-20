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

            Escuderia nuevaEscuderia = new Escuderia
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
                AgregarBotonMenu(nuevaEscuderia.Id, nuevaEscuderia.Nombre);
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

        private void AbrirEscuderia(int idEscuderia, string nombreEscuderia)
        {
            frmEscuderia escuderiaForm = new frmEscuderia(idEscuderia) { Text = nombreEscuderia };
            escuderiaForm.Show();
        }

        private void AgregarBotonMenu(int idEscuderia, string nombreEscuderia)
        {
            if (selectedImage != null)
            {
                Button nuevoBoton = new Button
                {
                    Text = nombreEscuderia,
                    Name = "btn" + idEscuderia,
                    BackColor = Color.White,
                    Size = new Size(98, 90),
                    BackgroundImage = selectedImage,
                    BackgroundImageLayout = ImageLayout.Zoom,
                    FlatStyle = FlatStyle.Popup
                };

                nuevoBoton.Click += (s, e) => AbrirEscuderia(idEscuderia, nombreEscuderia);

                if (Application.OpenForms["frmMenuEscuderias"] is frmMenuEscuderias menuPrincipal)
                {
                    menuPrincipal.AgregarBotonEscuderia(nuevoBoton);
                }
            }
            else
            {
                MessageBox.Show("Selecciona una imagen antes de insertar el botón.");
            }
        }
    }
}
