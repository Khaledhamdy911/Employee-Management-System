namespace EmployeesManagementSystem
{
    partial class Departments
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Departments));
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            AddBtn = new Button();
            pictureBox2 = new PictureBox();
            panel2 = new Panel();
            label3 = new Label();
            DepNameTb = new TextBox();
            label2 = new Label();
            panel1 = new Panel();
            label1 = new Label();
            label4 = new Label();
            pictureBox1 = new PictureBox();
            pictureBox3 = new PictureBox();
            pictureBox4 = new PictureBox();
            pictureBox5 = new PictureBox();
            EmpLbl = new Label();
            label6 = new Label();
            label7 = new Label();
            SalaryLbl = new Label();
            Deplist = new DataGridView();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Deplist).BeginInit();
            SuspendLayout();
            // 
            // AddBtn
            // 
            AddBtn.BackColor = SystemColors.HotTrack;
            AddBtn.FlatStyle = FlatStyle.Flat;
            AddBtn.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            AddBtn.ForeColor = Color.White;
            AddBtn.Location = new Point(32, 260);
            AddBtn.Name = "AddBtn";
            AddBtn.Size = new Size(75, 34);
            AddBtn.TabIndex = 41;
            AddBtn.Text = "Add";
            AddBtn.UseVisualStyleBackColor = false;
            AddBtn.Click += AddBtn_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(64, 106);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(88, 80);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 36;
            pictureBox2.TabStop = false;
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.HotTrack;
            panel2.Dock = DockStyle.Bottom;
            panel2.ForeColor = Color.Coral;
            panel2.Location = new Point(0, 642);
            panel2.Name = "panel2";
            panel2.Size = new Size(1128, 15);
            panel2.TabIndex = 35;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = SystemColors.HotTrack;
            label3.Location = new Point(36, 189);
            label3.Name = "label3";
            label3.Size = new Size(140, 20);
            label3.TabIndex = 28;
            label3.Text = "Department Name";
            // 
            // DepNameTb
            // 
            DepNameTb.AcceptsReturn = true;
            DepNameTb.AcceptsTab = true;
            DepNameTb.AllowDrop = true;
            DepNameTb.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            DepNameTb.Location = new Point(38, 212);
            DepNameTb.Name = "DepNameTb";
            DepNameTb.Size = new Size(171, 26);
            DepNameTb.TabIndex = 27;
            DepNameTb.TextChanged += DepNameTb_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.White;
            label2.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = SystemColors.HotTrack;
            label2.Location = new Point(729, 170);
            label2.Name = "label2";
            label2.Size = new Size(182, 20);
            label2.TabIndex = 26;
            label2.Text = "Manage Departments";
            label2.Click += label2_Click;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.HotTrack;
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1128, 100);
            panel1.TabIndex = 24;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.HotTrack;
            label1.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(651, 28);
            label1.Name = "label1";
            label1.Size = new Size(260, 20);
            label1.TabIndex = 1;
            label1.Text = "Employee Management System";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.ForeColor = SystemColors.HotTrack;
            label4.Location = new Point(767, 210);
            label4.Name = "label4";
            label4.Size = new Size(131, 20);
            label4.TabIndex = 43;
            label4.Text = "Departments List";
            label4.Click += label4_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(515, 116);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(48, 40);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 44;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(668, 116);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(48, 40);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 45;
            pictureBox3.TabStop = false;
            // 
            // pictureBox4
            // 
            pictureBox4.Image = (Image)resources.GetObject("pictureBox4.Image");
            pictureBox4.Location = new Point(827, 116);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(48, 40);
            pictureBox4.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox4.TabIndex = 46;
            pictureBox4.TabStop = false;
            pictureBox4.Click += pictureBox4_Click;
            // 
            // pictureBox5
            // 
            pictureBox5.Image = (Image)resources.GetObject("pictureBox5.Image");
            pictureBox5.Location = new Point(961, 116);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(48, 40);
            pictureBox5.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox5.TabIndex = 47;
            pictureBox5.TabStop = false;
            pictureBox5.Click += pictureBox5_Click;
            // 
            // EmpLbl
            // 
            EmpLbl.AutoSize = true;
            EmpLbl.ForeColor = SystemColors.HotTrack;
            EmpLbl.Location = new Point(565, 126);
            EmpLbl.Name = "EmpLbl";
            EmpLbl.Size = new Size(79, 20);
            EmpLbl.TabIndex = 48;
            EmpLbl.Text = "Employee";
            EmpLbl.Click += label5_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.ForeColor = SystemColors.HotTrack;
            label6.Location = new Point(1015, 126);
            label6.Name = "label6";
            label6.Size = new Size(59, 20);
            label6.TabIndex = 49;
            label6.Text = "Logout";
            label6.Click += label6_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.ForeColor = SystemColors.HotTrack;
            label7.Location = new Point(722, 126);
            label7.Name = "label7";
            label7.Size = new Size(94, 20);
            label7.TabIndex = 50;
            label7.Text = "Department";
            label7.Click += label7_Click;
            // 
            // SalaryLbl
            // 
            SalaryLbl.AutoSize = true;
            SalaryLbl.ForeColor = SystemColors.HotTrack;
            SalaryLbl.Location = new Point(885, 126);
            SalaryLbl.Name = "SalaryLbl";
            SalaryLbl.Size = new Size(53, 20);
            SalaryLbl.TabIndex = 51;
            SalaryLbl.Text = "Salary";
            SalaryLbl.Click += SalaryLbl_Click;
            // 
            // Deplist
            // 
            Deplist.AllowDrop = true;
            Deplist.AllowUserToOrderColumns = true;
            Deplist.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            Deplist.BackgroundColor = Color.White;
            Deplist.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.MenuHighlight;
            dataGridViewCellStyle1.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.False;
            Deplist.DefaultCellStyle = dataGridViewCellStyle1;
            Deplist.GridColor = Color.White;
            Deplist.Location = new Point(552, 250);
            Deplist.Name = "Deplist";
            Deplist.RowTemplate.Height = 25;
            Deplist.Size = new Size(503, 374);
            Deplist.TabIndex = 52;
            Deplist.CellContentClick += Deplist_CellContentClick_1;
            // 
            // button1
            // 
            button1.BackColor = Color.Red;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            button1.ForeColor = Color.White;
            button1.Location = new Point(134, 260);
            button1.Name = "button1";
            button1.Size = new Size(75, 34);
            button1.TabIndex = 53;
            button1.Text = "Delete";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // Departments
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1128, 657);
            Controls.Add(button1);
            Controls.Add(Deplist);
            Controls.Add(SalaryLbl);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(EmpLbl);
            Controls.Add(pictureBox5);
            Controls.Add(pictureBox4);
            Controls.Add(pictureBox3);
            Controls.Add(pictureBox1);
            Controls.Add(label4);
            Controls.Add(AddBtn);
            Controls.Add(pictureBox2);
            Controls.Add(panel2);
            Controls.Add(label3);
            Controls.Add(DepNameTb);
            Controls.Add(label2);
            Controls.Add(panel1);
            Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(4);
            Name = "Departments";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Departments";
            Load += Departments_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            ((System.ComponentModel.ISupportInitialize)Deplist).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button AddBtn;
        private PictureBox pictureBox2;
        private Panel panel2;
        private Label label3;
        private Label label2;
        private Panel panel1;
        private Label label1;
        private Label label4;
        private PictureBox pictureBox1;
        private PictureBox pictureBox3;
        private PictureBox pictureBox4;
        private PictureBox pictureBox5;
        private Label EmpLbl;
        private Label label6;
        private Label label7;
        private Label label8;
        private DataGridView Deplist;
        private Button button1;
        private TextBox DepNameTb;
        private Label SalaryLbl;
    }
}