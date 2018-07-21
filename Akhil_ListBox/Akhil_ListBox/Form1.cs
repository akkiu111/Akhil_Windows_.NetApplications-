using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Akhil_ListBox
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(char.IsLetter(e.KeyChar)|| e.KeyChar == 8)
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }

            if(e.KeyChar == 13)
            {
                if (textBox1.Text == "")
                {
                    MessageBox.Show("Please enter a course name");
                    textBox1.Focus();
                }
                else
                {
                    if (listBox1.Items.Contains(textBox1.Text) == true)
                    {
                        MessageBox.Show(textBox1.Text + " course is already added.. please check the listbox for details");
                        textBox1.Clear();
                    }
                    else
                    {
                        listBox1.Items.Add(textBox1.Text);
                        MessageBox.Show(textBox1.Text + " course added successfully");
                        textBox1.Clear();
                        textBox1.Focus();
                    }
                }
                
            }
        }

     
        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                string lname = listBox1.SelectedItem.ToString();
                if (listBox2.Items.Contains(lname) == false)
                {
                    listBox2.Items.Add(lname);
                }
            }
            catch (Exception ex)
            {

            }
        }
        void clearall()
        {
            textBox1.Clear();
            listBox1.Items.Clear();
            listBox2.Items.Clear();
            textBox1.Focus();
        }

      
        private void button1_Click(object sender, EventArgs e)
        {
            if(listBox1.SelectedIndex >= 0)
            {
                string lname = listBox1.SelectedItem.ToString();
                listBox1.Items.Remove(lname);
                listBox2.Items.Remove(lname);
                MessageBox.Show(lname + " Course Removed Successfully");
                textBox1.Focus();
            }
            else
            {
                MessageBox.Show("Please select your course that has to be removed");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            clearall();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

     
        private void button1_MouseEnter(object sender, EventArgs e)
        {
            this.button1.BackColor = Color.Orange;
        }

        private void button1_MouseLeave(object sender, EventArgs e)
        {
            this.button1.BackColor = DefaultBackColor;
        }

        private void button2_MouseEnter(object sender, EventArgs e)
        {
            this.button2.BackColor = Color.Orange;

        }

        private void button2_MouseLeave(object sender, EventArgs e)
        {
            this.button2.BackColor = DefaultBackColor;

        }

        private void button3_MouseEnter(object sender, EventArgs e)
        {
            this.button3.BackColor = Color.Orange;

        }

        private void button3_MouseLeave(object sender, EventArgs e)
        {
            this.button3.BackColor = DefaultBackColor;

        }

    }
}
