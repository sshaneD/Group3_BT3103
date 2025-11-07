namespace EventDriven.Project.UI.UserControlUI
{
    partial class MedicalRecordCard
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
            lblRecordID = new Label();
            lblRecordDate = new Label();
            lblDiagnosis = new Label();
            panel1 = new Panel();
            flowLayoutPanel1 = new FlowLayoutPanel();
            lblTreatment = new Label();
            lblMedication = new Label();
            btnView = new Button();
            panel1.SuspendLayout();
            flowLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // lblRecordID
            // 
            lblRecordID.AutoSize = true;
            lblRecordID.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            lblRecordID.Location = new Point(3, 0);
            lblRecordID.Name = "lblRecordID";
            lblRecordID.Size = new Size(111, 28);
            lblRecordID.TabIndex = 0;
            lblRecordID.Text = "Record ID: ";
            // 
            // lblRecordDate
            // 
            lblRecordDate.AutoSize = true;
            lblRecordDate.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            lblRecordDate.Location = new Point(3, 28);
            lblRecordDate.Name = "lblRecordDate";
            lblRecordDate.Size = new Size(127, 28);
            lblRecordDate.TabIndex = 1;
            lblRecordDate.Text = "Record Date:";
            // 
            // lblDiagnosis
            // 
            lblDiagnosis.AutoSize = true;
            lblDiagnosis.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            lblDiagnosis.Location = new Point(3, 56);
            lblDiagnosis.Name = "lblDiagnosis";
            lblDiagnosis.Size = new Size(105, 28);
            lblDiagnosis.TabIndex = 2;
            lblDiagnosis.Text = "Diagnosis:";
            // 
            // panel1
            // 
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(flowLayoutPanel1);
            panel1.Controls.Add(btnView);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(480, 230);
            panel1.TabIndex = 3;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Controls.Add(lblRecordID);
            flowLayoutPanel1.Controls.Add(lblRecordDate);
            flowLayoutPanel1.Controls.Add(lblDiagnosis);
            flowLayoutPanel1.Controls.Add(lblTreatment);
            flowLayoutPanel1.Controls.Add(lblMedication);
            flowLayoutPanel1.FlowDirection = FlowDirection.TopDown;
            flowLayoutPanel1.Location = new Point(-1, -1);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(510, 183);
            flowLayoutPanel1.TabIndex = 3;
            // 
            // lblTreatment
            // 
            lblTreatment.AutoSize = true;
            lblTreatment.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            lblTreatment.Location = new Point(3, 84);
            lblTreatment.Name = "lblTreatment";
            lblTreatment.Size = new Size(109, 28);
            lblTreatment.TabIndex = 4;
            lblTreatment.Text = "Treatment:";
            // 
            // lblMedication
            // 
            lblMedication.AutoSize = true;
            lblMedication.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            lblMedication.Location = new Point(3, 112);
            lblMedication.Name = "lblMedication";
            lblMedication.Size = new Size(118, 28);
            lblMedication.TabIndex = 5;
            lblMedication.Text = "Medication:";
            // 
            // btnView
            // 
            btnView.Location = new Point(382, 188);
            btnView.Name = "btnView";
            btnView.Size = new Size(94, 29);
            btnView.TabIndex = 6;
            btnView.Text = "View";
            btnView.UseVisualStyleBackColor = true;
            btnView.Click += btnView_Click;
            // 
            // MedicalRecordCard
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            Controls.Add(panel1);
            Name = "MedicalRecordCard";
            Size = new Size(480, 230);
            panel1.ResumeLayout(false);
            flowLayoutPanel1.ResumeLayout(false);
            flowLayoutPanel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label lblRecordID;
        private Label lblRecordDate;
        private Label lblDiagnosis;
        private Panel panel1;
        private FlowLayoutPanel flowLayoutPanel1;
        private Label lblTreatment;
        private Label lblMedication;
        private Button btnView;
    }
}
