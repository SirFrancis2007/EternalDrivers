using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WMPLib;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace CapaPresentacion
{
    public partial class frmIndex : Form
    {
        private WindowsMediaPlayer player = new WindowsMediaPlayer();

        public frmIndex()
        {
            InitializeComponent();
        }

        private void frmIndex_Load(object sender, EventArgs e)
        {
            // agregar URL:
            player.URL = "C:\\Users\\Usuario\\source\\repos\\EternalDrivers\\CapaPresentacion\\Formula 1 Official Theme Song - Brian Tyler.mp3";
            //player.URL = "C:\\Users\\Lab15-PC01\\Source\\Repos\\SirFrancis2007\\EternalDrivers\\CapaPresentacion\\Formula 1 Official Theme Song - Brian Tyler.mp3";
        }

        private void themeF1()
        {
            player.settings.setMode("loop", true);
            player.controls.play();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            /*Botton de SALIDA*/
            this.Close();
        }

        /*button de SONIDO*/
        private void button2_Click(object sender, EventArgs e)
        {
            if (player.playState == WMPLib.WMPPlayState.wmppsPlaying)
            {
                player.controls.pause();
            }
            else
            {
                player.controls.play();
            }
        }

        /*button de GRAN PREMIO MENU*/
        private void button7_Click(object sender, EventArgs e)
        {
            frmMenuGranPremio frmMenuEscuderia = new frmMenuGranPremio();
            frmMenuEscuderia.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            frmMenuGranPremio frmMenuEscuderia = new frmMenuGranPremio();
            frmMenuEscuderia.ShowDialog();
        }

        /*Button de ESCUDERIA MENU*/
        private void button6_Click(object sender, EventArgs e)
        {
            frmMenuEscuderias frmMenuGranPremio = new frmMenuEscuderias();
            frmMenuGranPremio.ShowDialog();
        }
        private void button4_Click(object sender, EventArgs e)
        {
            frmMenuEscuderias frmMenuGranPremio = new frmMenuEscuderias();
            frmMenuGranPremio.ShowDialog();
        }

        /*Resultados de Temporada = Mundial corredores y Mundial Constructores*/
        private void button8_Click(object sender, EventArgs e)
        {
            frmTemporada frmTemporada = new frmTemporada();
            frmTemporada.ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            frmDatosMonoplaza frmDatosMonoplaza = new frmDatosMonoplaza();
            frmDatosMonoplaza.ShowDialog();
        }
    }
}
