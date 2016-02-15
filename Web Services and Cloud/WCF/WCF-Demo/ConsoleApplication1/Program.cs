using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibrary;
namespace ConsoleApplication1
{
    public class Program
    {
        static void Main()
        {
            NorthwindEntities db = new NorthwindEntities();
            var count = db.Country.Count();
            Console.WriteLine(count);
        }
    }
}
