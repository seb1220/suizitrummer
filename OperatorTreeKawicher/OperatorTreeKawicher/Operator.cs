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
        public Node Left { set; get; }
        public Node Right { set; get; }

        public Operator(int x, int y, string symbol) : base(x, y)
        {
            Symbol = symbol;
        }

        public void paintConn(Graphics g)
        {
            if (Left != null)
                g.DrawLine(new Pen(Color.DeepSkyBlue, 2), Mx, My, Left.Mx, Left.My);
            if (Right != null)
                g.DrawLine(new Pen(Color.DeepSkyBlue, 2), Mx, My, Right.Mx, Right.My);
        }

        public override bool isIn(int x, int y)
        {
            return x <= X + RADIUS * 2 && x >= X && y <= Y + RADIUS * 2 && y >= Y;
        }

        public override void paint(Graphics g)
        {
            // Create font and brush.
            Font drawFont = new Font("Arial", 12);
            SolidBrush drawBrush = new SolidBrush(Color.Black);
            SizeF size  = g.MeasureString(Symbol, drawFont);

            // Draw string to screen.
            g.FillRectangle(new SolidBrush(Color.LightGray), new Rectangle(X, Y, Node.RADIUS * 2, Node.RADIUS * 2));
            g.DrawString(Symbol, drawFont, drawBrush, X + RADIUS - size.Width / 2, Y + RADIUS - size.Height / 2);
            g.DrawRectangle(new Pen(Color.Aqua, 2), new Rectangle(X, Y, Node.RADIUS * 2, Node.RADIUS * 2));
        }
    }
}
