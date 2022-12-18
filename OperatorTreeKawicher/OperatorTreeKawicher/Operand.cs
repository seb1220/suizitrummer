using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OperatorTreeKawicher
{
    [Serializable]

    // This class represents an operand in the tree
    internal class Operand : Node
    {
        public int Number { get; private set; }
        public Operand(int x, int y, int number) : base(x - RADIUS, y - RADIUS)
        {
            Number = number;
        }

        public override bool isIn(int x, int y)
        {
            return Math.Sqrt((Mx - x) * (Mx - x) + (My - y) * (My - y)) <= RADIUS;
        }

        public override void paint(Graphics g)
        {
            // Create font and brush.
            Font drawFont = new Font("Arial", 8);
            SolidBrush drawBrush = new SolidBrush(Color.Black);
            SizeF size = g.MeasureString(Number.ToString(), drawFont);

            // Draw string to screen.
            g.FillEllipse(new SolidBrush(Color.Silver), new Rectangle(X, Y, Node.RADIUS * 2, Node.RADIUS * 2));
            g.DrawString(Number.ToString(), drawFont, drawBrush, X + RADIUS - size.Width / 2, Y + RADIUS - size.Height / 2);
            if (IsSelected)
                g.DrawEllipse(new Pen(Color.Red, 2), new Rectangle(X, Y, Node.RADIUS * 2, Node.RADIUS * 2));
            else
                g.DrawEllipse(new Pen(Color.Fuchsia, 2), new Rectangle(X, Y, Node.RADIUS * 2 , Node.RADIUS * 2));
        }

        public override string ToString()
        {
            return Number.ToString();
        }
    }
}
