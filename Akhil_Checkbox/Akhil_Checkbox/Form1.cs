using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Akhil_Checkbox
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        double bill = 0;
       

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            bill = Convert.ToDouble(textBox1.Text);

            if (checkBox1.Checked == true)
            {
                bill = bill + 1000;
            }
            else
            {
                bill = bill - 1000;
            }

            textBox1.Text = bill.ToString();

        }

           private void checkBox2_CheckedChanged(object sender, EventArgs e)
           {
               bill = Convert.ToDouble(textBox1.Text);

               if (checkBox2.Checked == true)
               {
                   bill = bill + 500;
               }
               else
               {
                   bill = bill - 500;
               }

               textBox1.Text = bill.ToString();

           }

             private void checkBox3_CheckedChanged(object sender, EventArgs e)
                {
                    bill = Convert.ToDouble(textBox1.Text);

                    if (checkBox3.Checked == true)
                    {
                        bill = bill + 400;
                    }
                    else
                    {
                        bill = bill - 400;
                    }

                    textBox1.Text = bill.ToString();

                }

        

             private void checkBox4_CheckedChanged(object sender, EventArgs e)
              {
                  bill = Convert.ToDouble(textBox1.Text);

                  if (checkBox4.Checked == true)
                  {
                      bill = bill + 600;
                  }
                  else
                  {
                      bill = bill - 600;
                  }

                  textBox1.Text = bill.ToString();

              }
              
        
        
     private void checkBox5_CheckedChanged(object sender, EventArgs e)
     {
         bill = Convert.ToDouble(textBox1.Text);

         if (checkBox5.Checked == true)
         {
             bill = bill + 100;
         }
         else
         {
             bill = bill - 100;
         }


         textBox1.Text = bill.ToString();

     }

       

          private void checkBox6_CheckedChanged(object sender, EventArgs e)
          {
              bill = Convert.ToDouble(textBox1.Text);

              if (checkBox6.Checked == true)
              {
                  bill = bill + 200;
              }
              else
              {
                  bill = bill - 200;
              }

              textBox1.Text = bill.ToString();

          }

       
    }
}
