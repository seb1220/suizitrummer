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
    // This class is used to create a dialog box that will allow the user to enter a value for the operand thats about to be created
    public partial class DialogOperand : Form
    {
        public DialogOperand()
        {
            InitializeComponent();
        }

        public int Number {
            get { return int.Parse(tbOperand.Text); }
        }

        private void tbOperand_TextChanged(object sender, EventArgs e)
        {
            int tmp;
            if (int.TryParse(tbOperand.Text, out tmp)) {
                butOk.Enabled = true;
            } else
            {
                butOk.Enabled = false;
            }
        }
    }
}
