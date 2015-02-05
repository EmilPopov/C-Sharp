//Write a program that finds the most frequent number in an array.
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Frequent_Number
{
    class FrequentNumber
    {
        static void Main()
        {
            int currentCounter = 1;
            int counter = 0;
            int mostFrequentNumber = 0;
            int[] numbers = new int[13] { 4, 1, 1, 4, 2, 3, 4, 4, 1, 2, 4, 9, 3 };
            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] != mostFrequentNumber)
                {
                    for (int j = i + 1; j < numbers.Length - i ; j++)
                    {
                        if (numbers[j] == numbers[i])
                        {
                            currentCounter++;
                        }
                    }
                    if (currentCounter > counter)
                    {
                        counter = currentCounter;
                        mostFrequentNumber = numbers[i];
                    }
                    currentCounter = 1;
                }
            }
            Console.WriteLine("{0} ({1} times)", mostFrequentNumber, counter);
        }
    }
}

