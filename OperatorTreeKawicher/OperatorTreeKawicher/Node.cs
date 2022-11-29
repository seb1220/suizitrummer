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

        public int Mx { get { return X + RADIUS; } }
        public int My { get { return Y + RADIUS; } }

        protected Node(int x, int y)
        {
            X = x;
            Y = y;
        }

        abstract public void paint(Graphics g);
        abstract public Boolean isIn(int x, int y);

        public Boolean isNear(int x, int y)
        {
            return Math.Sqrt((Mx - x) * (Mx - x) + (My - y) * (My - y)) <= RADIUS * 3;
        }
    }
}
