//Write a program to read your birthday from the console and print how old you are now and how old you will be after 10 years.
using System;


namespace Age_after_10_Years
{
    class CalcMyAge
    {
        static void Main(string[] args)
        {
            Console.Write("Enter Your Birthday DD.MM.YYYY : ");
            DateTime birthday = DateTime.Parse(Console.ReadLine());
            DateTime now = DateTime.Today;
            int yourAge = now.Year - birthday.Year;
            Console.WriteLine("Your Age Is : " + yourAge);
            Console.WriteLine("Your Age After 10 Years : {0}",yourAge + 10);
        }
    }
}
