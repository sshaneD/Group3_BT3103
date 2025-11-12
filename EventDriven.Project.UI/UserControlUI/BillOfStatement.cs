using System.Drawing.Printing;
using EventDriven.Project.Businesslogic.Controller;
using EventDriven.Project.Model;

namespace EventDriven.Project.UI.UserControlUI
{
    public partial class BillOfStatement : UserControl
    {
        PatientController patientController;
        BillingController billingController;
        int selectedPatientID;
        List<PatientModel> patients;
        AutoCompleteStringCollection names;
        public BillOfStatement()
        {
            InitializeComponent();
            patientController = new PatientController();
            billingController = new BillingController();
            selectedPatientID = FormMain.selectedPatientID;
            names = new AutoCompleteStringCollection();
            patients = patientController.GetAllPatients();
            foreach (PatientModel patient in patients)
            {
                names.Add($"{patient.FirstName} {patient.MiddleName} {patient.LastName}");
            }
            txtSearch.AutoCompleteSource = AutoCompleteSource.CustomSource;
            txtSearch.AutoCompleteCustomSource = names;
            if (selectedPatientID != 0)
            {
                LoadPatientDetails();
                LoadBillingDetails();
            }
            else
            {
                ClearData();
            }
        }
        private void LoadPatientDetails()
        {
            PatientModel patient = patientController.GetPatientById(selectedPatientID);
            lblPatientID.Text = patient.PatientID.ToString();
            lblPatientName.Text = $"{patient.FirstName} {patient.MiddleName} {patient.LastName}";
            lblGender.Text = patient.Gender;
            lblBirthday.Text = patient.DateOfBirth.ToString("MM/dd/yyyy");
        }
        private void ClearData()
        {
            lblPatientID.Text = string.Empty;
            lblPatientName.Text = string.Empty;
            lblGender.Text = string.Empty;
            lblBirthday.Text = string.Empty;
        }
        private void LoadBillingDetails()
        {
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
                GrandTotal += detail.Total;
            }
            billingDetails.Add(new BillingDetailsModel());
            billingDetails.Add(new BillingDetailsModel());
            billingDetails.Add(new BillingDetailsModel()
            {
                Total = GrandTotal
            });
            dataGridView1.DataSource = billingDetails;
            dataGridView1.Columns["AdmissionID"].Visible = false;
        }
        private void btnPrintBOS_Click(object sender, EventArgs e)
        {
            printPreviewDialog1.ShowDialog();
        }
        private void printDocument1_PrintPage(object sender, PrintPageEventArgs e)
        {

            Graphics g = e.Graphics;

            g.DrawString("Billing Statement", new Font("Arial", 20, FontStyle.Bold), Brushes.Black, new PointF(100, 50));

            g.DrawString("Generated: " + DateTime.Now.ToString("MM/dd/yyyy"), new Font("Arial", 12), Brushes.Gray, new PointF(100, 90));

            g.DrawLine(Pens.Black, 100, 120, 700, 120);

            g.DrawString("Service/Item", new Font("Arial", 12, FontStyle.Bold), Brushes.Black, new PointF(100, 140));
            g.DrawString("Quantity/Days", new Font("Arial", 12, FontStyle.Bold), Brushes.Black, new PointF(350, 140));
            g.DrawString("Price", new Font("Arial", 12, FontStyle.Bold), Brushes.Black, new PointF(490, 140));
            g.DrawString("Total", new Font("Arial", 12, FontStyle.Bold), Brushes.Black, new PointF(600, 140));

            int y = 170;

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
            g.DrawString($"₱{GrandTotal}", new Font("Arial", 14, FontStyle.Bold), Brushes.Black, new PointF(580, y + 30));


            g.DrawString("End of Report", new Font("Arial", 10, FontStyle.Italic), Brushes.Gray, new PointF(100, y + 90));
        }
        private void btnPayment_Click(object sender, EventArgs e)
        {
            List<int> admissionIDs = patientController.GetPatientAdmissionIDs(selectedPatientID);
            List<BillingModel> billings = new List<BillingModel>();
            foreach (int admissionID in admissionIDs)
            {
                billings.Add(billingController.GenerateBilling(admissionID));
            }
            BillingModel selectedBilling = new BillingModel();
            foreach (BillingModel billing in billings)
            {
                if (billing.Balance > 0)
                {
                    selectedBilling = billing;
                    break;
                }
            }
            if (selectedBilling.BillingID > 0)
            {
                FormPayment payment = new FormPayment(selectedBilling.AdmissionID);
                payment.ShowDialog();
            }
            else
            {
                MessageBox.Show("Patient is currently Paid in Full.", "No Balance", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private void dataGridView1_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.Value != null && (e.Value is int || e.Value is decimal))
            {
                if (Convert.ToDecimal(e.Value) == 0)
                {
                    e.Value = "";
                    e.FormattingApplied = true;
                }
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            List<PatientModel> patients = patientController.SearchPatient(txtSearch.Text.Trim());
            selectedPatientID = patients[0].PatientID;
            LoadPatientDetails();
            LoadBillingDetails();
        }
    }
}
