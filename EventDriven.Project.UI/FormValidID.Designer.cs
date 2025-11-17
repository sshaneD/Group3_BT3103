namespace EventDriven.Project.UI
{
    partial class FormValidID
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
            btnCancel = new Button();
            btnSave = new Button();
            panel3 = new Panel();
            txtName = new TextBox();
            label4 = new Label();
            txtIDNumber = new TextBox();
            cbType = new ComboBox();
            label3 = new Label();
            label1 = new Label();
            panel2 = new Panel();
            label2 = new Label();
            label4 = new Label();
            panel1.SuspendLayout();
            panel3.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.Gainsboro;
            panel1.Controls.Add(btnCancel);
            panel1.Controls.Add(btnSave);
            panel1.Controls.Add(panel3);
            panel1.Controls.Add(panel2);
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(665, 394);
            panel1.TabIndex = 0;
            // 
            // btnCancel
            // 
            btnCancel.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCancel.Location = new Point(342, 324);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(141, 35);
            btnCancel.TabIndex = 3;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // btnSave
            // 
            btnSave.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSave.Location = new Point(489, 324);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(141, 35);
            btnSave.TabIndex = 2;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // panel3
            // 
            panel3.BackColor = SystemColors.Control;
            panel3.Controls.Add(txtName);
            panel3.Controls.Add(label4);
            panel3.Controls.Add(txtIDNumber);
            panel3.Controls.Add(cbType);
            panel3.Controls.Add(label3);
            panel3.Controls.Add(label1);
            panel3.Location = new Point(27, 85);
            panel3.Name = "panel3";
            panel3.Size = new Size(590, 212);
            panel3.TabIndex = 1;
            // 
            // txtName
            // 
            txtName.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtName.Location = new Point(212, 91);
            txtName.Name = "txtName";
            txtName.Size = new Size(343, 30);
            txtName.TabIndex = 6;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(24, 93);
            label4.Name = "label4";
            label4.Size = new Size(71, 28);
            label4.TabIndex = 5;
            label4.Text = "Name:";
            // 
            // txtIDNumber
            // 
            txtIDNumber.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtIDNumber.Location = new Point(212, 137);
            txtIDNumber.Name = "txtIDNumber";
            txtIDNumber.Size = new Size(343, 30);
            txtIDNumber.TabIndex = 4;
            // 
            // cbType
            // 
            cbType.DropDownStyle = ComboBoxStyle.DropDownList;
            cbType.FormattingEnabled = true;
            cbType.Items.AddRange(new object[] { "Philippine Passport", "PhilSys / PhilID (National ID)", "Driver’s License (LTO)", "Unified Multi-Purpose ID (UMID)", "Social Security System (SSS) ID", "Government Service Insurance System (GSIS) ID", "Professional Regulation Commission (PRC) ID / License", "Voter’s ID / Voter’s Registration Card (COMELEC)", "PhilHealth ID Card", "Postal ID (Philippine Postal ID)" });
            cbType.Location = new Point(212, 47);
            cbType.Name = "cbType";
            cbType.Size = new Size(343, 28);
            cbType.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(24, 135);
            label3.Name = "label3";
            label3.Size = new Size(119, 28);
            label3.TabIndex = 2;
            label3.Text = "ID Number:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(24, 43);
            label1.Name = "label1";
            label1.Size = new Size(86, 28);
            label1.TabIndex = 0;
            label1.Text = "ID Type:";
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(11, 143, 172);
            panel2.Controls.Add(label2);
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(665, 56);
            panel2.TabIndex = 0;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 13.5F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.White;
            label2.Location = new Point(1, 19);
            label2.Name = "label2";
            label2.Size = new Size(292, 31);
            label2.TabIndex = 1;
            label2.Text = " Valid ID Information Form";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(24, 93);
            label4.Name = "label4";
            label4.Size = new Size(71, 28);
            label4.TabIndex = 5;
            label4.Text = "Name:";
            // 
            // FormValidID
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(666, 392);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormValidID";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormValidID";
            panel1.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Panel panel3;
        private ComboBox cbType;
        private Label label3;
        private Label label2;
        private Label label1;
        private Button btnSave;
        private TextBox txtIDNumber;
        private Button btnCancel;
        private TextBox txtName;
        private Label label4;
    }
}