namespace Assertions
{
    using System;
    using System.Diagnostics;

    public static class CustomSort
    {
        public static void SelectionSort<T>(T[] arr) where T : IComparable<T>
        {
            for (int index = 0; index < arr.Length - 1; index++)
            {
                int minElementIndex = FindMinElementIndex(arr, index, arr.Length - 1);
                Swap(ref arr[index], ref arr[minElementIndex]);
            }
        }

        private static int FindMinElementIndex<T>(T[] arr, int startIndex, int endIndex)
            where T : IComparable<T>
        {
            Debug.Assert(arr.Length > 0, "Empty array.");
            Debug.Assert(arr.Length <= int.MaxValue, "Length of array is too big.");
            Debug.Assert(startIndex >= 0, "Start index is not greater than or equal to 0.");
            Debug.Assert(endIndex > 0, "End index is not greater than 0.");
            Debug.Assert(startIndex < endIndex, "End index is not greater than start index.");

            int minElementIndex = startIndex;
            for (int i = startIndex + 1; i <= endIndex; i++)
            {
                if (arr[i].CompareTo(arr[minElementIndex]) < 0)
                {
                    minElementIndex = i;
                }
            }

            Debug.Assert(TestAssistant.GetMinValue(arr, startIndex, endIndex).CompareTo(arr[minElementIndex]) == 0, "minElementIndex is not the index of min value.");

            return minElementIndex;
        }

        private static void Swap<T>(ref T x, ref T y)
        {
            T oldX = x;
            x = y;
            y = oldX;
        }
    }
}