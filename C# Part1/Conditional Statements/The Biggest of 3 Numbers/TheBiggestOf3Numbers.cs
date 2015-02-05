//Write a program that finds the biggest of three numbers
using System;


namespace The_Biggest_of_3_Numbers
{
    class TheBiggestOf3Numbers
    {
        static void Main()
        {
            double[] numbers = new double[3];
            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = double.Parse(Console.ReadLine());
            }
            Array.Sort(numbers);
            Console.WriteLine(numbers[numbers.Length-1]);
        }
    }
}
