using System;
using System.Collections.Generic;
using System.Linq;


namespace Longest_String
{
    class LongestString
    {
        static void Main()
        {
            var strList = new List<string>() { "a", "az", "azazzaa", "zzzaz", "zzzzzzzzzzzzz", "yhkh", "end", };
            var stringWithMaximalLength = strList.Aggregate((max, current) => max.Length > current.Length ? max : current);
            Console.WriteLine(stringWithMaximalLength);

        }
    }
}
