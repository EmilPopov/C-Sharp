//Write a program that compares two char arrays lexicographically (letter by letter).
using System;
using System.Linq;


namespace Compare_Char_Arrays
{
    class CompareCharArrays
    {
        static void Main()
        {
            char[] firstArray = "Telerik".ToCharArray();
            char[] secondArray = "Introprogramming".ToCharArray();
            int minLen = Math.Min(secondArray.Length, firstArray.Length); //gets min length of two arrays
            if (firstArray == secondArray)
            {
                Console.WriteLine("Arrays is equal");
            }
            else
            {
                for (int i = 0; i < minLen; i++)
                {
                    if (firstArray[i] < secondArray[i])
                    {
                        Console.WriteLine("The first char array is lexicografically before the second.");
                        break;
                    }
                    else if (firstArray[i] > secondArray[i])
                    {
                        Console.WriteLine("The second char array is lexicografically before the first.");
                        break;
                    }
                    else if (firstArray[i] == secondArray[i])
                    {
                        continue;
                    }
                }
            }
        }
    }
}
