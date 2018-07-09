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
    public partial class frmLoginPage : Form
    {
        public frmLoginPage()
        {
            InitializeComponent();
        }

        private void frmLoginPage_Load(object sender, EventArgs e)
        {
            cbRoleSelect.SelectedIndex = 0;
        }

        private void tbLogin_Click(object sender, EventArgs e)
        {
            #region AdminSelectFromComboBox
            if (cbRoleSelect.SelectedIndex == 0)
            {
                btMemberSignUP.Visible = false;
                if (tbUserName.Text == "mawaat" || tbPassword.Text == "mawaat")
                {
                    WelcomeAdmin WelcomForm = new WelcomeAdmin();
                    this.Hide();
                    WelcomForm.Show();
                }
            }
            #endregion
            #region MemberSelectedFromComboxBox
            if (cbRoleSelect.SelectedIndex == 1)
            {
                WelcomeMember MemberPage = new WelcomeMember();
                btMemberSignUP.Visible = true;
                string Username = tbUserName.Text;
                string Password = tbPassword.Text;
                List<string> LoginUserName = new List<string>();
                List<string> LoginPassword = new List<string>();
                LMS Login = new LMS();
                DataTable dt = Login.GettingMemberTable();
                dgUserName.DataSource = dt;
                if (dgUserName.Rows.Count > 1)
                {
                    for (int i = 0; i < dgUserName.Rows.Count; i++)
                    {
                        LoginUserName.Add(Convert.ToString(dgUserName.Rows[i].Cells[3].Value));
                        LoginPassword.Add(Convert.ToString(dgUserName.Rows[i].Cells[4].Value));
                        if (Username == LoginUserName[i] && Password == LoginPassword[i])
                        {
                            this.Hide();
                            MemberPage.Show();
                        }
                    }
                }
            }
            #endregion
        }

        private void btMemberSignUP_Click(object sender, EventArgs e)
        {
            this.Hide();
            MemberForm Member = new MemberForm();
            Member.Show();
            
        }
    }
}
