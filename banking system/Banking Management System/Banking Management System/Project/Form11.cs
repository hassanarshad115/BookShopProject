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
    public partial class Form11 : Form
    {
        public Form11()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Form11_Load(object sender, EventArgs e)
        {

        }
        int abc = 0;
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem.ToString() == "Pak Rupees To USD")
            {
                lbl1.Text = "Rs";
                lbl2.Text = "$";
                if (textBox1.Text == "")
                {
                    
                    textBox2.Text = abc.ToString();
                }

                else
                {

                    double a = Convert.ToDouble(textBox1.Text) * 0.01;
                    textBox2.Text = a + "";
                }
            }
            else if (comboBox1.SelectedItem.ToString() == "USD To Pak Rupees")
            {
                lbl1.Text = "$";
                lbl2.Text = "Rs";
                if (textBox1.Text == "")
                {
                    textBox2.Text = abc.ToString();
                }

                else
                {

                   double a = Convert.ToDouble(textBox1.Text) / 0.01;
                    textBox2.Text = a + "";
                }
            }
            else if (comboBox1.SelectedItem.ToString() == "Pak Rupees To Euro")
            {
                lbl1.Text = "Rs";
                lbl2.Text = "Euro";
                if (textBox1.Text == "")
                {
                    textBox2.Text = abc.ToString();
                }

                else
                {

                    double a = Convert.ToDouble(textBox1.Text) * 0.0090;
                    textBox2.Text = a + "";
                }
            }
            else if (comboBox1.SelectedItem.ToString() == "Euro To Pak Rupees")
            {
                lbl1.Text = "Euro";
                lbl2.Text = "Rs";
                if (textBox1.Text == "")
                {
                    textBox2.Text = abc.ToString();
                }

                else
                {

                    double a = Convert.ToDouble(textBox1.Text) / 0.0090;
                    textBox2.Text = a + "";
                }
            }
            else if (comboBox1.SelectedItem.ToString() == "Pak Rupees To Dirham")
            {
                lbl1.Text = "Rs";
                lbl2.Text = "Drh";
                if (textBox1.Text == "")
                {
                    textBox2.Text = abc.ToString();
                }

                else
                {

                    double a = Convert.ToDouble(textBox1.Text) / 0.037;
                    textBox2.Text = a + "";
                }

            }
            else if (comboBox1.SelectedItem.ToString() == "Dirham To Pak Rupees")
            {
                lbl1.Text = "Drh";
                lbl2.Text = "Rs";
                if (textBox1.Text == "")
                {
                    textBox2.Text = abc.ToString();
                }

                else
                {

                    double a = Convert.ToDouble(textBox1.Text) * 0.037;
                    textBox2.Text = a + "";
                }
            }
            else if (comboBox1.SelectedItem.ToString() == "Pak Rupees To Saudi Riyal")
            {
                lbl1.Text = "Rs";
                lbl2.Text = "Ryl";
                if (textBox1.Text == "")
                {
                    textBox2.Text = abc.ToString();
                }

                else
                {

                    double a = Convert.ToDouble(textBox1.Text) / 0.036;
                    textBox2.Text = a + "";
                }

            }
            else if (comboBox1.SelectedItem.ToString() == "Saudi Riyal To Pak Rupees")
            {
                lbl1.Text = "Ryl";
                lbl2.Text = "Rs";
                if (textBox1.Text == "")
                {
                    textBox2.Text = abc.ToString();
                }

                else
                {

                    double a = Convert.ToDouble(textBox1.Text) * 0.036;
                    textBox2.Text = a + "";
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
