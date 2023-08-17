using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EmployeesManagementSystem
{
    public partial class Employees : Form
    {
        Functions con;
        public Employees()
        {
            InitializeComponent();
            con = new Functions();
            ShowEmp();
            GetDepartment();
        }
        private void ShowEmp()
        {
            string Query = "select * from EmployeeTbl ";
            EmployeeList.DataSource = con.GetData(Query);
        }
        private void GetDepartment()
        {
            string Query = "select * from DepartmentTbl";
            DepCb.DisplayMember = con.GetData(Query).Columns["DepName"].ToString();
            DepCb.ValueMember = con.GetData(Query).Columns["DepId"].ToString();
            DepCb.DataSource = con.GetData(Query);
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
        }

        private void Employees_Load(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e) //AddBtn
        {
            try
            {
                if (EmpNameTb.Text == "" || GenCb.SelectedIndex == -1 || DepCb.SelectedIndex == -1 || DailySalTb.Text == "")
                {
                    MessageBox.Show("Missing Data!!!");
                }
                else
                {
                    string Name = EmpNameTb.Text;
                    string Gender = GenCb.SelectedItem.ToString();
                    int Dep = Convert.ToInt32(DepCb.SelectedValue.ToString());
                    string DOB = DOBTb.Value.Date.ToString();
                    string JDate = JDateTb.Value.Date.ToString();
                    int Salary = Convert.ToInt32(DailySalTb.Text);

                    string Query = "insert into EmployeeTbl values('{0}','{1}',{2},'{3}','{4}',{5})";
                    //. It replaces the {0} placeholder with the value of DepNameTb.Text, which is the department name.
                    Query = string.Format(Query, Name, Gender, Dep, DOB, JDate, Salary);
                    con.SetData(Query);
                    ShowEmp();
                    MessageBox.Show("Employee Added!");
                    EmpNameTb.Text = "";
                    DailySalTb.Text = "";
                    GenCb.SelectedIndex = -1;
                    DepCb.SelectedIndex = -1;

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void EmployeeList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void DeleteBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (EmpNameTb.Text == "")
                {
                    MessageBox.Show("Missing Data!!!");
                }
                else
                {


                    string Query = "delete from EmployeeTbl where EmpName ='{0}'";
                    //. It replaces the {0} placeholder with the value of DepNameTb.Text, which is the department name.
                    Query = string.Format(Query, EmpNameTb.Text);
                    con.SetData(Query);
                    ShowEmp();
                    MessageBox.Show("Employee Deleted!");
                    EmpNameTb.Text = "";
                    DailySalTb.Text = "";
                    GenCb.SelectedIndex = -1;
                    DepCb.SelectedIndex = -1;

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void UpdateBtn_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {
            salaries Obj = new salaries();
            Obj.Show();
            this.Hide();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            salaries Obj = new salaries();
            Obj.Show();
            this.Hide();
        }

        private void label10_Click(object sender, EventArgs e)
        {
            Departments Obj = new Departments();
            Obj.Show();
            this.Hide();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Departments Obj = new Departments();
            Obj.Show();
            this.Hide();
        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {

        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            Login Obj = new Login();
            Obj.Show();
            this.Hide();
        }

        private void label11_Click(object sender, EventArgs e)
        {
            Login Obj = new Login();
            Obj.Show();
            this.Hide();
        }
    }
}
