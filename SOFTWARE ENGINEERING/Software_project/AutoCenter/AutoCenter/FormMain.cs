using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace AutoCenter
{
    public partial class FormMain : Form
    {
        public FormSale formSale;
        public FormCarWash formCarWash;
        public FormSparkPlugs formSparkPlugs;

        public FormMain()
        {
            InitializeComponent();
        }

        private void toolStripMenuItemExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void toolStripMenuItemInputSale_Click(object sender, EventArgs e)
        {
            this.Hide();
            if(formSale == null)
            {
                formSale = new FormSale();
            }
            formSale.formMain = this;
            formSale.Show();
        }

        private void toolStripMenuItemCarWash_Click(object sender, EventArgs e)
        {
            this.Hide();
            if (formCarWash == null)
            {
                formCarWash = new FormCarWash();
            }
            //formCarWash.formMain = this;
            formCarWash.Show();
        }

        private void toolStripMenuItemColour_Click(object sender, EventArgs e)
        {
            DialogResult result = colorDialog1.ShowDialog();
            // See if user pressed ok.
            if (result == DialogResult.OK)
            {
                // Set form background to the selected color.
                this.labelBanner.ForeColor = colorDialog1.Color;
            }
        }

        private void toolStripMenuItemFont_Click(object sender, EventArgs e)
        {
            // show the font dialog modal. 
            // Nothing else happens until the dialog closes.
            fontDialog1.ShowDialog();
            // If the user clicks cancel, the font will be null.
            if (fontDialog1.Font != null)
            {
                // If not null change the font for lblHappy to selected font.
                this.labelBanner.Font = fontDialog1.Font;
            }
        }

        private void menuItemHelpAbout_Click(object sender, EventArgs e)
        {
            MessageBox.Show("AutoCenter is an App that can help seller with calculating cost of Client's car", "About", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void buttonSparkPlugs_Click(object sender, EventArgs e)
        {
            this.Hide();
            if (formSparkPlugs == null)
            {
                formSparkPlugs = new FormSparkPlugs();
            }
            //formCarWash.formMain = this;
            formSparkPlugs.Show();
        }
    }
}
