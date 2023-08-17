namespace EmployeesManagementSystem
{
    partial class Employees
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Employees));
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            panel1 = new Panel();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            EmpNameTb = new TextBox();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            DailySalTb = new TextBox();
            label7 = new Label();
            label8 = new Label();
            panel2 = new Panel();
            pictureBox2 = new PictureBox();
            GenCb = new ComboBox();
            DepCb = new ComboBox();
            DOBTb = new DateTimePicker();
            JDateTb = new DateTimePicker();
            AddBtn = new Button();
            label9 = new Label();
            label10 = new Label();
            label11 = new Label();
            label12 = new Label();
            pictureBox5 = new PictureBox();
            pictureBox4 = new PictureBox();
            pictureBox3 = new PictureBox();
            pictureBox1 = new PictureBox();
            EmployeeList = new DataGridView();
            DeleteBtn = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)EmployeeList).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.HotTrack;
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1128, 100);
            panel1.TabIndex = 0;
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
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.White;
            label2.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = SystemColors.HotTrack;
            label2.Location = new Point(611, 177);
            label2.Name = "label2";
            label2.Size = new Size(164, 20);
            label2.TabIndex = 2;
            label2.Text = "Manage Employess";
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = SystemColors.HotTrack;
            label3.Location = new Point(36, 189);
            label3.Name = "label3";
            label3.Size = new Size(125, 20);
            label3.TabIndex = 5;
            label3.Text = "Employee Name";
            label3.Click += label3_Click;
            // 
            // EmpNameTb
            // 
            EmpNameTb.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            EmpNameTb.Location = new Point(38, 212);
            EmpNameTb.Name = "EmpNameTb";
            EmpNameTb.Size = new Size(171, 26);
            EmpNameTb.TabIndex = 4;
            EmpNameTb.TextChanged += textBox1_TextChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label4.ForeColor = SystemColors.HotTrack;
            label4.Location = new Point(36, 254);
            label4.Name = "label4";
            label4.Size = new Size(137, 20);
            label4.TabIndex = 7;
            label4.Text = "Employee Gender";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label5.ForeColor = SystemColors.HotTrack;
            label5.Location = new Point(36, 321);
            label5.Name = "label5";
            label5.Size = new Size(168, 20);
            label5.TabIndex = 9;
            label5.Text = "Employee Department";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label6.ForeColor = SystemColors.HotTrack;
            label6.Location = new Point(36, 530);
            label6.Name = "label6";
            label6.Size = new Size(165, 20);
            label6.TabIndex = 15;
            label6.Text = "Employee Daily Salary";
            label6.Click += label6_Click;
            // 
            // DailySalTb
            // 
            DailySalTb.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            DailySalTb.Location = new Point(38, 559);
            DailySalTb.Name = "DailySalTb";
            DailySalTb.Size = new Size(171, 26);
            DailySalTb.TabIndex = 14;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label7.ForeColor = SystemColors.HotTrack;
            label7.Location = new Point(36, 468);
            label7.Name = "label7";
            label7.Size = new Size(77, 20);
            label7.TabIndex = 13;
            label7.Text = "Join Date";
            label7.Click += label7_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label8.ForeColor = SystemColors.HotTrack;
            label8.Location = new Point(36, 397);
            label8.Name = "label8";
            label8.Size = new Size(102, 20);
            label8.TabIndex = 11;
            label8.Text = "Date Of Birth";
            label8.Click += label8_Click;
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.HotTrack;
            panel2.Dock = DockStyle.Bottom;
            panel2.ForeColor = Color.Coral;
            panel2.Location = new Point(0, 642);
            panel2.Name = "panel2";
            panel2.Size = new Size(1128, 15);
            panel2.TabIndex = 16;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(60, 106);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(88, 80);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 17;
            pictureBox2.TabStop = false;
            // 
            // GenCb
            // 
            GenCb.FormattingEnabled = true;
            GenCb.Items.AddRange(new object[] { "Male", "Female" });
            GenCb.Location = new Point(40, 278);
            GenCb.Name = "GenCb";
            GenCb.Size = new Size(169, 28);
            GenCb.TabIndex = 18;
            // 
            // DepCb
            // 
            DepCb.FormattingEnabled = true;
            DepCb.Location = new Point(40, 351);
            DepCb.Name = "DepCb";
            DepCb.Size = new Size(169, 28);
            DepCb.TabIndex = 19;
            DepCb.SelectedIndexChanged += comboBox2_SelectedIndexChanged;
            // 
            // DOBTb
            // 
            DOBTb.CalendarForeColor = SystemColors.HotTrack;
            DOBTb.CalendarTitleForeColor = Color.AliceBlue;
            DOBTb.Format = DateTimePickerFormat.Short;
            DOBTb.Location = new Point(38, 426);
            DOBTb.Name = "DOBTb";
            DOBTb.Size = new Size(123, 26);
            DOBTb.TabIndex = 20;
            // 
            // JDateTb
            // 
            JDateTb.CalendarForeColor = SystemColors.HotTrack;
            JDateTb.CalendarTitleForeColor = Color.AliceBlue;
            JDateTb.Format = DateTimePickerFormat.Short;
            JDateTb.Location = new Point(40, 494);
            JDateTb.MinDate = new DateTime(2023, 7, 23, 0, 0, 0, 0);
            JDateTb.Name = "JDateTb";
            JDateTb.Size = new Size(121, 26);
            JDateTb.TabIndex = 21;
            // 
            // AddBtn
            // 
            AddBtn.BackColor = SystemColors.HotTrack;
            AddBtn.FlatStyle = FlatStyle.Flat;
            AddBtn.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            AddBtn.ForeColor = Color.White;
            AddBtn.Location = new Point(12, 602);
            AddBtn.Name = "AddBtn";
            AddBtn.Size = new Size(75, 34);
            AddBtn.TabIndex = 22;
            AddBtn.Text = "Add";
            AddBtn.UseVisualStyleBackColor = false;
            AddBtn.Click += button1_Click;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.ForeColor = SystemColors.HotTrack;
            label9.Location = new Point(931, 116);
            label9.Name = "label9";
            label9.Size = new Size(53, 20);
            label9.TabIndex = 59;
            label9.Text = "Salary";
            label9.Click += label9_Click;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.ForeColor = SystemColors.HotTrack;
            label10.Location = new Point(768, 116);
            label10.Name = "label10";
            label10.Size = new Size(94, 20);
            label10.TabIndex = 58;
            label10.Text = "Department";
            label10.Click += label10_Click;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.ForeColor = SystemColors.HotTrack;
            label11.Location = new Point(1061, 116);
            label11.Name = "label11";
            label11.Size = new Size(59, 20);
            label11.TabIndex = 57;
            label11.Text = "Logout";
            label11.Click += label11_Click;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.ForeColor = SystemColors.HotTrack;
            label12.Location = new Point(611, 116);
            label12.Name = "label12";
            label12.Size = new Size(79, 20);
            label12.TabIndex = 56;
            label12.Text = "Employee";
            // 
            // pictureBox5
            // 
            pictureBox5.Image = (Image)resources.GetObject("pictureBox5.Image");
            pictureBox5.Location = new Point(1007, 106);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(48, 40);
            pictureBox5.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox5.TabIndex = 55;
            pictureBox5.TabStop = false;
            pictureBox5.Click += pictureBox5_Click;
            // 
            // pictureBox4
            // 
            pictureBox4.Image = (Image)resources.GetObject("pictureBox4.Image");
            pictureBox4.Location = new Point(873, 106);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(48, 40);
            pictureBox4.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox4.TabIndex = 54;
            pictureBox4.TabStop = false;
            pictureBox4.Click += pictureBox4_Click;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(714, 106);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(48, 40);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 53;
            pictureBox3.TabStop = false;
            pictureBox3.Click += pictureBox3_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(561, 106);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(48, 40);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 52;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click_1;
            // 
            // EmployeeList
            // 
            EmployeeList.AllowDrop = true;
            EmployeeList.AllowUserToOrderColumns = true;
            EmployeeList.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            EmployeeList.BackgroundColor = Color.White;
            EmployeeList.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.MenuHighlight;
            dataGridViewCellStyle1.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.False;
            EmployeeList.DefaultCellStyle = dataGridViewCellStyle1;
            EmployeeList.GridColor = Color.White;
            EmployeeList.Location = new Point(294, 200);
            EmployeeList.Name = "EmployeeList";
            EmployeeList.RowTemplate.Height = 25;
            EmployeeList.Size = new Size(822, 436);
            EmployeeList.TabIndex = 60;
            EmployeeList.CellContentClick += EmployeeList_CellContentClick;
            // 
            // DeleteBtn
            // 
            DeleteBtn.BackColor = Color.Red;
            DeleteBtn.FlatStyle = FlatStyle.Flat;
            DeleteBtn.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            DeleteBtn.ForeColor = Color.Black;
            DeleteBtn.Location = new Point(135, 602);
            DeleteBtn.Name = "DeleteBtn";
            DeleteBtn.Size = new Size(75, 34);
            DeleteBtn.TabIndex = 61;
            DeleteBtn.Text = "Delete";
            DeleteBtn.UseVisualStyleBackColor = false;
            DeleteBtn.Click += DeleteBtn_Click;
            // 
            // Employees
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1128, 657);
            Controls.Add(DeleteBtn);
            Controls.Add(EmployeeList);
            Controls.Add(label9);
            Controls.Add(label10);
            Controls.Add(label11);
            Controls.Add(label12);
            Controls.Add(pictureBox5);
            Controls.Add(pictureBox4);
            Controls.Add(pictureBox3);
            Controls.Add(pictureBox1);
            Controls.Add(AddBtn);
            Controls.Add(JDateTb);
            Controls.Add(DOBTb);
            Controls.Add(DepCb);
            Controls.Add(GenCb);
            Controls.Add(pictureBox2);
            Controls.Add(panel2);
            Controls.Add(label6);
            Controls.Add(DailySalTb);
            Controls.Add(label7);
            Controls.Add(label8);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(EmpNameTb);
            Controls.Add(label2);
            Controls.Add(panel1);
            Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(4);
            Name = "Employees";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Employees";
            Load += Employees_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)EmployeeList).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox EmpNameTb;
        private Label label4;
        private Label label5;
        private Label label6;
        private TextBox DailySalTb;
        private Label label7;
        private Label label8;
        private Panel panel2;
        private PictureBox pictureBox2;
        private ComboBox GenCh;
        private ComboBox DepCh;
        private DateTimePicker DOBTb;
        private DateTimePicker JDate;
        private Button AddBtn;
        private Button UpdateBtn;
        private Label label9;
        private Label label10;
        private Label label11;
        private Label label12;
        private PictureBox pictureBox5;
        private PictureBox pictureBox4;
        private PictureBox pictureBox3;
        private PictureBox pictureBox1;
        private DataGridView EmployeeList;
        private ComboBox GenCb;
        private ComboBox DepCb;
        private DateTimePicker JDateTb;
        private Button DeleteBtn;
    }
}