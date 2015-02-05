using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Text_to_Number
{
    class TextToNumber
    {
        static void Main()
        {
            int m = int.Parse(Console.ReadLine());
            string text = Console.ReadLine().ToUpper();
            char[] chars = text.ToCharArray();
            long result = 0;
            for (int i = 0; i < chars.Length; i++)
            {
                if (chars[i] == '@')
                {
                    break;
                    // print result
                }
                else if (Char.IsDigit(chars[i]))
                {
                    result *= chars[i] - '0';
                }
                else if ((64 < chars[i]) && (chars[i]<=90))
                {
                    result += chars[i] - 65;
                }
                else
                {
                    result %= m;
                }
            }
            Console.WriteLine(result);
        }
    }
}
