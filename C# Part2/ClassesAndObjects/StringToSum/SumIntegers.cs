//You are given a sequence of positive integer values written into a string, separated by spaces.
//Write a function that reads these values from given string and calculates their sum
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringToSum
{
    class SumIntegers
    {
        static void Main(string[] args)
        {
            string s = "30 27 45 9 17 61";
            Console.WriteLine("The sum of this numbers is {0}",SumTheString(s)); 
        }
        static int SumTheString(string str)
        {
            int sum = 0;
            string[] numbers = str.Split(' ');
            for (int i = 0; i < numbers.Length; i++)
            {
                sum+=int.Parse(numbers[i]);
            }
            return sum;
        }
        
    }
}
