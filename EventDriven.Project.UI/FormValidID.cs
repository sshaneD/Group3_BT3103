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
        BillingController billingController;
        string action = "Save";
        public FormValidID()
        {
            InitializeComponent();
            patientController = new PatientController();
            billingController = new BillingController();
            PatientModel patient = patientController.GetPatientById(FormMain.selectedPatientID);
            int admissionID = patientController.GetPatientAdmissionIDs(FormMain.selectedPatientID).Last();
            BillingModel billing = billingController.GenerateBilling(admissionID);
            LoadData();
            if (billing.Balance <= 0)
            {
                ChangeButtons();
            }
        }
        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }
        private void LoadData()
        {
            if (patientController.GetValidIDByPatientID(FormMain.selectedPatientID) == null)
                return;
            ValidIDModel validID = patientController.GetValidIDByPatientID(FormMain.selectedPatientID);
            cbType.SelectedItem = validID.Type;
            txtName.Text = validID.Name;
            txtIDNumber.Text = validID.Number;   
        }
        private void ChangeButtons()
        {
            btnSave.Text = "Return";
            action = "Return";
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            if (action.Equals("Save"))
            {
                PatientModel patient = patientController.GetPatientById(FormMain.selectedPatientID);
                string patientName = patient.FirstName + " " + patient.MiddleName + " " + patient.LastName;
                string IDType = cbType.Text;
                string Name = txtName.Text;
                string IDNumber = txtIDNumber.Text;

                if (string.IsNullOrEmpty(IDType) || string.IsNullOrEmpty(Name) || string.IsNullOrEmpty(IDNumber))
                {
                    MessageBox.Show("Please fill in all fields.", "Incomplete Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (string.Equals(Name, patientName, StringComparison.OrdinalIgnoreCase) == true
                    || string.Equals(Name, patient.GuardianName, StringComparison.OrdinalIgnoreCase) == true)
                {
                    ValidIDModel validID = new ValidIDModel
                    {
                        PatientID = FormMain.selectedPatientID,
                        Type = IDType,
                        Name = Name,
                        Number = IDNumber,
                    };
                    patientController.AddValidID(validID);
                    MessageBox.Show("Valid ID Received", "", MessageBoxButtons.OK, MessageBoxIcon.None);
                }
                else
                {
                    MessageBox.Show("This ID does not match the patient's or guardian's name", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
            }
            else
            {
                patientController.DeleteValidID(FormMain.selectedPatientID);
                MessageBox.Show("Valid ID has been returned", "", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                DialogResult = DialogResult.OK;
            }
            Close();
        }
    }
}
