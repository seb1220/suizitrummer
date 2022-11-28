using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OperatorTreeKawicher
{
    internal class Operator : Node
    {
        string Symbol { set; get; }
        Node Left { set; get; }
        Node Right { set; get; }

        public Operator(int x, int y, string symbol) : base(x, y)
        {
            Symbol = symbol;
        }



        public override void paint(Graphics g)
        {
            // Create font and brush.
            Font drawFont = new Font("Arial", 12);
            SolidBrush drawBrush = new SolidBrush(Color.Black);
            SizeF size  = g.MeasureString(Symbol, drawFont);

            // Draw string to screen.
            g.DrawString(Symbol, drawFont, drawBrush, X + RADIUS - size.Width / 2, Y + RADIUS - size.Height / 2);
            g.DrawRectangle(new Pen(Color.Aqua, 1), new Rectangle(X, Y, Node.RADIUS * 2, Node.RADIUS * 2));
        }
    }
}
