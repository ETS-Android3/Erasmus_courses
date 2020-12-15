using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace AutoCenter
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
    public class PrintTool
    {
        public List<PrintLine> printLines = new List<PrintLine>();

        public void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            Graphics page = e.Graphics;
            SolidBrush solidBrush = new SolidBrush(Color.Black);
            int xpos = 50;
            int ypos = 80;
            foreach (PrintLine line in printLines)
            {
                page.DrawString(line.Text, line.Font, solidBrush, xpos, ypos, line.Format);
                ypos += line.Font.Height + 3;
            }
        }

    }
}
