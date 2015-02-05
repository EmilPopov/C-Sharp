//Write a program that finds the biggest of five numbers by using only five if statements.
using System;

namespace The_Biggest_of_Five_Numbers
{
    class TheBiggestOfFiveNumbers
    {
        static void Main()
        {
            double[] numbers = new double[5];
            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = double.Parse(Console.ReadLine());
            }
            Array.Sort(numbers);
            Console.WriteLine(numbers[numbers.Length - 1]);
        }
    }
}
