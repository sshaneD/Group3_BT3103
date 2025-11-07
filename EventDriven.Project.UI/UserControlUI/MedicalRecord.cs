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
    public partial class MedicalRecord : UserControl
    {
        PatientController patientController;
        RoomController roomController;
        StaffController staffController;
        MedicalRecordController medicalRecordController;
        int selectedPatientID;
        PatientModel patient;
        public event EventHandler GoToPatientInfo;
        public MedicalRecord()
        {
            InitializeComponent();

            patientController = new PatientController();
            roomController = new RoomController();
            staffController = new StaffController();
            medicalRecordController = new MedicalRecordController();
            selectedPatientID = FormMain.selectedPatientID;
            patient = patientController.GetPatientById(selectedPatientID);

            LoadPatient();
            LoadStaff();
            LoadRoom();
            ClearMedicalRecord();
            LoadMedicalRecords();
        }
        private void LoadPatient()
        {
            lblName.Text = $"{patient.FirstName} {patient.MiddleName} {patient.LastName}";
            lblPatientID.Text = $"Patient ID: {patient.PatientID}";
            lblAge.Text = $"{patient.Age} Years Old";
            lblGender.Text = patient.Gender;
        }
        private void LoadStaff()
        {
            List<int> staffIDs = staffController.GetAssignedStaff(selectedPatientID);
            List<StaffModel> staff = new List<StaffModel>();
            List<StaffModel> doctors = new List<StaffModel>();
            List<StaffModel> nurses = new List<StaffModel>();

            foreach (int staffID in staffIDs)
            {
                staff.Add(staffController.GetStaffByID(staffID));
            }

            foreach (StaffModel member in staff)
            {
                if (member.Role.Equals("Doctor"))
                {
                    doctors.Add(member);
                }
                else
                {
                    nurses.Add(member);
                }
            }

            for (int i = 0; i < doctors.Count; i++)
            {
                if (i < doctors.Count - 1)
                {
                    txtDoctorList.AppendText($"{doctors[i].FirstName} {doctors[i].LastName} ({doctors[i].DepartmentName}), {Environment.NewLine}");
                }
                else
                {
                    txtDoctorList.AppendText($"{doctors[i].FirstName} {doctors[i].LastName} ({doctors[i].DepartmentName})");
                }
            }

            for (int i = 0; i < nurses.Count; i++)
            {
                if (i < nurses.Count - 1)
                {
                    txtNurseList.AppendText($"{nurses[i].FirstName} {nurses[i].LastName} ({nurses[i].DepartmentName}), {Environment.NewLine}");
                }
                else
                {
                    txtNurseList.AppendText($"{nurses[i].FirstName} {nurses[i].LastName} ({nurses[i].DepartmentName})");
                }
            }
        }
        private void LoadRoom()
        {
            AssignedRoomModel assignedRoom = roomController.GetAssignedRoom(selectedPatientID);
            RoomInfoModel roomInfo = roomController.GetRoomByRoomID(assignedRoom.RoomID);

            lblRoomType.Text = $"Room Type: {roomInfo.RoomType}";
            lblRoomNum.Text = $"Room Number: {roomInfo.RoomNumber} ({assignedRoom.BedNumber})";
            string endDate = assignedRoom.EndDate.HasValue ? assignedRoom.EndDate.Value.ToShortDateString() : "N/A";
            lblDate.Text = $"{assignedRoom.StartDate.ToShortDateString()} - {endDate}";
        }
        private void LoadMedicalRecords()
        {
            List<MedicalRecordModel> medicalRecords = medicalRecordController.GetPatientMedicalRecords(selectedPatientID);
            foreach (MedicalRecordModel medicalRecord in medicalRecords)
            {
                FormMain.selectedRecordID = medicalRecord.RecordID;
                ShowControl(new MedicalRecordCard(medicalRecord.RecordID));
            }
            LoadMedicalRecord(FormMain.selectedRecordID);
        }
        private void LoadMedicalRecord(int recordID)
        {
            MedicalRecordModel medicalRecord = medicalRecordController.GetMedicalRecordByID(recordID);
            TreatmentModel treatment = medicalRecordController.GetTreatmentByRecordID(recordID);
            MedicationModel medication = medicalRecordController.GetMedicationByRecordID(recordID);
            txtDiagnosis.Text = medicalRecord.Diagnosis;
            txtNotes.Text = medicalRecord.Notes;
            txtTreatment.Text = treatment.TreatmentType;
            txtMedication.Text = medication.MedicationName;
        }
        private void ClearMedicalRecord()
        {
            FormMain.selectedRecordID = 0;
            txtDiagnosis.Clear();
            txtNotes.Clear();
        }
        private void ShowControl(UserControl control)
        {
            if (control is MedicalRecordCard medicalRecordCard)
            {
                medicalRecordCard.UpdateMedicalRecord += (s, e) => LoadMedicalRecord(FormMain.selectedRecordID);
            }
            flowMedicalRecords.Controls.Add(control);
        }
        private void label6_Click(object sender, EventArgs e)
        {

        }
        private void btnPrint_Click(object sender, EventArgs e)
        {

        }
        private void btnExit_Click(object sender, EventArgs e)
        {
            GoToPatientInfo?.Invoke(this, EventArgs.Empty);
        }
    }
}
