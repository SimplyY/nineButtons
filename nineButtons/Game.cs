using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nineButtons
{
    class Game
    {

        public Game()
        {
            currentPlayer = name.player1;
        }

        //about currentPlayer
        public enum name
        {
            player1,
            player2,
        }

        public name currentPlayer;

        public void TansPlayer()
        {
            if (currentPlayer == name.player1)
            {
                currentPlayer = name.player2;
            }
            else
            {
                currentPlayer = name.player1;
            }
        }

        public void GameIsEnd(System.Windows.Forms.Button[,] nineButtons)
        {
        
        }

        private void StopGame()
        {
 
        }
    }
}
