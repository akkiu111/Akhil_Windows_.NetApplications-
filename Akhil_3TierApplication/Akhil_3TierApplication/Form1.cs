using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Akhil_3TierApplication
{
    public partial class Form1 : Form
    {
        BAL_Student obj = new BAL_Student();

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
            //insert
            obj.bal_sid = int.Parse(textBox1.Text);
            obj.bal_sname = textBox2.Text;
            obj.bal_sgrade = textBox3.Text;

            int r = obj.Bal_insert_student();
            if(r==1)
            {
                MessageBox.Show("Student Details Inserted successfully");
            }
            else
            {
                MessageBox.Show("Check the values entered");
            }

            clearall();


        }

        private void button2_Click(object sender, EventArgs e)
        {
            obj.bal_sid = int.Parse(textBox1.Text);
            obj.bal_sname = textBox2.Text;
            obj.bal_sgrade = textBox3.Text;

            int r = obj.Bal_update_student();
            if (r == 1)
            {
                MessageBox.Show("Student Details Updated successfully");
            }
            else
            {
                MessageBox.Show("Check the values entered");
            }

            clearall();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            obj.bal_sid = int.Parse(textBox1.Text);
            DataTable d = obj.Bal_find_student();

            if(d==null)
            {
                MessageBox.Show("Invalid Student number..");

            }
            else
            {
                //assign dataatble values to textboxes
                textBox2.Text = d.Rows[0].ItemArray[1].ToString();
                textBox3.Text = d.Rows[0].ItemArray[2].ToString();
            }
            
            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            obj.bal_sid = int.Parse(textBox1.Text);
            int r = obj.Bal_delete_student();
            if (r == 1)
            {
                MessageBox.Show("Student Details deleted successfully");
            }
            else
            {
                MessageBox.Show("Check the values entered");
            }

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
            //display
            DataTable d = obj.Bal_display_student();

            //assign data to grid view
            dataGridView1.DataSource = d;
            dataGridView1.Refresh();
        }

       
    }
}
