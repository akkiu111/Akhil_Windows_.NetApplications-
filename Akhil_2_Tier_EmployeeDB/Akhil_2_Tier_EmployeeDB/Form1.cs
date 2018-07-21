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

namespace Akhil_2_Tier_EmployeeDB
{
    public partial class Form1 : Form
    {
        //Create BAL class Object
        BAL obj = new BAL();

        //clearall function
        void clearall()
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox1.Focus();
        }



        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // get textbox values and assign to class variables
            obj.bal_eid = int.Parse(textBox1.Text);
            obj.bal_ename = textBox2.Text;
            obj.bal_esalary = double.Parse(textBox3.Text);

            //call insert function
            string msg = obj.Bal_insert_Emp();
            MessageBox.Show(msg);
            clearall();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // get textbox values and assign to class variables
            obj.bal_eid = int.Parse(textBox1.Text);
            obj.bal_ename = textBox2.Text;
            obj.bal_esalary = double.Parse(textBox3.Text);

            //call update function
            string msg = obj.Bal_update_Emp();
            MessageBox.Show(msg);
            clearall();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //send emp number
            obj.bal_eid = int.Parse(textBox1.Text);

            //call find function
            obj.Bal_find_Emp();

            //assign the variables to textbox
            textBox2.Text = obj.bal_ename.ToString();
            textBox3.Text = obj.bal_esalary.ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            // get textbox values and assign to class variables
            obj.bal_eid = int.Parse(textBox1.Text);


            //call delete function
            string msg = obj.Bal_delete_Emp();
            MessageBox.Show(msg);
            clearall();
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
            // Access Function
            DataTable emp_data = obj.Bal_display_Emp();

            //Assign the grid
            dataGridView1.DataSource = emp_data;
            dataGridView1.Refresh();

        }
    }
}
