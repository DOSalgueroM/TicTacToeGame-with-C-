using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToeGame
{
    class TicTacToe
    {
        private Board board;
        private char currentPlayer;

        public TicTacToe()
        {
            board = new Board();
            currentPlayer = 'X';
        }

        // Método para iniciar el juego
        public void Start()
        {
            Console.WriteLine("Welcome to Tic Tac Toe!");
            Console.WriteLine("Player 1 (X) - Player 2 (O)");
            Console.WriteLine("-----------------------------");

            while (true)
            {
                // Imprimir el tablero
                board.PrintBoard();

                // Obtener la jugada del jugador actual
                Console.WriteLine("Player " + currentPlayer + ", enter your move (row [1-3] column [1-3]):");
                string[] input = Console.ReadLine().Split(' ');
                int row = int.Parse(input[0]) - 1;
                int col = int.Parse(input[1]) - 1;

                // Verificar si la jugada es válida
                if (row >= 0 && row < 3 && col >= 0 && col < 3 && board.PlaceSymbol(row, col, currentPlayer))
                {
                    // Verificar si hay un ganador
                    if (board.CheckWinner(currentPlayer))
                    {
                        Console.WriteLine("Player " + currentPlayer + " wins!");
                        break;
                    }
                    // Verificar si el tablero está lleno (empate)
                    else if (board.IsBoardFull())
                    {
                        Console.WriteLine("It's a draw!");
                        break;
                    }
                    // Cambiar el jugador
                    currentPlayer = (currentPlayer == 'X') ? 'O' : 'X';
                }
                else
                {
                    Console.WriteLine("Invalid move. Try again.");
                }
            }
        }
    }
}

