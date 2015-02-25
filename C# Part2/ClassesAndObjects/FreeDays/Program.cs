//Write a method that calculates the number of workdays between today and given date, passed as parameter.
//Consider that workdays are all days from Monday to Friday except a fixed list of public holidays specified preliminary as array.
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FreeDays
{
    class Program
    {
        static void Main()
        {
            int startYear = int.Parse(Console.ReadLine());
            int startMonth = int.Parse(Console.ReadLine());
            int startDay = int.Parse(Console.ReadLine());
            DateTime start = new DateTime(startYear, startMonth, startDay);
            int endYear = int.Parse(Console.ReadLine());
            int endMonth = int.Parse(Console.ReadLine());
            int endDay = int.Parse(Console.ReadLine());
            DateTime end = new DateTime(endYear, endMonth, endDay);
            int days = (int)(end - start).TotalDays;
            int weeks = days / 7;
            // check for a weekend in a partial week from start.
            if (7 - (days % 7) <= (int)start.DayOfWeek)
                days--;
            if (7 - (days % 7) <= (int)start.DayOfWeek)
                days--;

        // check for holidays
        for (int i = startYear; i <= endYear; i++)
        {
            int year = i;

            DateTime[] holidays = new DateTime[10];
            holidays[0] = new DateTime(year, 3, 3);
            holidays[1] = new DateTime(year, 5, 1);
            holidays[2] = new DateTime(year, 5, 6);
            holidays[3] = new DateTime(year, 5, 24);
            holidays[4] = new DateTime(year, 9, 6);
            holidays[5] = new DateTime(year, 9, 22);
            holidays[6] = new DateTime(year, 11, 1);
            holidays[7] = new DateTime(year, 12, 24);
            holidays[8] = new DateTime(year, 12, 26);
            holidays[9] = new DateTime(year, 12, 25);
            foreach (DateTime dt in holidays)
            {
                if ((dt > start) && (dt < end) && (dt.DayOfWeek != DayOfWeek.Saturday) && (dt.DayOfWeek != DayOfWeek.Sunday))
                    days--;
            }
        }
       // lose the weekends
        days -= weeks * 2;
        Console.WriteLine(days);
        }
    }
  }

