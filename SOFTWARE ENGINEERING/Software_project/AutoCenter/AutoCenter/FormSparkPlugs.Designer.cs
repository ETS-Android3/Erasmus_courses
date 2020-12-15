namespace AutoCenter
{
    partial class FormSparkPlugs
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormSparkPlugs));
            this.textBoxPartNumber = new System.Windows.Forms.TextBox();
            this.labelPartNumber = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItemFile = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemExit = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemHelp = new System.Windows.Forms.ToolStripMenuItem();
            this.labelBrand = new System.Windows.Forms.Label();
            this.comboBoxBrand = new System.Windows.Forms.ComboBox();
            this.buttonFindReplacement = new System.Windows.Forms.Button();
            this.labelFoundReplacement = new System.Windows.Forms.Label();
            this.labelFoundReplacementValue = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBoxPartNumber
            // 
            this.textBoxPartNumber.Location = new System.Drawing.Point(12, 64);
            this.textBoxPartNumber.Name = "textBoxPartNumber";
            this.textBoxPartNumber.Size = new System.Drawing.Size(125, 27);
            this.textBoxPartNumber.TabIndex = 0;
            // 
            // labelPartNumber
            // 
            this.labelPartNumber.AutoSize = true;
            this.labelPartNumber.Location = new System.Drawing.Point(12, 41);
            this.labelPartNumber.Name = "labelPartNumber";
            this.labelPartNumber.Size = new System.Drawing.Size(92, 20);
            this.labelPartNumber.TabIndex = 1;
            this.labelPartNumber.Text = "Part Number";
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItemFile,
            this.toolStripMenuItemHelp});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 28);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // toolStripMenuItemFile
            // 
            this.toolStripMenuItemFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItemExit});
            this.toolStripMenuItemFile.Name = "toolStripMenuItemFile";
            this.toolStripMenuItemFile.Size = new System.Drawing.Size(46, 24);
            this.toolStripMenuItemFile.Text = "&File";
            // 
            // toolStripMenuItemExit
            // 
            this.toolStripMenuItemExit.Name = "toolStripMenuItemExit";
            this.toolStripMenuItemExit.Size = new System.Drawing.Size(116, 26);
            this.toolStripMenuItemExit.Text = "E&xit";
            this.toolStripMenuItemExit.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // toolStripMenuItemHelp
            // 
            this.toolStripMenuItemHelp.Name = "toolStripMenuItemHelp";
            this.toolStripMenuItemHelp.Size = new System.Drawing.Size(55, 24);
            this.toolStripMenuItemHelp.Text = "&Help";
            // 
            // labelBrand
            // 
            this.labelBrand.AutoSize = true;
            this.labelBrand.Location = new System.Drawing.Point(143, 41);
            this.labelBrand.Name = "labelBrand";
            this.labelBrand.Size = new System.Drawing.Size(48, 20);
            this.labelBrand.TabIndex = 3;
            this.labelBrand.Text = "Brand";
            // 
            // comboBoxBrand
            // 
            this.comboBoxBrand.FormattingEnabled = true;
            this.comboBoxBrand.Items.AddRange(new object[] {
            "Brand A",
            "Brand B",
            "Brand X"});
            this.comboBoxBrand.Location = new System.Drawing.Point(143, 64);
            this.comboBoxBrand.Name = "comboBoxBrand";
            this.comboBoxBrand.Size = new System.Drawing.Size(151, 28);
            this.comboBoxBrand.TabIndex = 4;
            // 
            // buttonFindReplacement
            // 
            this.buttonFindReplacement.Location = new System.Drawing.Point(355, 46);
            this.buttonFindReplacement.Name = "buttonFindReplacement";
            this.buttonFindReplacement.Size = new System.Drawing.Size(130, 62);
            this.buttonFindReplacement.TabIndex = 2;
            this.buttonFindReplacement.Text = "Find Replacement";
            this.buttonFindReplacement.UseVisualStyleBackColor = true;
            this.buttonFindReplacement.Click += new System.EventHandler(this.buttonFindReplacement_Click);
            // 
            // labelFoundReplacement
            // 
            this.labelFoundReplacement.AutoSize = true;
            this.labelFoundReplacement.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelFoundReplacement.Location = new System.Drawing.Point(12, 170);
            this.labelFoundReplacement.Name = "labelFoundReplacement";
            this.labelFoundReplacement.Size = new System.Drawing.Size(210, 30);
            this.labelFoundReplacement.TabIndex = 5;
            this.labelFoundReplacement.Text = "Found Replacement:";
            // 
            // labelFoundReplacementValue
            // 
            this.labelFoundReplacementValue.AutoSize = true;
            this.labelFoundReplacementValue.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelFoundReplacementValue.Location = new System.Drawing.Point(228, 170);
            this.labelFoundReplacementValue.Name = "labelFoundReplacementValue";
            this.labelFoundReplacementValue.Size = new System.Drawing.Size(0, 35);
            this.labelFoundReplacementValue.TabIndex = 6;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(579, 343);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(130, 62);
            this.button1.TabIndex = 2;
            this.button1.Text = "E&xit";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // FormSparkPlugs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.labelFoundReplacementValue);
            this.Controls.Add(this.labelFoundReplacement);
            this.Controls.Add(this.buttonFindReplacement);
            this.Controls.Add(this.comboBoxBrand);
            this.Controls.Add(this.labelBrand);
            this.Controls.Add(this.labelPartNumber);
            this.Controls.Add(this.textBoxPartNumber);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FormSparkPlugs";
            this.Text = "Auto Center Spark Plugs";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.buttonExit_Click);
            this.Load += new System.EventHandler(this.FormSparkPlugs_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxPartNumber;
        private System.Windows.Forms.Label labelPartNumber;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemFile;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemExit;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemHelp;
        private System.Windows.Forms.Label labelBrand;
        private System.Windows.Forms.ComboBox comboBoxBrand;
        private System.Windows.Forms.Button buttonFindReplacement;
        private System.Windows.Forms.Label labelFoundReplacement;
        private System.Windows.Forms.Label labelFoundReplacementValue;
        private System.Windows.Forms.Button button1;
    }
}