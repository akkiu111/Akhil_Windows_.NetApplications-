using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;


namespace Akhil_Notepad
{
    public partial class Form1 : Form
    {
        public static string FindText;
        public static string ReplaceText;
        int d;
        public Form1()
        {
            InitializeComponent();
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
            if (richTextBox1.Text.Length > 0)
            {
                undoToolStripMenuItem.Enabled = true;
                cutToolStripMenuItem.Enabled = true;
                copyToolStripMenuItem.Enabled = true;
                pasteToolStripMenuItem.Enabled = true;
                findToolStripMenuItem.Enabled = true;
                findNextToolStripMenuItem.Enabled = true;
            }
            else
            {
                undoToolStripMenuItem.Enabled = false;
                cutToolStripMenuItem.Enabled = false;
                copyToolStripMenuItem.Enabled = false;
                pasteToolStripMenuItem.Enabled = false;
                findToolStripMenuItem.Enabled = false;
                findNextToolStripMenuItem.Enabled = false;
            }
        }


        private void timer1_Tick(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = DateTime.Now.ToString("MMM-dd-yyyy HH:mm:ss");
        }

        private void fontToolStripMenuItem_Click(object sender, EventArgs e)
        {

            fontDialog1.ShowDialog();

            richTextBox1.Font = fontDialog1.Font;
            

            fontDialog1.Dispose();
        }


        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = "";
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            

            openFileDialog1.Filter = "Text Documents (*.txt) | *.txt";

            openFileDialog1.FileName = "";

            openFileDialog1.ShowDialog();
      
            if (openFileDialog1.FileName != "")
            {
                StreamReader sr = new StreamReader(openFileDialog1.FileName);

                richTextBox1.Text = sr.ReadToEnd();

                sr.Close();
            }

            openFileDialog1.Dispose();
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {

            saveFileDialog1.Filter = "Text Documents (*.txt) | *.txt";

            saveFileDialog1.ShowDialog();

            StreamWriter sw = new StreamWriter(saveFileDialog1.FileName);

            sw.Write(richTextBox1.Text);

            sw.Close();

            saveFileDialog1.Dispose();
        }

        private void saveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            saveFileDialog1.Filter = "Text Documents (*.txt) | *.txt";

            saveFileDialog1.ShowDialog();

            StreamWriter sw = new StreamWriter(saveFileDialog1.FileName);

            sw.Write(richTextBox1.Text);

            sw.Close();

            saveFileDialog1.Dispose();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void undoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Undo();
            undoToolStripMenuItem.Enabled = false;
        }

       

        private void cutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Cut();
        }

        private void copyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Copy();
        }

        private void pasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Paste();
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.SelectedText = "";
        }

        private void selectToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.SelectAll();
        }

        private void timeDateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Text += DateTime.Now;
        }

        

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = "";
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "Text Documents (*.txt) | *.txt";

            openFileDialog1.FileName = "";

            openFileDialog1.ShowDialog();

            if (openFileDialog1.FileName != "")
            {
                StreamReader sr = new StreamReader(openFileDialog1.FileName);

                richTextBox1.Text = sr.ReadToEnd();

                sr.Close();
            }

            openFileDialog1.Dispose();
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            saveFileDialog1.Filter = "Text Documents (*.txt) | *.txt";

            saveFileDialog1.ShowDialog();

            StreamWriter sw = new StreamWriter(saveFileDialog1.FileName);

            sw.Write(richTextBox1.Text);

            sw.Close();

            saveFileDialog1.Dispose();
        }

        private void toolStripButton4_Click(object sender, EventArgs e)
        {
            richTextBox1.Undo();

            undoToolStripMenuItem.Enabled = false;
        }

        private void toolStripButton5_Click(object sender, EventArgs e)
        {
            saveFileDialog1.Filter = "Text Documents (*.txt) | *.txt";

            saveFileDialog1.ShowDialog();

            StreamWriter sw = new StreamWriter(saveFileDialog1.FileName);

            sw.Write(richTextBox1.Text);

            sw.Close();

            saveFileDialog1.Dispose();
        }

        private void wordWrapToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(richTextBox1.WordWrap == true)
            {
                richTextBox1.WordWrap = false;
            }
            else
            {
                richTextBox1.WordWrap = true;
            }
        }

        private void viewHelpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://answers.microsoft.com/en-us/windows/forum/apps_windows_10");         
        }

        private void findToolStripMenuItem_Click(object sender, EventArgs e)
        {
          
            Find r = new Find();
            r.ShowDialog();
            if(FindText != "")
            {
              d = richTextBox1.Find(FindText);
                
                
            }
        }

        private void findNextToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (FindText != "")
            {
                richTextBox1.Find(FindText,d,richTextBox1.Text.Length,RichTextBoxFinds.None);
            }
        }

        private void replaceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Replace r = new Replace();
            r.ShowDialog();
            richTextBox1.Find(FindText);
            richTextBox1.SelectedText = ReplaceText;
        }

        private void goToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
 