using System;

namespace PointDemo
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Point point = new Point();
            point.setX(30);
            point.Y = 100;
            point.Y = 130;
            Console.WriteLine(point.ToString());

            Points points = new Points();
            points[0] = new Point(30, 40);
            points[1] = new Point(40, 40);
            points.Print();
        }
    }
}