using OnePlayerTicTacToe;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Charles_Assignment9
{
    internal class HumanPlayer : Player
    {
        public override int MakeMove(Board gameBoard, int position, HumanPlayer aPlayer)
        {
            return position;
        }
    }
}
