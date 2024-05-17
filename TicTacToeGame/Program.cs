using System;

namespace TicTacToeGame
{
    class Program
    {
        static void Main(string[] args)
        {
            // creating a new TicTacToe game
            Console.WriteLine("Welcome to Tic Tac Toe!");
            Console.WriteLine("Choose an option:");
            Console.WriteLine("1. Play against another player");
            Console.WriteLine("2. Play against computer");
            int option = int.Parse(Console.ReadLine());

            if (option == 1)
            {
                PlayAgainstHuman();
            }
            else if (option == 2)
            {
                PlayAgainstComputer();
            }
            else
            {
                Console.WriteLine("Invalid option. Exiting the game.");
            }
        }

        static void PlayAgainstHuman()
        {
            TicTacToe game = new TicTacToe();
            game.StartAgainstHuman();
        }

        static void PlayAgainstComputer()
        {
            TicTacToe game = new TicTacToe();
            game.StartAgainstComputer();
        }
    }
    }
    
