using OnePlayerTicTacToe;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace Charles_Assignment9
{
    internal class ComputerPlayer : Player
    {

        int[] logicNums = new int[] { 4, 0, 2, 6, 8, 1, 3, 5, 7 };
        int[,] zeroWinCombos = new int[,] { { 1, 2 }, { 3, 6 }, { 4, 8 } };
        int[,] oneWinCombos = new int[,] { { 0, 2 }, { 4, 7 } };
        int[,] twoWinCombos = new int[,] { { 5, 8 }, { 1, 0 }, { 4, 6 } };
        int[,] threeWinCombos = new int[,] { { 4, 5 }, { 0, 6 } };
        int[,] fourWinCombos = new int[,] { { 3, 5 }, { 1, 7 }, { 0, 8 } };
        int[,] fiveWinCombos = new int[,] { { 3, 4 }, { 2, 8 } };
        int[,] sixWinCombos = new int[,] { { 7, 8 }, { 0, 3 }, { 2, 4 } };
        int[,] sevenWinCombos = new int[,] { { 6, 8 }, { 1, 4 } };
        int[,] eightWinCombos = new int[,] { { 6, 7 }, { 2, 5 }, { 4, 0 } };

        const int FLAG = 999;

        int selection;

        
        public override int MakeMove(Board gameBoard, int position, HumanPlayer aPlayer)
        {
            BitArray humanMoves = aPlayer.Pieces;
            selection = FLAG;
            

            selection = EvalHuman(humanMoves,gameBoard);

            if (selection == FLAG) {
                selection = BestMove(gameBoard);
                //selection = EvalPC(gameBoard);
            }



            return selection;
        }

        private int BestMove(Board gameBoard)
        {
            int[] possibleMoves = new int[] { 4, 0, 2, 6, 8, 1, 3, 5, 7};
            int choice = 0;

            for (int i = 0; i < possibleMoves.Length; i++) {

                if ( gameBoard.OpenPositions.Contains(possibleMoves[i]) ) {
                    choice = possibleMoves[i];
                    break;
                }
            }

            return choice;

        }

        private int EvalHuman(BitArray humanMoves, Board gameboard) {
            //check if computer wins, if so make that move
            //need to gather the moves that the player has made and then test to see if the winning combinations are inside.

            //check zero win combos {0}
            if (humanMoves[0])
            {
                selection = PrimeCheck(gameboard, humanMoves, zeroWinCombos);

                /*
                 //check {0, 1, 2}
                 selection = SubCheck(gameBoard,humanMoves,1,2);

                if (selection == FLAG) {
                    //if no move was made, check the next 0 win combination {0,3,6}
                    selection = SubCheck(gameBoard, humanMoves, 3,6);
                }

                if (selection == FLAG)
                {
                    //{0, 4, 8}
                    selection = SubCheck(gameBoard, humanMoves, 4, 8);
                } */

            }

            if (selection == FLAG)
            {
                //if no move was made, move onto next win combo sequence

                if (humanMoves[1])
                {

                    selection = PrimeCheck(gameboard, humanMoves, oneWinCombos);
                }

            }

            if (selection == FLAG)
            {
                //if no move was made, move onto next win combo sequence

                if (humanMoves[2])
                {

                    selection = PrimeCheck(gameboard, humanMoves, twoWinCombos);
                }

            }

            if (selection == FLAG)
            {
                //if no move was made, move onto next win combo sequence

                if (humanMoves[3])
                {

                    selection = PrimeCheck(gameboard, humanMoves, threeWinCombos);
                }

            }

            if (selection == FLAG)
            {
                //if no move was made, move onto next win combo sequence

                if (humanMoves[4])
                {

                    selection = PrimeCheck(gameboard, humanMoves, fourWinCombos);
                }

            }

            if (selection == FLAG)
            {
                //if no move was made, move onto next win combo sequence

                if (humanMoves[5])
                {

                    selection = PrimeCheck(gameboard, humanMoves, fiveWinCombos);
                }

            }

            if (selection == FLAG)
            {
                //if no move was made, move onto next win combo sequence

                if (humanMoves[6])
                {

                    selection = PrimeCheck(gameboard, humanMoves, sixWinCombos);
                }

            }

            if (selection == FLAG)
            {
                //if no move was made, move onto next win combo sequence

                if (humanMoves[7])
                {

                    selection = PrimeCheck(gameboard, humanMoves, sevenWinCombos);
                }

            }

            if (selection == FLAG)
            {
                //if no move was made, move onto next win combo sequence

                if (humanMoves[8])
                {

                    selection = PrimeCheck(gameboard, humanMoves, eightWinCombos);
                }

            }

            //check if human wins, if so  make move to block

            //else chose first available number from arr of nums

            return selection;
        }

        private int PrimeCheck(Board board,BitArray moves, int[,] winCombos) {
            int choice = 0;

            for (int i = 0; i < winCombos.GetLength(0); i++) {

                choice = SubCheck(board, moves, winCombos[i, 0], winCombos[i, 1]);

                if (choice != FLAG) {

                    return choice;
                }
            }

            return choice;
        }

        private int SubCheck(Board board, BitArray moves, int sqrPos1, int sqrPos2 ) {
            int choice = FLAG;

            if (moves[sqrPos1])
            {
                if (board.OpenPositions.Contains(sqrPos2))
                {
                    choice = sqrPos2;
                    return choice;
                }
            }
           
            if (moves[sqrPos2])
            {
                if (board.OpenPositions.Contains(sqrPos1))
                {
                    choice = sqrPos1;
                    return choice;
                }
            }

            return choice;
        }
    }
}
