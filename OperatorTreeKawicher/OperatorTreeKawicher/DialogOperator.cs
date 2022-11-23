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
    public partial class DialogOperator : Form
    {
        public string symbol = "+";

        public DialogOperator()
        {
            InitializeComponent();
        }

        private void cbOperator_SelectedIndexChanged(object sender, EventArgs e)
        {
            symbol = cbOperator.SelectedItem.ToString();
        }
    }
}
