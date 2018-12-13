using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataPrinter
{
    public static class Printing
    {
        public static void Print(string PrinterName)
        {
            PrintDocument doc = new PrintDocument();
            doc.PrinterSettings.PrinterName = PrinterName;
            doc.PrintPage += new PrintPageEventHandler(PrintHandler);
            doc.Print();
        }

        private static void PrintHandler(object sender, PrintPageEventArgs ppeArgs)
        {
            Font FontNormal = new Font("Verdana", 12);
            Graphics g = ppeArgs.Graphics;
            g.DrawString("Your string to print", FontNormal, Brushes.Black, 10, 10, new StringFormat());
        }

    }
}
