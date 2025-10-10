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

namespace EventDriven.Project.UI.UserControlUI
{
    public partial class PatientInformation : UserControl
    {
        public event EventHandler GoToAdmissionAdd;
        public event EventHandler GoToAdmissionEdit;
        private PatientController patientController;
        public PatientInformation()
        {
            InitializeComponent();
            patientController = new PatientController();
            DGPatientRecord.DataSource = patientController.GetAllPatients();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            FormDashboard.AdmissionAction = "Add";
            GoToAdmissionAdd?.Invoke(this, EventArgs.Empty);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (DGPatientRecord.CurrentRow != null)
            {
                int selected = Convert.ToInt32(DGPatientRecord.CurrentRow.Cells["PatientID"].Value);
                FormDashboard.selectedPatientID = selected;
            }
            FormDashboard.AdmissionAction = "Edit";
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
                var confirmResult = MessageBox.Show("Are you sure to delete the selected patient(s)?",
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
    }
}
