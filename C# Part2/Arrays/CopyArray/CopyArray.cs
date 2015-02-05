using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CopyArray
{
    class CopyArray
    {
        static void Main()
        {
            // COPY ARRAY
            int[] myArray = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            int[] copyArray = (int[])myArray.Clone();
            myArray[5] = -1111;
            Console.WriteLine(string.Join(",", myArray));
            Console.WriteLine(string.Join(",", copyArray));
        }
    }
}
