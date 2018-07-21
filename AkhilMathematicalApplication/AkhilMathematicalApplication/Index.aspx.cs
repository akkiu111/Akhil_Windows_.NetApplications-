using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace AkhilMathematicalApplication
{
    public partial class Index : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            double a = double.Parse(TextBox1.Text);
            double b = double.Parse(TextBox2.Text);
            double c = a + b;

            TextBox3.Text = c.ToString();
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            double a = double.Parse(TextBox1.Text);
            double b = double.Parse(TextBox2.Text);
            double c = a - b;

            TextBox3.Text = c.ToString();
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            double a = double.Parse(TextBox1.Text);
            double b = double.Parse(TextBox2.Text);
            double c = a * b;

            TextBox3.Text = c.ToString();
        }

        protected void Button4_Click(object sender, EventArgs e)
        {
            double a = double.Parse(TextBox1.Text);
            double b = double.Parse(TextBox2.Text);
            double c = a / b;

            TextBox3.Text = c.ToString();
        }

        protected void Button5_Click(object sender, EventArgs e)
        {
            double a = double.Parse(TextBox1.Text);
            double b = double.Parse(TextBox2.Text);
            double c = a % b;

            TextBox3.Text = c.ToString();
        }

        protected void Button6_Click(object sender, EventArgs e)
        {
            TextBox1.Text = "";
            TextBox2.Text = "";
            TextBox3.Text = "";
            TextBox1.Focus();
            
        }
    }
}