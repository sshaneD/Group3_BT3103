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
    public partial class FormStaffAssignment : Form
    {
        StaffController staffController;
        string role;
        public FormStaffAssignment()
        {
            staffController = new StaffController();
            role = FormMain.staffRole;
            InitializeComponent();
            CheckRole();
            LoadData();
        }

        private void CheckRole()
        {
            if (role.Equals("Doctor"))
            {
                labelTitle.Text = "Doctor Assignment";
                txtSearchStaff.PlaceholderText = "Search Doctor";
                lblStaff.Text = "Available Doctors";
            }
            else
            {
                labelTitle.Text = "Nurse Assignment";
                txtSearchStaff.PlaceholderText = "Search Nurse";
                lblStaff.Text = "Available Nurses";
            }
        }

        private void LoadData()
        {
            List<StaffModel> allStaff = staffController.GetAllStaff();
            for (int i = 0; i < allStaff.Count; i++)
            {
                if (!allStaff[i].Role.Equals(role))
                {
                    allStaff.Remove(allStaff[i]);
                }
            }
            dataGridAssignmentM.DataSource = allStaff;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void lblStaff_Click(object sender, EventArgs e)
        {

        }

        private void btnCancelAssign_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
