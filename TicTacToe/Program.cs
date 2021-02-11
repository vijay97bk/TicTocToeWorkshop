using System;

namespace TicTacToeGame
{
    public class TicTactoe
    {
        public static string PLAYER_1;
        public const int LETTERX = 0;
        public const int LETTERO = 1;

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
        /// <summary>
        /// Choose a Letter for player and computer
        /// </summary>
        public static void chooseLetter()
        {

            Random rand = new Random();
            int letterComputer = rand.Next(0, 2);
            Console.WriteLine(" Choose a Letter ");
            Console.WriteLine("Enter digit 0=X or 1=O");
            int letterPlayer = Convert.ToInt32(Console.ReadLine());

            switch (letterPlayer)
            {
                case LETTERX:
                    Console.WriteLine(" Player choose X Option ");
                    break;
                case LETTERO:
                    Console.WriteLine("  Player choose O Option  ");
                    break;
            }

            switch (letterComputer)
            {
                case LETTERX:
                    Console.WriteLine(" Computer choose X Option ");
                    break;
                case LETTERO:
                    Console.WriteLine(" Computer choose O Option  ");
                    break;
            }
        }
        /// <summary>
        /// Show the Board
        /// </summary>
        public static void showBoard()
        {
            Console.WriteLine(" |" + board[1] + "   | " + board[2] + "  | " + board[3] + "  | ");
            Console.WriteLine(" |" + board[4] + "   | " + board[5] + "  | " + board[6] + "  | ");
            Console.WriteLine(" |" + board[7] + "   | " + board[8] + "  | " + board[9] + "  | ");

        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to TicTacToe Game !");
            TicTactoe.createBoard();
            TicTactoe.chooseLetter();
            TicTactoe.showBoard();
        }
    }
}