namespace EventDriven.Project.UI.UserControlUI
{
    partial class AdmissionHistory
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
            flowAdmissions = new FlowLayoutPanel();
            label1 = new Label();
            panel1 = new Panel();
            btnSearch = new Button();
            textBox1 = new TextBox();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // flowAdmissions
            // 
            flowAdmissions.AutoScroll = true;
            flowAdmissions.BackColor = Color.FromArgb(217, 217, 217);
            flowAdmissions.Location = new Point(101, 185);
            flowAdmissions.Name = "flowAdmissions";
            flowAdmissions.Size = new Size(1410, 769);
            flowAdmissions.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(40, 56);
            label1.Name = "label1";
            label1.Size = new Size(258, 38);
            label1.TabIndex = 1;
            label1.Text = "Admission History";
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(11, 143, 172);
            panel1.Controls.Add(btnSearch);
            panel1.Controls.Add(textBox1);
            panel1.Location = new Point(101, 121);
            panel1.Name = "panel1";
            panel1.Size = new Size(1410, 58);
            panel1.TabIndex = 2;
            // 
            // btnSearch
            // 
            btnSearch.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSearch.Location = new Point(1294, 15);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(94, 34);
            btnSearch.TabIndex = 1;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Segoe UI", 12F);
            textBox1.Location = new Point(935, 15);
            textBox1.Name = "textBox1";
            textBox1.PlaceholderText = "Search Patient Name";
            textBox1.Size = new Size(353, 34);
            textBox1.TabIndex = 0;
            // 
            // AdmissionHistory
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Gainsboro;
            Controls.Add(panel1);
            Controls.Add(flowAdmissions);
            Controls.Add(label1);
            Name = "AdmissionHistory";
            Size = new Size(1637, 998);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private FlowLayoutPanel flowAdmissions;
        private Label label1;
        private Panel panel1;
        private TextBox textBox1;
        private Button btnSearch;
    }
}
