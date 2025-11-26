using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EventDriven.Project.Businesslogic.Controller;
using EventDriven.Project.Model;

namespace EventDriven.Project.UI.UserControlUI
{
    public partial class Rooms : UserControl
    {
        RoomController roomController;
        RoomInfoModel room;
        public event EventHandler GoToRoomManagement;
        public Rooms()
        {
            InitializeComponent();

            FormMain.selectedPatientID = 0;
            roomController = new RoomController();
            room = FormMain.SelectedRoom;
        }

        private void Rooms_Load(object sender, EventArgs e)
        {
            RoomOccupationModel occupation = roomController.GetRoomTypeAvailability(room.RoomType);
            lblOccupied.Text = occupation.TotalAvailableBeds.ToString() + "/" + occupation.Capacity;
            lblRoomType.Text = room.RoomType;
            lblPrice.Text = "PHP " + room.RatePerDay.ToString("N2");
            dgRooms.DataSource = roomController.GetRoomModel(room.RoomType);
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            GoToRoomManagement?.Invoke(this, EventArgs.Empty);
        }

        private void lblPrice_Click(object sender, EventArgs e)
        {

        }
    }
}
