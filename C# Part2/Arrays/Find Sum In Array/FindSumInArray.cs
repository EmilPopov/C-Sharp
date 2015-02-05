//Write a program that finds in given array of integers a sequence of given sum S (if present)
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Find_Sum_In_Array
{
    class FindSumInArray
    {
        static void Main()
        {
            int[] numbers = new int[7] { 4, 3, 1, 4, 2, 5, 8 };
            int s = 11;
            int sum = 0;
            List<int> sequence = new List<int>();
            List<int> trueSequence = new List<int>();
            bool findSum = false;
            while (findSum == false)
            {
                for (int i = 0; i < numbers.Length; i++)
                {
                    for (int j = i; j < numbers.Length; j++)
                    {
                        sum += numbers[j];
                        sequence.Add(numbers[j]);                     
                        if (sum == s)
                        {
                            findSum = true;
                            trueSequence.AddRange(sequence);
                            break;
                        }
                    }
                    sum = 0;
                    sequence.Clear();
                }
            }
            if (trueSequence.Count == 0)
            {
                Console.WriteLine("Not found sequence");
            }
            else
            {
                Console.WriteLine(string.Join(" ", trueSequence) + "=" + s);
            }
        }
    }
}
