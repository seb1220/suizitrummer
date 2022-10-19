using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace DemoRechner
{
    public partial class Calculator : Form
    {
        public Calculator()
        {
            InitializeComponent();
        }

        private void butResult_Click(object sender, EventArgs e)
        {
            String calc = txtCalc.Text;

            if (calc.Contains("+"))
            {
                resLab.Text = (float.Parse(calc.Split('+')[0]) + float.Parse(calc.Split('+')[1])).ToString();
            }
            else if (calc.Contains("-"))
            {
                resLab.Text = (float.Parse(calc.Split('-')[0]) - float.Parse(calc.Split('-')[1])).ToString();
            }
            else if (calc.Contains("*"))
            {
                resLab.Text = (float.Parse(calc.Split('*')[0]) * float.Parse(calc.Split('*')[1])).ToString();
            }
            else if (calc.Contains("/"))
            {
                resLab.Text = (float.Parse(calc.Split('/')[0]) / float.Parse(calc.Split('/')[1])).ToString();
            }
        }
    }
}
