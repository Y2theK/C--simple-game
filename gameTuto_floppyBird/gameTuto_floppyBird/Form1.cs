using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace gameTuto_floppyBird
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            btnRestart.Visible = false;   
        }
        int pipeSpeed = 8;
        int gravity = 10;
        int score = 0;

        private void gameTimerEvent(object sender, EventArgs e)
        {
            gameTimer.Stop();
            gameTimer.Start();
            pBfloppyBird.Top += gravity;
            pBpipeBottom.Left -= pipeSpeed;
            pBpipeTop.Left -= pipeSpeed;
            lbScore.Text = "Score = " + score.ToString();
            
            if(pBpipeBottom.Left <-50)
            {
                pBpipeBottom.Left = 800;
                score++;
            }
            if(pBpipeTop.Left < -50)
            {
                pBpipeTop.Left = 950;
                score++;
            }
            if(pBfloppyBird.Bounds.IntersectsWith(pBpipeBottom.Bounds) 
                || pBfloppyBird.Bounds.IntersectsWith(pBpipeTop.Bounds)
                || pBfloppyBird.Bounds.IntersectsWith(pBGround.Bounds))
            {
                endGame();
            }
            if (score > 5)
            {
                pipeSpeed = 20;
            }
            if (pBfloppyBird.Top < -20)
            {
                endGame();
            }
        }

        private void gameKeyisDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Space)
            {
                gravity = -7;
            }
        }

        private void gameKeyisUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space)
            {
                gravity = 7;
            }
        }
        private void endGame()
        {
            gameTimer.Stop();
            lbScore.Text += "  Game Over!!!";
            btnRestart.Visible = true;
              

        }

        private void btnRestart_Click(object sender, EventArgs e)
        {
            score = 0;
            pipeSpeed = 8;
            pBfloppyBird.Left = 42;
            pBfloppyBird.Top = 12;

            pBpipeTop.Top = 12;
            pBpipeTop.Left = 800;

            pBpipeBottom.Top = 313;
            pBpipeBottom.Left = 950;
            gameTimerEvent(sender,e);

            
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        
      
    }
}
