using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace CS438_Mancala
{
    public class Board
    {
        private const string LOGFILENAME = "Mancala Log.txt";
        private const string BOARDFILENAME = "Board.txt";

        public int sv = 1;
        public int[,] gameState;
        public int playerTurn;
        public bool gameEnd = false;

        public Board()
        {
            gameState = new int[,] {   {0, sv, sv, sv, sv, sv, sv}, 
                                            {sv, sv, sv, sv, sv, sv, 0 } };
            playerTurn = 0;

            // Create new log file
            if (File.Exists(LOGFILENAME))
            {
                File.Delete(LOGFILENAME);
            }
            var outFile = File.CreateText(LOGFILENAME);
            outFile.Close();
        }

        public void Print_Current_Board(string path)
        {
            if (File.Exists(BOARDFILENAME))
            {
                File.Delete(BOARDFILENAME);
            }

            StreamWriter moveFile = File.CreateText(BOARDFILENAME);

            string line1 = "";
            string line2 = "";
            string line3 = "";

            for (int i = 0; i < gameState.GetLength(1); ++i)
            {
                line1 += gameState[0, i].ToString();
            }

            for (int i = 0; i < gameState.GetLength(1); ++i)
            {
                line2 += gameState[1, i].ToString();
            }

            line3 = playerTurn.ToString();

            moveFile.WriteLine(line1);
            moveFile.WriteLine(line2);
            moveFile.WriteLine(line3);

            moveFile.Close();
        }

        public void Log_Move(int pocket)
        {
            string move;

            move = playerTurn.ToString() + " " + pocket.ToString();

            using (StreamWriter sw = File.AppendText(LOGFILENAME))
            {
                sw.WriteLine(move);
            }
        }

        private void changeTurn()
        {
            if (playerTurn == 0)
            {
                playerTurn = 1;
            } else
            {
                playerTurn = 0;
            }
        }

        private bool emptyBoard()
        {
            int sum = 0;
            int finalStones = 0;
            bool boardEmptied = false;

            for (int i = 1; i < gameState.GetLength(1); i++)
            {
                sum += gameState[0, i];
            }
            if (sum == 0)
            {
                boardEmptied = true;
                for (int i = 0; i < gameState.GetLength(1) - 1; i++)
                {
                    finalStones += gameState[1, i];
                    gameState[1, i] = 0;
                }
                gameState[1, 6] += finalStones;
            }

            finalStones = 0;
            sum = 0;
            for (int i = 0; i < gameState.GetLength(1) - 1; i++)
            {
                sum += gameState[1, i];
            }
            if (sum == 0)
            {
                boardEmptied = true;
                for (int i = 1; i < gameState.GetLength(1); i++)
                {
                    finalStones += gameState[0, i];
                    gameState[0, i] = 0;
                }
                gameState[0, 0] += finalStones;
            }
            
            return boardEmptied;
        }

        public void makeMove(int pocket)
        {
            if (playerTurn == 1) {
                pocket--;
            }

            int stones = gameState[playerTurn, pocket];
            int row = playerTurn;
            int col = pocket;
            bool goAgain = false;

            if (stones == 0)    //checks to see if player clicks pocket with no stones. If so, returns.
            {
                return;
            }

            gameState[playerTurn, pocket] = 0;
            for(int i = 0; i < stones; i++) {
                if (playerTurn == 0) {
                    if (col == 5 && row == 1) {
                        row--;
                        col++;
                    } else if (col == 0 && row == 0) 
                        row++;
                    else if (row == 0)
                        col--;
                    else if (row == 1)
                        col++;

                    gameState[row, col] += 1;

                    //Check to see if the player landed on their own space to steal the other players adjacent pieces;
                    if (col != 0 && gameState[row, col] == 1 && gameState[1, col - 1] > 0 && i == stones - 1)
                    {
                        gameState[row, 0] += gameState[1, col - 1];
                        gameState[1, col - 1] = 0;
                        gameState[row, 0] += gameState[row, col];
                        gameState[row, col]--;
                    }

                    goAgain = ((col == 0 && row == 0) ? true : false);
                }

                if (playerTurn == 1) {
                    if (col == 1 && row == 0) {
                        row++;
                        col--;
                    } else if (col == 6 && row == 1)
                        row--;
                    else if (row == 1)
                        col++;
                    else if (row == 0)
                        col--;

                    gameState[row, col] += 1;

                    //Check to see if the player landed on their own space to steal the other players adjacent pieces;
                    if (col != 6 && gameState[row, col] == 1 && gameState[0, col + 1] > 0 && i == stones - 1)
                    {
                        gameState[row, 6] += gameState[0, col + 1];
                        gameState[0, col + 1] = 0;
                        gameState[row, 6] += gameState[row, col];
                        gameState[row, col]--;
                    }

                    goAgain = ((col == 6 && row == 1) ? true : false);
                } // If
            } // For

            if (emptyBoard())
            {
                gameEnd = true;
            }

            if (!goAgain) {
                changeTurn();
            }
        }
    }
}
