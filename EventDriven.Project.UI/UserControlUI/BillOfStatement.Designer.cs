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
            panel1 = new Panel();
            btnPayment = new Button();
            btnPrintBOS = new Button();
            printPreviewDialog1 = new PrintPreviewDialog();
            printDocument1 = new System.Drawing.Printing.PrintDocument();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // lblBOS
            // 
            lblBOS.AutoSize = true;
            lblBOS.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblBOS.ForeColor = SystemColors.ButtonHighlight;
            lblBOS.Location = new Point(33, 19);
            lblBOS.Name = "lblBOS";
            lblBOS.Size = new Size(232, 37);
            lblBOS.TabIndex = 0;
            lblBOS.Text = "Bill of Statement";
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
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(131, 400);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(1339, 486);
            dataGridView1.TabIndex = 6;
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
            lblPatientName.AutoSize = true;
            lblPatientName.Font = new Font("Segoe UI", 12F);
            lblPatientName.Location = new Point(395, 179);
            lblPatientName.Name = "lblPatientName";
            lblPatientName.Size = new Size(247, 28);
            lblPatientName.TabIndex = 8;
            lblPatientName.Text = "Stefanie Shane Delos Reyes";
            // 
            // lblPatientID
            // 
            lblPatientID.AutoSize = true;
            lblPatientID.Font = new Font("Segoe UI", 12F);
            lblPatientID.Location = new Point(560, 215);
            lblPatientID.Name = "lblPatientID";
            lblPatientID.Size = new Size(67, 28);
            lblPatientID.TabIndex = 9;
            lblPatientID.Text = "10001";
            lblPatientID.TextAlign = ContentAlignment.TopRight;
            // 
            // lblGender
            // 
            lblGender.AutoSize = true;
            lblGender.Font = new Font("Segoe UI", 12F);
            lblGender.Location = new Point(554, 251);
            lblGender.Name = "lblGender";
            lblGender.Size = new Size(74, 28);
            lblGender.TabIndex = 10;
            lblGender.Text = "Female";
            lblGender.TextAlign = ContentAlignment.TopRight;
            // 
            // lblBirthday
            // 
            lblBirthday.AutoSize = true;
            lblBirthday.Font = new Font("Segoe UI", 12F);
            lblBirthday.Location = new Point(516, 282);
            lblBirthday.Name = "lblBirthday";
            lblBirthday.Size = new Size(116, 28);
            lblBirthday.TabIndex = 11;
            lblBirthday.Text = "11/22/2004";
            lblBirthday.TextAlign = ContentAlignment.TopRight;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Silver;
            panel1.Controls.Add(lblBOS);
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1637, 75);
            panel1.TabIndex = 12;
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
            btnPrintBOS.Text = "Print Bill of Statement";
            btnPrintBOS.UseVisualStyleBackColor = true;
            btnPrintBOS.Click += btnPrintBOS_Click;
            // 
            // printPreviewDialog1
            // 
            printPreviewDialog1.AutoScrollMargin = new Size(0, 0);
            printPreviewDialog1.AutoScrollMinSize = new Size(0, 0);
            printPreviewDialog1.ClientSize = new Size(400, 300);
            printPreviewDialog1.Enabled = true;
            printPreviewDialog1.Icon = (Icon)resources.GetObject("printPreviewDialog1.Icon");
            printPreviewDialog1.Name = "printPreviewDialog1";
            printPreviewDialog1.Visible = false;
            // 
            // BillOfStatement
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(btnPrintBOS);
            Controls.Add(btnPayment);
            Controls.Add(panel1);
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
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
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
        private Panel panel1;
        private Button btnPayment;
        private Button btnPrintBOS;
        private PrintPreviewDialog printPreviewDialog1;
        private System.Drawing.Printing.PrintDocument printDocument1;
    }
}
