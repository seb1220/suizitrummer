using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
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
        Boolean move = false;
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
            if (dialogOperator.ShowDialog() == DialogResult.OK)
            {
                nm.newOperator(x, y, dialogOperator.Symbol);
                Invalidate();
            }
        }

        private void cmiOperand_Click(object sender, EventArgs e)
        {
            DialogOperand dialogOperand = new DialogOperand();
            if (dialogOperand.ShowDialog() == DialogResult.OK)
            {
                nm.newOperand(x, y, dialogOperand.Number);
                Invalidate();
            }
        }

        private void FrmMain_Paint(object sender, PaintEventArgs e)
        {
            if (nm != null)
                nm.paint(e.Graphics);
        }

        private void FrmMain_MouseDown(object sender, MouseEventArgs e)
        {
            x = e.X; y = e.Y;

            if (e.Button == MouseButtons.Left && Control.ModifierKeys == Keys.Control)
            {
                move = true;
            }
        }
    }
}
