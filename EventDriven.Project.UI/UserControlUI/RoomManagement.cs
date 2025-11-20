using EventDriven.Project.Businesslogic.Controller;
using EventDriven.Project.Model;

namespace EventDriven.Project.UI.UserControlUI
{
    public partial class RoomManagement : UserControl
    {
        private RoomController roomController;
        public event EventHandler GoToRooms;

        public RoomManagement()
        {
            InitializeComponent();
            roomController = new RoomController();
            loadRoomBeds();
        }

        private void loadRoomBeds() 
        {

            RoomOccupationModel wardBeds = roomController.GetRoomTypeAvailability("Ward");
            RoomOccupationModel PRBeds = roomController.GetRoomTypeAvailability("Private Room");
            RoomOccupationModel NRBeds = roomController.GetRoomTypeAvailability("Pediatric Room");
            RoomOccupationModel ERBeds = roomController.GetRoomTypeAvailability("Emergency Room");
            RoomOccupationModel ICUBeds = roomController.GetRoomTypeAvailability("Intensive Care Unit (ICU)");
            RoomOccupationModel NICUBeds = roomController.GetRoomTypeAvailability("Neonatal Intensive Care Unit (NICU)");
            lblWardBeds.Text = wardBeds.TotalAvailableBeds.ToString() + "/" + wardBeds.Capacity;
            lblPRBeds.Text = PRBeds.TotalAvailableBeds.ToString() + "/" + PRBeds.Capacity;
            lblNRBeds.Text = NRBeds.TotalAvailableBeds.ToString() + "/" + NRBeds.Capacity;
            lblERBeds.Text = ERBeds.TotalAvailableBeds + "/" + ERBeds.Capacity;
            lblICUBeds.Text = ICUBeds.TotalAvailableBeds.ToString() + "/" + ICUBeds.Capacity;
            lblNICUBeds.Text = NICUBeds.TotalAvailableBeds.ToString() + "/" + NICUBeds.Capacity;
        }

        private void selectRoom(string RoomType)
        {
            List<RoomInfoModel> rooms = roomController.GetAllRooms();
            foreach (var room in rooms)
            {
                if (room.RoomType == RoomType)
                {
                    FormMain.SelectedRoom = room;
                    break;
                }
            }
        }

        private void btnWard_Click(object sender, EventArgs e)
        {
            selectRoom("Ward");
            GoToRooms?.Invoke(this, EventArgs.Empty);
        }

        private void btnPR_Click(object sender, EventArgs e)
        {
            selectRoom("Private Room");
            GoToRooms?.Invoke(this, EventArgs.Empty);
        }

        private void btnNR_Click(object sender, EventArgs e)
        {
            selectRoom("Pediatric Room");
            GoToRooms?.Invoke(this, EventArgs.Empty);
        }

        private void btnER_Click(object sender, EventArgs e)
        {
            selectRoom("Emergency Room");
            GoToRooms?.Invoke(this, EventArgs.Empty);
        }

        private void btnICU_Click(object sender, EventArgs e)
        {
            selectRoom("Intensive Care Unit (ICU)");
            GoToRooms?.Invoke(this, EventArgs.Empty);
        }

        private void btnNICU_Click(object sender, EventArgs e)
        {
            selectRoom("Neonatal Intensive Care Unit (NICU)");
            GoToRooms?.Invoke(this, EventArgs.Empty);
        }
    }
}
