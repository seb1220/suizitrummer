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

        public Operator(int x, int y, string symbol) : base(x, y)
        {
            Symbol = symbol;
        }

        public override void paint(Graphics g)
        {
            // Create font and brush.
            Font drawFont = new Font("Arial", 16);
            SolidBrush drawBrush = new SolidBrush(Color.Black);

            // Set format of string.
            StringFormat drawFormat = new StringFormat();
            drawFormat.FormatFlags = StringFormatFlags.DirectionVertical;

            // Draw string to screen.
            g.DrawString(Symbol, drawFont, drawBrush, X, Y, drawFormat);
            g.DrawEllipse(new Pen(Color.Red, 7), new Rectangle(X, Y, Node.RADIUS, Node.RADIUS));
        }
    }
}
