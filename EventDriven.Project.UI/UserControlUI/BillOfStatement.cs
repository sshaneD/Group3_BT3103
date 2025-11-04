using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EventDriven.Project.UI.UserControlUI
{
    public partial class BillOfStatement : UserControl
    {
        public BillOfStatement()
        {
            InitializeComponent();
            printDocument1.PrintPage += new PrintPageEventHandler(printDocument1_PrintPage);
        }

        private void btnPrintBOS_Click(object sender, EventArgs e)
        {
            printPreviewDialog1.Document = printDocument1;
            printPreviewDialog1.ShowDialog();
        }

        private void printDocument1_PrintPage(object sender, PrintPageEventArgs e)
        {

            Graphics g = e.Graphics;

            g.DrawString("Bill of Statement", new Font("Arial", 20, FontStyle.Bold), Brushes.Black, new PointF(100, 50));

            g.DrawString("Generated: " + DateTime.Now.ToString("MM/dd/yyyy"), new Font("Arial", 12), Brushes.Gray, new PointF(100, 90));

            g.DrawLine(Pens.Black, 100, 120, 700, 120);

            g.DrawString("Service/Item", new Font("Arial", 12, FontStyle.Bold), Brushes.Black, new PointF(100, 140));
            g.DrawString("Quantity/Days", new Font("Arial", 12, FontStyle.Bold), Brushes.Black, new PointF(350, 140));
            g.DrawString("Price", new Font("Arial", 12, FontStyle.Bold), Brushes.Black, new PointF(490, 140));
            g.DrawString("Total", new Font("Arial", 12, FontStyle.Bold), Brushes.Black, new PointF(600, 140));

            int y = 170;
            decimal total = 0;
            for (int i = 1; i <= 5; i++)
            {
                g.DrawString("Product " + i, new Font("Arial", 11), Brushes.Black, new PointF(100, y));
                g.DrawString("₱" + (100 * i), new Font("Arial", 11), Brushes.Black, new PointF(400, y));
                g.DrawString(i.ToString(), new Font("Arial", 11), Brushes.Black, new PointF(500, y));
                g.DrawString("₱" + (100 * i * i), new Font("Arial", 11), Brushes.Black, new PointF(600, y));
                y += 30;
                total += (100 * i * i);
            }

            g.DrawLine(Pens.Black, 100, y, 700, y);
            g.DrawString("Total Amount:", new Font("Arial", 14, FontStyle.Bold), Brushes.Black, new PointF(100, y + 30));
            g.DrawString("₱" + total.ToString(), new Font("Arial", 14, FontStyle.Bold), Brushes.Black, new PointF(580, y + 30));


            g.DrawString("End of Report", new Font("Arial", 10, FontStyle.Italic), Brushes.Gray, new PointF(100, y + 90));
        }

        private void btnPayment_Click(object sender, EventArgs e)
        {
            FormPayment payment = new FormPayment();
            payment.ShowDialog();
        }
    }
}
