using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Forms1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Enabled = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Enabled = true;
        }

        private void textbox1_Click(object sender, EventArgs e)
        {
            button1.Visible = false;
            button2.Visible = false;
            textBox1.BackColor = Color.White;
        }
    }
}
