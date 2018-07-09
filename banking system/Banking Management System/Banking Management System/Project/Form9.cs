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
    public partial class Form9 : Form
    {
        string iD;
        public Form9(string id)
        {
            InitializeComponent();
            this.iD = id;
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            this.Dispose();
        }
        CheckDetailed chkdetailed = new CheckDetailed();
        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void Form9_Load(object sender, EventArgs e)
        {
            
            
                textBox1.Text = iD;
                chkdetailed.Account_Detailed(textBox1, textBox2, textBox3, textBox4, textBox5);
            
            
        }
    }
}
