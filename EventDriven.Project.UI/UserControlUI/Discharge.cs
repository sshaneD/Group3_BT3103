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
    public partial class Discharge : UserControl
    {
        PatientController patientController;
        RoomController roomController;
        MedicalRecordController mediicalRecordController;
        BillingController billingController;
        int selectedPatientID;
        public Discharge()
        {
            InitializeComponent();
            patientController = new PatientController();
            roomController = new RoomController();
            mediicalRecordController = new MedicalRecordController();
            billingController = new BillingController();
            selectedPatientID = FormMain.selectedPatientID;

            LoadData();
        }
        private void LoadData()
        {
            PatientModel patient = patientController.GetPatientById(selectedPatientID);
            lblPatientName.Text = $"{patient.FirstName} {patient.MiddleName} {patient.LastName}";
            lblPatientID.Text = patient.PatientID.ToString();

            CurrentRoomModel room = roomController.GetCurrentRoom(selectedPatientID);
            lblRoomName.Text = room.RoomType;

            List<int> admissionIDs = patientController.GetPatientAdmissionIDs(selectedPatientID);
            List<AdmissionCardModel> admissions = patientController.GetAllAdmissionCards();

            foreach (AdmissionCardModel admission in admissions)
            {
                if (admission.DischargeDate != null || admission.DischargeDate > DateTime.Now)
                {
                  lblAdmissionDate.Text = admission.AdmissionDate.ToString();
                    
                }
            }



        }
    }
}
