﻿using System;
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
