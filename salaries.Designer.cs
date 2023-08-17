namespace EmployeesManagementSystem
{
    partial class salaries
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(salaries));
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            AddBtn = new Button();
            PeriodTb = new DateTimePicker();
            EmpCb = new ComboBox();
            pictureBox2 = new PictureBox();
            panel2 = new Panel();
            label7 = new Label();
            label8 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            panel1 = new Panel();
            label1 = new Label();
            DaysTb = new TextBox();
            label5 = new Label();
            label6 = new Label();
            LogoutLbl = new Label();
            label10 = new Label();
            pictureBox5 = new PictureBox();
            pictureBox4 = new PictureBox();
            pictureBox3 = new PictureBox();
            pictureBox1 = new PictureBox();
            SalaryList = new DataGridView();
            AmountTb = new TextBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)SalaryList).BeginInit();
            SuspendLayout();
            // 
            // AddBtn
            // 
            AddBtn.BackColor = SystemColors.HotTrack;
            AddBtn.FlatStyle = FlatStyle.Flat;
            AddBtn.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            AddBtn.ForeColor = Color.White;
            AddBtn.Location = new Point(78, 602);
            AddBtn.Name = "AddBtn";
            AddBtn.Size = new Size(75, 34);
            AddBtn.TabIndex = 41;
            AddBtn.Text = "Add";
            AddBtn.UseVisualStyleBackColor = false;
            AddBtn.Click += AddBtn_Click;
            // 
            // PeriodTb
            // 
            PeriodTb.CalendarForeColor = SystemColors.HotTrack;
            PeriodTb.CalendarTitleForeColor = Color.AliceBlue;
            PeriodTb.Location = new Point(42, 363);
            PeriodTb.Name = "PeriodTb";
            PeriodTb.Size = new Size(202, 26);
            PeriodTb.TabIndex = 39;
            // 
            // EmpCb
            // 
            EmpCb.FormattingEnabled = true;
            EmpCb.Items.AddRange(new object[] { "" });
            EmpCb.Location = new Point(40, 212);
            EmpCb.Name = "EmpCb";
            EmpCb.Size = new Size(169, 28);
            EmpCb.TabIndex = 37;
            EmpCb.SelectionChangeCommitted += EmpCb_SelectionChangeCommitted;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(60, 106);
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
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label7.ForeColor = SystemColors.HotTrack;
            label7.Location = new Point(40, 405);
            label7.Name = "label7";
            label7.Size = new Size(113, 20);
            label7.TabIndex = 32;
            label7.Text = "Salary Amount";
            label7.Click += label7_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label8.ForeColor = SystemColors.HotTrack;
            label8.Location = new Point(40, 334);
            label8.Name = "label8";
            label8.Size = new Size(54, 20);
            label8.TabIndex = 31;
            label8.Text = "Period";
            label8.Click += label8_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label4.ForeColor = SystemColors.HotTrack;
            label4.Location = new Point(36, 254);
            label4.Name = "label4";
            label4.Size = new Size(115, 20);
            label4.TabIndex = 29;
            label4.Text = "Days Attended";
            label4.Click += label4_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = SystemColors.HotTrack;
            label3.Location = new Point(36, 189);
            label3.Name = "label3";
            label3.Size = new Size(79, 20);
            label3.TabIndex = 28;
            label3.Text = "Employee";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.White;
            label2.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = SystemColors.HotTrack;
            label2.Location = new Point(726, 153);
            label2.Name = "label2";
            label2.Size = new Size(164, 20);
            label2.TabIndex = 26;
            label2.Text = "Manage Employess";
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
            // DaysTb
            // 
            DaysTb.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            DaysTb.Location = new Point(40, 292);
            DaysTb.Name = "DaysTb";
            DaysTb.Size = new Size(171, 26);
            DaysTb.TabIndex = 44;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.ForeColor = SystemColors.HotTrack;
            label5.Location = new Point(915, 116);
            label5.Name = "label5";
            label5.Size = new Size(53, 20);
            label5.TabIndex = 59;
            label5.Text = "Salary";
            label5.Click += label5_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.ForeColor = SystemColors.HotTrack;
            label6.Location = new Point(752, 116);
            label6.Name = "label6";
            label6.Size = new Size(94, 20);
            label6.TabIndex = 58;
            label6.Text = "Department";
            label6.Click += label6_Click;
            // 
            // LogoutLbl
            // 
            LogoutLbl.AutoSize = true;
            LogoutLbl.ForeColor = SystemColors.HotTrack;
            LogoutLbl.Location = new Point(1045, 116);
            LogoutLbl.Name = "LogoutLbl";
            LogoutLbl.Size = new Size(59, 20);
            LogoutLbl.TabIndex = 57;
            LogoutLbl.Text = "Logout";
            LogoutLbl.Click += LogoutLbl_Click;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.ForeColor = SystemColors.HotTrack;
            label10.Location = new Point(595, 116);
            label10.Name = "label10";
            label10.Size = new Size(79, 20);
            label10.TabIndex = 56;
            label10.Text = "Employee";
            label10.Click += label10_Click;
            // 
            // pictureBox5
            // 
            pictureBox5.Image = (Image)resources.GetObject("pictureBox5.Image");
            pictureBox5.Location = new Point(991, 106);
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
            pictureBox4.Location = new Point(857, 106);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(48, 40);
            pictureBox4.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox4.TabIndex = 54;
            pictureBox4.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(698, 106);
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
            pictureBox1.Location = new Point(545, 106);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(48, 40);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 52;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // SalaryList
            // 
            SalaryList.AllowDrop = true;
            SalaryList.AllowUserToOrderColumns = true;
            SalaryList.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            SalaryList.BackgroundColor = Color.White;
            SalaryList.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.MenuHighlight;
            dataGridViewCellStyle1.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.False;
            SalaryList.DefaultCellStyle = dataGridViewCellStyle1;
            SalaryList.GridColor = Color.White;
            SalaryList.Location = new Point(484, 233);
            SalaryList.Name = "SalaryList";
            SalaryList.RowTemplate.Height = 25;
            SalaryList.Size = new Size(540, 374);
            SalaryList.TabIndex = 60;
            SalaryList.CellContentClick += SalaryList_CellContentClick;
            // 
            // AmountTb
            // 
            AmountTb.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            AmountTb.Location = new Point(38, 428);
            AmountTb.Name = "AmountTb";
            AmountTb.Size = new Size(171, 26);
            AmountTb.TabIndex = 61;
            AmountTb.TextChanged += textBox2_TextChanged;
            // 
            // salaries
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1128, 657);
            Controls.Add(AmountTb);
            Controls.Add(SalaryList);
            Controls.Add(label5);
            Controls.Add(label6);
            Controls.Add(LogoutLbl);
            Controls.Add(label10);
            Controls.Add(pictureBox5);
            Controls.Add(pictureBox4);
            Controls.Add(pictureBox3);
            Controls.Add(pictureBox1);
            Controls.Add(DaysTb);
            Controls.Add(AddBtn);
            Controls.Add(PeriodTb);
            Controls.Add(EmpCb);
            Controls.Add(pictureBox2);
            Controls.Add(panel2);
            Controls.Add(label7);
            Controls.Add(label8);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(panel1);
            Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(4);
            Name = "salaries";
            Text = "salaries";
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)SalaryList).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button button1;
        private DateTimePicker dateTimePicker2;
        private DateTimePicker dateTimePicker1;
        private DataGridView dataGridView1;
        private ComboBox comboBox1;
        private PictureBox pictureBox2;
        private Panel panel2;
        private Label label7;
        private Label label8;
        private Label label4;
        private Label label3;
        private Label label2;
        private Panel panel1;
        private Label label1;
        private TextBox textBox1;
        private Label label5;
        private Label label6;
        private Label label9;
        private Label label10;
        private PictureBox pictureBox5;
        private PictureBox pictureBox4;
        private PictureBox pictureBox3;
        private PictureBox pictureBox1;
        private Button AddBtn;
        private DateTimePicker PeriodTb;
        private ComboBox EmpCb;
        private TextBox DaysTb;
        private DataGridView SalaryList;
        private TextBox AmountTb;
        private Label LogoutLbl;
    }
}