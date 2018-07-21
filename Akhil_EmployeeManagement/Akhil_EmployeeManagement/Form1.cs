using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;

namespace Akhil_EmployeeManagement
{
    public partial class Form1 : Form
    {
        //Sql Provider
        SqlConnection con = null;
        SqlCommand cmd = null;
        ConnectionClass con_obj = new ConnectionClass();
        public Form1()
        {
            InitializeComponent();
        }

        void Clearall()
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //open Connection
            con = con_obj.EmpDbConnection();
            con.Open();

            //Insert Command
            string query = "insert into Employee_tbl values(@val_eno,@val_ename,@val_esalary)";
            cmd = new SqlCommand(query, con);
            cmd.Parameters.AddWithValue("@val_eno", textBox1.Text);
            cmd.Parameters.AddWithValue("@val_ename", textBox2.Text);
            cmd.Parameters.AddWithValue("@val_esalary", textBox3.Text);
            cmd.ExecuteNonQuery();

            MessageBox.Show("Employee Details are Inserted Successfully");
            Clearall();

            //Close Connection
            con.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //open Connection
            con = con_obj.EmpDbConnection();
            con.Open();

            //Update Command
            string query = "update Employee_tbl set Eno=@val_eno,Ename=@val_ename,Esalary=@val_esalary";
            cmd = new SqlCommand(query, con);
            cmd.Parameters.AddWithValue("@val_eno", textBox1.Text);
            cmd.Parameters.AddWithValue("@val_ename", textBox2.Text);
            cmd.Parameters.AddWithValue("@val_esalary", textBox3.Text);
            cmd.ExecuteNonQuery();

            MessageBox.Show("Employee Details are Updated Successfully");
            Clearall();

            //Close Connection
            con.Close();
        }

       
        private void button4_Click(object sender, EventArgs e)
        {
            //open Connection
            con = con_obj.EmpDbConnection();
            con.Open();


            //Delete Command
            string query = "delete from Employee_tbl where  Eno=@val_eno";
            cmd = new SqlCommand(query, con);
            cmd.Parameters.AddWithValue("@val_eno", textBox1.Text);
            cmd.Parameters.AddWithValue("@val_ename", textBox2.Text);
            cmd.Parameters.AddWithValue("@val_esalary", textBox3.Text);
            cmd.ExecuteNonQuery();

            MessageBox.Show("Deleted Successfully");
            Clearall();

            //Close Connection
            con.Close();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Clearall();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

      
    }
}
