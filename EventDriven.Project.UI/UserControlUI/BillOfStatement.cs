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
            txtSearch.AutoCompleteCustomSource = names;
            txtSearch.AutoCompleteSource = AutoCompleteSource.CustomSource;
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
            BillingModel billing = billingController.GenerateBilling(admissionIDs[0]);
            foreach (int admissionID in admissionIDs)
            {
                List<BillingDetailsModel> details = billingController.GetBillingDetails(admissionID);
                billingDetails.AddRange(details);
            }
            billingDetails.Add(new BillingDetailsModel());
            billingDetails.Add(new BillingDetailsModel());
            billingDetails.Add(new BillingDetailsModel()
            {
                Service = "Total",
                Total = billing.TotalAmount
            });
            billingDetails.Add(new BillingDetailsModel()
            {
                Service = "Amount Paid",
                Total = billing.AmountPaid
            });
            billingDetails.Add(new BillingDetailsModel()
            {
                Service = "Balance",
                Total = billing.Balance
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
                new RectangleF(left, y, right - left, 40),
                new StringFormat() { Alignment = StringAlignment.Center });
            y += 50;

            g.DrawString("Billing Statement", headerFont, Brushes.Black,
                new RectangleF(left, y, right - left, 30),
                new StringFormat() { Alignment = StringAlignment.Center });
            y += 40;

            
            g.DrawString("Generated: " + DateTime.Now.ToString("MM/dd/yyyy"), normalFont, Brushes.Gray, left, y);
            y += 25;

            
            g.DrawLine(Pens.Black, left, y, right, y);
            y += 20;

            
            g.DrawString("Patient Information", subHeaderFont, Brushes.Black, left, y);
            y += 30;

            g.DrawString($"{patient.FirstName} {patient.MiddleName} {patient.LastName}", pInfoFont, Brushes.Black, left, y);
            y += 20;
            g.DrawString($"Patient ID: {patient.PatientID}", pInfoFont, Brushes.Black, left, y);
            y += 20;
            g.DrawString($"Gender: {patient.Gender}", pInfoFont, Brushes.Black, left, y);
            y += 20;
            g.DrawString($"Age: {patient.Age} Years Old", pInfoFont, Brushes.Black, left, y);
            y += 30;

            
            Font tableHeaderFont = new Font("Arial", 12, FontStyle.Bold);
            int colService = left;
            int colQty = left + 320;
            int colPrice = left + 430;
            int colTotal = left + 540;

            g.DrawString("Service/Item", tableHeaderFont, Brushes.Black, colService, y);
            g.DrawString("Quantity/Days", tableHeaderFont, Brushes.Black, colQty, y);
            g.DrawString("Price", tableHeaderFont, Brushes.Black, colPrice, y);
            g.DrawString("Total", tableHeaderFont, Brushes.Black, colTotal, y);
            y += 25;

           
            List<int> admissionIDs = patientController.GetPatientAdmissionIDs(selectedPatientID);
            List<BillingDetailsModel> billingDetails = new List<BillingDetailsModel>();
            BillingModel billing = billingController.GenerateBilling(admissionIDs[0]);
            decimal GrandTotal = 0;

            foreach (int admissionID in admissionIDs)
            {
                List<BillingDetailsModel> details = billingController.GetBillingDetails(admissionID);
                billingDetails.AddRange(details);
            }

            foreach (var detail in billingDetails)
            {
                
                if (billingDetails.IndexOf(detail) % 2 == 1)
                    g.FillRectangle(Brushes.LightGray, left, y, right - left, 25);

                g.DrawString(detail.Service, normalFont, Brushes.Black, colService, y);
                g.DrawString(detail.Quantity.ToString(), normalFont, Brushes.Black, colQty + 50, y);
                g.DrawString($"{detail.Price:C2}", normalFont, Brushes.Black, colPrice + 30, y);
                g.DrawString($"{detail.Total:C2}", normalFont, Brushes.Black, colTotal + 30, y);

                y += 25;
                GrandTotal += detail.Total;
            }

                        g.DrawLine(Pens.Black, left, y + 5, right, y + 5);
            y += 20;

            
            Font totalsFont = new Font("Arial", 14, FontStyle.Bold);
            g.DrawString("Total Amount:", totalsFont, Brushes.Black, left, y);
            g.DrawString("Amount Paid:", totalsFont, Brushes.Black, left, y + 30);
            g.DrawString("Balance:", totalsFont, Brushes.Black, left, y + 60);

            g.DrawString($"{GrandTotal:C2}", totalsFont, Brushes.Black, left + 500, y);
            g.DrawString($"{billing.AmountPaid:C2}", totalsFont, Brushes.Black, left + 500, y + 30);
            g.DrawString($"{billing.Balance:C2}", totalsFont, Brushes.Black, left + 500, y + 60);
            y += 100;

            
            g.DrawLine(Pens.Gray, left, y, right, y);
            y += 15;
            g.DrawString("End of Report", fadedFont, Brushes.Gray, left, y);
        }
        private void btnPayment_Click(object sender, EventArgs e)
        {
            List<int> admissionIDs = patientController.GetPatientAdmissionIDs(selectedPatientID);
            FormMain.selectedPatientID = selectedPatientID;
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
                if (payment.DialogResult == DialogResult.OK)
                {
                    LoadBillingDetails();
                }
            }
            else
            {
                MessageBox.Show("Patient is currently Paid in Full.", "No Balance", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private void dataGridView1_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.ColumnIndex == 2)
            {
                if (Convert.ToInt32(e.Value) <= 0)
                {
                    e.Value = "";
                }
            }
            if (e.Value != null && (e.Value is decimal))
            {
                if (Convert.ToDecimal(e.Value) <= 0)
                {
                    e.Value = "0.00";
                }
                if (Convert.ToDecimal(e.Value) == 0 && !(e.RowIndex == dataGridView1.RowCount - 2 && e.ColumnIndex == dataGridView1.ColumnCount - 1))
                {
                    e.Value = "";
                    return;
                }
                e.Value = Convert.ToDecimal(e.Value).ToString("C2");
                e.FormattingApplied = true;
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
