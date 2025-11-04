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
            label6 = new Label();
            label12 = new Label();
            dateEndDate = new DateTimePicker();
            dateStartDate = new DateTimePicker();
            txtNurse3 = new TextBox();
            dateOfBirth = new DateTimePicker();
            dateAdmission = new DateTimePicker();
            label1 = new Label();
            txtNurse = new TextBox();
            txtDoctor3 = new TextBox();
            txtDoctor2 = new TextBox();
            txtMN = new TextBox();
            label14 = new Label();
            btnCancel = new Button();
            cbRoomNo = new ComboBox();
            label13 = new Label();
            btnSubmit = new Button();
            label11 = new Label();
            txtNurse2 = new TextBox();
            label10 = new Label();
            label9 = new Label();
            cbRoom = new ComboBox();
            txtDoctor = new TextBox();
            label8 = new Label();
            txtGCN = new TextBox();
            label7 = new Label();
            label2 = new Label();
            txtFN = new TextBox();
            label5 = new Label();
            cbGender = new ComboBox();
            txtGN = new TextBox();
            label4 = new Label();
            label3 = new Label();
            txtLN = new TextBox();
            btnTreatment = new Button();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // button8
            // 
            button8.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold);
            button8.Location = new Point(1325, 81);
            button8.Name = "button8";
            button8.Size = new Size(251, 35);
            button8.TabIndex = 18;
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
            panel3.Controls.Add(label6);
            panel3.Controls.Add(label12);
            panel3.Controls.Add(dateEndDate);
            panel3.Controls.Add(dateStartDate);
            panel3.Controls.Add(txtNurse3);
            panel3.Controls.Add(dateOfBirth);
            panel3.Controls.Add(dateAdmission);
            panel3.Controls.Add(label1);
            panel3.Controls.Add(txtNurse);
            panel3.Controls.Add(txtDoctor3);
            panel3.Controls.Add(txtDoctor2);
            panel3.Controls.Add(txtMN);
            panel3.Controls.Add(label14);
            panel3.Controls.Add(btnCancel);
            panel3.Controls.Add(cbRoomNo);
            panel3.Controls.Add(label13);
            panel3.Controls.Add(btnSubmit);
            panel3.Controls.Add(label11);
            panel3.Controls.Add(txtNurse2);
            panel3.Controls.Add(label10);
            panel3.Controls.Add(label9);
            panel3.Controls.Add(cbRoom);
            panel3.Controls.Add(txtDoctor);
            panel3.Controls.Add(label8);
            panel3.Controls.Add(txtGCN);
            panel3.Controls.Add(label7);
            panel3.Controls.Add(label2);
            panel3.Controls.Add(txtFN);
            panel3.Controls.Add(label5);
            panel3.Controls.Add(cbGender);
            panel3.Controls.Add(txtGN);
            panel3.Controls.Add(label4);
            panel3.Controls.Add(label3);
            panel3.Controls.Add(txtLN);
            panel3.ForeColor = SystemColors.ActiveCaptionText;
            panel3.Location = new Point(105, 134);
            panel3.Name = "panel3";
            panel3.Size = new Size(1426, 826);
            panel3.TabIndex = 30;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.Transparent;
            label6.Font = new Font("Microsoft JhengHei UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(931, 188);
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
            label12.Location = new Point(707, 188);
            label12.Name = "label12";
            label12.Size = new Size(99, 22);
            label12.TabIndex = 43;
            label12.Text = "Start Date:";
            // 
            // dateEndDate
            // 
            dateEndDate.Checked = false;
            dateEndDate.Format = DateTimePickerFormat.Short;
            dateEndDate.Location = new Point(931, 213);
            dateEndDate.Name = "dateEndDate";
            dateEndDate.ShowCheckBox = true;
            dateEndDate.Size = new Size(238, 27);
            dateEndDate.TabIndex = 42;
            // 
            // dateStartDate
            // 
            dateStartDate.Format = DateTimePickerFormat.Short;
            dateStartDate.Location = new Point(707, 213);
            dateStartDate.Name = "dateStartDate";
            dateStartDate.Size = new Size(218, 27);
            dateStartDate.TabIndex = 41;
            // 
            // txtNurse3
            // 
            txtNurse3.Cursor = Cursors.Hand;
            txtNurse3.Font = new Font("Segoe UI", 10.2F);
            txtNurse3.Location = new Point(707, 663);
            txtNurse3.Multiline = true;
            txtNurse3.Name = "txtNurse3";
            txtNurse3.ReadOnly = true;
            txtNurse3.Size = new Size(462, 39);
            txtNurse3.TabIndex = 40;
            txtNurse3.Click += txtNurse_Click;
            // 
            // dateOfBirth
            // 
            dateOfBirth.Font = new Font("Microsoft JhengHei UI", 10.2F, FontStyle.Bold);
            dateOfBirth.Format = DateTimePickerFormat.Short;
            dateOfBirth.Location = new Point(194, 404);
            dateOfBirth.Name = "dateOfBirth";
            dateOfBirth.Size = new Size(220, 29);
            dateOfBirth.TabIndex = 5;
            // 
            // dateAdmission
            // 
            dateAdmission.Format = DateTimePickerFormat.Short;
            dateAdmission.Location = new Point(1273, 39);
            dateAdmission.Name = "dateAdmission";
            dateAdmission.Size = new Size(110, 27);
            dateAdmission.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft JhengHei UI", 10.2F, FontStyle.Bold);
            label1.Location = new Point(1122, 41);
            label1.Name = "label1";
            label1.Size = new Size(145, 22);
            label1.TabIndex = 39;
            label1.Text = "Admission Date:";
            // 
            // txtNurse
            // 
            txtNurse.Cursor = Cursors.Hand;
            txtNurse.Font = new Font("Segoe UI", 10.2F);
            txtNurse.Location = new Point(707, 511);
            txtNurse.Multiline = true;
            txtNurse.Name = "txtNurse";
            txtNurse.ReadOnly = true;
            txtNurse.Size = new Size(462, 39);
            txtNurse.TabIndex = 14;
            txtNurse.Click += txtNurse_Click;
            // 
            // txtDoctor3
            // 
            txtDoctor3.Cursor = Cursors.Hand;
            txtDoctor3.Font = new Font("Segoe UI", 10.2F);
            txtDoctor3.Location = new Point(707, 435);
            txtDoctor3.Multiline = true;
            txtDoctor3.Name = "txtDoctor3";
            txtDoctor3.ReadOnly = true;
            txtDoctor3.Size = new Size(462, 39);
            txtDoctor3.TabIndex = 13;
            txtDoctor3.Click += txtDoctor_Click;
            // 
            // txtDoctor2
            // 
            txtDoctor2.Cursor = Cursors.Hand;
            txtDoctor2.Font = new Font("Segoe UI", 10.2F);
            txtDoctor2.Location = new Point(707, 359);
            txtDoctor2.Multiline = true;
            txtDoctor2.Name = "txtDoctor2";
            txtDoctor2.ReadOnly = true;
            txtDoctor2.Size = new Size(462, 39);
            txtDoctor2.TabIndex = 12;
            txtDoctor2.Click += txtDoctor_Click;
            // 
            // txtMN
            // 
            txtMN.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtMN.Location = new Point(194, 227);
            txtMN.Multiline = true;
            txtMN.Name = "txtMN";
            txtMN.Size = new Size(412, 39);
            txtMN.TabIndex = 3;
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
            btnCancel.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCancel.Location = new Point(1122, 760);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(134, 37);
            btnCancel.TabIndex = 19;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnADCancel_Click;
            // 
            // cbRoomNo
            // 
            cbRoomNo.DropDownStyle = ComboBoxStyle.DropDownList;
            cbRoomNo.FormattingEnabled = true;
            cbRoomNo.Location = new Point(992, 146);
            cbRoomNo.Name = "cbRoomNo";
            cbRoomNo.Size = new Size(177, 28);
            cbRoomNo.TabIndex = 10;
            cbRoomNo.SelectedIndexChanged += cbRoomNo_SelectedIndexChanged;
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
            btnSubmit.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSubmit.Location = new Point(1262, 760);
            btnSubmit.Name = "btnSubmit";
            btnSubmit.Size = new Size(134, 37);
            btnSubmit.TabIndex = 20;
            btnSubmit.Text = "Admit";
            btnSubmit.UseVisualStyleBackColor = true;
            btnSubmit.Click += btnSubmit_Click;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.BackColor = Color.Transparent;
            label11.Font = new Font("Microsoft JhengHei UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label11.Location = new Point(707, 486);
            label11.Name = "label11";
            label11.Size = new Size(80, 22);
            label11.TabIndex = 24;
            label11.Text = "Nurse/s:";
            // 
            // txtNurse2
            // 
            txtNurse2.Cursor = Cursors.Hand;
            txtNurse2.Font = new Font("Segoe UI", 10.2F);
            txtNurse2.Location = new Point(707, 587);
            txtNurse2.Multiline = true;
            txtNurse2.Name = "txtNurse2";
            txtNurse2.ReadOnly = true;
            txtNurse2.Size = new Size(462, 39);
            txtNurse2.TabIndex = 15;
            txtNurse2.Click += txtNurse_Click;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.BackColor = Color.Transparent;
            label10.Font = new Font("Microsoft JhengHei UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label10.Location = new Point(707, 258);
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
            cbRoom.DropDownStyle = ComboBoxStyle.DropDownList;
            cbRoom.FormattingEnabled = true;
            cbRoom.Items.AddRange(new object[] { "Ward", "Private Room", "Emergency Room", "Nursery Room", "Intensive Care Unit (ICU)", "Neonatal Intensive Care Unit (NICU)" });
            cbRoom.Location = new Point(707, 146);
            cbRoom.Name = "cbRoom";
            cbRoom.Size = new Size(268, 28);
            cbRoom.TabIndex = 9;
            cbRoom.SelectedIndexChanged += cbRoom_SelectedIndexChanged;
            // 
            // txtDoctor
            // 
            txtDoctor.Cursor = Cursors.Hand;
            txtDoctor.Font = new Font("Segoe UI", 10.2F);
            txtDoctor.Location = new Point(707, 283);
            txtDoctor.Multiline = true;
            txtDoctor.Name = "txtDoctor";
            txtDoctor.ReadOnly = true;
            txtDoctor.Size = new Size(462, 39);
            txtDoctor.TabIndex = 11;
            txtDoctor.Click += txtDoctor_Click;
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
            txtGCN.TabIndex = 8;
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
            txtFN.TabIndex = 2;
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
            cbGender.DropDownStyle = ComboBoxStyle.DropDownList;
            cbGender.FormattingEnabled = true;
            cbGender.Items.AddRange(new object[] { "Female", "Male" });
            cbGender.Location = new Point(194, 489);
            cbGender.Name = "cbGender";
            cbGender.Size = new Size(220, 28);
            cbGender.TabIndex = 6;
            // 
            // txtGN
            // 
            txtGN.Font = new Font("Segoe UI", 10.2F);
            txtGN.Location = new Point(194, 579);
            txtGN.Multiline = true;
            txtGN.Name = "txtGN";
            txtGN.Size = new Size(412, 39);
            txtGN.TabIndex = 7;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Microsoft JhengHei UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(198, 375);
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
            txtLN.TabIndex = 4;
            // 
            // btnTreatment
            // 
            btnTreatment.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold);
            btnTreatment.Location = new Point(1325, 40);
            btnTreatment.Name = "btnTreatment";
            btnTreatment.Size = new Size(251, 35);
            btnTreatment.TabIndex = 17;
            btnTreatment.Text = "Treatment";
            btnTreatment.UseVisualStyleBackColor = true;
            btnTreatment.Click += btnViewDN_Click;
            // 
            // Admission
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(button8);
            Controls.Add(lblTitle);
            Controls.Add(panel3);
            Controls.Add(btnTreatment);
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
    }
}
