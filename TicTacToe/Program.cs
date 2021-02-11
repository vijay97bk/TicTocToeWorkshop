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

        public static void emptyTheBoard()
        {
            for (int i = 1; i < 10; i++)
            {
                board[i] = ' ';
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

        public static void play(char[] letter)
        {
            const int HEAD = 0;
            const int TAIL = 1;
            char freeSpace = ' ';
            Random rand = new Random();
            switch (makeAToss())
            {
                case HEAD:
                    Console.WriteLine(" Player wins a toss ");
                    while (board[1] == ' ' || board[2] == ' ' || board[3] == ' ' || board[4] == ' ' || board[5] == ' ' || board[6] == ' ' || board[7] == ' ' || board[8] == ' ' || board[9] == ' ')
                    {
                        player(letter);
                        if (isWin(letter) == true)
                        {
                            Console.WriteLine(" Player Wins ");
                            break;
                        }
                        computer(letter);
                        if (isWin(letter) == true)
                        {
                            Console.WriteLine(" Computer Wins ");
                            break;
                        }
                    }
                    break;
                case TAIL:
                    Console.WriteLine(" Player wins a toss ");
                    while (board[1] == ' ' || board[2] == ' ' || board[3] == ' ' || board[4] == ' ' || board[5] == ' ' || board[6] == ' ' || board[7] == ' ' || board[8] == ' ' || board[9] == ' ')
                    {
                        computer(letter);
                        if (isWin(letter) == true)
                        {
                            Console.WriteLine(" Computer Wins ");
                            break;
                        }
                        player(letter);
                        if (isWin(letter) == true)
                        {
                            Console.WriteLine(" Player Wins ");
                            break;
                        }
                    }
                    break;
            }
        }

        public static void player(char[] letter)
        {
            const int CORNER = 1;
            const int CENTRE = 2;
            const int SIDES = 3;
            Console.WriteLine(" Players Move ");
            Console.WriteLine(" Choose option: ");
            int option = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(" Make a move ");
            int indexPlayer = Convert.ToInt32(Console.ReadLine());
            switch (option)
            {
                case SIDES:
                    Console.WriteLine(" Move to availabel sides ");
                    availabelSides(letter, indexPlayer);
                    break;
                case CORNER:
                    Console.WriteLine(" Move to availabel corner ");
                    availabelCorners(letter, indexPlayer);
                    break;
                case CENTRE:
                    Console.WriteLine(" Move to availabel centre ");
                    availabelCentre(letter);
                    break;
            }
            showBoard();

        }

        public static void computer(char[] letter)
        {
            Random rand = new Random();
            Console.WriteLine(" Computers Move ");
            int indexComputer = rand.Next(1, 10);
            if (board[indexComputer] == ' ')
            {
                board[indexComputer] = letter[1];
            }
            showBoard();
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

        public static void availabelCorners(char[] letter, int indexPlayer)
        {
            if (board[1] == ' ' || board[3] == ' ' || board[7] == ' ' || board[9] == ' ')
            {
                board[indexPlayer] = letter[0];
            }
        }

        public static void availabelSides(char[] letter, int indexPlayer)
        {
            if ((board[2] == ' ' || board[4] == ' ' || board[6] == ' ' || board[8] == ' ') || (board[1] != ' ' && board[3] != ' ' && board[7] != ' ' && board[9] != ' ' && board[5] != ' '))
            {
                board[indexPlayer] = letter[0];
            }
        }

        public static void availabelCentre(char[] letter)
        {
            if (board[5] == ' ' || (board[1] != ' ' && board[3] != ' ' && board[7] != ' ' && board[9] != ' '))
            {
                int indexPlayer = 5;
                board[indexPlayer] = letter[0];
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
            char[] letter = { 'X', 'O' };
            Console.WriteLine(" Welcome to Tic Tac Toe Game");

            // TicTacToe.chooseLetter(letter);   
            TicTacToe.play(letter);
            string anotherGame = Console.ReadLine();
            if (anotherGame == "YES")
            {
                Console.WriteLine(" Play Another Game ");
                TicTacToe.emptyTheBoard();
                TicTacToe.play(letter);
            }
        }
    }
}