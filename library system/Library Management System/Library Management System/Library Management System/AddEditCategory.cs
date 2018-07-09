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
    public partial class AddEditCategory : Form
    {
        public AddEditCategory()
        {
            InitializeComponent();
        }

        private void AddEditCategory_Load(object sender, EventArgs e)
        {
            lblCategory.Visible = true;
            lblCategoryDesc.Visible = false;
            lblCategoryEditDesc.Visible = false;
            lblCategoryEditID.Visible = false;
            lblCategoryEditName.Visible = false;
            lblCategoryID.Visible = false;
            lblCategoryName.Visible = false;
            tbCategorDesc.Visible = false;
            tbCategoryID.Visible = false;
            tbCategoryName.Visible = false;
            tbEditCategoryDesc.Visible = false;
            tbEditCategoryName.Visible = false;
            cbCategoryIDs.Visible = false;
            btAddCategory.Visible = false;
            btUpdateCategory.Visible = false;

            if (rbAddCategory.Checked == true)
            { 
            lblCategoryID.Visible = true;
            lblCategoryName.Visible = true;
            lblCategoryDesc.Visible = true;
            tbCategoryName.Visible = true;
            tbCategoryID.Visible = true;
            tbCategorDesc.Visible = true;
            btAddCategory.Visible = true;
            cbCategoryIDs.Visible = false;
            lblCategoryEditID.Visible = false;
            lblCategoryEditName.Visible = false;
            lblCategoryEditDesc.Visible = false;
            tbEditCategoryName.Visible = false;
            tbEditCategoryDesc.Visible = false;
            btUpdateCategory.Visible = false; ;
            }
            else if (rbEditCategory.Checked == true)
            {
                lblCategoryID.Visible = false;
                lblCategoryName.Visible = false;
                lblCategoryDesc.Visible = false;
                tbCategoryName.Visible = false;
                tbCategoryID.Visible = false;
                tbCategorDesc.Visible = false;
                btAddCategory.Visible = false;
                cbCategoryIDs.Visible = true;
                lblCategoryEditID.Visible = true;
                lblCategoryEditName.Visible = true;
                lblCategoryEditDesc.Visible = true;
                tbEditCategoryName.Visible = true;
                tbEditCategoryDesc.Visible = true;
                btUpdateCategory.Visible = true ;
            }
        }

        private void rbAddCategory_CheckedChanged(object sender, EventArgs e)
        {

            if (rbAddCategory.Checked == true)
            {
                lblCategoryID.Visible = true;
                lblCategoryName.Visible = true;
                lblCategoryDesc.Visible = true;
                tbCategoryName.Visible = true;
                tbCategoryID.Visible = true;
                tbCategorDesc.Visible = true;
                btAddCategory.Visible = true;
                cbCategoryIDs.Visible = false;
                lblCategoryEditID.Visible = false;
                lblCategoryEditName.Visible = false;
                lblCategoryEditDesc.Visible = false;
                tbEditCategoryName.Visible = false;
                tbEditCategoryDesc.Visible = false;
                btUpdateCategory.Visible = false; ;
            }
        }

        private void rbEditCategory_CheckedChanged(object sender, EventArgs e)
        {
            if (rbEditCategory.Checked == true)
            {
                lblCategoryID.Visible = false;
                lblCategoryName.Visible = false;
                lblCategoryDesc.Visible = false;
                tbCategoryName.Visible = false;
                tbCategoryID.Visible = false;
                tbCategorDesc.Visible = false;
                btAddCategory.Visible = false;
                cbCategoryIDs.Visible = true;
                lblCategoryEditID.Visible = true;
                lblCategoryEditName.Visible = true;
                lblCategoryEditDesc.Visible = true;
                tbEditCategoryName.Visible = true;
                tbEditCategoryDesc.Visible = true;
                btUpdateCategory.Visible = true;
            }
        }
    }
}
