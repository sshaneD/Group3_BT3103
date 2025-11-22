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
            if (roomController.GetCurrentRoom(selectedPatientID) == null)
            {
                lblRoomType.Text = "Room Type: N/A";
                lblRoomNum.Text = "Room Number: N/A";
                lblDate.Text = "N/A";
                panelAssignment.Visible = false;
                panelDischarged.Visible = true;
                return;
            }
            else
            {
                panelAssignment.Visible = true;
                panelDischarged.Visible = false;
                CurrentRoomModel assignedRoom = roomController.GetCurrentRoom(selectedPatientID);

                lblRoomType.Text = $"Room Type: {assignedRoom.RoomType}";
                lblRoomNum.Text = $"Room Number: {assignedRoom.RoomNumber} (Bed {assignedRoom.BedNumber})";
                string endDate = assignedRoom.EndDate.HasValue ? assignedRoom.EndDate.Value.ToShortDateString() : "N/A";
                lblDate.Text = $"{assignedRoom.StartDate.ToShortDateString()} - {endDate}";
            }
        }
        private void LoadMedicalRecords()
        {
            ClearMedicalRecord();
            flowMedicalRecords.Controls.Clear();
            List<MedicalRecordModel> medicalRecords = medicalRecordController.GetPatientMedicalRecords(selectedPatientID);
            if (medicalRecords.Count > 0)
            {
                FormMain.selectedRecordID = medicalRecords[0].RecordID;
                LoadMedicalRecord(medicalRecords[0].RecordID);
                foreach (MedicalRecordModel medicalRecord in medicalRecords)
                {
                    ShowControl(new MedicalRecordCard(medicalRecord.RecordID));
                }
            }
        }
        private void LoadMedicalRecord(int recordID)
        {
            MedicalRecordModel medicalRecord = medicalRecordController.GetMedicalRecordByID(recordID);
            TreatmentModel treatment = medicalRecordController.GetTreatmentByRecordID(recordID);
            MedicationModel medication = medicalRecordController.GetMedicationByRecordID(recordID);
            txtDiagnosis.Text = medicalRecord.Diagnosis;
            txtNotes.Text = medicalRecord.Notes;
            if (!string.IsNullOrEmpty(treatment.TreatmentType))
                txtTreatment.Text = treatment.TreatmentType;
            else
                txtTreatment.Text = string.Empty;

            if (!string.IsNullOrEmpty(medication.MedicationName))
                txtMedication.Text = $"{medication.MedicationName} {Environment.NewLine}{medication.FrequencyCount} Every {medication.FrequencyValue} {medication.FrequencyType}";
            else
                txtMedication.Text = string.Empty;
        }
        private void ClearMedicalRecord()
        {
            txtDiagnosis.Clear();
            txtNotes.Clear();
            txtTreatment.Clear();
            txtMedication.Clear();
        }
        private void ShowControl(UserControl control)
        {
            if (control is MedicalRecordCard medicalRecordCard)
            {
                medicalRecordCard.UpdateMedicalRecord += (s, e) => LoadMedicalRecord(FormMain.selectedRecordID);
            }
            flowMedicalRecords.Controls.Add(control);
        }
        private void btnExit_Click(object sender, EventArgs e)
        {
            GoToPatientInfo?.Invoke(this, EventArgs.Empty);
        }
        private void btnDelete_Click(object sender, EventArgs e)
        {
            DialogResult res = MessageBox.Show(
                "Are you sure you want to delete this record? This cannot be undone.",
                "Delete Medical Record",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning
            );

            if (res == DialogResult.Yes)
            {
                medicalRecordController.DeleteMedicalRecordByID(FormMain.selectedRecordID);
                FormMain.selectedRecordID = 0;
                LoadMedicalRecords();
                MessageBox.Show(
                    "Medical Record Deleted Successfully!",
                    "Success",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                );
            }
            else
            {
                MessageBox.Show("Deletion Cancelled",
                    "Cancelled",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                );

            }
        }
    }
}