using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToeGame
{
    class Board
    {
        private char[,] board;

        public Board()
        {
            board = new char[3, 3];
            InitializeBoard();
        }

        private void InitializeBoard()
        {
            for (int row = 0; row < 3; row++)
            {
                for (int col = 0; col < 3; col++)
                {
                    board[row, col] = ' ';
                }
            }
        }

        public void PrintBoard()
        {
            Console.WriteLine(" 1 | 2 | 3 ");
            Console.WriteLine("---|---|---");
            Console.WriteLine(" 4 | 5 | 6 ");
            Console.WriteLine("---|---|---");
            Console.WriteLine(" 7 | 8 | 9 ");
            Console.WriteLine();
            for (int row = 0; row < 3; row++)
            {
                Console.WriteLine(" " + board[row, 0] + " | " + board[row, 1] + " | " + board[row, 2]);
                if (row < 2)
                {
                    Console.WriteLine("---|---|---");
                }
            }
        }

        public bool PlaceSymbol(int position, char symbol)
        {
            int row = (position - 1) / 3;
            int col = (position - 1) % 3;

            if (row < 0 || row > 2 || col < 0 || col > 2 || board[row, col] != ' ')
            {
                return false;
            }

            board[row, col] = symbol;
            return true;
        }

        public bool CheckWinner(char symbol)
        {
            for (int i = 0; i < 3; i++)
            {
                if (board[i, 0] == symbol && board[i, 1] == symbol && board[i, 2] == symbol)
                    return true;

                if (board[0, i] == symbol && board[1, i] == symbol && board[2, i] == symbol)
                    return true;
            }

            // Verificar diagonales
            if ((board[0, 0] == symbol && board[1, 1] == symbol && board[2, 2] == symbol) ||
                (board[0, 2] == symbol && board[1, 1] == symbol && board[2, 0] == symbol))
            {
                return true;
            }

            return false;
        }

        public bool IsBoardFull()
        {
            for (int row = 0; row < 3; row++)
            {
                for (int col = 0; col < 3; col++)
                {
                    if (board[row, col] == ' ')
                    {
                        return false;
                    }
                }
            }
            return true;
        }
    }
}
    
