//Write a program that prints to the console which day of the week is today
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WhichDayIsToday
{
    class DayOfWeek
    {
        static void Main()
        {
            DateTime Today = DateTime.Today;
            Console.WriteLine(Today.DayOfWeek);
        }
    }
}
