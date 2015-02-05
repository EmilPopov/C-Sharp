//Write a program that enters in integer n and prints the numbers 1, 2, …, n in random order.
using System;


namespace Randomize_the_Numbers_1_N
{
    class RandomizeTheNumbers
    {
        static void Main()
        {
            Console.WriteLine("N : ");
            int n = int.Parse(Console.ReadLine());
            int[] numbers = new int[n];
            Random rnd = new Random();
            int rndIndex = 0;
            for (int i = 1; i <= numbers.Length; i++)
            {
                rndIndex = rnd.Next(0,n);
                if (numbers[rndIndex] == 0)
                {
                    numbers[rndIndex] = i;                 
                }
                else
                {
                    i--;
                }
            }
            foreach (var number in numbers)
            {
                Console.Write(number + " ");
            }
        }
    }
}
