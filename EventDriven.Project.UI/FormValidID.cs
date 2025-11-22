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
    public partial class FormValidID : Form
    {
        PatientController patientController;
        public FormValidID()
        {
            InitializeComponent();
            patientController = new PatientController();
        }
        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            PatientModel patient = patientController.GetPatientById(FormMain.selectedPatientID);
            string IDType = cbType.Text;
            string Name = txtName.Text;
            string IDNumber = txtIDNumber.Text;

            if (string.IsNullOrEmpty(IDType) || string.IsNullOrEmpty(Name) || string.IsNullOrEmpty(IDNumber))
            {
                MessageBox.Show("Please fill in all fields.", "Incomplete Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (Name != (patient.FirstName + " " + patient.MiddleName + " " + patient.LastName)
                || Name != patient.GuardianName)
            {
                MessageBox.Show("This ID does not match the patient's or guardian's name", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            FormMain.ValidIDType = IDType;
            FormMain.ValidIDName = Name;
            FormMain.ValidIDNum = IDNumber;
            FormMain.receivedValidID = true;
            MessageBox.Show("Valid ID Received", "", MessageBoxButtons.OK, MessageBoxIcon.None);
            Close();
        }
    }
}
