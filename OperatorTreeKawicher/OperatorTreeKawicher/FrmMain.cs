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
        int x;
        int y;
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
                nm.newOperator(x, y, dialogOperator.symbol);
        }

        private void cmiOperand_Click(object sender, EventArgs e)
        {
            DialogOperand dialogOperand = new DialogOperand();
            if (dialogOperand.ShowDialog() == DialogResult.OK)
                return;
        }

        private void FrmMain_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
                x = e.X; x = e.X;



        }
    }
}
