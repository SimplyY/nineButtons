using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace nineButtons
{
    public partial class Form1 : Form
    {
        private Game thisGame;
        public Button[,] nineButtons;

        public Form1()
        {
            InitializeComponent();

            InitGame();
        }

        private void InitGame()
        {
            InitStatusBox();
            InitNineButtons();

            thisGame = new Game();
        }

        private void InitStatusBox()
        {
            setStatusBox("白方的回合");
        }

        public void setStatusBox(string status)
        {
            statusBox.Text = status;
        }

        private void InitNineButtons()
        {
            nineButtons = new Button[3, 3];

            nineButtons[0, 0] = button1;
            nineButtons[0, 1] = button2;
            nineButtons[0, 2] = button3;
            nineButtons[1, 0] = button4;
            nineButtons[1, 1] = button5;
            nineButtons[1, 2] = button6;
            nineButtons[2, 0] = button7;
            nineButtons[2, 1] = button8;
            nineButtons[2, 2] = button9;
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    nineButtons[i, j].Enabled = true;
                    nineButtons[i, j].Text = "";
                }
            }
        }



        private void button_Click(object sender, EventArgs e)
        {
            if (thisGame.gameIsEnd != true)
            {
                ShowAClick(sender);
                Button clickedButton = (Button)sender;
                clickedButton.Enabled = false;
                thisGame.TansPlayer();
                thisGame.GameIsEnd(nineButtons, this);
            }
        }

        private void ShowAClick(object sender)
        {
            Button clickedButton = (Button)sender;
            string showedButtonText = GetShowedText();

            string showedStatusText = thisGame.GetlastedPlayerButtonText() + "方的回合";
            setStatusBox(showedStatusText);
            clickedButton.Text = showedButtonText;
        }

        private string GetShowedText()
        {
            string showedText;

            if (thisGame.currentPlayer == Game.playerName.white)
            {
                showedText = "白";
            }
            else
            {
                showedText = "黑";
            }
            return showedText;
        }

        private void ReinitGameButton_Click(object sender, EventArgs e)
        {
            InitGame();
        }
    }
}
