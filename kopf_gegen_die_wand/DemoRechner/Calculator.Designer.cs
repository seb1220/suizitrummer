namespace DemoRechner
{
    partial class Calculator
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtCalc = new System.Windows.Forms.TextBox();
            this.resLab = new System.Windows.Forms.Label();
            this.butResult = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtCalc
            // 
            this.txtCalc.Location = new System.Drawing.Point(36, 38);
            this.txtCalc.Name = "txtCalc";
            this.txtCalc.Size = new System.Drawing.Size(288, 22);
            this.txtCalc.TabIndex = 1;
            // 
            // resLab
            // 
            this.resLab.AutoSize = true;
            this.resLab.Location = new System.Drawing.Point(33, 82);
            this.resLab.Name = "resLab";
            this.resLab.Size = new System.Drawing.Size(39, 16);
            this.resLab.TabIndex = 2;
            this.resLab.Text = "result";
            // 
            // butResult
            // 
            this.butResult.Location = new System.Drawing.Point(351, 38);
            this.butResult.Name = "butResult";
            this.butResult.Size = new System.Drawing.Size(84, 60);
            this.butResult.TabIndex = 3;
            this.butResult.Text = "Result";
            this.butResult.UseVisualStyleBackColor = true;
            this.butResult.Click += new System.EventHandler(this.butResult_Click);
            // 
            // Calculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(490, 140);
            this.Controls.Add(this.butResult);
            this.Controls.Add(this.resLab);
            this.Controls.Add(this.txtCalc);
            this.Name = "Calculator";
            this.Text = "Calculator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtCalc;
        private System.Windows.Forms.Label resLab;
        private System.Windows.Forms.Button butResult;
    }
}

