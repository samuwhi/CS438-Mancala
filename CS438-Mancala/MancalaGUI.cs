using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;
using System.Diagnostics;

namespace CS438_Mancala
{
    public partial class MancalaGUI : Form
    {
        public string fileName1 = "";
        public string fileName2 = "";

        private bool startButtonHasBeenPressed = false;

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
            //Make Move
            for (int i = 0; i < player1Pockets.Length; i++)
            {
                player1Pockets[i].Text = board.gameState[0, i].ToString();
            }
            for (int i = 0; i < player2Pockets.Length; i++)
            {
                player2Pockets[i].Text = board.gameState[1, i].ToString();
            }

            //Update Score
            Score1Text.Text = board.gameState[0, 0].ToString();
            Score2Text.Text = board.gameState[1, 6].ToString();

            //Change Turn Color
            if (board.playerTurn == 0)
            {
                CurrentPlayerTurnButton.BackColor = Color.SteelBlue;
            }
            else
            {
                CurrentPlayerTurnButton.BackColor = Color.OrangeRed;
            }
        }

        private bool Allow_Button(int turnToCheck)
        {
            if (!startButtonHasBeenPressed)
            {
                return false;
            }

            if (board.playerTurn == turnToCheck && HumanComputerLabel1.Text == "Human")
            {
                return true;
            }
            else if (board.playerTurn == turnToCheck && HumanComputerLabel2.Text == "Human")
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Pocket1_Click(object sender, EventArgs e)
        {
            if (Allow_Button(0))
            {
                board.makeMove(6);
                board.Log_Move(6);
                Update_Pockets();
            }
        }

        private void Pocket2_Click(object sender, EventArgs e)
        {
            if (Allow_Button(0))
            {
                board.makeMove(5);
                board.Log_Move(5);
                Update_Pockets();
            }
        }

        private void Pocket3_Click(object sender, EventArgs e)
        {
            if (Allow_Button(0))
            {
                board.makeMove(4);
                board.Log_Move(4);
                Update_Pockets();
            }
        }

        private void Pocket4_Click(object sender, EventArgs e)
        {
            if (Allow_Button(0))
            {
                board.makeMove(3);
                board.Log_Move(3);
                Update_Pockets();
            }
        }

        private void Pocket5_Click(object sender, EventArgs e)
        {
            if (Allow_Button(0))
            {
                board.makeMove(2);
                board.Log_Move(2);
                Update_Pockets();
            }
        }

        private void Pocket6_Click(object sender, EventArgs e)
        {
            if (Allow_Button(0))
            {
                board.makeMove(1);
                board.Log_Move(1);
                Update_Pockets();
            }
        }

        private void Pocket7_Click(object sender, EventArgs e)
        {
            // This is player 1s Pit
        }

        private void Pocket8_Click(object sender, EventArgs e)
        {
            if (Allow_Button(1))
            {
                board.makeMove(1);
                board.Log_Move(1);
                Update_Pockets();
            }
        }

        private void Pocket9_Click(object sender, EventArgs e)
        {
            if (Allow_Button(1))
            {
                board.makeMove(2);
                board.Log_Move(2);
                Update_Pockets();
            }
        }

        private void Pocket10_Click(object sender, EventArgs e)
        {
            if (Allow_Button(1))
            {
                board.makeMove(3);
                board.Log_Move(3);
                Update_Pockets();
            }
        }

        private void Pocket11_Click(object sender, EventArgs e)
        {
            if (Allow_Button(1))
            {
                board.makeMove(4);
                board.Log_Move(4);
                Update_Pockets();
            }
        }

        private void Pocket12_Click(object sender, EventArgs e)
        {
            if (Allow_Button(1))
            {
                board.makeMove(5);
                board.Log_Move(5);
                Update_Pockets();
            }
        }

        private void Pocket13_Click(object sender, EventArgs e)
        {
            if (Allow_Button(1))
            {
                board.makeMove(6);
                board.Log_Move(6);
                Update_Pockets();
            }
        }

        private void Pocket14_Click(object sender, EventArgs e)
        {
            //This is player 2's pit
        }

        private void Human1Button_Click(object sender, EventArgs e)
        {
            HumanComputerLabel1.Text = "Human";
        }

        private void Computer1Button_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Exe Files (.exe)|*.exe|All Files (*.*)|*.*";

            DialogResult result = openFileDialog.ShowDialog();
            if (result == DialogResult.OK)
            {
                fileName1 = openFileDialog.FileName;
                HumanComputerLabel1.Text = fileName1;
            }
        }

        private void Player1ConsoleWindowCheck_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void Human2Button_Click(object sender, EventArgs e)
        {
            HumanComputerLabel2.Text = "Human";
        }

        private void Computer2Button_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Exe Files (.exe)|*.exe|All Files (*.*)|*.*";

            DialogResult result = openFileDialog.ShowDialog();
            if (result == DialogResult.OK)
            {
                fileName2 = openFileDialog.FileName;
                HumanComputerLabel2.Text = fileName2;
            }
        }

        private void Player2ConsoleWindowCheck_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void StartButton_Click(object sender, EventArgs e)
        {
            startButtonHasBeenPressed = true;
            CurrentPlayerTurnButton.BackColor = Color.SteelBlue;

            //This needs fixed, got to wait for whoevers turn to be over with before starting up.
            if (fileName1 != "")
            {
                Process.Start(fileName1);
            }
            if (fileName2 != "")
            {
                Process.Start(fileName2);
            }
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
