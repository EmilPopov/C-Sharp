//Write a program that generates and prints all possible cards from a standard deck of 52 cards (without the jokers). The cards should be printed using the classical notation (like 5 of spades, A of hearts, 9 of clubs; and K of diamonds).
//The card faces should start from 2 to A.
//Print each card face in its four possible suits: clubs, diamonds, hearts and spades. Use 2 nested for-loops and a switch-case statement.
using System;


namespace Print_a_Deck_of_52_Cards
{
    class PrintADeckOf52Cards
    {
        static void Main()
        {
            string[] allCards = { "2", "3", "4", "5", "6", "7", "8", "9", "10", "J", "D", "K", "A" };
            char card = '\u2660';
            for (int i = 1; i <= 4; i++)
            {
                Console.BackgroundColor = ConsoleColor.White;
                if (i == 1)
                {
                    Console.ForegroundColor = ConsoleColor.Black;
                    card = '\u2660';

                }
                else if (i == 2)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    card = '\u2665';
                }
                else if (i == 3)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    card = '\u2666';
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Black;
                    card = '\u2663';
                }
                foreach (string all in allCards)
                {
                    Console.Write(" {0} {1} ", card, all);

                }
                Console.WriteLine();
                Console.WriteLine();
                Console.BackgroundColor = ConsoleColor.Black;

            }
        }
    }
}