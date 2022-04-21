using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS438_Mancala
{
    public class Board
    {
        public int[] gameState;
        public int playerTurn;

        public Board()
        {
            this.gameState = new int[] { 4, 4, 4, 4, 4, 4, 0, 4, 4, 4, 4, 4, 4, 0 };
            this.playerTurn = 1;
        }

        private int getIndex(int pocket)
        {
            int index;

            if (playerTurn == 1)
            {
                index = pocket - 1;
            }
            else
            {
                index = pocket + 6;
            }

            return index;
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
