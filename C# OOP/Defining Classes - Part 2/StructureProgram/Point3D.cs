

using System;
using System.Text.RegularExpressions;
namespace StructureProgram

{

    public struct Point3D
    {
        public static readonly char separator ='-';

        private double x;
        private double y;
        private double z;
        private static readonly Point3D o = new Point3D(0, 0, 0);
        public static Point3D O
        {
            get { return o; }
        }
          
        public double X { get; set; }
        public double Y { get; set; }
        public double Z { get; set; }
      
        public Point3D(double x,double y ,double z):this()
        {
            this.X = x;
            this.Y = y;
            this.Z = z;
        }
        public static Point3D Parse(string points)
        {
            string[] coordinates = points.Split(separator);

            return new Point3D(double.Parse(coordinates[0]), double.Parse(coordinates[1]),double.Parse(coordinates[2]));
        }
        public override string ToString()
        {
            return string.Format("X : {0}  Y : {1}  Z : {2}", this.X, this.Y, this.Z);
        }



    }
}
