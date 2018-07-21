using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Akhil_s_DemoStudentApplication
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

        private void button1_Click(object sender, EventArgs e)
        {
            s_id = Convert.ToDouble(textBox1.Text);
            s_name = textBox2.Text;
            s_tel = Convert.ToDouble(textBox3.Text);
            s_eng = Convert.ToDouble(textBox4.Text);
            s_hin = Convert.ToDouble(textBox5.Text);
            total = s_tel + s_eng + s_hin;
            avg = total / 3;
            MessageBox.Show(" Student Progress Report" + "\n---------------------------" + "\nStudent id : " + s_id + "\nStudent Name : " + s_name + "\nTotal Marks : " + total + "\nAverage : " + avg + "\nGrade : " + Gradecalculator(avg));
        }
       
    }
}

