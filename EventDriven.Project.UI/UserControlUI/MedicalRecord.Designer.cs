namespace EventDriven.Project.UI.UserControlUI
{
    partial class MedicalRecord
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
            label1 = new Label();
            panel1 = new Panel();
            lblGender = new Label();
            lblAge = new Label();
            lblPatientID = new Label();
            lblName = new Label();
            panelAssignment = new Panel();
            flowLayoutPanel4 = new FlowLayoutPanel();
            lblRoomType = new Label();
            lblRoomNum = new Label();
            lblDate = new Label();
            txtNurseList = new TextBox();
            txtDoctorList = new TextBox();
            label13 = new Label();
            label12 = new Label();
            panelDischarged = new Panel();
            label2 = new Label();
            panel7 = new Panel();
            flowMedicalRecords = new FlowLayoutPanel();
            btnDelete = new Button();
            label6 = new Label();
            txtDiagnosis = new TextBox();
            txtTreatment = new TextBox();
            txtMedication = new TextBox();
            label7 = new Label();
            label8 = new Label();
            txtNotes = new TextBox();
            label9 = new Label();
            btnExit = new Button();
            panel1.SuspendLayout();
            panelAssignment.SuspendLayout();
            flowLayoutPanel4.SuspendLayout();
            panelDischarged.SuspendLayout();
            panel7.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 17F, FontStyle.Bold);
            label1.Location = new Point(32, 30);
            label1.Name = "label1";
            label1.Size = new Size(229, 40);
            label1.TabIndex = 0;
            label1.Text = "Medical Record";
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(lblGender);
            panel1.Controls.Add(lblAge);
            panel1.Controls.Add(lblPatientID);
            panel1.Controls.Add(lblName);
            panel1.Location = new Point(32, 84);
            panel1.Name = "panel1";
            panel1.Size = new Size(1019, 209);
            panel1.TabIndex = 1;
            // 
            // lblGender
            // 
            lblGender.AutoSize = true;
            lblGender.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblGender.Location = new Point(29, 153);
            lblGender.Name = "lblGender";
            lblGender.Size = new Size(77, 28);
            lblGender.TabIndex = 3;
            lblGender.Text = "Female";
            // 
            // lblAge
            // 
            lblAge.AutoSize = true;
            lblAge.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblAge.Location = new Point(29, 114);
            lblAge.Name = "lblAge";
            lblAge.Size = new Size(122, 28);
            lblAge.TabIndex = 2;
            lblAge.Text = "21 Years Old";
            // 
            // lblPatientID
            // 
            lblPatientID.AutoSize = true;
            lblPatientID.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblPatientID.Location = new Point(29, 74);
            lblPatientID.Name = "lblPatientID";
            lblPatientID.Size = new Size(106, 28);
            lblPatientID.TabIndex = 1;
            lblPatientID.Text = "Patient ID:";
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Font = new Font("Segoe UI Semibold", 17F, FontStyle.Bold);
            lblName.Location = new Point(18, 23);
            lblName.Name = "lblName";
            lblName.Size = new Size(397, 40);
            lblName.TabIndex = 0;
            lblName.Text = "Stefanie Shane L Delos Reyes";
            // 
            // panelAssignment
            // 
            panelAssignment.BackColor = Color.White;
            panelAssignment.Controls.Add(flowLayoutPanel4);
            panelAssignment.Controls.Add(txtNurseList);
            panelAssignment.Controls.Add(txtDoctorList);
            panelAssignment.Controls.Add(label13);
            panelAssignment.Controls.Add(label12);
            panelAssignment.Controls.Add(panelDischarged);
            panelAssignment.Location = new Point(32, 307);
            panelAssignment.Name = "panelAssignment";
            panelAssignment.Size = new Size(1019, 172);
            panelAssignment.TabIndex = 2;
            // 
            // flowLayoutPanel4
            // 
            flowLayoutPanel4.Controls.Add(lblRoomType);
            flowLayoutPanel4.Controls.Add(lblRoomNum);
            flowLayoutPanel4.Controls.Add(lblDate);
            flowLayoutPanel4.FlowDirection = FlowDirection.TopDown;
            flowLayoutPanel4.Location = new Point(18, 21);
            flowLayoutPanel4.Name = "flowLayoutPanel4";
            flowLayoutPanel4.Size = new Size(314, 148);
            flowLayoutPanel4.TabIndex = 11;
            // 
            // lblRoomType
            // 
            lblRoomType.AutoSize = true;
            lblRoomType.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblRoomType.Location = new Point(3, 0);
            lblRoomType.Margin = new Padding(3, 0, 3, 10);
            lblRoomType.Name = "lblRoomType";
            lblRoomType.Size = new Size(302, 56);
            lblRoomType.TabIndex = 6;
            lblRoomType.Text = "Room Type: Neonatal Intensive Care Unit (NICU)";
            // 
            // lblRoomNum
            // 
            lblRoomNum.AutoSize = true;
            lblRoomNum.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblRoomNum.Location = new Point(3, 66);
            lblRoomNum.Margin = new Padding(3, 0, 3, 10);
            lblRoomNum.Name = "lblRoomNum";
            lblRoomNum.Size = new Size(257, 28);
            lblRoomNum.TabIndex = 5;
            lblRoomNum.Text = "Room Number: 301 (Bed 1)";
            // 
            // lblDate
            // 
            lblDate.AutoSize = true;
            lblDate.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblDate.Location = new Point(3, 104);
            lblDate.Margin = new Padding(3, 0, 3, 10);
            lblDate.Name = "lblDate";
            lblDate.Size = new Size(228, 28);
            lblDate.TabIndex = 4;
            lblDate.Text = "11/05/2025 - 11/06/2025";
            // 
            // txtNurseList
            // 
            txtNurseList.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold);
            txtNurseList.Location = new Point(676, 51);
            txtNurseList.Multiline = true;
            txtNurseList.Name = "txtNurseList";
            txtNurseList.ReadOnly = true;
            txtNurseList.Size = new Size(314, 95);
            txtNurseList.TabIndex = 10;
            // 
            // txtDoctorList
            // 
            txtDoctorList.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold);
            txtDoctorList.Location = new Point(338, 51);
            txtDoctorList.Multiline = true;
            txtDoctorList.Name = "txtDoctorList";
            txtDoctorList.ReadOnly = true;
            txtDoctorList.Size = new Size(314, 95);
            txtDoctorList.TabIndex = 0;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label13.Location = new Point(676, 20);
            label13.Name = "label13";
            label13.Size = new Size(80, 28);
            label13.TabIndex = 7;
            label13.Text = "Nurses:";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label12.Location = new Point(338, 20);
            label12.Name = "label12";
            label12.Size = new Size(87, 28);
            label12.TabIndex = 6;
            label12.Text = "Doctors:";
            // 
            // panelDischarged
            // 
            panelDischarged.Controls.Add(label2);
            panelDischarged.Location = new Point(0, 0);
            panelDischarged.Name = "panelDischarged";
            panelDischarged.Size = new Size(1019, 172);
            panelDischarged.TabIndex = 12;
            panelDischarged.Visible = false;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 15F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(386, 69);
            label2.Name = "label2";
            label2.Size = new Size(255, 35);
            label2.TabIndex = 0;
            label2.Text = "Patient is Discharged";
            // 
            // panel7
            // 
            panel7.BackColor = Color.White;
            panel7.Controls.Add(flowMedicalRecords);
            panel7.Location = new Point(1082, 84);
            panel7.Name = "panel7";
            panel7.Size = new Size(512, 868);
            panel7.TabIndex = 5;
            // 
            // flowMedicalRecords
            // 
            flowMedicalRecords.AutoScroll = true;
            flowMedicalRecords.Dock = DockStyle.Fill;
            flowMedicalRecords.FlowDirection = FlowDirection.TopDown;
            flowMedicalRecords.Location = new Point(0, 0);
            flowMedicalRecords.Name = "flowMedicalRecords";
            flowMedicalRecords.Size = new Size(512, 868);
            flowMedicalRecords.TabIndex = 0;
            flowMedicalRecords.WrapContents = false;
            // 
            // btnDelete
            // 
            btnDelete.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold);
            btnDelete.Location = new Point(907, 905);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(144, 47);
            btnDelete.TabIndex = 15;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Semibold", 14F, FontStyle.Bold);
            label6.Location = new Point(32, 494);
            label6.Name = "label6";
            label6.Size = new Size(124, 32);
            label6.TabIndex = 4;
            label6.Text = "Diagnosis:";
            label6.Click += label6_Click;
            // 
            // txtDiagnosis
            // 
            txtDiagnosis.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold);
            txtDiagnosis.Location = new Point(32, 538);
            txtDiagnosis.Multiline = true;
            txtDiagnosis.Name = "txtDiagnosis";
            txtDiagnosis.Size = new Size(306, 218);
            txtDiagnosis.TabIndex = 0;
            // 
            // txtTreatment
            // 
            txtTreatment.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold);
            txtTreatment.Location = new Point(383, 538);
            txtTreatment.Multiline = true;
            txtTreatment.Name = "txtTreatment";
            txtTreatment.Size = new Size(306, 218);
            txtTreatment.TabIndex = 6;
            // 
            // txtMedication
            // 
            txtMedication.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold);
            txtMedication.Location = new Point(745, 538);
            txtMedication.Multiline = true;
            txtMedication.Name = "txtMedication";
            txtMedication.Size = new Size(306, 218);
            txtMedication.TabIndex = 7;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI Semibold", 14F, FontStyle.Bold);
            label7.Location = new Point(383, 494);
            label7.Name = "label7";
            label7.Size = new Size(132, 32);
            label7.TabIndex = 8;
            label7.Text = "Treatment:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI Semibold", 14F, FontStyle.Bold);
            label8.Location = new Point(745, 494);
            label8.Name = "label8";
            label8.Size = new Size(142, 32);
            label8.TabIndex = 9;
            label8.Text = "Medication:";
            // 
            // txtNotes
            // 
            txtNotes.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold);
            txtNotes.Location = new Point(32, 806);
            txtNotes.Multiline = true;
            txtNotes.Name = "txtNotes";
            txtNotes.Size = new Size(855, 146);
            txtNotes.TabIndex = 10;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI Semibold", 14F, FontStyle.Bold);
            label9.Location = new Point(35, 769);
            label9.Name = "label9";
            label9.Size = new Size(84, 32);
            label9.TabIndex = 11;
            label9.Text = "Notes:";
            // 
            // btnExit
            // 
            btnExit.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold);
            btnExit.Location = new Point(1451, 28);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(144, 47);
            btnExit.TabIndex = 13;
            btnExit.Text = "Back";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // MedicalRecord
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(btnDelete);
            Controls.Add(btnExit);
            Controls.Add(label9);
            Controls.Add(txtNotes);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(txtMedication);
            Controls.Add(txtTreatment);
            Controls.Add(txtDiagnosis);
            Controls.Add(label6);
            Controls.Add(panel7);
            Controls.Add(panelAssignment);
            Controls.Add(panel1);
            Controls.Add(label1);
            Name = "MedicalRecord";
            Size = new Size(1637, 998);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panelAssignment.ResumeLayout(false);
            panelAssignment.PerformLayout();
            flowLayoutPanel4.ResumeLayout(false);
            flowLayoutPanel4.PerformLayout();
            panelDischarged.ResumeLayout(false);
            panelDischarged.PerformLayout();
            panel7.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Panel panel1;
        private Label lblName;
        private Label lblPatientID;
        private Label lblGender;
        private Label lblAge;
        private Panel panelAssignment;
        private Label label6;
        private Panel panel7;
        private TextBox txtDiagnosis;
        private TextBox txtTreatment;
        private TextBox txtMedication;
        private Label label7;
        private Label label11;
        private Label label10;
        private Label label8;
        private TextBox txtNotes;
        private Label label9;
        private FlowLayoutPanel flowLayoutPanel2;
        private Label label15;
        private Label label14;
        private Label label13;
        private Label label12;
        private Button btnExit;
        private FlowLayoutPanel flowMedicalRecords;
        private Button btnDelete;
        private TextBox txtDoctorList;
        private TextBox txtNurseList;
        private FlowLayoutPanel flowLayoutPanel4;
        private Label lblRoomType;
        private Label lblRoomNum;
        private Label lblDate;
        private Panel panelDischarged;
        private Label label2;
    }
}
