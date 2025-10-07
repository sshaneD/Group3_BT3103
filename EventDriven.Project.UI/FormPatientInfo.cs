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
    public partial class FormPatientInfo : Form
    {
        PatientController patientController;
        public static String Function;
        public static int selectedPatientID;
        public FormPatientInfo()
        {
            InitializeComponent();
            patientController = new PatientController();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {
            Function = "Add";
            Hide();
            FormAddPatient addPatient = new FormAddPatient();
            addPatient.ShowDialog();

        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow != null)
            {
                DataGridViewRow row = dataGridView1.CurrentRow;
                int selected = Convert.ToInt32(row.Cells["PatientID"].Value);
                selectedPatientID = selected;
            }
            Function = "Edit";
            Hide();
            FormAddPatient addPatient = new FormAddPatient();
            addPatient.ShowDialog();

        }

        private void FormPatientInfo_Load(object sender, EventArgs e)
        {
            Function = "Add";

            if (FormLogin.Role == "receptionist")
            {
                btnBilling.Visible = false;
            }
            dataGridView1.DataSource = patientController.GetAllPatients();
        }

        private void btnAPLogout_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormLogin formLogin = new FormLogin();
            formLogin.ShowDialog();
        }

        private void btnPatientInfo_Click(object sender, EventArgs e)
        {
            Hide();
            FormPatientInfo formPatientInfo = new FormPatientInfo();
            formPatientInfo.ShowDialog();
        }

        private void btnAdmission_Click(object sender, EventArgs e)
        {
            Hide();
            FormAddPatient formAddPatient = new FormAddPatient();
            formAddPatient.ShowDialog();
        }
    }
}
