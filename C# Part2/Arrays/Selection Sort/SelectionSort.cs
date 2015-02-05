//Sorting an array means to arrange its elements in increasing order. Write a program to sort an array.
//Use the Selection sort algorithm: Find the smallest element, move it at the 
//first position, find the smallest from the rest, move it at the second position, etc.
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Selection_Sort
{
    class SelectionSort
    {
        static void Main()
        {
            int[] arr = { 2, 4, 67, 34, 6, 9, 1, };

            int min;
            int change;
            for (int i = 0; i < arr.Length - 1; i++)
            {
                min = i;
                for (int j = i + 1; j < arr.Length; j++)
                {
                    if (arr[i] > arr[j])
                    {
                        min = j;                // take index of smallest element
                    }
                }
                change = arr[i];                // a=b  b=c  c=a
                arr[i] = arr[min];
                arr[min] = change;
            }
            foreach (var numbers in arr)
            {
                Console.WriteLine(" " + numbers + " ");
            }
        }
    }
}
