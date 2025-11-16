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
            PatientModel patient = patientController.GetPatientById(selectedPatientID);

            Graphics g = e.Graphics;

            
            Font titleFont = new Font("Arial", 22, FontStyle.Bold);
            Font headerFont = new Font("Arial", 16, FontStyle.Bold);
            Font subHeaderFont = new Font("Arial", 14, FontStyle.Bold);
            Font normalFont = new Font("Arial", 11);
            Font pInfoFont = new Font("Arial", 12);
            Font fadedFont = new Font("Arial", 10, FontStyle.Italic);

            int left = 80;
            int right = 720;
            int y = 60;

            
            g.DrawString("APEX MEDICAL CENTER", titleFont, Brushes.Black,
                new RectangleF(left, y, 650, 40),
                new StringFormat() { Alignment = StringAlignment.Center });

            y += 50;

            g.DrawString("Billing Statement", headerFont, Brushes.Black,
                new RectangleF(left, y, 650, 30),
                new StringFormat() { Alignment = StringAlignment.Center });

            y += 40;

            g.DrawString("Generated: " + DateTime.Now.ToString("MM/dd/yyyy"),
                normalFont, Brushes.Gray, left, y);

            y += 20;

            g.DrawLine(Pens.Black, left, y, right, y);
            y += 20;

            
            g.DrawString("Patient Information", subHeaderFont, Brushes.Black, left, y);
            y += 30;

            g.DrawString($"{patient.FirstName} {patient.MiddleName} {patient.LastName}",
                pInfoFont, Brushes.Black, left, y);
            y += 20;

            g.DrawString($"Patient ID: {patient.PatientID}", pInfoFont, Brushes.Black, left, y);
            y += 20;

            g.DrawString($"Gender: {patient.Gender}", pInfoFont, Brushes.Black, left, y);
            y += 20;

            g.DrawString($"Age: {patient.Age} Years Old", pInfoFont, Brushes.Black, left, y);
            y += 30;

            g.DrawLine(Pens.Black, left, y, right, y);
            y += 20;

            g.DrawString("Service / Item", subHeaderFont, Brushes.Black, left, y);
            g.DrawString("Quantity", subHeaderFont, Brushes.Black, left + 300, y);
            g.DrawString("Price", subHeaderFont, Brushes.Black, left + 430, y);
            g.DrawString("Total", subHeaderFont, Brushes.Black, left + 540, y);

            y += 25;
            g.DrawLine(Pens.Black, left, y, right, y);
            y += 15;

            int itemY = y;

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
                g.DrawString(detail.Service, normalFont, Brushes.Black, left, itemY);
                g.DrawString(detail.Quantity.ToString(), normalFont, Brushes.Black, left + 320, itemY);
                g.DrawString($"₱{detail.Price}", normalFont, Brushes.Black, left + 430, itemY);
                g.DrawString($"₱{detail.Total}", normalFont, Brushes.Black, left + 540, itemY);

                itemY += 25;
                GrandTotal += detail.Total;
            }

            y = itemY + 20;
            g.DrawLine(Pens.Black, left, y, right, y);
            y += 20;

        
            g.DrawString("Total Amount:", new Font("Arial", 14, FontStyle.Bold), Brushes.Black, left, y);
            g.DrawString($"₱{GrandTotal}", new Font("Arial", 14, FontStyle.Bold), Brushes.Black, left + 500, y);

            y += 40;

            g.DrawLine(Pens.Gray, left, y, right, y);
            y += 15;

            g.DrawString("End of Report", fadedFont, Brushes.Gray, left, y);
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

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void roundedPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
