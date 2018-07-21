using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AkhilCalculator
{
    public partial class Form1 : Form
    {
        double FirstNumber, SecondNumber, Total;

       
        public Form1()
        {
            InitializeComponent();
        }

        

        private void button1_Click(object sender, EventArgs e)
        {
            FirstNumber = Convert.ToDouble(textBox1.Text);
            SecondNumber = Convert.ToDouble(textBox2.Text);
            Total = FirstNumber + SecondNumber;
            textBox3.Text = Total.ToString();
        }

        

        private void button2_Click(object sender, EventArgs e)
        {

            FirstNumber = Convert.ToDouble(textBox1.Text);
            SecondNumber = Convert.ToDouble(textBox2.Text);
            Total = FirstNumber - SecondNumber;
            textBox3.Text = Total.ToString();
        }

        

        private void button3_Click(object sender, EventArgs e)
        {
            FirstNumber = Convert.ToDouble(textBox1.Text);
            SecondNumber = Convert.ToDouble(textBox2.Text);
            Total = FirstNumber * SecondNumber;
            textBox3.Text = Total.ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            FirstNumber = Convert.ToDouble(textBox1.Text);
            SecondNumber = Convert.ToDouble(textBox2.Text);
            Total = FirstNumber / SecondNumber;
            textBox3.Text = Total.ToString();
        }

      

        private void button5_Click(object sender, EventArgs e)
        {
            FirstNumber = Convert.ToDouble(textBox1.Text);
            SecondNumber = Convert.ToDouble(textBox2.Text);
            Total = FirstNumber % SecondNumber;
            textBox3.Text = Total.ToString();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox1.Focus();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }


    }
}
