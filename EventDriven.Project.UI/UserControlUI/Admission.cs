using EventDriven.Project.Businesslogic.Controller;
using EventDriven.Project.Model;
using TextBox = System.Windows.Forms.TextBox;

namespace EventDriven.Project.UI.UserControlUI
{
    public partial class Admission : UserControl
    {
        #region Local Variables
        public event EventHandler GoToPatientInfo;
        public event EventHandler GoToTreatment;
        public event EventHandler GoToAdmissionHistory;
        private PatientController patientController;
        private StaffController staffController;
        private RoomController roomController;
        #endregion
        public Admission()
        {
            InitializeComponent();
            patientController = new PatientController();
            staffController = new StaffController();
            roomController = new RoomController();
            CheckAction();
        }
        private void CheckAction()
        {
            if (FormMain.AdmissionAction == "Add")
            {
                ClearData();
                btnSubmit.Text = "Admit";
                btnTreatment.Visible = false;
                btnCancel.Visible = false;
                lblTitle.Text = "Admission Form";
            }
            else if (FormMain.AdmissionAction == "Edit")
            {
                LoadData();
                btnSubmit.Text = "Save";
                btnTreatment.Visible = true;
                btnCancel.Visible = true;
                lblTitle.Text = "Edit Patient Information";
            }
        }
        private void LoadData()
        {
            PatientModel patient = patientController.GetPatientById(FormMain.selectedPatientID);
            CurrentRoomModel assignedRoom = roomController.GetCurrentRoom(FormMain.selectedPatientID);
            txtFN.Text = patient.FirstName;
            txtMN.Text = patient.MiddleName;
            txtLN.Text = patient.LastName;
            dateOfBirth.Value = patient.DateOfBirth;
            cbGender.Text = patient.Gender;
            txtGN.Text = patient.GuardianName;
            txtGCN.Text = patient.GuardianNo;

            LoadTextbox();
            LoadRoomTypes();

            List<RoomInfoModel> allRooms = roomController.GetAllRooms();
            RoomInfoModel selectedRoom = allRooms.Where(ar => ar.RoomID == assignedRoom.RoomID).First();
            cbRoom.SelectedItem = selectedRoom.RoomType;
            LoadRoomNumber();
            cbRoomNo.SelectedIndexChanged -= cbRoomNo_SelectedIndexChanged;
            cbRoomNo.SelectedIndex = cbRoomNo.Items.IndexOf(selectedRoom.RoomNumber.ToString());
            cbRoomNo.SelectedIndexChanged += cbRoomNo_SelectedIndexChanged;
            dateStartDate.Value = assignedRoom.StartDate;
            dateEndDate.Value = assignedRoom.EndDate ?? DateTime.Now;

        }
        private void ClearData()
        {
            txtFN.Clear();
            txtMN.Clear();
            txtLN.Clear();
            dateAdmission.Value = DateTime.Now.Date;
            dateOfBirth.Value = DateTime.Now.Date;
            cbGender.SelectedIndex = -1;
            txtGN.Clear();
            txtGCN.Clear();
            cbRoom.SelectedIndex = -1;
            cbRoomNo.SelectedIndex = -1;
            txtDoctor.Clear();
            txtDoctor2.Clear();
            txtDoctor3.Clear();
            txtNurse.Clear();
            txtNurse2.Clear();
            txtNurse3.Clear();
            FormMain.assignedStaff.Clear();
        }
        private void btnADCancel_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Changes are not saved.", "Cancelled", MessageBoxButtons.OK, MessageBoxIcon.Information);
            GoToPatientInfo?.Invoke(this, EventArgs.Empty);
        }
        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if (FormMain.AdmissionAction == "Add")
            {
                PatientModel newPatient = new PatientModel
                {
                    FirstName = txtFN.Text,
                    MiddleName = txtMN.Text,
                    LastName = txtLN.Text,
                    DateOfBirth = dateOfBirth.Value.Date,
                    Age = calculateAge(dateOfBirth.Value.Date),
                    Gender = cbGender.Text,
                    GuardianName = txtGN.Text,
                    GuardianNo = txtGCN.Text,
                };
                patientController.AddPatient(newPatient);
                AssignStaff();
                assignRoom();
                MessageBox.Show("Patient admitted successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                ClearData();
            }
            else if (FormMain.AdmissionAction == "Edit")
            {
                PatientModel updatedPatient = new PatientModel
                {
                    PatientID = FormMain.selectedPatientID,
                    FirstName = txtFN.Text,
                    MiddleName = txtMN.Text,
                    LastName = txtLN.Text,
                    DateOfBirth = dateOfBirth.Value.Date,
                    Age = calculateAge(dateOfBirth.Value.Date),
                    Gender = cbGender.Text,
                    GuardianName = txtGN.Text,
                    GuardianNo = txtGCN.Text,
                };
                patientController.EditPatient(updatedPatient);
                AssignStaff();
                assignRoom();
                MessageBox.Show("Patient information updated successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                GoToPatientInfo?.Invoke(this, EventArgs.Empty);

                ClearData();
            }
        }
        private void AssignStaff()
        {
            //FormMain.assignedStaff.Clear();

            int selectedPatientID = FormMain.AdmissionAction.Equals("Add") ? patientController.GetNextPatientID() - 1 : FormMain.selectedPatientID;
            if (FormMain.AdmissionAction.Equals("Edit"))
            {
                staffController.RemoveAssignedStaff(selectedPatientID);
            }
            for (int i = 0; i < FormMain.assignedStaff.Count; i++)
            {
                staffController.AddStaff(selectedPatientID, FormMain.assignedStaff[i].StaffID);
            }
        }
        private void btnViewDN_Click(object sender, EventArgs e)
        {
            FormAddMedicalDetails med = new FormAddMedicalDetails();
            med.ShowDialog();
        }
        private int calculateAge(DateTime dateOfBirth)
        {
            DateTime today = DateTime.Today;
            int age = today.Year - dateOfBirth.Year;
            if (dateOfBirth.Date > today.AddYears(-age)) age--;
            return age;
        }
        private void txtDoctor_Click(object sender, EventArgs e)
        {
            FormMain.staffRole = "Doctor";
            FormStaffAssignment doctorStaff = new FormStaffAssignment();
            doctorStaff.ShowDialog();
            if (doctorStaff.DialogResult == DialogResult.OK)
            {
                LoadTextbox();
            }
        }
        private void txtNurse_Click(object sender, EventArgs e)
        {
            FormMain.staffRole = "Nurse";
            FormStaffAssignment doctorStaff = new FormStaffAssignment();
            doctorStaff.ShowDialog();
            if (doctorStaff.DialogResult == DialogResult.OK)
            {
                LoadTextbox();
            }
        }
        private void LoadTextbox()
        {
            TextBox[] textBoxes = { txtDoctor, txtDoctor2, txtDoctor3, txtNurse, txtNurse2, txtNurse3 };
            TextBox[] doctorTextboxes = { txtDoctor, txtDoctor2, txtDoctor3 };
            TextBox[] nurseTextboxes = { txtNurse, txtNurse2, txtNurse3 };
            List<StaffModel> doctors = new List<StaffModel>();
            List<StaffModel> nurses = new List<StaffModel>();

            foreach (TextBox tb in textBoxes)
            {
                tb.Clear();
            }

            foreach (StaffModel staff in FormMain.assignedStaff)
            {
                if (staff.Role.Equals("Doctor"))
                {
                    doctors.Add(staff);
                }
                else
                {
                    nurses.Add(staff);
                }
            }

            for (int i = 0; i < doctors.Count; i++)
            {
                doctorTextboxes[i].Text = $"{doctors[i].FirstName} {doctors[i].LastName} ({doctors[i].DepartmentName})";
            }

            for (int i = 0; i < nurses.Count; i++)
            {
                nurseTextboxes[i].Text = $"{nurses[i].FirstName} {nurses[i].LastName} ({nurses[i].DepartmentName})";
            }
        }
        private void LoadRoomTypes()
        {
            cbRoom.Items.Clear();
            List<RoomOccupationModel> rooms =
            [
                roomController.GetRoomTypeAvailability("Ward"),
                roomController.GetRoomTypeAvailability("Private Room"),
                roomController.GetRoomTypeAvailability("Pediatric Room"),
                roomController.GetRoomTypeAvailability("Emergency Room"),
                roomController.GetRoomTypeAvailability("Intensive Care Unit (ICU)"),
                roomController.GetRoomTypeAvailability("Neonatal Intensive Care Unit (NICU)"),
            ];

            foreach (RoomOccupationModel room in rooms)
            {
                cbRoom.Items.Add(room.RoomType);
            }

        }
        private void LoadRoomNumber()
        {
            cbRoomNo.Items.Clear();
            if (cbRoom.SelectedItem != null)
            {
                string selectedRoomType = cbRoom.SelectedItem.ToString();
                List<RoomModel> roomModel = roomController.GetRoomModel(selectedRoomType);
                foreach (RoomModel room in roomModel)
                {
                    if (room.AvailableBeds > 0)
                    {
                        cbRoomNo.Items.Add(room.RoomNumber.ToString());
                    }
                    else
                    {
                        cbRoomNo.Items.Add($"{room.RoomNumber} (Full)");
                    }
                }
            }
            else
            {
                cbRoomNo.Items.Add("Please select a Room");
                cbRoomNo.SelectedIndex = 0;
            }
        }
        private void cbRoomNo_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedRoomNo = string.Empty;
            if (cbRoomNo.SelectedIndex > -1)
                selectedRoomNo = cbRoomNo.SelectedItem.ToString();
            if (selectedRoomNo.Contains("Full"))
            {
                cbRoomNo.SelectedIndex = -1;
                MessageBox.Show("This Room is full. Please select another Room.", "Room Full", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        private void cbRoom_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadRoomNumber();
        }
        private void assignRoom()
        {
            List<RoomInfoModel> allRooms = roomController.GetAllRooms();
            RoomInfoModel selectedRoom = allRooms.Where(ar => ar.RoomType == cbRoom.SelectedItem.ToString() && ar.RoomNumber == Convert.ToInt32(cbRoomNo.SelectedItem.ToString())).First();
            RoomNumberModel roomNumber = roomController.GetRoomNumberInfo(Convert.ToInt32(cbRoomNo.SelectedItem.ToString()));
            AssignedRoomModel assignedRoom = new AssignedRoomModel
            {
                RoomID = selectedRoom.RoomID,
                PatientID = FormMain.AdmissionAction.Equals("Add") ? patientController.GetNextPatientID() - 1 : FormMain.selectedPatientID,
                BedNumber = roomNumber.OccupiedBeds + 1,
                StartDate = dateStartDate.Value.Date,
                EndDate = dateEndDate.Checked == true ? dateEndDate.Value.Date : null,
            };
            if (FormMain.AdmissionAction.Equals("Edit"))
            {
                CurrentRoomModel currentRoom = roomController.GetCurrentRoom(FormMain.selectedPatientID);
                if (currentRoom.RoomID == assignedRoom.RoomID)
                {
                    return;
                }
            }
            roomController.AssignRoom(assignedRoom);
        }
        private void btnViewAdmissionHistory_Click(object sender, EventArgs e)
        {
            GoToAdmissionHistory?.Invoke(this, EventArgs.Empty);
        }
        private void removeFocus(object sender, EventArgs e)
        {
            ActiveControl = null;
        }
    }
}