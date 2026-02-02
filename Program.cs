using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Containment2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Circle c = new Circle(1,2,3);

            Console.WriteLine(c.BuiltString());

            c.Center.X = 4;
            c.Center.Y = 5;
            c.Radius = 6;

            Console.WriteLine("Area: {0:F2}", c.Area());
        }
    }
    public class Point
    {
        private int x;
        private int y;

        public int X
        {
            get { return x; }
            set { x = value; }
        }
        public int Y
        {
            get { return y; }
            set { y = value; }
        }

        public Point() { }
        public Point(int x1,int y1)
        {
            x = x1;
            y = y1;
        }

        public string BuiltString()
        {
            return " [ " + x + " , " + y + " ] ";
        }
    }//End Point class
    public class Circle
    {
        private Point center; //Container or Composition
        private int radius;

        public int Radius
        {
            get { return radius; }
            set { radius = value; }
        }
        public Point Center
        {
            get { return center; }
        }

        public Circle()
        {
            center = new Point();
        }

        public Circle(int x1,int y1,int r)
        {
            center = new Point(x1, y1);

            radius = r;
        }

        public string BuiltString()
        {
            return center.BuiltString()  + "Radius: " + radius;
        }

        public double Area()
        {
            return Math.PI * Math.Pow(radius, 2);
        }
    }
}
