namespace EventDriven.Project.UI
{
    partial class FormPayment
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPayment));
            txtAmountPaid = new TextBox();
            label3 = new Label();
            lblTotalAmount = new Label();
            label2 = new Label();
            label1 = new Label();
            label4 = new Label();
            txtRemarks = new TextBox();
            btnConfirm = new Button();
            btnCancel = new Button();
            panel1 = new Panel();
            panelBorder = new Panel();
            panel2 = new Panel();
            panel3 = new Panel();
            label8 = new Label();
            label7 = new Label();
            label5 = new Label();
            txtAmountReceived = new TextBox();
            lblChange = new Label();
            label6 = new Label();
            printDocument1 = new System.Drawing.Printing.PrintDocument();
            printPreviewDialog1 = new PrintPreviewDialog();
            panel1.SuspendLayout();
            panelBorder.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // txtAmountPaid
            // 
            txtAmountPaid.Font = new Font("Segoe UI", 11F);
            txtAmountPaid.Location = new Point(316, 110);
            txtAmountPaid.Name = "txtAmountPaid";
            txtAmountPaid.PlaceholderText = "Enter Amount";
            txtAmountPaid.Size = new Size(254, 32);
            txtAmountPaid.TabIndex = 9;
            txtAmountPaid.KeyPress += txtAmountPaid_KeyPress;
            txtAmountPaid.Leave += txtAmountPaid_Leave;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(25, 79);
            label3.Name = "label3";
            label3.Size = new Size(177, 28);
            label3.TabIndex = 8;
            label3.Text = "Amount Received:";
            // 
            // lblTotalAmount
            // 
            lblTotalAmount.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTotalAmount.Location = new Point(242, 32);
            lblTotalAmount.Name = "lblTotalAmount";
            lblTotalAmount.Size = new Size(148, 28);
            lblTotalAmount.TabIndex = 7;
            lblTotalAmount.Text = "12,000.00";
            lblTotalAmount.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = SystemColors.Control;
            label2.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(25, 32);
            label2.Name = "label2";
            label2.Size = new Size(140, 28);
            label2.TabIndex = 6;
            label2.Text = "Total Amount:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 13F, FontStyle.Bold);
            label1.ForeColor = SystemColors.Control;
            label1.Location = new Point(364, 13);
            label1.Name = "label1";
            label1.Size = new Size(104, 30);
            label1.TabIndex = 5;
            label1.Text = "Payment";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(78, 281);
            label4.Name = "label4";
            label4.Size = new Size(151, 28);
            label4.TabIndex = 10;
            label4.Text = "Payment Notes";
            // 
            // txtRemarks
            // 
            txtRemarks.Font = new Font("Segoe UI", 11F);
            txtRemarks.Location = new Point(78, 318);
            txtRemarks.Multiline = true;
            txtRemarks.Name = "txtRemarks";
            txtRemarks.PlaceholderText = "Remarks";
            txtRemarks.Size = new Size(436, 131);
            txtRemarks.TabIndex = 11;
            // 
            // btnConfirm
            // 
            btnConfirm.BackColor = Color.FromArgb(11, 143, 172);
            btnConfirm.FlatAppearance.BorderSize = 0;
            btnConfirm.FlatStyle = FlatStyle.Flat;
            btnConfirm.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            btnConfirm.ForeColor = Color.White;
            btnConfirm.Location = new Point(533, 402);
            btnConfirm.Name = "btnConfirm";
            btnConfirm.Size = new Size(159, 35);
            btnConfirm.TabIndex = 12;
            btnConfirm.Text = "Confirm Payment";
            btnConfirm.UseVisualStyleBackColor = false;
            btnConfirm.Click += btnConfirm_Click;
            // 
            // btnCancel
            // 
            btnCancel.BackColor = Color.FromArgb(11, 143, 172);
            btnCancel.FlatAppearance.BorderSize = 0;
            btnCancel.FlatStyle = FlatStyle.Flat;
            btnCancel.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            btnCancel.ForeColor = Color.White;
            btnCancel.Location = new Point(533, 356);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(159, 35);
            btnCancel.TabIndex = 13;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = false;
            btnCancel.Click += btnCancel_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(11, 143, 172);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(-1, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(833, 56);
            panel1.TabIndex = 14;
            // 
            // panelBorder
            // 
            panelBorder.BackColor = SystemColors.Control;
            panelBorder.BorderStyle = BorderStyle.FixedSingle;
            panelBorder.Controls.Add(panel2);
            panelBorder.Dock = DockStyle.Fill;
            panelBorder.Location = new Point(0, 0);
            panelBorder.Name = "panelBorder";
            panelBorder.Size = new Size(829, 558);
            panelBorder.TabIndex = 6;
            // 
            // panel2
            // 
            panel2.BackColor = Color.Gainsboro;
            panel2.Controls.Add(panel3);
            panel2.Controls.Add(btnConfirm);
            panel2.Controls.Add(btnCancel);
            panel2.Controls.Add(txtRemarks);
            panel2.Controls.Add(label4);
            panel2.Location = new Point(22, 74);
            panel2.Name = "panel2";
            panel2.Size = new Size(778, 465);
            panel2.TabIndex = 20;
            // 
            // panel3
            // 
            panel3.BackColor = SystemColors.Control;
            panel3.Controls.Add(label8);
            panel3.Controls.Add(label7);
            panel3.Controls.Add(label5);
            panel3.Controls.Add(label2);
            panel3.Controls.Add(txtAmountReceived);
            panel3.Controls.Add(lblChange);
            panel3.Controls.Add(lblTotalAmount);
            panel3.Controls.Add(label3);
            panel3.Controls.Add(label6);
            panel3.Controls.Add(txtAmountPaid);
            panel3.Location = new Point(78, 31);
            panel3.Name = "panel3";
            panel3.Size = new Size(614, 234);
            panel3.TabIndex = 20;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.Location = new Point(185, 174);
            label8.Name = "label8";
            label8.Size = new Size(51, 28);
            label8.TabIndex = 19;
            label8.Text = "PHP";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(316, 79);
            label7.Name = "label7";
            label7.Size = new Size(135, 28);
            label7.TabIndex = 18;
            label7.Text = "Amount Paid:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(185, 32);
            label5.Name = "label5";
            label5.Size = new Size(51, 28);
            label5.TabIndex = 15;
            label5.Text = "PHP";
            // 
            // txtAmountReceived
            // 
            txtAmountReceived.Font = new Font("Segoe UI", 11F);
            txtAmountReceived.Location = new Point(25, 110);
            txtAmountReceived.Name = "txtAmountReceived";
            txtAmountReceived.PlaceholderText = "Enter Amount";
            txtAmountReceived.Size = new Size(254, 32);
            txtAmountReceived.TabIndex = 17;
            txtAmountReceived.KeyPress += txtAmountReceived_KeyPress;
            txtAmountReceived.Leave += txtAmountReceived_Leave;
            // 
            // lblChange
            // 
            lblChange.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblChange.Location = new Point(242, 174);
            lblChange.Name = "lblChange";
            lblChange.Size = new Size(121, 28);
            lblChange.TabIndex = 16;
            lblChange.Text = "0.00";
            lblChange.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(25, 174);
            label6.Name = "label6";
            label6.Size = new Size(86, 28);
            label6.TabIndex = 15;
            label6.Text = "Change:";
            // 
            // printDocument1
            // 
            printDocument1.PrintPage += printDocument1_PrintPage;
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
            printPreviewDialog1.Visible = false;
            // 
            // FormPayment
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(829, 558);
            Controls.Add(panel1);
            Controls.Add(panelBorder);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormPayment";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormPayment";
            Load += FormPayment_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panelBorder.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TextBox txtAmountPaid;
        private Label label3;
        private Label lblTotalAmount;
        private Label label2;
        private Label label1;
        private Label label4;
        private TextBox txtRemarks;
        private Button btnConfirm;
        private Button btnCancel;
        private Panel panel1;
        private Panel panelBorder;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private PrintPreviewDialog printPreviewDialog1;
        private Label lblChange;
        private Label label6;
        private Label label8;
        private Label label7;
        private Label label5;
        private TextBox txtAmountReceived;
        private Panel panel2;
        private Panel panel3;
    }
}