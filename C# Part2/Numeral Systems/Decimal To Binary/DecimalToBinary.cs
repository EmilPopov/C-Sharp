//Write a program to convert decimal numbers to their binary representation.
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decimal_To_Binary
{
    class DecimalToBinary
    {
        static void Main()
        {
            int number = 151;
            string binaryNum = string.Empty;
            string binary = Convert.ToString(number, 2);
            Console.WriteLine(binary);
            // Or 
            while (number != 0)
            {
                binaryNum = number % 2 + binaryNum;
                number /= 2;
            }
            Console.WriteLine(binaryNum);
        }
    }
}
