//Write a program that enters 3 real numbers and prints them sorted in descending order.
using System;


namespace Sort_3_Numbers_with_Nested_Ifs
{
    class Sort3Numbers
    {
        static void Main()
        {
            double[] numbers = new double[3];
            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = double.Parse(Console.ReadLine());
            }
            Array.Sort(numbers);
            Array.Reverse(numbers);
            for (int i = 0; i < numbers.Length; i++)
            {
                Console.Write(numbers[i] + " ");
            }
        }
    }
}
