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
using TextBox = System.Windows.Forms.TextBox;

namespace EventDriven.Project.UI.UserControlUI
{
    public partial class Admission : UserControl
    {
        public event EventHandler GoToPatientInfo;
        public event EventHandler GoToTreatment;
        private PatientController patientController;
        private StaffController staffController;
        public Admission()
        {
            InitializeComponent();
            patientController = new PatientController();
            staffController = new StaffController();
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
            txtFN.Text = patient.FirstName;
            txtMN.Text = patient.MiddleName;
            txtLN.Text = patient.LastName;
            dateAdmission.Value = patient.AdmissionDate;
            dateOfBirth.Value = patient.DateOfBirth;
            cbGender.Text = patient.Gender;
            txtGN.Text = patient.GuardianName;
            txtGCN.Text = patient.GuardianNo;
            LoadTextbox();
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
                    MiddleName = txtMN.Text,
                    LastName = txtLN.Text,
                    AdmissionDate = dateAdmission.Value.Date,
                    DateOfBirth = dateOfBirth.Value.Date,
                    Age = calculateAge(dateOfBirth.Value.Date),
                    Gender = cbGender.Text,
                    GuardianName = txtGN.Text,
                    GuardianNo = txtGCN.Text,
                };
                patientController.AddPatient(newPatient);
                AssignStaff();
                MessageBox.Show("Patient admitted successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                txtFN.Clear();
                txtMN.Clear();
                txtLN.Clear();
                dateAdmission.Value = DateTime.Now.Date;
                dateOfBirth.Value = DateTime.Now.Date;
                cbGender.SelectedIndex = -1;
                txtGN.Clear();
                txtGCN.Clear();
                cbRoomNo.SelectedIndex = -1;
                FormMain.assignedStaff.Clear();
            }
            else if (FormMain.AdmissionAction == "Edit")
            {
                PatientModel updatedPatient = new PatientModel
                {
                    PatientID = FormMain.selectedPatientID,
                    FirstName = txtFN.Text,
                    MiddleName = txtMN.Text,
                    LastName = txtLN.Text,
                    AdmissionDate = dateAdmission.Value.Date,
                    DateOfBirth = dateOfBirth.Value.Date,
                    Age = calculateAge(dateOfBirth.Value.Date),
                    Gender = cbGender.Text,
                    GuardianName = txtGN.Text,
                    GuardianNo = txtGCN.Text,
                };
                patientController.EditPatient(updatedPatient);
                AssignStaff();
                MessageBox.Show("Patient information updated successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                GoToPatientInfo?.Invoke(this, EventArgs.Empty);

                txtFN.Clear();
                txtMN.Clear();
                txtLN.Clear();
                dateAdmission.Value = DateTime.Now.Date;
                dateOfBirth.Value = DateTime.Now.Date;
                cbGender.SelectedIndex = -1;
                txtGN.Clear();
                txtGCN.Clear();
                cbRoomNo.SelectedIndex = -1;
                FormMain.assignedStaff.Clear();
            }
        }

        private void AssignStaff()
        {
            //FormMain.assignedStaff.Clear();
            
            int selectedPatientID = FormMain.AdmissionAction.Equals("Add") ? patientController.GetNextPatientID() : FormMain.selectedPatientID;
            if (FormMain.AdmissionAction.Equals("Edit"))
            {
                staffController.RemoveAssignedStaff(selectedPatientID);
            }
            for (int i = 0; i < FormMain.assignedStaff.Count; i++)
            {
                staffController.AddStaff(selectedPatientID, FormMain.assignedStaff[i].StaffID);
            }
        }

        private void btnViewDN_Click(object sender, EventArgs e)
        {
            FormAddMedicalRecord med = new FormAddMedicalRecord();
            med.ShowDialog();
        }

        private int calculateAge(DateTime dateOfBirth)
        {
            DateTime today = DateTime.Today;
            int age = today.Year - dateOfBirth.Year;
            if (dateOfBirth.Date > today.AddYears(-age)) age--;
            return age;
        }

        private void txtDoctor_Click(object sender, EventArgs e)
        {
            FormMain.staffRole = "Doctor";
            FormStaffAssignment doctorStaff = new FormStaffAssignment();
            doctorStaff.ShowDialog();
            if (doctorStaff.DialogResult == DialogResult.OK)
            {
                LoadTextbox();
            }
        }

        private void txtNurse_Click(object sender, EventArgs e)
        {
            FormMain.staffRole = "Nurse";
            FormStaffAssignment doctorStaff = new FormStaffAssignment();
            doctorStaff.ShowDialog();
            if (doctorStaff.DialogResult == DialogResult.OK)
            {
                LoadTextbox();
            }
        }

        private void LoadTextbox()
        {
            TextBox[] textBoxes = { txtDoctor, txtDoctor2, txtDoctor3, txtNurse, txtNurse2, txtNurse3 };
            TextBox[] doctorTextboxes = { txtDoctor, txtDoctor2, txtDoctor3 };
            TextBox[] nurseTextboxes = { txtNurse, txtNurse2, txtNurse3 };
            List<StaffModel> doctors = new List<StaffModel>();
            List<StaffModel> nurses = new List<StaffModel>();

            foreach (TextBox tb in textBoxes)
            {
                tb.Clear();
            }

            foreach (StaffModel staff in FormMain.assignedStaff)
            {
                if (staff.Role.Equals("Doctor"))
                {
                    doctors.Add(staff);
                }
                else
                {
                    nurses.Add(staff);
                }
            }

            for (int i = 0; i < doctors.Count; i++)
            {
                doctorTextboxes[i].Text = $"{doctors[i].FirstName} {doctors[i].LastName} ({doctors[i].DepartmentName})";
            }

            for (int i = 0; i < nurses.Count; i++)
            {
                nurseTextboxes[i].Text = $"{nurses[i].FirstName} {nurses[i].LastName} ({nurses[i].DepartmentName})";
            }
        }
    }
}
