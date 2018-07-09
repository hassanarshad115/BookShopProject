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
    public partial class AddEditAuthor : Form
    {
        public AddEditAuthor()
        {
            InitializeComponent();
        }
        List<string> AuthorReg = new List<string>();
        List<string> AuthorName = new List<string>();
        List<string> AuthorAddress = new List<string>();
        List<string> AuthorPhone = new List<string>();
        List<string> AuthorEmail = new List<string>();
        List<int> IDs = new List<int>();
        int ID = 0;
        private void AddEditAuthor_Load(object sender, EventArgs e)
        {
            lblAuthor.Visible = true;
            lblAuthorAddress.Visible = false;
            lblAuthorEditAddress.Visible = false;
            lblAuthorEditEmail.Visible = false;
            lblAuthorEditReg.Visible = false;
            lblAuthorEditName.Visible = false;
            lblAuthorEditPhone.Visible = false;
            lblAuthorEmail.Visible = false;
            lblAuthorReg.Visible = false;
            lblAuthorPhone.Visible = false;
            lblAuthorName.Visible = false;
            tbAuthorEmail.Visible = false;
            tbAuthorReg.Visible = false;
            tbAuthorName.Visible = false;
            tbAuthorPhone.Visible = false;
            tbAuthorAddress.Visible = false;
            tbEditAuthorAddress.Visible = false;
            tbEditAuthorEmail.Visible = false;
            tbEditAuthorName.Visible = false;
            tbEditAuthorPhone.Visible = false;
            cbAuthorRegs.Visible = false;
            btAddAuthor.Visible = false;
            btUpdateAuthor.Visible = false;

            if (rbAddAuthor.Checked == true)
            {
                lblAuthorName.Visible = true;
                lblAuthorReg.Visible = true;
                lblAuthorAddress.Visible = true;
                lblAuthorPhone.Visible=true;
                lblAuthorEmail.Visible = true;
                btAddAuthor.Visible = true;
                tbAuthorEmail.Visible = true;
                tbAuthorReg.Visible = true;
                tbAuthorName.Visible = true;
                tbAuthorAddress.Visible = true;
                tbAuthorPhone.Visible = true;
                lblAuthorEditAddress.Visible = false;
                lblAuthorEditEmail.Visible = false;
                lblAuthorEditReg.Visible = false;
                lblAuthorEditName.Visible = false;
                lblAuthorEditPhone.Visible = false;
                btUpdateAuthor.Visible = false;
                tbEditAuthorAddress.Visible = false;
                tbEditAuthorEmail.Visible = false;
                tbEditAuthorName.Visible = false;
                tbEditAuthorPhone.Visible = false;
                cbAuthorRegs.Visible = false;
            }
            else if (rbEditAuthor.Checked == true)
            {
                lblAuthorName.Visible = false;
                lblAuthorReg.Visible = false;
                lblAuthorAddress.Visible = false;
                lblAuthorPhone.Visible = false;
                lblAuthorEmail.Visible = false;
                btAddAuthor.Visible = false;
                tbAuthorEmail.Visible = false;
                tbAuthorReg.Visible = false;
                tbAuthorName.Visible = false;
                tbAuthorAddress.Visible = false;
                tbAuthorPhone.Visible = false;
                lblAuthorEditAddress.Visible = true;
                lblAuthorEditEmail.Visible = true;
                lblAuthorEditReg.Visible = true;
                lblAuthorEditName.Visible = true;
                lblAuthorEditPhone.Visible = true;
                btUpdateAuthor.Visible = true;
                tbEditAuthorAddress.Visible = true;
                tbEditAuthorEmail.Visible = true;
                tbEditAuthorName.Visible = true;
                tbEditAuthorPhone.Visible = true;
                cbAuthorRegs.Visible = true;
            }
            
        }

        private void rbAddAuthor_CheckedChanged(object sender, EventArgs e)
        {
            if (rbAddAuthor.Checked == true)
            {
                lblAuthorName.Visible = true;
                lblAuthorReg.Visible = true;
                lblAuthorAddress.Visible = true;
                lblAuthorPhone.Visible = true;
                lblAuthorEmail.Visible = true;
                btAddAuthor.Visible = true;
                tbAuthorEmail.Visible = true;
                tbAuthorReg.Visible = true;
                tbAuthorName.Visible = true;
                tbAuthorAddress.Visible = true;
                tbAuthorPhone.Visible = true;
                lblAuthorEditAddress.Visible = false;
                lblAuthorEditEmail.Visible = false;
                lblAuthorEditReg.Visible = false;
                lblAuthorEditName.Visible = false;
                lblAuthorEditPhone.Visible = false;
                btUpdateAuthor.Visible = false;
                tbEditAuthorAddress.Visible = false;
                tbEditAuthorEmail.Visible = false;
                tbEditAuthorName.Visible = false;
                tbEditAuthorPhone.Visible = false;
                cbAuthorRegs.Visible = false;
            }
        }

        private void rbEditAuthor_CheckedChanged(object sender, EventArgs e)
        {
            if (rbEditAuthor.Checked == true)
            {
                lblAuthorName.Visible = false;
                lblAuthorReg.Visible = false;
                lblAuthorAddress.Visible = false;
                lblAuthorPhone.Visible = false;
                lblAuthorEmail.Visible = false;
                btAddAuthor.Visible = false;
                tbAuthorEmail.Visible = false;
                tbAuthorReg.Visible = false;
                tbAuthorName.Visible = false;
                tbAuthorAddress.Visible = false;
                tbAuthorPhone.Visible = false;
                lblAuthorEditAddress.Visible = true;
                lblAuthorEditEmail.Visible = true;
                lblAuthorEditReg.Visible = true;
                lblAuthorEditName.Visible = true;
                lblAuthorEditPhone.Visible = true;
                btUpdateAuthor.Visible = true;
                tbEditAuthorAddress.Visible = true;
                tbEditAuthorEmail.Visible = true;
                tbEditAuthorName.Visible = true;
                tbEditAuthorPhone.Visible = true;
                cbAuthorRegs.Visible = true;

                LMS UpdateAuthor = new LMS();
                DataTable dt = UpdateAuthor.GettingAuthorTable();
                DGAuthor.DataSource = dt;
                if (DGAuthor.Rows.Count > 1)
                {
                    for (int i = 0; i < DGAuthor.Rows.Count; i++)
                    {
                        AuthorReg.Add(Convert.ToString(DGAuthor.Rows[i].Cells[1].Value));
                        AuthorName.Add(Convert.ToString(DGAuthor.Rows[i].Cells[2].Value));
                        AuthorAddress.Add(Convert.ToString(DGAuthor.Rows[i].Cells[3].Value));
                        AuthorPhone.Add(Convert.ToString(DGAuthor.Rows[i].Cells[4].Value));
                        AuthorEmail.Add(Convert.ToString(DGAuthor.Rows[i].Cells[5].Value));
                        IDs.Add(Convert.ToInt32(DGAuthor.Rows[i].Cells[0].Value));
                        cbAuthorRegs.Items.Add(AuthorReg[i]);
                    }
                }
            }

        }

        private void btAddAuthor_Click(object sender, EventArgs e)
        {
            string AuthorName = tbAuthorName.Text;
            string AuthorAddress = tbAuthorAddress.Text;
            string AuthorPhone = tbAuthorPhone.Text;
            string AuthorEmail = tbAuthorEmail.Text;
            string AuthorReg = AuthorName + "" + AuthorPhone + "" + AuthorEmail;
            LMS Register = new LMS();
            int val = Register.InstertAuthor(AuthorReg, AuthorName, AuthorAddress, AuthorPhone, AuthorEmail);

            if (val == 1)
            {
                MessageBox.Show("New Author Added");
            }
        }

        private void btUpdateAuthor_Click(object sender, EventArgs e)
        {
            string Reg = cbAuthorRegs.Text;
            string Name = tbEditAuthorName.Text;
            string Address = tbEditAuthorAddress.Text;
            string Phone = tbEditAuthorPhone.Text;
            string Email = tbEditAuthorEmail.Text;
        }

        private void cbAuthorRegs_SelectedIndexChanged(object sender, EventArgs e)
        {
            string regno = cbAuthorRegs.Text;
            for (int i = 0; i < AuthorReg.Count; i++)
            {
                if (regno == AuthorReg[i])
                {
                    tbEditAuthorName.Text = AuthorName[i];
                    tbEditAuthorAddress.Text = AuthorAddress[i];
                    tbEditAuthorPhone.Text = AuthorPhone[i];
                    tbEditAuthorEmail.Text = AuthorEmail[i];
                    ID = IDs[i];
                    break;
                }
            }
        }
    }
}
