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
            StreamWriter sw = File.CreateText(LOGFILENAME);
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
            

        }
    }



}
