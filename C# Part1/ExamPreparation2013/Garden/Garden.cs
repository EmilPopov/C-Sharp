using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Garden
{
    class Garden
    {
        static void Main()
        {
            List<double> seedsPrice = new List<double>() { 0.5, 0.4, 0.25, 0.6, 0.3, 0.4 };
            List<int> seedsAmount = new List<int>();
            List<int> areas = new List<int>();
            double totalCosts = 0;
            int totalArea = 0;
            for (int i = 0; i < 11; i++)
            {
                if (i % 2 == 0)
                {
                    seedsAmount.Add(int.Parse(Console.ReadLine()));
                }
                else
                {
                    areas.Add(int.Parse(Console.ReadLine()));
                }
            }
            for (int i = 0; i < seedsAmount.Count; i++)
            {
                totalCosts += seedsAmount[i] * seedsPrice[i];
            }
            Console.WriteLine("Total costs: {0:F2}",totalCosts);
            for (int i = 0; i < areas.Count; i++)
            {
                totalArea += areas[i];
            }
            if (totalArea < 250)
            {
                Console.WriteLine("Beans area: {0}",250 - totalArea);
            }
            else if (totalArea == 250)
            {
                Console.WriteLine("No area for beans");
            }
            else if (totalArea > 250)
            {
                Console.WriteLine("Insufficient area");
            }
        }
    }
}
