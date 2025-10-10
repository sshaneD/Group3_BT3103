namespace EventDriven.Project.UI.UserControlUI
{
    partial class Admission
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
            button8 = new Button();
            lblTitle = new Label();
            panel3 = new Panel();
            txtMN = new TextBox();
            label14 = new Label();
            btnCancel = new Button();
            cbRoomNo = new ComboBox();
            label13 = new Label();
            btnSubmit = new Button();
            label12 = new Label();
            txtDiagnosis = new TextBox();
            label11 = new Label();
            txtNurses = new TextBox();
            label10 = new Label();
            label9 = new Label();
            cbRoom = new ComboBox();
            txtDoctor = new TextBox();
            label8 = new Label();
            txtGCN = new TextBox();
            label7 = new Label();
            lblID = new Label();
            label6 = new Label();
            label2 = new Label();
            txtFN = new TextBox();
            label5 = new Label();
            cbGender = new ComboBox();
            txtGN = new TextBox();
            label4 = new Label();
            txtAge = new TextBox();
            label3 = new Label();
            txtLN = new TextBox();
            btnViewDN = new Button();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // button8
            // 
            button8.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button8.Location = new Point(1325, 81);
            button8.Name = "button8";
            button8.Size = new Size(251, 35);
            button8.TabIndex = 32;
            button8.Text = "View Admission History\r\n";
            button8.UseVisualStyleBackColor = true;
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Microsoft JhengHei UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitle.Location = new Point(79, 76);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(253, 38);
            lblTitle.TabIndex = 29;
            lblTitle.Text = "Admission Form";
            // 
            // panel3
            // 
            panel3.BackColor = Color.Silver;
            panel3.Controls.Add(txtMN);
            panel3.Controls.Add(label14);
            panel3.Controls.Add(btnCancel);
            panel3.Controls.Add(cbRoomNo);
            panel3.Controls.Add(label13);
            panel3.Controls.Add(btnSubmit);
            panel3.Controls.Add(label12);
            panel3.Controls.Add(txtDiagnosis);
            panel3.Controls.Add(label11);
            panel3.Controls.Add(txtNurses);
            panel3.Controls.Add(label10);
            panel3.Controls.Add(label9);
            panel3.Controls.Add(cbRoom);
            panel3.Controls.Add(txtDoctor);
            panel3.Controls.Add(label8);
            panel3.Controls.Add(txtGCN);
            panel3.Controls.Add(label7);
            panel3.Controls.Add(lblID);
            panel3.Controls.Add(label6);
            panel3.Controls.Add(label2);
            panel3.Controls.Add(txtFN);
            panel3.Controls.Add(label5);
            panel3.Controls.Add(cbGender);
            panel3.Controls.Add(txtGN);
            panel3.Controls.Add(label4);
            panel3.Controls.Add(txtAge);
            panel3.Controls.Add(label3);
            panel3.Controls.Add(txtLN);
            panel3.ForeColor = SystemColors.ActiveCaptionText;
            panel3.Location = new Point(105, 134);
            panel3.Name = "panel3";
            panel3.Size = new Size(1426, 826);
            panel3.TabIndex = 30;
            panel3.Paint += panel3_Paint;
            // 
            // txtMN
            // 
            txtMN.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtMN.Location = new Point(194, 227);
            txtMN.Multiline = true;
            txtMN.Name = "txtMN";
            txtMN.Size = new Size(412, 39);
            txtMN.TabIndex = 34;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.BackColor = Color.Transparent;
            label14.Font = new Font("Microsoft JhengHei UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label14.Location = new Point(194, 202);
            label14.Name = "label14";
            label14.Size = new Size(127, 22);
            label14.TabIndex = 33;
            label14.Text = "Middle Name:";
            // 
            // btnCancel
            // 
            btnCancel.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCancel.Location = new Point(1122, 760);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(134, 37);
            btnCancel.TabIndex = 31;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnADCancel_Click;
            // 
            // cbRoomNo
            // 
            cbRoomNo.FormattingEnabled = true;
            cbRoomNo.Items.AddRange(new object[] { "Female", "Male" });
            cbRoomNo.Location = new Point(992, 146);
            cbRoomNo.Name = "cbRoomNo";
            cbRoomNo.Size = new Size(177, 28);
            cbRoomNo.TabIndex = 30;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.BackColor = Color.Transparent;
            label13.Font = new Font("Microsoft JhengHei UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label13.Location = new Point(992, 121);
            label13.Name = "label13";
            label13.Size = new Size(92, 22);
            label13.TabIndex = 29;
            label13.Text = "Room No:";
            // 
            // btnSubmit
            // 
            btnSubmit.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSubmit.Location = new Point(1262, 760);
            btnSubmit.Name = "btnSubmit";
            btnSubmit.Size = new Size(134, 37);
            btnSubmit.TabIndex = 28;
            btnSubmit.Text = "Admit";
            btnSubmit.UseVisualStyleBackColor = true;
            btnSubmit.Click += btnSubmit_Click;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.BackColor = Color.Transparent;
            label12.Font = new Font("Microsoft JhengHei UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label12.Location = new Point(707, 387);
            label12.Name = "label12";
            label12.Size = new Size(176, 22);
            label12.TabIndex = 26;
            label12.Text = "Diagnosis/Remarks:";
            // 
            // txtDiagnosis
            // 
            txtDiagnosis.Location = new Point(707, 412);
            txtDiagnosis.Multiline = true;
            txtDiagnosis.Name = "txtDiagnosis";
            txtDiagnosis.Size = new Size(462, 298);
            txtDiagnosis.TabIndex = 25;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.BackColor = Color.Transparent;
            label11.Font = new Font("Microsoft JhengHei UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label11.Location = new Point(707, 287);
            label11.Name = "label11";
            label11.Size = new Size(80, 22);
            label11.TabIndex = 24;
            label11.Text = "Nurse/s:";
            // 
            // txtNurses
            // 
            txtNurses.Font = new Font("Segoe UI", 10.2F);
            txtNurses.Location = new Point(707, 312);
            txtNurses.Multiline = true;
            txtNurses.Name = "txtNurses";
            txtNurses.Size = new Size(462, 39);
            txtNurses.TabIndex = 23;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.BackColor = Color.Transparent;
            label10.Font = new Font("Microsoft JhengHei UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label10.Location = new Point(707, 202);
            label10.Name = "label10";
            label10.Size = new Size(88, 22);
            label10.TabIndex = 22;
            label10.Text = "Doctor/s:";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.BackColor = Color.Transparent;
            label9.Font = new Font("Microsoft JhengHei UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label9.Location = new Point(707, 121);
            label9.Name = "label9";
            label9.Size = new Size(63, 22);
            label9.TabIndex = 21;
            label9.Text = "Room:";
            // 
            // cbRoom
            // 
            cbRoom.FormattingEnabled = true;
            cbRoom.Items.AddRange(new object[] { "Ward", "Private Room", "Emergency Room", "Nursery Room", "Intensive Care Unit (ICU)", "Neonatal Intensive Care Unit (NICU)" });
            cbRoom.Location = new Point(707, 146);
            cbRoom.Name = "cbRoom";
            cbRoom.Size = new Size(268, 28);
            cbRoom.TabIndex = 20;
            // 
            // txtDoctor
            // 
            txtDoctor.Font = new Font("Segoe UI", 10.2F);
            txtDoctor.Location = new Point(707, 227);
            txtDoctor.Multiline = true;
            txtDoctor.Name = "txtDoctor";
            txtDoctor.Size = new Size(462, 39);
            txtDoctor.TabIndex = 19;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = Color.Transparent;
            label8.Font = new Font("Microsoft JhengHei UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.Location = new Point(198, 646);
            label8.Name = "label8";
            label8.Size = new Size(191, 22);
            label8.TabIndex = 18;
            label8.Text = "Guardian Contact No:";
            // 
            // txtGCN
            // 
            txtGCN.Location = new Point(194, 671);
            txtGCN.Multiline = true;
            txtGCN.Name = "txtGCN";
            txtGCN.Size = new Size(412, 39);
            txtGCN.TabIndex = 17;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.Transparent;
            label7.Font = new Font("Microsoft JhengHei UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(198, 549);
            label7.Name = "label7";
            label7.Size = new Size(146, 22);
            label7.TabIndex = 16;
            label7.Text = "Guardian Name:";
            // 
            // lblID
            // 
            lblID.AutoSize = true;
            lblID.BackColor = Color.Transparent;
            lblID.Font = new Font("Microsoft JhengHei UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblID.Location = new Point(232, 50);
            lblID.Name = "lblID";
            lblID.Size = new Size(69, 29);
            lblID.TabIndex = 15;
            lblID.Text = "1001";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.Transparent;
            label6.Font = new Font("Microsoft JhengHei UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(98, 50);
            label6.Name = "label6";
            label6.Size = new Size(128, 29);
            label6.TabIndex = 14;
            label6.Text = "Patient ID:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Microsoft JhengHei UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(194, 117);
            label2.Name = "label2";
            label2.Size = new Size(104, 22);
            label2.TabIndex = 6;
            label2.Text = "First Name:";
            // 
            // txtFN
            // 
            txtFN.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtFN.Location = new Point(194, 142);
            txtFN.Multiline = true;
            txtFN.Name = "txtFN";
            txtFN.Size = new Size(412, 39);
            txtFN.TabIndex = 4;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Microsoft JhengHei UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(198, 464);
            label5.Name = "label5";
            label5.Size = new Size(76, 22);
            label5.TabIndex = 13;
            label5.Text = "Gender:";
            // 
            // cbGender
            // 
            cbGender.FormattingEnabled = true;
            cbGender.Items.AddRange(new object[] { "Female", "Male" });
            cbGender.Location = new Point(194, 489);
            cbGender.Name = "cbGender";
            cbGender.Size = new Size(220, 28);
            cbGender.TabIndex = 12;
            // 
            // txtGN
            // 
            txtGN.Font = new Font("Segoe UI", 10.2F);
            txtGN.Location = new Point(194, 574);
            txtGN.Multiline = true;
            txtGN.Name = "txtGN";
            txtGN.Size = new Size(412, 39);
            txtGN.TabIndex = 11;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Microsoft JhengHei UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(198, 375);
            label4.Name = "label4";
            label4.Size = new Size(47, 22);
            label4.TabIndex = 10;
            label4.Text = "Age:";
            // 
            // txtAge
            // 
            txtAge.Font = new Font("Segoe UI", 10.2F);
            txtAge.Location = new Point(194, 400);
            txtAge.Multiline = true;
            txtAge.Name = "txtAge";
            txtAge.Size = new Size(220, 39);
            txtAge.TabIndex = 9;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Microsoft JhengHei UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(194, 287);
            label3.Name = "label3";
            label3.Size = new Size(102, 22);
            label3.TabIndex = 8;
            label3.Text = "Last Name:";
            // 
            // txtLN
            // 
            txtLN.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtLN.Location = new Point(194, 312);
            txtLN.Multiline = true;
            txtLN.Name = "txtLN";
            txtLN.Size = new Size(412, 39);
            txtLN.TabIndex = 5;
            // 
            // btnViewDN
            // 
            btnViewDN.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnViewDN.Location = new Point(1325, 40);
            btnViewDN.Name = "btnViewDN";
            btnViewDN.Size = new Size(251, 35);
            btnViewDN.TabIndex = 31;
            btnViewDN.Text = "View Nurse/Doctor";
            btnViewDN.UseVisualStyleBackColor = true;
            // 
            // Admission
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(button8);
            Controls.Add(lblTitle);
            Controls.Add(panel3);
            Controls.Add(btnViewDN);
            Name = "Admission";
            Size = new Size(1637, 998);
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button8;
        private Label lblTitle;
        private Panel panel3;
        private ComboBox cbRoomNo;
        private Label label13;
        private Button btnSubmit;
        private Label label12;
        private TextBox txtDiagnosis;
        private Label label11;
        private TextBox txtNurses;
        private Label label10;
        private Label label9;
        private ComboBox cbRoom;
        private TextBox txtDoctor;
        private Label label8;
        private TextBox txtGCN;
        private Label label7;
        private Label lblID;
        private Label label6;
        private Label label2;
        private TextBox txtFN;
        private Label label5;
        private ComboBox cbGender;
        private TextBox txtGN;
        private Label label4;
        private TextBox txtAge;
        private Label label3;
        private TextBox txtLN;
        private Button btnViewDN;
        private TextBox txtMN;
        private Label label14;
        private Button btnCancel;
    }
}
