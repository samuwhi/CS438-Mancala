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
            board = new Board();
            player1Pockets = new Button[] { Pocket7, Pocket6, Pocket5, Pocket4, Pocket3, Pocket2, Pocket1 };
            player2Pockets = new Button[] { Pocket8, Pocket9, Pocket10, Pocket11, Pocket12, Pocket13, Pocket14 };
        }

        private void Update_Pockets()
        {
            for (int i = 0; i < player1Pockets.Length; i++)
            {
                player1Pockets[i].Text = board.gameState[0, i].ToString();
            }
            for (int i = 0; i < player2Pockets.Length; i++)
            {
                player2Pockets[i].Text = board.gameState[1, i].ToString();
            }
        }


        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Pocket1_Click(object sender, EventArgs e)
        {
            board.makeMove(6);
            Update_Pockets();
        }

        private void Pocket2_Click(object sender, EventArgs e)
        {
            board.makeMove(5);
        }

        private void Pocket3_Click(object sender, EventArgs e)
        {
            board.makeMove(4);
        }

        private void Pocket4_Click(object sender, EventArgs e)
        {
            board.makeMove(3);
        }

        private void Pocket5_Click(object sender, EventArgs e)
        {
            board.makeMove(2);
        }

        private void Pocket6_Click(object sender, EventArgs e)
        {
            board.makeMove(1);
        }

        private void Pocket7_Click(object sender, EventArgs e)
        {
            // This is player 1s Pit
        }

        private void Pocket8_Click(object sender, EventArgs e)
        {
            board.makeMove(1);
        }

        private void Pocket9_Click(object sender, EventArgs e)
        {
            board.makeMove(2);
        }

        private void Pocket10_Click(object sender, EventArgs e)
        {
            board.makeMove(3);
        }

        private void Pocket11_Click(object sender, EventArgs e)
        {
            board.makeMove(4);
        }

        private void Pocket12_Click(object sender, EventArgs e)
        {
            board.makeMove(5);
        }

        private void Pocket13_Click(object sender, EventArgs e)
        {
            board.makeMove(6);
        }

        private void Pocket14_Click(object sender, EventArgs e)
        {

        }

        private void Human1Button_Click(object sender, EventArgs e)
        {

        }

        private void Computer1Button_Click(object sender, EventArgs e)
        {

        }

        private void Player1ConsoleWindowCheck_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void Human2Button_Click(object sender, EventArgs e)
        {

        }

        private void Computer2Button_Click(object sender, EventArgs e)
        {

        }

        private void Player2ConsoleWindowCheck_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void StartButton_Click(object sender, EventArgs e)
        {

        }

        private void ResetButton_Click(object sender, EventArgs e)
        {

        }

        private void StepForwardButton_Click(object sender, EventArgs e)
        {

        }

        private void StepBackButton_Click(object sender, EventArgs e)
        {

        }
    }
}
