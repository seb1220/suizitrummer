using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OperatorTreeKawicher
{
    public partial class FrmMain : Form
    {
        NodeManagement nm;
        int x = 0;
        int y = 0;
        int dx;
        int dy;
        Node move = null;
        Operator conn = null;
        public FrmMain()
        {
            InitializeComponent();
            nm = new NodeManagement();
        }

        private void viewToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void cmiOperator_Click(object sender, EventArgs e)
        {
            DialogOperator dialogOperator = new DialogOperator();
            if (dialogOperator.ShowDialog() == DialogResult.OK && nm.isNear(x, y) == false)
            {
                nm.newOperator(x, y, dialogOperator.Symbol);
                Invalidate();
            }
        }

        private void cmiOperand_Click(object sender, EventArgs e)
        {
            DialogOperand dialogOperand = new DialogOperand();
            if (dialogOperand.ShowDialog() == DialogResult.OK && nm.isNear(x, y) == false)
            {
                nm.newOperand(x, y, dialogOperand.Number);
                Invalidate();
            }
        }

        private void FrmMain_MouseDown(object sender, MouseEventArgs e)
        {
            x = e.X; y = e.Y;

            if (e.Button == MouseButtons.Left && Control.ModifierKeys == Keys.Control
                && nm.isIn(e.X, e.Y) != null)
            {
                move = nm.isIn(e.X, e.Y);
                dx = x - move.X;
                dy = y - move.Y;
            } else if (e.Button == MouseButtons.Left && nm.isIn(e.X, e.Y) != null
                && nm.isIn(e.X, e.Y).GetType() == typeof(Operator))
            {
                conn = (Operator) nm.isIn(e.X, e.Y);
            }
        }

        private void FrmMain_MouseMove(object sender, MouseEventArgs e)
        {
            if (move != null)
            {
                move.X = e.X - dx;
                move.Y = e.Y - dy;
                Invalidate();
            } else if (conn != null)
            {
                x = e.X;
                y = e.Y;
                Invalidate();
            }
        }
        private void FrmMain_MouseUp(object sender, MouseEventArgs e)
        {
            if (move != null)
                move = null;
            if (conn != null)
            {
                if (nm.isIn(e.X, e.Y) != null) {
                    if (conn.My < nm.isIn(e.X, e.Y).My)
                    {
                        if (conn.Mx > nm.isIn(e.X, e.Y).Mx)
                            conn.Left = nm.isIn(e.X, e.Y);
                        else if (conn.Mx < nm.isIn(e.X, e.Y).Mx)
                            conn.Right = nm.isIn(e.X, e.Y);
                    }

                }
                conn = null;
            }
            Invalidate();
        }

        private void FrmMain_Paint(object sender, PaintEventArgs e)
        {
            if (conn != null)
                e.Graphics.DrawLine(new Pen(Color.DeepSkyBlue, 2), conn.Mx, conn.My, x, y);
            nm.paint(e.Graphics);

            if (nm.isValid())
                lblValid.Text = "Valid";
            else
                lblValid.Text = "Invalid";

            lblPrefix.Text = nm.getPrefix();
            lblInfix.Text = nm.getInfix();
            lblPostfix.Text = nm.getPostfix();
        }
    }
}
