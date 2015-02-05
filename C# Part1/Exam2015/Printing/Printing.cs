using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Printing
{
    class Printing
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            int s = int.Parse(Console.ReadLine());
            double p = double.Parse(Console.ReadLine());

            int totalPaper = n * s;
            double reams = totalPaper / 500.00;
            double price = reams * p;
            Console.WriteLine("{0:F2}",price);
        }
    }
}
