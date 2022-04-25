using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace MancalaAI
{
    internal class Communication
    {
        private const string MOVEFILE = "move.txt";
        private const string BOARDFILE = "board.txt";
        private bool getGameBoard(ref int[,] board)
        {
            using (StreamReader reader = new StreamReader(BOARDFILE))
            {
                board = 
            }

            return true;
        }

        public static bool putMove(int pocket)
        {
            if (File.Exists(MOVEFILE))
            {
                File.Delete(MOVEFILE);
            }
            File.create(MOVEFILE)
            using (StreamWriter writer = new StreamWriter(MOVEFILE))
            {
                writer.WriteLine(pocket);
            }
            return true;
        }
    }
}
