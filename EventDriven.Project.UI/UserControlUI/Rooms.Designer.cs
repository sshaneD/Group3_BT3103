namespace EventDriven.Project.UI.UserControlUI
{
    partial class Rooms
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            dgRooms = new DataGridView();
            btnBack = new Button();
            lblRoomType = new Label();
            lblPrice = new Label();
            panel2 = new Panel();
            flowLayoutPanel1 = new FlowLayoutPanel();
            label13 = new Label();
            lblOccupied = new Label();
            ((System.ComponentModel.ISupportInitialize)dgRooms).BeginInit();
            panel2.SuspendLayout();
            flowLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // dgRooms
            // 
            dgRooms.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgRooms.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dgRooms.BackgroundColor = Color.Gainsboro;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 12F);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Control;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgRooms.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgRooms.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 12F);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Window;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dgRooms.DefaultCellStyle = dataGridViewCellStyle2;
            dgRooms.EditMode = DataGridViewEditMode.EditProgrammatically;
            dgRooms.EnableHeadersVisualStyles = false;
            dgRooms.GridColor = SystemColors.WindowText;
            dgRooms.Location = new Point(178, 384);
            dgRooms.Name = "dgRooms";
            dgRooms.ReadOnly = true;
            dgRooms.RowHeadersVisible = false;
            dgRooms.RowHeadersWidth = 51;
            dgRooms.ShowEditingIcon = false;
            dgRooms.Size = new Size(1307, 507);
            dgRooms.TabIndex = 10;
            dgRooms.TabStop = false;
            // 
            // btnBack
            // 
            btnBack.BackColor = Color.FromArgb(11, 143, 172);
            btnBack.FlatAppearance.BorderSize = 0;
            btnBack.FlatStyle = FlatStyle.Flat;
            btnBack.Font = new Font("Microsoft JhengHei UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnBack.ForeColor = Color.White;
            btnBack.Location = new Point(1447, 910);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(110, 39);
            btnBack.TabIndex = 12;
            btnBack.Text = "Back";
            btnBack.UseVisualStyleBackColor = false;
            btnBack.Click += btnBack_Click;
            // 
            // lblRoomType
            // 
            lblRoomType.Anchor = AnchorStyles.None;
            lblRoomType.AutoSize = true;
            lblRoomType.BackColor = Color.White;
            lblRoomType.Cursor = Cursors.Hand;
            lblRoomType.Font = new Font("Microsoft JhengHei UI", 14.8F, FontStyle.Bold);
            lblRoomType.ForeColor = SystemColors.ActiveCaptionText;
            lblRoomType.Location = new Point(96, 47);
            lblRoomType.Name = "lblRoomType";
            lblRoomType.Size = new Size(94, 32);
            lblRoomType.TabIndex = 27;
            lblRoomType.Text = "WARD\r\n";
            lblRoomType.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblPrice
            // 
            lblPrice.Anchor = AnchorStyles.None;
            lblPrice.AutoSize = true;
            lblPrice.BackColor = Color.White;
            lblPrice.Cursor = Cursors.Hand;
            lblPrice.Font = new Font("Segoe UI Semibold", 14.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblPrice.Location = new Point(62, 166);
            lblPrice.Name = "lblPrice";
            lblPrice.Size = new Size(162, 35);
            lblPrice.TabIndex = 28;
            lblPrice.Text = "PHP 1,000.00";
            lblPrice.TextAlign = ContentAlignment.MiddleCenter;
            lblPrice.Click += lblPrice_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.White;
            panel2.Controls.Add(flowLayoutPanel1);
            panel2.Location = new Point(178, 106);
            panel2.Name = "panel2";
            panel2.Size = new Size(287, 204);
            panel2.TabIndex = 32;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Controls.Add(lblPrice);
            flowLayoutPanel1.Controls.Add(label13);
            flowLayoutPanel1.Controls.Add(lblOccupied);
            flowLayoutPanel1.Controls.Add(lblRoomType);
            flowLayoutPanel1.FlowDirection = FlowDirection.BottomUp;
            flowLayoutPanel1.Location = new Point(3, 3);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(281, 201);
            flowLayoutPanel1.TabIndex = 33;
            // 
            // label13
            // 
            label13.Anchor = AnchorStyles.None;
            label13.BackColor = Color.White;
            label13.Font = new Font("Segoe UI Semibold", 13F, FontStyle.Bold);
            label13.ForeColor = SystemColors.AppWorkspace;
            label13.Location = new Point(3, 136);
            label13.Name = "label13";
            label13.Size = new Size(281, 30);
            label13.TabIndex = 31;
            label13.Text = "Available Beds";
            label13.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblOccupied
            // 
            lblOccupied.Anchor = AnchorStyles.None;
            lblOccupied.BackColor = Color.White;
            lblOccupied.Cursor = Cursors.Hand;
            lblOccupied.Font = new Font("Segoe UI Semibold", 25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblOccupied.Location = new Point(63, 79);
            lblOccupied.Name = "lblOccupied";
            lblOccupied.Size = new Size(160, 57);
            lblOccupied.TabIndex = 30;
            lblOccupied.Text = "13/30";
            lblOccupied.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Rooms
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panel2);
            Controls.Add(btnBack);
            Controls.Add(dgRooms);
            Name = "Rooms";
            Size = new Size(1637, 998);
            Load += Rooms_Load;
            ((System.ComponentModel.ISupportInitialize)dgRooms).EndInit();
            panel2.ResumeLayout(false);
            flowLayoutPanel1.ResumeLayout(false);
            flowLayoutPanel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private DataGridView dgRooms;
        private Button btnBack;
        private Label lblRoomType;
        private Label lblPrice;
        private Panel panel2;
        private Label label13;
        private Label lblOccupied;
        private FlowLayoutPanel flowLayoutPanel1;
    }
}
