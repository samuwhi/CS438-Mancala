using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AI
{
    internal class FirstLegalMove
    {

        private static bool Legal(int[,] board, int turn, int move)
        {
            int tmp;
            if (move < 1 || move > 6)
            {
                return false;
            }
            if (turn == 0)
            {
                tmp = 7 - move;
                if (board[turn, tmp] == 0)
                {
                    return false;
                }
            } else
            {
                tmp = move - 1;
                if (board[turn, tmp] == 0)
                {
                    return false;
                }
            }
            return true;
        }
        static void Main(string[] args)
        {
            int[,] board = { { 1, 2, 3, 4, 5, 6, 7 }, { 1, 2, 3, 4, 5, 6, 7 } };
            int turn = 0;

            Communication.getGameBoard(ref board, ref turn);

            for (int i = 1; i < board.GetLength(1); i++)
            {
                if (Legal(board, turn, i)){
                    Communication.putMove(i);
                } else
                {
                    continue;
                }
            }
        }
    }
}
