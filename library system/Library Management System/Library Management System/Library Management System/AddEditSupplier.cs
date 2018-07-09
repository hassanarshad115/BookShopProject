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
    public partial class AddEditSupplier : Form
    {
        public AddEditSupplier()
        {
            InitializeComponent();
        }

        private void AddEditSupplier_Load(object sender, EventArgs e)
        {
            lblSupplier.Visible = true;
            lblSupplierAddress.Visible = false;
            lblSupplierEditAddress.Visible = false;
            lblSupplierEditEmail.Visible = false;
            lblSupplierEditID.Visible = false;
            lblSupplierEditName.Visible = false;
            lblSupplierEditPhone.Visible = false;
            lblSupplierEmail.Visible = false;
            lblSupplierID.Visible = false;
            lblSupplierPhone.Visible = false;
            lblSupplierName.Visible = false;
            tbSupplierEmail.Visible = false;
            tbSupplierID.Visible = false;
            tbSupplierName.Visible = false;
            tbSupplierPhone.Visible = false;
            tbSupplierAddress.Visible = false;
            tbEditSupplierAddress.Visible = false;
            tbEditSupplierEmail.Visible = false;
            tbEditSupplierName.Visible = false;
            tbEditSupplierPhone.Visible = false;
            cbSupplierIDs.Visible = false;
            btAddSupplier.Visible = false;
            btUpdateSupplier.Visible = false;

            if (rbAddSupplier.Checked == true)
            {
                lblSupplierName.Visible = true;
                lblSupplierID.Visible = true;
                lblSupplierAddress.Visible = true;
                lblSupplierPhone.Visible = true;
                lblSupplierEmail.Visible = true;
                btAddSupplier.Visible = true;
                tbSupplierEmail.Visible = true;
                tbSupplierID.Visible = true;
                tbSupplierName.Visible = true;
                tbSupplierAddress.Visible = true;
                tbSupplierPhone.Visible = true;
                lblSupplierEditAddress.Visible = false;
                lblSupplierEditEmail.Visible = false;
                lblSupplierEditID.Visible = false;
                lblSupplierEditName.Visible = false;
                lblSupplierEditPhone.Visible = false;
                btUpdateSupplier.Visible = false;
                tbEditSupplierAddress.Visible = false;
                tbEditSupplierEmail.Visible = false;
                tbEditSupplierName.Visible = false;
                tbEditSupplierPhone.Visible = false;
                cbSupplierIDs.Visible = false;
            }
            else if (rbEditSupplier.Checked == true)
            {
                lblSupplierName.Visible = false;
                lblSupplierID.Visible = false;
                lblSupplierAddress.Visible = false;
                lblSupplierPhone.Visible = false;
                lblSupplierEmail.Visible = false;
                btAddSupplier.Visible = false;
                tbSupplierEmail.Visible = false;
                tbSupplierID.Visible = false;
                tbSupplierName.Visible = false;
                tbSupplierAddress.Visible = false;
                tbSupplierPhone.Visible = false;
                lblSupplierEditAddress.Visible = true;
                lblSupplierEditEmail.Visible = true;
                lblSupplierEditID.Visible = true;
                lblSupplierEditName.Visible = true;
                lblSupplierEditPhone.Visible = true;
                btUpdateSupplier.Visible = true;
                tbEditSupplierAddress.Visible = true;
                tbEditSupplierEmail.Visible = true;
                tbEditSupplierName.Visible = true;
                tbEditSupplierPhone.Visible = true;
                cbSupplierIDs.Visible = true;
            }
        }

        private void rbAddSupplier_CheckedChanged(object sender, EventArgs e)
        {
            if (rbAddSupplier.Checked == true)
            {
                lblSupplierName.Visible = true;
                lblSupplierID.Visible = true;
                lblSupplierAddress.Visible = true;
                lblSupplierPhone.Visible = true;
                lblSupplierEmail.Visible = true;
                btAddSupplier.Visible = true;
                tbSupplierEmail.Visible = true;
                tbSupplierID.Visible = true;
                tbSupplierName.Visible = true;
                tbSupplierAddress.Visible = true;
                tbSupplierPhone.Visible = true;
                lblSupplierEditAddress.Visible = false;
                lblSupplierEditEmail.Visible = false;
                lblSupplierEditID.Visible = false;
                lblSupplierEditName.Visible = false;
                lblSupplierEditPhone.Visible = false;
                btUpdateSupplier.Visible = false;
                tbEditSupplierAddress.Visible = false;
                tbEditSupplierEmail.Visible = false;
                tbEditSupplierName.Visible = false;
                tbEditSupplierPhone.Visible = false;
                cbSupplierIDs.Visible = false;
            }
        }

        private void rbEditSupplier_CheckedChanged(object sender, EventArgs e)
        {
            if (rbEditSupplier.Checked == true)
            {
                lblSupplierName.Visible = false;
                lblSupplierID.Visible = false;
                lblSupplierAddress.Visible = false;
                lblSupplierPhone.Visible = false;
                lblSupplierEmail.Visible = false;
                btAddSupplier.Visible = false;
                tbSupplierEmail.Visible = false;
                tbSupplierID.Visible = false;
                tbSupplierName.Visible = false;
                tbSupplierAddress.Visible = false;
                tbSupplierPhone.Visible = false;
                lblSupplierEditAddress.Visible = true;
                lblSupplierEditEmail.Visible = true;
                lblSupplierEditID.Visible = true;
                lblSupplierEditName.Visible = true;
                lblSupplierEditPhone.Visible = true;
                btUpdateSupplier.Visible = true;
                tbEditSupplierAddress.Visible = true;
                tbEditSupplierEmail.Visible = true;
                tbEditSupplierName.Visible = true;
                tbEditSupplierPhone.Visible = true;
                cbSupplierIDs.Visible = true;
            }
        }
    }
}
