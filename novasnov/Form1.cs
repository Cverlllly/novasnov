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
            label1.Text = "Player 1 score: " + game.Player1Score.ToString();
            label2.Text = "Player 2 score: " + game.Player2Score.ToString();
            label3.Text = "Player 1 highscore: " + Game.Player1HighScore.ToString();
            label4.Text = "Player 2 highscore: " + Game.Player2HighScore.ToString();
            pictureBox1.LoadAsync(game.Player1State.ToString() + ".png");
            pictureBox2.LoadAsync(game.Player2State.ToString() + ".png");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            game.Player1Score = 0;
            game.Player2Score = 0;
            label1.Text = "Player 1 score: " + game.Player1Score.ToString();
            label2.Text = "Player 2 score: " + game.Player2Score.ToString();
        }
    }
}
