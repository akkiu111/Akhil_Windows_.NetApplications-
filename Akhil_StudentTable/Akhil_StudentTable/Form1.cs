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

namespace Akhil_StudentTable
{
    public partial class Form1 : Form
    {
        //Declare SQL class objects

        SqlConnection con = null;
        SqlCommand cmd = null;
        SqlDataAdapter da = null;
        SqlDataReader dr = null;

        //Declare the connection class object

        ConnectionClass con_obj = new ConnectionClass();

        public Form1()
        {
            InitializeComponent();
        }

        void clearall()
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            radioButton1.Checked = false;
            radioButton2.Checked = false;
            comboBox1.SelectedIndex = -1;
            comboBox1.ResetText();
            textBox1.Focus();
        }
       

        private void button1_Click(object sender, EventArgs e)
        {
            //Open Connection
            con = con_obj.studentDBConnection();
            con.Open();

            //Insert Command
            string query = "insert into Student_tbl values(@val_sid,@val_sname,@val_gender,@val_sclass,@val_smarks)";
            cmd = new SqlCommand(query, con);
            cmd.Parameters.AddWithValue("@val_sid", textBox1.Text);
            cmd.Parameters.AddWithValue("@val_sname", textBox2.Text);

            if(radioButton1.Checked == true)
            {
                cmd.Parameters.AddWithValue("@val_gender", radioButton1.Text);

            }
            else if (radioButton2.Checked == true)
            {
                cmd.Parameters.AddWithValue("@val_gender",radioButton2.Text);

            }
            cmd.Parameters.AddWithValue("@val_sclass", comboBox1.SelectedItem.ToString());
            cmd.Parameters.AddWithValue("@val_smarks", textBox3.Text);

            cmd.ExecuteNonQuery();

            MessageBox.Show("Student Details Inserted Successfully");

            clearall();
            //Close Connection
            con.Close();
        }


        private void button2_Click(object sender, EventArgs e)
        {
            //Open Connection
            con = con_obj.studentDBConnection();
            con.Open();

            //Update Command
            string query = "update Student_tbl set Sname=@val_sname,gender=@val_Gender,Sclass=@val_sclass,Smarks=@val_smarks where Sid=@val_sid";
            cmd = new SqlCommand(query, con);
            cmd.Parameters.AddWithValue("@val_sid", textBox1.Text);
            cmd.Parameters.AddWithValue("@val_sname", textBox2.Text);

            if (radioButton1.Checked == true)
            {
                cmd.Parameters.AddWithValue("@val_gender", radioButton1.Text);

            }
            else if (radioButton2.Checked == true)
            {
                cmd.Parameters.AddWithValue("@val_gender", radioButton2.Text);

            }
            cmd.Parameters.AddWithValue("@val_sclass", comboBox1.SelectedItem.ToString());
            cmd.Parameters.AddWithValue("@val_smarks", textBox3.Text);

            cmd.ExecuteNonQuery();

            MessageBox.Show("Student Details Updated Successfully");

            clearall();
            //Close Connection
            con.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //Open Connection
            con = con_obj.studentDBConnection();
            con.Open();

            // select query

            string query = "select * from Student_tbl where sid=@val_sid";
            cmd = new SqlCommand(query, con);

            //Insert Command
            
            cmd.Parameters.AddWithValue("@val_sid", textBox1.Text);
            dr = cmd.ExecuteReader();
            if(dr.Read())
            {
                textBox2.Text = dr["sname"].ToString();

                String gender = dr["gender"].ToString();
                if(gender == "Male")
                {
                    radioButton1.Checked = true;
                }
                else
                {
                    radioButton2.Checked = true;
                }
                comboBox1.SelectedItem = dr["sclass"].ToString();
                textBox3.Text = dr["smarks"].ToString();

            }
            else
            {
                MessageBox.Show("Invalid Student Number");
                textBox1.Clear();
                textBox1.Focus();
            }
            cmd.Parameters.AddWithValue("@val_sname", textBox2.Text);

            if (radioButton1.Checked == true)
            {
                cmd.Parameters.AddWithValue("@val_gender", radioButton1.Text);

            }
            else if (radioButton2.Checked == true)
            {
                cmd.Parameters.AddWithValue("@val_gender", radioButton2.Text);

            }
            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            //Open Connection
            con = con_obj.studentDBConnection();
            con.Open();

            //Delete Command
            string query = "delete from Student_tbl where Sid=@val_sid";
            cmd = new SqlCommand(query, con);
            cmd.Parameters.AddWithValue("@val_sid", textBox1.Text);
            cmd.ExecuteNonQuery();

            MessageBox.Show("Student Details Deleted Successfully");

            clearall();
            //Close Connection
            con.Close();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            clearall();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            //Open Connection
            con = con_obj.studentDBConnection();
            con.Open();

            // select query

            string query = "select * from Student_tbl";
            cmd = new SqlCommand(query, con);
            da = new SqlDataAdapter(cmd);

            //Set Da data
            DataTable dt = new DataTable();

            //Fill data table
            da.Fill(dt);

            //Assign the dt to grid
            dataGridView1.DataSource = dt;
            dataGridView1.Refresh();

            //close connection
            con.Close(); 

        }

    }
}
