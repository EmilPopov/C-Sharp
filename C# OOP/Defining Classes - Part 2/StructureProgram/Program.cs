using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StructureProgram
{
    class Program
    {
        static void Main()
        {
            Point3D pointOne = new Point3D(1,2,3);
            Point3D pointTwo = new Point3D(4,5,6);
            Console.WriteLine(pointOne.X);
            Console.WriteLine(pointOne.ToString());
            Console.WriteLine(Point3D.O);
            double distanse = Distance.Calculate(pointOne, pointTwo);
            Path myPath = new Path();
            myPath.Add(pointOne,pointTwo);
            Console.WriteLine(myPath.ToString());   
        }
    }
}
