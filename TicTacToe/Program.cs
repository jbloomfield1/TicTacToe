using System;
using System.Linq;

namespace TicTacToe
{
    public static class MainClass
    {
        private const string V = " ";
        private const string X = "X";
        private const string O = "O";
        public static void Main()
        {
            Globals.ClearBoard();
            Globals.xTurn = true;
            Start();
        }

        public static void Start()
        {
            Console.Clear();
            Globals.ShowBoardReference();
            Globals.ShowBoardState();
            Console.WriteLine("\r\nChoose an option: \n1. Play Tic-Tac-Toe \n2. Exit\r\n");
            var input = Console.ReadKey(true);
            switch (input.Key)
            {
                case ConsoleKey.D1:
                case ConsoleKey.NumPad1:
                    MainGame();
                    break;
                case ConsoleKey.D2:
                case ConsoleKey.NumPad2:
                    return;
                default:
                    Console.WriteLine("\nChoose a valid option");
                    Start();
                    break;
            }
        }

        public static void MainGame()
        {
            Console.Clear();
            Globals.ShowBoardReference();
            Globals.ShowBoardState();
            CheckGameState();
            if (!Globals.xTurn) { OMove(); } else { XMove(); }
            void XMove()
            {
                Console.WriteLine("\nPlayer X:\n Press (1-9) to move or R to return\r\n");
                var input = Console.ReadKey(true);
                switch (input.Key)
                {
                    case ConsoleKey.D9:
                    case ConsoleKey.NumPad9:
                        if (Globals.boardState[0] == V)
                        {
                            Globals.boardState[0] = X;
                            Globals.xTurn = false;
                        }
                        else
                        {
                            Globals.InvalidXMove();
                        }
                        break;
                    case ConsoleKey.D1:
                    case ConsoleKey.NumPad1:
                        if (Globals.boardState[1] == V)
                        {
                            Globals.boardState[1] = X;
                            Globals.xTurn = false;
                        }
                        else
                        {
                            Globals.InvalidXMove();
                        }
                        break;
                    case ConsoleKey.D2:
                    case ConsoleKey.NumPad2:
                        if (Globals.boardState[2] == V)
                        {
                            Globals.boardState[2] = X;
                            Globals.xTurn = false;
                        }
                        else
                        {
                            Globals.InvalidXMove();
                        }
                        break;
                    case ConsoleKey.D3:
                    case ConsoleKey.NumPad3:
                        if (Globals.boardState[3] == V)
                        {
                            Globals.boardState[3] = X;
                            Globals.xTurn = false;
                        }
                        else
                        {
                            Globals.InvalidXMove();
                        }
                        break;
                    case ConsoleKey.D4:
                    case ConsoleKey.NumPad4:
                        if (Globals.boardState[4] == V)
                        {
                            Globals.boardState[4] = X;
                            Globals.xTurn = false;
                        }
                        else
                        {
                            Globals.InvalidXMove();
                        }
                        break;
                    case ConsoleKey.D5:
                    case ConsoleKey.NumPad5:
                        if (Globals.boardState[5] == V)
                        {
                            Globals.boardState[5] = X;
                            Globals.xTurn = false;
                        }
                        else
                        {
                            Globals.InvalidXMove();
                        }
                        break;
                    case ConsoleKey.D6:
                    case ConsoleKey.NumPad6:
                        if (Globals.boardState[6] == V)
                        {
                            Globals.boardState[6] = X;
                            Globals.xTurn = false;
                        }
                        else
                        {
                            Globals.InvalidXMove();
                        }
                        break;
                    case ConsoleKey.D7:
                    case ConsoleKey.NumPad7:
                        if (Globals.boardState[7] == V)
                        {
                            Globals.boardState[7] = X;
                            Globals.xTurn = false;
                        }
                        else
                        {
                            Globals.InvalidXMove();
                        }
                        break;
                    case ConsoleKey.D8:
                    case ConsoleKey.NumPad8:
                        if (Globals.boardState[8] == V)
                        {
                            Globals.boardState[8] = X;
                            Globals.xTurn = false;
                        }
                        else
                        {
                            Globals.InvalidXMove();
                        }
                        break;
                    case ConsoleKey.R:
                        Main();
                        break;
                    default:
                        XMove();
                        break;
                }
                MainGame();
            }
            void OMove()
            {
                Console.WriteLine("\nPlayer O:\n Press (1-9) to move or R to return\r\n");
                var input = Console.ReadKey(true);
                switch (input.Key)
                {
                    case ConsoleKey.D9:
                    case ConsoleKey.NumPad9:
                        if (Globals.boardState[0] == V)
                        {
                            Globals.boardState[0] = O;
                            Globals.xTurn = true;
                        }
                        else
                        {
                            Globals.InvalidOMove();
                        }
                        break;
                    case ConsoleKey.D1:
                    case ConsoleKey.NumPad1:
                        if (Globals.boardState[1] == V)
                        {
                            Globals.boardState[1] = O;
                            Globals.xTurn = true;
                        }
                        else
                        {
                            Globals.InvalidOMove();
                        }
                        break;
                    case ConsoleKey.D2:
                    case ConsoleKey.NumPad2:
                        if (Globals.boardState[2] == V)
                        {
                            Globals.boardState[2] = O;
                            Globals.xTurn = true;
                        }
                        else
                        {
                            Globals.InvalidOMove();
                        }
                        break;
                    case ConsoleKey.D3:
                    case ConsoleKey.NumPad3:
                        if (Globals.boardState[3] == V)
                        {
                            Globals.boardState[3] = O;
                            Globals.xTurn = true;
                        }
                        else
                        {
                            Globals.InvalidOMove();
                        }
                        break;
                    case ConsoleKey.D4:
                    case ConsoleKey.NumPad4:
                        if (Globals.boardState[4] == V)
                        {
                            Globals.boardState[4] = O;
                            Globals.xTurn = true;
                        }
                        else
                        {
                            Globals.InvalidOMove();
                        }
                        break;
                    case ConsoleKey.D5:
                    case ConsoleKey.NumPad5:
                        if (Globals.boardState[5] == V)
                        {
                            Globals.boardState[5] = O;
                            Globals.xTurn = true;
                        }
                        else
                        {
                            Globals.InvalidOMove();
                        }
                        break;
                    case ConsoleKey.D6:
                    case ConsoleKey.NumPad6:
                        if (Globals.boardState[6] == V)
                        {
                            Globals.boardState[6] = O;
                            Globals.xTurn = true;
                        }
                        else
                        {
                            Globals.InvalidOMove();
                        }
                        break;
                    case ConsoleKey.D7:
                    case ConsoleKey.NumPad7:
                        if (Globals.boardState[7] == V)
                        {
                            Globals.boardState[7] = O;
                            Globals.xTurn = true;
                        }
                        else
                        {
                            Globals.InvalidOMove();
                        }
                        break;
                    case ConsoleKey.D8:
                    case ConsoleKey.NumPad8:
                        if (Globals.boardState[8] == V)
                        {
                            Globals.boardState[8] = O;
                            Globals.xTurn = true;
                        }
                        else
                        {
                            Globals.InvalidOMove();
                        }
                        break;
                    case ConsoleKey.R:
                        Main();
                        break;
                    default:
                        OMove();
                        break;
                }
                MainGame();
            }
        }
        public static void CheckGameState()
        {
            if (Globals.boardState[1] == X &&
                Globals.boardState[2] == X &&
                Globals.boardState[3] == X)
            {
                XWins();
            }
            else if (Globals.boardState[4] == X &&
                Globals.boardState[5] == X &&
                Globals.boardState[6] == X)
            {
                XWins();
            }
            else if (Globals.boardState[7] == X &&
                Globals.boardState[8] == X &&
                Globals.boardState[0] == X)
            {
                XWins();
            }
            else if (Globals.boardState[1] == X &&
                Globals.boardState[4] == X &&
                Globals.boardState[7] == X)
            {
                XWins();
            }
            else if (Globals.boardState[2] == X &&
                Globals.boardState[5] == X &&
                Globals.boardState[8] == X)
            {
                XWins();
            }
            else if (Globals.boardState[3] == X &&
                Globals.boardState[6] == X &&
                Globals.boardState[0] == X)
            {
                XWins();
            }
            else if (Globals.boardState[1] == X &&
                Globals.boardState[5] == X &&
                Globals.boardState[0] == X)
            {
                XWins();
            }
            else if (Globals.boardState[3] == X &&
                Globals.boardState[5] == X &&
                Globals.boardState[7] == X)
            {
                XWins();
            }
            else if (Globals.boardState[1] == O &&
                Globals.boardState[2] == O &&
                Globals.boardState[3] == O)
            {
                OWins();
            }
            else if (Globals.boardState[4] == O &&
                Globals.boardState[5] == O &&
                Globals.boardState[6] == O)
            {
                OWins();
            }
            else if (Globals.boardState[7] == O &&
                Globals.boardState[8] == O &&
                Globals.boardState[0] == O)
            {
                OWins();
            }
            else if (Globals.boardState[1] == O &&
                Globals.boardState[4] == O &&
                Globals.boardState[7] == O)
            {
                OWins();
            }
            else if (Globals.boardState[2] == O &&
                Globals.boardState[5] == O &&
                Globals.boardState[8] == O)
            {
                OWins();
            }
            else if (Globals.boardState[3] == O &&
                Globals.boardState[6] == O &&
                Globals.boardState[0] == O)
            {
                OWins();
            }
            else if (Globals.boardState[1] == O &&
                Globals.boardState[5] == O &&
                Globals.boardState[0] == O)
            {
                OWins();
            }
            else if (Globals.boardState[3] == O &&
                Globals.boardState[5] == O &&
                Globals.boardState[7] == O)
            {
                OWins();
            }
            else if (Globals.boardState.Contains(V))
            {
                return;
            }
            TieGame();
        }

        public static void XWins()
        {
            Console.Clear();
            Globals.ShowBoardReference();
            Globals.ShowBoardState();
            Console.WriteLine("==============\nPlayer X WINS!\n==============\n");
            Console.ReadKey(true);
            Main();
        }

        public static void OWins()
        {
            Console.Clear();
            Globals.ShowBoardReference();
            Globals.ShowBoardState();
            Console.WriteLine("==============\nPlayer O WINS!\n==============\n");
            Console.ReadKey(true);
            Main();
        }

        public static void TieGame()
        {
            Console.Clear();
            Globals.ShowBoardReference();
            Globals.ShowBoardState();
            Console.WriteLine("==============\n---Tie Game---\n==============\n");
            Console.ReadKey(true);
            Main();
        }
    }
}