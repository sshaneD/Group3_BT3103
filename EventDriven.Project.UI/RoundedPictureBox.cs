using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace EventDriven.Project.UI
{
    public class RoundedPictureBox : PictureBox
    {
        public int CornerRadius { get; set; } = 10;

        protected override void OnPaint(PaintEventArgs pe)
        {
            base.OnPaint(pe);

            using (GraphicsPath path = new GraphicsPath())
            {
                Rectangle bounds = new Rectangle(0, 0, Width, Height);
                int diameter = CornerRadius * 2;
                Size size = new Size(diameter, diameter);
                Rectangle arc = new Rectangle(bounds.Location, size);

                path.AddArc(arc, 180, 90);
                arc.X = bounds.Right - diameter;
                path.AddArc(arc, 270, 90);
                arc.Y = bounds.Bottom - diameter;
                path.AddArc(arc, 0, 90);
                arc.X = bounds.Left;
                path.AddArc(arc, 90, 90);
                path.CloseFigure();

                this.Region = new Region(path);
            }
        }
    }
}