namespace EventDriven.Project.UI
{
    partial class FormLogin
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
            txtUsername = new TextBox();
            lblFname = new Label();
            txtPassword = new TextBox();
            lblPassword = new Label();
            btnCancel = new Button();
            btnLogin = new Button();
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // txtUsername
            // 
            txtUsername.Font = new Font("Segoe UI", 13.2000008F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtUsername.Location = new Point(99, 258);
            txtUsername.Margin = new Padding(3, 4, 3, 4);
            txtUsername.Multiline = true;
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(321, 39);
            txtUsername.TabIndex = 3;
            // 
            // lblFname
            // 
            lblFname.AutoSize = true;
            lblFname.Font = new Font("Cambria Math", 13.8F);
            lblFname.ForeColor = SystemColors.ButtonHighlight;
            lblFname.Location = new Point(82, 168);
            lblFname.Name = "lblFname";
            lblFname.Size = new Size(161, 129);
            lblFname.TabIndex = 2;
            lblFname.Text = "Username:";
            // 
            // txtPassword
            // 
            txtPassword.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtPassword.Location = new Point(99, 362);
            txtPassword.Margin = new Padding(3, 4, 3, 4);
            txtPassword.Multiline = true;
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(319, 39);
            txtPassword.TabIndex = 5;
            txtPassword.TextChanged += txtPassword_TextChanged;
            // 
            // lblPassword
            // 
            lblPassword.AutoSize = true;
            lblPassword.Font = new Font("Cambria Math", 13.8F);
            lblPassword.ForeColor = SystemColors.ButtonHighlight;
            lblPassword.Location = new Point(83, 272);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new Size(158, 129);
            lblPassword.TabIndex = 4;
            lblPassword.Text = "Password:";
            // 
            // btnCancel
            // 
            btnCancel.BackColor = Color.FromArgb(123, 183, 193);
            btnCancel.Font = new Font("Palatino Linotype", 12F);
            btnCancel.Location = new Point(264, 446);
            btnCancel.Margin = new Padding(3, 4, 3, 4);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(141, 44);
            btnCancel.TabIndex = 16;
            btnCancel.Text = "Exit";
            btnCancel.UseVisualStyleBackColor = false;
            btnCancel.Click += btnCancel_Click;
            // 
            // btnLogin
            // 
            btnLogin.BackColor = Color.FromArgb(123, 183, 193);
            btnLogin.Font = new Font("Palatino Linotype", 12F);
            btnLogin.Location = new Point(107, 446);
            btnLogin.Margin = new Padding(3, 4, 3, 4);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(141, 44);
            btnLogin.TabIndex = 15;
            btnLogin.Text = "Login";
            btnLogin.UseVisualStyleBackColor = false;
            btnLogin.Click += btnLogin_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(11, 143, 172);
            panel1.Controls.Add(txtUsername);
            panel1.Controls.Add(btnCancel);
            panel1.Controls.Add(txtPassword);
            panel1.Controls.Add(btnLogin);
            panel1.Controls.Add(lblFname);
            panel1.Controls.Add(lblPassword);
            panel1.Location = new Point(0, -3);
            panel1.Name = "panel1";
            panel1.Size = new Size(540, 714);
            panel1.TabIndex = 17;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.Modern_Minimalist_Black_and_White_Report_Presentation__15_;
            pictureBox1.Location = new Point(343, 60);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(1164, 544);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 18;
            pictureBox1.TabStop = false;
            // 
            // FormLogin
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(217, 217, 217);
            ClientSize = new Size(1399, 708);
            Controls.Add(panel1);
            Controls.Add(pictureBox1);
            Margin = new Padding(3, 4, 3, 4);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FormLogin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TextBox txtUsername;
        private Label lblFname;
        private TextBox txtPassword;
        private Label lblPassword;
        private Button btnCancel;
        private Button btnLogin;
        private Panel panel1;
        private PictureBox pictureBox1;
    }
}