//Write a program that sorts an array of strings using the Quick sort algorithm.
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quick_Sort
{
    class QuickSortArray
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            int[] arrayToSort = new int[n];
            for (int i = 0; i < n; i++)
            {
                arrayToSort[i] = int.Parse(Console.ReadLine());
            }
            QuickSort(arrayToSort);
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine(arrayToSort[i]);
            }
        }

        private static void QuickSort(int[] arrayToSort)
        {
            QuickSortHelper(arrayToSort, 0, arrayToSort.Length - 1);
        }

        private static void QuickSortHelper(int[] arrayToSort, int left, int right)
        {
            if (left < right)
            {
                Random pivotChooser = new Random();
                int pivot = pivotChooser.Next(left, right);
                int newPivot = Partition(arrayToSort, left, right, pivot);
                QuickSortHelper(arrayToSort, left, newPivot - 1);
                QuickSortHelper(arrayToSort, newPivot + 1, right);
            }
        }

        private static int Partition(int[] arrayToSort, int left, int right, int pivot)
        {
            int pivotValue = arrayToSort[pivot];

            int swapValueForPivot = arrayToSort[pivot];
            arrayToSort[pivot] = arrayToSort[right];
            arrayToSort[right] = swapValueForPivot;

            int storeIndex = left;
            for (int i = left; i < right; i++)
            {
                if (arrayToSort[i] < pivotValue)
                {
                    int swapValueForStoreIndex = arrayToSort[storeIndex];
                    arrayToSort[storeIndex] = arrayToSort[i];
                    arrayToSort[i] = swapValueForStoreIndex;
                    storeIndex++;
                }
            }

            int swapValueForFinalStoreIndex = arrayToSort[storeIndex];
            arrayToSort[storeIndex] = arrayToSort[right];
            arrayToSort[right] = swapValueForFinalStoreIndex;

            return storeIndex;

        }
    }
}
