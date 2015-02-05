//Write a program that takes as input a four-digit number in format abcd (e.g. 2011) and performs the following:
//Calculates the sum of the myArray (in our example 2 + 0 + 1 + 1 = 4).
//Prints on the console the number in reversed order: dcba (in our example 1102).
//Puts the last digit in the first position: dabc (in our example 1201).
//Exchanges the second and the third numString: acbd (in our example 2101).
using System;


namespace Four_Digit_Number
{
    class FourDigitNumber
    {
        static void Main()
        {
            Console.Write("Enter 4 digit number:");
            int num = int.Parse(Console.ReadLine());
            int d = num % 10;
            int c = (num / 10) % 10;
            int b = (num / 100) % 10;
            int a = (num / 1000) % 10;
            int sum = a + b + c + d;
            int[] myArray = new int[] { a, b, c, d };
            Array.Reverse(myArray);
            string reverse = string.Join("", myArray);
            string numString = num.ToString();
            string lastDigitFirst = "" + numString[numString.Length - 1];
            for (int i = 0; i < numString.Length - 1; i++)
            {
                lastDigitFirst += numString[i];
            }
            string changePosition = numString[0].ToString() + numString[2] + numString[1] + numString[3];
            Console.WriteLine(changePosition);
            Console.WriteLine(lastDigitFirst);
            Console.WriteLine(reverse);
            Console.WriteLine(sum);
        }
    }
}
