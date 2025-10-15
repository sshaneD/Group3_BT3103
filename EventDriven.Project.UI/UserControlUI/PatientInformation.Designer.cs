namespace EventDriven.Project.UI.UserControlUI
{
    partial class PatientInformation
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            txtSearch = new TextBox();
            btnSearch = new Button();
            btnDelete = new Button();
            button8 = new Button();
            button7 = new Button();
            DGPatientRecord = new DataGridView();
            panel1 = new Panel();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)DGPatientRecord).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // txtSearch
            // 
            txtSearch.Font = new Font("Microsoft JhengHei UI", 12F);
            txtSearch.Location = new Point(1026, 17);
            txtSearch.Name = "txtSearch";
            txtSearch.PlaceholderText = "Search for Patient ID or Name";
            txtSearch.Size = new Size(373, 33);
            txtSearch.TabIndex = 41;
            txtSearch.KeyPress += txtSearch_KeyPress;
            // 
            // btnSearch
            // 
            btnSearch.Font = new Font("Microsoft JhengHei UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSearch.Location = new Point(1405, 16);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(121, 35);
            btnSearch.TabIndex = 40;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += btnSearch_Click;
            // 
            // btnDelete
            // 
            btnDelete.Font = new Font("Microsoft JhengHei UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnDelete.Location = new Point(327, 15);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(121, 35);
            btnDelete.TabIndex = 39;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // button8
            // 
            button8.Font = new Font("Microsoft JhengHei UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button8.Location = new Point(176, 15);
            button8.Name = "button8";
            button8.Size = new Size(121, 35);
            button8.TabIndex = 38;
            button8.Text = "Edit";
            button8.UseVisualStyleBackColor = true;
            button8.Click += button8_Click;
            // 
            // button7
            // 
            button7.Font = new Font("Microsoft JhengHei UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button7.Location = new Point(25, 14);
            button7.Name = "button7";
            button7.Size = new Size(121, 35);
            button7.TabIndex = 37;
            button7.Text = "Add ";
            button7.UseVisualStyleBackColor = true;
            button7.Click += button7_Click;
            // 
            // DGPatientRecord
            // 
            DGPatientRecord.AllowUserToResizeRows = false;
            DGPatientRecord.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Control;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            DGPatientRecord.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            DGPatientRecord.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DGPatientRecord.EnableHeadersVisualStyles = false;
            DGPatientRecord.Location = new Point(49, 168);
            DGPatientRecord.Name = "DGPatientRecord";
            DGPatientRecord.RowHeadersVisible = false;
            DGPatientRecord.RowHeadersWidth = 51;
            DGPatientRecord.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            DGPatientRecord.Size = new Size(1539, 795);
            DGPatientRecord.TabIndex = 36;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(11, 143, 172);
            panel1.Controls.Add(btnSearch);
            panel1.Controls.Add(btnDelete);
            panel1.Controls.Add(button8);
            panel1.Controls.Add(txtSearch);
            panel1.Controls.Add(button7);
            panel1.Location = new Point(49, 97);
            panel1.Name = "panel1";
            panel1.Size = new Size(1539, 65);
            panel1.TabIndex = 42;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft JhengHei UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(49, 49);
            label1.Name = "label1";
            label1.Size = new Size(284, 36);
            label1.TabIndex = 43;
            label1.Text = "Patient Information";
            // 
            // PatientInformation
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(label1);
            Controls.Add(DGPatientRecord);
            Controls.Add(panel1);
            Name = "PatientInformation";
            Size = new Size(1637, 998);
            ((System.ComponentModel.ISupportInitialize)DGPatientRecord).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtSearch;
        private Button btnSearch;
        private Button btnDelete;
        private Button button8;
        private Button button7;
        private DataGridView DGPatientRecord;
        private Panel panel1;
        private Label label1;
    }
}
