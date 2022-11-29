﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OperatorTreeKawicher
{
    internal class Operand : Node
    {
        int Number { get; set; }
        public Operand(int x, int y, int number) : base(x, y)
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
            g.DrawEllipse(new Pen(Color.Fuchsia, 2), new Rectangle(X, Y, Node.RADIUS * 2 , Node.RADIUS * 2));
        }
    }
}
