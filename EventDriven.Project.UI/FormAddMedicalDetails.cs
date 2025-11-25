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

namespace EventDriven.Project.UI
{
    public partial class FormAddMedicalDetails : Form
    {
        MedicalRecordController medicalRecordController;
        int selectedPatientID;
        public FormAddMedicalDetails()
        {
            InitializeComponent();
            medicalRecordController = new MedicalRecordController();
            selectedPatientID = FormMain.selectedPatientID;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            int nextRecordID = medicalRecordController.GetNextMedicalRecordID();

            MedicalRecordModel medicalRecord = new MedicalRecordModel();
            medicalRecord.PatientID = selectedPatientID;
            medicalRecord.Diagnosis = txtDiagnosis.Text;
            medicalRecord.Notes = txtNotes.Text;

            TreatmentModel treatment = new TreatmentModel();
            treatment.RecordID = nextRecordID;
            treatment.TreatmentType = txtTreatment.Text;
            treatment.Price = Convert.ToDecimal(txtTreatmentPrice.Text);

            if (!string.IsNullOrEmpty(treatment.TreatmentType) && treatment.Price <= 0)
            {
                MessageBox.Show("Please enter a valid price for the treatment.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            MedicationModel medication = new MedicationModel();
            medication.RecordID = nextRecordID;
            medication.MedicationName = txtMedication.Text;
            medication.FrequencyCount = Convert.ToInt32(numMedFrequencyCount.Value);
            medication.FrequencyValue = Convert.ToInt32(numMedFrequencyValue.Value);
            medication.FrequencyType = cbFrequencyType.SelectedItem.ToString();
            medication.Duration = Convert.ToInt32(numMedDuration.Value);
            medication.Price = Convert.ToDecimal(txtMedPrice.Text);

            if (!string.IsNullOrEmpty(medication.MedicationName))
            {
                if ((medication.FrequencyCount <= 0 || medication.FrequencyValue <= 0 || medication.Duration <= 0))
                {
                    MessageBox.Show("Please enter valid frequency and duration values for the medication.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if ((medication.Duration * 24) / medication.FrequencyValue * medication.FrequencyCount <= 0)
                {
                    MessageBox.Show("The calculated total doses for the medication must be greater than zero.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (medication.Price <= 0)
                {
                    MessageBox.Show("Please enter a valid price for the medication.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }

            medicalRecordController.AddMedicalRecord(medicalRecord);
            medicalRecordController.AddTreatment(treatment);
            medicalRecordController.AddMedication(medication);

            MessageBox.Show("Medical details added successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Close();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
