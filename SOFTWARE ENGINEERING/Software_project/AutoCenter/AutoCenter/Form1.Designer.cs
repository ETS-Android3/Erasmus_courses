namespace AutoCenter
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.checkBoxComputerNavigation = new System.Windows.Forms.CheckBox();
            this.checkBoxLeatherInterior = new System.Windows.Forms.CheckBox();
            this.checkBoxStereoSystem = new System.Windows.Forms.CheckBox();
            this.radioButtonCarExteriorFinish = new System.Windows.Forms.GroupBox();
            this.radioButtonCustomizedDetailing = new System.Windows.Forms.RadioButton();
            this.radioButtonPearlized = new System.Windows.Forms.RadioButton();
            this.radioButtonStandard = new System.Windows.Forms.RadioButton();
            this.buttonCalculate = new System.Windows.Forms.Button();
            this.buttonClear = new System.Windows.Forms.Button();
            this.buttonPrintForm = new System.Windows.Forms.Button();
            this.buttonExit = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.labelAmountDue = new System.Windows.Forms.Label();
            this.labelTradeInAllowance = new System.Windows.Forms.Label();
            this.labelTotal = new System.Windows.Forms.Label();
            this.labelSalesTax_8 = new System.Windows.Forms.Label();
            this.labelSubtotal = new System.Windows.Forms.Label();
            this.labelAccessoriesFinish = new System.Windows.Forms.Label();
            this.labelCarSSalesPrice = new System.Windows.Forms.Label();
            this.textBoxAmountDue = new System.Windows.Forms.TextBox();
            this.textBoxTradeInAllowance = new System.Windows.Forms.TextBox();
            this.textBoxTotal = new System.Windows.Forms.TextBox();
            this.textBoxSalesTax_8 = new System.Windows.Forms.TextBox();
            this.textBoxSubtotal = new System.Windows.Forms.TextBox();
            this.textBoxAccessoriesFinish = new System.Windows.Forms.TextBox();
            this.textBoxCarSSalesPrice = new System.Windows.Forms.TextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.groupBox1.SuspendLayout();
            this.radioButtonCarExteriorFinish.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.checkBoxComputerNavigation);
            this.groupBox1.Controls.Add(this.checkBoxLeatherInterior);
            this.groupBox1.Controls.Add(this.checkBoxStereoSystem);
            this.groupBox1.Location = new System.Drawing.Point(24, 22);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(250, 128);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Accessories";
            // 
            // checkBoxComputerNavigation
            // 
            this.checkBoxComputerNavigation.AutoSize = true;
            this.checkBoxComputerNavigation.Location = new System.Drawing.Point(7, 89);
            this.checkBoxComputerNavigation.Name = "checkBoxComputerNavigation";
            this.checkBoxComputerNavigation.Size = new System.Drawing.Size(174, 24);
            this.checkBoxComputerNavigation.TabIndex = 2;
            this.checkBoxComputerNavigation.Text = "Computer Navigation";
            this.checkBoxComputerNavigation.UseVisualStyleBackColor = true;
            // 
            // checkBoxLeatherInterior
            // 
            this.checkBoxLeatherInterior.AutoSize = true;
            this.checkBoxLeatherInterior.Location = new System.Drawing.Point(7, 58);
            this.checkBoxLeatherInterior.Name = "checkBoxLeatherInterior";
            this.checkBoxLeatherInterior.Size = new System.Drawing.Size(132, 24);
            this.checkBoxLeatherInterior.TabIndex = 1;
            this.checkBoxLeatherInterior.Text = "Leather Interior";
            this.checkBoxLeatherInterior.UseVisualStyleBackColor = true;
            // 
            // checkBoxStereoSystem
            // 
            this.checkBoxStereoSystem.AutoSize = true;
            this.checkBoxStereoSystem.Location = new System.Drawing.Point(6, 26);
            this.checkBoxStereoSystem.Name = "checkBoxStereoSystem";
            this.checkBoxStereoSystem.Size = new System.Drawing.Size(125, 24);
            this.checkBoxStereoSystem.TabIndex = 0;
            this.checkBoxStereoSystem.Text = "Stereo System";
            this.checkBoxStereoSystem.UseVisualStyleBackColor = true;
            // 
            // radioButtonCarExteriorFinish
            // 
            this.radioButtonCarExteriorFinish.Controls.Add(this.radioButtonCustomizedDetailing);
            this.radioButtonCarExteriorFinish.Controls.Add(this.radioButtonPearlized);
            this.radioButtonCarExteriorFinish.Controls.Add(this.radioButtonStandard);
            this.radioButtonCarExteriorFinish.Location = new System.Drawing.Point(24, 167);
            this.radioButtonCarExteriorFinish.Name = "radioButtonCarExteriorFinish";
            this.radioButtonCarExteriorFinish.Size = new System.Drawing.Size(250, 125);
            this.radioButtonCarExteriorFinish.TabIndex = 1;
            this.radioButtonCarExteriorFinish.TabStop = false;
            this.radioButtonCarExteriorFinish.Text = "Car Exterior Finish";
            // 
            // radioButtonCustomizedDetailing
            // 
            this.radioButtonCustomizedDetailing.AutoSize = true;
            this.radioButtonCustomizedDetailing.Location = new System.Drawing.Point(6, 87);
            this.radioButtonCustomizedDetailing.Name = "radioButtonCustomizedDetailing";
            this.radioButtonCustomizedDetailing.Size = new System.Drawing.Size(173, 24);
            this.radioButtonCustomizedDetailing.TabIndex = 0;
            this.radioButtonCustomizedDetailing.TabStop = true;
            this.radioButtonCustomizedDetailing.Text = "Customized Detailing";
            this.radioButtonCustomizedDetailing.UseVisualStyleBackColor = true;
            // 
            // radioButtonPearlized
            // 
            this.radioButtonPearlized.AutoSize = true;
            this.radioButtonPearlized.Location = new System.Drawing.Point(6, 57);
            this.radioButtonPearlized.Name = "radioButtonPearlized";
            this.radioButtonPearlized.Size = new System.Drawing.Size(90, 24);
            this.radioButtonPearlized.TabIndex = 0;
            this.radioButtonPearlized.TabStop = true;
            this.radioButtonPearlized.Text = "Pearlized";
            this.radioButtonPearlized.UseVisualStyleBackColor = true;
            // 
            // radioButtonStandard
            // 
            this.radioButtonStandard.AutoSize = true;
            this.radioButtonStandard.Location = new System.Drawing.Point(7, 27);
            this.radioButtonStandard.Name = "radioButtonStandard";
            this.radioButtonStandard.Size = new System.Drawing.Size(90, 24);
            this.radioButtonStandard.TabIndex = 0;
            this.radioButtonStandard.TabStop = true;
            this.radioButtonStandard.Text = "Standard";
            this.radioButtonStandard.UseVisualStyleBackColor = true;
            // 
            // buttonCalculate
            // 
            this.buttonCalculate.Location = new System.Drawing.Point(24, 298);
            this.buttonCalculate.Name = "buttonCalculate";
            this.buttonCalculate.Size = new System.Drawing.Size(130, 62);
            this.buttonCalculate.TabIndex = 2;
            this.buttonCalculate.Text = "Calculate";
            this.buttonCalculate.UseVisualStyleBackColor = true;
            // 
            // buttonClear
            // 
            this.buttonClear.Location = new System.Drawing.Point(160, 298);
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.Size = new System.Drawing.Size(130, 62);
            this.buttonClear.TabIndex = 2;
            this.buttonClear.Text = "Clear";
            this.buttonClear.UseVisualStyleBackColor = true;
            // 
            // buttonPrintForm
            // 
            this.buttonPrintForm.Location = new System.Drawing.Point(296, 298);
            this.buttonPrintForm.Name = "buttonPrintForm";
            this.buttonPrintForm.Size = new System.Drawing.Size(130, 62);
            this.buttonPrintForm.TabIndex = 2;
            this.buttonPrintForm.Text = "Print Form";
            this.buttonPrintForm.UseVisualStyleBackColor = true;
            // 
            // buttonExit
            // 
            this.buttonExit.Location = new System.Drawing.Point(432, 298);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(130, 62);
            this.buttonExit.TabIndex = 2;
            this.buttonExit.Text = "Exit";
            this.buttonExit.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.labelAmountDue);
            this.panel1.Controls.Add(this.labelTradeInAllowance);
            this.panel1.Controls.Add(this.labelTotal);
            this.panel1.Controls.Add(this.labelSalesTax_8);
            this.panel1.Controls.Add(this.labelSubtotal);
            this.panel1.Controls.Add(this.labelAccessoriesFinish);
            this.panel1.Controls.Add(this.labelCarSSalesPrice);
            this.panel1.Controls.Add(this.textBoxAmountDue);
            this.panel1.Controls.Add(this.textBoxTradeInAllowance);
            this.panel1.Controls.Add(this.textBoxTotal);
            this.panel1.Controls.Add(this.textBoxSalesTax_8);
            this.panel1.Controls.Add(this.textBoxSubtotal);
            this.panel1.Controls.Add(this.textBoxAccessoriesFinish);
            this.panel1.Controls.Add(this.textBoxCarSSalesPrice);
            this.panel1.Location = new System.Drawing.Point(278, 48);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(284, 226);
            this.panel1.TabIndex = 4;
            // 
            // labelAmountDue
            // 
            this.labelAmountDue.AutoSize = true;
            this.labelAmountDue.Location = new System.Drawing.Point(62, 199);
            this.labelAmountDue.Name = "labelAmountDue";
            this.labelAmountDue.Size = new System.Drawing.Size(96, 20);
            this.labelAmountDue.TabIndex = 1;
            this.labelAmountDue.Text = "Amount Due:";
            this.labelAmountDue.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // labelTradeInAllowance
            // 
            this.labelTradeInAllowance.AutoSize = true;
            this.labelTradeInAllowance.Location = new System.Drawing.Point(18, 166);
            this.labelTradeInAllowance.Name = "labelTradeInAllowance";
            this.labelTradeInAllowance.Size = new System.Drawing.Size(140, 20);
            this.labelTradeInAllowance.TabIndex = 1;
            this.labelTradeInAllowance.Text = "Trade-in Allowance:";
            this.labelTradeInAllowance.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // labelTotal
            // 
            this.labelTotal.AutoSize = true;
            this.labelTotal.Location = new System.Drawing.Point(113, 133);
            this.labelTotal.Name = "labelTotal";
            this.labelTotal.Size = new System.Drawing.Size(45, 20);
            this.labelTotal.TabIndex = 1;
            this.labelTotal.Text = "Total:";
            this.labelTotal.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // labelSalesTax_8
            // 
            this.labelSalesTax_8.AutoSize = true;
            this.labelSalesTax_8.Location = new System.Drawing.Point(57, 100);
            this.labelSalesTax_8.Name = "labelSalesTax_8";
            this.labelSalesTax_8.Size = new System.Drawing.Size(101, 20);
            this.labelSalesTax_8.TabIndex = 1;
            this.labelSalesTax_8.Text = "Sales Tax(8%):";
            this.labelSalesTax_8.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // labelSubtotal
            // 
            this.labelSubtotal.AutoSize = true;
            this.labelSubtotal.Location = new System.Drawing.Point(90, 67);
            this.labelSubtotal.Name = "labelSubtotal";
            this.labelSubtotal.Size = new System.Drawing.Size(68, 20);
            this.labelSubtotal.TabIndex = 1;
            this.labelSubtotal.Text = "Subtotal:";
            this.labelSubtotal.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // labelAccessoriesFinish
            // 
            this.labelAccessoriesFinish.AutoSize = true;
            this.labelAccessoriesFinish.Location = new System.Drawing.Point(25, 34);
            this.labelAccessoriesFinish.Name = "labelAccessoriesFinish";
            this.labelAccessoriesFinish.Size = new System.Drawing.Size(133, 20);
            this.labelAccessoriesFinish.TabIndex = 1;
            this.labelAccessoriesFinish.Text = "Accessories & Finish:";
            this.labelAccessoriesFinish.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // labelCarSSalesPrice
            // 
            this.labelCarSSalesPrice.AutoSize = true;
            this.labelCarSSalesPrice.Location = new System.Drawing.Point(41, 3);
            this.labelCarSSalesPrice.Name = "labelCarSSalesPrice";
            this.labelCarSSalesPrice.Size = new System.Drawing.Size(117, 20);
            this.labelCarSSalesPrice.TabIndex = 1;
            this.labelCarSSalesPrice.Text = "Car\'s Sales Price:";
            this.labelCarSSalesPrice.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // textBoxAmountDue
            // 
            this.textBoxAmountDue.BackColor = System.Drawing.SystemColors.Control;
            this.textBoxAmountDue.Enabled = false;
            this.textBoxAmountDue.Location = new System.Drawing.Point(164, 196);
            this.textBoxAmountDue.MaximumSize = new System.Drawing.Size(120, 27);
            this.textBoxAmountDue.MinimumSize = new System.Drawing.Size(120, 27);
            this.textBoxAmountDue.Name = "textBoxAmountDue";
            this.textBoxAmountDue.ReadOnly = true;
            this.textBoxAmountDue.Size = new System.Drawing.Size(120, 27);
            this.textBoxAmountDue.TabIndex = 0;
            this.textBoxAmountDue.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // textBoxTradeInAllowance
            // 
            this.textBoxTradeInAllowance.Location = new System.Drawing.Point(164, 163);
            this.textBoxTradeInAllowance.MaximumSize = new System.Drawing.Size(120, 27);
            this.textBoxTradeInAllowance.MinimumSize = new System.Drawing.Size(120, 27);
            this.textBoxTradeInAllowance.Name = "textBoxTradeInAllowance";
            this.textBoxTradeInAllowance.Size = new System.Drawing.Size(120, 27);
            this.textBoxTradeInAllowance.TabIndex = 0;
            this.textBoxTradeInAllowance.Text = "0";
            this.textBoxTradeInAllowance.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // textBoxTotal
            // 
            this.textBoxTotal.BackColor = System.Drawing.SystemColors.Control;
            this.textBoxTotal.Enabled = false;
            this.textBoxTotal.Location = new System.Drawing.Point(164, 130);
            this.textBoxTotal.MaximumSize = new System.Drawing.Size(120, 27);
            this.textBoxTotal.MinimumSize = new System.Drawing.Size(120, 27);
            this.textBoxTotal.Name = "textBoxTotal";
            this.textBoxTotal.ReadOnly = true;
            this.textBoxTotal.Size = new System.Drawing.Size(120, 27);
            this.textBoxTotal.TabIndex = 0;
            this.textBoxTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // textBoxSalesTax_8
            // 
            this.textBoxSalesTax_8.BackColor = System.Drawing.SystemColors.Control;
            this.textBoxSalesTax_8.Enabled = false;
            this.textBoxSalesTax_8.Location = new System.Drawing.Point(164, 97);
            this.textBoxSalesTax_8.MaximumSize = new System.Drawing.Size(120, 27);
            this.textBoxSalesTax_8.MinimumSize = new System.Drawing.Size(120, 27);
            this.textBoxSalesTax_8.Name = "textBoxSalesTax_8";
            this.textBoxSalesTax_8.ReadOnly = true;
            this.textBoxSalesTax_8.Size = new System.Drawing.Size(120, 27);
            this.textBoxSalesTax_8.TabIndex = 0;
            this.textBoxSalesTax_8.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // textBoxSubtotal
            // 
            this.textBoxSubtotal.BackColor = System.Drawing.SystemColors.Control;
            this.textBoxSubtotal.Enabled = false;
            this.textBoxSubtotal.Location = new System.Drawing.Point(164, 64);
            this.textBoxSubtotal.MaximumSize = new System.Drawing.Size(120, 27);
            this.textBoxSubtotal.MinimumSize = new System.Drawing.Size(120, 27);
            this.textBoxSubtotal.Name = "textBoxSubtotal";
            this.textBoxSubtotal.ReadOnly = true;
            this.textBoxSubtotal.Size = new System.Drawing.Size(120, 27);
            this.textBoxSubtotal.TabIndex = 0;
            this.textBoxSubtotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // textBoxAccessoriesFinish
            // 
            this.textBoxAccessoriesFinish.BackColor = System.Drawing.SystemColors.Control;
            this.textBoxAccessoriesFinish.Enabled = false;
            this.textBoxAccessoriesFinish.Location = new System.Drawing.Point(164, 31);
            this.textBoxAccessoriesFinish.MaximumSize = new System.Drawing.Size(120, 27);
            this.textBoxAccessoriesFinish.MinimumSize = new System.Drawing.Size(120, 27);
            this.textBoxAccessoriesFinish.Name = "textBoxAccessoriesFinish";
            this.textBoxAccessoriesFinish.ReadOnly = true;
            this.textBoxAccessoriesFinish.Size = new System.Drawing.Size(120, 27);
            this.textBoxAccessoriesFinish.TabIndex = 0;
            this.textBoxAccessoriesFinish.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // textBoxCarSSalesPrice
            // 
            this.textBoxCarSSalesPrice.Location = new System.Drawing.Point(164, 0);
            this.textBoxCarSSalesPrice.MaximumSize = new System.Drawing.Size(120, 27);
            this.textBoxCarSSalesPrice.MinimumSize = new System.Drawing.Size(120, 27);
            this.textBoxCarSSalesPrice.Name = "textBoxCarSSalesPrice";
            this.textBoxCarSSalesPrice.Size = new System.Drawing.Size(120, 27);
            this.textBoxCarSSalesPrice.TabIndex = 0;
            this.textBoxCarSSalesPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 383);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.buttonExit);
            this.Controls.Add(this.buttonPrintForm);
            this.Controls.Add(this.buttonClear);
            this.Controls.Add(this.buttonCalculate);
            this.Controls.Add(this.radioButtonCarExteriorFinish);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Auto Center";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.radioButtonCarExteriorFinish.ResumeLayout(false);
            this.radioButtonCarExteriorFinish.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox checkBoxComputerNavigation;
        private System.Windows.Forms.CheckBox checkBoxLeatherInterior;
        private System.Windows.Forms.CheckBox checkBoxStereoSystem;
        private System.Windows.Forms.GroupBox radioButtonCarExteriorFinish;
        private System.Windows.Forms.RadioButton radioButtonCustomizedDetailing;
        private System.Windows.Forms.RadioButton radioButtonPearlized;
        private System.Windows.Forms.RadioButton radioButtonStandard;
        private System.Windows.Forms.Button buttonCalculate;
        private System.Windows.Forms.Button buttonClear;
        private System.Windows.Forms.Button buttonPrintForm;
        private System.Windows.Forms.Button buttonExit;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox textBoxCarSSalesPrice;
        private System.Windows.Forms.TextBox textBoxAccessoriesFinish;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.TextBox textBoxSubtotal;
        private System.Windows.Forms.Label labelAmountDue;
        private System.Windows.Forms.Label labelTradeInAllowance;
        private System.Windows.Forms.Label labelTotal;
        private System.Windows.Forms.Label labelSalesTax_8;
        private System.Windows.Forms.Label labelSubtotal;
        private System.Windows.Forms.Label labelAccessoriesFinish;
        private System.Windows.Forms.Label labelCarSSalesPrice;
        private System.Windows.Forms.TextBox textBoxAmountDue;
        private System.Windows.Forms.TextBox textBoxTradeInAllowance;
        private System.Windows.Forms.TextBox textBoxTotal;
        private System.Windows.Forms.TextBox textBoxSalesTax_8;
    }
}

