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
            printDocument1 = new System.Drawing.Printing.PrintDocument();
            printPreviewDialog1 = new PrintPreviewDialog();
            panel1.SuspendLayout();
            panelBorder.SuspendLayout();
            SuspendLayout();
            // 
            // txtAmountPaid
            // 
            txtAmountPaid.Font = new Font("Segoe UI", 11F);
            txtAmountPaid.Location = new Point(57, 172);
            txtAmountPaid.Name = "txtAmountPaid";
            txtAmountPaid.PlaceholderText = "Enter Amount";
            txtAmountPaid.Size = new Size(341, 32);
            txtAmountPaid.TabIndex = 9;
            txtAmountPaid.KeyPress += txtAmountPaid_KeyPress;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(57, 136);
            label3.Name = "label3";
            label3.Size = new Size(177, 28);
            label3.TabIndex = 8;
            label3.Text = "Amount Received:";
            // 
            // lblTotalAmount
            // 
            lblTotalAmount.AutoSize = true;
            lblTotalAmount.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTotalAmount.Location = new Point(303, 94);
            lblTotalAmount.Name = "lblTotalAmount";
            lblTotalAmount.Size = new Size(96, 28);
            lblTotalAmount.TabIndex = 7;
            lblTotalAmount.Text = "12,000.00";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(58, 94);
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
            label4.Location = new Point(57, 269);
            label4.Name = "label4";
            label4.Size = new Size(151, 28);
            label4.TabIndex = 10;
            label4.Text = "Payment Notes";
            // 
            // txtRemarks
            // 
            txtRemarks.Font = new Font("Segoe UI", 11F);
            txtRemarks.Location = new Point(57, 305);
            txtRemarks.Multiline = true;
            txtRemarks.Name = "txtRemarks";
            txtRemarks.PlaceholderText = "Remarks";
            txtRemarks.Size = new Size(614, 152);
            txtRemarks.TabIndex = 11;
            // 
            // btnConfirm
            // 
            btnConfirm.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            btnConfirm.Location = new Point(634, 487);
            btnConfirm.Name = "btnConfirm";
            btnConfirm.Size = new Size(150, 35);
            btnConfirm.TabIndex = 12;
            btnConfirm.Text = "Confirm Payment";
            btnConfirm.UseVisualStyleBackColor = true;
            btnConfirm.Click += btnConfirm_Click;
            // 
            // btnCancel
            // 
            btnCancel.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            btnCancel.Location = new Point(474, 487);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(150, 35);
            btnCancel.TabIndex = 13;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
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
            panelBorder.BackColor = Color.Transparent;
            panelBorder.BorderStyle = BorderStyle.FixedSingle;
            panelBorder.Controls.Add(label3);
            panelBorder.Controls.Add(txtRemarks);
            panelBorder.Controls.Add(txtAmountPaid);
            panelBorder.Controls.Add(label4);
            panelBorder.Dock = DockStyle.Fill;
            panelBorder.Location = new Point(0, 0);
            panelBorder.Name = "panelBorder";
            panelBorder.Size = new Size(829, 558);
            panelBorder.TabIndex = 6;
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
            Controls.Add(btnCancel);
            Controls.Add(btnConfirm);
            Controls.Add(lblTotalAmount);
            Controls.Add(label2);
            Controls.Add(panelBorder);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormPayment";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormPayment";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panelBorder.ResumeLayout(false);
            panelBorder.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
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
    }
}