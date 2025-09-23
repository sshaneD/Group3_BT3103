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
        public FormAddPatient()
        {
            InitializeComponent();

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
    }
}
