namespace OperatorTreeKawicher
{
    partial class FrmMain
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
            this.components = new System.ComponentModel.Container();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.mFile = new System.Windows.Forms.ToolStripMenuItem();
            this.miNew = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.miOpen = new System.Windows.Forms.ToolStripMenuItem();
            this.miSave = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
            this.miExit = new System.Windows.Forms.ToolStripMenuItem();
            this.mView = new System.Windows.Forms.ToolStripMenuItem();
            this.miAnimation = new System.Windows.Forms.ToolStripMenuItem();
            this.cmMain = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.cmiOperator = new System.Windows.Forms.ToolStripMenuItem();
            this.cmiOperand = new System.Windows.Forms.ToolStripMenuItem();
            this.lblValid = new System.Windows.Forms.Label();
            this.lblPrefixTitle = new System.Windows.Forms.Label();
            this.lblInfixTitle = new System.Windows.Forms.Label();
            this.lblPostfixTitle = new System.Windows.Forms.Label();
            this.lblPrefix = new System.Windows.Forms.Label();
            this.lblInfix = new System.Windows.Forms.Label();
            this.lblPostfix = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.cmMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mFile,
            this.mView});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "msMain";
            // 
            // mFile
            // 
            this.mFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.miNew,
            this.toolStripMenuItem1,
            this.miOpen,
            this.miSave,
            this.toolStripMenuItem2,
            this.miExit});
            this.mFile.Name = "mFile";
            this.mFile.Size = new System.Drawing.Size(46, 24);
            this.mFile.Text = "File";
            // 
            // miNew
            // 
            this.miNew.Name = "miNew";
            this.miNew.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.miNew.Size = new System.Drawing.Size(224, 26);
            this.miNew.Text = "New";
            this.miNew.Click += new System.EventHandler(this.newToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(221, 6);
            // 
            // miOpen
            // 
            this.miOpen.Name = "miOpen";
            this.miOpen.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.miOpen.Size = new System.Drawing.Size(224, 26);
            this.miOpen.Text = "Open";
            this.miOpen.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // miSave
            // 
            this.miSave.Name = "miSave";
            this.miSave.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.miSave.Size = new System.Drawing.Size(224, 26);
            this.miSave.Text = "Save";
            this.miSave.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(221, 6);
            // 
            // miExit
            // 
            this.miExit.Name = "miExit";
            this.miExit.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F4)));
            this.miExit.Size = new System.Drawing.Size(224, 26);
            this.miExit.Text = "Exit";
            this.miExit.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // mView
            // 
            this.mView.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.miAnimation});
            this.mView.Name = "mView";
            this.mView.Size = new System.Drawing.Size(55, 24);
            this.mView.Text = "View";
            // 
            // miAnimation
            // 
            this.miAnimation.Enabled = false;
            this.miAnimation.Name = "miAnimation";
            this.miAnimation.Size = new System.Drawing.Size(224, 26);
            this.miAnimation.Text = "Animation";
            this.miAnimation.Click += new System.EventHandler(this.animationToolStripMenuItem_Click);
            // 
            // cmMain
            // 
            this.cmMain.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.cmMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cmiOperator,
            this.cmiOperand});
            this.cmMain.Name = "cmMain";
            this.cmMain.Size = new System.Drawing.Size(139, 52);
            // 
            // cmiOperator
            // 
            this.cmiOperator.Name = "cmiOperator";
            this.cmiOperator.Size = new System.Drawing.Size(138, 24);
            this.cmiOperator.Text = "Operator";
            this.cmiOperator.Click += new System.EventHandler(this.cmiOperator_Click);
            // 
            // cmiOperand
            // 
            this.cmiOperand.Name = "cmiOperand";
            this.cmiOperand.Size = new System.Drawing.Size(138, 24);
            this.cmiOperand.Text = "Operand";
            this.cmiOperand.Click += new System.EventHandler(this.cmiOperand_Click);
            // 
            // lblValid
            // 
            this.lblValid.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblValid.AutoSize = true;
            this.lblValid.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.lblValid.Location = new System.Drawing.Point(13, 282);
            this.lblValid.Name = "lblValid";
            this.lblValid.Size = new System.Drawing.Size(65, 23);
            this.lblValid.TabIndex = 1;
            this.lblValid.Text = "Invalid";
            // 
            // lblPrefixTitle
            // 
            this.lblPrefixTitle.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblPrefixTitle.AutoSize = true;
            this.lblPrefixTitle.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrefixTitle.Location = new System.Drawing.Point(12, 336);
            this.lblPrefixTitle.Name = "lblPrefixTitle";
            this.lblPrefixTitle.Size = new System.Drawing.Size(58, 23);
            this.lblPrefixTitle.TabIndex = 2;
            this.lblPrefixTitle.Text = "prefix";
            // 
            // lblInfixTitle
            // 
            this.lblInfixTitle.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblInfixTitle.AutoSize = true;
            this.lblInfixTitle.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInfixTitle.Location = new System.Drawing.Point(12, 359);
            this.lblInfixTitle.Name = "lblInfixTitle";
            this.lblInfixTitle.Size = new System.Drawing.Size(43, 23);
            this.lblInfixTitle.TabIndex = 3;
            this.lblInfixTitle.Text = "infix";
            // 
            // lblPostfixTitle
            // 
            this.lblPostfixTitle.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblPostfixTitle.AutoSize = true;
            this.lblPostfixTitle.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPostfixTitle.Location = new System.Drawing.Point(12, 382);
            this.lblPostfixTitle.Name = "lblPostfixTitle";
            this.lblPostfixTitle.Size = new System.Drawing.Size(67, 23);
            this.lblPostfixTitle.TabIndex = 4;
            this.lblPostfixTitle.Text = "postfix";
            // 
            // lblPrefix
            // 
            this.lblPrefix.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblPrefix.AutoSize = true;
            this.lblPrefix.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrefix.Location = new System.Drawing.Point(85, 336);
            this.lblPrefix.Name = "lblPrefix";
            this.lblPrefix.Size = new System.Drawing.Size(0, 23);
            this.lblPrefix.TabIndex = 5;
            // 
            // lblInfix
            // 
            this.lblInfix.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblInfix.AutoSize = true;
            this.lblInfix.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInfix.Location = new System.Drawing.Point(85, 359);
            this.lblInfix.Name = "lblInfix";
            this.lblInfix.Size = new System.Drawing.Size(0, 23);
            this.lblInfix.TabIndex = 6;
            // 
            // lblPostfix
            // 
            this.lblPostfix.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblPostfix.AutoSize = true;
            this.lblPostfix.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPostfix.Location = new System.Drawing.Point(85, 382);
            this.lblPostfix.Name = "lblPostfix";
            this.lblPostfix.Size = new System.Drawing.Size(0, 23);
            this.lblPostfix.TabIndex = 7;
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.ContextMenuStrip = this.cmMain;
            this.Controls.Add(this.lblPostfix);
            this.Controls.Add(this.lblInfix);
            this.Controls.Add(this.lblPrefix);
            this.Controls.Add(this.lblPostfixTitle);
            this.Controls.Add(this.lblInfixTitle);
            this.Controls.Add(this.lblPrefixTitle);
            this.Controls.Add(this.lblValid);
            this.Controls.Add(this.menuStrip1);
            this.DoubleBuffered = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FrmMain";
            this.Text = "OperatorTree";
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.FrmMain_Paint);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.FrmMain_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.FrmMain_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.FrmMain_MouseUp);
            this.Move += new System.EventHandler(this.FrmMain_Move);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.cmMain.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem mFile;
        private System.Windows.Forms.ToolStripMenuItem miNew;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem miOpen;
        private System.Windows.Forms.ToolStripMenuItem miSave;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem miExit;
        private System.Windows.Forms.ToolStripMenuItem mView;
        private System.Windows.Forms.ToolStripMenuItem miAnimation;
        private System.Windows.Forms.ContextMenuStrip cmMain;
        private System.Windows.Forms.ToolStripMenuItem cmiOperator;
        private System.Windows.Forms.ToolStripMenuItem cmiOperand;
        private System.Windows.Forms.Label lblValid;
        private System.Windows.Forms.Label lblPrefixTitle;
        private System.Windows.Forms.Label lblInfixTitle;
        private System.Windows.Forms.Label lblPostfixTitle;
        private System.Windows.Forms.Label lblPrefix;
        private System.Windows.Forms.Label lblInfix;
        private System.Windows.Forms.Label lblPostfix;
    }
}

