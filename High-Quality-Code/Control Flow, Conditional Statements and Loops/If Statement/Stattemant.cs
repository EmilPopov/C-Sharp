using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conditional_Statment_HQC
{
    public class Stattemant
    {       
        public static void Main()
        {
            const int MIN_X = 1;
            const int MAX_X = 100;
            const int MIN_Y = 1;
            const int MAX_Y = 100;

            int x = 10;
            int y = 30;

            bool shouldVisitCell = true;

            if (inRange(MAX_X,MIN_X,x) && inRange(MAX_Y,MIN_Y,y) && (shouldVisitCell))
            {
                VisitCell();
            }
            else
            {
                Console.WriteLine("Not");
            }
        }

        private static void VisitCell()
        {
            Console.WriteLine("Cell is visited");
        }
        public static  bool inRange(int max, int min, int value)
        {
            bool isInRange = (max >= value) && (value >= min);
            return isInRange;
        }
    }
}

