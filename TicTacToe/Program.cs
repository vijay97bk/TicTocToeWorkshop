using System;

namespace TicTacToeGame
{
    class TicTacToe
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

        //public static char chooseLetter(char letter)
        //{
        //    switch (letter)
        //   {
        //        case LETTERX:
        //            Console.WriteLine(" Player choose X Option ");
        //            break;
        //        case LETTERO:
        //            Console.WriteLine("  Player choose O Option  ");
        //            break;
        //    }
        // 
        //    switch (letter)
        //    {
        //        case LETTERX:
        //            Console.WriteLine(" Computer choose X Option ");
        //            break;
        //        case LETTERO:
        //            Console.WriteLine(" Computer choose O Option  ");
        //           break;
        //    }
        //    return letter;
        //}

        public static void showBoard()
        {
            Console.WriteLine(" |" + board[1] + "   | " + board[2] + "  | " + board[3] + "  | ");
            Console.WriteLine(" |" + board[4] + "   | " + board[5] + "  | " + board[6] + "  | ");
            Console.WriteLine(" |" + board[7] + "   | " + board[8] + "  | " + board[9] + "  | ");

        }

        public static void makeAMove(char[] letter)
        {
            char freeSpace = ' ';
            Random rand = new Random();
            if (makeAToss() == 1)
            {
                Console.WriteLine(" Player wins a toss ");
                while (isWin(letter) != true)
                {
                    Console.WriteLine(" Players Move ");
                    int indexPlayer = Convert.ToInt32(Console.ReadLine());
                    if (board[indexPlayer] == ' ')
                    {
                        board[indexPlayer] = letter[0];
                        if (isWin(letter) == true)
                        {
                            Console.WriteLine(" Player Wins ");
                            Environment.Exit(0);

                        }
                    }
                    showBoard();
                    Console.WriteLine(" Computers Move ");
                    int indexComputer = rand.Next(1, 10);
                    if (board[indexComputer] == ' ')
                    {
                        board[indexComputer] = letter[1];
                        if (isWin(letter) == true)
                        {
                            Console.WriteLine(" Computer Wins ");
                            Environment.Exit(0);
                        }
                    }
                    showBoard();
                }

            }
            else
            {
                Console.WriteLine(" Computer wins a toss ");
                while (isWin(letter) != true)
                {
                    Console.WriteLine(" Computers Move ");
                    int indexComputer = rand.Next(1, 10);
                    if (board[indexComputer] == ' ')
                    {
                        board[indexComputer] = letter[1];
                        if (isWin(letter) == true)
                        {
                            Console.WriteLine(" Computer Wins ");
                            Environment.Exit(0);
                        }
                    }
                    showBoard();
                    Console.WriteLine(" Players Move ");
                    int indexPlayer = Convert.ToInt32(Console.ReadLine());
                    if (board[indexPlayer] == ' ')
                    {
                        board[indexPlayer] = letter[0];
                        if (isWin(letter) == true)
                        {
                            Console.WriteLine(" Player Wins ");
                            Environment.Exit(0);
                        }
                    }
                    showBoard();
                }
            }

        }

        public static bool isWin(char[] letter)
        {
            return (board[1] == letter[0] && board[2] == letter[0] && board[3] == letter[0]) ||
                 (board[4] == letter[0] && board[5] == letter[0] && board[6] == letter[0]) ||
                 (board[7] == letter[0] && board[8] == letter[0] && board[9] == letter[0]) ||
                 (board[1] == letter[0] && board[4] == letter[0] && board[7] == letter[0]) ||
                 (board[2] == letter[0] && board[5] == letter[0] && board[8] == letter[0]) ||
                 (board[3] == letter[0] && board[6] == letter[0] && board[9] == letter[0]) ||
                 (board[1] == letter[0] && board[5] == letter[0] && board[9] == letter[0]) ||
                 (board[3] == letter[1] && board[5] == letter[1] && board[7] == letter[1]) ||
                 (board[1] == letter[1] && board[2] == letter[1] && board[3] == letter[1]) ||
                 (board[4] == letter[1] && board[5] == letter[1] && board[6] == letter[1]) ||
                 (board[7] == letter[1] && board[8] == letter[1] && board[9] == letter[1]) ||
                 (board[1] == letter[1] && board[4] == letter[1] && board[7] == letter[1]) ||
                 (board[2] == letter[1] && board[5] == letter[1] && board[8] == letter[1]) ||
                 (board[3] == letter[1] && board[6] == letter[1] && board[9] == letter[1]) ||
                 (board[1] == letter[1] && board[5] == letter[1] && board[9] == letter[1]) ||
                 (board[3] == letter[1] && board[5] == letter[1] && board[7] == letter[1]);
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
            char[] letter = { 'X', 'O' };
            Console.WriteLine(" Welcome to Tic Tac Toe Game");

            // TicTacToe.chooseLetter(letter);   
            TicTacToe.makeAMove(letter);


        }
    }
}