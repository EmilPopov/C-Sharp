//A company has name, address, phone number, fax number, web site and manager. The manager has first name, last name, age and a phone number.
//Write a program that reads the information about a company and its manager and prints it back on the console.
using System;


namespace Print_Company_Information
{
    class CompanyInformation
    {
        static void Main()
        {
            Console.WriteLine("Please enter a infornation about your company:");
            Console.Write("Name: ");
            string name = Console.ReadLine();
            Console.Write("Address: ");
            string address = Console.ReadLine();
            Console.Write("Phone: ");
            long phone = long.Parse(Console.ReadLine());
            Console.Write("Fax: ");
            long fax = long.Parse(Console.ReadLine());
            Console.Write("Web Sait: ");
            string sait = Console.ReadLine();
            Console.WriteLine();

            Console.WriteLine("Who is your manager: ");
            Console.Write("First Name: ");
            string firstName = Console.ReadLine();
            Console.Write("Last Name: ");
            string lastName = Console.ReadLine();
            Console.Write("Age: ");
            int age = int.Parse(Console.ReadLine());
            Console.Write("Phone Number: ");
            long managerPhone = long.Parse(Console.ReadLine());
            Console.WriteLine("The contacts of {0} company:phone ({1}),fax ({2}),web sait {3}." +
            "Their manager is {4} {5}.He is {6} years old.His phone number is {7}.The address of the company is {8}", name, phone, fax, sait,
            firstName, lastName, age, managerPhone, address);
        }
    }
}
