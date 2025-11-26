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
            roundedPanel1 = new RoundedPanel();
            panel4 = new Panel();
            label16 = new Label();
            label15 = new Label();
            numMedFrequencyCount = new NumericUpDown();
            numMedDuration = new NumericUpDown();
            label11 = new Label();
            label10 = new Label();
            cbFrequencyType = new ComboBox();
            numMedFrequencyValue = new NumericUpDown();
            txtMedPrice = new TextBox();
            label9 = new Label();
            label8 = new Label();
            label7 = new Label();
            txtMedication = new TextBox();
            label2 = new Label();
            label12 = new Label();
            btnSave = new Button();
            btnCancel = new Button();
            label13 = new Label();
            txtTreatmentPrice = new TextBox();
            label5 = new Label();
            label4 = new Label();
            txtNotes = new TextBox();
            label3 = new Label();
            txtDiagnosis = new TextBox();
            txtTreatment = new TextBox();
            label1 = new Label();
            panel3 = new Panel();
            label6 = new Label();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            roundedPanel1.SuspendLayout();
            panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numMedFrequencyCount).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numMedDuration).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numMedFrequencyValue).BeginInit();
            panel3.SuspendLayout();
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
            panel2.BackColor = Color.Gainsboro;
            panel2.Controls.Add(roundedPanel1);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(0, 66);
            panel2.Name = "panel2";
            panel2.Size = new Size(1180, 570);
            panel2.TabIndex = 4;
            panel2.Paint += panel2_Paint;
            // 
            // roundedPanel1
            // 
            roundedPanel1.BackColor = SystemColors.Control;
            roundedPanel1.BorderColor = Color.Transparent;
            roundedPanel1.BorderThickness = 0F;
            roundedPanel1.Controls.Add(panel4);
            roundedPanel1.Controls.Add(label12);
            roundedPanel1.Controls.Add(btnSave);
            roundedPanel1.Controls.Add(btnCancel);
            roundedPanel1.Controls.Add(label13);
            roundedPanel1.Controls.Add(txtTreatmentPrice);
            roundedPanel1.Controls.Add(label5);
            roundedPanel1.Controls.Add(label4);
            roundedPanel1.Controls.Add(txtNotes);
            roundedPanel1.Controls.Add(label3);
            roundedPanel1.Controls.Add(txtDiagnosis);
            roundedPanel1.Controls.Add(txtTreatment);
            roundedPanel1.Controls.Add(label1);
            roundedPanel1.CornerRadius = 10;
            roundedPanel1.Location = new Point(33, 28);
            roundedPanel1.Name = "roundedPanel1";
            roundedPanel1.Size = new Size(1108, 514);
            roundedPanel1.TabIndex = 29;
            // 
            // panel4
            // 
            panel4.BackColor = Color.Gainsboro;
            panel4.Controls.Add(label16);
            panel4.Controls.Add(label15);
            panel4.Controls.Add(numMedFrequencyCount);
            panel4.Controls.Add(numMedDuration);
            panel4.Controls.Add(label11);
            panel4.Controls.Add(label10);
            panel4.Controls.Add(cbFrequencyType);
            panel4.Controls.Add(numMedFrequencyValue);
            panel4.Controls.Add(txtMedPrice);
            panel4.Controls.Add(label9);
            panel4.Controls.Add(label8);
            panel4.Controls.Add(label7);
            panel4.Controls.Add(txtMedication);
            panel4.Controls.Add(label2);
            panel4.Location = new Point(520, 61);
            panel4.Name = "panel4";
            panel4.Size = new Size(563, 384);
            panel4.TabIndex = 31;
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Font = new Font("Segoe UI Semibold", 15F, FontStyle.Bold);
            label16.Location = new Point(12, 23);
            label16.Name = "label16";
            label16.Size = new Size(229, 35);
            label16.TabIndex = 32;
            label16.Text = "Medication Details";
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Font = new Font("Segoe UI", 13.8F);
            label15.Location = new Point(300, 320);
            label15.Name = "label15";
            label15.Size = new Size(56, 31);
            label15.TabIndex = 29;
            label15.Text = "PHP";
            // 
            // numMedFrequencyCount
            // 
            numMedFrequencyCount.Font = new Font("Segoe UI", 10F);
            numMedFrequencyCount.Location = new Point(61, 225);
            numMedFrequencyCount.Name = "numMedFrequencyCount";
            numMedFrequencyCount.Size = new Size(57, 30);
            numMedFrequencyCount.TabIndex = 28;
            // 
            // numMedDuration
            // 
            numMedDuration.Font = new Font("Segoe UI", 10F);
            numMedDuration.Location = new Point(61, 320);
            numMedDuration.Name = "numMedDuration";
            numMedDuration.Size = new Size(57, 30);
            numMedDuration.TabIndex = 22;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 13.8F);
            label11.Location = new Point(120, 320);
            label11.Name = "label11";
            label11.Size = new Size(77, 31);
            label11.TabIndex = 21;
            label11.Text = "Day(s)";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 13.8F);
            label10.Location = new Point(124, 225);
            label10.Name = "label10";
            label10.Size = new Size(68, 31);
            label10.TabIndex = 20;
            label10.Text = "Every";
            // 
            // cbFrequencyType
            // 
            cbFrequencyType.Font = new Font("Segoe UI", 10F);
            cbFrequencyType.FormattingEnabled = true;
            cbFrequencyType.Items.AddRange(new object[] { "Hour(s)", "Day(s)" });
            cbFrequencyType.Location = new Point(261, 225);
            cbFrequencyType.Name = "cbFrequencyType";
            cbFrequencyType.Size = new Size(83, 31);
            cbFrequencyType.TabIndex = 19;
            cbFrequencyType.Text = "Hour(s)";
            // 
            // numMedFrequencyValue
            // 
            numMedFrequencyValue.Font = new Font("Segoe UI", 10F);
            numMedFrequencyValue.Location = new Point(198, 225);
            numMedFrequencyValue.Name = "numMedFrequencyValue";
            numMedFrequencyValue.Size = new Size(57, 30);
            numMedFrequencyValue.TabIndex = 18;
            // 
            // txtMedPrice
            // 
            txtMedPrice.Font = new Font("Segoe UI", 13.8F);
            txtMedPrice.Location = new Point(361, 317);
            txtMedPrice.Name = "txtMedPrice";
            txtMedPrice.Size = new Size(97, 38);
            txtMedPrice.TabIndex = 16;
            txtMedPrice.Text = "0.00";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            label9.Location = new Point(300, 277);
            label9.Name = "label9";
            label9.Size = new Size(168, 28);
            label9.TabIndex = 17;
            label9.Text = "Medication Price:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            label8.Location = new Point(61, 277);
            label8.Name = "label8";
            label8.Size = new Size(203, 28);
            label8.TabIndex = 15;
            label8.Text = "Medication Duration:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            label7.Location = new Point(59, 187);
            label7.Name = "label7";
            label7.Size = new Size(218, 28);
            label7.TabIndex = 13;
            label7.Text = "Medication Frequency:";
            // 
            // txtMedication
            // 
            txtMedication.Font = new Font("Segoe UI", 11F);
            txtMedication.Location = new Point(61, 121);
            txtMedication.Multiline = true;
            txtMedication.Name = "txtMedication";
            txtMedication.PlaceholderText = "e.g. Salbutamol Inhaler";
            txtMedication.Size = new Size(450, 39);
            txtMedication.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            label2.Location = new Point(61, 82);
            label2.Name = "label2";
            label2.Size = new Size(216, 28);
            label2.TabIndex = 3;
            label2.Text = "Medication (Optional):";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI Semibold", 15F, FontStyle.Bold);
            label12.Location = new Point(63, 37);
            label12.Name = "label12";
            label12.Size = new Size(248, 35);
            label12.TabIndex = 30;
            label12.Text = "Medical Information";
            // 
            // btnSave
            // 
            btnSave.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            btnSave.Location = new Point(979, 458);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(113, 45);
            btnSave.TabIndex = 6;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // btnCancel
            // 
            btnCancel.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            btnCancel.Location = new Point(860, 458);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(113, 45);
            btnCancel.TabIndex = 5;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Segoe UI", 13.8F);
            label13.Location = new Point(63, 292);
            label13.Name = "label13";
            label13.Size = new Size(56, 31);
            label13.TabIndex = 25;
            label13.Text = "PHP";
            // 
            // txtTreatmentPrice
            // 
            txtTreatmentPrice.Font = new Font("Segoe UI", 13.8F);
            txtTreatmentPrice.Location = new Point(125, 292);
            txtTreatmentPrice.Name = "txtTreatmentPrice";
            txtTreatmentPrice.Size = new Size(97, 38);
            txtTreatmentPrice.TabIndex = 24;
            txtTreatmentPrice.Text = "0.00";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            label5.Location = new Point(63, 253);
            label5.Name = "label5";
            label5.Size = new Size(159, 28);
            label5.TabIndex = 11;
            label5.Text = "Treatment Price:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            label4.Location = new Point(63, 89);
            label4.Name = "label4";
            label4.Size = new Size(114, 28);
            label4.TabIndex = 9;
            label4.Text = "*Diagnosis:";
            // 
            // txtNotes
            // 
            txtNotes.Location = new Point(63, 380);
            txtNotes.Multiline = true;
            txtNotes.Name = "txtNotes";
            txtNotes.Size = new Size(417, 114);
            txtNotes.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            label3.Location = new Point(63, 349);
            label3.Name = "label3";
            label3.Size = new Size(71, 28);
            label3.TabIndex = 5;
            label3.Text = "Notes:";
            // 
            // txtDiagnosis
            // 
            txtDiagnosis.Font = new Font("Segoe UI", 11F);
            txtDiagnosis.Location = new Point(63, 120);
            txtDiagnosis.Multiline = true;
            txtDiagnosis.Name = "txtDiagnosis";
            txtDiagnosis.PlaceholderText = "e.g. Asthma";
            txtDiagnosis.Size = new Size(339, 39);
            txtDiagnosis.TabIndex = 1;
            // 
            // txtTreatment
            // 
            txtTreatment.Font = new Font("Segoe UI", 11F);
            txtTreatment.Location = new Point(63, 204);
            txtTreatment.Multiline = true;
            txtTreatment.Name = "txtTreatment";
            txtTreatment.PlaceholderText = "e.g. Nebulization";
            txtTreatment.Size = new Size(339, 39);
            txtTreatment.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            label1.Location = new Point(63, 173);
            label1.Name = "label1";
            label1.Size = new Size(207, 28);
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
            label6.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ForeColor = SystemColors.ButtonHighlight;
            label6.Location = new Point(11, 18);
            label6.Name = "label6";
            label6.Size = new Size(218, 38);
            label6.TabIndex = 4;
            label6.Text = "Medical Details";
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
            roundedPanel1.ResumeLayout(false);
            roundedPanel1.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numMedFrequencyCount).EndInit();
            ((System.ComponentModel.ISupportInitialize)numMedDuration).EndInit();
            ((System.ComponentModel.ISupportInitialize)numMedFrequencyValue).EndInit();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
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
        private NumericUpDown numMedFrequencyValue;
        private Label label10;
        private ComboBox cbFrequencyType;
        private Label label13;
        private TextBox txtTreatmentPrice;
        private NumericUpDown numMedDuration;
        private Label label11;
        private NumericUpDown numMedFrequencyCount;
        private RoundedPanel roundedPanel1;
        private Label label12;
        private Label label15;
        private Panel panel4;
        private Label label16;
    }
}