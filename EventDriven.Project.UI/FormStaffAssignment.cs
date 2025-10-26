using EventDriven.Project.Businesslogic.Controller;
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
        public FormStaffAssignment()
        {
            staffController = new StaffController();
            InitializeComponent();
            dataGridAssignmentM.DataSource = staffController.GetAllStaff();
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
