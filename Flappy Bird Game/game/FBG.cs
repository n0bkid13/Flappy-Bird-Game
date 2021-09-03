using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace game
{
    public partial class FBG : Form
    {
        
        public FBG()
        {
            InitializeComponent();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Flappy_Birds flappyBirds = new Flappy_Birds();
            flappyBirds.ShowDialog();
        }

        private void btnQuitGame_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnHishScores_Click(object sender, EventArgs e)
        {
            Flappy_Birds flappyBirds = new Flappy_Birds();
            int highscore = flappyBirds.ReadHighScore();
            MessageBox.Show("The high score of the game is " + highscore);
        }
    }
}
