//Write a program, that reads from the console an array of N integers and an integer K, 
//sorts the array and using the method Array.BinSearch() finds the largest number in the array which is ≤ K
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
            int n = int.Parse(Console.ReadLine());
            int k = int.Parse(Console.ReadLine());
            int[] numbers = new int[n];
            for (int i = 0; i < n; i++)
            {
                numbers[i] = int.Parse(Console.ReadLine());
            }
            Array.Sort(numbers);
            if (numbers[0] > k)
            {
                Console.WriteLine("There is no number that is less than or equal to K.");
            }
            else
            {
                int largestNumberIndex = Array.BinarySearch(numbers, k);                
                while (largestNumberIndex < 0)
                {
                    k--;
                    largestNumberIndex = Array.BinarySearch(numbers, k);
                }
                Console.WriteLine("The largest number in the array less than or equal to K : {0}", numbers[largestNumberIndex]);
            }

        }
    }
}
