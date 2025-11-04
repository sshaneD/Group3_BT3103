using System.Diagnostics.Eventing.Reader;
using EventDriven.Project.Model;
using EventDriven.Project.UI.UserControlUI;

namespace EventDriven.Project.UI
{
    public partial class FormMain : Form
    {
        public static string AdmissionAction;
        public static int selectedPatientID = 0;
        public static string staffRole;
        public static RoomInfoModel SelectedRoom;
        public static List<StaffModel> assignedStaff = new List<StaffModel>();
        public FormMain()
        {
            InitializeComponent();
            AdmissionAction = "Add";
            ShowControl(new Dashboard());
            CheckLoggedUser();
        }

        private void CheckLoggedUser()
        {
            switch (FormLogin.Role)
            {
                case "admin":
                    break;
                case "receptionist":
                    btnBilling.Visible = false;
                    break;
                case "cashier":
                    btnAdmission.Visible = false;
                    btnRooms.Visible = false;
                    btnDischarge.Visible = false;
                    break;
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            FormLogin.Logout = "Yes";
            this.Hide();
            FormLogin formLogin = new FormLogin();
            formLogin.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ShowControl(new PatientInformation());
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ShowControl(new Dashboard());
        }

        private void button4_Click(object sender, EventArgs e)
        {
            FormMain.AdmissionAction = "Add";
            ShowControl(new Admission());
        }

        private void ShowControl(UserControl userControl)
        {
            btnHome.BackColor = Color.Transparent;
            btnPatientInfo.BackColor = Color.Transparent;
            btnAdmission.BackColor = Color.Transparent;
            btnRooms.BackColor = Color.Transparent;
            btnBilling.BackColor = Color.Transparent;
            btnDischarge.BackColor = Color.Transparent;

            if (userControl is PatientInformation patientInfo)
            {
                btnPatientInfo.BackColor = Color.LightGray;
                patientInfo.GoToAdmissionAdd += (s, e) => ShowControl(new Admission());
                patientInfo.GoToAdmissionEdit += (s, e) => ShowControl(new Admission());
            }
            else if (userControl is Admission admission)
            {

                if (AdmissionAction == "Add")
                {
                    btnAdmission.BackColor = Color.LightGray;
                }
                else if (AdmissionAction == "Edit")
                {
                    btnPatientInfo.BackColor = Color.LightGray;
                }
                admission.GoToPatientInfo += (s, e) => ShowControl(new PatientInformation());
              
            }

            else if (userControl is RoomManagement roomManagement)
            {
                btnRooms.BackColor = Color.LightGray;
                roomManagement.GoToRooms += (s, e) => ShowControl(new Rooms());
            }

            else if (userControl is Dashboard dashboard)
            {
                btnHome.BackColor = Color.LightGray;
            }

            else if (userControl is Rooms rooms)
            {
                rooms.GoToRoomManagement += (s, e) => ShowControl(new RoomManagement());
            }

                MainPanel.Controls.Clear();
            MainPanel.Controls.Add(userControl);
        }

        private void btnRooms_Click(object sender, EventArgs e)
        {
            ShowControl(new RoomManagement());
        }
    }
}
