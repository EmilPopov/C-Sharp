//Write a program that reads two integer numbers N and K and an array of N elements from the console.
//Find in the array those K elements that have maximal sum.
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Maximal_K_Sum
{
    class MaximalKSum
    {
        static void Main()
        {
            Console.Write("Enter N : ");
            int n = int.Parse(Console.ReadLine());
            Console.Write("Enter K : ");
            int k = int.Parse(Console.ReadLine());
            int[] numbers = new int[n];
            int currentSum = 0;
            int maxSum = 0;
            List<int> sequence = new List<int>();
            List<int> maxSumSequence = new List<int>();
            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = int.Parse(Console.ReadLine());
            }
            for (int i = 0; i <= numbers.Length - k; i++)
            {
                for (int j = i; j < k + i; j++)
                {
                    currentSum += numbers[j];
                    sequence.Add(numbers[j]);
                }
                if (currentSum > maxSum)
                {
                    maxSum = currentSum;
                    maxSumSequence.Clear();             // clear old sequence
                    maxSumSequence.AddRange(sequence);  // add elements from other List<>
                }
                currentSum = 0;
                sequence.Clear();
            }
            Console.WriteLine(string.Join("+",maxSumSequence) + "=" + maxSum);
        }
    }
}
