using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Library_Management_System
{
    public partial class MemberForm : Form
    {
        public MemberForm()
        {
            InitializeComponent();
        }

        private void MemberForm_Load(object sender, EventArgs e)
        {
            cbGender.SelectedIndex = 0;
            tbRegisterID.Text = Convert.ToString(Guid.NewGuid());
        }

        private void btSignup_Click(object sender, EventArgs e)
        {
            LMS Main=new LMS();
            string RegistrationID = tbRegisterID.Text;
            string UserName = tbUserName.Text;
            string Password = tbPassword.Text;
            string Name = tbName.Text;
            string Phone = tbPhone.Text;
            string Email = tbEmail.Text;
            string Issued="No";
            string Gender = Convert.ToString(cbGender.SelectedValue);
            int val = Main.InsertMember(RegistrationID, Name, UserName, Password, Email, Issued);
            if (val == 1)
            {
                MessageBox.Show("Data Added");
            }
        }

        private void tbUserName_TextChanged(object sender, EventArgs e)
        {
            List<string> Usernames = new List<string>();
            string UserName = tbUserName.Text;
            LMS Main = new LMS();
            DataTable dt = Main.GettingMemberTable();
            DGMember.DataSource = dt;
            if (DGMember.Rows.Count > 1)
            {
                for (int i = 0; i < DGMember.Rows.Count; i++)
                {
                    Usernames.Add(Convert.ToString(DGMember.Rows[i].Cells[3].Value));
                    if (UserName == Usernames[0])
                    {
                        MessageBox.Show("Username exist kindly change it");
                        tbUserName.Text = tbUserName.Text +"0";
                    }
                }
            }
        }
    }
}
