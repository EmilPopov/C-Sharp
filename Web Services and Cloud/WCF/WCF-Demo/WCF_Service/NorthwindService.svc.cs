using ClassLibrary;
using System;
using System.Linq;
using System.ServiceModel;
using System.Text.RegularExpressions;

namespace WCF_Service
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.
    public class NorthwindService : INorthwindService
    {
        public int GetCitiesCount()
        {
            var db = new NorthwindEntities();
            var count = db.Cities.Count();
            return count;
        }

        public decimal? GetProductUnitPrice(int productId)
        {
            var db = new NorthwindEntities();
            var unitPrice = db.Products
                .Where(p => p.ProductID == productId)
                .Select(up => up.UnitPrice)
                .FirstOrDefault();

            return unitPrice;
        }

        public ProductInfo GetProductInfo(int productId)
        {
            var db = new NorthwindEntities();
            var productInfo = db.Products
                .Where(p => p.ProductID == productId)
                .Select(p => new ProductInfo
                {
                    Id = p.ProductID,
                    Name = p.ProductName,
                    UnitPrice = p.UnitPrice
                }).FirstOrDefault();

            return productInfo;
        }

        public string GetDayToBgString(DateTime date)
        {
            var culture = new System.Globalization.CultureInfo("bg-BG");
            var day = culture.DateTimeFormat.GetDayName(date.DayOfWeek);
            return day;
        }

        public int GetSubstrCount(string content, string substring)
        {
            
            return Regex.Matches(content, substring).Count;
         
        }
    }
}

