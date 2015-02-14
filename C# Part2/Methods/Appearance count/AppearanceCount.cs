//Write a method that counts how many times given number appears in given array.
//Write a test program to check if the method is workings correctly.
using System;


namespace Appearance_count
{
    class AppearanceCount
    {
        static void Main()
        {
            int k = 4;
            int[] numbers = new int[13] { 4, 1, 1, 4, 2, 3, 4, 4, 1, 2, 4, 9, 3 };
            NumberCounter(k, numbers);
        }
        static void NumberCounter(int k , int[] numbers)
        {
            int counter = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] == k)
                {
                    counter++;
                }
            }
            if (counter==0)
            {
                Console.WriteLine("This number not exist in this array");
            }
            else
            {
                Console.WriteLine("{0} ({1} times)", k, counter);
            }
        }
    }
}
