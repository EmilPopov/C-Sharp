//Write a method that checks if the element at given position in given array of integers is larger than its two neighbours 
using System;


namespace Larger_Than_Neighbours
{
    class LargerThanNeighbours
    {
        static void Main()
        {
            Console.Write("Enter sequense length : ");
            int n = int.Parse(Console.ReadLine());
            int[] arr = new int[n];
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = int.Parse(Console.ReadLine());
            }
            Console.Write("Enter index from 0 to {0} : ", n - 1);
            int index = int.Parse(Console.ReadLine());
            CheckNeighbors(arr, index);
        }

        private static void CheckNeighbors(int[] array, int index)
        {
            if (array[index] > array[index - 1] && array[index] > array[index + 1])
            {
                Console.WriteLine("The number in this index {0} is bigger than previosus {1} and next {2}",
                    array[index], array[index - 1], array[index + 1]);
            }
            else
            {
                Console.WriteLine("The number is less than its neighbors");
            }
        }
    }
}

