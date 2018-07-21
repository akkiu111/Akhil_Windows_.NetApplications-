using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Akhil_s_FullStudentApplication
{
    public partial class Form1 : Form
    {
        double s_tel, s_eng, s_hin, total, avg, s_id;     
        string s_name;
        public Form1()
        {
            InitializeComponent();

        }
        static string Gradecalculator(double avg)
        {
            if (avg > 90)
            {
                return "A";
            }
            else if (avg <= 90 && avg >= 80)
            {
                return "B";
            }
            else if (avg <= 80 && avg >= 70)
            {
                return "C";
            }

            else if (avg <= 70 && avg >= 60)
            {
                return "D";
            }
            else if (avg < 60)
            {
                return "FAIL";
            }
            return "No Grade";
        }
        void clearall()
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox5.Clear();
            textBox1.Focus();
        }



        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(char.IsDigit(e.KeyChar) || e.KeyChar == 8 )
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }

            if(e.KeyChar == 13)
            {
                if(textBox1.Text != "")
                {
                    textBox2.Focus();
                }
                else
                {   
                    MessageBox.Show("Please enter student Id");
                    textBox1.Focus();
                }
            }
        }

      

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(char.IsLetter(e.KeyChar)|| e.KeyChar == 8)
            {
                e.Handled = false;

            }
            else
            {
                e.Handled = true;
            }

            if (e.KeyChar == 13)
            {
                if (textBox2.Text != "")
                {
                    textBox3.Focus();
                }
                else
                {
                    MessageBox.Show("Please enter student Name");
                    textBox2.Focus();
                }
            }
        }


       
        private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar) || e.KeyChar == 8)
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }

            if (e.KeyChar == 13)
            {
                if (textBox3.Text != "")
                {
                    if(int.Parse(textBox3.Text) <= 100)
                    {
                        textBox4.Focus();
                        
                    }
                    else
                    {
                        MessageBox.Show(" Please enter marks less than or equal to 100");
                        textBox3.Clear();
                        textBox3.Focus();
                    }
                    
                }
                else
                {
                    MessageBox.Show("Please enter student's Telugu Marks");
                    textBox3.Focus();
                }
            }
        }

        private void textBox4_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar) || e.KeyChar == 8)
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }

            if (e.KeyChar == 13)
            {
                if (textBox4.Text != "")
                {
                    if (int.Parse(textBox4.Text) <= 100)
                    {
                        textBox5.Focus();

                    }
                    else
                    {
                        MessageBox.Show(" Please enter marks less than or equal to 100");
                        textBox4.Clear();
                        textBox4.Focus();
                    }
                }
                else
                {
                    MessageBox.Show("Please enter student's Eenglish Marks");
                    textBox4.Focus();
                }
            }
        }

        private void textBox5_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar) || e.KeyChar == 8)
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }

            if (e.KeyChar == 13)
            {
                if (textBox5.Text != "")
                {
                    if (int.Parse(textBox5.Text) <= 100)
                    {
                        button1.Focus();

                    }
                    else
                    {
                        MessageBox.Show(" Please enter marks less than or equal to 100");
                        textBox5.Clear();
                        textBox5.Focus();
                    }
                }
                else
                {
                    MessageBox.Show("Please enter student's Hindi Marks");
                    textBox5.Focus();
                }
            }
        }

        

        public void StudentResult()
        {
            try
            {
                textBox1.Focus();
                s_id = Convert.ToDouble(textBox1.Text);
                s_name = textBox2.Text;
                s_tel = Convert.ToDouble(textBox3.Text);
                s_eng = Convert.ToDouble(textBox4.Text);
                s_hin = Convert.ToDouble(textBox5.Text);
                total = s_tel + s_eng + s_hin;
                avg = total / 3;
                DialogResult res = MessageBox.Show(" Student Progress Report" + "\n---------------------------" + "\nStudent id : " + s_id + "\nStudent Name : " + s_name + "\nTotal Marks : " + total + "\nAverage : " + avg + "\nGrade : " + Gradecalculator(avg), "Result", MessageBoxButtons.OK, MessageBoxIcon.Information);

                if (res.ToString() == "OK")
                {
                    clearall();
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("Please Enter the Student Details");
            }
        }

        
        private void button1_MouseEnter(object sender, EventArgs e)
        {
            button1.BackColor = Color.DarkOrange;
        }

        private void button1_MouseLeave(object sender, EventArgs e)
        {
            button1.BackColor = Color.Aquamarine;
        }
        private void button2_MouseEnter(object sender, EventArgs e)
        {
            button2.BackColor = Color.DarkOrange;
        }

        private void button2_MouseLeave(object sender, EventArgs e)
        {
            button2.BackColor = Color.Aquamarine;

        }   

        private void button3_MouseEnter(object sender, EventArgs e)
        {
            button3.BackColor = Color.DarkOrange;

        }

        private void button3_MouseLeave(object sender, EventArgs e)
        {
            button3.BackColor = Color.Aquamarine;

        }
        private void button1_Click(object sender, EventArgs e)
        {
            StudentResult();
          
        }

        private void button2_Click(object sender, EventArgs e)
        {
            clearall();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

    }
}

