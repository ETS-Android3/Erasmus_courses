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
        float carSalesPrice, accessoriesFinish, subtotal;
        float amount, tax8, total, tradeInAllowance;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void helpAbout_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This section is about App and Author", "About");
        }
        private void buttonClear_Click(object sender, EventArgs e)
        {
            clearDataAndWindow();
            calculate();
        }

        private void buttonCalculate_Click(object sender, EventArgs e)
        {
            clearData();
            getDataFromForms();
            calculate();
        }
        private void getDataFromForms()
        {
            getDataFromCarSSalesPrice();
            getDataFromTradeInAllowance();
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
                parsingMessageBox();
            }
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void buttonPrintForm_Click(object sender, EventArgs e)
        {

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
                parsingMessageBox();
            }
        }
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
        private void calculate()
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
        private void parsingMessageBox()
        {
            MessageBox.Show("Input data should be float", "Parsing error");
        }
    }
}
