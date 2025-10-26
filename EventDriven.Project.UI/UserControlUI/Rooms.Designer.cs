namespace EventDriven.Project.UI.UserControlUI
{
    partial class Rooms
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
            label2 = new Label();
            dataGridView1 = new DataGridView();
            panel1 = new Panel();
            button1 = new Button();
            btnWard = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Silver;
            label2.Font = new Font("Microsoft JhengHei UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.ButtonHighlight;
            label2.Location = new Point(262, 132);
            label2.Name = "label2";
            label2.Size = new Size(113, 38);
            label2.TabIndex = 9;
            label2.Text = "WARD\r\n";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(178, 384);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(1307, 507);
            dataGridView1.TabIndex = 10;
            // 
            // panel1
            // 
            panel1.BackColor = Color.LightGray;
            panel1.Location = new Point(178, 344);
            panel1.Name = "panel1";
            panel1.Size = new Size(1307, 34);
            panel1.TabIndex = 11;
            // 
            // button1
            // 
            button1.Font = new Font("Microsoft JhengHei UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.Location = new Point(1447, 910);
            button1.Name = "button1";
            button1.Size = new Size(110, 39);
            button1.TabIndex = 12;
            button1.Text = "Back";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // btnWard
            // 
            btnWard.BackColor = Color.Silver;
            btnWard.FlatAppearance.BorderSize = 0;
            btnWard.FlatStyle = FlatStyle.Flat;
            btnWard.Location = new Point(178, 96);
            btnWard.Name = "btnWard";
            btnWard.Size = new Size(287, 205);
            btnWard.TabIndex = 8;
            btnWard.UseVisualStyleBackColor = false;
            btnWard.Click += btnWard_Click;
            // 
            // Rooms
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(button1);
            Controls.Add(panel1);
            Controls.Add(dataGridView1);
            Controls.Add(label2);
            Controls.Add(btnWard);
            Name = "Rooms";
            Size = new Size(1637, 998);
            Load += Rooms_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label2;
        private DataGridView dataGridView1;
        private Panel panel1;
        private Button button1;
        private Button btnWard;
    }
}
