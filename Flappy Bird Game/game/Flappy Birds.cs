using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace game
{
    
    public partial class Flappy_Birds : Form
    {
        int pipeSpeed = 8; // Brzina na dvizenje na pipes
        int gravity = 5;
        int score = 0;
        string pts = "0";
        public Flappy_Birds()
        {
            InitializeComponent();
            

        }

        private void Flappy_Birds_Load(object sender, EventArgs e)
        {

        }
        private void GameTimerEvent(object sender, EventArgs e)
        {
            FlappyBird.Top += gravity; // Flappy Bird pozicija
            pipeBottom.Left -= pipeSpeed; // Bottom Pipe pozicija
            pipeTop.Left -= pipeSpeed; // Top Pipe pozicija
            ScoreText.Text = "Score : " + score;

            if (pipeBottom.Left < -50)
            {

                pipeBottom.Left = 500;

                score++;

            }
            
            if (pipeTop.Left < -80)
            {

                pipeTop.Left = 600;

                score++;
            }
            if (FlappyBird.Bounds.IntersectsWith(pipeBottom.Bounds) ||
                FlappyBird.Bounds.IntersectsWith(pipeTop.Bounds) ||
                FlappyBird.Bounds.IntersectsWith(ground.Bounds) ||
                FlappyBird.Top < -25)
            {
                
                EndGame();
                this.Close();
            }

        }

        private void GameKeyDown(object sender, KeyEventArgs e)
        {

            if (e.KeyCode == Keys.Space)
            {

                gravity = -15;

            }

        }

        private void GameKeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space) {

                gravity = +15;
            
            }
        }
        private void EndGame()
        {

            GameTimer.Stop();
            MessageBox.Show("You lose!!!");
            WriteHighScore();

        }
        public int ReadHighScore() {

            if (!File.Exists("highscore.txt")) {

                TextWriter tw = new StreamWriter("highscore.txt");
                tw.Write("0");
                tw.Close();
            
            }
            TextReader tr = new StreamReader("highscore.txt");
            pts = tr.ReadLine();
            tr.Close();
            return Int32.Parse(pts);

        
        }
        private void WriteHighScore() {


        
        }
    }
}
