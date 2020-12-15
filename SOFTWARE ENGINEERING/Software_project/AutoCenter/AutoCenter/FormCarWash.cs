using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace AutoCenter
{
    public partial class FormCarWash : Form
    {

        public PrintTool printTool;
        public FormMain formMain;
        public const String detailingExteriorHandWash = "Hand Wash";
        public const String detailingExteriorHandWax = "Hand Wax";
        public const String detailingExteriorCheckEngineFluids = "Check Engine Fluids";
        public const String detailingExteriorDetailEngineCompartment = "Detail Engine Compartment";
        public const String detailingExteriorDetailUnderCarriage = "Detail Under Carriage";
        /////////////////
        public const String detailingInteriorFragrance = "Fragrance";
        public const String detailingInteriorShampooCarpets = "Shampoo Carpets";
        public const String detailingInteriorShampooUpholstery = "Shampoo Upholstery";
        public const String detailingInteriorInteriorProtectionCoat = "Interior Protection Coat (dashboard and console)";
        public const String detailingInteriorScotchguard = "Scotchguard";


        public static List<String> exteriorFeatures = new List<String> ();
        public static List<String> interiorFeatures = new List<String> ();

        public FormCarWash()
        {
            InitializeComponent();
            printTool = new PrintTool();
        }

        private void toolStripMenuItemExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void toolStripMenuItemClear_Click(object sender, EventArgs e)
        {
            listBoxInterior.Items.Clear();
            listBoxExterior.Items.Clear();
            comboBoxDetailingPackages.SelectedItem = null;
            comboBoxFragrance.SelectedItem = null;
            printTool.printLines = new List<PrintLine>();
        }

        private void toolStripMenuItemPrint_Click(object sender, EventArgs e)
        {
            if (validData())
            {
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
                    printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(printTool.printDocument1_PrintPage);
                    printDocument1.Print();
                }
            } 
            else
            {
                MessageBox.Show("Select correct settings. Validation error", "Validation failed");
            }
        }

        private void comboBoxDetailingPackages_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxDetailingPackages.SelectedItem != null)
            {
                exteriorFeatures = new List<String>();
                interiorFeatures = new List<String>();
                listBoxInterior.Items.Clear();
                listBoxExterior.Items.Clear();
                switch (comboBoxDetailingPackages.SelectedItem.ToString())
                {
                    case "Luxury":
                        exteriorFeatures.Add(detailingExteriorCheckEngineFluids);
                        exteriorFeatures.Add(detailingExteriorDetailEngineCompartment);
                        exteriorFeatures.Add(detailingExteriorDetailUnderCarriage);

                        interiorFeatures.Add(detailingInteriorShampooUpholstery);
                        interiorFeatures.Add(detailingInteriorScotchguard);
                        goto case "Deluxe";

                    case "Executive":
                        interiorFeatures.Add(detailingInteriorInteriorProtectionCoat);
                        exteriorFeatures.Add(detailingExteriorCheckEngineFluids);
                        goto case "Deluxe";

                    case "Deluxe":
                        exteriorFeatures.Add(detailingExteriorHandWax);
                        interiorFeatures.Add(detailingInteriorShampooCarpets);
                        goto case "Standard";

                    case "Standard":
                        exteriorFeatures.Add(detailingExteriorHandWash);
                        interiorFeatures.Add(detailingInteriorFragrance);
                        break;

                }
            
                foreach(String interior in interiorFeatures)
                {
                    listBoxInterior.Items.Add(interior);
                }

                foreach (String exterior in exteriorFeatures)
                {
                    listBoxExterior.Items.Add(exterior);
                }
            }
        }

        private Boolean validData()
        {
            return listBoxExterior.Items.Count != 0 &&
                listBoxInterior.Items.Count != 0 &&
                comboBoxDetailingPackages.SelectedItem != null &&
                comboBoxFragrance.SelectedItem != null;
        }


        private void preparePrintData()
        {
            printTool.printLines = new List<PrintLine>();

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
            printTool.printLines.Add(printLine);
            printLine = new PrintLine("Car Wash", heading1PrintFont, heading1PrintStringFormat);
            printTool.printLines.Add(printLine);
            printLine = new PrintLine("Choosen packages available for detailing a vehicle: ", heading2PrintFont, heading2PrintStringFormat);
            printTool.printLines.Add(printLine);
            printLine = new PrintLine(comboBoxDetailingPackages.SelectedItem.ToString(), heading3PrintFont, heading3PrintStringFormat);
            printTool.printLines.Add(printLine);

            printTool.printLines.Add(separatorH2Line);

            printLine = new PrintLine("Choosen exterior items: ", heading2PrintFont, heading2PrintStringFormat);
            printTool.printLines.Add(printLine);
            foreach (String exterior in exteriorFeatures)
            {
                printLine = new PrintLine(exterior, heading3PrintFont, heading3PrintStringFormat);
                printTool.printLines.Add(printLine);
            }

            printTool.printLines.Add(separatorH2Line);
            printLine = new PrintLine("Choosen interior items: ", heading2PrintFont, heading2PrintStringFormat);
            printTool.printLines.Add(printLine);
            foreach (String interior in interiorFeatures)
            {
                printLine = new PrintLine(interior, heading3PrintFont, heading3PrintStringFormat);
                printTool.printLines.Add(printLine);
                if(interior == detailingInteriorFragrance)
                {
                    printLine = new PrintLine("  Choosen: " + comboBoxFragrance.SelectedItem.ToString(), heading3PrintFont, heading3PrintStringFormat);
                    printTool.printLines.Add(printLine);
                }
            }
        }

    }
}
