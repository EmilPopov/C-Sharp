//Write a method that returns the index of the first element in array that is larger than its neighbours, or -1, if there’s no such element.
//Use the method from the previous exercise.
using System;


namespace First_Larger_Than_Neighbours
{
    class FirstLargerThanNeighbours
    {
        static void Main()
        {
            CheckNeibours(ReadArray());
        }

        private static void CheckNeibours(int[] array)
        {
            int counter = 0;
            for (int i = 1; i < array.Length - 1; i++)
            {
                if (array[i] > array[i - 1] && array[i] > array[i + 1])
                {
                    Console.WriteLine("Index = {0}  Number = {1}", i, array[i]);
                    counter++;
                    break;
                }
            }
            if (counter == 0)
            {
                Console.WriteLine("Not found");
            }
        }

        private static int[] ReadArray()
        {
            Console.Write("Enter sequence length : ");
            int n = int.Parse(Console.ReadLine());
            int[] arr = new int[n];
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = int.Parse(Console.ReadLine());
            }
            return arr;
        }
    }
}
