//Write a method that return the maximal element in a portion of array of integers starting at given index.
//Using it write another method that sorts an array in ascending / descending order.
using System;


namespace Sorting_Array
{
    class SortingArray
    {
        static void Main()
        {
            int[] arr = ReadArray();
            int start = int.Parse(Console.ReadLine());
            int end = int.Parse(Console.ReadLine());
            Console.WriteLine("Max element in partion {0} - {1} => {2}",start,end,MaxElemInPartOfArray(arr,start,end));
            Console.WriteLine(string.Join(" ",SortArray(arr)));
            Array.Reverse(arr);
            Console.WriteLine(string.Join(" ", arr));

        }
        private static int MaxElemInPartOfArray(int[] arr, int start, int stop)
        {
            for (int i = start; i < stop; i++)
            {
                for (int j = i + 1; j <= stop; j++)
                {
                    if (arr[j] > arr[i])
                    {
                        int swap = arr[i];
                        arr[i] = arr[j];
                        arr[j] = swap;
                    }
                }
            }
            int maxElem = arr[start];
            return maxElem;
        }
        private static int[] SortArray(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = i + 1; j < arr.Length; j++)
                {
                    if (arr[j] > arr[i])
                    {
                        int swap = arr[i];
                        arr[i] = arr[j];
                        arr[j] = swap;
                    }
                }
            }

            return arr;
        }
        private static int[] ReadArray()
        {
            Console.Write("Enter array length : ");
            int n = int.Parse(Console.ReadLine());
            int[] arr = new int[n];
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write("Index[{0}] = ", i);
                arr[i] = int.Parse(Console.ReadLine());
            }
            return arr;
        }
    }
}
