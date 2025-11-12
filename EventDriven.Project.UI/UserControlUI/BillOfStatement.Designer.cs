namespace EventDriven.Project.UI.UserControlUI
{
    partial class BillOfStatement
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
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BillOfStatement));
            lblBOS = new Label();
            lblpatient = new Label();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            dataGridView1 = new DataGridView();
            label5 = new Label();
            lblPatientName = new Label();
            lblPatientID = new Label();
            lblGender = new Label();
            lblBirthday = new Label();
            btnPayment = new Button();
            btnPrintBOS = new Button();
            printPreviewDialog1 = new PrintPreviewDialog();
            printDocument1 = new System.Drawing.Printing.PrintDocument();
            txtSearch = new TextBox();
            btnSearch = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // lblBOS
            // 
            lblBOS.AutoSize = true;
            lblBOS.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblBOS.ForeColor = SystemColors.ActiveCaptionText;
            lblBOS.Location = new Point(34, 38);
            lblBOS.Name = "lblBOS";
            lblBOS.Size = new Size(239, 37);
            lblBOS.TabIndex = 0;
            lblBOS.Text = "Billing Statement";
            // 
            // lblpatient
            // 
            lblpatient.AutoSize = true;
            lblpatient.Font = new Font("Segoe UI Semibold", 14F, FontStyle.Bold);
            lblpatient.Location = new Point(121, 123);
            lblpatient.Name = "lblpatient";
            lblpatient.Size = new Size(172, 32);
            lblpatient.TabIndex = 1;
            lblpatient.Text = "Patient Details";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F);
            label1.Location = new Point(130, 179);
            label1.Name = "label1";
            label1.Size = new Size(68, 28);
            label1.TabIndex = 2;
            label1.Text = "Name:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F);
            label2.Location = new Point(130, 215);
            label2.Name = "label2";
            label2.Size = new Size(100, 28);
            label2.TabIndex = 3;
            label2.Text = "Patient ID:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F);
            label3.Location = new Point(130, 282);
            label3.Name = "label3";
            label3.Size = new Size(126, 28);
            label3.TabIndex = 4;
            label3.Text = "Date of Birth:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F);
            label4.Location = new Point(130, 251);
            label4.Name = "label4";
            label4.Size = new Size(80, 28);
            label4.TabIndex = 5;
            label4.Text = "Gender:";
            // 
            // dataGridView1
            // 
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dataGridView1.BackgroundColor = Color.FromArgb(217, 217, 217);
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Control;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Window;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dataGridView1.DefaultCellStyle = dataGridViewCellStyle2;
            dataGridView1.EnableHeadersVisualStyles = false;
            dataGridView1.Location = new Point(131, 400);
            dataGridView1.MultiSelect = false;
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.ShowCellToolTips = false;
            dataGridView1.ShowEditingIcon = false;
            dataGridView1.Size = new Size(1339, 486);
            dataGridView1.TabIndex = 6;
            dataGridView1.CellFormatting += dataGridView1_CellFormatting;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(130, 355);
            label5.Name = "label5";
            label5.Size = new Size(74, 32);
            label5.TabIndex = 7;
            label5.Text = "Items";
            // 
            // lblPatientName
            // 
            lblPatientName.Font = new Font("Segoe UI", 12F);
            lblPatientName.Location = new Point(204, 179);
            lblPatientName.Name = "lblPatientName";
            lblPatientName.Size = new Size(438, 28);
            lblPatientName.TabIndex = 8;
            lblPatientName.Text = "Stefanie Shane Delos Reyes";
            lblPatientName.TextAlign = ContentAlignment.MiddleRight;
            // 
            // lblPatientID
            // 
            lblPatientID.Font = new Font("Segoe UI", 12F);
            lblPatientID.Location = new Point(534, 215);
            lblPatientID.Name = "lblPatientID";
            lblPatientID.Size = new Size(108, 28);
            lblPatientID.TabIndex = 9;
            lblPatientID.Text = "10001";
            lblPatientID.TextAlign = ContentAlignment.MiddleRight;
            // 
            // lblGender
            // 
            lblGender.Font = new Font("Segoe UI", 12F);
            lblGender.Location = new Point(527, 251);
            lblGender.Name = "lblGender";
            lblGender.Size = new Size(115, 28);
            lblGender.TabIndex = 10;
            lblGender.Text = "Female";
            lblGender.TextAlign = ContentAlignment.MiddleRight;
            // 
            // lblBirthday
            // 
            lblBirthday.Font = new Font("Segoe UI", 12F);
            lblBirthday.Location = new Point(485, 282);
            lblBirthday.Name = "lblBirthday";
            lblBirthday.Size = new Size(157, 28);
            lblBirthday.TabIndex = 11;
            lblBirthday.Text = "11/22/2004";
            lblBirthday.TextAlign = ContentAlignment.MiddleRight;
            // 
            // btnPayment
            // 
            btnPayment.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnPayment.Location = new Point(1325, 913);
            btnPayment.Name = "btnPayment";
            btnPayment.Size = new Size(205, 40);
            btnPayment.TabIndex = 13;
            btnPayment.Text = "Proceed to Payment";
            btnPayment.UseVisualStyleBackColor = true;
            btnPayment.Click += btnPayment_Click;
            // 
            // btnPrintBOS
            // 
            btnPrintBOS.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnPrintBOS.Location = new Point(1112, 913);
            btnPrintBOS.Name = "btnPrintBOS";
            btnPrintBOS.Size = new Size(207, 40);
            btnPrintBOS.TabIndex = 14;
            btnPrintBOS.Text = "Print Billing Statement";
            btnPrintBOS.UseVisualStyleBackColor = true;
            btnPrintBOS.Click += btnPrintBOS_Click;
            // 
            // printPreviewDialog1
            // 
            printPreviewDialog1.AutoScrollMargin = new Size(0, 0);
            printPreviewDialog1.AutoScrollMinSize = new Size(0, 0);
            printPreviewDialog1.ClientSize = new Size(400, 300);
            printPreviewDialog1.Document = printDocument1;
            printPreviewDialog1.Enabled = true;
            printPreviewDialog1.Icon = (Icon)resources.GetObject("printPreviewDialog1.Icon");
            printPreviewDialog1.Name = "printPreviewDialog1";
            printPreviewDialog1.ShowIcon = false;
            printPreviewDialog1.Visible = false;
            // 
            // printDocument1
            // 
            printDocument1.PrintPage += printDocument1_PrintPage;
            // 
            // txtSearch
            // 
            txtSearch.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            txtSearch.Font = new Font("Segoe UI", 11F);
            txtSearch.Location = new Point(984, 123);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(361, 32);
            txtSearch.TabIndex = 15;
            // 
            // btnSearch
            // 
            btnSearch.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSearch.Location = new Point(1354, 123);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(116, 32);
            btnSearch.TabIndex = 16;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += btnSearch_Click;
            // 
            // BillOfStatement
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(btnSearch);
            Controls.Add(txtSearch);
            Controls.Add(lblBOS);
            Controls.Add(btnPrintBOS);
            Controls.Add(btnPayment);
            Controls.Add(lblBirthday);
            Controls.Add(lblGender);
            Controls.Add(lblPatientID);
            Controls.Add(lblPatientName);
            Controls.Add(label5);
            Controls.Add(dataGridView1);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(lblpatient);
            Name = "BillOfStatement";
            Size = new Size(1637, 998);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblBOS;
        private Label lblpatient;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private DataGridView dataGridView1;
        private Label label5;
        private Label lblPatientName;
        private Label lblPatientID;
        private Label lblGender;
        private Label lblBirthday;
        private Button btnPayment;
        private Button btnPrintBOS;
        private PrintPreviewDialog printPreviewDialog1;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private TextBox txtSearch;
        private Button btnSearch;
    }
}
