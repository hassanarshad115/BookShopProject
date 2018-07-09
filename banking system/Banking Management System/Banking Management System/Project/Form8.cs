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
    public partial class Form8 : Form
    {
        string ID;
        public Form8(TextBox id)
        {
            InitializeComponent();
            this.ID = id.Text;
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            
            this.Hide();
            Form1 f1 = new Form1();
            f1.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form9 form9 = new Form9(ID);
            form9.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form12 form12 = new Form12(ID);
            form12.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form10 form10 = new Form10(ID);
            form10.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form11 form11 = new Form11();
            form11.Show();
            
        }

        private void Form8_Load(object sender, EventArgs e)
        {

        }
    }
}
