using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EmployeesManagementSystem
{
    public partial class Departments : Form
    {
        Functions con;

        public Departments()
        {
            InitializeComponent();
            con = new Functions();
            ShowDepartments();
        }
        private void ShowDepartments()
        {
            string Query = "select * from DepartmentTbl ";
            Deplist.DataSource = con.GetData(Query);
        }
        private void AddBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (DepNameTb.Text == "")
                {
                    MessageBox.Show("Missing Data!!!");
                }
                else
                {
                    string Dep = DepNameTb.Text;
                    string Query = "insert into DepartmentTbl values('{0}')";
                    //. It replaces the {0} placeholder with the value of DepNameTb.Text, which is the department name.
                    Query = string.Format(Query, DepNameTb.Text);
                    con.SetData(Query);
                    ShowDepartments();
                    MessageBox.Show("Department Added!");
                    DepNameTb.Text = "";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void Departments_Load(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e) //employee label
        {
            Employees Obj = new Employees();
            Obj.Show();
            this.Hide();
        }

        private void label6_Click(object sender, EventArgs e)
        {
            Login Obj = new Login();
            Obj.Show();
            this.Hide();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            Login Obj = new Login();
            Obj.Show();
            this.Hide();
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void Deplist_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        int key = 0;
        public void Deplist_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {


        }

        private void EditBtn_Click(object sender, EventArgs e)
        {




        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (DepNameTb.Text == "")
                {
                    MessageBox.Show("Missing Data!!!");
                }
                else
                {
                    string Dep = DepNameTb.Text;
                    string Query = "Delete from DepartmentTbl where  DepName='{0}'";
                    //. It replaces the {0} placeholder with the value of DepNameTb.Text, which is the department name.
                    Query = string.Format(Query, DepNameTb.Text);
                    con.SetData(Query);
                    ShowDepartments();
                    MessageBox.Show("Department Deleted!");
                    DepNameTb.Text = "";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void DepNameTb_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)//employee icon
        {
            Employees Obj = new Employees();
            Obj.Show();
            this.Hide();
        }

        private void SalaryLbl_Click(object sender, EventArgs e)
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
    }
}
