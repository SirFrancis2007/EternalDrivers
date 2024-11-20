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
    public partial class frmMenuGranPremio : Form
    {
        public frmMenuGranPremio()
        {
            InitializeComponent();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            frmDelGranPremio frmDelGranPremio = new frmDelGranPremio();
            frmDelGranPremio.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            /*Dato Belgica*/
            frmGranPremio frmGranPremio = new frmGranPremio(1);
            frmGranPremio.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            frmGranPremio frmGranPremio = new frmGranPremio(2);
            frmGranPremio.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            frmGranPremio frmGranPremio = new frmGranPremio(3);
            frmGranPremio.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            frmGranPremio frmGranPremio = new frmGranPremio(4);
            frmGranPremio.ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            frmGranPremio frmGranPremio = new frmGranPremio(5);
            frmGranPremio.ShowDialog();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            frmAddGranPremio frmAddGranPremio = new frmAddGranPremio();
            frmAddGranPremio.ShowDialog(this);
        }

        public void AgregarBotonAlPanel(Button botton)
        {
            flowLayoutPanel1.Controls.Add(botton);
        }

        private void frmMenuGranPremio_Load(object sender, EventArgs e)
        {

        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
