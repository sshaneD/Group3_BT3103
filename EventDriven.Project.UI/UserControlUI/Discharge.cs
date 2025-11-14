using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EventDriven.Project.Businesslogic.Controller;
using EventDriven.Project.Model;

namespace EventDriven.Project.UI.UserControlUI
{
    public partial class Discharge : UserControl
    {
        PatientController patientController;
        RoomController roomController;
        MedicalRecordController medicalRecordController;
        BillingController billingController;
        int selectedPatientID;
        int selectedAdmissionID;
        public Discharge()
        {
            InitializeComponent();
            patientController = new PatientController();
            roomController = new RoomController();
            medicalRecordController = new MedicalRecordController();
            billingController = new BillingController();
            selectedPatientID = FormMain.selectedPatientID;

            LoadData();
        }
        private void LoadData()
        {
            PatientModel patient = patientController.GetPatientById(selectedPatientID);
            lblPatientName.Text = $"{patient.FirstName} {patient.MiddleName} {patient.LastName}";
            lblPatientID.Text = patient.PatientID.ToString();

            CurrentRoomModel room = roomController.GetCurrentRoom(selectedPatientID);
            lblRoomName.Text = room.RoomType;

            List<int> admissionIDs = patientController.GetPatientAdmissionIDs(selectedPatientID);
            List<AdmissionCardModel> admissions = patientController.GetAllAdmissionCards();
            AdmissionCardModel selectedAdmission = new AdmissionCardModel();

            foreach (AdmissionCardModel admission in admissions)
            {
                if (admission.DischargeDate != null || admission.DischargeDate < DateTime.Now)
                {
                    continue;
                }
                if (admission.PatientID == selectedPatientID)
                {
                    selectedAdmission = admission;
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
                    txtMedication.AppendText($"{medication.MedicationName} {Environment.NewLine} {Environment.NewLine}");
                else
                    txtMedication.AppendText($"N/A {Environment.NewLine} {Environment.NewLine}");

                if (medication.FrequencyCount != 0)
                    txtFrequency.AppendText($"{medication.FrequencyCount} Every {medication.FrequencyValue} Hours {Environment.NewLine} {Environment.NewLine}");
                else
                    txtFrequency.AppendText($"N/A {Environment.NewLine} {Environment.NewLine}");

                if (medication.Duration != 0)
                    txtDuration.AppendText($"{medication.Duration} Days {Environment.NewLine} {Environment.NewLine}");
                else
                    txtDuration.AppendText($"N/A {Environment.NewLine} {Environment.NewLine}");

                if (!string.IsNullOrEmpty(medicalRecord.Notes))
                    txtNotes.AppendText($"{medicalRecord.Notes} {Environment.NewLine} {Environment.NewLine}");
                else
                    txtNotes.AppendText($"N/A {Environment.NewLine} {Environment.NewLine}");
            }

            BillingModel billing = billingController.GenerateBilling(selectedAdmission.AdmissionID);
            txtTotal.Text = billing.TotalAmount.ToString();
            txtBalance.Text = billing.Balance.ToString();
            string statusText = string.Empty;
            if (billing.Balance == billing.TotalAmount)
                statusText = "NOT PAID";
            else if (billing.Balance > 0 && billing.Balance < billing.TotalAmount)
                statusText = "PARTIALLY PAID";
            else if (billing.Balance <= 0)
                statusText = "PAID";
            lblStatus.Text = statusText;
        }

        private void btnDischarge_Click(object sender, EventArgs e)
        {
            if (lblStatus.Text.Equals("NOT PAID"))
            {
                MessageBox.Show("This patient has not yet paid their balance.", "Cannot Discharge", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            DialogResult res = MessageBox.Show("Are you sure you want to discharge this patient?", "Confirm Discharge", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (res  == DialogResult.Yes)
            {
                patientController.DischargePatient(selectedPatientID, selectedAdmissionID);
                MessageBox.Show("Patient Discharged Successfully!", "Discharge Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Discharge Cancelled", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
