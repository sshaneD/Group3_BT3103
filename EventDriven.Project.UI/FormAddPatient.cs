using EventDriven.Project.Businesslogic.Controller;
using EventDriven.Project.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EventDriven.Project.UI
{
    public partial class FormAddPatient : Form
    {
        PatientController patientController;
        public FormAddPatient()
        {
            InitializeComponent();
            patientController = new PatientController();

        }

        private void FormAddPatient_Load(object sender, EventArgs e)
        {
            if (FormPatientInfo.Function == "Edit")

            {
                lblTitle.Text = "Edit Patient";
                btnPatientInfo.BackColor = Color.LightGray;
                btnAdmission.BackColor = Color.White;
            }

            else if (FormPatientInfo.Function == "Add")

            {
                btnADCancel.Visible = false;
            }

            if (FormLogin.Role == "receptionist")

            {
                btnBilling.Visible = false;

            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnAPLogout_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormLogin formLogin = new FormLogin();
            formLogin.ShowDialog();

        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void btnADCancel_Click(object sender, EventArgs e)
        {
            Hide();
            FormPatientInfo formPatientInfo = new FormPatientInfo();
            formPatientInfo.ShowDialog();
        }

        private void btnPatientInfo_Click(object sender, EventArgs e)
        {
            Hide();
            FormPatientInfo formPatientInfo = new FormPatientInfo();
            formPatientInfo.ShowDialog();
        }

        private void btnAdmission_Click(object sender, EventArgs e)
        {
            FormPatientInfo.Function = "Add";
            Hide();
            FormAddPatient formAddPatient = new FormAddPatient();
            formAddPatient.ShowDialog();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            PatientModel patient = new PatientModel{
                PatientID = Convert.ToInt32(lblID.Text),
                FirstName = textBox1.Text,
                LastName = textBox2.Text,
                Age = Convert.ToInt32 (textBox3.Text),
                Gender = comboBox1.Text,
                Diagnosis = textBox8.Text,
                RoomNo = Convert.ToInt32(comboBox3.Text),
                GuardianName = textBox4.Text,
                GuardianNo = textBox5.Text

            };
            patientController.AddPatient(patient);
            MessageBox.Show("The patient has been added!");
        }
    }
}
