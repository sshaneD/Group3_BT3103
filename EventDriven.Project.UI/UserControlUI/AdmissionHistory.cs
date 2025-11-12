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

namespace EventDriven.Project.UI.UserControlUI
{
    public partial class AdmissionHistory : UserControl
    {
        PatientController patientController;
        public AdmissionHistory()
        {
            InitializeComponent();
            patientController = new PatientController();
            LoadData();
        }

        public void LoadData()
        {
            Clear();
            List<AdmissionCardModel> admissions = patientController.GetAllAdmissionCards();
            foreach (AdmissionCardModel admissionCard in admissions)
            {
                ShowControl(new AdmissionHistoryCard(admissionCard));
            }
        }

        public void Clear()
        {
            flowAdmissions.Controls.Clear();
        }

        public void ShowControl(UserControl control)
        {
            flowAdmissions.Controls.Add(control);
        }
    }
}
