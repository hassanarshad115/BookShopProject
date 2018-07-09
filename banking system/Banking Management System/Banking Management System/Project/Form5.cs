using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace Project
{
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }
        Update up = new Update();
        private void Form5_Load(object sender, EventArgs e)
        {
        
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            up.Customer_Record_Update(textBox1, dataGridView1);
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            this.Hide();
            this.Dispose();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            up.Customer_Record_Update(textBox1, dataGridView1);
            textBox1.Clear();
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            this.Dispose();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            this.Dispose();
        }

    }
}
