namespace EmployeesManagementSystem
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            panel1 = new Panel();
            label1 = new Label();
            label4 = new Label();
            PasswordTb = new TextBox();
            label3 = new Label();
            UNameTb = new TextBox();
            pictureBox1 = new PictureBox();
            LoginBtn = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.HotTrack;
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(186, 450);
            panel1.TabIndex = 1;
            panel1.Paint += panel1_Paint;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.White;
            label1.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.HotTrack;
            label1.Location = new Point(343, 30);
            label1.Name = "label1";
            label1.Size = new Size(260, 20);
            label1.TabIndex = 1;
            label1.Text = "Employee Management System";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label4.ForeColor = SystemColors.HotTrack;
            label4.Location = new Point(389, 279);
            label4.Name = "label4";
            label4.Size = new Size(78, 20);
            label4.TabIndex = 13;
            label4.Text = "Password";
            label4.Click += label4_Click;
            // 
            // PasswordTb
            // 
            PasswordTb.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            PasswordTb.Location = new Point(391, 302);
            PasswordTb.Name = "PasswordTb";
            PasswordTb.PasswordChar = '*';
            PasswordTb.Size = new Size(171, 26);
            PasswordTb.TabIndex = 12;
            PasswordTb.TextChanged += textBox2_TextChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = SystemColors.HotTrack;
            label3.Location = new Point(389, 207);
            label3.Name = "label3";
            label3.Size = new Size(89, 20);
            label3.TabIndex = 11;
            label3.Text = "User Name";
            label3.Click += label3_Click;
            // 
            // UNameTb
            // 
            UNameTb.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            UNameTb.Location = new Point(391, 230);
            UNameTb.Name = "UNameTb";
            UNameTb.Size = new Size(171, 26);
            UNameTb.TabIndex = 10;
            UNameTb.TextChanged += textBox1_TextChanged;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(416, 73);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(127, 115);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 14;
            pictureBox1.TabStop = false;
            // 
            // LoginBtn
            // 
            LoginBtn.FlatStyle = FlatStyle.Flat;
            LoginBtn.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            LoginBtn.ForeColor = SystemColors.HotTrack;
            LoginBtn.Location = new Point(445, 370);
            LoginBtn.Name = "LoginBtn";
            LoginBtn.Size = new Size(75, 34);
            LoginBtn.TabIndex = 15;
            LoginBtn.Text = "Login";
            LoginBtn.UseVisualStyleBackColor = true;
            LoginBtn.Click += button1_Click;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(800, 450);
            Controls.Add(LoginBtn);
            Controls.Add(pictureBox1);
            Controls.Add(label4);
            Controls.Add(PasswordTb);
            Controls.Add(label3);
            Controls.Add(UNameTb);
            Controls.Add(label1);
            Controls.Add(panel1);
            Name = "Login";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login";
            Load += Login_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private Label label4;
        private TextBox PasswordTb;
        private Label label3;
        private TextBox UNameTb;
        private PictureBox pictureBox1;
        private Button LoginBtn;
    }
}