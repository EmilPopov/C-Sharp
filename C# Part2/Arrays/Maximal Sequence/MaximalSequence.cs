//Write a program that finds the maximal sequence of equal elements in an array
using System;


namespace Maximal_Sequence
{
    class MaximalSequence
    {
        static void Main()
        {
            int[] arr = { 5, 6, 4, -1, -1, -1, 3 };
            int number = 0;
            int sequence = 1;
            int maxSequence = 1;
            for (int i = 0; i < arr.Length - 1; i++)
            {
                if (arr[i] == arr[i + 1])
                {
                    sequence++;
                    if (sequence > maxSequence)
                    {
                        maxSequence = sequence;
                        number = arr[i];
                    }
                }
                else
                {
                    sequence = 1;
                }
            }
            Console.Write("The Max Sequence of Equal Elements is : ");
            for (int i = 1; i <= maxSequence; i++)
            {
                Console.Write(" {0} ", number);
            }
            Console.WriteLine();
        }
    }
}
