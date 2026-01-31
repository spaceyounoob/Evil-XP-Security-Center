using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace XPSecurityCenter
{
    public partial class App : Form
    {
        public App()
        {
            InitializeComponent();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://en.wikipedia.org/wiki/List_of_Linux_distributions");
        }

        private void label5_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://en.wikipedia.org/wiki/List_of_Linux_distributions");
        }

        private void label7_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://en.wikipedia.org/wiki/List_of_Linux_distributions");
        }

        private void linkLabel1_LinkClicked_1(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://en.wikipedia.org/wiki/List_of_Linux_distributions");
        }

        private void Option3_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("notepad.exe");
        }

        private void radioButton1_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("http://touchgrass.now");
        }

        private void radioButton2_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.google.com/search?q=memz+how+to+install");
        }

        private void label9_Click(object sender, EventArgs e)
        {
            var form2 = new AlertSettings();
            form2.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var form2 = new Recommendation();
            form2.ShowDialog();
        }
    }
}
