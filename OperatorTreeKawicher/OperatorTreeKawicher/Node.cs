using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OperatorTreeKawicher
{
    internal abstract class Node
    {
        protected const int RADIUS = 15;
        protected int X { get; set; }
        protected int Y { get; set; }

        protected Node(int x, int y)
        {
            X = x;
            Y = y;
        }

        abstract public void paint(Graphics g);
        public Boolean isIn(int x, int y)
        {
            return Math.Sqrt((X - x) * (X - x) + (Y - y) * (Y - y)) <= RADIUS;
        }
    }
}
