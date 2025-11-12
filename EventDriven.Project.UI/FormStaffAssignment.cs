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
            dataGridAssignmentM.ClearSelection();
        }

        private void CheckRole()
        {
            if (role.Equals("Doctor"))
            {
                labelTitle.Text = "Doctor Assignment";
                lblStaff.Text = "Available Doctors";
            }
            else
            {
                labelTitle.Text = "Nurse Assignment";
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

        private void btnCancelAssign_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAssignStaff_Click(object sender, EventArgs e)
        {
            List<StaffModel> removeTheseStaff = new List<StaffModel>();
            for (int i = 0; i < FormMain.assignedStaff.Count; i++)
            {
                if (FormMain.assignedStaff[i].Role.Equals(role))
                {
                    removeTheseStaff.Add(FormMain.assignedStaff[i]);
                }
            }
            for (int i = 0; i < removeTheseStaff.Count; i++)
            {
                FormMain.assignedStaff.Remove(removeTheseStaff[i]);
            }
            if (dataGridAssignmentM.SelectedRows.Count > 0)
            {
                for (int i = 0; i < dataGridAssignmentM.SelectedRows.Count; i++)
                {
                    int selectedStaffID = Convert.ToInt32(dataGridAssignmentM.SelectedRows[i].Cells["StaffID"].Value);
                    FormMain.assignedStaff.Add(staffController.GetStaffByID(selectedStaffID));
                }
                MessageBox.Show("Staff assigned successfully.");
                DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {
                MessageBox.Show("Please select a staff member to assign.");
            }
        }

        private void dataGridAssignmentM_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridAssignmentM.SelectedRows.Count > 3)
            {
                DataGridViewRow lastSelected = dataGridAssignmentM.SelectedRows[dataGridAssignmentM.SelectedRows.Count - 1];
                lastSelected.Selected = false;

                MessageBox.Show("You can only select up to 3 items.", "Selection Limit", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
        }

        private void FormStaffAssignment_Load(object sender, EventArgs e)
        {
            dataGridAssignmentM.ClearSelection();
            if (FormMain.assignedStaff.Count > 0)
            {
                if (FormMain.staffRole.Equals("Doctor"))
                {
                    for (int i = 0; i < FormMain.assignedStaff.Count; i++)
                    {
                        for (int j = 0; j < dataGridAssignmentM.Rows.Count; j++)
                        {
                            if (FormMain.assignedStaff[i].StaffID == Convert.ToInt32(dataGridAssignmentM.Rows[j].Cells["StaffID"].Value))
                            {
                                dataGridAssignmentM.Rows[j].Selected = true;
                            }
                        }
                    }
                }
                else if (FormMain.staffRole.Equals("Nurse"))
                {
                    for (int i = 0; i < FormMain.assignedStaff.Count; i++)
                    {
                        for (int j = 0; j < dataGridAssignmentM.Rows.Count; j++)
                        {
                            if (FormMain.assignedStaff[i].StaffID == Convert.ToInt32(dataGridAssignmentM.Rows[j].Cells["StaffID"].Value))
                            {
                                dataGridAssignmentM.Rows[j].Selected = true;
                            }
                        }
                    }
                }
            }
        }
    }
}
