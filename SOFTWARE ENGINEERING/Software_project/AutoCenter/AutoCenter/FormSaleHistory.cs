using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using System;
using System.IO;

namespace AutoCenter
{
    public partial class FormSaleHistory : Form
    {

        public PrintTool printTool;
        float carSalesPrice, accessoriesFinish, subtotal;
        float amount, tax8, total, tradeInAllowance;
        public FormSale formSale;
        String historyFilename = "car_sales_history.xml";



        public FormSaleHistory()
        {
            InitializeComponent();
        }

        private void menuItemHelpAbout_Click(object sender, EventArgs e)
        {
            MessageBox.Show("AutoCenter is an App that can help seller with calculating cost of Client's car", "About", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void toolStripMenuItemGoBackToFormSale_Click(object sender, EventArgs e)
        {
            this.formSale.Show();
            this.Hide();
        }


        private void buttonNext_Click(object sender, EventArgs e)
        {

        }
        private void buttonPrevious_Click(object sender, EventArgs e)
        {

        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }




        private void clearDataAndWindow()
        {
            this.checkBoxStereoSystem.Checked = false;
            this.checkBoxLeatherInterior.Checked = false;
            this.checkBoxComputerNavigation.Checked = false;
            this.radioButtonStandard.Checked = true;
            this.textBoxCarSSalesPrice.Text = "0";
            this.textBoxTradeInAllowance.Text = "0";
        }
        
        private void readFromXml()
        {
            XElement root;

            if (File.Exists(historyFilename))
                root = XElement.Load(historyFilename);
            else
                root = new XElement("Sales");

            root.Add(new XElement("Sale",
                     new XElement("timeStamp", DateTime.Now.ToString()),
                     new XElement("checkBoxStereoSystem", checkBoxStereoSystem.Checked),
                     new XElement("checkBoxLeatherInterior", checkBoxLeatherInterior.Checked),
                     new XElement("checkBoxComputerNavigation", checkBoxComputerNavigation.Checked),
                     new XElement("radioButtonStandard", radioButtonStandard.Checked),
                     new XElement("radioButtonPearlized", radioButtonPearlized.Checked),
                     new XElement("radioButtonCustomizedDetailing", radioButtonCustomizedDetailing.Checked),
                     new XElement("textBoxCarSSalesPrice", textBoxCarSSalesPrice.Text),
                     new XElement("textBoxAccessoriesFinish", textBoxAccessoriesFinish.Text),
                     new XElement("textBoxSubtotal", textBoxSubtotal.Text),
                     new XElement("textBoxSalesTax_8", textBoxSalesTax_8.Text),
                     new XElement("textBoxTotal", textBoxTotal.Text),
                     new XElement("textBoxTradeInAllowance", textBoxTradeInAllowance.Text),
                     new XElement("textBoxAmountDue", textBoxAmountDue.Text) 
                     ));
            root.Save(historyFilename);
        }

    }
}
