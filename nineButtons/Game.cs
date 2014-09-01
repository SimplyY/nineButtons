using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nineButtons
{
    class Game
    {
        public bool gameIsEnd;

        public Game()
        {
            gameIsEnd = false;
            currentPlayer = playerName.white;
        }

        //about currentPlayer
        public enum playerName
        {
            white,
            black,
        }

        public playerName currentPlayer;

        public void TansPlayer()
        {
            if (currentPlayer == playerName.white)
            {
                currentPlayer = playerName.black;
            }
            else
            {
                currentPlayer = playerName.white;
            }
        }

        //judge whether has a player's buttons in a line
        public void GameIsEnd(System.Windows.Forms.Button[,] nineButtons, Form1 thisForm)
        {

            if (whetherHasButtonsInALine(nineButtons))
            {
                StopGame(thisForm);
            }
        }

        private bool whetherHasButtonsInALine(System.Windows.Forms.Button[,] nineButtons)
        {
            bool whetherHasButtonsInALine = false;

            bool inARow = WhetherButtonsInARow(nineButtons);
            bool inAColumn = WhetherButtonsInAColumn(nineButtons);
            bool inADiagonal = WhetherButtonsInADiagonal(nineButtons);

            whetherHasButtonsInALine = inARow || inAColumn || inADiagonal;

            return whetherHasButtonsInALine;
        }

        private bool WhetherButtonsInARow(System.Windows.Forms.Button[,] nineButtons)
        {
            bool isInALine = false;
            string lastedPlayerButtonText = GetlastedPlayerButtonText();
            for (int i = 0; i < 3; i++)
			{
                int rowIndex = i;
                int buttonsNumberInTheRow = 0;
                for (int j = 0; j < 3; j++)
                {
                    if (nineButtons[rowIndex, j].Text == lastedPlayerButtonText)
                    {
                        ++buttonsNumberInTheRow;
                    }
                }

                if (buttonsNumberInTheRow == 3)
                {
                    isInALine = true;
                    break;
                }
			}
            return isInALine;
        }

        private bool WhetherButtonsInAColumn(System.Windows.Forms.Button[,] nineButtons)
        {
            bool isInALine = false;
            string lastedPlayerButtonText = GetlastedPlayerButtonText();
            for (int i = 0; i < 3; i++)
            {
                int columnIndex = i;
                int buttonsNumberInTheColumn = 0;
                for (int j = 0; j < 3; j++)
                {
                    if (nineButtons[j, columnIndex].Text == lastedPlayerButtonText)
                    {
                        ++buttonsNumberInTheColumn;
                    }
                }
                if (buttonsNumberInTheColumn == 3)
                {
                    isInALine = true;
                    break;
                }
            }
            return isInALine;

        }

        private bool WhetherButtonsInADiagonal(System.Windows.Forms.Button[,] nineButtons)
        {
            bool isInALine = false;
            string lastedPlayerButtonText = GetlastedPlayerButtonText();
            for (int i = 0; i < 3; i++)
            {
                int columnIndex = i;
                int buttonsNumberInTheDiagonal1 = 0;
                int buttonsNumberInTheDiagonal2 = 0;
                for (int j = 0; j < 3; j++)
                {
                    if (nineButtons[i, i].Text == lastedPlayerButtonText)
                    {
                        ++buttonsNumberInTheDiagonal1;
                    }
                    if (nineButtons[j, 3 - i].Text == lastedPlayerButtonText)
                    {
                        ++buttonsNumberInTheDiagonal2;
                    }
                }

                if (buttonsNumberInTheDiagonal1 == 3||buttonsNumberInTheDiagonal2 == 3)
                {
                    isInALine = true;
                    break;
                }
            }
            return isInALine;
        }



        private string GetlastedPlayerButtonText()
        {
            string lastedPlayerButtonText = "";
            if (currentPlayer == playerName.white)
            {
                lastedPlayerButtonText = "白";
            }
            else
            {
                lastedPlayerButtonText = "黑";
            }

            return lastedPlayerButtonText;
        }

        private void StopGame(Form1 thisForm)
        {
            gameIsEnd = true;

            string status = GetlastedPlayerButtonText() + "方获得胜利";
            thisForm.setStatusBox(status);
        }
    }
}
