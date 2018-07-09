using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Project
{
    public partial class Form10 : Form
    {
        string iD;
        public Form10(string id)
        {
            InitializeComponent();
            this.iD = id;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
        Transfer_Balance tb = new Transfer_Balance();
        private void btn1_Click(object sender, EventArgs e)
        {
            tb.Transfer(textBox1, textBox2, textBox3);

        }

        private void Form10_Load(object sender, EventArgs e)
        {
            textBox1.Text = iD;
        }
    }
}
