using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Akhil_MaskedTextBox_LinkLabel
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

            Form2 form2 = Application.OpenForms.OfType<Form2>().FirstOrDefault();
            if (form2 == null)
            {
                form2 = new Form2();
                form2.Show();
            }
            else
            {
                form2.BringToFront();
            }

        }
    }
}
