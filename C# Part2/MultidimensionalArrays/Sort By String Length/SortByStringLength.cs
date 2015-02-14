//You are given an array of strings. Write a method that sorts the 
//array by the length of its elements (the number of characters composing them).
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sort_By_String_Length
{
    class SortByStringLength
    {
        static void Main()
        {
            string[] arr = new string[5] { "Sofiq", "Plovdiv", "Ruse", "Silistra", "VelikoTurnovo" };
            Array.Sort(arr, (x, y) => x.Length.CompareTo(y.Length));
            foreach (var city in arr)
            {
                Console.Write(city + " ");
            }
            Console.WriteLine();
        }
    }
}
