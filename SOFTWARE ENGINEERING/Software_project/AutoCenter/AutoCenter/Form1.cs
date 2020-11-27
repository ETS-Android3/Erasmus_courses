using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AutoCenter
{
    public partial class Form1 : Form
    {
        public class PrintLine
        {
            public String Text;
            public Font Font;
            public StringFormat Format;

            public PrintLine(String text, Font font, StringFormat format)
            {
                this.Text = text;
                this.Font = font;
                this.Format = format;
            }
        }

        float carSalesPrice, accessoriesFinish, subtotal;
        float amount, tax8, total, tradeInAllowance;
        List<PrintLine> printLines = new List<PrintLine>();
        public Form2 formMain;


        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void menuItemHelpAbout_Click(object sender, EventArgs e)
        {
            MessageBox.Show("AutoCenter is an App that can help seller with calculating cost of Client's car", "About", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void menuItemHelpGoBackToMainWizard_Click(object sender, EventArgs e)
        {
            this.formMain.Show();
            this.Hide();
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            clearDataAndWindow();
            calculateData();
        }

        private void buttonCalculate_Click(object sender, EventArgs e)
        {
            cleanGetCalculateData();
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void buttonPrintForm_Click(object sender, EventArgs e)
        {
            cleanGetCalculateData();
            preparePrintData();
            // Print dialog lets user select a print, number of copies, start page, etc.
            // To keep it simple we have ignored all of these settings
            // and assume the items in list box will fit on one page .
            DialogResult result = printDialog1.ShowDialog();
            if (result == DialogResult.OK)
            {
                // Assign all of the settings from the print dialog to the document.
                printDocument1.PrinterSettings = printDialog1.PrinterSettings;
                // Calling print executes the code in printDocument1_PrintPage
                printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
                printDocument1.Print();
            }

        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            Graphics page = e.Graphics;
            Font defaultPrintFont = new Font(this.Font.FontFamily, 16);
            SolidBrush solidBrush = new SolidBrush(Color.Black);
            int xpos = 50;
            int ypos = 80;
            foreach (PrintLine line in printLines)
            {
                page.DrawString(line.Text, line.Font, solidBrush, xpos, ypos, line.Format);
                ypos += line.Font.Height + 3;
            }
        }


        /// <summary>
        /// Helper Functions
        /// </summary>

        private void clearData()
        {
            this.carSalesPrice = 0;
            this.accessoriesFinish = 0;
            this.subtotal = 0;
            this.amount = 0;
            this.tax8 = 0;
            this.total = 0;
            this.tradeInAllowance = 0;
        }
        
        private void clearDataAndWindow()
        {
            clearData();
            this.checkBoxStereoSystem.Checked = false;
            this.checkBoxLeatherInterior.Checked = false;
            this.checkBoxComputerNavigation.Checked = false;
            this.radioButtonStandard.Checked = true;
            this.textBoxCarSSalesPrice.Text = "0";
            this.textBoxTradeInAllowance.Text = "0";
        }
        
        private void getDataFromCarSSalesPrice()
        {
            try
            {
                this.textBoxCarSSalesPrice.Text = this.textBoxCarSSalesPrice.Text.Replace('.', ',');
                this.carSalesPrice = float.Parse(this.textBoxCarSSalesPrice.Text);
            }
            catch (Exception e)
            {
                this.textBoxCarSSalesPrice.Text = "0";
                parsingErrorMessageBox();
            }
        }
        
        private void getDataFromTradeInAllowance()
        {
            try
            {
                this.textBoxTradeInAllowance.Text = this.textBoxTradeInAllowance.Text.Replace('.', ',');
                this.tradeInAllowance = float.Parse(this.textBoxTradeInAllowance.Text);
            }
            catch (Exception e)
            {
                this.textBoxTradeInAllowance.Text = "0";
                parsingErrorMessageBox();
            }
        }
        
        private void getDataFromForms()
        {
            getDataFromCarSSalesPrice();
            getDataFromTradeInAllowance();
        }
        
        private void calculateData()
        {
            if (this.checkBoxStereoSystem.Checked)
            {
                this.accessoriesFinish += (float)425.76;
            }
            if (this.checkBoxLeatherInterior.Checked)
            {
                this.accessoriesFinish += (float)987.41;
            }
            if (this.checkBoxComputerNavigation.Checked)
            {
                this.accessoriesFinish += (float)1741.43;
            }
            if (this.radioButtonPearlized.Checked)
            {
                this.accessoriesFinish += (float)345.72;
            }
            if (this.radioButtonCustomizedDetailing.Checked)
            {
                this.accessoriesFinish += (float)599.99;
            }

            this.subtotal = this.carSalesPrice + accessoriesFinish;
            this.tax8 = this.subtotal * (float)0.08;
            this.total = this.subtotal + this.tax8;
            this.amount = this.tradeInAllowance + this.total;
            this.textBoxAccessoriesFinish.Text = this.accessoriesFinish.ToString("0.00");
            this.textBoxSubtotal.Text = this.subtotal.ToString("0.00");
            this.textBoxSalesTax_8.Text = this.tax8.ToString("0.00");
            this.textBoxTotal.Text = this.total.ToString("0.00");
            this.textBoxAmountDue.Text = this.amount.ToString("0.00");
        }
        
        private void cleanGetCalculateData()
        {
            clearData();
            getDataFromForms();
            calculateData();
        }
        
        private void preparePrintData()
        {
            printLines = new List<PrintLine>();

            Font titlePrintFont = new Font(this.Font.FontFamily, 20);
            StringFormat titlePrintStringFormat = new StringFormat();
            titlePrintStringFormat.LineAlignment = StringAlignment.Center;
            Font heading1PrintFont = new Font(this.Font.FontFamily, 14);
            StringFormat heading1PrintStringFormat = new StringFormat();
            Font heading2PrintFont = new Font(this.Font.FontFamily, 12);
            StringFormat heading2PrintStringFormat = new StringFormat();
            Font heading3PrintFont = new Font(this.Font.FontFamily, 10);
            StringFormat heading3PrintStringFormat = new StringFormat();
            PrintLine separatorTLine = new PrintLine("\n", titlePrintFont, titlePrintStringFormat);
            PrintLine separatorH1Line = new PrintLine("\n", heading1PrintFont, heading1PrintStringFormat);
            PrintLine separatorH2Line = new PrintLine("\n", heading2PrintFont, heading2PrintStringFormat);
            PrintLine separatorH3Line = new PrintLine("\n", heading3PrintFont, heading3PrintStringFormat);
            PrintLine printLine;
            printLine = new PrintLine("AutoCenter company", titlePrintFont, titlePrintStringFormat);
            printLines.Add(printLine);
            printLine = new PrintLine("Choosen Accessories", heading1PrintFont, heading1PrintStringFormat);
            printLines.Add(printLine);
            printLine = new PrintLine("", heading2PrintFont, heading2PrintStringFormat);
            if (checkBoxStereoSystem.Checked)
            {
                printLine.Text += "x - ";
            }
            else
            {
                printLine.Text += "_ - ";
            }
            printLine.Text += checkBoxStereoSystem.Text;
            printLines.Add(printLine);

            printLine = new PrintLine("", heading2PrintFont, heading2PrintStringFormat);
            if (checkBoxLeatherInterior.Checked)
            {
                printLine.Text += "x - ";
            }
            else
            {
                printLine.Text += "_ - ";
            }
            printLine.Text += checkBoxLeatherInterior.Text;
            printLines.Add(printLine);


            printLine = new PrintLine("", heading2PrintFont, heading2PrintStringFormat);
            if (checkBoxComputerNavigation.Checked)
            {
                printLine.Text += "x - ";
            }
            else
            {
                printLine.Text += "_ - ";
            }
            printLine.Text += checkBoxComputerNavigation.Text;
            printLines.Add(printLine);
            printLines.Add(separatorH2Line);

            ///////////////////////////////////////////////////////////

            printLine = new PrintLine("Car Exterior Finish", heading1PrintFont, heading1PrintStringFormat);
            printLines.Add(printLine);

            printLine = new PrintLine("", heading2PrintFont, heading2PrintStringFormat);
            if (radioButtonStandard.Checked)
            {
                printLine.Text += "x - ";
            }
            else
            {
                printLine.Text += "_ - ";
            }
            printLine.Text += radioButtonStandard.Text;
            printLines.Add(printLine);

            printLine = new PrintLine("", heading2PrintFont, heading2PrintStringFormat);
            if (radioButtonPearlized.Checked)
            {
                printLine.Text += "x - ";
            }
            else
            {
                printLine.Text += "_ - ";
            }
            printLine.Text += radioButtonPearlized.Text;
            printLines.Add(printLine);


            printLine = new PrintLine("", heading2PrintFont, heading2PrintStringFormat);
            if (radioButtonCustomizedDetailing.Checked)
            {
                printLine.Text += "x - ";
            }
            else
            {
                printLine.Text += "_ - ";
            }
            printLine.Text += radioButtonCustomizedDetailing.Text;
            printLines.Add(printLine);
            printLines.Add(separatorH2Line);

            ///////////////////////////////////////////////////////////
            printLine = new PrintLine("Calculations", heading1PrintFont, heading1PrintStringFormat);
            printLines.Add(printLine);
            printLine = new PrintLine(this.labelCarSSalesPrice.Text+" "+this.textBoxCarSSalesPrice.Text, heading2PrintFont, heading2PrintStringFormat);
            printLines.Add(printLine);
            printLine = new PrintLine(this.labelAccessoriesFinish.Text + " " + this.textBoxAccessoriesFinish.Text, heading2PrintFont, heading2PrintStringFormat);
            printLines.Add(printLine);
            printLine = new PrintLine(this.labelSubtotal.Text + " " + this.textBoxSubtotal.Text, heading2PrintFont, heading2PrintStringFormat);
            printLines.Add(printLine);
            printLine = new PrintLine(this.labelSalesTax_8.Text + " " + this.textBoxSalesTax_8.Text, heading2PrintFont, heading2PrintStringFormat);
            printLines.Add(printLine);
            printLine = new PrintLine(this.labelTotal.Text + " " + this.textBoxTotal.Text, heading2PrintFont, heading2PrintStringFormat);
            printLines.Add(printLine);
            printLine = new PrintLine(this.labelTradeInAllowance.Text + " " + this.textBoxTradeInAllowance.Text, heading2PrintFont, heading2PrintStringFormat);
            printLines.Add(printLine);
            printLine = new PrintLine(this.labelAmountDue.Text + " " + this.textBoxAmountDue.Text, heading2PrintFont, heading2PrintStringFormat);
            printLines.Add(printLine);
            ///////////////////////////////////////////////////////////
            printLines.Add(separatorTLine);
            printLine = new PrintLine("Legend", heading1PrintFont, heading1PrintStringFormat);
            printLines.Add(printLine);

            printLine = new PrintLine("x - selected option", heading2PrintFont, heading2PrintStringFormat);
            printLines.Add(printLine);
            printLine = new PrintLine("_ - not selected option", heading2PrintFont, heading2PrintStringFormat);
            printLines.Add(printLine);
        }

        private void parsingErrorMessageBox()
        {
            MessageBox.Show("Input data should be float", "Parsing error");
        }


    }
}
