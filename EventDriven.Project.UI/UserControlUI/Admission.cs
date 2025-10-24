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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace EventDriven.Project.UI.UserControlUI
{
    public partial class Admission : UserControl
    {
        public event EventHandler GoToPatientInfo;
        public event EventHandler GoToTreatment;
        private PatientController patientController;
        public Admission()
        {
            InitializeComponent();
            patientController = new PatientController();
            CheckAction();
        }

        private void CheckAction()
        {
            if (FormMain.AdmissionAction == "Add")
            {
                btnSubmit.Text = "Admit";
                btnCancel.Visible = false;
                lblTitle.Text = "Admission Form";
            }
            else if (FormMain.AdmissionAction == "Edit")
            {
                LoadData();
                btnSubmit.Text = "Save";
                btnCancel.Visible = true;
                lblTitle.Text = "Edit Patient Information";
            }
        }

        private void LoadData()
        {
            PatientModel patient = patientController.GetPatientById(FormMain.selectedPatientID);
            lblID.Text = patient.PatientID.ToString();
            txtFN.Text = patient.FirstName;
            txtLN.Text = patient.LastName;
            txtAge.Text = patient.Age.ToString();
            cbGender.Text = patient.Gender;
            txtGN.Text = patient.GuardianName;
            txtGCN.Text = patient.GuardianNo;
            cbRoomNo.Text = patient.RoomNo.ToString();
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
            if (FormMain.AdmissionAction == "Add")
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
                };
                patientController.AddPatient(newPatient);
                MessageBox.Show("Patient admitted successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                txtFN.Clear();
                txtLN.Clear();
                txtAge.Clear();
                cbGender.SelectedIndex = -1;
                txtGN.Clear();
                txtGCN.Clear();
                cbRoomNo.SelectedIndex = -1;
            }
            else if (FormMain.AdmissionAction == "Edit")
            {
                PatientModel updatedPatient = new PatientModel
                {
                    PatientID = FormMain.selectedPatientID,
                    FirstName = txtFN.Text,
                    LastName = txtLN.Text,
                    Age = int.Parse(txtAge.Text),
                    Gender = cbGender.Text,
                    GuardianName = txtGN.Text,
                    GuardianNo = txtGCN.Text,
                    RoomNo = int.Parse(cbRoomNo.Text),
                };
                patientController.EditPatient(updatedPatient);
                MessageBox.Show("Patient information updated successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                GoToPatientInfo?.Invoke(this, EventArgs.Empty);

                txtFN.Clear();
                txtLN.Clear();
                txtAge.Clear();
                cbGender.SelectedIndex = -1;
                txtGN.Clear();
                txtGCN.Clear();
                cbRoomNo.SelectedIndex = -1;
            }
        }

        private void txtDoctor_TextChanged(object sender, EventArgs e)
        {
            FormStaffAssignment doctorStaff = new FormStaffAssignment();
            doctorStaff.ShowDialog();
        }

        private void txtNurses_TextChanged(object sender, EventArgs e)
        {
            FormStaffAssignment nurseStaff = new FormStaffAssignment();
            nurseStaff.ShowDialog();

        }

        private void btnViewDN_Click(object sender, EventArgs e)
        {
            FormAddMedicalRecord med = new FormAddMedicalRecord();
            med.ShowDialog();
        }
    }
}
