//Write a program to convert decimal numbers to their hexadecimal representation
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecimalToHexadecimal
{
    class DecimalToHexadecimal
    {
        static void Main()
        {
            int num = 2934;
            string hexNum = num.ToString("X");
            Console.WriteLine(hexNum);
            // Or-------------------------------------
            string hex = String.Empty;
            while (num != 0)
            {
                if (num % 16 >=10 )
                {
                    hex = ((char)('A' + (num % 16) - 10)) + hex;
                }
                else
                {
                    hex = ((char)('0' + num % 16)) + hex;
                }
                num /= 16;
            }
            Console.WriteLine(hex);
           
        }
    }
}
