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
        private bool getGameBoard(ref int[,] board)
        {
            return true;
        }

        public static bool putMove(int pocket)
        {
            using (StreamWriter writer = new StreamWriter(MOVEFILE))
            {
                writer.WriteLine(pocket);
            }
            return true;
        }
    }
}
