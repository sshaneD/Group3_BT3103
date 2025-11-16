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
            textBox1 = new TextBox();
            comboBox1 = new ComboBox();
            label3 = new Label();
            label1 = new Label();
            panel2 = new Panel();
            label2 = new Label();
            label4 = new Label();
            textBox2 = new TextBox();
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
            panel1.Paint += panel1_Paint;
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
            // 
            // panel3
            // 
            panel3.BackColor = SystemColors.Control;
            panel3.Controls.Add(textBox2);
            panel3.Controls.Add(label4);
            panel3.Controls.Add(textBox1);
            panel3.Controls.Add(comboBox1);
            panel3.Controls.Add(label3);
            panel3.Controls.Add(label1);
            panel3.Location = new Point(27, 85);
            panel3.Name = "panel3";
            panel3.Size = new Size(590, 212);
            panel3.TabIndex = 1;
            panel3.Paint += panel3_Paint;
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox1.Location = new Point(212, 137);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(343, 30);
            textBox1.TabIndex = 4;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Philippine Passport", "PhilSys / PhilID (National ID)", "Driver’s License (LTO)", "Unified Multi-Purpose ID (UMID)", "Social Security System (SSS) ID", "Government Service Insurance System (GSIS) ID", "Professional Regulation Commission (PRC) ID / License", "Voter’s ID / Voter’s Registration Card (COMELEC)", "PhilHealth ID Card", "Postal ID (Philippine Postal ID)" });
            comboBox1.Location = new Point(212, 47);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(343, 28);
            comboBox1.TabIndex = 3;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
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
            // textBox2
            // 
            textBox2.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox2.Location = new Point(212, 91);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(343, 30);
            textBox2.TabIndex = 6;
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
        private ComboBox comboBox1;
        private Label label3;
        private Label label2;
        private Label label1;
        private Button btnSave;
        private TextBox textBox1;
        private Button btnCancel;
        private TextBox textBox2;
        private Label label4;
    }
}