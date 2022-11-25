using OnePlayerTicTacToe;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Charles_Assignment9
{
    internal class ComputerPlayer : Player
    {

        int[] logicNums = new int[] { 4, 0, 2, 6, 8, 1, 3, 5, 7 };
        public override int MakeMove(Board gameBoard, int position, HumanPlayer aPlayer)
        {
            BitArray humanMoves = aPlayer.Pieces;
            int selection = 0;
            //check if computer wins, if so make that move
            //need to gather the moves that the player has made and then test to see if the winning combinations are inside.

            //check zero win combos {0}
            if (humanMoves[0] == true)
            {
                //check {0,1,2}
                if (humanMoves[1] == true)
                {
                    if (gameBoard.OpenPositions.Contains(2))
                    {
                        selection = 2;
                    }
                }
                else if (humanMoves[2] == true)
                {
                    if (gameBoard.OpenPositions.Contains(1))
                    {
                        selection = 1;
                    }
                }
                //check {0,3,6}
                if (humanMoves[3] == true)
                {
                    if (gameBoard.OpenPositions.Contains(6))
                    {
                        selection = 6;
                    }
                }
                else if (humanMoves[6] == true)
                {
                    if (gameBoard.OpenPositions.Contains(3))
                    {
                        selection = 3;
                    }
                }
                //check {0,4,8}
                if (humanMoves[4] == true)
                {
                    if (gameBoard.OpenPositions.Contains(8))
                    {
                        selection = 8;
                    }
                }
                else if (humanMoves[4] == true)
                {
                    if (gameBoard.OpenPositions.Contains(8))
                    {
                        selection = 8;
                    }
                }
            }
                //check if human wins, if so  make move to block

                //else chose first available number from arr of nums

                return selection;
        }
    }
}
