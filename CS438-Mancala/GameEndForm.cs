using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CS438_Mancala
{
    public partial class GameEndForm : Form
    {
        public GameEndForm(int score1, int score2)
        {
            InitializeComponent();

            if (score1 > score2)
            {
                string text = "Player One won with a score of " + score1 + "!\n";
                GameOverText.Text = text;
            }
            else if (score1 < score2)
            {
                string text = "Player Two won with a score of " + score2 + "!\n";
                GameOverText.Text = text;
            }
            else
            {
                string text = "Player One and Two tied with a score of " + score1 + "!\n";
                GameOverText.Text = text;
            }
        }
    }
}
