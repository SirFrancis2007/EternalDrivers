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
        public frmMenuEscuderias()
        {
            InitializeComponent();
        }
        private void frmMenuEscuderias_Load(object sender, EventArgs e)
        {

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


        private void button1_Click(object sender, EventArgs e)
        {
            /*ferrari*/
            frmEscuderia frmescuderia = new frmEscuderia(1);
            frmescuderia.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            frmEscuderia frmescuderia = new frmEscuderia(2);
            frmescuderia.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            frmEscuderia frmescuderia = new frmEscuderia(3);
            frmescuderia.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            frmEscuderia frmescuderia = new frmEscuderia(4);
            frmescuderia.ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            frmEscuderia frmescuderia = new frmEscuderia(5);
            frmescuderia.ShowDialog();
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
    }
}
