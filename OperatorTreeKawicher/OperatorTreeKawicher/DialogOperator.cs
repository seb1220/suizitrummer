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
        public string Symbol
        {
            get { return cbOperator.SelectedItem.ToString(); }
        }

        public DialogOperator()
        {
            InitializeComponent();
        }

        private void DialogOperator_Load(object sender, EventArgs e)
        {

        }
    }
}
