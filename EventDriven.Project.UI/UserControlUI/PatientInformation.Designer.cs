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
            btnEdit = new Button();
            btnAdd = new Button();
            DGPatientRecord = new DataGridView();
            panel1 = new Panel();
            btnMedRecord = new Button();
            label1 = new Label();
            flowLayoutPanel1 = new FlowLayoutPanel();
            btnBOS = new Button();
            ((System.ComponentModel.ISupportInitialize)DGPatientRecord).BeginInit();
            panel1.SuspendLayout();
            flowLayoutPanel1.SuspendLayout();
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
            txtSearch.TextChanged += txtSearch_TextChanged;
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
            btnDelete.Location = new Point(257, 3);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(121, 35);
            btnDelete.TabIndex = 39;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnEdit
            // 
            btnEdit.Font = new Font("Microsoft JhengHei UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnEdit.Location = new Point(130, 3);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(121, 35);
            btnEdit.TabIndex = 38;
            btnEdit.Text = "Edit";
            btnEdit.UseVisualStyleBackColor = true;
            btnEdit.Click += button8_Click;
            // 
            // btnAdd
            // 
            btnAdd.Font = new Font("Microsoft JhengHei UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAdd.Location = new Point(3, 3);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(121, 35);
            btnAdd.TabIndex = 37;
            btnAdd.Text = "Add ";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += button7_Click;
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
            panel1.Controls.Add(txtSearch);
            panel1.Location = new Point(49, 97);
            panel1.Name = "panel1";
            panel1.Size = new Size(1539, 65);
            panel1.TabIndex = 42;
            // 
            // btnMedRecord
            // 
            btnMedRecord.Font = new Font("Microsoft JhengHei UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnMedRecord.Location = new Point(384, 3);
            btnMedRecord.Name = "btnMedRecord";
            btnMedRecord.Size = new Size(185, 35);
            btnMedRecord.TabIndex = 42;
            btnMedRecord.Text = "Medical Record";
            btnMedRecord.UseVisualStyleBackColor = true;
            btnMedRecord.Click += btnMedRecord_Click;
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
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.BackColor = Color.FromArgb(11, 143, 172);
            flowLayoutPanel1.Controls.Add(btnAdd);
            flowLayoutPanel1.Controls.Add(btnEdit);
            flowLayoutPanel1.Controls.Add(btnDelete);
            flowLayoutPanel1.Controls.Add(btnMedRecord);
            flowLayoutPanel1.Controls.Add(btnBOS);
            flowLayoutPanel1.Location = new Point(62, 113);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(970, 49);
            flowLayoutPanel1.TabIndex = 44;
            // 
            // btnBOS
            // 
            btnBOS.Font = new Font("Microsoft JhengHei UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnBOS.Location = new Point(575, 3);
            btnBOS.Name = "btnBOS";
            btnBOS.Size = new Size(205, 35);
            btnBOS.TabIndex = 43;
            btnBOS.Text = "Bill of Statement";
            btnBOS.UseVisualStyleBackColor = true;
            btnBOS.Click += btnBOS_Click;
            // 
            // PatientInformation
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(label1);
            Controls.Add(flowLayoutPanel1);
            Controls.Add(DGPatientRecord);
            Controls.Add(panel1);
            Name = "PatientInformation";
            Size = new Size(1637, 998);
            ((System.ComponentModel.ISupportInitialize)DGPatientRecord).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            flowLayoutPanel1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtSearch;
        private Button btnSearch;
        private Button btnDelete;
        private Button btnEdit;
        private Button btnAdd;
        private DataGridView DGPatientRecord;
        private Panel panel1;
        private Label label1;
        private Button btnMedRecord;
        private FlowLayoutPanel flowLayoutPanel1;
        private Button btnBOS;
    }
}
