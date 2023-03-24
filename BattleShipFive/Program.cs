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

            StartGame(gameBoard);
            MakeBoard(gameBoard);
            for (int i = 0; i < 3; i++)
            {

            }
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
                Console.Write("|         ");
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
                Console.Write("|         ");
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
                Console.Write("|         ");
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
                Console.Write("|         ");
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
                Console.Write("|         ");
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
                Console.Write("|         ");
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
                Console.Write("|         ");
            }
            Console.Write("|");
            DrawDiagonalLines();
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
    }
}
