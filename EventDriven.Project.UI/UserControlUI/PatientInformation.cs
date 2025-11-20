using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EventDriven.Project.Businesslogic.Controller;
using EventDriven.Project.Model;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace EventDriven.Project.UI.UserControlUI
{
    public partial class PatientInformation : UserControl
    {
        public event EventHandler GoToAdmissionAdd;
        public event EventHandler GoToAdmissionEdit;
        public event EventHandler GoToMedicalRecord;
        public event EventHandler GoToBOS;
        public event EventHandler GoToDischarge;
        private PatientController patientController;
        private StaffController staffController;
        private RoomController roomController;
        public PatientInformation()
        {
            InitializeComponent();
            patientController = new PatientController();
            staffController = new StaffController();
            roomController = new RoomController();
            DGPatientRecord.DataSource = patientController.GetAllPatients();
            CheckLoggedUser();
        }

        private void CheckLoggedUser()
        {
            switch (FormLogin.Role)
            {
                case "admin":
                    break;
                case "receptionist":
                    btnBOS.Visible = false;
                    break;
                case "cashier":
                    btnAdd.Visible = false;
                    btnEdit.Visible = false;
                    btnDelete.Visible = false;
                    btnMedRecord.Visible = false;
                    btnDischarge.Visible = false;
                    break;
            }
        }
        private void button7_Click(object sender, EventArgs e)
        {
            FormMain.AdmissionAction = "Add";
            GoToAdmissionAdd?.Invoke(this, EventArgs.Empty);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (DGPatientRecord.CurrentRow != null)
            {
                int selected = Convert.ToInt32(DGPatientRecord.CurrentRow.Cells["PatientID"].Value);
                FormMain.selectedPatientID = selected;
                List<int> staffIDs = staffController.GetAssignedStaff(selected);
                FormMain.assignedStaff.Clear();
                foreach (int staffID in staffIDs)
                {
                    FormMain.assignedStaff.Add(staffController.GetStaffByID(staffID));
                }
            }
            FormMain.AdmissionAction = "Edit";
            GoToAdmissionEdit?.Invoke(this, EventArgs.Empty);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            List<int> selectedPatients = new List<int>();
            if (DGPatientRecord.CurrentRow != null)
            {
                foreach (DataGridViewRow row in DGPatientRecord.SelectedRows)
                {
                    int selected = Convert.ToInt32(row.Cells["PatientID"].Value);
                    selectedPatients.Add(selected);
                }
                DialogResult confirmResult = MessageBox.Show("Are you sure you want to delete the selected patient(s)?",
                                     "Confirm Delete!!",
                                     MessageBoxButtons.YesNo);
                if (confirmResult == DialogResult.Yes)
                {
                    for (int i = 0; i < selectedPatients.Count; i++)
                    {
                        staffController.RemoveAssignedStaff(selectedPatients[i]);
                        roomController.DeleteAssignedRoom(selectedPatients[i]);
                        patientController.DeletePatient(selectedPatients[i]);
                    }
                    MessageBox.Show("Patient(s) deleted successfully.");
                    DGPatientRecord.DataSource = patientController.GetAllPatients();
                }
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (txtSearch.Text == String.Empty)
            {
                MessageBox.Show("Please input a Name or Patient ID", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                DGPatientRecord.DataSource = patientController.GetAllPatients();
            }
            try
            {
                List<PatientModel> patients = patientController.SearchPatient(txtSearch.Text);
                if (patients == null || patients.Count == 0)
                {
                    MessageBox.Show("Patient not found!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    DGPatientRecord.DataSource = patientController.GetAllPatients();
                    txtSearch.Text = String.Empty;
                    return;
                }
                DGPatientRecord.DataSource = patients;

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error in Search: " + ex.Message);

            }

        }



        private void txtSearch_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                btnSearch.PerformClick();
            }
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnBOS_Click(object sender, EventArgs e)
        {
            if (DGPatientRecord.CurrentRow != null)
            {
                int selected = Convert.ToInt32(DGPatientRecord.SelectedRows[0].Cells[0].Value);
                FormMain.selectedPatientID = selected;
                GoToBOS?.Invoke(this, EventArgs.Empty);
            }
            else
            {
                MessageBox.Show("Please select a patient", "No Patient Selected", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnMedRecord_Click(object sender, EventArgs e)
        {
            if (DGPatientRecord.CurrentRow != null)
            {
                int selected = Convert.ToInt32(DGPatientRecord.SelectedRows[0].Cells[0].Value);
                FormMain.selectedPatientID = selected;
                GoToMedicalRecord?.Invoke(this, EventArgs.Empty);
            }
            else
            {
                MessageBox.Show("Please select a patient", "No Patient Selected", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnDischarge_Click(object sender, EventArgs e)
        {
            if (DGPatientRecord.CurrentRow != null)
            {
                int selected = Convert.ToInt32(DGPatientRecord.SelectedRows[0].Cells[0].Value);
                FormMain.selectedPatientID = selected;
                PatientModel patient = patientController.GetPatientById(selected);
                if (patient.Status.Equals("Discharged"))
                {
                    MessageBox.Show("This patient is already discharged", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                GoToDischarge?.Invoke(this, EventArgs.Empty);
            }
            else
            {
                MessageBox.Show("Please select a patient", "No Patient Selected", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}

