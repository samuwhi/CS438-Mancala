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
    public partial class MancalaGUI : Form
    {
        public Board board;
        public Button[] player1Pockets;
        public Button[] player2Pockets;
        public MancalaGUI()
        {
            InitializeComponent();
            this.board = new Board();
            this.player1Pockets = new Button[] { Pocket7, Pocket6, Pocket5, Pocket4, Pocket3, Pocket2, Pocket1 };
            this.player2Pockets = new Button[] { Pocket8, Pocket9, Pocket10, Pocket11, Pocket12, Pocket13, Pocket14 };
        }

        private void Update_Pockets()
        {
            for (int i = 0; i < this.player1Pockets.Length; i++)
            {
                this.player1Pockets[i].Text = this.board.gameState[0, i].ToString();
            }
            for (int i = 0; i < this.player2Pockets.Length; i++)
            {
                this.player2Pockets[i].Text = this.board.gameState[1, i].ToString();
            }
        }


        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Pocket1_Click(object sender, EventArgs e)
        {
            Update_Pockets();
        }

        private void Pocket2_Click(object sender, EventArgs e)
        {

        }

        private void Pocket3_Click(object sender, EventArgs e)
        {

        }

        private void Pocket4_Click(object sender, EventArgs e)
        {

        }

        private void Pocket5_Click(object sender, EventArgs e)
        {

        }

        private void Pocket6_Click(object sender, EventArgs e)
        {

        }

        private void Pocket7_Click(object sender, EventArgs e)
        {

        }

        private void Pocket8_Click(object sender, EventArgs e)
        {

        }

        private void Pocket9_Click(object sender, EventArgs e)
        {

        }

        private void Pocket10_Click(object sender, EventArgs e)
        {

        }

        private void Pocket11_Click(object sender, EventArgs e)
        {

        }

        private void Pocket12_Click(object sender, EventArgs e)
        {

        }

        private void Pocket14_Click(object sender, EventArgs e)
        {

        }
    }
}
