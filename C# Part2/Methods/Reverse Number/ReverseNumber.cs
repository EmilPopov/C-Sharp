//Write a method that reverses the digits of given decimal number.
using System;


namespace Reverse_Number
{
    class ReverseNumber
    {
        static void Main()
        {
            Console.Write("Enter number : ");
            int num = int.Parse(Console.ReadLine());
            Console.WriteLine("Reverse number : " + ReverseNum(num));
        }

        private static int ReverseNum(int num)
        {
            int count = DigitsCount(num);
            int reverseNum = 0;
            int digit = 0;
            for (int i = count - 1; i >= 0; i--)
            {
                digit = num % 10;
                num /= 10;
                reverseNum += digit * (int)Math.Pow(10, i);
            }
            return reverseNum;
        }

        private static int DigitsCount(int num)
        {
            int count = 0;
            while (num > 0)
            {
                num /= 10;
                count++;
            }
            return count;
        }
    }
}
