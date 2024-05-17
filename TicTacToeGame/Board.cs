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

        // Inicializa el tablero con espacios en blanco
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

        // Método para imprimir el tablero
        public void PrintBoard()
        {
            for (int row = 0; row < 3; row++)
            {
                Console.WriteLine(" " + board[row, 0] + " | " + board[row, 1] + " | " + board[row, 2]);
                if (row < 2)
                {
                    Console.WriteLine("---|---|---");
                }
            }
        }

        // Método para colocar un símbolo en una posición específica
        public bool PlaceSymbol(int row, int col, char symbol)
        {
            if (row < 0 || row > 2 || col < 0 || col > 2 || board[row, col] != ' ')
            {
                return false;
            }

            board[row, col] = symbol;
            return true;
        }

        // Método para verificar si hay un ganador
        public bool CheckWinner(char symbol)
        {
            // Comprobación de filas y columnas
            for (int i = 0; i < 3; i++)
            {
                if (board[i, 0] == symbol && board[i, 1] == symbol && board[i, 2] == symbol)
                    return true;

                if (board[0, i] == symbol && board[1, i] == symbol && board[2, i] == symbol)
                    return true;
            }

            // Comprobación de diagonales
            if ((board[0, 0] == symbol && board[1, 1] == symbol && board[2, 2] == symbol) ||
                (board[0, 2] == symbol && board[1, 1] == symbol && board[2, 0] == symbol))
            {
                return true;
            }

            return false;
        }

        // Método para verificar si el tablero está lleno
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
