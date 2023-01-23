using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace novasnov
{
    internal class Game
    {
        public int Player1Score { get; set; }
        public int Player2Score { get; set; }
        public int Player1State{get; set;}
        public int Player2State{ get; set; }
        public static int Player1HighScore { get; set; }
        public static int Player2HighScore { get; set; }

        public void Play()
        {
            Player1State = HelperClass.GetState();
            Player2State = HelperClass.GetState();

            if (Player1State == Player2State)
            {
                //draw
            }
            else if (Player1State == 0 && Player2State == 1)
            {
                Player1Score++;
            }
            else if (Player1State==0 && Player2State == 2)
            {
                Player2Score++;
            }
            else if (Player1State == 1 && Player2State == 0)
            {
                Player2Score++;
            }
            else if (Player1State == 1 && Player2State == 2)
            {
                Player1Score++;
            }
            else if (Player1State == 2 && Player2State == 0)
            {
                Player2Score++;
            }
            else if (Player1State == 2 && Player2State == 1)
            {
                Player1Score++;
            }
            if (Player1Score > Player1HighScore)
            {
                Player1HighScore = Player1Score;
            }
            else if (Player2Score > Player2HighScore)
            {
                Player2HighScore = Player2Score;
            }
        }
    }
}
