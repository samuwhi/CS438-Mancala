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

        public int[,] gameState;
        public int playerTurn;

        public Board()
        {
            this.gameState = new int[,] { {0, 4, 4, 4, 4, 4, 4}, {4, 4, 4, 4, 4, 4, 0 } };
            this.playerTurn = 0;

            // Create new log file
            if (File.Exists(LOGFILENAME))
            {
                File.Delete(LOGFILENAME);
            }
            var outFile = File.CreateText(LOGFILENAME);
            outFile.Close();
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

        private bool isValid(int index)
        {
            return true;
        }

        public void makeMove(int pocket)
        {
            if (playerTurn == 1) {
                pocket--;
            }
            int stones = gameState[playerTurn, pocket];
            int row = playerTurn;
            int col = pocket;

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
                }
            }

        }
    }



}
