namespace EventDriven.Project.UI
{
    partial class FormStaffAssignment
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            panel1 = new Panel();
            panel2 = new Panel();
            labelTitle = new Label();
            dataGridAssignmentM = new DataGridView();
            btnCancelAssign = new Button();
            lblStaff = new Label();
            btnAssignStaff = new Button();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridAssignmentM).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.Transparent;
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(panel2);
            panel1.Controls.Add(dataGridAssignmentM);
            panel1.Controls.Add(btnCancelAssign);
            panel1.Controls.Add(lblStaff);
            panel1.Controls.Add(btnAssignStaff);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1189, 695);
            panel1.TabIndex = 0;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(11, 143, 172);
            panel2.Controls.Add(labelTitle);
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(1191, 69);
            panel2.TabIndex = 10;
            // 
            // labelTitle
            // 
            labelTitle.AutoSize = true;
            labelTitle.Font = new Font("Microsoft JhengHei UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelTitle.ForeColor = SystemColors.ButtonHighlight;
            labelTitle.Location = new Point(13, 27);
            labelTitle.Name = "labelTitle";
            labelTitle.Size = new Size(229, 29);
            labelTitle.TabIndex = 3;
            labelTitle.Text = "Doctor Assignment";
            // 
            // dataGridAssignmentM
            // 
            dataGridAssignmentM.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Control;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dataGridAssignmentM.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dataGridAssignmentM.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridAssignmentM.EnableHeadersVisualStyles = false;
            dataGridAssignmentM.Location = new Point(88, 157);
            dataGridAssignmentM.Name = "dataGridAssignmentM";
            dataGridAssignmentM.ReadOnly = true;
            dataGridAssignmentM.RowHeadersVisible = false;
            dataGridAssignmentM.RowHeadersWidth = 51;
            dataGridAssignmentM.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridAssignmentM.Size = new Size(1010, 415);
            dataGridAssignmentM.TabIndex = 9;
            dataGridAssignmentM.SelectionChanged += dataGridAssignmentM_SelectionChanged;
            // 
            // btnCancelAssign
            // 
            btnCancelAssign.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCancelAssign.Location = new Point(906, 645);
            btnCancelAssign.Name = "btnCancelAssign";
            btnCancelAssign.Size = new Size(118, 29);
            btnCancelAssign.TabIndex = 15;
            btnCancelAssign.Text = "Cancel";
            btnCancelAssign.UseVisualStyleBackColor = true;
            btnCancelAssign.Click += btnCancelAssign_Click;
            // 
            // lblStaff
            // 
            lblStaff.AutoSize = true;
            lblStaff.Font = new Font("Microsoft JhengHei UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblStaff.Location = new Point(90, 120);
            lblStaff.Name = "lblStaff";
            lblStaff.Size = new Size(178, 23);
            lblStaff.TabIndex = 14;
            lblStaff.Text = "Available Doctor/s:";
            // 
            // btnAssignStaff
            // 
            btnAssignStaff.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAssignStaff.Location = new Point(1039, 645);
            btnAssignStaff.Name = "btnAssignStaff";
            btnAssignStaff.Size = new Size(118, 29);
            btnAssignStaff.TabIndex = 11;
            btnAssignStaff.Text = "Assign";
            btnAssignStaff.UseVisualStyleBackColor = true;
            btnAssignStaff.Click += btnAssignStaff_Click;
            // 
            // FormStaffAssignment
            // 
            AcceptButton = btnAssignStaff;
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = btnCancelAssign;
            ClientSize = new Size(1189, 695);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            KeyPreview = true;
            Name = "FormStaffAssignment";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormStaffAssignment";
            Load += FormStaffAssignment_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridAssignmentM).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridView1;
        private DataGridView dataGridView2;
        private Panel panel1;
        private Panel panel2;
        private Label labelTitle;
        private DataGridView dataGridAssignmentM;
        private Button btnCancelAssign;
        private Label lblStaff;
        private Button btnAssignStaff;
    }
}