namespace Assertions
{
    using System;

    public class Start
    {
        public static void Main()
        {
            int[] arr = new int[] { 3, -1, 15, 4, 17, 2, 33, 0 };

            Console.WriteLine("arr = [{0}]", string.Join(", ", arr));
            CustomSort.SelectionSort(arr);
            Console.WriteLine("sorted = [{0}]", string.Join(", ", arr));

            CustomSort.SelectionSort(new int[0]); // Test sorting empty array
            CustomSort.SelectionSort(new int[1]); // Test sorting single element array

            Console.WriteLine(Search.BinarySearch(arr, -1000));
            Console.WriteLine(Search.BinarySearch(arr, 0));
            Console.WriteLine(Search.BinarySearch(arr, 17));
            Console.WriteLine(Search.BinarySearch(arr, 10));
            Console.WriteLine(Search.BinarySearch(arr, 1000));
        }
    }
}