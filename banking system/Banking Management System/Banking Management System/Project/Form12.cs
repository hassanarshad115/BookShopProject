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
    public partial class Form12 : Form
    {
        string iD;
        public Form12(string id)
        {
            InitializeComponent();
            this.iD = id;
        }

        private void Form12_Load(object sender, EventArgs e)
        {
            textBox1.Text = iD;
        }

        private void textBox15_TextChanged(object sender, EventArgs e)
        {

        }

        private void lebl1_Click(object sender, EventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }
        ChangePin changep = new ChangePin();
        ChangePinAdminPanel changeap = new ChangePinAdminPanel();
        private void btn1_Click(object sender, EventArgs e)
        {
            changep.changePinCode(textBox1, textBox2, textBox3);
            changeap.ChangePinAP(textBox1, textBox2, textBox3);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            this.Dispose();
        }
    }
}
