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
            lblAdmitted = new Label();
            label1 = new Label();
            lblDiagnosis = new Label();
            lblDischarged = new Label();
            SuspendLayout();
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Font = new Font("Segoe UI", 14.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblName.Location = new Point(59, 19);
            lblName.Name = "lblName";
            lblName.Size = new Size(323, 32);
            lblName.TabIndex = 0;
            lblName.Text = "Stefanie Shane Delos Reyes";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(69, 55);
            label2.Name = "label2";
            label2.Size = new Size(106, 28);
            label2.TabIndex = 1;
            label2.Text = "Patient ID:";
            // 
            // lblPatientID
            // 
            lblPatientID.AutoSize = true;
            lblPatientID.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblPatientID.Location = new Point(181, 55);
            lblPatientID.Name = "lblPatientID";
            lblPatientID.Size = new Size(50, 28);
            lblPatientID.TabIndex = 2;
            lblPatientID.Text = "1001";
            // 
            // lblAdmitted
            // 
            lblAdmitted.AutoSize = true;
            lblAdmitted.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblAdmitted.Location = new Point(984, 33);
            lblAdmitted.Name = "lblAdmitted";
            lblAdmitted.Size = new Size(233, 28);
            lblAdmitted.TabIndex = 3;
            lblAdmitted.Text = "Admitted on: 01/01/0001";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(70, 89);
            label1.Name = "label1";
            label1.Size = new Size(105, 28);
            label1.TabIndex = 5;
            label1.Text = "Diagnosis:";
            // 
            // lblDiagnosis
            // 
            lblDiagnosis.AutoSize = true;
            lblDiagnosis.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblDiagnosis.Location = new Point(181, 89);
            lblDiagnosis.Name = "lblDiagnosis";
            lblDiagnosis.Size = new Size(39, 28);
            lblDiagnosis.TabIndex = 6;
            lblDiagnosis.Text = "Flu";
            // 
            // lblDischarged
            // 
            lblDischarged.AutoSize = true;
            lblDischarged.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblDischarged.Location = new Point(984, 76);
            lblDischarged.Name = "lblDischarged";
            lblDischarged.Size = new Size(249, 28);
            lblDischarged.TabIndex = 7;
            lblDischarged.Text = "Discharged on: 01/01/0001";
            // 
            // AdmissionHistoryCard
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            BorderStyle = BorderStyle.FixedSingle;
            Controls.Add(lblDischarged);
            Controls.Add(lblDiagnosis);
            Controls.Add(label1);
            Controls.Add(lblAdmitted);
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
        private Label lblAdmitted;
        private Label label1;
        private Label lblDiagnosis;
        private Label lblDischarged;
    }
}
