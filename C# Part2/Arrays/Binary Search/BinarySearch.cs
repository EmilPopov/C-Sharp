//Write a program that finds the index of given element in a sorted array of integers by using the Binary search algorithm.
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Binary_Search
{
    class BinarySearch
    {
        static void Main()
        {
            int[] numbers = new int[19] { 0, 13, 2, 6, 9, 5, 45, 7, 8, 4, 10, 18, 58, 35, -8, -378, 77, 44, 55 };
            int findNum = 35;
            int index = 0;
            Array.Sort(numbers);
            int center = numbers.Length / 2;
            int currentNum = numbers[center];
            while (findNum != currentNum)
            {
                while (findNum > currentNum)
                {
                    center = (numbers.Length + center) / 2;
                    currentNum = numbers[center];
                }
                while (findNum < currentNum)
                {
                    center = (center) / 2;
                    currentNum = numbers[center];
                }
                index = center;
            }
            Console.WriteLine("{0} is on index {1}",findNum,index);
        }
    }
}
