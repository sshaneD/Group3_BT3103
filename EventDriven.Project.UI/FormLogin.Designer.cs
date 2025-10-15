
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
            txtUsername.Font = new Font("Segoe UI", 13.2F);
            txtUsername.Location = new Point(123, 422);
            txtUsername.Margin = new Padding(3, 4, 3, 4);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(442, 37);
            txtUsername.TabIndex = 3;
            txtUsername.TextChanged += txtUsername_TextChanged;
            // 
            // lblFname
            // 
            lblFname.AutoSize = true;
            lblFname.Font = new Font("Cambria Math", 13.2F);
            lblFname.ForeColor = SystemColors.ButtonHighlight;
            lblFname.Location = new Point(106, 341);
            lblFname.Name = "lblFname";
            lblFname.Size = new Size(153, 123);
            lblFname.TabIndex = 2;
            lblFname.Text = "Username:";
            // 
            // txtPassword
            // 
            txtPassword.Font = new Font("Segoe UI", 13.2F);
            txtPassword.Location = new Point(123, 563);
            txtPassword.Margin = new Padding(3, 4, 3, 4);
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '*';
            txtPassword.Size = new Size(442, 37);
            txtPassword.TabIndex = 5;
            txtPassword.UseSystemPasswordChar = true;
            txtPassword.KeyPress += txtPassword_KeyPress;
            // 
            // lblPassword
            // 
            lblPassword.AutoSize = true;
            lblPassword.Font = new Font("Cambria Math", 13.2F);
            lblPassword.ForeColor = SystemColors.ButtonHighlight;
            lblPassword.Location = new Point(107, 483);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new Size(150, 123);
            lblPassword.TabIndex = 4;
            lblPassword.Text = "Password:";
            // 
            // btnCancel
            // 
            btnCancel.BackColor = Color.FromArgb(123, 183, 193);
            btnCancel.Font = new Font("Microsoft Sans Serif", 13.2000008F);
            btnCancel.Location = new Point(358, 674);
            btnCancel.Margin = new Padding(3, 4, 3, 4);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(158, 49);
            btnCancel.TabIndex = 16;
            btnCancel.Text = "Exit";
            btnCancel.UseVisualStyleBackColor = false;
            btnCancel.Click += btnCancel_Click;
            // 
            // btnLogin
            // 
            btnLogin.BackColor = Color.FromArgb(123, 183, 193);
            btnLogin.Font = new Font("Microsoft Sans Serif", 13.2000008F);
            btnLogin.Location = new Point(158, 674);
            btnLogin.Margin = new Padding(3, 4, 3, 4);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(158, 49);
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
            panel1.Dock = DockStyle.Left;
            panel1.Font = new Font("Microsoft Sans Serif", 13.2000008F);
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(737, 1080);
            panel1.TabIndex = 17;
            panel1.Paint += panel1_Paint;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.Modern_Minimalist_Black_and_White_Report_Presentation__15_;
            pictureBox1.Location = new Point(504, 107);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(1656, 869);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 18;
            pictureBox1.TabStop = false;
            // 
            // FormLogin
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(217, 217, 217);
            ClientSize = new Size(1920, 1080);
            Controls.Add(panel1);
            Controls.Add(pictureBox1);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 4, 3, 4);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FormLogin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login";
            WindowState = FormWindowState.Maximized;
            Load += FormLogin_Load;
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