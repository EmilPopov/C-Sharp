//Write a program that reads two integer arrays from the console and compares them element by element.
using System;


namespace Compare_arrays
{
    class CompareArrays
    {
        static void Main()
        {
            Console.Write("Enter N : ");
            int n = int.Parse(Console.ReadLine());
            int[] firstArray = new int[n];
            for (int i = 0; i < firstArray.Length; i++)
            {
                firstArray[i] = int.Parse(Console.ReadLine());
            }
            Console.Write("Enter L : ");
            int l = int.Parse(Console.ReadLine());
            int[] secondArray = new int[l];
            for (int i = 0; i < secondArray.Length; i++)
            {
                secondArray[i] = int.Parse(Console.ReadLine());
            }
            if (firstArray.Length != secondArray.Length)
            {
                Console.WriteLine("False");
            }
            else
            {
                int trueCount = 0;
                int falseCount = 0;
                for (int i = 0; i < firstArray.Length; i++)
                {
                    if (firstArray[i] == secondArray[i])
                    {
                        trueCount++;
                    }
                    else
                    {
                        falseCount++;
                    }
                }
                Console.WriteLine("The arrays have {0} same elements at the same index and {1} different", trueCount, falseCount);
            }
        }
    }
}
