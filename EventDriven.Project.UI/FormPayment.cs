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
            if (patient.Status.Equals("Discharged") && billingSummary.Balance <= 0)
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
                Close();
            }
            else
            {
                FormMain.selectedPatientID = 0;
                FormMain.selectedRecordID = 0;
                FormMain.SelectedRoom = new RoomInfoModel();
                FormMain.assignedStaff.Clear();
                Close();
            }
        }
        private void printDocument1_PrintPage(object sender, PrintPageEventArgs e)
        {
            PatientModel patient = patientController.GetPatientById(selectedPatientID);
            Graphics g = e.Graphics;

            g.DrawString("Bill Receipt", new Font("Arial", 20, FontStyle.Bold), Brushes.Black, new PointF(100, 50));

            g.DrawString("Generated: " + DateTime.Now.ToString("MM/dd/yyyy"), new Font("Arial", 12), Brushes.Gray, new PointF(100, 90));

            g.DrawLine(Pens.Black, 100, 120, 700, 120);

            g.DrawString($"{patient.FirstName} {patient.MiddleName} {patient.LastName}", new Font("Arial", 16, FontStyle.Bold), Brushes.Black, new PointF(100, 140));
            g.DrawString($"Patient ID: {patient.PatientID}", new Font("Arial", 12, FontStyle.Bold), Brushes.Black, new PointF(100, 170));
            g.DrawString(patient.Gender, new Font("Arial", 12, FontStyle.Bold), Brushes.Black, new PointF(100, 200));
            g.DrawString($"{patient.Age} Years Old", new Font("Arial", 12, FontStyle.Bold), Brushes.Black, new PointF(100, 230));


            g.DrawLine(Pens.Black, 100, 270, 700, 270);

            g.DrawString("Service/Item", new Font("Arial", 12, FontStyle.Bold), Brushes.Black, new PointF(100, 280));
            g.DrawString("Quantity/Days", new Font("Arial", 12, FontStyle.Bold), Brushes.Black, new PointF(350, 280));
            g.DrawString("Price", new Font("Arial", 12, FontStyle.Bold), Brushes.Black, new PointF(490, 280));
            g.DrawString("Total", new Font("Arial", 12, FontStyle.Bold), Brushes.Black, new PointF(600, 280));

            int y = 310;

            List<int> admissionIDs = patientController.GetPatientAdmissionIDs(selectedPatientID);
            List<BillingDetailsModel> billingDetails = new List<BillingDetailsModel>();
            decimal GrandTotal = 0;
            foreach (int admissionID in admissionIDs)
            {
                List<BillingDetailsModel> details = billingController.GetBillingDetails(admissionID);
                billingDetails.AddRange(details);
            }
            foreach (var detail in billingDetails)
            {
                g.DrawString(detail.Service, new Font("Arial", 11), Brushes.Black, new PointF(100, y));
                g.DrawString(detail.Quantity.ToString(), new Font("Arial", 11), Brushes.Black, new PointF(400, y));
                g.DrawString($"₱{detail.Price}", new Font("Arial", 11), Brushes.Black, new PointF(500, y));
                g.DrawString($"₱{detail.Total}", new Font("Arial", 11), Brushes.Black, new PointF(600, y));
                y += 30;
                GrandTotal += detail.Total;
            }

            g.DrawLine(Pens.Black, 100, y, 700, y);
            g.DrawString("Total Amount:", new Font("Arial", 14, FontStyle.Bold), Brushes.Black, new PointF(100, y + 30));
            g.DrawString("Payment Received:", new Font("Arial", 14, FontStyle.Bold), Brushes.Black, new PointF(100, y + 60));
            g.DrawString("Remaining Balance:", new Font("Arial", 14, FontStyle.Bold), Brushes.Black, new PointF(100, y + 90));
            g.DrawString("Remarks:", new Font("Arial", 14, FontStyle.Bold), Brushes.Black, new PointF(100, y + 120));
            g.DrawString("₱" + billingSummary.TotalAmount.ToString(), new Font("Arial", 14, FontStyle.Bold), Brushes.Black, new PointF(580, y + 30));
            g.DrawString("₱" + billingSummary.AmountPaid.ToString(), new Font("Arial", 14, FontStyle.Bold), Brushes.Black, new PointF(580, y + 60));
            g.DrawString("₱" + (billingSummary.Balance < 0 ? 0 : billingSummary.Balance), new Font("Arial", 14, FontStyle.Bold), Brushes.Black, new PointF(580, y + 90));
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
        private void txtAmountPaid_Leave(object sender, EventArgs e)
        {
            decimal change = Convert.ToDecimal(txtAmountPaid.Text) - Convert.ToDecimal(lblTotalAmount.Text);
            lblChange.Text = change <= 0 ? "0" : change.ToString();
        }
    }
}