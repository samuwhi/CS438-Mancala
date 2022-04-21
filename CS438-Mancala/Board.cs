using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS438_Mancala
{
    public class Board
    {

        public int[,] gameState;
        public int playerTurn;

        public Board()
        {
            this.gameState = new int[,] { {0, 4, 4, 4, 4, 4, 4}, {4, 4, 4, 4, 4, 4, 0 } };
            this.playerTurn = 0;
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
