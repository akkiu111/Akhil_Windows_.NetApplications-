using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Akhil_DateTimePicker
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            label2.Text = dateTimePicker1.Value.ToLongDateString();
            label3.Text = dateTimePicker1.Value.ToLongTimeString();
            label4.Text = dateTimePicker1.Value.ToShortDateString();
            label5.Text = dateTimePicker1.Value.AddHours(2).ToString("MM/dd/yyyy hh:mm:ss");
            label6.Text = dateTimePicker1.Value.AddYears(5).ToString();
            label7.Text = dateTimePicker1.Value.ToUniversalTime().ToString();


        }

       
    }
}
