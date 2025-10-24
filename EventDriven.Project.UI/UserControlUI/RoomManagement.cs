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


namespace EventDriven.Project.UI.UserControlUI
{
    public partial class RoomManagement : UserControl
    {

        public event EventHandler GoToRooms;

        public RoomManagement()
        {
            InitializeComponent();
        }

        private void RoundButton(Button btn, int radius)
        {
            GraphicsPath path = new GraphicsPath();
            path.AddArc(0, 0, radius, radius, 180, 90);
            path.AddArc(btn.Width - radius, 0, radius, radius, 270, 90);
            path.AddArc(btn.Width - radius, btn.Height - radius, radius, radius, 0, 90);
            path.AddArc(0, btn.Height - radius, radius, radius, 90, 90);
            path.CloseAllFigures();

            btn.Region = new Region(path);


        }

        private void RoomManagement_Load(object sender, EventArgs e)
        {
            RoundButton(btnWard, 50);
            RoundButton(btnPrivate, 50);
            RoundButton(btnNursery, 50);
            RoundButton(btnER, 50);
            RoundButton(btnICU, 50);
            RoundButton(btnNICU, 50);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            GoToRooms?.Invoke(this, EventArgs.Empty);

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btnICU_Click(object sender, EventArgs e)
        {

        }
    }
}
