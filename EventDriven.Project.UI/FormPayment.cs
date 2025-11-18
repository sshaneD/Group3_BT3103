using System.Drawing.Printing;
using EventDriven.Project.Businesslogic.Controller;
using EventDriven.Project.Model;

namespace EventDriven.Project.UI
{
    public partial class FormPayment : Form
    {
        BillingController billingController;
        PatientController patientController;
        BillingModel selectedBilling;
        BillingModel billingSummary;
        int selectedPatientID;
        int admissionID;
        public FormPayment(int AdmissionID)
        {
            InitializeComponent();
            billingController = new BillingController();
            patientController = new PatientController();
            selectedPatientID = FormMain.selectedPatientID;
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
            PatientModel patient = patientController.GetPatientById(selectedPatientID);
            int billingID = selectedBilling.BillingID;
            decimal payment = Convert.ToDecimal(txtAmountPaid.Text);
            string remarks = txtRemarks.Text;
            if (Convert.ToDecimal(txtAmountPaid.Text) < (Convert.ToDecimal(lblTotalAmount.Text) * Convert.ToDecimal(0.5)))
            {
                MessageBox.Show($"Amount paid is less than 50% of the total amount. Please pay at least {Convert.ToDecimal(lblTotalAmount.Text) * Convert.ToDecimal(0.5)}.", "Insufficient Payment", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            billingSummary = billingController.ConfirmPayment(billingID, payment, remarks);
            string change = string.Empty;
            if (billingSummary.Balance < 0)
            {
                change = $"Change: {billingSummary.AmountPaid - billingSummary.TotalAmount}{Environment.NewLine}";
            }
            if (patient.Status.Equals("Discharged") && billingSummary.Balance <= 0 && FormMain.receivedValidID.Equals(true))
            {
                MessageBox.Show("Valid ID has been returned", "", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
            DialogResult result = MessageBox.Show(change + "Do you want to print the receipt?", "Payment Received", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (result == DialogResult.Yes)
            {
                printPreviewDialog1.ShowDialog();
                FormMain.selectedPatientID = 0;
                FormMain.selectedRecordID = 0;
                FormMain.SelectedRoom = new RoomInfoModel();
                FormMain.assignedStaff.Clear();
            }
            else
            {
                FormMain.selectedPatientID = 0;
                FormMain.selectedRecordID = 0;
                FormMain.SelectedRoom = new RoomInfoModel();
                FormMain.assignedStaff.Clear();
            }
            DialogResult = DialogResult.OK;
            Close();
        }
        private void printDocument1_PrintPage(object sender, PrintPageEventArgs e)
        {
            PatientModel patient = patientController.GetPatientById(selectedPatientID);
            Graphics g = e.Graphics;

            float pageWidth = e.PageBounds.Width;
            float margin = 50;
            float y = margin;

            // --- Hospital Name ---
            string title = "Apex Medical Center";
            Font titleFont = new Font("Arial", 22, FontStyle.Bold);
            SizeF titleSize = g.MeasureString(title, titleFont);
            g.DrawString(title, titleFont, Brushes.Black, (pageWidth - titleSize.Width) / 2, y);
            y += titleSize.Height + 5;

            // --- Billing Receipt subtitle ---
            string subtitle = "Billing Receipt";
            Font subtitleFont = new Font("Arial", 16, FontStyle.Bold);
            SizeF subtitleSize = g.MeasureString(subtitle, subtitleFont);
            g.DrawString(subtitle, subtitleFont, Brushes.Black, (pageWidth - subtitleSize.Width) / 2, y);
            y += subtitleSize.Height + 15;

            // --- Generated Date ---
            g.DrawString("Generated: " + DateTime.Now.ToString("MM/dd/yyyy"),
                new Font("Arial", 12), Brushes.Gray, margin, y);
            y += 30;

            g.DrawLine(Pens.Black, margin, y, pageWidth - margin, y);
            y += 20;

            Font headerFont = new Font("Arial", 14, FontStyle.Bold);
            Font regularFont = new Font("Arial", 12);
            g.DrawString($"{patient.FirstName} {patient.MiddleName} {patient.LastName}", headerFont, Brushes.Black, margin, y);
            y += 25;
            g.DrawString($"Patient ID: {patient.PatientID}", regularFont, Brushes.Black, margin, y);
            y += 20;
            g.DrawString($"{patient.Gender} | {patient.Age} Years Old", regularFont, Brushes.Black, margin, y);
            y += 30;

            Font tableHeaderFont = new Font("Arial", 12, FontStyle.Bold);
            float[] columnX = { margin, 350, 490, 600 };
            g.DrawString("Service/Item", tableHeaderFont, Brushes.Black, columnX[0], y);
            g.DrawString("Quantity/Days", tableHeaderFont, Brushes.Black, columnX[1], y);
            g.DrawString("Price", tableHeaderFont, Brushes.Black, columnX[2], y);
            g.DrawString("Total", tableHeaderFont, Brushes.Black, columnX[3], y);
            y += 25;

            List<int> admissionIDs = patientController.GetPatientAdmissionIDs(selectedPatientID);
            List<BillingDetailsModel> billingDetails = new List<BillingDetailsModel>();
            decimal GrandTotal = 0;

            foreach (int admissionID in admissionIDs)
            {
                List<BillingDetailsModel> details = billingController.GetBillingDetails(admissionID);
                billingDetails.AddRange(details);
            }

            Font tableFont = new Font("Arial", 11);
            foreach (var detail in billingDetails)
            {
                if ((billingDetails.IndexOf(detail) % 2) == 1)
                    g.FillRectangle(Brushes.LightGray, margin, y, pageWidth - 2 * margin, 25);

                g.DrawString(detail.Service, tableFont, Brushes.Black, columnX[0], y);
                g.DrawString(detail.Quantity.ToString(), tableFont, Brushes.Black, columnX[1] + 50, y);
                g.DrawString($"₱{detail.Price}", tableFont, Brushes.Black, columnX[2] + 30, y);
                g.DrawString($"₱{detail.Total}", tableFont, Brushes.Black, columnX[3] + 30, y);

                y += 25;
                GrandTotal += detail.Total;
            }

            g.DrawLine(Pens.Black, margin, y, pageWidth - margin, y);
            y += 20;

            RectangleF summaryRect = new RectangleF(margin, y, pageWidth - 2 * margin, 120);
            g.DrawRectangle(Pens.Black, summaryRect.X, summaryRect.Y, summaryRect.Width, summaryRect.Height);

            g.DrawString("Total Amount:", headerFont, Brushes.Black, summaryRect.X + 10, summaryRect.Y + 10);
            g.DrawString("Payment Received:", headerFont, Brushes.Black, summaryRect.X + 10, summaryRect.Y + 40);
            g.DrawString("Remaining Balance:", headerFont, Brushes.Black, summaryRect.X + 10, summaryRect.Y + 70);
            g.DrawString("Remarks:", headerFont, Brushes.Black, summaryRect.X + 10, summaryRect.Y + 100);

            g.DrawString("₱" + billingSummary.TotalAmount.ToString("N2"), headerFont, Brushes.Black, summaryRect.X + 450, summaryRect.Y + 10);
            g.DrawString("₱" + billingSummary.AmountPaid.ToString("N2"), headerFont, Brushes.Black, summaryRect.X + 450, summaryRect.Y + 40);
            g.DrawString("₱" + (billingSummary.Balance < 0 ? 0 : billingSummary.Balance).ToString("N2"), headerFont, Brushes.Black, summaryRect.X + 450, summaryRect.Y + 70);
            g.DrawString(billingSummary.Remarks, headerFont, Brushes.Black, summaryRect.X + 10, summaryRect.Y + 100);
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
        private void txtAmountPaid_Leave(object sender, EventArgs e)
        {
            decimal change = Convert.ToDecimal(txtAmountPaid.Text) - Convert.ToDecimal(lblTotalAmount.Text);
            lblChange.Text = change <= 0 ? "0" : change.ToString();
        }
    }
}