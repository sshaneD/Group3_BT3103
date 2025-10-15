namespace EventDriven.Project.UI
{
    partial class FormMain
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panel1 = new Panel();
            label14 = new Label();
            button7 = new Button();
            panel2 = new Panel();
            pictureBox1 = new PictureBox();
            flowLayoutPanel1 = new FlowLayoutPanel();
            btnDashboard = new Button();
            btnPatientInfo = new Button();
            btnAdmission = new Button();
            btnRooms = new Button();
            btnBilling = new Button();
            btnDischarge = new Button();
            pictureBox2 = new PictureBox();
            MainPanel = new Panel();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            MainPanel.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(11, 143, 172);
            panel1.Controls.Add(label14);
            panel1.Controls.Add(button7);
            panel1.Location = new Point(-4, -1);
            panel1.Name = "panel1";
            panel1.Size = new Size(1927, 85);
            panel1.TabIndex = 0;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Microsoft JhengHei UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label14.ForeColor = SystemColors.ButtonHighlight;
            label14.Location = new Point(34, 35);
            label14.Name = "label14";
            label14.Size = new Size(297, 36);
            label14.TabIndex = 30;
            label14.Text = "Apex Medical Center";
            // 
            // button7
            // 
            button7.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button7.Location = new Point(1806, 28);
            button7.Name = "button7";
            button7.Size = new Size(94, 29);
            button7.TabIndex = 3;
            button7.Text = "Log out";
            button7.UseVisualStyleBackColor = true;
            button7.Click += button7_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.White;
            panel2.Controls.Add(pictureBox1);
            panel2.Controls.Add(flowLayoutPanel1);
            panel2.Location = new Point(-4, 84);
            panel2.Name = "panel2";
            panel2.Size = new Size(291, 1035);
            panel2.TabIndex = 1;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.Modern_Minimalist_Black_and_White_Report_Presentation__17_;
            pictureBox1.Location = new Point(34, 87);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(215, 212);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Controls.Add(btnDashboard);
            flowLayoutPanel1.Controls.Add(btnPatientInfo);
            flowLayoutPanel1.Controls.Add(btnAdmission);
            flowLayoutPanel1.Controls.Add(btnRooms);
            flowLayoutPanel1.Controls.Add(btnBilling);
            flowLayoutPanel1.Controls.Add(btnDischarge);
            flowLayoutPanel1.FlowDirection = FlowDirection.TopDown;
            flowLayoutPanel1.Location = new Point(3, 315);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(288, 680);
            flowLayoutPanel1.TabIndex = 8;
            // 
            // btnDashboard
            // 
            btnDashboard.BackColor = Color.LightGray;
            btnDashboard.FlatAppearance.BorderSize = 0;
            btnDashboard.Font = new Font("Microsoft JhengHei UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnDashboard.Location = new Point(20, 30);
            btnDashboard.Margin = new Padding(20, 30, 3, 3);
            btnDashboard.Name = "btnDashboard";
            btnDashboard.Size = new Size(248, 61);
            btnDashboard.TabIndex = 2;
            btnDashboard.Text = "Dashboard";
            btnDashboard.UseVisualStyleBackColor = false;
            btnDashboard.Click += button1_Click;
            // 
            // btnPatientInfo
            // 
            btnPatientInfo.Font = new Font("Microsoft JhengHei UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnPatientInfo.Location = new Point(20, 124);
            btnPatientInfo.Margin = new Padding(20, 30, 3, 3);
            btnPatientInfo.Name = "btnPatientInfo";
            btnPatientInfo.Size = new Size(248, 61);
            btnPatientInfo.TabIndex = 3;
            btnPatientInfo.Text = "Patient Information";
            btnPatientInfo.UseVisualStyleBackColor = true;
            btnPatientInfo.Click += button2_Click;
            // 
            // btnAdmission
            // 
            btnAdmission.Font = new Font("Microsoft JhengHei UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAdmission.Location = new Point(20, 218);
            btnAdmission.Margin = new Padding(20, 30, 3, 3);
            btnAdmission.Name = "btnAdmission";
            btnAdmission.Size = new Size(248, 61);
            btnAdmission.TabIndex = 5;
            btnAdmission.Text = "Admission";
            btnAdmission.UseVisualStyleBackColor = true;
            btnAdmission.Click += button4_Click;
            // 
            // btnRooms
            // 
            btnRooms.Font = new Font("Microsoft JhengHei UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnRooms.Location = new Point(20, 312);
            btnRooms.Margin = new Padding(20, 30, 3, 3);
            btnRooms.Name = "btnRooms";
            btnRooms.Size = new Size(248, 61);
            btnRooms.TabIndex = 4;
            btnRooms.Text = "Rooms";
            btnRooms.UseVisualStyleBackColor = true;
            // 
            // btnBilling
            // 
            btnBilling.Font = new Font("Microsoft JhengHei UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnBilling.Location = new Point(20, 406);
            btnBilling.Margin = new Padding(20, 30, 3, 3);
            btnBilling.Name = "btnBilling";
            btnBilling.Size = new Size(248, 61);
            btnBilling.TabIndex = 6;
            btnBilling.Text = "Billing";
            btnBilling.UseVisualStyleBackColor = true;
            // 
            // btnDischarge
            // 
            btnDischarge.Font = new Font("Microsoft JhengHei UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnDischarge.Location = new Point(20, 500);
            btnDischarge.Margin = new Padding(20, 30, 3, 3);
            btnDischarge.Name = "btnDischarge";
            btnDischarge.Size = new Size(248, 61);
            btnDischarge.TabIndex = 7;
            btnDischarge.Text = "Discharge";
            btnDischarge.UseVisualStyleBackColor = true;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.Modern_Minimalist_Black_and_White_Report_Presentation__19_;
            pictureBox2.Location = new Point(33, 66);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(1547, 863);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 2;
            pictureBox2.TabStop = false;
            // 
            // MainPanel
            // 
            MainPanel.Controls.Add(pictureBox2);
            MainPanel.Location = new Point(283, 84);
            MainPanel.Name = "MainPanel";
            MainPanel.Size = new Size(1637, 998);
            MainPanel.TabIndex = 3;
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(217, 217, 217);
            ClientSize = new Size(1920, 1080);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(MainPanel);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Dashboard";
            WindowState = FormWindowState.Maximized;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            flowLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            MainPanel.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Button btnDischarge;
        private Button btnBilling;
        private Button btnAdmission;
        private Button btnRooms;
        private Button btnPatientInfo;
        private Button btnDashboard;
        private PictureBox pictureBox1;
        private Button button7;
        private Label label14;
        private PictureBox pictureBox2;
        private Panel MainPanel;
        private FlowLayoutPanel flowLayoutPanel1;
    }
}