using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace novasnov
{
    public partial class Form1 : Form
    {
        Game game = new Game();
        
        public Form1()
        {
            InitializeComponent();
            label1.Text ="Player 1 score: "+game.Player1Score.ToString();
            label2.Text ="Player 2 score: "+game.Player2Score.ToString();
            label3.Text ="Player 1 highscore: "+Game.Player1HighScore.ToString();
            label4.Text ="Player 2 highscore: "+Game.Player2HighScore.ToString();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            game.Play();
            label1.Text = game.Player1Score.ToString();
            label2.Text = game.Player2Score.ToString();
            label3.Text = Game.Player1HighScore.ToString();
            label4.Text = Game.Player2HighScore.ToString();
            if (game.Player1State==0)
            {
                pictureBox1.Image = Image.FromFile("rock1.paper");
            }
        }
    }
}
