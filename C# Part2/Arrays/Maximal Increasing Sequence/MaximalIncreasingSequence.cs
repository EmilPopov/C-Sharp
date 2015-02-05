//Write a program that finds the maximal increasing sequence in an array
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Maximal_Increasing_Sequence
{
    class MaximalIncreasingSequence
    {
        static void Main()
        {
            int[] arr = { 4, 5, 6, 7, 8, 3, 23, 24, 25, 26, 27, 28, 29, 10, 11 };
            List<int> currentNum = new List<int>();
            List<int> sequence = new List<int>();
            for (int i = 0; i < arr.Length - 1; i++)
            {
                if ((arr[i] < arr[i + 1]) && (arr[i + 1] - arr[i] == 1))
                {
                    currentNum.Add(arr[i]);
                    currentNum.Add(arr[i] + 1);

                    if (currentNum.Count > sequence.Count)
                    {
                        sequence.Clear();
                        sequence.AddRange(currentNum);
                    }
                }
                else
                {
                    currentNum.Clear();
                }
            }
            List<int> increasingElements = sequence.Distinct().ToList();    // Remove equal elements
            Console.Write("The Max Sequence of Increasing Elements is : ");
            for (int i = 0; i < increasingElements.Count; i++)
            {
                Console.Write(" " + increasingElements[i] + " ");

            }
            Console.WriteLine();
        }
    }
}
