using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace AI
{
    internal class Communication
    {
        private const string MOVEFILE = "move.txt";
        private const string BOARDFILE = "Board.txt";
        public static bool getGameBoard(ref int[,] board, ref int turn)
        {
            string[] row;
            string[] row2;
            using (StreamReader reader = new StreamReader(BOARDFILE))
            {
                row = reader.ReadLine().Split(' ');
                row2 = reader.ReadLine().Split(' ');
                for (int i = 0; i < row.Length - 1; i++)
                {
                    board[0, i] = Convert.ToInt32(row[i]);
                    board[1, i] = Convert.ToInt32(row2[i]);
                }

                turn = Convert.ToInt32(reader.ReadLine());
                
            }

            return true;
        }

        public static bool putMove(int pocket)
        {
            if (File.Exists(MOVEFILE))
            {
                File.Delete(MOVEFILE);
            }
            StreamWriter writer = File.CreateText(MOVEFILE);
            writer.WriteLine(pocket);

            writer.Close();
            
            System.Environment.Exit(0);
            return true;
        }
    }
}
