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
            btnViewAdmissionHistory = new Button();
            lblTitle = new Label();
            panel3 = new Panel();
            label18 = new Label();
            panel5 = new Panel();
            label8 = new Label();
            label7 = new Label();
            txtGCN = new TextBox();
            txtGN = new TextBox();
            label17 = new Label();
            label16 = new Label();
            panel4 = new Panel();
            cbRoomNo = new ComboBox();
            label6 = new Label();
            label12 = new Label();
            dateEndDate = new DateTimePicker();
            dateStartDate = new DateTimePicker();
            label13 = new Label();
            label9 = new Label();
            cbRoom = new ComboBox();
            panel2 = new Panel();
            txtNurse3 = new TextBox();
            txtNurse = new TextBox();
            txtDoctor3 = new TextBox();
            txtDoctor2 = new TextBox();
            label11 = new Label();
            txtNurse2 = new TextBox();
            label10 = new Label();
            txtDoctor = new TextBox();
            label15 = new Label();
            panel1 = new Panel();
            dateOfBirth = new DateTimePicker();
            txtMN = new TextBox();
            label14 = new Label();
            label2 = new Label();
            txtFN = new TextBox();
            label5 = new Label();
            cbGender = new ComboBox();
            label4 = new Label();
            label3 = new Label();
            txtLN = new TextBox();
            dateAdmission = new DateTimePicker();
            label1 = new Label();
            btnCancel = new Button();
            btnSubmit = new Button();
            btnTreatment = new Button();
            panel3.SuspendLayout();
            panel5.SuspendLayout();
            panel4.SuspendLayout();
            panel2.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // btnViewAdmissionHistory
            // 
            btnViewAdmissionHistory.BackColor = Color.FromArgb(11, 143, 172);
            btnViewAdmissionHistory.FlatStyle = FlatStyle.Flat;
            btnViewAdmissionHistory.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold);
            btnViewAdmissionHistory.ForeColor = Color.White;
            btnViewAdmissionHistory.Location = new Point(1343, 73);
            btnViewAdmissionHistory.Name = "btnViewAdmissionHistory";
            btnViewAdmissionHistory.Size = new Size(251, 35);
            btnViewAdmissionHistory.TabIndex = 18;
            btnViewAdmissionHistory.Text = "View Admission History\r\n";
            btnViewAdmissionHistory.UseVisualStyleBackColor = false;
            btnViewAdmissionHistory.Click += btnViewAdmissionHistory_Click;
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitle.Location = new Point(32, 46);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(281, 46);
            lblTitle.TabIndex = 29;
            lblTitle.Text = "Admission Form";
            // 
            // panel3
            // 
            panel3.BackColor = Color.Gainsboro;
            panel3.Controls.Add(label18);
            panel3.Controls.Add(panel5);
            panel3.Controls.Add(label17);
            panel3.Controls.Add(label16);
            panel3.Controls.Add(panel4);
            panel3.Controls.Add(panel2);
            panel3.Controls.Add(label15);
            panel3.Controls.Add(panel1);
            panel3.Controls.Add(dateAdmission);
            panel3.Controls.Add(label1);
            panel3.Controls.Add(btnCancel);
            panel3.Controls.Add(btnSubmit);
            panel3.ForeColor = SystemColors.ActiveCaptionText;
            panel3.Location = new Point(32, 123);
            panel3.Name = "panel3";
            panel3.Size = new Size(1562, 831);
            panel3.TabIndex = 30;
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.Font = new Font("Segoe UI Semibold", 15F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label18.Location = new Point(953, 45);
            label18.Name = "label18";
            label18.Size = new Size(242, 35);
            label18.TabIndex = 52;
            label18.Text = "Emergency Contact:";
            // 
            // panel5
            // 
            panel5.BackColor = SystemColors.Control;
            panel5.Controls.Add(label8);
            panel5.Controls.Add(label7);
            panel5.Controls.Add(txtGCN);
            panel5.Controls.Add(txtGN);
            panel5.Location = new Point(961, 91);
            panel5.Name = "panel5";
            panel5.Size = new Size(527, 336);
            panel5.TabIndex = 51;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = Color.Transparent;
            label8.Font = new Font("Microsoft JhengHei UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.Location = new Point(20, 156);
            label8.Name = "label8";
            label8.Size = new Size(191, 22);
            label8.TabIndex = 18;
            label8.Text = "Guardian Contact No:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.Transparent;
            label7.Font = new Font("Microsoft JhengHei UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(20, 56);
            label7.Name = "label7";
            label7.Size = new Size(146, 22);
            label7.TabIndex = 16;
            label7.Text = "Guardian Name:";
            // 
            // txtGCN
            // 
            txtGCN.Location = new Point(20, 193);
            txtGCN.Multiline = true;
            txtGCN.Name = "txtGCN";
            txtGCN.Size = new Size(482, 39);
            txtGCN.TabIndex = 8;
            // 
            // txtGN
            // 
            txtGN.Font = new Font("Segoe UI", 10.2F);
            txtGN.Location = new Point(20, 85);
            txtGN.Multiline = true;
            txtGN.Name = "txtGN";
            txtGN.Size = new Size(482, 39);
            txtGN.TabIndex = 7;
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Font = new Font("Segoe UI Semibold", 15F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label17.Location = new Point(971, 448);
            label17.Name = "label17";
            label17.Size = new Size(82, 35);
            label17.TabIndex = 50;
            label17.Text = "Room";
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Font = new Font("Segoe UI Semibold", 15F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label16.Location = new Point(31, 448);
            label16.Name = "label16";
            label16.Size = new Size(170, 35);
            label16.TabIndex = 49;
            label16.Text = "Doctor/Nurse";
            // 
            // panel4
            // 
            panel4.BackColor = SystemColors.Control;
            panel4.Controls.Add(cbRoomNo);
            panel4.Controls.Add(label6);
            panel4.Controls.Add(label12);
            panel4.Controls.Add(dateEndDate);
            panel4.Controls.Add(dateStartDate);
            panel4.Controls.Add(label13);
            panel4.Controls.Add(label9);
            panel4.Controls.Add(cbRoom);
            panel4.Location = new Point(971, 494);
            panel4.Name = "panel4";
            panel4.Size = new Size(517, 248);
            panel4.TabIndex = 48;
            // 
            // cbRoomNo
            // 
            cbRoomNo.DropDownStyle = ComboBoxStyle.DropDownList;
            cbRoomNo.FormattingEnabled = true;
            cbRoomNo.Items.AddRange(new object[] { "Ward", "Private Room", "Emergency Room", "Nursery Room", "Intensive Care Unit (ICU)", "Neonatal Intensive Care Unit (NICU)" });
            cbRoomNo.Location = new Point(295, 64);
            cbRoomNo.Name = "cbRoomNo";
            cbRoomNo.Size = new Size(177, 28);
            cbRoomNo.TabIndex = 45;
            cbRoomNo.SelectedIndexChanged += cbRoomNo_SelectedIndexChanged;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.Transparent;
            label6.Font = new Font("Microsoft JhengHei UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(251, 111);
            label6.Name = "label6";
            label6.Size = new Size(89, 22);
            label6.TabIndex = 44;
            label6.Text = "End Date:";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.BackColor = Color.Transparent;
            label12.Font = new Font("Microsoft JhengHei UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label12.Location = new Point(21, 111);
            label12.Name = "label12";
            label12.Size = new Size(99, 22);
            label12.TabIndex = 43;
            label12.Text = "Start Date:";
            // 
            // dateEndDate
            // 
            dateEndDate.Checked = false;
            dateEndDate.Format = DateTimePickerFormat.Short;
            dateEndDate.Location = new Point(251, 136);
            dateEndDate.Name = "dateEndDate";
            dateEndDate.ShowCheckBox = true;
            dateEndDate.Size = new Size(221, 27);
            dateEndDate.TabIndex = 42;
            // 
            // dateStartDate
            // 
            dateStartDate.Format = DateTimePickerFormat.Short;
            dateStartDate.Location = new Point(21, 136);
            dateStartDate.Name = "dateStartDate";
            dateStartDate.Size = new Size(218, 27);
            dateStartDate.TabIndex = 41;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.BackColor = Color.Transparent;
            label13.Font = new Font("Microsoft JhengHei UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label13.Location = new Point(295, 39);
            label13.Name = "label13";
            label13.Size = new Size(92, 22);
            label13.TabIndex = 29;
            label13.Text = "Room No:";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.BackColor = Color.Transparent;
            label9.Font = new Font("Microsoft JhengHei UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label9.Location = new Point(21, 39);
            label9.Name = "label9";
            label9.Size = new Size(63, 22);
            label9.TabIndex = 21;
            label9.Text = "Room:";
            // 
            // cbRoom
            // 
            cbRoom.DropDownStyle = ComboBoxStyle.DropDownList;
            cbRoom.FormattingEnabled = true;
            cbRoom.Items.AddRange(new object[] { "Ward", "Private Room", "Emergency Room", "Nursery Room", "Intensive Care Unit (ICU)", "Neonatal Intensive Care Unit (NICU)" });
            cbRoom.Location = new Point(21, 64);
            cbRoom.Name = "cbRoom";
            cbRoom.Size = new Size(268, 28);
            cbRoom.TabIndex = 9;
            cbRoom.SelectedIndexChanged += cbRoom_SelectedIndexChanged;
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.Control;
            panel2.Controls.Add(txtNurse3);
            panel2.Controls.Add(txtNurse);
            panel2.Controls.Add(txtDoctor3);
            panel2.Controls.Add(txtDoctor2);
            panel2.Controls.Add(label11);
            panel2.Controls.Add(txtNurse2);
            panel2.Controls.Add(label10);
            panel2.Controls.Add(txtDoctor);
            panel2.Location = new Point(26, 494);
            panel2.Name = "panel2";
            panel2.Size = new Size(897, 307);
            panel2.TabIndex = 47;
            // 
            // txtNurse3
            // 
            txtNurse3.BackColor = SystemColors.Window;
            txtNurse3.Cursor = Cursors.Hand;
            txtNurse3.Font = new Font("Segoe UI", 10.2F);
            txtNurse3.Location = new Point(434, 209);
            txtNurse3.Multiline = true;
            txtNurse3.Name = "txtNurse3";
            txtNurse3.ReadOnly = true;
            txtNurse3.Size = new Size(395, 39);
            txtNurse3.TabIndex = 40;
            txtNurse3.TabStop = false;
            txtNurse3.Click += txtNurse_Click;
            txtNurse3.Enter += removeFocus;
            // 
            // txtNurse
            // 
            txtNurse.BackColor = SystemColors.Window;
            txtNurse.Cursor = Cursors.Hand;
            txtNurse.Font = new Font("Segoe UI", 10.2F);
            txtNurse.Location = new Point(434, 71);
            txtNurse.Multiline = true;
            txtNurse.Name = "txtNurse";
            txtNurse.ReadOnly = true;
            txtNurse.Size = new Size(395, 39);
            txtNurse.TabIndex = 14;
            txtNurse.TabStop = false;
            txtNurse.Click += txtNurse_Click;
            txtNurse.Enter += removeFocus;
            // 
            // txtDoctor3
            // 
            txtDoctor3.BackColor = SystemColors.Window;
            txtDoctor3.Cursor = Cursors.Hand;
            txtDoctor3.Font = new Font("Segoe UI", 10.2F);
            txtDoctor3.Location = new Point(19, 209);
            txtDoctor3.Multiline = true;
            txtDoctor3.Name = "txtDoctor3";
            txtDoctor3.ReadOnly = true;
            txtDoctor3.Size = new Size(395, 39);
            txtDoctor3.TabIndex = 13;
            txtDoctor3.TabStop = false;
            txtDoctor3.Click += txtDoctor_Click;
            txtDoctor3.Enter += removeFocus;
            // 
            // txtDoctor2
            // 
            txtDoctor2.BackColor = SystemColors.Window;
            txtDoctor2.Cursor = Cursors.Hand;
            txtDoctor2.Font = new Font("Segoe UI", 10.2F);
            txtDoctor2.Location = new Point(19, 138);
            txtDoctor2.Multiline = true;
            txtDoctor2.Name = "txtDoctor2";
            txtDoctor2.ReadOnly = true;
            txtDoctor2.Size = new Size(395, 39);
            txtDoctor2.TabIndex = 12;
            txtDoctor2.TabStop = false;
            txtDoctor2.Click += txtDoctor_Click;
            txtDoctor2.Enter += removeFocus;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.BackColor = Color.Transparent;
            label11.Font = new Font("Microsoft JhengHei UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label11.Location = new Point(434, 41);
            label11.Name = "label11";
            label11.Size = new Size(80, 22);
            label11.TabIndex = 24;
            label11.Text = "Nurse/s:";
            // 
            // txtNurse2
            // 
            txtNurse2.BackColor = SystemColors.Window;
            txtNurse2.Cursor = Cursors.Hand;
            txtNurse2.Font = new Font("Segoe UI", 10.2F);
            txtNurse2.Location = new Point(434, 138);
            txtNurse2.Multiline = true;
            txtNurse2.Name = "txtNurse2";
            txtNurse2.ReadOnly = true;
            txtNurse2.Size = new Size(395, 39);
            txtNurse2.TabIndex = 15;
            txtNurse2.TabStop = false;
            txtNurse2.Click += txtNurse_Click;
            txtNurse2.Enter += removeFocus;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.BackColor = Color.Transparent;
            label10.Font = new Font("Microsoft JhengHei UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label10.Location = new Point(29, 41);
            label10.Name = "label10";
            label10.Size = new Size(88, 22);
            label10.TabIndex = 22;
            label10.Text = "Doctor/s:";
            // 
            // txtDoctor
            // 
            txtDoctor.BackColor = SystemColors.Window;
            txtDoctor.Cursor = Cursors.Hand;
            txtDoctor.Font = new Font("Segoe UI", 10.2F);
            txtDoctor.Location = new Point(19, 71);
            txtDoctor.Multiline = true;
            txtDoctor.Name = "txtDoctor";
            txtDoctor.ReadOnly = true;
            txtDoctor.Size = new Size(395, 39);
            txtDoctor.TabIndex = 11;
            txtDoctor.TabStop = false;
            txtDoctor.Click += txtDoctor_Click;
            txtDoctor.Enter += removeFocus;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Font = new Font("Segoe UI Semibold", 17F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label15.Location = new Point(31, 42);
            label15.Name = "label15";
            label15.Size = new Size(272, 40);
            label15.TabIndex = 31;
            label15.Text = "Patient Information";
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.Control;
            panel1.Controls.Add(dateOfBirth);
            panel1.Controls.Add(txtMN);
            panel1.Controls.Add(label14);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(txtFN);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(cbGender);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(txtLN);
            panel1.Location = new Point(26, 91);
            panel1.Name = "panel1";
            panel1.Size = new Size(902, 336);
            panel1.TabIndex = 46;
            // 
            // dateOfBirth
            // 
            dateOfBirth.Font = new Font("Microsoft JhengHei UI", 10.2F, FontStyle.Bold);
            dateOfBirth.Format = DateTimePickerFormat.Short;
            dateOfBirth.Location = new Point(586, 87);
            dateOfBirth.Name = "dateOfBirth";
            dateOfBirth.Size = new Size(215, 29);
            dateOfBirth.TabIndex = 5;
            // 
            // txtMN
            // 
            txtMN.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtMN.Location = new Point(57, 163);
            txtMN.Multiline = true;
            txtMN.Name = "txtMN";
            txtMN.Size = new Size(475, 39);
            txtMN.TabIndex = 3;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.BackColor = Color.Transparent;
            label14.Font = new Font("Microsoft JhengHei UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label14.Location = new Point(57, 138);
            label14.Name = "label14";
            label14.Size = new Size(127, 22);
            label14.TabIndex = 33;
            label14.Text = "Middle Name:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Microsoft JhengHei UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(57, 57);
            label2.Name = "label2";
            label2.Size = new Size(104, 22);
            label2.TabIndex = 6;
            label2.Text = "First Name:";
            // 
            // txtFN
            // 
            txtFN.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtFN.Location = new Point(57, 81);
            txtFN.Multiline = true;
            txtFN.Name = "txtFN";
            txtFN.Size = new Size(475, 39);
            txtFN.TabIndex = 2;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Microsoft JhengHei UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(586, 138);
            label5.Name = "label5";
            label5.Size = new Size(76, 22);
            label5.TabIndex = 13;
            label5.Text = "Gender:";
            // 
            // cbGender
            // 
            cbGender.DropDownStyle = ComboBoxStyle.DropDownList;
            cbGender.FormattingEnabled = true;
            cbGender.Items.AddRange(new object[] { "Female", "Male" });
            cbGender.Location = new Point(586, 163);
            cbGender.Name = "cbGender";
            cbGender.Size = new Size(220, 28);
            cbGender.TabIndex = 6;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Microsoft JhengHei UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(586, 57);
            label4.Name = "label4";
            label4.Size = new Size(99, 22);
            label4.TabIndex = 10;
            label4.Text = "Birth Date:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Microsoft JhengHei UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(59, 214);
            label3.Name = "label3";
            label3.Size = new Size(102, 22);
            label3.TabIndex = 8;
            label3.Text = "Last Name:";
            // 
            // txtLN
            // 
            txtLN.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtLN.Location = new Point(57, 239);
            txtLN.Multiline = true;
            txtLN.Name = "txtLN";
            txtLN.Size = new Size(473, 39);
            txtLN.TabIndex = 4;
            // 
            // dateAdmission
            // 
            dateAdmission.Format = DateTimePickerFormat.Short;
            dateAdmission.Location = new Point(1428, 27);
            dateAdmission.Name = "dateAdmission";
            dateAdmission.Size = new Size(110, 27);
            dateAdmission.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft JhengHei UI", 10.2F, FontStyle.Bold);
            label1.Location = new Point(1277, 31);
            label1.Name = "label1";
            label1.Size = new Size(145, 22);
            label1.TabIndex = 39;
            label1.Text = "Admission Date:";
            // 
            // btnCancel
            // 
            btnCancel.BackColor = Color.FromArgb(11, 143, 172);
            btnCancel.FlatAppearance.BorderSize = 0;
            btnCancel.FlatStyle = FlatStyle.Flat;
            btnCancel.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCancel.ForeColor = Color.White;
            btnCancel.Location = new Point(1214, 768);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(134, 37);
            btnCancel.TabIndex = 19;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = false;
            btnCancel.Click += btnADCancel_Click;
            // 
            // btnSubmit
            // 
            btnSubmit.BackColor = Color.FromArgb(11, 143, 172);
            btnSubmit.FlatAppearance.BorderSize = 0;
            btnSubmit.FlatStyle = FlatStyle.Flat;
            btnSubmit.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSubmit.ForeColor = Color.White;
            btnSubmit.Location = new Point(1354, 768);
            btnSubmit.Name = "btnSubmit";
            btnSubmit.Size = new Size(134, 37);
            btnSubmit.TabIndex = 20;
            btnSubmit.Text = "Admit";
            btnSubmit.UseVisualStyleBackColor = false;
            btnSubmit.Click += btnSubmit_Click;
            // 
            // btnTreatment
            // 
            btnTreatment.BackColor = Color.FromArgb(11, 143, 172);
            btnTreatment.FlatStyle = FlatStyle.Flat;
            btnTreatment.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold);
            btnTreatment.ForeColor = Color.White;
            btnTreatment.Location = new Point(1343, 32);
            btnTreatment.Name = "btnTreatment";
            btnTreatment.Size = new Size(251, 35);
            btnTreatment.TabIndex = 17;
            btnTreatment.Text = "Add Medical Details";
            btnTreatment.UseVisualStyleBackColor = false;
            btnTreatment.Click += btnViewDN_Click;
            // 
            // Admission
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(btnViewAdmissionHistory);
            Controls.Add(lblTitle);
            Controls.Add(panel3);
            Controls.Add(btnTreatment);
            Name = "Admission";
            Size = new Size(1637, 998);
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnViewAdmissionHistory;
        private Label lblTitle;
        private Panel panel3;
        private Label label13;
        private Button btnSubmit;
        private Label label11;
        private TextBox txtNurse2;
        private Label label10;
        private Label label9;
        private ComboBox cbRoom;
        private TextBox txtDoctor;
        private Label label8;
        private TextBox txtGCN;
        private Label label7;
        private Label label2;
        private TextBox txtFN;
        private Label label5;
        private ComboBox cbGender;
        private TextBox txtGN;
        private Label label4;
        private Label label3;
        private TextBox txtLN;
        private Button btnTreatment;
        private TextBox txtMN;
        private Label label14;
        private Button btnCancel;
        private TextBox txtDoctor2;
        private TextBox txtNurse;
        private TextBox txtDoctor3;
        private Label label1;
        private DateTimePicker dateOfBirth;
        private DateTimePicker dateAdmission;
        private TextBox txtNurse3;
        private DateTimePicker dateEndDate;
        private DateTimePicker dateStartDate;
        private Label label6;
        private Label label12;
        private ComboBox cbRoomNo;
        private Label label15;
        private Panel panel1;
        private Panel panel4;
        private Panel panel2;
        private Label label17;
        private Label label16;
        private Label label18;
        private Panel panel5;
    }
}
