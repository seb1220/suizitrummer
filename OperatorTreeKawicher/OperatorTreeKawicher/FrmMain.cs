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
        public FrmMain()
        {
            InitializeComponent();
        }

        private void viewToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void cmiOperator_Click(object sender, EventArgs e)
        {
            DialogOperator dialogOperator = new DialogOperator();
            if (dialogOperator.ShowDialog() == DialogResult.OK)
                return;
        }

        private void cmiOperand_Click(object sender, EventArgs e)
        {
            DialogOperand dialogOperand = new DialogOperand();
            if (dialogOperand.ShowDialog() == DialogResult.OK)
                return;
        }
    }
}
