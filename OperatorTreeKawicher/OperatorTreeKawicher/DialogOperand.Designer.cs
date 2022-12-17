namespace OperatorTreeKawicher
{
    partial class DialogOperand
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.butOk = new System.Windows.Forms.Button();
            this.butCancel = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.tbOperand = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // butOk
            // 
            this.butOk.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.butOk.Enabled = false;
            this.butOk.Location = new System.Drawing.Point(179, 66);
            this.butOk.Name = "butOk";
            this.butOk.Size = new System.Drawing.Size(158, 30);
            this.butOk.TabIndex = 0;
            this.butOk.Text = "Okay";
            this.butOk.UseVisualStyleBackColor = true;
            // 
            // butCancel
            // 
            this.butCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.butCancel.Location = new System.Drawing.Point(12, 66);
            this.butCancel.Name = "butCancel";
            this.butCancel.Size = new System.Drawing.Size(152, 30);
            this.butCancel.TabIndex = 2;
            this.butCancel.Text = "Cancel";
            this.butCancel.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "Operand";
            // 
            // tbOperand
            // 
            this.tbOperand.Location = new System.Drawing.Point(78, 27);
            this.tbOperand.Name = "tbOperand";
            this.tbOperand.Size = new System.Drawing.Size(259, 22);
            this.tbOperand.TabIndex = 2;
            this.tbOperand.TextChanged += new System.EventHandler(this.tbOperand_TextChanged);
            // 
            // DialogOperand
            // 
            this.AcceptButton = this.butOk;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.butCancel;
            this.ClientSize = new System.Drawing.Size(349, 108);
            this.ControlBox = false;
            this.Controls.Add(this.tbOperand);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.butCancel);
            this.Controls.Add(this.butOk);
            this.Name = "DialogOperand";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "New Operand";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button butOk;
        private System.Windows.Forms.Button butCancel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbOperand;
    }
}