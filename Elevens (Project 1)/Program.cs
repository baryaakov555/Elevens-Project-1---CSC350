using System;
using System.Collections.Generic;
using Elevens;

namespace Elevens
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ElevensGame game = new ElevensGame();

            Console.WriteLine("Welcome to the Elevens Game!");
            Console.WriteLine("Select cards by their index numbers (1–9).");
            Console.WriteLine("Select either two cards that add to 11, or three cards, them being: Jack, Queen, and King.\n");

            DisplayBoard(game.GetBoard());

            while (game.AnotherPlayIsPossible())
            {
                Console.Write("Enter card indexes (seperate them by a comma ','): ");
                string input = Console.ReadLine();

                if (string.IsNullOrWhiteSpace(input))
                {
                    Console.WriteLine("Invalid input.\n");
                    continue;
                }

                var indexes = new List<int>();

                foreach (var s in input.Split(','))
                {
                    if (int.TryParse(s.Trim(), out int num))
                        indexes.Add(num - 1);
                }

                if (game.IsLegalMove(indexes))
                {
                    game.ReplaceCards(indexes);
                    Console.WriteLine("Legal move! The selected cards were replaced.\n");
                }
                else
                {
                    Console.WriteLine("Illegal move. Try again.\n");
                }

                DisplayBoard(game.GetBoard());
            }

            Console.WriteLine("\nNo more legal moves left. Game Over!");
        }

        static void DisplayBoard(List<Card> board)
        {
            Console.WriteLine("\nCurrent Board:");
            for (int i = 0; i < board.Count; i++)
            {
                if (board[i] != null)
                    Console.WriteLine($"{i + 1}. {board[i]}");
                else
                    Console.WriteLine($"{i + 1}. [Empty]");
            }
            Console.WriteLine();
        }
    }
}
