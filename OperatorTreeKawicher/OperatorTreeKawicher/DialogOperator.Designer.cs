namespace OperatorTreeKawicher
{
    partial class DialogOperator
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
            this.cbOperator = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.butCancel = new System.Windows.Forms.Button();
            this.butOk = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cbOperator
            // 
            this.cbOperator.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbOperator.FormattingEnabled = true;
            this.cbOperator.Items.AddRange(new object[] {
            "+",
            "-",
            "*",
            "/"});
            this.cbOperator.Location = new System.Drawing.Point(121, 12);
            this.cbOperator.Name = "cbOperator";
            this.cbOperator.Size = new System.Drawing.Size(77, 24);
            this.cbOperator.TabIndex = 3;
            this.cbOperator.SelectedIndexChanged += new System.EventHandler(this.cbOperator_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Operator";
            // 
            // butCancel
            // 
            this.butCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.butCancel.Location = new System.Drawing.Point(15, 52);
            this.butCancel.Name = "butCancel";
            this.butCancel.Size = new System.Drawing.Size(81, 23);
            this.butCancel.TabIndex = 2;
            this.butCancel.Text = "Cancel";
            this.butCancel.UseVisualStyleBackColor = true;
            // 
            // butOk
            // 
            this.butOk.Location = new System.Drawing.Point(102, 52);
            this.butOk.Name = "butOk";
            this.butOk.Size = new System.Drawing.Size(95, 22);
            this.butOk.TabIndex = 3;
            this.butOk.Text = "Okay";
            this.butOk.UseVisualStyleBackColor = true;
            // 
            // DialogOperator
            // 
            this.AcceptButton = this.butOk;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.butCancel;
            this.ClientSize = new System.Drawing.Size(210, 89);
            this.ControlBox = false;
            this.Controls.Add(this.butOk);
            this.Controls.Add(this.butCancel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbOperator);
            this.Name = "DialogOperator";
            this.Text = "New Operator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbOperator;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button butCancel;
        private System.Windows.Forms.Button butOk;
    }
}