using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace FloppyBird
{
    public partial class MainMenu : Form
    {
        public MainMenu()
        {
            InitializeComponent();
        }

        private void StartIcon_Click(object sender, EventArgs e)
        {
            FloppyBird gamewindow = new FloppyBird();

            gamewindow.Show();

        }

        private void ControlsIcon_Click(object sender, EventArgs e)
        {
            ImagenControles.Visible = true;
            
        }

        private void ExitIcon_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Credits_Click(object sender, EventArgs e)
        {
            
        }

        private void MainMenu_Load(object sender, EventArgs e)
        {
            
        }

        private void tiempoRGB_Tick(object sender, EventArgs e)
        {
            Random rand = new Random();
            int A = rand.Next(0, 255);
            int R = rand.Next(0, 255);
            int G = rand.Next(0, 255);
            int B = rand.Next(0, 255);
            Credits.ForeColor = Color.FromArgb(A, R, G, B);
            tiempoRGB.Start();
        }
    }
}
