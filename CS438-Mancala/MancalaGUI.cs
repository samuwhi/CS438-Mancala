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
        private int timeToWait = 1000000;

        public Board board;
        public Button[] player1Pockets;
        public Button[] player2Pockets;
        public bool player1human = true;
        public bool player2human = true;

        private bool console1WindowChecked = false;
        private bool console2WindowChecked = false;

        private Color board1Color = Color.MediumSpringGreen;
        private Color board1HoverColor = Color.MediumSeaGreen;
        private Color board2Color = Color.Salmon;
        private Color board2HoverColor = Color.IndianRed;

        private static string player1file = "";
        private static string player2file = "";

        private bool gameEndHasBeenHit = false;
        public MancalaGUI()
        {
            InitializeComponent();
            board = new Board();
            player1Pockets = new Button[] { Pocket7, Pocket6, Pocket5, Pocket4, Pocket3, Pocket2, Pocket1 };
            player2Pockets = new Button[] { Pocket8, Pocket9, Pocket10, Pocket11, Pocket12, Pocket13, Pocket14 };
            Update_Pockets();
            CurrentPlayerTurnButton.BackColor = Color.LightGray;
        }

        private void Get_Next_Turn()
        {
            Process process;
            string path;
            string file;
            int move;

            if ((board.playerTurn == 0 && player1human == false) || (board.playerTurn == 1 && player2human == false))
            {
                if (board.playerTurn == 0)
                {
                    file = player1file;
                } else
                {
                    file = player2file;
                }

                path = Path.GetDirectoryName(file);
                Directory.SetCurrentDirectory(path);
                
                // write out to text file
                board.Print_Current_Board(path);

                // run executable
                string filename = Path.GetFileName(file);
                ProcessStartInfo psi = new ProcessStartInfo();
                psi.FileName = filename;
                psi.CreateNoWindow = true;
                psi.WindowStyle = ProcessWindowStyle.Hidden;

                if (console1WindowChecked == true)
                {
                    psi.CreateNoWindow = false;
                    psi.WindowStyle = ProcessWindowStyle.Normal;
                }
                if (console2WindowChecked == true)
                {
                    psi.CreateNoWindow = false;
                    psi.WindowStyle = ProcessWindowStyle.Normal;
                }

                process = Process.Start(psi);
                process.WaitForExit();

                //                  Problem! This code below works for the timer but it causes the window pop up bug to happen again.

                //process = Process.Start(filename);
                //if (!process.WaitForExit(timeToWait))
                //{
                //    Timeout to = new Timeout();
                //    to.Show();
                //    System.Environment.Exit(1);
                //}

                // read from move file
                using (StreamReader sr = new StreamReader("move.txt"))
                {
                    string line = sr.ReadLine();
                    move = int.Parse(line);
                }

                // Don't have to handle player 2 adjustments because it's handled in makeMove
                if (board.playerTurn == 0)
                {
                    move = 7 - move;
                }

                board.makeMove(move);
                Update_Pockets();
            }
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

            if (board.gameEnd == true)
            {
                gameEndHasBeenHit = true;
                GameEndForm gameEndForm = new GameEndForm(board.gameState[0, 0], board.gameState[1, 6]);
                gameEndForm.Show();
                return;
            }
            if (board.illegalMoveMade == true)
            {
                IllegalMoveMadeForm illegalMoveMadeForm = new IllegalMoveMadeForm();
                illegalMoveMadeForm.Show();
                return;
            }

            //Change Turn Color
            if (board.playerTurn == 0)
            {
                CurrentPlayerTurnButton.BackColor = board1Color;
            }
            else
            {
                CurrentPlayerTurnButton.BackColor = board2Color;
            }

            Get_Next_Turn();
        }
        private bool Allow_Button(int turnToCheck, RoundButton Pocket)
        {
            if (Pocket.Text == "0")
            {
                return false;
            }

            if (!startButtonHasBeenPressed)
            {
                return false;
            }

            if (board.gameEnd == true)
            {
                return false;
            }

            if (gameEndHasBeenHit == true)
            {
                return false;
            }

            if (board.illegalMoveMade == true)
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
        private void Pocket1_Click_1(object sender, EventArgs e)
        {
            if (Allow_Button(0, Pocket1))
            {
                board.makeMove(6);
                board.Log_Move(6);
                Update_Pockets();
            }
        }
        private void Pocket1_Click(object sender, EventArgs e)
        {
            if (Allow_Button(0, Pocket1))
            {
                board.makeMove(6);
                board.Log_Move(6);
                Update_Pockets();
            }
        }
        private void Pocket1_MouseHover(object sender, EventArgs e)
        {
            Pocket1.BackColor = board1HoverColor;
        }
        private void Pocket1_MouseLeave(object sender, EventArgs e)
        {
            Pocket1.BackColor = board1Color;
        }
        private void Pocket2_Click(object sender, EventArgs e)
        {
            if (Allow_Button(0, Pocket2))
            {
                board.makeMove(5);
                board.Log_Move(5);
                Update_Pockets();
            }
        }
        private void Pocket2_MouseHover(object sender, EventArgs e)
        {
            Pocket2.BackColor = board1HoverColor;
        }
        private void Pocket2_MouseLeave(object sender, EventArgs e)
        {
            Pocket2.BackColor = board1Color;
        }
        private void Pocket3_Click(object sender, EventArgs e)
        {
            if (Allow_Button(0, Pocket3))
            {
                board.makeMove(4);
                board.Log_Move(4);
                Update_Pockets();
            }
        }
        private void Pocket3_MouseHover(object sender, EventArgs e)
        {
            Pocket3.BackColor = board1HoverColor;
        }
        private void Pocket3_MouseLeave(object sender, EventArgs e)
        {
            Pocket3.BackColor = board1Color;
        }
        private void Pocket4_Click(object sender, EventArgs e)
        {
            if (Allow_Button(0, Pocket4))
            {
                board.makeMove(3);
                board.Log_Move(3);
                Update_Pockets();
            }
        }
        private void Pocket4_MouseHover(object sender, EventArgs e)
        {
            Pocket4.BackColor = board1HoverColor;
        }
        private void Pocket4_MouseLeave(object sender, EventArgs e)
        {
            Pocket4.BackColor = board1Color;
        }
        private void Pocket5_Click(object sender, EventArgs e)
        {
            if (Allow_Button(0, Pocket5))
            {
                board.makeMove(2);
                board.Log_Move(2);
                Update_Pockets();
            }
        }
        private void Pocket5_MouseHover(object sender, EventArgs e)
        {
            Pocket5.BackColor = board1HoverColor;
        }
        private void Pocket5_MouseLeave(object sender, EventArgs e)
        {
            Pocket5.BackColor = board1Color;
        }
        private void Pocket6_Click(object sender, EventArgs e)
        {
            if (Allow_Button(0, Pocket6))
            {
                board.makeMove(1);
                board.Log_Move(1);
                Update_Pockets();
            }
        }
        private void Pocket6_MouseHover(object sender, EventArgs e)
        {
            Pocket6.BackColor = board1HoverColor;
        }
        private void Pocket6_MouseLeave(object sender, EventArgs e)
        {
            Pocket6.BackColor = board1Color;
        }
        private void Pocket7_Click(object sender, EventArgs e)
        {
            // This is player 1s Pit
        }
        private void Pocket8_Click(object sender, EventArgs e)
        {
            if (Allow_Button(1, Pocket8))
            {
                board.makeMove(1);
                board.Log_Move(1);
                Update_Pockets();
            }
        }
        private void Pocket8_MouseHover(object sender, EventArgs e)
        {
            Pocket8.BackColor = board2HoverColor;
        }
        private void Pocket8_MouseLeave(object sender, EventArgs e)
        {
            Pocket8.BackColor = board2Color;
        }
        private void Pocket9_Click(object sender, EventArgs e)
        {
            if (Allow_Button(1, Pocket9))
            {
                board.makeMove(2);
                board.Log_Move(2);
                Update_Pockets();
            }
        }
        private void Pocket9_MouseHover(object sender, EventArgs e)
        {
            Pocket9.BackColor = board2HoverColor;
        }
        private void Pocket9_MouseLeave(object sender, EventArgs e)
        {
            Pocket9.BackColor = board2Color;
        }
        private void Pocket10_Click(object sender, EventArgs e)
        {
            if (Allow_Button(1, Pocket10))
            {
                board.makeMove(3);
                board.Log_Move(3);
                Update_Pockets();
            }
        }
        private void Pocket10_MouseHover(object sender, EventArgs e)
        {
            Pocket10.BackColor = board2HoverColor;
        }
        private void Pocket10_MouseLeave(object sender, EventArgs e)
        {
            Pocket10.BackColor = board2Color;
        }
        private void Pocket11_Click(object sender, EventArgs e)
        {
            if (Allow_Button(1, Pocket11))
            {
                board.makeMove(4);
                board.Log_Move(4);
                Update_Pockets();
            }
        }
        private void Pocket11_MouseHover(object sender, EventArgs e)
        {
            Pocket11.BackColor = board2HoverColor;
        }
        private void Pocket11_MouseLeave(object sender, EventArgs e)
        {
            Pocket11.BackColor = board2Color;
        }
        private void Pocket12_Click(object sender, EventArgs e)
        {
            if (Allow_Button(1, Pocket12))
            {
                board.makeMove(5);
                board.Log_Move(5);
                Update_Pockets();
            }
        }
        private void Pocket12_MouseHover(object sender, EventArgs e)
        {
            Pocket12.BackColor = board2HoverColor;
        }
        private void Pocket12_MouseLeave(object sender, EventArgs e)
        {
            Pocket12.BackColor = board2Color;
        }
        private void Pocket13_Click(object sender, EventArgs e)
        {
            if (Allow_Button(1, Pocket13))
            {
                board.makeMove(6);
                board.Log_Move(6);
                Update_Pockets();
            }
        }
        private void Pocket13_MouseHover(object sender, EventArgs e)
        {
            Pocket13.BackColor = board2HoverColor;
        }
        private void Pocket13_MouseLeave(object sender, EventArgs e)
        {
            Pocket13.BackColor = board2Color;
        }
        private void Pocket14_Click(object sender, EventArgs e)
        {
            //This is player 2's pit
        }
        private void Human1Button_Click(object sender, EventArgs e)
        {
            HumanComputerLabel1.Text = "Human";
            player1file = "";
            player1human = true;
        }
        private void Computer1Button_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Exe Files (.exe)|*.exe|All Files (*.*)|*.*";

            DialogResult result = openFileDialog.ShowDialog();
            if (result == DialogResult.OK)
            {
                player1file = openFileDialog.FileName;
                HumanComputerLabel1.Text = player1file;
                player1human = false;
            }
        }
        private void Player1ConsoleWindowCheck_CheckedChanged(object sender, EventArgs e)
        {
            if (console1WindowChecked == false)
            {
                console1WindowChecked = true;
            }
            else
            {
                console1WindowChecked = false;
            }
        }
        private void Human2Button_Click(object sender, EventArgs e)
        {
            HumanComputerLabel2.Text = "Human";
            player2file = "";
            player2human = true;
        }
        private void Computer2Button_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Exe Files (.exe)|*.exe|Python Files (.py)|*.py|All Files (*.*)|*.*";

            DialogResult result = openFileDialog.ShowDialog();
            if (result == DialogResult.OK)
            {
                player2file = openFileDialog.FileName;
                HumanComputerLabel2.Text = player2file;
                player2human = false;
            }
        }
        private void Player2ConsoleWindowCheck_CheckedChanged(object sender, EventArgs e)
        {
            if (console2WindowChecked == false)
            {
                console2WindowChecked = true;
            }
            else
            {
                console2WindowChecked = false;
            }
        }
        private void StartButton_Click(object sender, EventArgs e)
        {
            startButtonHasBeenPressed = true;
            gameEndHasBeenHit = false;
            CurrentPlayerTurnButton.BackColor = board1Color;

            //This needs fixed, got to wait for whoevers turn to be over with before starting up.
            if (player1human == false)
            {
                Get_Next_Turn();
            }
        }
        private void ResetButton_Click(object sender, EventArgs e)
        {
            gameEndHasBeenHit = false;
            board = new Board();
            Update_Pockets();
            startButtonHasBeenPressed = false;
            CurrentPlayerTurnButton.BackColor = Color.LightGray;
        }
        private void StepForwardButton_Click(object sender, EventArgs e)
        {
            board.Step_Forward();
            Update_Pockets();
        }
        private void StepBackButton_Click(object sender, EventArgs e)
        {
            board.Step_Back();
            Update_Pockets();
        }

        private void TimeToWaitDropdown_SelectedIndexChanged(object sender, EventArgs e)
        {
            string waitTimeString = TimeToWaitDropdown.SelectedItem.ToString();

            if (waitTimeString == "5 seconds")
            {
                timeToWait = 5000;
            }
            else if (waitTimeString == "10 seconds")
            {
                timeToWait = 10000;
            }
            else if (waitTimeString == "20 seconds")
            {
                timeToWait = 20000;
            }
            else if (waitTimeString == "1 minute")
            {
                timeToWait = 60000;
            }
            else
            {
                timeToWait = 100000000;
            }
        }
    }
}
