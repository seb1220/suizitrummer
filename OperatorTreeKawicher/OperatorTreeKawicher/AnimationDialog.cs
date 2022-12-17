using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OperatorTreeKawicher
{
    public delegate void RunAnimationHandler(AnimationType animationType);
    public partial class AnimationDialog : Form
    {
        AnimationType SelectedType { get; set; }
        public event RunAnimationHandler runAnimationHandler;
        
        public AnimationDialog()
        {
            InitializeComponent();
            cbPrefix.Checked = true;
            SelectedType = AnimationType.Prefix;
        }

        private void cbPrefix_CheckedChanged(object sender, EventArgs e)
        {

            if (cbPrefix.Checked)
            {
                SelectedType = AnimationType.Prefix;
                cbInfix.Checked = false;
                cbPostfix.Checked = false;
            }
        }

        private void cbInfix_CheckedChanged(object sender, EventArgs e)
        {
            if (cbInfix.Checked)
            {
                SelectedType = AnimationType.Infix;
                cbPrefix.Checked = false;
                cbPostfix.Checked = false;
            }
        }
        
        private void cbPostfix_CheckedChanged(object sender, EventArgs e)
        {
            if (cbPostfix.Checked)
            {
                SelectedType = AnimationType.Postfix;
                cbPrefix.Checked = false;
                cbInfix.Checked = false;
            }
        }

        private void butRun_Click(object sender, EventArgs e)
        {
            Thread t = new Thread(() => runAnimationHandler(SelectedType));
            t.Start();
        }
    }
}
