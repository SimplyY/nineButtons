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
        public List<Button> nineButtons;

        public Form1()
        {
            InitializeComponent();
            InitNineButtons();
            InitGame();
        }

        private void InitNineButtons()
        {
            nineButtons.Add(button1);
            nineButtons.Add(button2);
            nineButtons.Add(button3);
            nineButtons.Add(button4);
            nineButtons.Add(button5);
            nineButtons.Add(button6);
            nineButtons.Add(button7);
            nineButtons.Add(button8);
            nineButtons.Add(button9);
        }

        private void InitGame()
        {
            thisGame = new Game();
        }

        private void button_Click(object sender, EventArgs e)
        {
            ShowAClick(sender);

            thisGame.TansPlayer();
            thisGame.GameIsEnd();
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
