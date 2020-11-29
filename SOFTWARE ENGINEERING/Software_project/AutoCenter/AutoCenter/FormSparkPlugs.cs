using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace AutoCenter
{
    public partial class FormSparkPlugs : Form
    {
        List<ReplacementSparkPlugItem> replacementSparkPlugItems = new List<ReplacementSparkPlugItem>();

        class ReplacementSparkPlugItem
        {
            public String auto;
            public String brandA;
            public String brandB;
            public String brandX;

            public ReplacementSparkPlugItem(String auto, String brandA, String brandB, String brandX)
            {
                this.auto = auto;
                this.brandA = brandA;
                this.brandB = brandB;
                this.brandX = brandX;
            }

        }
        public FormSparkPlugs()
        {
            InitializeComponent();
            replacementSparkPlugItems.Add(new ReplacementSparkPlugItem("PR214", "MR43T", "RBL8", "14K22"));
            replacementSparkPlugItems.Add(new ReplacementSparkPlugItem("PR223", "R43", "RJ6", "14K24"));
            replacementSparkPlugItems.Add(new ReplacementSparkPlugItem("PR224", "R43N", "RN4", "14K30"));
            replacementSparkPlugItems.Add(new ReplacementSparkPlugItem("PR246", "R46N", "RN8", "14K32"));
            replacementSparkPlugItems.Add(new ReplacementSparkPlugItem("PR247", "R46TS", "RBL17Y", "14K33"));
            replacementSparkPlugItems.Add(new ReplacementSparkPlugItem("PR248", "R46TX", "RBL12-6", "14K35"));
            replacementSparkPlugItems.Add(new ReplacementSparkPlugItem("PR324", "S46", "J11", "14K38"));
            replacementSparkPlugItems.Add(new ReplacementSparkPlugItem("PR326", "SR46E", "XEJ8", "14K40"));
            replacementSparkPlugItems.Add(new ReplacementSparkPlugItem("PR444", "47L", "H12", "14K44"));

        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }


        private void FormSparkPlugs_Load(object sender, EventArgs e)
        {

        }

        private void buttonFindReplacement_Click(object sender, EventArgs e)
        {
            Boolean foundResult = false;
            String searchPartName = textBoxPartNumber.Text;
            if (this.comboBoxBrand.SelectedItem != null)
            {
                foreach(ReplacementSparkPlugItem item in replacementSparkPlugItems)
                {
                    switch (this.comboBoxBrand.SelectedItem.ToString())
                    {
                        case "Brand A":
                            if (searchPartName.ToLower().Equals(item.brandA.ToLower()))
                            {
                                foundResult = true;
                                labelFoundReplacementValue.Text = item.auto;
                            }
                            break;
                        case "Brand B":
                            if (searchPartName.ToLower().Equals(item.brandB.ToLower()))
                            {
                                foundResult = true;
                                labelFoundReplacementValue.Text = item.auto;
                            }
                            break;
                        case "Brand X":
                            if (searchPartName.ToLower().Equals(item.brandX.ToLower()))
                            {
                                foundResult = true;
                                labelFoundReplacementValue.Text = item.auto;
                            }
                            break;
                    }
                }
                if(foundResult == false)
                {
                    labelFoundReplacementValue.Text = "No replacement found";
                }

            }
            else
            {
                MessageBox.Show("Please select brand of the part", "No brand selected");
            }
        }
    }
}
