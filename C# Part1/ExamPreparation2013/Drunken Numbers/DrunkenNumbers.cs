using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Drunken_Numbers
{
    class DrunkenNumbers
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            List<string> numbers = new List<string>();
            List<char> digits = new List<char>();
            int sumMitko = 0;
            int sumVladko = 0;
            for (int i = 0; i < n; i++)
            {
                string drunkenNumber = Console.ReadLine();
                numbers.Add(drunkenNumber);
                digits = numbers[i].ToList<char>();
                if (digits[0] == '-')
                {
                    digits.Remove(digits[0]);
                }

                for (int j = 0; j <= digits.Count / 2; j++)
                {
                    if (digits[j] == '0')
                    {
                        continue;
                    }
                    else if ((digits.Count % 2 == 0) && (j == digits.Count / 2))
                    {
                        sumMitko -= (digits[digits.Count / 2] - '0');
                    }
                    sumMitko += (digits[j] - '0');
                }
                for (int j = digits.Count - 1; j >= digits.Count / 2; j--)
                {
                    if (digits[j] == '0')
                    {
                        continue;
                    }
                    sumVladko += (digits[j] - '0');
                }
                digits.Clear();
            }
            if (sumMitko > sumVladko)
            {
                Console.WriteLine("M {0}", sumMitko - sumVladko);
            }
            else if (sumVladko > sumMitko)
            {
                Console.WriteLine("V {0}", sumVladko - sumMitko);
            }
            else
            {
                Console.WriteLine("No {0}", sumMitko + sumVladko);
            }
        }
    }
}
