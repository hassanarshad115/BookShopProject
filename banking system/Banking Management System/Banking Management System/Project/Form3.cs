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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }
        Add_Customer addCustomer = new Add_Customer();
        private void Form3_Load(object sender, EventArgs e)
        {
            Random rand = new Random();
            textBox1.Text = rand.Next(10, 100000).ToString();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        
        

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            this.Dispose();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            addCustomer.addcustomer(textBox1, textBox2, textBox3, textBox4, ctxt1, textBox6, textBox7, textBox8, textBox9, textBox10, textBox11, textBox12, textBox13, textBox14, dateTimePicker1);
        
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox6.Clear();
            textBox7.Clear();
            textBox8.Clear();
            textBox9.Clear();
            textBox10.Clear();
            textBox11.Clear();
            textBox12.Clear();
            textBox13.Clear();
            textBox14.Clear();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            this.Dispose();
        }
    }
}
