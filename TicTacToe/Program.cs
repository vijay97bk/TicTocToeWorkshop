using System;

namespace TicTacToeGame
{
    class TicTactoe
    {
        public static string PLAYER_1;
        public const char LETTERX = 'X';
        public const char LETTERO = 'O';
        public static char[] board = { ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ' };
        public static void createBoard()
        {
            for (int i = 1; i < 10; i++)
            {
                Console.WriteLine(" Empty board:" + i + ": " + board[i]);
            }
        }

        public static char chooseLetter(char letterPlayer, char letterComputer)
        {
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
            return letterPlayer;
        }

        public static void showBoard()
        {
            Console.WriteLine(" |" + board[1] + "   | " + board[2] + "  | " + board[3] + "  | ");
            Console.WriteLine(" |" + board[4] + "   | " + board[5] + "  | " + board[6] + "  | ");
            Console.WriteLine(" |" + board[7] + "   | " + board[8] + "  | " + board[9] + "  | ");

        }

        public static void makeAMove(char letterPlayer, char letterComputer)
        {
            char freeSpace = ' ';
            Random rand = new Random();
            if (makeAToss() == 1)
            {
                Console.WriteLine(" Players Move ");
                int indexPlayer = Convert.ToInt32(Console.ReadLine());
                if (board[indexPlayer] == ' ')
                {
                    board[indexPlayer] = letterPlayer;
                }
                Console.WriteLine(" Computers Move ");
                int indexComputer = rand.Next(1, 10);
                if (board[indexComputer] == ' ')
                {
                    board[indexComputer] = letterComputer;
                }


            }
            else if (makeAToss() == 0)
            {
                Console.WriteLine(" Computers Move ");
                int indexComputer = rand.Next(1, 10);
                if (board[indexComputer] == ' ')
                {
                    board[indexComputer] = letterComputer;
                }
                Console.WriteLine(" Players Move ");
                int indexPlayer = Convert.ToInt32(Console.ReadLine());
                if (board[indexPlayer] == ' ')
                {
                    board[indexPlayer] = letterPlayer;
                }
            }
        }

        public static int makeAToss()
        {
            Random rand = new Random();
            int toss = rand.Next(0, 2);
            return toss;
        }

    }

    class Program
    {
        static void Main(string[] args)
        {
            char letterComputer = 'O';
            char letterPlayer = 'X';
            Console.WriteLine(" Welcome to TicTacToe Game");

            TicTactoe.chooseLetter(letterPlayer, letterComputer);

            TicTactoe.makeAMove(letterPlayer, letterComputer);
            TicTactoe.showBoard();


        }
    }
}