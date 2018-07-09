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
    public partial class WelcomeAdmin : Form
    {
        public WelcomeAdmin()
        {
            InitializeComponent();
        }

        private void btAEPublisher_Click(object sender, EventArgs e)
        {
            this.Hide();
            AddEditPublisher AEPublisherForm = new AddEditPublisher();
            AEPublisherForm.Show();
        }

        private void btAEAuthor_Click(object sender, EventArgs e)
        {
            this.Hide();
            AddEditAuthor AEAuthorForm = new AddEditAuthor();
            AEAuthorForm.Show();
        }

        private void btAECategory_Click(object sender, EventArgs e)
        {
            this.Hide();
            AddEditCategory AECategoryForm = new AddEditCategory();
            AECategoryForm.Show();
        }

        private void btAESupplier_Click(object sender, EventArgs e)
        {
            this.Hide();
            AddEditSupplier AESupplierForm = new AddEditSupplier();
            AESupplierForm.Show();
        }

        private void btAEBook_Click(object sender, EventArgs e)
        {
            this.Hide();
            AddEditBook AEBookForm = new AddEditBook();
            AEBookForm.Show();
        }

        private void btSearch_Click(object sender, EventArgs e)
        {
            this.Hide();
            SearchForm Search = new SearchForm();
            Search.Show();
        }
    }
}
