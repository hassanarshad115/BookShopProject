namespace Library_Management_System
{
    partial class WelcomeAdmin
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblWelcome = new System.Windows.Forms.Label();
            this.btAEPublisher = new System.Windows.Forms.Button();
            this.btAEAuthor = new System.Windows.Forms.Button();
            this.btAECategory = new System.Windows.Forms.Button();
            this.btAEBook = new System.Windows.Forms.Button();
            this.btAESupplier = new System.Windows.Forms.Button();
            this.btSearch = new System.Windows.Forms.Button();
            this.btAdminLogout = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblWelcome
            // 
            this.lblWelcome.AutoSize = true;
            this.lblWelcome.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWelcome.Location = new System.Drawing.Point(328, 32);
            this.lblWelcome.Name = "lblWelcome";
            this.lblWelcome.Size = new System.Drawing.Size(137, 20);
            this.lblWelcome.TabIndex = 1;
            this.lblWelcome.Text = "Welcome Admin";
            // 
            // btAEPublisher
            // 
            this.btAEPublisher.Location = new System.Drawing.Point(64, 102);
            this.btAEPublisher.Name = "btAEPublisher";
            this.btAEPublisher.Size = new System.Drawing.Size(113, 23);
            this.btAEPublisher.TabIndex = 6;
            this.btAEPublisher.Text = "Add/Edit Publisher";
            this.btAEPublisher.UseVisualStyleBackColor = true;
            this.btAEPublisher.Click += new System.EventHandler(this.btAEPublisher_Click);
            // 
            // btAEAuthor
            // 
            this.btAEAuthor.Location = new System.Drawing.Point(297, 102);
            this.btAEAuthor.Name = "btAEAuthor";
            this.btAEAuthor.Size = new System.Drawing.Size(113, 23);
            this.btAEAuthor.TabIndex = 7;
            this.btAEAuthor.Text = "Add/Edit Author";
            this.btAEAuthor.UseVisualStyleBackColor = true;
            this.btAEAuthor.Click += new System.EventHandler(this.btAEAuthor_Click);
            // 
            // btAECategory
            // 
            this.btAECategory.Location = new System.Drawing.Point(522, 102);
            this.btAECategory.Name = "btAECategory";
            this.btAECategory.Size = new System.Drawing.Size(113, 23);
            this.btAECategory.TabIndex = 8;
            this.btAECategory.Text = "Add/Edit Category";
            this.btAECategory.UseVisualStyleBackColor = true;
            this.btAECategory.Click += new System.EventHandler(this.btAECategory_Click);
            // 
            // btAEBook
            // 
            this.btAEBook.Location = new System.Drawing.Point(297, 174);
            this.btAEBook.Name = "btAEBook";
            this.btAEBook.Size = new System.Drawing.Size(113, 23);
            this.btAEBook.TabIndex = 9;
            this.btAEBook.Text = "Add/Edit Book";
            this.btAEBook.UseVisualStyleBackColor = true;
            this.btAEBook.Click += new System.EventHandler(this.btAEBook_Click);
            // 
            // btAESupplier
            // 
            this.btAESupplier.Location = new System.Drawing.Point(64, 174);
            this.btAESupplier.Name = "btAESupplier";
            this.btAESupplier.Size = new System.Drawing.Size(113, 23);
            this.btAESupplier.TabIndex = 10;
            this.btAESupplier.Text = "Add/Edit Supplier";
            this.btAESupplier.UseVisualStyleBackColor = true;
            this.btAESupplier.Click += new System.EventHandler(this.btAESupplier_Click);
            // 
            // btSearch
            // 
            this.btSearch.Location = new System.Drawing.Point(522, 174);
            this.btSearch.Name = "btSearch";
            this.btSearch.Size = new System.Drawing.Size(113, 23);
            this.btSearch.TabIndex = 11;
            this.btSearch.Text = "Search";
            this.btSearch.UseVisualStyleBackColor = true;
            this.btSearch.Click += new System.EventHandler(this.btSearch_Click);
            // 
            // btAdminLogout
            // 
            this.btAdminLogout.Location = new System.Drawing.Point(297, 337);
            this.btAdminLogout.Name = "btAdminLogout";
            this.btAdminLogout.Size = new System.Drawing.Size(113, 23);
            this.btAdminLogout.TabIndex = 12;
            this.btAdminLogout.Text = "Logout";
            this.btAdminLogout.UseVisualStyleBackColor = true;
            // 
            // WelcomeAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(803, 399);
            this.Controls.Add(this.btAdminLogout);
            this.Controls.Add(this.btSearch);
            this.Controls.Add(this.btAESupplier);
            this.Controls.Add(this.btAEBook);
            this.Controls.Add(this.btAECategory);
            this.Controls.Add(this.btAEAuthor);
            this.Controls.Add(this.btAEPublisher);
            this.Controls.Add(this.lblWelcome);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "WelcomeAdmin";
            this.Text = "WelcomeAdmin";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Button btAdminLogout;
        public System.Windows.Forms.Label lblWelcome;
        public System.Windows.Forms.Button btAEPublisher;
        public System.Windows.Forms.Button btAEAuthor;
        public System.Windows.Forms.Button btAECategory;
        public System.Windows.Forms.Button btAEBook;
        public System.Windows.Forms.Button btAESupplier;
        public System.Windows.Forms.Button btSearch;

    }
}