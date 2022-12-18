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
    public partial class DialogOperator : Form
    {
        public string Symbol
        {
            get { return cbOperator.SelectedItem.ToString(); }
        }

        public DialogOperator()
        {
            InitializeComponent();
            cbOperator.SelectedIndex = 0;
        }
    }
}
