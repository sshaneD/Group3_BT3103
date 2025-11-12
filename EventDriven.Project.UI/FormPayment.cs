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
using EventDriven.Project.Businesslogic.Controller;
using EventDriven.Project.Model;

namespace EventDriven.Project.UI
{
    public partial class FormPayment : Form
    {
        BillingController billingController;
        BillingModel selectedBilling;
        BillingModel billingSummary;
        int admissionID;
        public FormPayment(int AdmissionID)
        {
            InitializeComponent();
            billingController = new BillingController();
            admissionID = AdmissionID;
            selectedBilling = billingController.GenerateBilling(admissionID);
            lblTotalAmount.Text = selectedBilling.Balance.ToString();
        }
        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void btnConfirm_Click(object sender, EventArgs e)
        {
            int billingID = selectedBilling.BillingID;
            decimal payment = Convert.ToDecimal(txtAmountPaid.Text);
            string remarks = txtRemarks.Text;
            billingSummary = billingController.ConfirmPayment(billingID, payment, remarks);
            string change = string.Empty;
            if (billingSummary.Balance <= 0)
            {
                change = $"Change: {billingSummary.TotalAmount - billingSummary.AmountPaid}{Environment.NewLine}";
            }
            DialogResult result = MessageBox.Show(change + "Do you want to print the receipt?", "Payment Received", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (result == DialogResult.Yes)
            {
                printPreviewDialog1.ShowDialog();
                Close();
            }
            else
            {
                Close();
            }
        }
        private void printDocument1_PrintPage(object sender, PrintPageEventArgs e)
        {
            Graphics g = e.Graphics;

            g.DrawString("Receipt", new Font("Arial", 20, FontStyle.Bold), Brushes.Black, new PointF(100, 50));

            g.DrawString("Generated: " + DateTime.Now.ToString("MM/dd/yyyy"), new Font("Arial", 12), Brushes.Gray, new PointF(100, 90));

            g.DrawLine(Pens.Black, 100, 120, 700, 120);

            g.DrawString("Service/Item", new Font("Arial", 12, FontStyle.Bold), Brushes.Black, new PointF(100, 140));
            g.DrawString("Quantity/Days", new Font("Arial", 12, FontStyle.Bold), Brushes.Black, new PointF(350, 140));
            g.DrawString("Price", new Font("Arial", 12, FontStyle.Bold), Brushes.Black, new PointF(490, 140));
            g.DrawString("Total", new Font("Arial", 12, FontStyle.Bold), Brushes.Black, new PointF(600, 140));

            int y = 170;

            List<BillingDetailsModel> billingDetails = billingController.GetBillingDetails(admissionID); 
            decimal total = 0;
            foreach (var detail in billingDetails)
            {
                g.DrawString(detail.Service, new Font("Arial", 11), Brushes.Black, new PointF(100, y));
                g.DrawString(detail.Quantity.ToString(), new Font("Arial", 11), Brushes.Black, new PointF(400, y));
                g.DrawString($"₱{detail.Price}", new Font("Arial", 11), Brushes.Black, new PointF(500, y));
                g.DrawString($"₱{detail.Total}", new Font("Arial", 11), Brushes.Black, new PointF(600, y));
                y += 30;
                total += detail.Total;
            }

            g.DrawLine(Pens.Black, 100, y, 700, y);
            g.DrawString("Total Amount:", new Font("Arial", 14, FontStyle.Bold), Brushes.Black, new PointF(100, y + 30));
            g.DrawString("Payment Received:", new Font("Arial", 14, FontStyle.Bold), Brushes.Black, new PointF(100, y + 60));
            g.DrawString("Remaining Balance:", new Font("Arial", 14, FontStyle.Bold), Brushes.Black, new PointF(100, y + 90));
            g.DrawString("Remarks:", new Font("Arial", 14, FontStyle.Bold), Brushes.Black, new PointF(100, y + 120));
            g.DrawString("₱" + billingSummary.TotalAmount.ToString(), new Font("Arial", 14, FontStyle.Bold), Brushes.Black, new PointF(580, y + 30));
            g.DrawString("₱" + billingSummary.AmountPaid.ToString(), new Font("Arial", 14, FontStyle.Bold), Brushes.Black, new PointF(580, y + 60));
            g.DrawString("₱" + billingSummary.Balance.ToString(), new Font("Arial", 14, FontStyle.Bold), Brushes.Black, new PointF(580, y + 90));
            g.DrawString(billingSummary.Remarks, new Font("Arial", 14), Brushes.Black, new PointF(100, y + 150));
        }
        private void txtAmountPaid_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '.')
            {
                e.Handled = true;
            }

            if (e.KeyChar == '.' && txtAmountPaid.Text.Contains("."))
            {
                e.Handled = true;
            }
        }
    }
}
