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

        private PatientController patientController;
        public PatientInformation()
        {
            InitializeComponent();
            patientController = new PatientController();
            DGPatientRecord.DataSource = patientController.GetAllPatients();
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

        private void btnMedRecord_Click(object sender, EventArgs e)
        {
            GoToMedicalRecord?.Invoke(this, EventArgs.Empty);
        }
    }
}

