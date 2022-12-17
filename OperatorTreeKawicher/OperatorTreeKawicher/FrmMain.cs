using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OperatorTreeKawicher
{
    public enum AnimationType
    {
        Prefix,
        Infix,
        Postfix
    }
    public partial class FrmMain : Form
    {
        NodeManagement nm;
        AnimationDialog animationDialog;
        int x = 0;
        int y = 0;
        int dx;
        int dy;
        Node move = null;
        Operator conn = null;
        public FrmMain()
        {
            InitializeComponent();
            nm = new NodeManagement();
            animationDialog = new AnimationDialog();
            animationDialog.runAnimationHandler += animate;
        }

        private void cmiOperator_Click(object sender, EventArgs e)
        {
            DialogOperator dialogOperator = new DialogOperator();
            if (dialogOperator.ShowDialog() == DialogResult.OK && nm.isNear(x, y) == false)
            {
                nm.newOperator(x, y, dialogOperator.Symbol);
                Invalidate();
            }
        }

        private void cmiOperand_Click(object sender, EventArgs e)
        {
            DialogOperand dialogOperand = new DialogOperand();
            if (dialogOperand.ShowDialog() == DialogResult.OK && nm.isNear(x, y) == false)
            {
                nm.newOperand(x, y, dialogOperand.Number);
                Invalidate();
            }
        }

        private void FrmMain_MouseDown(object sender, MouseEventArgs e)
        {
            x = e.X; y = e.Y;

            if (e.Button == MouseButtons.Left && Control.ModifierKeys == Keys.Control
                && nm.isIn(e.X, e.Y) != null)
            {
                move = nm.isIn(e.X, e.Y);
                dx = x - move.X;
                dy = y - move.Y;
            }
            else if (e.Button == MouseButtons.Left && nm.isIn(e.X, e.Y) != null
                && nm.isIn(e.X, e.Y).GetType() == typeof(Operator))
            {
                conn = (Operator)nm.isIn(e.X, e.Y);
            }
        }

        private void FrmMain_MouseMove(object sender, MouseEventArgs e)
        {
            if (move != null)
            {
                move.X = e.X - dx;
                move.Y = e.Y - dy;
                Invalidate();
            }
            else if (conn != null)
            {
                x = e.X;
                y = e.Y;
                Invalidate();
            }
        }
        private void FrmMain_MouseUp(object sender, MouseEventArgs e)
        {
            if (move != null)
                move = null;
            if (conn != null)
            {
                if (nm.isIn(e.X, e.Y) != null)
                {
                    if (conn.My < nm.isIn(e.X, e.Y).My)
                    {
                        if (conn.Mx > nm.isIn(e.X, e.Y).Mx)
                            conn.Left = nm.isIn(e.X, e.Y);
                        else if (conn.Mx < nm.isIn(e.X, e.Y).Mx)
                            conn.Right = nm.isIn(e.X, e.Y);
                    }

                }
                conn = null;
            }
            Invalidate();
        }

        private void FrmMain_Paint(object sender, PaintEventArgs e)
        {
            if (conn != null)
                e.Graphics.DrawLine(new Pen(Color.Salmon, 2), conn.Mx, conn.My, x, y);
            nm.paint(e.Graphics);

            if (nm.isValid())
            {
                lblValid.Text = "Valid";
                miAnimation.Enabled = true;
            }
            else
            {
                lblValid.Text = "Invalid";
                miAnimation.Enabled = false;
            }

            List<Node> nodes = nm.getPrefix();
            if (nodes == null)
            {
                lblPrefix.Text = "Invalid Tree";
                lblInfix.Text = "Invalid Tree";
                lblPostfix.Text = "Invalid Tree";
                return;
            }
            
            lblPrefix.Text = nodes.Aggregate("", (current, node) => current + (node.ToString() + " "));

            nodes = nm.getInfix();
            lblInfix.Text = nodes.Aggregate("", (current, node) => current +
                ((node.GetType() == typeof(Operator) ? node.ToString() :
                    (nodes.FindAll(n => n.GetType() == typeof(Operator)).Find(op => ((Operator)op).Left == node) != null ? "(" + node.ToString() : node.ToString() + ")")) 
                + " "));

            nodes = nm.getPostfix();
            lblPostfix.Text = nodes.Aggregate("", (current, node) => current + (node.ToString() + " "));
            
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            nm.clear();
            Invalidate();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Binary File *.bin|*.bin";
            openFileDialog.InitialDirectory = @"C:\Temp";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                FileStream stream = new FileStream(openFileDialog.FileName, FileMode.Open);
                BinaryFormatter formatter = new BinaryFormatter();
                nm = (NodeManagement)formatter.Deserialize(stream);
                stream.Close();
                Invalidate();
            }
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Binary File *.bin|*.bin";
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                FileStream stream = new FileStream(saveFileDialog.FileName, FileMode.Create);
                BinaryFormatter formatter = new BinaryFormatter();
                formatter.Serialize(stream, nm);
                stream.Close();
            }
        }

        private void animationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (animationDialog.Visible)
            {
                miAnimation.Checked = false;
                animationDialog.Hide();
            }
            else
            {
                miAnimation.Checked = true;
                moveAnitmationDialog();
                animationDialog.Show();
            }
        }

        private void FrmMain_Move(object sender, EventArgs e)
        {
            moveAnitmationDialog();
        }

        private void moveAnitmationDialog()
        {
            animationDialog.Location = new Point(this.Location.X + this.Width + 5, this.Location.Y + this.Height / 2 - animationDialog.Height / 2);
        }

        private void animate(AnimationType type)
        {
            switch (type)
            {
                case AnimationType.Prefix:
                    foreach (Node node in nm.getPrefix()) {
                        node.IsSelected = true;
                        Invalidate();
                        Thread.Sleep(1000);
                        node.IsSelected = false;
                    }
                    break;
                case AnimationType.Infix:
                    foreach (Node node in nm.getInfix())
                    {
                        node.IsSelected = true;
                        Invalidate();
                        Thread.Sleep(1000);
                        node.IsSelected = false;
                    }
                    break;
                case AnimationType.Postfix:
                    foreach (Node node in nm.getPostfix())
                    {
                        node.IsSelected = true;
                        Invalidate();
                        Thread.Sleep(1000);
                        node.IsSelected = false;
                    }
                    break;
            }
            Invalidate();
        }
    }
}
