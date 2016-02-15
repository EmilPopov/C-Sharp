namespace NorthwindEntity
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Startup
    {
        static void Main()
        {
            // 2.Using the Visual Studio Entity Framework designer create a DbContext for the Northwind database. 
            //TestCustomerFunctionality();

            Console.WriteLine("********************************************");


            // 3.Write a method that finds all customers who have orders made in 1997 and shipped to Canada.

            var customers = NorthwindMethods.FindCustomersWithOrdersByCountryAndYear("Canada", 1997);
            DisplayResult(customers);

            Console.WriteLine("********************************************");

            // 4.Implement previous by using native SQL query and executing it through the DbContext.

            var nativeSQLCustomers = NorthwindMethods.FindCustomersWithNativeQUery("Canada", 1997);
            DisplayResult(nativeSQLCustomers);

            Console.WriteLine("********************************************");

            // 5.Write a method that finds all the sales by specified region and period (start / end dates)

            var orders = NorthwindMethods.FindAllTheSalesBySpecifiedRegionAndPeriod("RJ", new DateTime(1998, 01, 01), new DateTime(2000, 01, 01));
            DisplayResult(orders);
        }

        public static void TestCustomerFunctionality()
        {
            string phone = "0888/33-44-47";
            string customerId = "KOKO";
            Customer customer = new Customer()
            {
                CustomerID = "KOKO",
                CompanyName = "Zamunda"
            };

            var newCustomerId = CustomerFunctionality.Insert(customer);

            //CustomerFunctionality.UpdatePhone(customerId, phone);

            //CustomerFunctionality.Delete(customerId);
        }

        public static void DisplayResult(ICollection<string> result)
        {
            foreach (var name in result)
            {
                Console.WriteLine(name);
            }
        }
    }
}
