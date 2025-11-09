using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EventDriven.Project.Model;

namespace EventDriven.Project.UI.UserControlUI
{
    public partial class AdmissionHistoryCard : UserControl
    {
        AdmissionCardModel card;
        public AdmissionHistoryCard(AdmissionCardModel admissionCard)
        {
            InitializeComponent();
            card = admissionCard;
            LoadData();
        }

        public void LoadData()
        {
            lblName.Text = card.PatientName;
            lblPatientID.Text = card.PatientID.ToString();
            lblDiagnosis.Text = card.Diagnosis;
            lblAdmitted.Text = $"Admitted on: {card.AdmissionDate}";
            if (card.DischargeDate != null)
            {
                lblDischarged.Text = $"Discharged on: {card.DischargeDate}";
            }
            else
            {
                lblDischarged.Visible = false;
            }
        }
    }
}
