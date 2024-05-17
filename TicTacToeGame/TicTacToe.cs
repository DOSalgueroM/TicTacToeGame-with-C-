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

        public void StartAgainstHuman()
        {
            Console.WriteLine("Player 1 (X) - Player 2 (O)");
            Console.WriteLine("-----------------------------");

            while (true)
            {
                board.PrintBoard();

                Console.WriteLine("Player " + currentPlayer + ", enter your move (1-9):");
                int position = int.Parse(Console.ReadLine());

                if (board.PlaceSymbol(position, currentPlayer))
                {
                    if (board.CheckWinner(currentPlayer))
                    {
                        Console.WriteLine("Player " + currentPlayer + " wins!");
                        break;
                    }
                    else if (board.IsBoardFull())
                    {
                        Console.WriteLine("It's a draw!");
                        break;
                    }
                    currentPlayer = (currentPlayer == 'X') ? 'O' : 'X';
                }
                else
                {
                    Console.WriteLine("Invalid move. Try again.");
                }
            }
        }

        public void StartAgainstComputer()
        {
            Console.WriteLine("You are playing against the computer (O)");

            while (true)
            {
                
                board.PrintBoard();
                Console.WriteLine("Your move (1-9):");
                int position = int.Parse(Console.ReadLine());

                if (board.PlaceSymbol(position, 'X'))
                {
                    if (board.CheckWinner('X'))
                    {
                        Console.WriteLine("Congratulations! You win!");
                        break;
                    }
                    else if (board.IsBoardFull())
                    {
                        Console.WriteLine("It's a draw!");
                        break;
                    }

                   
                    int computerMove = GetComputerMove();
                    board.PlaceSymbol(computerMove, 'O');

                    if (board.CheckWinner('O'))
                    {
                        board.PrintBoard();
                        Console.WriteLine("The computer wins! Better luck next time.");
                        break;
                    }
                    else if (board.IsBoardFull())
                    {
                        Console.WriteLine("It's a draw!");
                        break;
                    }
                }
                else
                {
                    Console.WriteLine("Invalid move. Try again.");
                }
            }
        
    }

        private int GetComputerMove()
        {
            

            Random random = new Random();
            int position;

            do
            {
                position = random.Next(1, 10);
            } while (!board.PlaceSymbol(position, 'O'));

            return position;
        }
    }
}


