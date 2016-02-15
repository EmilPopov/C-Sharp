
namespace NorthwindEntity
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class NorthwindMethods
    {
        public static ICollection<string> FindCustomersWithOrdersByCountryAndYear(string country, int year)
        {
            using (var db = new NorthwindEntities())
            {
                var result = db.Orders
                    .Where(o => o.ShipCountry == country && o.ShippedDate.Value.Year == year)
                    .Select(c => c.Customer.ContactName)
                    .Distinct()
                    .ToList();
                return result;
            }
        }

        public static ICollection<string> FindCustomersWithNativeQUery(string country, int year)
        {
            using (var northwindEntities = new NorthwindEntities())
            {
                string nativeSqlQuery =
                        "SELECT DISTINCT c.ContactName AS [ContactName]" +
                        "FROM Orders o " +
                        "JOIN Customers c ON c.CustomerID = o.CustomerID " +
                        "WHERE o.ShipCountry = '" + country + "'" +
                        " AND DATEPART(YEAR, o.ShippedDate) = " + year;

                var customers = northwindEntities.Database.SqlQuery<string>(nativeSqlQuery).ToList();
                return customers;
            }
        }

        public static ICollection<string> FindAllTheSalesBySpecifiedRegionAndPeriod(string region, DateTime startDate, DateTime endDate)
        {
            using (var db = new NorthwindEntities())
            {
                var result = db.Orders
                    .Where(o => o.ShipRegion == region && o.ShippedDate > startDate && o.ShippedDate < endDate)
                    .OrderBy(sd => sd.ShippedDate)
                    .Select(o => o.ShipName)
                    .Distinct()
                    .ToList();
                return result;
            }
        }
    }
}
