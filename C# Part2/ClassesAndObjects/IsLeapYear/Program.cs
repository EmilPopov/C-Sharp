//Write a program that reads a year from the console and checks whether it is a leap one.
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IsLeapYear
{
    class Program
    {
        static void Main()
        {
            Console.Write("Enter year : ");
            int year = int.Parse(Console.ReadLine());
            DateTime Date = new DateTime(year);
            Console.WriteLine(DateTime.IsLeapYear(year));
        }
    }
}
