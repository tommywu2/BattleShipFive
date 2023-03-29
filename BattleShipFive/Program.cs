using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace BattleShipFive
{
    internal class Program
    {

        static void Main(string[] args)
        {
            string[,] gameBoard = new string[10, 10];
            string player = "X";
            int player1BoatAmound = 0;
            int xCoordinate = 0;
            int yCoordinate = 0;

            StartGame(gameBoard);
            MakeBoard(gameBoard);
            PlayerTurn(player, ref xCoordinate, ref yCoordinate, gameBoard);
        }
        //functions
        private static void StartGame(string[,] gameBoard)
        {
            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    gameBoard[i, j] = " ";
                }
            }

        }
        //draws the board
        private static void MakeBoard(string[,] gameBoard)
        {
            Console.WriteLine("          1         2         3         4         5         6         7         8         9         10    ");
            Console.Write("      ");
            for (int j = 0; j < 10; j++)
            {
                Console.Write("————————— ");
            }
            DrawDiagonalLines();
            Console.WriteLine(" ");
            Console.Write("  A  ");
            for (int l = 0; l < 10; l++)
            {
                Console.Write("|    " + gameBoard[l, 0] + "    ");
            }
            Console.Write("|");
            DrawDiagonalLines();
            Console.WriteLine("");

            Console.Write("      ");
            for (int j = 0; j < 10; j++)
            {
                Console.Write("————————— ");
            }
            DrawDiagonalLines();
            Console.WriteLine(" ");
            Console.Write("  B  ");
            for (int l = 0; l < 10; l++)
            {
                Console.Write("|    " + gameBoard[l, 1] + "    ");
            }
            Console.Write("|");
            DrawDiagonalLines();
            Console.WriteLine("");

            Console.Write("      ");
            for (int j = 0; j < 10; j++)
            {
                Console.Write("————————— ");
            }
            DrawDiagonalLines();
            Console.WriteLine(" ");
            Console.Write("  C  ");
            for (int l = 0; l < 10; l++)
            {
                Console.Write("|    " + gameBoard[l, 2] + "    ");
            }
            Console.Write("|");
            DrawDiagonalLines();
            Console.WriteLine("");

            Console.Write("      ");
            for (int j = 0; j < 10; j++)
            {
                Console.Write("————————— ");
            }
            DrawDiagonalLines();
            Console.WriteLine(" ");
            Console.Write("  D  ");
            for (int l = 0; l < 10; l++)
            {
                Console.Write("|    " + gameBoard[l, 3] + "    ");
            }
            Console.Write("|");
            DrawDiagonalLines();
            Console.WriteLine("");

            Console.Write("      ");
            for (int j = 0; j < 10; j++)
            {
                Console.Write("————————— ");
            }
            DrawDiagonalLines();
            Console.WriteLine(" ");
            Console.Write("  E  ");
            for (int l = 0; l < 10; l++)
            {
                Console.Write("|    " + gameBoard[l, 4] + "    ");
            }
            Console.Write("|");
            DrawDiagonalLines();
            Console.WriteLine("");

            Console.Write("      ");
            for (int j = 0; j < 10; j++)
            {
                Console.Write("————————— ");
            }
            DrawDiagonalLines();
            Console.WriteLine(" ");
            Console.Write("  F  ");
            for (int l = 0; l < 10; l++)
            {
                Console.Write("|    " + gameBoard[l, 5] + "    ");
            }
            Console.Write("|");
            DrawDiagonalLines();
            Console.WriteLine("");

            Console.Write("      ");
            for (int j = 0; j < 10; j++)
            {
                Console.Write("————————— ");
            }
            DrawDiagonalLines();
            Console.WriteLine(" ");
            Console.Write("  G  ");
            for (int l = 0; l < 10; l++)
            {
                Console.Write("|    " + gameBoard[l, 6] + "    ");
            }
            Console.Write("|");
            DrawDiagonalLines();
            Console.WriteLine("");

            Console.Write("      ");
            for (int j = 0; j < 10; j++)
            {
                Console.Write("————————— ");
            }
            DrawDiagonalLines();
            Console.WriteLine(" ");
            Console.Write("  H  ");
            for (int l = 0; l < 10; l++)
            {
                Console.Write("|    " + gameBoard[l, 7] + "    ");
            }
            Console.Write("|");
            DrawDiagonalLines();
            Console.WriteLine("");

            Console.Write("      ");
            for (int j = 0; j < 10; j++)
            {
                Console.Write("————————— ");
            }
            DrawDiagonalLines();
            Console.WriteLine(" ");
            Console.Write("  I  ");
            for (int l = 0; l < 10; l++)
            {
                Console.Write("|    " + gameBoard[l, 8] + "    ");
            }
            Console.Write("|");
            DrawDiagonalLines();
            Console.WriteLine("");

            Console.Write("      ");
            for (int j = 0; j < 10; j++)
            {
                Console.Write("————————— ");
            }
            DrawDiagonalLines();
            Console.WriteLine(" ");
            Console.Write("  J  ");
            for (int l = 0; l < 10; l++)
            {
                Console.Write("|    " + gameBoard[l, 9] + "    ");
            }
            Console.Write("|");
            DrawDiagonalLines();
            Console.WriteLine("");
            Console.Write("      ");
            for (int j = 0; j < 10; j++)
            {
                Console.Write("————————— ");
            }
            Console.WriteLine("");
        }
        //draw diagonal line for board
        private static void DrawDiagonalLines()
        {
            for (int i = 0; i < 1; i++)
            {
                Console.WriteLine(" ");
                Console.Write("     ");
                for (int j = 0; j < 10; j++)
                {
                    Console.Write("|         ");
                }
                Console.Write("|");

            }
        }
        //player turn
        private static void PlayerTurn(string player, ref int xCoordinate, ref int yCoordinate, string[,] gameBoard)
        {
            Console.WriteLine("Player: " + player);
            Console.WriteLine("What x coordinate do you want to go");
            xCoordinate = Convert.ToInt32(Console.ReadLine());
            if (xCoordinate > 0)
            {
                if (xCoordinate < 10)
                {
                    Console.WriteLine("What y coordinate do you want to go");
                    yCoordinate = Convert.ToInt32(Console.ReadLine());
                    if (yCoordinate > 0)
                    {
                        if (yCoordinate < 10)
                        {
                            gameBoard[xCoordinate - 1, yCoordinate - 1] = player;
                            MakeBoard(gameBoard);
                        }
                        else
                        {
                            Console.WriteLine("INVALID MOVE");
                            PlayerTurn(player, ref xCoordinate, ref yCoordinate, gameBoard);
                        }
                    }
                    else
                    {
                        Console.WriteLine("INVALID MOVE");
                        PlayerTurn(player, ref xCoordinate, ref yCoordinate, gameBoard);
                    }
                }
                else
                {
                    Console.WriteLine("INVALID MOVE");
                    PlayerTurn(player, ref xCoordinate, ref yCoordinate, gameBoard);
                }
            }
            else
            {
                Console.WriteLine("INVALID MOVE");
                PlayerTurn(player, ref xCoordinate, ref yCoordinate, gameBoard);
            }
            
        }
    }
}
