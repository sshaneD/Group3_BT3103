namespace EventDriven.Project.UI.UserControlUI
{
    partial class AdmissionHistoryCard
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
            lblName = new Label();
            label2 = new Label();
            lblPatientID = new Label();
            label4 = new Label();
            date = new DateTimePicker();
            label1 = new Label();
            label3 = new Label();
            SuspendLayout();
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Font = new Font("Segoe UI", 14.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblName.Location = new Point(59, 20);
            lblName.Name = "lblName";
            lblName.Size = new Size(323, 32);
            lblName.TabIndex = 0;
            lblName.Text = "Stefanie Shane Delos Reyes";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(69, 56);
            label2.Name = "label2";
            label2.Size = new Size(106, 28);
            label2.TabIndex = 1;
            label2.Text = "Patient ID:";
            // 
            // lblPatientID
            // 
            lblPatientID.AutoSize = true;
            lblPatientID.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblPatientID.Location = new Point(181, 56);
            lblPatientID.Name = "lblPatientID";
            lblPatientID.Size = new Size(50, 28);
            lblPatientID.TabIndex = 2;
            lblPatientID.Text = "1001";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(864, 56);
            label4.Name = "label4";
            label4.Size = new Size(132, 28);
            label4.TabIndex = 3;
            label4.Text = "Admitted on:";
            // 
            // date
            // 
            date.CalendarFont = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            date.Font = new Font("Segoe UI", 9.5F, FontStyle.Regular, GraphicsUnit.Point, 0);
            date.Location = new Point(1002, 56);
            date.Name = "date";
            date.Size = new Size(316, 29);
            date.TabIndex = 4;
            date.Value = new DateTime(2025, 11, 9, 15, 29, 36, 0);
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(70, 90);
            label1.Name = "label1";
            label1.Size = new Size(105, 28);
            label1.TabIndex = 5;
            label1.Text = "Diagnosis:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(181, 90);
            label3.Name = "label3";
            label3.Size = new Size(39, 28);
            label3.TabIndex = 6;
            label3.Text = "Flu";
            // 
            // AdmissionHistoryCard
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BorderStyle = BorderStyle.FixedSingle;
            Controls.Add(label3);
            Controls.Add(label1);
            Controls.Add(date);
            Controls.Add(label4);
            Controls.Add(lblPatientID);
            Controls.Add(label2);
            Controls.Add(lblName);
            Name = "AdmissionHistoryCard";
            Size = new Size(1385, 136);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblName;
        private Label label2;
        private Label lblPatientID;
        private Label label4;
        private DateTimePicker date;
        private Label label1;
        private Label label3;
    }
}
