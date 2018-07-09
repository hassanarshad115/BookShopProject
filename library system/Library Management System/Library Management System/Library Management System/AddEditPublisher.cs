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
    public partial class AddEditPublisher : Form
    {
        public AddEditPublisher()
        {
            InitializeComponent();
        }

        List<string> PublisherReg = new List<string>();
        List<string> PublisherName = new List<string>();
        List<string> PublisherYear = new List<string>();
        List<string> PublisherHouse = new List<string>();
        List<string> PublisherEdition = new List<string>();
        List<int> IDs = new List<int>();
        int ID = 0;
        private void AddEditPublisher_Load(object sender, EventArgs e)
        {
            lblPublisheEditID.Visible = false;
            lblPublisherEditEdition.Visible = false;
            lblPublisherEditHouse.Visible = false;
            lblPublisherEdition.Visible = false;
            lblPublisherEditName.Visible = false;
            lblPublisherEditYear.Visible = false;
            lblPublisherReg.Visible = false;
            lblPublisherName.Visible = false;
            lblPublisherYear.Visible = false;
            lblPublishingHouse.Visible = false;
            btUpdatePublisher.Visible = false;
            btAddPublisher.Visible = false;
            tbEditPublisherName.Visible = false;
            tbEditPublisherYear.Visible = false;
            tbPublisherEditEdition.Visible = false;
            tbPublisherEditHouse.Visible = false;
            tbPublisherEdition.Visible = true;
            tbPublisherHouse.Visible = false;
            tbPublisherReg.Visible = false;
            tbPublisherName.Visible = false;
            tbPublisherYear.Visible = false;
            cbPublisherRegs.Visible = false;

            if (rbAddPublisher.Checked == true)
            {
                cbPublisherRegs.Visible = false;
                lblPublisheEditID.Visible = false;
                lblPublisherEditEdition.Visible = false;
                lblPublisherEditHouse.Visible = false;
                lblPublisherEdition.Visible = true;
                lblPublisherEditName.Visible = false;
                lblPublisherEditYear.Visible = false;
                lblPublisherReg.Visible = true;
                lblPublisherName.Visible = true;
                lblPublisherYear.Visible = true;
                lblPublishingHouse.Visible = true;
                btUpdatePublisher.Visible = false;
                btAddPublisher.Visible = true;
                tbEditPublisherName.Visible = false;
                tbEditPublisherYear.Visible = false;
                tbPublisherEditEdition.Visible = false;
                tbPublisherEditHouse.Visible = false;
                tbPublisherEdition.Visible = true;
                tbPublisherHouse.Visible = true;
                tbPublisherReg.Visible = true;
                tbPublisherName.Visible = true;
                tbPublisherYear.Visible = true;
            }
            if (rbEditPublisher.Checked == true)
            {
                cbPublisherRegs.Visible = true;
                lblPublisheEditID.Visible = true;
                lblPublisherEditEdition.Visible = true;
                lblPublisherEditHouse.Visible = true;
                lblPublisherEdition.Visible = true;
                lblPublisherEditName.Visible = true;
                lblPublisherEditYear.Visible = true;
                lblPublisherReg.Visible = false;
                lblPublisherName.Visible = false;
                lblPublisherYear.Visible = false;
                lblPublishingHouse.Visible = false;
                btUpdatePublisher.Visible = true;
                btAddPublisher.Visible = false;
                tbEditPublisherName.Visible = true;
                tbEditPublisherYear.Visible = true;
                tbPublisherEditEdition.Visible = true;
                tbPublisherEditHouse.Visible = true;
                tbPublisherEdition.Visible = false;
                tbPublisherHouse.Visible = false;
                tbPublisherReg.Visible = false;
                tbPublisherName.Visible = false;
                tbPublisherYear.Visible = false;

            }

        }

        private void rbAddPublisher_CheckedChanged(object sender, EventArgs e)
        {
            if (rbAddPublisher.Checked == true)
            {
                cbPublisherRegs.Visible = false;
                lblPublisheEditID.Visible = false;
                lblPublisherEditEdition.Visible = false;
                lblPublisherEditHouse.Visible = false;
                lblPublisherEdition.Visible = true;
                lblPublisherEditName.Visible = false;
                lblPublisherEditYear.Visible = false;
                lblPublisherReg.Visible = true;
                lblPublisherName.Visible = true;
                lblPublisherYear.Visible = true;
                lblPublishingHouse.Visible = true;
                btUpdatePublisher.Visible = false;
                btAddPublisher.Visible = true;
                tbEditPublisherName.Visible = false;
                tbEditPublisherYear.Visible = false;
                tbPublisherEditEdition.Visible = false;
                tbPublisherEditHouse.Visible = false;
                tbPublisherEdition.Visible = true;
                tbPublisherHouse.Visible = true;
                tbPublisherReg.Visible = true;
                tbPublisherName.Visible = true;
                tbPublisherYear.Visible = true;
            }

        }

        private void rbEditPublisher_CheckedChanged(object sender, EventArgs e)
        {
            if (rbEditPublisher.Checked == true)
            {
                cbPublisherRegs.Visible = true;
                lblPublisheEditID.Visible = true;
                lblPublisherEditEdition.Visible = true;
                lblPublisherEditHouse.Visible = true;
                lblPublisherEdition.Visible = false;
                lblPublisherEditName.Visible = true;
                lblPublisherEditYear.Visible = true;
                lblPublisherReg.Visible = false;
                lblPublisherName.Visible = false;
                lblPublisherYear.Visible = false;
                lblPublishingHouse.Visible = false;
                btUpdatePublisher.Visible = true;
                btAddPublisher.Visible = false;
                tbEditPublisherName.Visible = true;
                tbEditPublisherYear.Visible = true;
                tbPublisherEditEdition.Visible = true;
                tbPublisherEditHouse.Visible = true;
                tbPublisherEdition.Visible = false;
                tbPublisherHouse.Visible = false;
                tbPublisherReg.Visible = false;
                tbPublisherName.Visible = false;
                tbPublisherYear.Visible = false;

              
                LMS UpdatePublisher = new LMS();
                DataTable dt = UpdatePublisher.GettingPublisherTable();
                DGPublisher.DataSource = dt;
                if (DGPublisher.Rows.Count > 1)
                {
                    for (int i = 0; i < DGPublisher.Rows.Count; i++)
                    {
                        PublisherReg.Add(Convert.ToString(DGPublisher.Rows[i].Cells[1].Value));
                        PublisherName.Add(Convert.ToString(DGPublisher.Rows[i].Cells[2].Value));
                        PublisherYear.Add(Convert.ToString(DGPublisher.Rows[i].Cells[3].Value));
                        PublisherHouse.Add(Convert.ToString(DGPublisher.Rows[i].Cells[4].Value));
                        PublisherEdition.Add(Convert.ToString(DGPublisher.Rows[i].Cells[5].Value));
                        IDs.Add(Convert.ToInt32(DGPublisher.Rows[i].Cells[0].Value));
                        cbPublisherRegs.Items.Add(PublisherReg[i]) ;
                    }
                }

            
            }
        }

        private void btAddPublisher_Click(object sender, EventArgs e)
        {
           
            string PublisherName=tbPublisherName.Text;
            string PublisherYear=tbPublisherYear.Text;
            string PublisherHouse=tbPublisherHouse.Text;
            string PublisherEdition=tbPublisherEdition.Text;
            string PublisherReg = PublisherName + "" + PublisherYear + "" + PublisherEdition + ""+PublisherHouse;
            LMS Register = new LMS();
            int val = Register.InsertPublisher(PublisherReg, PublisherName, PublisherYear, PublisherHouse, PublisherEdition);
            if (val == 1)
            {
                MessageBox.Show("New Publisher Added");
            }
        }

        private void tbPublisherReg_TextChanged(object sender, EventArgs e)
        {
         
        }

        private void cbPublisherRegs_SelectedIndexChanged(object sender, EventArgs e)
        {
            string RegNo = cbPublisherRegs.Text;
            for (int i = 0; i < PublisherReg.Count; i++)
            {
                if (RegNo == PublisherReg[i])
                {
                    tbEditPublisherName.Text = PublisherName[i];
                    tbEditPublisherYear.Text = PublisherYear[i];
                    tbPublisherEditHouse.Text = PublisherHouse[i];
                    tbPublisherEditEdition.Text = PublisherEdition[i];
                    ID = IDs[i];
                    break;
                }
            }
        }

        private void btUpdatePublisher_Click(object sender, EventArgs e)
        {
            string Reg = cbPublisherRegs.Text;
            string Name = tbEditPublisherName.Text;
            string Year = tbEditPublisherYear.Text;
            string House = tbPublisherEditHouse.Text;
            string Edition = tbPublisherEditEdition.Text;
            
            LMS UpdatePublisher = new LMS();
            int val=UpdatePublisher.UpdatePublisher(ID, Name, Year, House, Edition);
            if (val == 1)
            {
                MessageBox.Show("Data Updated");
            }
        }
    }
}
