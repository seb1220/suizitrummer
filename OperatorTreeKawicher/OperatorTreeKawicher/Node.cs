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
        protected const int RADIUS = 20;
        public int X { get; set; }
        public int Y { get; set; }

        protected Node(int x, int y)
        {
            X = x;
            Y = y;
        }

        abstract public void paint(Graphics g);
        abstract public Boolean isIn(int x, int y);

        public Boolean isNear(int x, int y)
        {
            return Math.Sqrt((X + RADIUS - x) * (X + RADIUS - x) + (Y + RADIUS - y) * (Y + RADIUS - y)) <= RADIUS * 3;
        }
    }
}
