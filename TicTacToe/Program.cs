using System;

namespace TicTacToeGame
{
    public class TicTactoe
    {
        /// <summary>
        /// Created a Board with size 10 char array
        /// </summary>
        public static char[] board = { ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ' };
        public static void createBoard()
        {
            for (int i = 1; i < 10; i++)
            {
                Console.WriteLine(" Empty board:" + i + ": " + board[i]);
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to TicTacToe Game !");
            TicTactoe.createBoard();
        }
    }
}
