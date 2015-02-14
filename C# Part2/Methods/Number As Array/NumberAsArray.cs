//Write a method that adds two positive integer numbers represented as arrays of digits (each array element arr[i] contains a digit; the last digit is kept in arr[0]).
//Each of the numbers that will be added could have up to 10 000 digits.
using System;

namespace Number_As_Array
{
    class NumberAsArray
    {
        static void Main()
        {
            string firstNum = Console.ReadLine();
            string secondNum = Console.ReadLine();
            int[] firstArr = NumberToArray(firstNum);
            int[] secondtArr = NumberToArray(secondNum);
            Console.WriteLine(string.Join(" ",firstArr));
            Console.WriteLine(string.Join(" ", secondtArr));
        }
        static int[] NumberToArray(string num)
        {
            int[] arr = new int[num.Length];
            for (int i = 0; i < num.Length; i++)
                arr[i] = num[i] - '0';
            return arr;
        }
    }
}
