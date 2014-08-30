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
            InitNineButtons();
            InitGame();
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
        }

        private void InitGame()
        {
            thisGame = new Game();
        }

        private void button_Click(object sender, EventArgs e)
        {
            ShowAClick(sender);

            thisGame.TansPlayer();
            thisGame.GameIsEnd(nineButtons);
        }

        private void ShowAClick(object sender)
        {
            Button clickedButton = (Button)sender;
            string showedText = GetShowedText();
            clickedButton.Text = showedText;
        }

        private string GetShowedText()
        {
            string showedText;

            if (thisGame.currentPlayer == Game.name.player1)
            {
                showedText = "黑";
            }
            else
            {
                showedText = "白";
            }
            return showedText;
        }
    }
}
