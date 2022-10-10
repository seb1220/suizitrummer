using System;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;

namespace PointDemo
{
    public class Points
    {
        private Point[] points;

        public static readonly int MAX = 10;

        public Points() : this(MAX)
        {
            
        }

        public Points(int size)
        {
            points = new Point[size];
        }

        public Point this[int index]
        {
            set
            {
                points[index] = value;
            }

            get
            {
                return points[index];
            }
        }
        
        public void Print()
        {
            Console.WriteLine("Points:");
            foreach (var point in points)
            {
                Console.WriteLine(point);
            }
        }    
    }
}