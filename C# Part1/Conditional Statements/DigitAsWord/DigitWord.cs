//Write a program that asks for a digit (0-9), and depending on the input, shows the digit as a word (in English).
//Print “not a digit” in case of invalid input.
//Use a switch statement.
using System;

using System.Threading.Tasks;

namespace DigitAsWord
{
    class DigitWord
    {
        static void Main()
        {
            Console.Write("Enter digit (0-9) : ");
            int digit;
            int.TryParse(Console.ReadLine(), out digit);
            if ((digit >= 0 && (digit <= 9)))
            {
                switch (digit)
                {
                    case 0: Console.WriteLine("ZERO");
                        break;
                    case 1: Console.WriteLine("ONE");
                        break;
                    case 2: Console.WriteLine("TWO");
                        break;
                    case 3: Console.WriteLine("THREE");
                        break;
                    case 4: Console.WriteLine("FOUR");
                        break;
                    case 5: Console.WriteLine("FIVE");
                        break;
                    case 6: Console.WriteLine("SIX");
                        break;
                    case 7: Console.WriteLine("SEVEN");
                        break;
                    case 8: Console.WriteLine("EIGHT");
                        break;
                    case 9: Console.WriteLine("NINE");
                        break;
                }
            }
            else
            {
                Console.WriteLine("Invalid Input !");
            }
        }
    }
}
