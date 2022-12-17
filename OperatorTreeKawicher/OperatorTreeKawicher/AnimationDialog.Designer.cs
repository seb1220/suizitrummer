namespace OperatorTreeKawicher
{
    partial class AnimationDialog
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
            this.gbMethod = new System.Windows.Forms.GroupBox();
            this.cbPostfix = new System.Windows.Forms.CheckBox();
            this.cbInfix = new System.Windows.Forms.CheckBox();
            this.cbPrefix = new System.Windows.Forms.CheckBox();
            this.butRun = new System.Windows.Forms.Button();
            this.gbMethod.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbMethod
            // 
            this.gbMethod.Controls.Add(this.cbPostfix);
            this.gbMethod.Controls.Add(this.cbInfix);
            this.gbMethod.Controls.Add(this.cbPrefix);
            this.gbMethod.Location = new System.Drawing.Point(12, 12);
            this.gbMethod.Name = "gbMethod";
            this.gbMethod.Size = new System.Drawing.Size(156, 100);
            this.gbMethod.TabIndex = 1;
            this.gbMethod.TabStop = false;
            this.gbMethod.Text = "Method";
            // 
            // cbPostfix
            // 
            this.cbPostfix.AutoSize = true;
            this.cbPostfix.Location = new System.Drawing.Point(7, 75);
            this.cbPostfix.Name = "cbPostfix";
            this.cbPostfix.Size = new System.Drawing.Size(67, 20);
            this.cbPostfix.TabIndex = 2;
            this.cbPostfix.Text = "postfix";
            this.cbPostfix.UseVisualStyleBackColor = true;
            this.cbPostfix.CheckedChanged += new System.EventHandler(this.cbPostfix_CheckedChanged);
            // 
            // cbInfix
            // 
            this.cbInfix.AutoSize = true;
            this.cbInfix.Location = new System.Drawing.Point(7, 48);
            this.cbInfix.Name = "cbInfix";
            this.cbInfix.Size = new System.Drawing.Size(51, 20);
            this.cbInfix.TabIndex = 1;
            this.cbInfix.Text = "infix";
            this.cbInfix.UseVisualStyleBackColor = true;
            this.cbInfix.CheckedChanged += new System.EventHandler(this.cbInfix_CheckedChanged);
            // 
            // cbPrefix
            // 
            this.cbPrefix.AutoSize = true;
            this.cbPrefix.Checked = true;
            this.cbPrefix.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbPrefix.Location = new System.Drawing.Point(6, 21);
            this.cbPrefix.Name = "cbPrefix";
            this.cbPrefix.Size = new System.Drawing.Size(61, 20);
            this.cbPrefix.TabIndex = 0;
            this.cbPrefix.Text = "prefix";
            this.cbPrefix.UseVisualStyleBackColor = true;
            this.cbPrefix.CheckedChanged += new System.EventHandler(this.cbPrefix_CheckedChanged);
            // 
            // butRun
            // 
            this.butRun.Location = new System.Drawing.Point(12, 118);
            this.butRun.Name = "butRun";
            this.butRun.Size = new System.Drawing.Size(156, 33);
            this.butRun.TabIndex = 2;
            this.butRun.Text = "Run";
            this.butRun.UseVisualStyleBackColor = true;
            this.butRun.Click += new System.EventHandler(this.butRun_Click);
            // 
            // AnimationDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(181, 161);
            this.ControlBox = false;
            this.Controls.Add(this.butRun);
            this.Controls.Add(this.gbMethod);
            this.Name = "AnimationDialog";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Animation";
            this.gbMethod.ResumeLayout(false);
            this.gbMethod.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbMethod;
        private System.Windows.Forms.Button butRun;
        private System.Windows.Forms.CheckBox cbPostfix;
        private System.Windows.Forms.CheckBox cbInfix;
        private System.Windows.Forms.CheckBox cbPrefix;
    }
}