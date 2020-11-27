namespace AutoCenter
{
    partial class FormCarWash
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;
        public FormMain formMain;

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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormCarWash));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItemFile = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemExit = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemHelp = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemAbout = new System.Windows.Forms.ToolStripMenuItem();
            this.listBoxExterior = new System.Windows.Forms.ListBox();
            this.comboBoxDetailingPackages = new System.Windows.Forms.ComboBox();
            this.listBoxInterior = new System.Windows.Forms.ListBox();
            this.labelDetailingPackages = new System.Windows.Forms.Label();
            this.labelExterior = new System.Windows.Forms.Label();
            this.labelInterior = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
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
            this.menuStrip1.TabIndex = 0;
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
            this.toolStripMenuItemExit.Click += new System.EventHandler(this.toolStripMenuItemExit_Click);
            // 
            // toolStripMenuItemHelp
            // 
            this.toolStripMenuItemHelp.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItemAbout});
            this.toolStripMenuItemHelp.Name = "toolStripMenuItemHelp";
            this.toolStripMenuItemHelp.Size = new System.Drawing.Size(55, 24);
            this.toolStripMenuItemHelp.Text = "&Help";
            // 
            // toolStripMenuItemAbout
            // 
            this.toolStripMenuItemAbout.Name = "toolStripMenuItemAbout";
            this.toolStripMenuItemAbout.Size = new System.Drawing.Size(133, 26);
            this.toolStripMenuItemAbout.Text = "&About";
            // 
            // listBoxExterior
            // 
            this.listBoxExterior.FormattingEnabled = true;
            this.listBoxExterior.ItemHeight = 20;
            this.listBoxExterior.Location = new System.Drawing.Point(169, 54);
            this.listBoxExterior.Name = "listBoxExterior";
            this.listBoxExterior.Size = new System.Drawing.Size(150, 104);
            this.listBoxExterior.TabIndex = 1;
            // 
            // comboBoxDetailingPackages
            // 
            this.comboBoxDetailingPackages.FormattingEnabled = true;
            this.comboBoxDetailingPackages.Items.AddRange(new object[] {
            "Standard",
            "Deluxe",
            "Executive",
            "Luxury"});
            this.comboBoxDetailingPackages.Location = new System.Drawing.Point(12, 54);
            this.comboBoxDetailingPackages.Name = "comboBoxDetailingPackages";
            this.comboBoxDetailingPackages.Size = new System.Drawing.Size(151, 28);
            this.comboBoxDetailingPackages.TabIndex = 2;
            // 
            // listBoxInterior
            // 
            this.listBoxInterior.FormattingEnabled = true;
            this.listBoxInterior.ItemHeight = 20;
            this.listBoxInterior.Location = new System.Drawing.Point(325, 54);
            this.listBoxInterior.Name = "listBoxInterior";
            this.listBoxInterior.Size = new System.Drawing.Size(150, 104);
            this.listBoxInterior.TabIndex = 1;
            // 
            // labelDetailingPackages
            // 
            this.labelDetailingPackages.AutoSize = true;
            this.labelDetailingPackages.Location = new System.Drawing.Point(12, 31);
            this.labelDetailingPackages.Name = "labelDetailingPackages";
            this.labelDetailingPackages.Size = new System.Drawing.Size(134, 20);
            this.labelDetailingPackages.TabIndex = 3;
            this.labelDetailingPackages.Text = "Detailing Packages";
            // 
            // labelExterior
            // 
            this.labelExterior.AutoSize = true;
            this.labelExterior.Location = new System.Drawing.Point(169, 28);
            this.labelExterior.Name = "labelExterior";
            this.labelExterior.Size = new System.Drawing.Size(60, 20);
            this.labelExterior.TabIndex = 3;
            this.labelExterior.Text = "Exterior";
            // 
            // labelInterior
            // 
            this.labelInterior.AutoSize = true;
            this.labelInterior.Location = new System.Drawing.Point(325, 28);
            this.labelInterior.Name = "labelInterior";
            this.labelInterior.Size = new System.Drawing.Size(57, 20);
            this.labelInterior.TabIndex = 3;
            this.labelInterior.Text = "Interior";
            // 
            // FormCarWash
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.labelInterior);
            this.Controls.Add(this.labelExterior);
            this.Controls.Add(this.labelDetailingPackages);
            this.Controls.Add(this.listBoxInterior);
            this.Controls.Add(this.comboBoxDetailingPackages);
            this.Controls.Add(this.listBoxExterior);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FormCarWash";
            this.Text = "AutoCenter CarWash";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemFile;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemExit;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemHelp;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemAbout;
        private System.Windows.Forms.ListBox listBoxExterior;
        private System.Windows.Forms.ComboBox comboBoxDetailingPackages;
        private System.Windows.Forms.ListBox listBoxInterior;
        private System.Windows.Forms.Label labelDetailingPackages;
        private System.Windows.Forms.Label labelExterior;
        private System.Windows.Forms.Label labelInterior;
    }
}