//We are given a date (day + month + year). Write a program to print the next day.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Next_Date
{
    class NextDate
    {
        static void Main()
        {
            int day = int.Parse(Console.ReadLine());
            int month = int.Parse(Console.ReadLine());
            int year = int.Parse(Console.ReadLine());
            DateTime date = new DateTime(year,month,day);
            DateTime myDate = date.AddDays(1);
            Console.WriteLine(myDate.ToString("d.M.yyyy"));
        }
    }
}
