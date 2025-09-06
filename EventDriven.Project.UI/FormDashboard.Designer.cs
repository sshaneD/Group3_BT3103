namespace EventDriven.Project.UI
{
    partial class FormDashboard
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
            panel1 = new Panel();
            button7 = new Button();
            panel2 = new Panel();
            button6 = new Button();
            button5 = new Button();
            button4 = new Button();
            button3 = new Button();
            button2 = new Button();
            button1 = new Button();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(11, 143, 172);
            panel1.Controls.Add(button7);
            panel1.Location = new Point(-4, -1);
            panel1.Name = "panel1";
            panel1.Size = new Size(1404, 62);
            panel1.TabIndex = 0;
            // 
            // button7
            // 
            button7.Location = new Point(1297, 26);
            button7.Name = "button7";
            button7.Size = new Size(94, 29);
            button7.TabIndex = 3;
            button7.Text = "Log out";
            button7.UseVisualStyleBackColor = true;
            button7.Click += button7_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.White;
            panel2.Controls.Add(button6);
            panel2.Controls.Add(button5);
            panel2.Controls.Add(button4);
            panel2.Controls.Add(button3);
            panel2.Controls.Add(button2);
            panel2.Controls.Add(button1);
            panel2.Controls.Add(pictureBox1);
            panel2.Location = new Point(4, 61);
            panel2.Name = "panel2";
            panel2.Size = new Size(283, 683);
            panel2.TabIndex = 1;
            // 
            // button6
            // 
            button6.Font = new Font("Microsoft JhengHei UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button6.Location = new Point(34, 583);
            button6.Name = "button6";
            button6.Size = new Size(206, 46);
            button6.TabIndex = 7;
            button6.Text = "Discharge";
            button6.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            button5.Font = new Font("Microsoft JhengHei UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button5.Location = new Point(34, 519);
            button5.Name = "button5";
            button5.Size = new Size(206, 46);
            button5.TabIndex = 6;
            button5.Text = "Billing";
            button5.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            button4.Font = new Font("Microsoft JhengHei UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button4.Location = new Point(34, 451);
            button4.Name = "button4";
            button4.Size = new Size(206, 46);
            button4.TabIndex = 5;
            button4.Text = "Admission";
            button4.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Font = new Font("Microsoft JhengHei UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button3.Location = new Point(34, 385);
            button3.Name = "button3";
            button3.Size = new Size(206, 46);
            button3.TabIndex = 4;
            button3.Text = "Room Search";
            button3.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Font = new Font("Microsoft JhengHei UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.Location = new Point(34, 318);
            button2.Name = "button2";
            button2.Size = new Size(206, 46);
            button2.TabIndex = 3;
            button2.Text = "Patient Information";
            button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.BackColor = Color.LightGray;
            button1.Font = new Font("Microsoft JhengHei UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.Location = new Point(34, 255);
            button1.Name = "button1";
            button1.Size = new Size(206, 46);
            button1.TabIndex = 2;
            button1.Text = "Dashboard";
            button1.UseVisualStyleBackColor = false;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.Modern_Minimalist_Black_and_White_Report_Presentation__17_;
            pictureBox1.Location = new Point(55, 80);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(167, 153);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.Modern_Minimalist_Black_and_White_Report_Presentation__19_;
            pictureBox2.Location = new Point(322, 104);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(1044, 566);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 2;
            pictureBox2.TabStop = false;
            // 
            // FormDashboard
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(217, 217, 217);
            ClientSize = new Size(1399, 708);
            Controls.Add(pictureBox2);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "FormDashboard";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Dashboard";
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Button button6;
        private Button button5;
        private Button button4;
        private Button button3;
        private Button button2;
        private Button button1;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private Button button7;
    }
}