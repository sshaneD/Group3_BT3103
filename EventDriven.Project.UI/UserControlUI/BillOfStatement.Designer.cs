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
            dataGridView1 = new DataGridView();
            label5 = new Label();
            btnPayment = new Button();
            btnPrintBOS = new Button();
            printPreviewDialog1 = new PrintPreviewDialog();
            printDocument1 = new System.Drawing.Printing.PrintDocument();
            txtSearch = new TextBox();
            btnSearch = new Button();
            panel1 = new Panel();
            lblBirthday = new Label();
            lblGender = new Label();
            lblPatientID = new Label();
            lblPatientName = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            lblpatient = new Label();
            roundedPanel1 = new RoundedPanel();
            panel2 = new Panel();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel1.SuspendLayout();
            roundedPanel1.SuspendLayout();
            panel2.SuspendLayout();
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
            // dataGridView1
            // 
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dataGridView1.BackgroundColor = Color.Gainsboro;
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
            dataGridView1.Location = new Point(118, 510);
            dataGridView1.MultiSelect = false;
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.ShowCellToolTips = false;
            dataGridView1.ShowEditingIcon = false;
            dataGridView1.Size = new Size(1307, 324);
            dataGridView1.TabIndex = 6;
            dataGridView1.CellFormatting += dataGridView1_CellFormatting;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = SystemColors.Control;
            label5.Location = new Point(28, 11);
            label5.Name = "label5";
            label5.Size = new Size(74, 32);
            label5.TabIndex = 7;
            label5.Text = "Items";
            // 
            // btnPayment
            // 
            btnPayment.BackColor = Color.FromArgb(11, 143, 172);
            btnPayment.FlatStyle = FlatStyle.Flat;
            btnPayment.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnPayment.ForeColor = Color.White;
            btnPayment.Location = new Point(1328, 882);
            btnPayment.Name = "btnPayment";
            btnPayment.Size = new Size(205, 40);
            btnPayment.TabIndex = 13;
            btnPayment.Text = "Proceed to Payment";
            btnPayment.UseVisualStyleBackColor = false;
            btnPayment.Click += btnPayment_Click;
            // 
            // btnPrintBOS
            // 
            btnPrintBOS.BackColor = Color.FromArgb(11, 143, 172);
            btnPrintBOS.FlatStyle = FlatStyle.Flat;
            btnPrintBOS.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnPrintBOS.ForeColor = Color.White;
            btnPrintBOS.Location = new Point(1115, 882);
            btnPrintBOS.Name = "btnPrintBOS";
            btnPrintBOS.Size = new Size(207, 40);
            btnPrintBOS.TabIndex = 14;
            btnPrintBOS.Text = "Print Billing Statement";
            btnPrintBOS.UseVisualStyleBackColor = false;
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
            txtSearch.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtSearch.Location = new Point(118, 109);
            txtSearch.Name = "txtSearch";
            txtSearch.PlaceholderText = "Search Patient or ID";
            txtSearch.Size = new Size(742, 38);
            txtSearch.TabIndex = 15;
            // 
            // btnSearch
            // 
            btnSearch.BackColor = Color.FromArgb(11, 143, 172);
            btnSearch.FlatStyle = FlatStyle.Flat;
            btnSearch.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSearch.ForeColor = Color.White;
            btnSearch.Location = new Point(884, 109);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(116, 38);
            btnSearch.TabIndex = 16;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = false;
            btnSearch.Click += btnSearch_Click;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.Window;
            panel1.Controls.Add(lblBirthday);
            panel1.Controls.Add(lblGender);
            panel1.Controls.Add(lblPatientID);
            panel1.Controls.Add(lblPatientName);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(lblpatient);
            panel1.Location = new Point(17, 5);
            panel1.Name = "panel1";
            panel1.Size = new Size(698, 221);
            panel1.TabIndex = 17;
            // 
            // lblBirthday
            // 
            lblBirthday.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            lblBirthday.Location = new Point(524, 170);
            lblBirthday.Name = "lblBirthday";
            lblBirthday.Size = new Size(157, 28);
            lblBirthday.TabIndex = 11;
            lblBirthday.Text = "11/22/2004";
            lblBirthday.TextAlign = ContentAlignment.MiddleRight;
            // 
            // lblGender
            // 
            lblGender.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            lblGender.Location = new Point(566, 139);
            lblGender.Name = "lblGender";
            lblGender.Size = new Size(115, 28);
            lblGender.TabIndex = 10;
            lblGender.Text = "Female";
            lblGender.TextAlign = ContentAlignment.MiddleRight;
            // 
            // lblPatientID
            // 
            lblPatientID.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            lblPatientID.Location = new Point(573, 103);
            lblPatientID.Name = "lblPatientID";
            lblPatientID.Size = new Size(108, 28);
            lblPatientID.TabIndex = 9;
            lblPatientID.Text = "10001";
            lblPatientID.TextAlign = ContentAlignment.MiddleRight;
            // 
            // lblPatientName
            // 
            lblPatientName.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            lblPatientName.Location = new Point(243, 67);
            lblPatientName.Name = "lblPatientName";
            lblPatientName.Size = new Size(438, 28);
            lblPatientName.TabIndex = 8;
            lblPatientName.Text = "Stefanie Shane Delos Reyes";
            lblPatientName.TextAlign = ContentAlignment.MiddleRight;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            label4.Location = new Point(23, 139);
            label4.Name = "label4";
            label4.Size = new Size(85, 28);
            label4.TabIndex = 5;
            label4.Text = "Gender:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            label3.Location = new Point(23, 170);
            label3.Name = "label3";
            label3.Size = new Size(134, 28);
            label3.TabIndex = 4;
            label3.Text = "Date of Birth:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            label2.Location = new Point(23, 103);
            label2.Name = "label2";
            label2.Size = new Size(106, 28);
            label2.TabIndex = 3;
            label2.Text = "Patient ID:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            label1.Location = new Point(23, 67);
            label1.Name = "label1";
            label1.Size = new Size(71, 28);
            label1.TabIndex = 2;
            label1.Text = "Name:";
            // 
            // lblpatient
            // 
            lblpatient.AutoSize = true;
            lblpatient.Font = new Font("Segoe UI Semibold", 14F, FontStyle.Bold);
            lblpatient.Location = new Point(18, 24);
            lblpatient.Name = "lblpatient";
            lblpatient.Size = new Size(172, 32);
            lblpatient.TabIndex = 1;
            lblpatient.Text = "Patient Details";
            // 
            // roundedPanel1
            // 
            roundedPanel1.BackColor = SystemColors.Window;
            roundedPanel1.BorderColor = SystemColors.Control;
            roundedPanel1.BorderThickness = 0F;
            roundedPanel1.Controls.Add(panel1);
            roundedPanel1.CornerRadius = 10;
            roundedPanel1.Location = new Point(118, 176);
            roundedPanel1.Name = "roundedPanel1";
            roundedPanel1.Size = new Size(742, 236);
            roundedPanel1.TabIndex = 18;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(11, 143, 172);
            panel2.Controls.Add(label5);
            panel2.Location = new Point(118, 448);
            panel2.Name = "panel2";
            panel2.Size = new Size(1307, 56);
            panel2.TabIndex = 19;
            // 
            // BillOfStatement
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panel2);
            Controls.Add(roundedPanel1);
            Controls.Add(btnSearch);
            Controls.Add(txtSearch);
            Controls.Add(lblBOS);
            Controls.Add(btnPrintBOS);
            Controls.Add(btnPayment);
            Controls.Add(dataGridView1);
            Name = "BillOfStatement";
            Size = new Size(1637, 998);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            roundedPanel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblBOS;
        private DataGridView dataGridView1;
        private Label label5;
        private Button btnPayment;
        private Button btnPrintBOS;
        private PrintPreviewDialog printPreviewDialog1;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private TextBox txtSearch;
        private Button btnSearch;
        private Panel panel1;
        private Label lblBirthday;
        private Label lblGender;
        private Label lblPatientID;
        private Label lblPatientName;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private Label lblpatient;
        private RoundedPanel roundedPanel1;
        private Panel panel2;
    }
}
