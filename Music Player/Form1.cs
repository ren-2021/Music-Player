using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Music_Player
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            openFileDialog1.FileName = "";
            openFileDialog1.Filter = "mp4 files (*.mp4)|*.mp4|mp3 files (*.mp3)|*.mp3| avi files (*.avi)|*.avi|All files (*.*)|*.*";

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                textBox1.Text = openFileDialog1.FileName;
            }
            Player.URL = textBox1.Text;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if(Player.playState == WMPLib.WMPPlayState.wmppsPlaying)
            {
                Player.Ctlcontrols.pause();
                button2.Text = "Play";
                button2.Enabled = true;
            }
            else if(Player.playState == WMPLib.WMPPlayState.wmppsPaused)
            {
                Player.Ctlcontrols.play();
                button2.Text = "Pause";
                button2.Enabled = true;
            }
            else
            {
                button2.Enabled = false;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Player.Ctlcontrols.stop();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
