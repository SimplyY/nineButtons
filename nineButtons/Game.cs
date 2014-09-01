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
            currentPlayer = playerName.player1;
        }

        //about currentPlayer
        public enum playerName
        {
            player1,
            player2,
        }

        public playerName currentPlayer;

        public void TansPlayer()
        {
            if (currentPlayer == playerName.player1)
            {
                currentPlayer = playerName.player2;
            }
            else
            {
                currentPlayer = playerName.player1;
            }
        }

        //judge whether has a player's buttons in a line
        public void GameIsEnd(System.Windows.Forms.Button[,] nineButtons)
        {
            bool whetherHasButtonsInALine = false;

            bool inARow = WhetherButtonsInARow(nineButtons);
            bool inAColumn = WhetherButtonsInAColumn(nineButtons);
            bool inADiagonal = WhetherButtonsInADiagonal(nineButtons);

            whetherHasButtonsInALine = inARow || inAColumn || inADiagonal;

            if (whetherHasButtonsInALine)
            {
                StopGame();
            }
        }

        private bool WhetherButtonsInARow(System.Windows.Forms.Button[,] nineButtons)
        {
            bool isInALine = false;
            string lastedPlayerButtonText = GetlastedPlayerButtonText();
            for (int i = 0; i < 3; i++)
			{
                int beginIndex = i * 3 - 1;

                isInALine = testALine(nineButtons, lastedPlayerButtonText, beginIndex, 1);
                if (isInALine == true)
                {
                    break;
                }
			}
            return isInALine;
        }

        private bool WhetherButtonsInAColumn(System.Windows.Forms.Button[,] nineButtons)
        {

        }

        private bool WhetherButtonsInADiagonal(System.Windows.Forms.Button[,] nineButtons)
        {

        }

        private bool testALine(System.Windows.Forms.Button[,] nineButtons, string lastedPlayerButtonText, int beginIndex, int indexInterval)
        {

        }

        private string GetlastedPlayerButtonText()
        {
            string lastedPlayerButtonText = "";
            if (currentPlayer == playerName.player1)
            {
                lastedPlayerButtonText = "白";
            }
            else
            {
                lastedPlayerButtonText = "黑";
            }

            return lastedPlayerButtonText;
        }

        private void StopGame()
        {
 
        }
    }
}
