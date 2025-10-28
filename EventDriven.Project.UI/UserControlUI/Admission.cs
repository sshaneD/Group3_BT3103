using EventDriven.Project.Businesslogic.Controller;
using EventDriven.Project.Model;

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
            txtFN.Text = patient.FirstName;
            txtMN.Text = patient.MiddleName;
            txtLN.Text = patient.LastName;
            dateAdmission.Value = patient.AdmissionDate;
            dateOfBirth.Value = patient.DateOfBirth;
            cbGender.Text = patient.Gender;
            txtGN.Text = patient.GuardianName;
            txtGCN.Text = patient.GuardianNo;
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
            FormAddMedicalDetails med = new FormAddMedicalDetails();
            med.ShowDialog();
        }

        private int calculateAge(DateTime dateOfBirth)
        {
            DateTime today = DateTime.Today;
            int age = today.Year - dateOfBirth.Year;
            if (dateOfBirth.Date > today.AddYears(-age)) age--;
            return age;
        }
    }
}
