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
            textBox1 = new TextBox();
            button2 = new Button();
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
            // textBox1
            // 
            textBox1.Font = new Font("Microsoft JhengHei UI", 16F);
            textBox1.Location = new Point(1024, 20);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(373, 35);
            textBox1.TabIndex = 41;
            // 
            // button2
            // 
            button2.Font = new Font("Microsoft JhengHei UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.Location = new Point(1403, 20);
            button2.Name = "button2";
            button2.Size = new Size(121, 35);
            button2.TabIndex = 40;
            button2.Text = "Search";
            button2.UseVisualStyleBackColor = true;
            // 
            // btnDelete
            // 
            btnDelete.Font = new Font("Microsoft JhengHei UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnDelete.Location = new Point(370, 118);
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
            button8.Location = new Point(216, 118);
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
            button7.Location = new Point(67, 117);
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
            DGPatientRecord.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
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
            panel1.Controls.Add(button2);
            panel1.Controls.Add(textBox1);
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
            Controls.Add(btnDelete);
            Controls.Add(button8);
            Controls.Add(button7);
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

        private TextBox textBox1;
        private Button button2;
        private Button btnDelete;
        private Button button8;
        private Button button7;
        private DataGridView DGPatientRecord;
        private Panel panel1;
        private Label label1;
    }
}
