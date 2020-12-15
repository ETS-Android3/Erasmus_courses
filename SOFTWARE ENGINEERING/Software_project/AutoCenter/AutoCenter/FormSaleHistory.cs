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
        public class SaleFormData
        {
            public String timeStamp { get; set; }
            public Boolean checkBoxStereoSystem { get; set; }
            public Boolean checkBoxLeatherInterior { get; set; }
            public Boolean checkBoxComputerNavigation { get; set; }
            public Boolean radioButtonStandard { get; set; }
            public Boolean radioButtonPearlized { get; set; }
            public Boolean radioButtonCustomizedDetailing { get; set; }
            public String textBoxCarSSalesPrice { get; set; }
            public String textBoxAccessoriesFinish { get; set; }
            public String textBoxSubtotal { get; set; }
            public String textBoxSalesTax_8 { get; set; }
            public String textBoxTotal { get; set; }
            public String textBoxTradeInAllowance { get; set; }
            public String textBoxAmountDue { get; set; }


            public SaleFormData()
            {

            }
        }

        public PrintTool printTool;
        public FormSale formSale;
        List<SaleFormData> listOfSales;
        String historyFilename = "car_sales_history.xml";
        int currentIdx = -1;


        public FormSaleHistory()
        {
            InitializeComponent();
            currentIdx = -1;
            readFromXml();
        }

        private void menuItemHelpAbout_Click(object sender, EventArgs e)
        {
            MessageBox.Show("AutoCenter is an App that can help seller with calculating cost of Client's car", "About", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void toolStripMenuItemGoBackToFormSale_Click(object sender, EventArgs e)
        {
            goBackToFormSale_Click();
        }

        private void goBackToFormSale_Click()
        {
            this.formSale.Show();
            this.Hide();
        }


        private void buttonNext_Click(object sender, EventArgs e)
        {
            getElementFromList(currentIdx + 1);
        }
        private void buttonPrevious_Click(object sender, EventArgs e)
        {
            getElementFromList(currentIdx - 1);
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


            listOfSales = new List<SaleFormData>();
            listOfSales = root.Elements("Sale").Select(sv => new SaleFormData()
            {
                timeStamp = (String)sv.Element("timeStamp"),
                checkBoxStereoSystem = (Boolean)sv.Element("checkBoxStereoSystem"),
                checkBoxLeatherInterior = (Boolean)sv.Element("checkBoxLeatherInterior"),
                checkBoxComputerNavigation = (Boolean)sv.Element("checkBoxComputerNavigation"),
                radioButtonStandard = (Boolean)sv.Element("radioButtonStandard"),
                radioButtonPearlized = (Boolean)sv.Element("radioButtonPearlized"),
                radioButtonCustomizedDetailing = (Boolean)sv.Element("radioButtonCustomizedDetailing"),
                textBoxCarSSalesPrice = (String)sv.Element("textBoxCarSSalesPrice"),
                textBoxAccessoriesFinish = (String)sv.Element("textBoxAccessoriesFinish"),
                textBoxSubtotal = (String)sv.Element("textBoxSubtotal"),
                textBoxSalesTax_8 = (String)sv.Element("textBoxSalesTax_8"),
                textBoxTotal = (String)sv.Element("textBoxTotal"),
                textBoxTradeInAllowance = (String)sv.Element("textBoxTradeInAllowance"),
                textBoxAmountDue = (String)sv.Element("textBoxAmountDue")
            }).ToList();

        }

        private void setFormElementsFromDataset(SaleFormData inputData)
        {
            this.labelDateTimeValue.Text = inputData.timeStamp;
            this.checkBoxStereoSystem.Checked = inputData.checkBoxStereoSystem;
            this.checkBoxLeatherInterior.Checked = inputData.checkBoxLeatherInterior;
            this.checkBoxComputerNavigation.Checked = inputData.checkBoxComputerNavigation;
            this.radioButtonStandard.Checked = inputData.radioButtonStandard;
            this.radioButtonPearlized.Checked = inputData.radioButtonPearlized;
            this.textBoxCarSSalesPrice.Text = inputData.textBoxCarSSalesPrice;
            this.textBoxAccessoriesFinish.Text = inputData.textBoxAccessoriesFinish;
            this.textBoxSubtotal.Text = inputData.textBoxSubtotal;
            this.textBoxSalesTax_8.Text = inputData.textBoxSalesTax_8;
            this.textBoxTotal.Text = inputData.textBoxTotal;
            this.textBoxTradeInAllowance.Text = inputData.textBoxTradeInAllowance;
            this.textBoxAmountDue.Text = inputData.textBoxAmountDue;
        }

        private void getElementFromList(int idx)
        {
            int listSize = listOfSales.Count();
            if(listSize == 0)
            {
                DialogResult result = MessageBox.Show("No content in history. You should return to sales window.", "History Empty");
                this.buttonPrevious.Hide();
                this.buttonNext.Hide();
            }
            else
            {
                if (idx < 0)
                {
                    getElementFromList(listSize - 1);
                } 
                else if(idx >= listSize-1)
                {
                    currentIdx = listSize - 1;
                    this.buttonNext.Hide();
                } 
                else if(idx == 0)
                {
                    currentIdx = 0;
                    this.buttonPrevious.Hide();
                } 
                else
                {
                    currentIdx = idx;
                    this.buttonPrevious.Show();
                    this.buttonNext.Show();

                }
                setFormElementsFromDataset(listOfSales[currentIdx]);
            }

        }

        private void FormSaleHistory_Load(object sender, EventArgs e)
        {
            getElementFromList(currentIdx);
        }
    }
}
