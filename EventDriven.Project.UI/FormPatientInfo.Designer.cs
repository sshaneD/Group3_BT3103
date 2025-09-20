namespace EventDriven.Project.UI
{
    partial class FormPatientInfo
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
            label14 = new Label();
            btnAPLogout = new Button();
            panel2 = new Panel();
            flowLayoutPanel1 = new FlowLayoutPanel();
            btnBilling = new Button();
            button1 = new Button();
            btnPatientInfo = new Button();
            button3 = new Button();
            btnAdmission = new Button();
            btnADischarge = new Button();
            pictureBox1 = new PictureBox();
            dataGridView1 = new DataGridView();
            button7 = new Button();
            button8 = new Button();
            button9 = new Button();
            button10 = new Button();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(11, 143, 172);
            panel1.Controls.Add(label14);
            panel1.Controls.Add(btnAPLogout);
            panel1.Location = new Point(0, -1);
            panel1.Name = "panel1";
            panel1.Size = new Size(1927, 85);
            panel1.TabIndex = 2;
            panel1.Paint += panel1_Paint;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Microsoft JhengHei UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label14.ForeColor = SystemColors.ButtonHighlight;
            label14.Location = new Point(25, 34);
            label14.Name = "label14";
            label14.Size = new Size(297, 36);
            label14.TabIndex = 29;
            label14.Text = "Apex Medical Center";
            // 
            // btnAPLogout
            // 
            btnAPLogout.Location = new Point(1800, 43);
            btnAPLogout.Name = "btnAPLogout";
            btnAPLogout.Size = new Size(94, 29);
            btnAPLogout.TabIndex = 3;
            btnAPLogout.Text = "Log out";
            btnAPLogout.UseVisualStyleBackColor = true;
            btnAPLogout.Click += btnAPLogout_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.White;
            panel2.Controls.Add(flowLayoutPanel1);
            panel2.Controls.Add(pictureBox1);
            panel2.Location = new Point(1, 83);
            panel2.Name = "panel2";
            panel2.Size = new Size(291, 1037);
            panel2.TabIndex = 3;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Controls.Add(btnBilling);
            flowLayoutPanel1.Controls.Add(button1);
            flowLayoutPanel1.Controls.Add(btnPatientInfo);
            flowLayoutPanel1.Controls.Add(button3);
            flowLayoutPanel1.Controls.Add(btnAdmission);
            flowLayoutPanel1.Controls.Add(btnADischarge);
            flowLayoutPanel1.Location = new Point(34, 347);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(241, 523);
            flowLayoutPanel1.TabIndex = 34;
            // 
            // btnBilling
            // 
            btnBilling.Font = new Font("Microsoft JhengHei UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnBilling.Location = new Point(3, 3);
            btnBilling.Margin = new Padding(3, 3, 3, 30);
            btnBilling.Name = "btnBilling";
            btnBilling.Size = new Size(212, 46);
            btnBilling.TabIndex = 6;
            btnBilling.Text = "Billing";
            btnBilling.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.BackColor = Color.Transparent;
            button1.Font = new Font("Microsoft JhengHei UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.Location = new Point(3, 82);
            button1.Margin = new Padding(3, 3, 3, 30);
            button1.Name = "button1";
            button1.Size = new Size(212, 46);
            button1.TabIndex = 2;
            button1.Text = "Dashboard";
            button1.UseVisualStyleBackColor = false;
            // 
            // btnPatientInfo
            // 
            btnPatientInfo.BackColor = Color.LightGray;
            btnPatientInfo.Font = new Font("Microsoft JhengHei UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnPatientInfo.Location = new Point(3, 161);
            btnPatientInfo.Margin = new Padding(3, 3, 3, 30);
            btnPatientInfo.Name = "btnPatientInfo";
            btnPatientInfo.Size = new Size(212, 46);
            btnPatientInfo.TabIndex = 3;
            btnPatientInfo.Text = "Patient Information";
            btnPatientInfo.UseVisualStyleBackColor = false;
            btnPatientInfo.Click += btnPatientInfo_Click;
            // 
            // button3
            // 
            button3.Font = new Font("Microsoft JhengHei UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button3.Location = new Point(3, 240);
            button3.Margin = new Padding(3, 3, 3, 30);
            button3.Name = "button3";
            button3.Size = new Size(212, 46);
            button3.TabIndex = 4;
            button3.Text = "Room Search";
            button3.UseVisualStyleBackColor = true;
            // 
            // btnAdmission
            // 
            btnAdmission.BackColor = Color.White;
            btnAdmission.Font = new Font("Microsoft JhengHei UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAdmission.Location = new Point(3, 319);
            btnAdmission.Margin = new Padding(3, 3, 3, 30);
            btnAdmission.Name = "btnAdmission";
            btnAdmission.Size = new Size(212, 46);
            btnAdmission.TabIndex = 5;
            btnAdmission.Text = "Admission";
            btnAdmission.UseVisualStyleBackColor = false;
            btnAdmission.Click += btnAdmission_Click;
            // 
            // btnADischarge
            // 
            btnADischarge.Font = new Font("Microsoft JhengHei UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnADischarge.Location = new Point(3, 398);
            btnADischarge.Margin = new Padding(3, 3, 3, 30);
            btnADischarge.Name = "btnADischarge";
            btnADischarge.Size = new Size(212, 46);
            btnADischarge.TabIndex = 7;
            btnADischarge.Text = "Discharge";
            btnADischarge.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.Modern_Minimalist_Black_and_White_Report_Presentation__17_;
            pictureBox1.Location = new Point(34, 87);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(215, 212);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(327, 249);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(1539, 730);
            dataGridView1.TabIndex = 4;
            // 
            // button7
            // 
            button7.Font = new Font("Microsoft JhengHei UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button7.Location = new Point(349, 180);
            button7.Name = "button7";
            button7.Size = new Size(163, 51);
            button7.TabIndex = 30;
            button7.Text = "Add ";
            button7.UseVisualStyleBackColor = true;
            button7.Click += button7_Click;
            // 
            // button8
            // 
            button8.Font = new Font("Microsoft JhengHei UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button8.Location = new Point(531, 180);
            button8.Name = "button8";
            button8.Size = new Size(163, 51);
            button8.TabIndex = 31;
            button8.Text = "Edit";
            button8.UseVisualStyleBackColor = true;
            button8.Click += button8_Click;
            // 
            // button9
            // 
            button9.Font = new Font("Microsoft JhengHei UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button9.Location = new Point(711, 180);
            button9.Name = "button9";
            button9.Size = new Size(163, 51);
            button9.TabIndex = 32;
            button9.Text = "View";
            button9.UseVisualStyleBackColor = true;
            // 
            // button10
            // 
            button10.Font = new Font("Microsoft JhengHei UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button10.Location = new Point(890, 180);
            button10.Name = "button10";
            button10.Size = new Size(163, 51);
            button10.TabIndex = 33;
            button10.Text = "Delete";
            button10.UseVisualStyleBackColor = true;
            // 
            // FormPatientInfo
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightGray;
            ClientSize = new Size(1902, 1033);
            Controls.Add(button10);
            Controls.Add(button9);
            Controls.Add(button8);
            Controls.Add(button7);
            Controls.Add(dataGridView1);
            Controls.Add(panel2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormPatientInfo";
            Text = "FormPatientInfo";
            WindowState = FormWindowState.Maximized;
            Load += FormPatientInfo_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            flowLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label14;
        private Button btnAPLogout;
        private Panel panel2;
        private PictureBox pictureBox1;
        private DataGridView dataGridView1;
        private Button button7;
        private Button button8;
        private Button button9;
        private Button button10;
        private FlowLayoutPanel flowLayoutPanel1;
        private Button btnBilling;
        private Button button1;
        private Button btnPatientInfo;
        private Button button3;
        private Button btnAdmission;
        private Button btnADischarge;
    }
}