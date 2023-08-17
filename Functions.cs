using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeesManagementSystem
{
    internal class Functions
    {
        // con used to manage the database connection.
        private SqlConnection con;
        //  cmd  used to send SQL queries to the database.
        private SqlCommand cmd;
        // dt used to store data retrieved from a database in tabular form. 
        private DataTable dt;
        // contains information about the database server, credentials, and other parameters required to establish a connection to the database.
        private string ConStr;
        public Functions() {
         ConStr = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\khaled\Documents\EmpMDb.mdf;Integrated Security=True;Connect Timeout=30";
        con = new SqlConnection(ConStr);
            // cmd will be associated with the same database connection.
            cmd = con.CreateCommand();
            cmd.Connection = con;
        }                    
        public DataTable GetData(String Query)//enter sql query in parameter to return data table
        {
            //This DataTable will be used to store the data retrieved from the database.
            dt = new DataTable();
            //manipulating and getting data 
            SqlDataAdapter sda= new SqlDataAdapter(Query, ConStr);
            //filling datatable
            sda.Fill(dt);
            return dt;
        }
        public int SetData(string Query) //executes the query  and returns the number of rows affected by the SQL command.
                                         //The method is primarily used for executing non-query SQL commands (e.g., INSERT, UPDATE, DELETE, etc.) and does not return any data from the database.
        {
            int cnt = 0; // to store the number of rows affected by the SQL command 
            if (con.State == ConnectionState.Closed)
            {
                //It ensures that the connection is open before executing the SQL command.
                con.Open();
            }
            cmd.CommandText= Query;  //represents the SQL command that will be executed.
            cnt =cmd.ExecuteNonQuery();
            return cnt;
        }
    }
}
