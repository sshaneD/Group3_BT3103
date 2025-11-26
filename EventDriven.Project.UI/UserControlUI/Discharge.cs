using EventDriven.Project.Businesslogic.Controller;
using EventDriven.Project.Model;
using System.Drawing.Printing;

namespace EventDriven.Project.UI.UserControlUI
{
    public partial class Discharge : UserControl
    {
        PatientController patientController;
        RoomController roomController;
        MedicalRecordController medicalRecordController;
        BillingController billingController;
        StaffController staffController;
        AdmissionCardModel admissionCardModel;
        int selectedPatientID;
        int selectedAdmissionID;
        
        public Discharge()
        {
            InitializeComponent();
            patientController = new PatientController();
            roomController = new RoomController();
            medicalRecordController = new MedicalRecordController();
            billingController = new BillingController();
            StaffController staffController = new StaffController(); 
            selectedPatientID = FormMain.selectedPatientID;

            

            AutoCompleteStringCollection names = new AutoCompleteStringCollection();
            List<PatientModel> patients = patientController.GetAllPatients();
            foreach (PatientModel patient in patients)
            {
                names.Add($"{patient.FirstName} {patient.MiddleName} {patient.LastName}");
            }
            txtSearch.AutoCompleteCustomSource = names;

            btnDischarge.Visible = false;
            btnPrint.Visible = false;
            if (FormMain.selectedPatientID != 0)
                LoadData();
        }
        private void LoadData()
        {
            btnDischarge.Visible = true;
            btnPrint.Visible = false;
            PatientModel patient = patientController.GetPatientById(selectedPatientID);
            lblPatientName.Text = $"{patient.FirstName} {patient.MiddleName} {patient.LastName}";
            lblPatientID.Text = patient.PatientID.ToString();
            if (patient.Status.Equals("Discharged"))
            {
                btnDischarge.Visible = false;
                btnPrint.Visible = true;
            }

            CurrentRoomModel room = roomController.GetCurrentRoom(selectedPatientID);
            lblRoomName.Text = room.RoomType;

            List<int> admissionIDs = patientController.GetPatientAdmissionIDs(selectedPatientID);
            List<AdmissionCardModel> admissions = patientController.GetAllAdmissionCards();
            AdmissionCardModel selectedAdmission = new AdmissionCardModel();

            foreach (AdmissionCardModel admission in admissions)
            {
                if (admission.PatientID == selectedPatientID)
                {
                    selectedAdmission = admission;
                    break;
                }
            }

            selectedAdmissionID = selectedAdmission.AdmissionID;
            lblAdmissionDate.Text = selectedAdmission.AdmissionDate.ToShortDateString();

            List<MedicalRecordModel> medicalRecords = medicalRecordController.GetPatientMedicalRecords(selectedPatientID);
            foreach (MedicalRecordModel medicalRecord in medicalRecords)
            {
                MedicationModel medication = medicalRecordController.GetMedicationByRecordID(medicalRecord.RecordID);
                TreatmentModel treatment = medicalRecordController.GetTreatmentByRecordID(medicalRecord.RecordID);
                if (!string.IsNullOrEmpty(medicalRecord.Diagnosis))
                    txtDiagnosis.AppendText($"{medicalRecord.Diagnosis} {Environment.NewLine} {Environment.NewLine}");
                else
                    txtDiagnosis.AppendText($"N/A {Environment.NewLine} {Environment.NewLine}");

                if (!string.IsNullOrEmpty(treatment.TreatmentType))
                    txtTreatment.AppendText($"{treatment.TreatmentType} {Environment.NewLine} {Environment.NewLine}");
                else
                    txtTreatment.AppendText($"N/A {Environment.NewLine} {Environment.NewLine}");

                if (!string.IsNullOrEmpty(medication.MedicationName))
                    txtMedication.AppendText($"{medication.MedicationName} {Environment.NewLine}");
                else
                    txtMedication.AppendText($"N/A {Environment.NewLine} {Environment.NewLine}");

                if (medication.FrequencyCount != 0)
                    txtFrequency.AppendText($"{medication.FrequencyCount} Every {medication.FrequencyValue} Hours {Environment.NewLine}");
                else
                    txtFrequency.AppendText($"N/A {Environment.NewLine} {Environment.NewLine}");

                if (medication.Duration != 0)
                    txtDuration.AppendText($"{medication.Duration} Days {Environment.NewLine}");
                else
                    txtDuration.AppendText($"N/A {Environment.NewLine} {Environment.NewLine}");

                if (!string.IsNullOrEmpty(medicalRecord.Notes))
                    txtNotes.AppendText($"{medicalRecord.Notes} {Environment.NewLine} {Environment.NewLine}");
                else
                    txtNotes.AppendText($"N/A {Environment.NewLine} {Environment.NewLine}");
            }

            BillingModel billing = billingController.GenerateBilling(selectedAdmission.AdmissionID);
            txtTotal.Text = billing.TotalAmount.ToString();
            txtBalance.Text = billing.Balance < 0 ? "0.00" : billing.Balance.ToString();
            string statusText = string.Empty;
            if (billing.Balance > (billing.TotalAmount * Convert.ToDecimal(0.5)))
                statusText = "NOT PAID";
            else if (billing.Balance <= (billing.TotalAmount * Convert.ToDecimal(0.5)) && billing.Balance > 0)
                statusText = "PARTIALLY PAID";
            else if (billing.Balance <= 0)
                statusText = "PAID";
            lblStatus.Text = statusText;

            if (lblStatus.Text.Equals("PARTIALLY PAID") || (lblStatus.Text.Equals("PAID") && patientController.GetValidIDByPatientID(selectedPatientID) != null))
                btnID.Visible = true;
            else
                btnID.Visible = false;
        }
        private void removeFocus(object sender, EventArgs e)
        {
            ActiveControl = null;
        }
        private void btnDischarge_Click(object sender, EventArgs e)
        {
            if (lblStatus.Text.Equals("NOT PAID"))
            {
                MessageBox.Show("This patient has not yet paid their balance.", "Cannot Discharge", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else if (lblStatus.Text.Equals("PARTIALLY PAID") && patientController.GetValidIDByPatientID(FormMain.selectedPatientID) == null)
            {
                MessageBox.Show("Valid ID is required before discharge", "", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return;
            }
            DialogResult res = MessageBox.Show("Are you sure you want to discharge this patient?", "Confirm Discharge", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (res == DialogResult.Yes)
            {
                patientController.DischargePatient(selectedPatientID, selectedAdmissionID);
                ClearData();
                MessageBox.Show("Patient Discharged Successfully!", "Discharge Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Discharge Cancelled", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private void btnSearch_Click(object sender, EventArgs e)
        {
            List<PatientModel> patients = patientController.SearchPatient(txtSearch.Text.Trim());
            selectedPatientID = patients[0].PatientID;
            FormMain.selectedPatientID = selectedPatientID;
            PatientModel patient = patientController.GetPatientById(selectedPatientID);
            LoadData();
            txtSearch.Clear();
        }
        private void btnID_Click(object sender, EventArgs e)
        {
            FormValidID formValidID = new FormValidID();
            formValidID.ShowDialog();
            if (formValidID.DialogResult == DialogResult.OK)
            {
                btnID.Visible = false;
            }
        }
        private void ClearData()
        {
            lblAdmissionDate.Text = string.Empty;
            lblPatientID.Text = string.Empty;
            lblPatientName.Text = string.Empty;
            lblRoomName.Text = string.Empty;
            lblStatus.Text = string.Empty;

            txtBalance.Clear();
            txtDiagnosis.Clear();
            txtDuration.Clear();
            txtFrequency.Clear();
            txtMedication.Clear();
            txtNotes.Clear();
            txtSearch.Clear();
            txtTotal.Clear();
            txtTreatment.Clear();
        }


        private void printDocument1_PrintPage(object sender, PrintPageEventArgs e)
        {
            PatientModel patient = patientController.GetPatientById(selectedPatientID);
            List<AdmissionCardModel> admissions = patientController.GetAllAdmissionCards();
            AdmissionCardModel admission = admissions.FirstOrDefault(a => a.AdmissionID == selectedAdmissionID);
            List<MedicalRecordModel> medicalRecords = medicalRecordController.GetPatientMedicalRecords(selectedPatientID);

            Graphics g = e.Graphics;

            // Fonts (switched to Calibri for better print readability)
            Font titleFont = new Font("Calibri", 24, FontStyle.Bold);
            Font headerFont = new Font("Calibri", 16, FontStyle.Bold);
            Font sectionFont = new Font("Calibri", 14, FontStyle.Bold);
            Font boldFont = new Font("Calibri", 12, FontStyle.Bold);
            Font normalFont = new Font("Calibri", 11);
            Font fadedFont = new Font("Calibri", 10, FontStyle.Italic);

            // Page dimensions and margins
            int pageWidth = e.PageBounds.Width;
            int pageHeight = e.PageBounds.Height;
            int leftMargin = 80;
            int rightMargin = pageWidth - 80;
            int topMargin = 60;
            int bottomMargin = pageHeight - 100; // Leave space for footer
            int y = topMargin;
            int lineSpacing = 22; // Increased for better readability
            int boxPadding = 12;
            int sectionSpacing = 30; // Space between sections

            // =============================
            // HEADER
            // =============================
            // Simple logo placeholder (text-based)
            g.DrawString("🏥", new Font("Arial", 28), Brushes.DarkBlue, leftMargin, y);
            g.DrawString("APEX MEDICAL CENTER", titleFont, Brushes.DarkBlue,
                new RectangleF(leftMargin + 40, y, rightMargin - leftMargin - 40, 40),
                new StringFormat() { Alignment = StringAlignment.Center });
            y += 50;

            g.DrawString("Discharge Summary", headerFont, Brushes.DarkBlue,
                new RectangleF(leftMargin, y, rightMargin - leftMargin, 30),
                new StringFormat() { Alignment = StringAlignment.Center });
            y += 40;

            g.DrawString("Generated: " + DateTime.Now.ToString("MMMM dd, yyyy"), fadedFont, Brushes.Gray, rightMargin - 200, y);
            y += 30;

            g.DrawLine(Pens.DarkBlue, leftMargin, y, rightMargin, y);
            y += sectionSpacing;

            // =============================
            // PATIENT INFORMATION BOX
            // =============================
            int patientBoxHeight = 160; // Slightly taller for better spacing
            Rectangle patientRect = new Rectangle(leftMargin - 10, y - 10, (rightMargin - leftMargin) + 20, patientBoxHeight);
            g.FillRectangle(new SolidBrush(Color.FromArgb(245, 245, 245)), patientRect); // Very light gray
            g.DrawRectangle(Pens.Black, patientRect);
            g.DrawString("PATIENT INFORMATION", sectionFont, Brushes.Black, leftMargin, y - 5);
            y += boxPadding + 5;

            g.DrawString($"Name: {patient.FirstName} {patient.MiddleName} {patient.LastName}", boldFont, Brushes.Black, leftMargin, y);
            y += lineSpacing;
            g.DrawString($"Patient ID: {patient.PatientID}", normalFont, Brushes.Black, leftMargin, y);
            y += lineSpacing;
            g.DrawString($"Age: {patient.Age} Years Old", normalFont, Brushes.Black, leftMargin, y);
            y += lineSpacing;
            g.DrawString($"Gender: {patient.Gender}", normalFont, Brushes.Black, leftMargin, y);
            y += lineSpacing;
            g.DrawString($"Admission Date: {admission?.AdmissionDate:MMMM dd, yyyy}", normalFont, Brushes.Black, leftMargin, y);
            y += lineSpacing;
            g.DrawString($"Discharge Date: {(admission?.DischargeDate.HasValue == true ? admission.DischargeDate.Value.ToString("MMMM dd, yyyy") : "Not Applicable")}", normalFont, Brushes.Black, leftMargin, y);
            y += lineSpacing + sectionSpacing;

            // =============================
            // DIAGNOSES BOX
            // =============================
            g.DrawString("DIAGNOSES", sectionFont, Brushes.Black, leftMargin, y);
            y += 30;

            int diagCount = Math.Max(1, medicalRecords.Count);
            int diagBoxHeight = diagCount * 22 + boxPadding * 2;
            Rectangle diagRect = new Rectangle(leftMargin - 10, y, (rightMargin - leftMargin) + 20, diagBoxHeight);
            g.FillRectangle(new SolidBrush(Color.FromArgb(240, 248, 255)), diagRect); // Very light blue
            g.DrawRectangle(Pens.Black, diagRect);
            int diagStartY = y + boxPadding;

            if (medicalRecords.Any())
            {
                foreach (var r in medicalRecords)
                {
                    g.DrawString("• " + r.Diagnosis, normalFont, Brushes.Black, leftMargin + 10, diagStartY);
                    diagStartY += 22;
                }
            }
            else
            {
                g.DrawString("• No diagnoses recorded.", normalFont, Brushes.Gray, leftMargin + 10, diagStartY);
            }
            y = diagStartY + sectionSpacing;

            // =============================
            // TREATMENTS / PROCEDURES
            // =============================
            g.DrawString("TREATMENTS / PROCEDURES", sectionFont, Brushes.Black, leftMargin, y);
            y += 30;

            List<TreatmentModel> treatments = new List<TreatmentModel>();
            foreach (var rec in medicalRecords)
            {
                var t = medicalRecordController.GetTreatmentByRecordID(rec.RecordID);
                if (t != null) treatments.Add(t);
            }

            int treatCount = Math.Max(1, treatments.Count);
            int treatBoxHeight = treatCount * 22 + boxPadding * 2;
            Rectangle treatRect = new Rectangle(leftMargin - 10, y, (rightMargin - leftMargin) + 20, treatBoxHeight);
            g.FillRectangle(new SolidBrush(Color.FromArgb(245, 255, 245)), treatRect); // Very light green
            g.DrawRectangle(Pens.Black, treatRect);

            int treatY = y + boxPadding;
            if (treatments.Any())
            {
                foreach (var t in treatments)
                {
                    g.DrawString("• " + t.TreatmentType, normalFont, Brushes.Black, leftMargin + 10, treatY);
                    g.DrawString($"₱{t.Price:N2}", normalFont, Brushes.Black, rightMargin - 100, treatY); // Right-aligned
                    treatY += 22;
                }
            }
            else
            {
                g.DrawString("• No treatments recorded.", normalFont, Brushes.Gray, leftMargin + 10, treatY);
            }
            y = treatY + sectionSpacing;

            // =============================
            // MEDICATIONS GIVEN
            // =============================
            g.DrawString("MEDICATIONS GIVEN", sectionFont, Brushes.Black, leftMargin, y);
            y += 30;

            List<MedicationModel> medications = new List<MedicationModel>();
            foreach (var rec in medicalRecords)
            {
                var m = medicalRecordController.GetMedicationByRecordID(rec.RecordID);
                if (m != null) medications.Add(m);
            }

            int medCount = Math.Max(1, medications.Count);
            int medBoxHeight = medCount * 22 + boxPadding * 2;
            Rectangle medRect = new Rectangle(leftMargin - 10, y, (rightMargin - leftMargin) + 20, medBoxHeight);
            g.FillRectangle(new SolidBrush(Color.FromArgb(250, 245, 255)), medRect); // Very light lavender
            g.DrawRectangle(Pens.Black, medRect);

            int medY = y + boxPadding;
            if (medications.Any())
            {
                foreach (var m in medications)
                {
                    string medLine = $"• {m.MedicationName} – {m.FrequencyCount} Every {m.FrequencyValue} {m.FrequencyType}";
                    g.DrawString(medLine, normalFont, Brushes.Black, leftMargin + 10, medY);
                    g.DrawString($"₱{m.Price:N2}", normalFont, Brushes.Black, rightMargin - 100, medY); // Right-aligned
                    medY += 22;
                }
            }
            else
            {
                g.DrawString("• No medications recorded.", normalFont, Brushes.Gray, leftMargin + 10, medY);
            }
            y = medY + sectionSpacing;

            // =============================
            // SIGNATURE LINE
            // =============================
            if (y + 60 > bottomMargin)
            {
                e.HasMorePages = true;
                return;
            }
            g.DrawString("Physician Signature: _______________________________", normalFont, Brushes.Black, leftMargin, y);
            y += 30;
            g.DrawString("Date: ___________________", normalFont, Brushes.Black, leftMargin, y);
            y += sectionSpacing;

            // =============================
            // FOOTER
            // =============================
            g.DrawLine(Pens.DarkBlue, leftMargin, bottomMargin - 40, rightMargin, bottomMargin - 40);
            g.DrawString("Apex Medical Center | 123 Health St, City, State | Phone: (123) 456-7890 | www.apexmedical.com", fadedFont, Brushes.Gray,
                new RectangleF(leftMargin, bottomMargin - 30, rightMargin - leftMargin, 20),
                new StringFormat() { Alignment = StringAlignment.Center });

            // Check for page overflow
            e.HasMorePages = y > bottomMargin;
        }





        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            printPreviewDialog1.ShowDialog();
            
        }
    }
}