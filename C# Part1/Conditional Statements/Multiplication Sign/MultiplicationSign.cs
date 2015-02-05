//Write a program that shows the sign (+, - or 0) of the product of three real numbers, without calculating it.
//Use a sequence of if operators
using System;


namespace Multiplication_Sign
{
    class MultiplicationSign
    {
        static void Main()
        {
            double number;
            int counter = 0;
            for (int i = 0; i < 3; i++)
            {
                Console.Write("Enter number:");
                double.TryParse(Console.ReadLine(), out number);

                if (number < 0)
                {
                    counter++;
                }
                else if (number == 0)
                {
                    Console.WriteLine("ZERO");
                }
            }
            if (counter % 2 == 0)
            {
                Console.WriteLine("The sign is \"+\"");
            }
            else
            {
                Console.WriteLine("The sign is \"-\"");
            }
           
        }
    }
}
