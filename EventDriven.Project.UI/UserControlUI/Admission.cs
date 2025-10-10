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
    public partial class Admission : UserControl
    {
        public event EventHandler GoToPatientInfo;
        private PatientController patientController;
        public Admission()
        {
            InitializeComponent();
            patientController = new PatientController();
            CheckAction();
        }

        private void CheckAction()
        {
            if (FormDashboard.AdmissionAction == "Add")
            {
                btnSubmit.Text = "Admit";
                btnCancel.Visible = false;
                lblTitle.Text = "Admission Form";
            }
            else if (FormDashboard.AdmissionAction == "Edit")
            {
                LoadData();
                btnSubmit.Text = "Save";
                btnCancel.Visible = true;
                lblTitle.Text = "Edit Patient Information";
            }
        }

        private void LoadData()
        {
            PatientModel patient = patientController.GetPatientById(FormDashboard.selectedPatientID);
            lblID.Text = patient.PatientID.ToString();
            txtFN.Text = patient.FirstName;
            txtLN.Text = patient.LastName;
            txtAge.Text = patient.Age.ToString();
            cbGender.Text = patient.Gender;
            txtGN.Text = patient.GuardianName;
            txtGCN.Text = patient.GuardianNo;
            cbRoomNo.Text = patient.RoomNo.ToString();
            txtDiagnosis.Text = patient.Diagnosis;
        }

        private void btnADCancel_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Changes are not saved.", "Cancelled", MessageBoxButtons.OK, MessageBoxIcon.Information);
            GoToPatientInfo?.Invoke(this, EventArgs.Empty);
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if (FormDashboard.AdmissionAction == "Add")
            {
                PatientModel newPatient = new PatientModel
                {
                    FirstName = txtFN.Text,
                    LastName = txtLN.Text,
                    Age = int.Parse(txtAge.Text),
                    Gender = cbGender.Text,
                    GuardianName = txtGN.Text,
                    GuardianNo = txtGCN.Text,
                    RoomNo = int.Parse(cbRoomNo.Text),
                    Diagnosis = txtDiagnosis.Text
                };
                patientController.AddPatient(newPatient);
                MessageBox.Show("Patient admitted successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (FormDashboard.AdmissionAction == "Edit")
            {
                PatientModel updatedPatient = new PatientModel
                {
                    PatientID = FormDashboard.selectedPatientID,
                    FirstName = txtFN.Text,
                    LastName = txtLN.Text,
                    Age = int.Parse(txtAge.Text),
                    Gender = cbGender.Text,
                    GuardianName = txtGN.Text,
                    GuardianNo = txtGCN.Text,
                    RoomNo = int.Parse(cbRoomNo.Text),
                    Diagnosis = txtDiagnosis.Text
                };
                patientController.EditPatient(updatedPatient);
                MessageBox.Show("Patient information updated successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                GoToPatientInfo?.Invoke(this, EventArgs.Empty);
            }
        }
    }
}
