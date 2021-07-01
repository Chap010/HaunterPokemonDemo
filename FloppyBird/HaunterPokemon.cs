using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FloppyBird
{
    public partial class HaunterPokemon : Form
    {
        int pipavelocidad = 9;
        int gravedad = 10;
        int score = 0;
        public HaunterPokemon()
        {
            InitializeComponent();
        }

        private void PillarPic2_Click(object sender, EventArgs e)
        {

        }

        private void gameTimerEvent(object sender, EventArgs e)
        {
            MainCharacterPic.Top += gravedad;
            UpperPillar.Left -= pipavelocidad;
            BottomPillar.Left -= pipavelocidad;
            ScoreIcon.Text = " Score: " + score;
            //ScoreIcon.Text = (string)score.ToString();

            if (UpperPillar.Left < -100)
            {
                UpperPillar.Left = 800;
                score++;
            }
            if (BottomPillar.Left < -180)
            {
                BottomPillar.Left = 850;
                score++;
            }

            if (MainCharacterPic.Bounds.IntersectsWith(UpperPillar.Bounds) ||
                MainCharacterPic.Bounds.IntersectsWith(BottomPillar.Bounds) ||
                MainCharacterPic.Bounds.IntersectsWith(GroundIcon.Bounds) )
            {
                gameOver();
            }

            if (score > 7)
            {
                pipavelocidad = 15;
            }

            if(MainCharacterPic.Top < -25)
            {
                gameOver();
            }    
        }

        private void gamekeydown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space)
            {
                gravedad = -15;
            }
        }

        private void gamekeyup(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space)
            {
                gravedad = 15;
            }
        }
        private void gameOver()
        {
            GameTime.Stop();
            //OverGameICon.Text +=  " ";
            OverGameICon.Visible = true;
        }

        private void OverGameICon_Click(object sender, EventArgs e)
        {
           // OverGameICon.Visible = true;
        }
    }
}
