namespace EventDriven.Project.UI.UserControlUI
{
    public partial class RoomManagement : UserControl
    {

        public event EventHandler GoToRooms;

        public RoomManagement()
        {
            InitializeComponent();
        }

        private void btnWard_Click(object sender, EventArgs e)
        {
            GoToRooms?.Invoke(this, EventArgs.Empty);
        }

        private void btnPR_Click(object sender, EventArgs e)
        {
            GoToRooms?.Invoke(this, EventArgs.Empty);
        }

        private void btnNR_Click(object sender, EventArgs e)
        {
            GoToRooms?.Invoke(this, EventArgs.Empty);
        }

        private void btnER_Click(object sender, EventArgs e)
        {
            GoToRooms?.Invoke(this, EventArgs.Empty);
        }

        private void btnICU_Click(object sender, EventArgs e)
        {
            GoToRooms?.Invoke(this, EventArgs.Empty);
        }

        private void btnNICU_Click(object sender, EventArgs e)
        {
            GoToRooms?.Invoke(this, EventArgs.Empty);
        }
    }
}
