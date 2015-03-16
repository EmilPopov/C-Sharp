using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StructureProgram
{
    public static class Distance
    {
        public static double Calculate(Point3D firstPoint, Point3D secondPoind)
        {
            return Math.Sqrt(Math.Pow(firstPoint.X - secondPoind.X, 2)
                   + Math.Pow(firstPoint.Y - secondPoind.Y, 2)
                   + Math.Pow(firstPoint.Z - secondPoind.Z, 2));
        }
    }
}
