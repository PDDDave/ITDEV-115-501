using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using Charles_Assignment9;

namespace OnePlayerTicTacToe
{
    abstract class Player
    {
        BitArray pieces;

        public Player()
        {
            pieces = new BitArray(9, false);
        }

        public BitArray Pieces
        {
            get
            {
                return pieces;
            }
        }

        public abstract int MakeMove(Board gameBoard, int position, HumanPlayer aPlayer);





    }
}
