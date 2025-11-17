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
    public partial class FormValidID : Form
    {
        public FormValidID()
        {
            InitializeComponent();
        }
        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            string IDType = cbType.Text;
            string Name = txtName.Text;
            string IDNumber = txtIDNumber.Text;

            if (string.IsNullOrEmpty(IDType) || string.IsNullOrEmpty(Name) || string.IsNullOrEmpty(IDNumber))
            {
                MessageBox.Show("Please fill in all fields.", "Incomplete Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            FormMain.receivedValidID = true;
            MessageBox.Show("Valid ID Received", "", MessageBoxButtons.OK, MessageBoxIcon.None);
            Close();
        }
    }
}
