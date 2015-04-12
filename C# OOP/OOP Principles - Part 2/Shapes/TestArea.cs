using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes
{
    class TestArea
    {
        public static void Main()
        {
            var shapes = new List<Shape>
           {
               new Triangle(4,5.3),
               new Rectangle(56,7.3),
               new Square(10),
           };
            foreach (var shape in shapes)
            {
                Console.WriteLine(shape.GetType().Name + " - " + shape.CalculateSurface());
            }
        }
    }
}
