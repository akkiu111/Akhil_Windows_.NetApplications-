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
    public partial class Akhil_DigitalClock : Form
    {
        public Akhil_DigitalClock()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label1.Text = DateTime.Now.ToString("MM/dd/yyyy hh:mm:ss");
        }
    }
}
