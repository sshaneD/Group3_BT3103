namespace EventDriven.Project.UI.UserControlUI
{
    partial class Discharge
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Discharge));
            label1 = new Label();
            label3 = new Label();
            lblPatientName = new Label();
            roundedPanel1 = new RoundedPanel();
            lblAdmissionDate = new Label();
            label9 = new Label();
            lblRoomName = new Label();
            label7 = new Label();
            lblPatientID = new Label();
            label5 = new Label();
            roundedPanel2 = new RoundedPanel();
            txtNotes = new TextBox();
            txtTreatment = new TextBox();
            txtDiagnosis = new TextBox();
            label17 = new Label();
            label16 = new Label();
            label15 = new Label();
            txtDuration = new TextBox();
            txtFrequency = new TextBox();
            txtMedication = new TextBox();
            label2 = new Label();
            label12 = new Label();
            label14 = new Label();
            label18 = new Label();
            roundedPanel4 = new RoundedPanel();
            txtBalance = new TextBox();
            lblStatus = new Label();
            txtTotal = new TextBox();
            label22 = new Label();
            label21 = new Label();
            label19 = new Label();
            label13 = new Label();
            btnDischarge = new Button();
            txtSearch = new TextBox();
            btnSearch = new Button();
            btnID = new Button();
            panel1 = new Panel();
            roundedPanel3 = new RoundedPanel();
            panel2 = new Panel();
            btnPrint = new Button();
            printDocument1 = new System.Drawing.Printing.PrintDocument();
            printPreviewDialog1 = new PrintPreviewDialog();
            flowLayoutPanel1 = new FlowLayoutPanel();
            roundedPanel1.SuspendLayout();
            roundedPanel2.SuspendLayout();
            roundedPanel4.SuspendLayout();
            panel1.SuspendLayout();
            roundedPanel3.SuspendLayout();
            panel2.SuspendLayout();
            flowLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(123, 37);
            label1.Name = "label1";
            label1.Size = new Size(281, 38);
            label1.TabIndex = 0;
            label1.Text = "Discharge Summary";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 14.5F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(109, 26);
            label3.Name = "label3";
            label3.Size = new Size(238, 35);
            label3.TabIndex = 1;
            label3.Text = "Patient Information";
            // 
            // lblPatientName
            // 
            lblPatientName.AutoSize = true;
            lblPatientName.Font = new Font("Segoe UI Semibold", 14.5F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblPatientName.Location = new Point(14, 31);
            lblPatientName.Name = "lblPatientName";
            lblPatientName.Size = new Size(0, 35);
            lblPatientName.TabIndex = 0;
            // 
            // roundedPanel1
            // 
            roundedPanel1.BackColor = SystemColors.Control;
            roundedPanel1.BorderColor = Color.LightGray;
            roundedPanel1.BorderThickness = 0F;
            roundedPanel1.Controls.Add(lblAdmissionDate);
            roundedPanel1.Controls.Add(label9);
            roundedPanel1.Controls.Add(lblRoomName);
            roundedPanel1.Controls.Add(label7);
            roundedPanel1.Controls.Add(lblPatientID);
            roundedPanel1.Controls.Add(label5);
            roundedPanel1.Controls.Add(lblPatientName);
            roundedPanel1.CornerRadius = 10;
            roundedPanel1.Location = new Point(109, 81);
            roundedPanel1.Name = "roundedPanel1";
            roundedPanel1.Size = new Size(688, 254);
            roundedPanel1.TabIndex = 3;
            // 
            // lblAdmissionDate
            // 
            lblAdmissionDate.AutoSize = true;
            lblAdmissionDate.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblAdmissionDate.Location = new Point(172, 158);
            lblAdmissionDate.Name = "lblAdmissionDate";
            lblAdmissionDate.Size = new Size(0, 25);
            lblAdmissionDate.TabIndex = 6;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label9.Location = new Point(14, 158);
            label9.Name = "label9";
            label9.Size = new Size(152, 25);
            label9.TabIndex = 5;
            label9.Text = "Admission Date:";
            // 
            // lblRoomName
            // 
            lblRoomName.AutoSize = true;
            lblRoomName.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblRoomName.Location = new Point(87, 115);
            lblRoomName.Name = "lblRoomName";
            lblRoomName.Size = new Size(0, 25);
            lblRoomName.TabIndex = 4;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(14, 115);
            label7.Name = "label7";
            label7.Size = new Size(67, 25);
            label7.TabIndex = 3;
            label7.Text = "Room:";
            // 
            // lblPatientID
            // 
            lblPatientID.AutoSize = true;
            lblPatientID.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblPatientID.Location = new Point(113, 77);
            lblPatientID.Name = "lblPatientID";
            lblPatientID.Size = new Size(0, 25);
            lblPatientID.TabIndex = 2;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(14, 77);
            label5.Name = "label5";
            label5.Size = new Size(102, 25);
            label5.TabIndex = 1;
            label5.Text = "Patient ID:";
            // 
            // roundedPanel2
            // 
            roundedPanel2.BackColor = SystemColors.Control;
            roundedPanel2.BorderColor = Color.LightGray;
            roundedPanel2.BorderThickness = 0F;
            roundedPanel2.Controls.Add(txtNotes);
            roundedPanel2.Controls.Add(txtTreatment);
            roundedPanel2.Controls.Add(txtDiagnosis);
            roundedPanel2.Controls.Add(label17);
            roundedPanel2.Controls.Add(label16);
            roundedPanel2.Controls.Add(label15);
            roundedPanel2.CornerRadius = 10;
            roundedPanel2.Location = new Point(109, 406);
            roundedPanel2.Name = "roundedPanel2";
            roundedPanel2.Size = new Size(457, 326);
            roundedPanel2.TabIndex = 7;
            // 
            // txtNotes
            // 
            txtNotes.BackColor = SystemColors.Window;
            txtNotes.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtNotes.Location = new Point(33, 241);
            txtNotes.Multiline = true;
            txtNotes.Name = "txtNotes";
            txtNotes.ReadOnly = true;
            txtNotes.ScrollBars = ScrollBars.Vertical;
            txtNotes.Size = new Size(386, 69);
            txtNotes.TabIndex = 16;
            txtNotes.TabStop = false;
            txtNotes.Enter += removeFocus;
            // 
            // txtTreatment
            // 
            txtTreatment.BackColor = SystemColors.Window;
            txtTreatment.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtTreatment.Location = new Point(33, 146);
            txtTreatment.Multiline = true;
            txtTreatment.Name = "txtTreatment";
            txtTreatment.ReadOnly = true;
            txtTreatment.ScrollBars = ScrollBars.Vertical;
            txtTreatment.Size = new Size(386, 50);
            txtTreatment.TabIndex = 12;
            txtTreatment.TabStop = false;
            txtTreatment.Enter += removeFocus;
            // 
            // txtDiagnosis
            // 
            txtDiagnosis.BackColor = SystemColors.Window;
            txtDiagnosis.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtDiagnosis.Location = new Point(33, 51);
            txtDiagnosis.Multiline = true;
            txtDiagnosis.Name = "txtDiagnosis";
            txtDiagnosis.ReadOnly = true;
            txtDiagnosis.ScrollBars = ScrollBars.Vertical;
            txtDiagnosis.Size = new Size(386, 50);
            txtDiagnosis.TabIndex = 11;
            txtDiagnosis.TabStop = false;
            txtDiagnosis.Enter += removeFocus;
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label17.Location = new Point(33, 113);
            label17.Name = "label17";
            label17.Size = new Size(104, 25);
            label17.TabIndex = 8;
            label17.Text = "Treatment:";
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label16.Location = new Point(33, 18);
            label16.Name = "label16";
            label16.Size = new Size(100, 25);
            label16.TabIndex = 1;
            label16.Text = "Diagnosis:";
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label15.Location = new Point(33, 208);
            label15.Name = "label15";
            label15.Size = new Size(68, 25);
            label15.TabIndex = 2;
            label15.Text = "Notes:";
            // 
            // txtDuration
            // 
            txtDuration.BackColor = SystemColors.Window;
            txtDuration.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtDuration.Location = new Point(214, 203);
            txtDuration.Multiline = true;
            txtDuration.Name = "txtDuration";
            txtDuration.ReadOnly = true;
            txtDuration.ScrollBars = ScrollBars.Vertical;
            txtDuration.Size = new Size(106, 52);
            txtDuration.TabIndex = 15;
            txtDuration.TabStop = false;
            txtDuration.Enter += removeFocus;
            // 
            // txtFrequency
            // 
            txtFrequency.BackColor = SystemColors.Window;
            txtFrequency.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtFrequency.Location = new Point(33, 203);
            txtFrequency.Multiline = true;
            txtFrequency.Name = "txtFrequency";
            txtFrequency.ReadOnly = true;
            txtFrequency.ScrollBars = ScrollBars.Vertical;
            txtFrequency.Size = new Size(106, 52);
            txtFrequency.TabIndex = 14;
            txtFrequency.TabStop = false;
            txtFrequency.Enter += removeFocus;
            // 
            // txtMedication
            // 
            txtMedication.BackColor = SystemColors.Window;
            txtMedication.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtMedication.Location = new Point(33, 59);
            txtMedication.Multiline = true;
            txtMedication.Name = "txtMedication";
            txtMedication.ReadOnly = true;
            txtMedication.ScrollBars = ScrollBars.Vertical;
            txtMedication.Size = new Size(287, 52);
            txtMedication.TabIndex = 13;
            txtMedication.TabStop = false;
            txtMedication.Enter += removeFocus;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(33, 161);
            label2.Name = "label2";
            label2.Size = new Size(106, 25);
            label2.TabIndex = 6;
            label2.Text = "Frequency:";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label12.Location = new Point(214, 161);
            label12.Name = "label12";
            label12.Size = new Size(93, 25);
            label12.TabIndex = 5;
            label12.Text = "Duration:";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label14.Location = new Point(33, 22);
            label14.Name = "label14";
            label14.Size = new Size(114, 25);
            label14.TabIndex = 3;
            label14.Text = "Medication:";
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.Font = new Font("Segoe UI Semibold", 14.5F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label18.Location = new Point(109, 359);
            label18.Name = "label18";
            label18.Size = new Size(219, 35);
            label18.TabIndex = 9;
            label18.Text = "Medical Overview";
            // 
            // roundedPanel4
            // 
            roundedPanel4.BackColor = SystemColors.Control;
            roundedPanel4.BorderColor = Color.LightGray;
            roundedPanel4.BorderThickness = 0F;
            roundedPanel4.Controls.Add(txtBalance);
            roundedPanel4.Controls.Add(lblStatus);
            roundedPanel4.Controls.Add(txtTotal);
            roundedPanel4.Controls.Add(label22);
            roundedPanel4.Controls.Add(label21);
            roundedPanel4.Controls.Add(label19);
            roundedPanel4.CornerRadius = 10;
            roundedPanel4.Location = new Point(824, 81);
            roundedPanel4.Name = "roundedPanel4";
            roundedPanel4.Size = new Size(438, 254);
            roundedPanel4.TabIndex = 8;
            // 
            // txtBalance
            // 
            txtBalance.BackColor = SystemColors.Window;
            txtBalance.Font = new Font("Segoe UI", 12F);
            txtBalance.Location = new Point(222, 58);
            txtBalance.Name = "txtBalance";
            txtBalance.ReadOnly = true;
            txtBalance.Size = new Size(147, 34);
            txtBalance.TabIndex = 13;
            txtBalance.TabStop = false;
            txtBalance.Enter += removeFocus;
            // 
            // lblStatus
            // 
            lblStatus.AutoSize = true;
            lblStatus.Font = new Font("Segoe UI Semibold", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblStatus.Location = new Point(55, 171);
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new Size(0, 37);
            lblStatus.TabIndex = 12;
            // 
            // txtTotal
            // 
            txtTotal.BackColor = SystemColors.Window;
            txtTotal.Font = new Font("Segoe UI", 12F);
            txtTotal.Location = new Point(55, 58);
            txtTotal.Name = "txtTotal";
            txtTotal.ReadOnly = true;
            txtTotal.Size = new Size(147, 34);
            txtTotal.TabIndex = 10;
            txtTotal.TabStop = false;
            txtTotal.Enter += removeFocus;
            // 
            // label22
            // 
            label22.AutoSize = true;
            label22.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label22.Location = new Point(222, 27);
            label22.Name = "label22";
            label22.Size = new Size(83, 25);
            label22.TabIndex = 9;
            label22.Text = "Balance:";
            // 
            // label21
            // 
            label21.AutoSize = true;
            label21.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label21.Location = new Point(55, 136);
            label21.Name = "label21";
            label21.Size = new Size(149, 25);
            label21.TabIndex = 8;
            label21.Text = "Payment Status:";
            // 
            // label19
            // 
            label19.AutoSize = true;
            label19.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label19.Location = new Point(55, 27);
            label19.Name = "label19";
            label19.Size = new Size(101, 25);
            label19.TabIndex = 7;
            label19.Text = "Total Cost:";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Segoe UI Semibold", 14.5F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label13.Location = new Point(824, 26);
            label13.Name = "label13";
            label13.Size = new Size(204, 35);
            label13.TabIndex = 11;
            label13.Text = "Billing Summary";
            // 
            // btnDischarge
            // 
            btnDischarge.BackColor = Color.FromArgb(11, 143, 172);
            btnDischarge.FlatAppearance.BorderSize = 0;
            btnDischarge.FlatStyle = FlatStyle.Flat;
            btnDischarge.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnDischarge.ForeColor = Color.White;
            btnDischarge.Location = new Point(1030, 664);
            btnDischarge.Name = "btnDischarge";
            btnDischarge.Size = new Size(199, 45);
            btnDischarge.TabIndex = 12;
            btnDischarge.Text = "Confirm Discharge";
            btnDischarge.UseVisualStyleBackColor = false;
            btnDischarge.Click += btnDischarge_Click;
            // 
            // txtSearch
            // 
            txtSearch.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            txtSearch.AutoCompleteSource = AutoCompleteSource.CustomSource;
            txtSearch.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtSearch.Location = new Point(15, 13);
            txtSearch.Name = "txtSearch";
            txtSearch.PlaceholderText = "Search for Patient Name or ID";
            txtSearch.Size = new Size(636, 38);
            txtSearch.TabIndex = 14;
            // 
            // btnSearch
            // 
            btnSearch.BackColor = Color.White;
            btnSearch.FlatAppearance.BorderSize = 0;
            btnSearch.FlatStyle = FlatStyle.Flat;
            btnSearch.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSearch.ForeColor = Color.FromArgb(11, 143, 172);
            btnSearch.Location = new Point(657, 13);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(155, 38);
            btnSearch.TabIndex = 15;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = false;
            btnSearch.Click += btnSearch_Click;
            // 
            // btnID
            // 
            btnID.BackColor = Color.White;
            btnID.FlatAppearance.BorderSize = 0;
            btnID.FlatStyle = FlatStyle.Flat;
            btnID.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnID.ForeColor = Color.FromArgb(11, 143, 172);
            btnID.Location = new Point(166, 3);
            btnID.Name = "btnID";
            btnID.Size = new Size(248, 38);
            btnID.TabIndex = 16;
            btnID.Text = "Valid ID Form";
            btnID.UseVisualStyleBackColor = false;
            btnID.Visible = false;
            btnID.Click += btnID_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Gainsboro;
            panel1.Controls.Add(roundedPanel3);
            panel1.Controls.Add(label13);
            panel1.Controls.Add(btnDischarge);
            panel1.Controls.Add(roundedPanel4);
            panel1.Controls.Add(label18);
            panel1.Controls.Add(roundedPanel2);
            panel1.Controls.Add(roundedPanel1);
            panel1.Controls.Add(label3);
            panel1.Location = new Point(123, 169);
            panel1.Name = "panel1";
            panel1.Size = new Size(1371, 768);
            panel1.TabIndex = 17;
            panel1.Paint += panel1_Paint;
            // 
            // roundedPanel3
            // 
            roundedPanel3.BackColor = SystemColors.Control;
            roundedPanel3.BorderColor = Color.LightGray;
            roundedPanel3.BorderThickness = 0F;
            roundedPanel3.Controls.Add(label14);
            roundedPanel3.Controls.Add(txtMedication);
            roundedPanel3.Controls.Add(txtDuration);
            roundedPanel3.Controls.Add(txtFrequency);
            roundedPanel3.Controls.Add(label2);
            roundedPanel3.Controls.Add(label12);
            roundedPanel3.CornerRadius = 10;
            roundedPanel3.Location = new Point(592, 406);
            roundedPanel3.Name = "roundedPanel3";
            roundedPanel3.Size = new Size(376, 326);
            roundedPanel3.TabIndex = 17;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(11, 143, 172);
            panel2.Controls.Add(flowLayoutPanel1);
            panel2.Controls.Add(btnSearch);
            panel2.Controls.Add(txtSearch);
            panel2.Location = new Point(123, 105);
            panel2.Name = "panel2";
            panel2.Size = new Size(1371, 59);
            panel2.TabIndex = 18;
            // 
            // btnPrint
            // 
            btnPrint.BackColor = Color.White;
            btnPrint.FlatAppearance.BorderSize = 0;
            btnPrint.FlatStyle = FlatStyle.Flat;
            btnPrint.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnPrint.ForeColor = Color.FromArgb(11, 143, 172);
            btnPrint.Location = new Point(5, 3);
            btnPrint.Name = "btnPrint";
            btnPrint.Size = new Size(155, 38);
            btnPrint.TabIndex = 17;
            btnPrint.Text = "Print";
            btnPrint.UseVisualStyleBackColor = false;
            btnPrint.Click += btnPrint_Click;
            // 
            // printDocument1
            // 
            printDocument1.PrintPage += printDocument1_PrintPage;
            // 
            // printPreviewDialog1
            // 
            printPreviewDialog1.AutoScrollMargin = new Size(0, 0);
            printPreviewDialog1.AutoScrollMinSize = new Size(0, 0);
            printPreviewDialog1.ClientSize = new Size(400, 300);
            printPreviewDialog1.Document = printDocument1;
            printPreviewDialog1.Enabled = true;
            printPreviewDialog1.Icon = (Icon)resources.GetObject("printPreviewDialog1.Icon");
            printPreviewDialog1.Name = "printPreviewDialog1";
            printPreviewDialog1.Visible = false;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Controls.Add(btnID);
            flowLayoutPanel1.Controls.Add(btnPrint);
            flowLayoutPanel1.FlowDirection = FlowDirection.RightToLeft;
            flowLayoutPanel1.Location = new Point(951, 8);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(417, 48);
            flowLayoutPanel1.TabIndex = 18;
            // 
            // Discharge
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(label1);
            Name = "Discharge";
            Size = new Size(1637, 998);
            roundedPanel1.ResumeLayout(false);
            roundedPanel1.PerformLayout();
            roundedPanel2.ResumeLayout(false);
            roundedPanel2.PerformLayout();
            roundedPanel4.ResumeLayout(false);
            roundedPanel4.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            roundedPanel3.ResumeLayout(false);
            roundedPanel3.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            flowLayoutPanel1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label3;
        private Label lblPatientName;
        private RoundedPanel roundedPanel1;
        private Label lblAdmissionDate;
        private Label label9;
        private Label lblRoomName;
        private Label label7;
        private Label lblPatientID;
        private Label label5;
        private RoundedPanel roundedPanel2;
        private Label label2;
        private Label label12;
        private Label label14;
        private Label label15;
        private Label label16;
        private Label label18;
        private Label label17;
        private RoundedPanel roundedPanel4;
        private TextBox txtBalance;
        private Label lblStatus;
        private TextBox txtTotal;
        private Label label22;
        private Label label21;
        private Label label19;
        private Label label13;
        private Button btnDischarge;
        private TextBox txtNotes;
        private TextBox txtDuration;
        private TextBox txtFrequency;
        private TextBox txtMedication;
        private TextBox txtTreatment;
        private TextBox txtDiagnosis;
        private TextBox txtSearch;
        private Button btnSearch;
        private Button btnID;
        private Panel panel1;
        private RoundedPanel roundedPanel3;
        private Panel panel2;
        private Button btnPrint;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private PrintPreviewDialog printPreviewDialog1;
        private FlowLayoutPanel flowLayoutPanel1;
    }
}
