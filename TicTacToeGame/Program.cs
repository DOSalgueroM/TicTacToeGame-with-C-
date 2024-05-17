using System;

namespace TicTacToeGame
{
    class Program
    {
        static void Main(string[] args)
        {
            // Crear una nueva instancia del juego
            TicTacToe game = new TicTacToe();

            // Comenzar el juego
            game.Start();

            Console.ReadLine();
        }
    }
    }
