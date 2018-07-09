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
    public partial class AddEditBook : Form
    {
        public AddEditBook()
        {
            InitializeComponent();
        }

        private void AddEditBook_Load(object sender, EventArgs e)
        {
            lblBook.Visible = true;
            lblBookAuthor.Visible = false;
            lblBookCategory.Visible = false;
            lblBookISBN.Visible = false;
            lblBookName.Visible = false;
            lblBookPrice.Visible = false;
            lblBookPublisher.Visible = false;
            lblBookQuantity.Visible = false;
            lblBookSupllier.Visible = false;
            tbBookID.Visible = false;
            tbBookIsbn.Visible = false;
            tbBookName.Visible = false;
            tbBookPrice.Visible = false;
            tbBookQuantity.Visible = false;
            cbBookAuthor.Visible = false;
            cbBookCategory.Visible = false;
            cbBookPublisher.Visible = false;
            cbBookSupplier.Visible = false;
            btAddBook.Visible = false;

            cbBookID.Visible = false;
            lblEditBookCategory.Visible = false;
            lblEditBookID.Visible = false;
            lblEditBookAuthor.Visible = false;
            lblEditBookIsbn.Visible = false;
            lblEditBookName.Visible = false;
            lblEditBookPrice.Visible = false;
            lblEditBookPublisher.Visible = false;
            lblEditBookQuantity.Visible = false;
            lblEditBookSupplier.Visible = false;
            tbEditBookAuthor.Visible = false;
            tbEditBookCategory.Visible = false;
            tbEditBookIsbn.Visible = false;
            tbEditBookName.Visible = false;
            tbEditBookPrice.Visible = false;
            tbEditBookPublisher.Visible = false;
            tbEditBookSupplier.Visible = false;
            tbEditBookQuantity.Visible = false;
            btUpdateBook.Visible = false;

            if (rbAddBook.Checked == true)
            {
               
                lblBookAuthor.Visible = true;
                lblBookCategory.Visible = true;
                lblBookISBN.Visible = true;
                lblBookName.Visible = true;
                lblBookPrice.Visible = true;
                lblBookPublisher.Visible = true;
                lblBookQuantity.Visible = true;
                lblBookSupllier.Visible = true;
                tbBookID.Visible = true;
                tbBookIsbn.Visible = true;
                tbBookName.Visible =true;
                tbBookPrice.Visible = true;
                tbBookQuantity.Visible = true;
                cbBookAuthor.Visible = true;
                cbBookCategory.Visible = true;
                cbBookPublisher.Visible = true;
                cbBookSupplier.Visible = true;
                btAddBook.Visible = true;

                cbBookID.Visible = false;
                lblEditBookCategory.Visible = false;
                lblEditBookID.Visible = false;
                lblEditBookAuthor.Visible = false;
                lblEditBookIsbn.Visible = false;
                lblEditBookName.Visible = false;
                lblEditBookPrice.Visible = false;
                lblEditBookPublisher.Visible = false;
                lblEditBookQuantity.Visible = false;
                lblEditBookSupplier.Visible = false;
                tbEditBookAuthor.Visible = false;
                tbEditBookCategory.Visible = false;
                tbEditBookIsbn.Visible = false;
                tbEditBookName.Visible = false;
                tbEditBookPrice.Visible = false;
                tbEditBookPublisher.Visible = false;
                tbEditBookSupplier.Visible = false;
                tbEditBookQuantity.Visible = false;
                btUpdateBook.Visible = false;
            }
            else if (rbEditBook.Checked == true)
            {
       
                lblBookAuthor.Visible = false;
                lblBookCategory.Visible = false;
                lblBookISBN.Visible = false;
                lblBookName.Visible = false;
                lblBookPrice.Visible = false;
                lblBookPublisher.Visible = false;
                lblBookQuantity.Visible = false;
                lblBookSupllier.Visible = false;
                tbBookID.Visible = false;
                tbBookIsbn.Visible = false;
                tbBookName.Visible = false;
                tbBookPrice.Visible = false;
                tbBookQuantity.Visible = false;
                cbBookAuthor.Visible = false;
                cbBookCategory.Visible = false;
                cbBookPublisher.Visible = false;
                cbBookSupplier.Visible = false;
                btAddBook.Visible = false;

                cbBookID.Visible = true;
                lblEditBookCategory.Visible = true;
                lblEditBookID.Visible = true;
                lblEditBookAuthor.Visible = true;
                lblEditBookIsbn.Visible = true;
                lblEditBookName.Visible = true;
                lblEditBookPrice.Visible = true;
                lblEditBookPublisher.Visible = true;
                lblEditBookQuantity.Visible = true;
                lblEditBookSupplier.Visible = true;
                tbEditBookAuthor.Visible = true;
                tbEditBookCategory.Visible = true;
                tbEditBookIsbn.Visible = true;
                tbEditBookName.Visible = true;
                tbEditBookPrice.Visible = true;
                tbEditBookPublisher.Visible = true;
                tbEditBookSupplier.Visible = true;
                tbEditBookQuantity.Visible = true;
                btUpdateBook.Visible = true;
            }
        }

        private void rbAddBook_CheckedChanged(object sender, EventArgs e)
        {
            if (rbAddBook.Checked == true)
            {
                lblBookAuthor.Visible = true;
                lblBookCategory.Visible = true;
                lblBookISBN.Visible = true;
                lblBookName.Visible = true;
                lblBookPrice.Visible = true;
                lblBookPublisher.Visible = true;
                lblBookQuantity.Visible = true;
                lblBookSupllier.Visible = true;
                tbBookID.Visible = true;
                tbBookIsbn.Visible = true;
                tbBookName.Visible = true;
                tbBookPrice.Visible = true;
                tbBookQuantity.Visible = true;
                cbBookAuthor.Visible = true;
                cbBookCategory.Visible = true;
                cbBookPublisher.Visible = true;
                cbBookSupplier.Visible = true;
                btAddBook.Visible = true;

                cbBookID.Visible = false;
                lblEditBookCategory.Visible = false;
                lblEditBookID.Visible = false;
                lblEditBookAuthor.Visible = false;
                lblEditBookIsbn.Visible = false;
                lblEditBookName.Visible = false;
                lblEditBookPrice.Visible = false;
                lblEditBookPublisher.Visible = false;
                lblEditBookQuantity.Visible = false;
                lblEditBookSupplier.Visible = false;
                tbEditBookAuthor.Visible = false;
                tbEditBookCategory.Visible = false;
                tbEditBookIsbn.Visible = false;
                tbEditBookName.Visible = false;
                tbEditBookPrice.Visible = false;
                tbEditBookPublisher.Visible = false;
                tbEditBookSupplier.Visible = false;
                tbEditBookQuantity.Visible = false;
                btUpdateBook.Visible = false;
            }
        }

        private void rbEditBook_CheckedChanged(object sender, EventArgs e)
        {
            if (rbEditBook.Checked == true)
            {

                lblBookAuthor.Visible = false;
                lblBookCategory.Visible = false;
                lblBookISBN.Visible = false;
                lblBookName.Visible = false;
                lblBookPrice.Visible = false;
                lblBookPublisher.Visible = false;
                lblBookQuantity.Visible = false;
                lblBookSupllier.Visible = false;
                tbBookID.Visible = false;
                tbBookIsbn.Visible = false;
                tbBookName.Visible = false;
                tbBookPrice.Visible = false;
                tbBookQuantity.Visible = false;
                cbBookAuthor.Visible = false;
                cbBookCategory.Visible = false;
                cbBookPublisher.Visible = false;
                cbBookSupplier.Visible = false;
                btAddBook.Visible = false;

                cbBookID.Visible = true;
                lblEditBookCategory.Visible = true;
                lblEditBookID.Visible = true;
                lblEditBookAuthor.Visible = true;
                lblEditBookIsbn.Visible = true;
                lblEditBookName.Visible = true;
                lblEditBookPrice.Visible = true;
                lblEditBookPublisher.Visible = true;
                lblEditBookQuantity.Visible = true;
                lblEditBookSupplier.Visible = true;
                tbEditBookAuthor.Visible = true;
                tbEditBookCategory.Visible = true;
                tbEditBookIsbn.Visible = true;
                tbEditBookName.Visible = true;
                tbEditBookPrice.Visible = true;
                tbEditBookPublisher.Visible = true;
                tbEditBookSupplier.Visible = true;
                tbEditBookQuantity.Visible = true;
                btUpdateBook.Visible = true;
            }
        }
    }
}
