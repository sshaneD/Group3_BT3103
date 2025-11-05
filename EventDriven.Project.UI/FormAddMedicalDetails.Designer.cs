namespace EventDriven.Project.UI
{
    partial class FormAddMedicalDetails
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
            panel2 = new Panel();
            txtMedication = new TextBox();
            label4 = new Label();
            btnSave = new Button();
            btnCancel = new Button();
            txtNotes = new TextBox();
            label3 = new Label();
            txtDiagnosis = new TextBox();
            label2 = new Label();
            txtTreatment = new TextBox();
            label1 = new Label();
            panel3 = new Panel();
            label6 = new Label();
            label5 = new Label();
            label7 = new Label();
            label8 = new Label();
            txtMedPrice = new TextBox();
            label9 = new Label();
            numMedFrequency = new NumericUpDown();
            cbFrequencyType = new ComboBox();
            label10 = new Label();
            label11 = new Label();
            numMedDuration = new NumericUpDown();
            label12 = new Label();
            label13 = new Label();
            txtTreatmentPrice = new TextBox();
            dateRecordDate = new DateTimePicker();
            label14 = new Label();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numMedFrequency).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numMedDuration).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.Transparent;
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(panel2);
            panel1.Controls.Add(panel3);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1182, 638);
            panel1.TabIndex = 0;
            // 
            // panel2
            // 
            panel2.BackColor = Color.LightGray;
            panel2.Controls.Add(label14);
            panel2.Controls.Add(dateRecordDate);
            panel2.Controls.Add(label13);
            panel2.Controls.Add(txtTreatmentPrice);
            panel2.Controls.Add(label12);
            panel2.Controls.Add(numMedDuration);
            panel2.Controls.Add(label11);
            panel2.Controls.Add(label10);
            panel2.Controls.Add(cbFrequencyType);
            panel2.Controls.Add(numMedFrequency);
            panel2.Controls.Add(txtMedPrice);
            panel2.Controls.Add(label9);
            panel2.Controls.Add(label8);
            panel2.Controls.Add(label7);
            panel2.Controls.Add(label5);
            panel2.Controls.Add(txtMedication);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(btnSave);
            panel2.Controls.Add(btnCancel);
            panel2.Controls.Add(txtNotes);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(txtDiagnosis);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(txtTreatment);
            panel2.Controls.Add(label1);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(0, 66);
            panel2.Name = "panel2";
            panel2.Size = new Size(1180, 570);
            panel2.TabIndex = 4;
            // 
            // txtMedication
            // 
            txtMedication.Location = new Point(458, 93);
            txtMedication.Multiline = true;
            txtMedication.Name = "txtMedication";
            txtMedication.PlaceholderText = "e.g. Paracetamol 500mg";
            txtMedication.Size = new Size(268, 39);
            txtMedication.TabIndex = 3;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft JhengHei UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(80, 61);
            label4.Name = "label4";
            label4.Size = new Size(128, 29);
            label4.TabIndex = 9;
            label4.Text = "Diagnosis:";
            // 
            // btnSave
            // 
            btnSave.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            btnSave.Location = new Point(1031, 505);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(94, 29);
            btnSave.TabIndex = 6;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            // 
            // btnCancel
            // 
            btnCancel.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            btnCancel.Location = new Point(931, 505);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(94, 29);
            btnCancel.TabIndex = 5;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // txtNotes
            // 
            txtNotes.Location = new Point(80, 378);
            txtNotes.Multiline = true;
            txtNotes.Name = "txtNotes";
            txtNotes.Size = new Size(647, 156);
            txtNotes.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft JhengHei UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(80, 345);
            label3.Name = "label3";
            label3.Size = new Size(86, 29);
            label3.TabIndex = 5;
            label3.Text = "Notes:";
            // 
            // txtDiagnosis
            // 
            txtDiagnosis.Location = new Point(80, 93);
            txtDiagnosis.Multiline = true;
            txtDiagnosis.Name = "txtDiagnosis";
            txtDiagnosis.PlaceholderText = "e.g. Cancer";
            txtDiagnosis.Size = new Size(268, 39);
            txtDiagnosis.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft JhengHei UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(458, 61);
            label2.Name = "label2";
            label2.Size = new Size(264, 29);
            label2.TabIndex = 3;
            label2.Text = "Medication (Optional):";
            // 
            // txtTreatment
            // 
            txtTreatment.Location = new Point(80, 179);
            txtTreatment.Multiline = true;
            txtTreatment.Name = "txtTreatment";
            txtTreatment.PlaceholderText = "e.g. Chemotherapy";
            txtTreatment.Size = new Size(268, 39);
            txtTreatment.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft JhengHei UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(80, 147);
            label1.Name = "label1";
            label1.Size = new Size(254, 29);
            label1.TabIndex = 1;
            label1.Text = "Treatment (Optional):";
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(11, 143, 172);
            panel3.Controls.Add(label6);
            panel3.Dock = DockStyle.Top;
            panel3.Location = new Point(0, 0);
            panel3.Name = "panel3";
            panel3.Size = new Size(1180, 66);
            panel3.TabIndex = 5;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Microsoft JhengHei UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ForeColor = SystemColors.ButtonHighlight;
            label6.Location = new Point(33, 26);
            label6.Name = "label6";
            label6.Size = new Size(239, 29);
            label6.TabIndex = 4;
            label6.Text = "Add Medical Record";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Microsoft JhengHei UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(80, 233);
            label5.Name = "label5";
            label5.Size = new Size(195, 29);
            label5.TabIndex = 11;
            label5.Text = "Treatment Price:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Microsoft JhengHei UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(458, 132);
            label7.Name = "label7";
            label7.Size = new Size(265, 29);
            label7.TabIndex = 13;
            label7.Text = "Medication Frequency:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Microsoft JhengHei UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.Location = new Point(458, 196);
            label8.Name = "label8";
            label8.Size = new Size(249, 29);
            label8.TabIndex = 15;
            label8.Text = "Medication Duration:";
            // 
            // txtMedPrice
            // 
            txtMedPrice.Font = new Font("Segoe UI", 13.8F);
            txtMedPrice.Location = new Point(514, 295);
            txtMedPrice.Name = "txtMedPrice";
            txtMedPrice.Size = new Size(212, 38);
            txtMedPrice.TabIndex = 16;
            txtMedPrice.Text = "0.00";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Microsoft JhengHei UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label9.Location = new Point(458, 263);
            label9.Name = "label9";
            label9.Size = new Size(205, 29);
            label9.TabIndex = 17;
            label9.Text = "Medication Price:";
            // 
            // numMedFrequency
            // 
            numMedFrequency.Font = new Font("Segoe UI", 10F);
            numMedFrequency.Location = new Point(532, 164);
            numMedFrequency.Name = "numMedFrequency";
            numMedFrequency.Size = new Size(57, 30);
            numMedFrequency.TabIndex = 18;
            // 
            // cbFrequencyType
            // 
            cbFrequencyType.Font = new Font("Segoe UI", 10F);
            cbFrequencyType.FormattingEnabled = true;
            cbFrequencyType.Items.AddRange(new object[] { "Hour(s)", "Day(s)" });
            cbFrequencyType.Location = new Point(595, 163);
            cbFrequencyType.Name = "cbFrequencyType";
            cbFrequencyType.Size = new Size(83, 31);
            cbFrequencyType.TabIndex = 19;
            cbFrequencyType.Text = "Hour(s)";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 13.8F);
            label10.Location = new Point(458, 160);
            label10.Name = "label10";
            label10.Size = new Size(68, 31);
            label10.TabIndex = 20;
            label10.Text = "Every";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 13.8F);
            label11.Location = new Point(514, 229);
            label11.Name = "label11";
            label11.Size = new Size(77, 31);
            label11.TabIndex = 21;
            label11.Text = "Day(s)";
            // 
            // numMedDuration
            // 
            numMedDuration.Font = new Font("Segoe UI", 10F);
            numMedDuration.Location = new Point(460, 230);
            numMedDuration.Name = "numMedDuration";
            numMedDuration.Size = new Size(57, 30);
            numMedDuration.TabIndex = 22;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI", 13.8F);
            label12.Location = new Point(458, 298);
            label12.Name = "label12";
            label12.Size = new Size(56, 31);
            label12.TabIndex = 23;
            label12.Text = "PHP";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Segoe UI", 13.8F);
            label13.Location = new Point(80, 268);
            label13.Name = "label13";
            label13.Size = new Size(56, 31);
            label13.TabIndex = 25;
            label13.Text = "PHP";
            // 
            // txtTreatmentPrice
            // 
            txtTreatmentPrice.Font = new Font("Segoe UI", 13.8F);
            txtTreatmentPrice.Location = new Point(136, 265);
            txtTreatmentPrice.Name = "txtTreatmentPrice";
            txtTreatmentPrice.Size = new Size(212, 38);
            txtTreatmentPrice.TabIndex = 24;
            txtTreatmentPrice.Text = "0.00";
            // 
            // dateRecordDate
            // 
            dateRecordDate.Format = DateTimePickerFormat.Short;
            dateRecordDate.Location = new Point(1000, 63);
            dateRecordDate.Name = "dateRecordDate";
            dateRecordDate.Size = new Size(120, 27);
            dateRecordDate.TabIndex = 26;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Microsoft JhengHei UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label14.Location = new Point(837, 61);
            label14.Name = "label14";
            label14.Size = new Size(157, 29);
            label14.TabIndex = 27;
            label14.Text = "Record Date:";
            // 
            // FormAddMedicalDetails
            // 
            AcceptButton = btnSave;
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = btnCancel;
            ClientSize = new Size(1182, 638);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            KeyPreview = true;
            Name = "FormAddMedicalDetails";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormAddMedicalRecord";
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numMedFrequency).EndInit();
            ((System.ComponentModel.ISupportInitialize)numMedDuration).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private TextBox txtMedication;
        private Label label4;
        private Button btnSave;
        private Button btnCancel;
        private TextBox txtNotes;
        private Label label3;
        private TextBox txtDiagnosis;
        private Label label2;
        private TextBox txtTreatment;
        private Label label1;
        private Panel panel3;
        private Label label6;
        private Label label5;
        private TextBox txtMedPrice;
        private Label label9;
        private Label label8;
        private Label label7;
        private NumericUpDown numMedFrequency;
        private Label label10;
        private ComboBox cbFrequencyType;
        private Label label13;
        private TextBox txtTreatmentPrice;
        private Label label12;
        private NumericUpDown numMedDuration;
        private Label label11;
        private Label label14;
        private DateTimePicker dateRecordDate;
    }
}