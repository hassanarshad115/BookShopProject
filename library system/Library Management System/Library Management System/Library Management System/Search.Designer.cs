namespace Library_Management_System
{
    partial class SearchForm
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
            this.cbType = new System.Windows.Forms.ComboBox();
            this.lblType = new System.Windows.Forms.Label();
            this.lblSearch = new System.Windows.Forms.Label();
            this.SearchGridView = new System.Windows.Forms.DataGridView();
            this.lblSearchType = new System.Windows.Forms.Label();
            this.TbSearch = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.SearchGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // cbType
            // 
            this.cbType.FormattingEnabled = true;
            this.cbType.Items.AddRange(new object[] {
            "Book",
            "Author",
            "Category",
            "Supplier",
            "Publisher"});
            this.cbType.Location = new System.Drawing.Point(370, 42);
            this.cbType.Name = "cbType";
            this.cbType.Size = new System.Drawing.Size(161, 21);
            this.cbType.TabIndex = 51;
            // 
            // lblType
            // 
            this.lblType.AutoSize = true;
            this.lblType.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblType.Location = new System.Drawing.Point(204, 42);
            this.lblType.Name = "lblType";
            this.lblType.Size = new System.Drawing.Size(47, 20);
            this.lblType.TabIndex = 52;
            this.lblType.Text = "Type";
            // 
            // lblSearch
            // 
            this.lblSearch.AutoSize = true;
            this.lblSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSearch.Location = new System.Drawing.Point(334, 9);
            this.lblSearch.Name = "lblSearch";
            this.lblSearch.Size = new System.Drawing.Size(66, 20);
            this.lblSearch.TabIndex = 53;
            this.lblSearch.Text = "Search";
            // 
            // SearchGridView
            // 
            this.SearchGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.SearchGridView.Location = new System.Drawing.Point(229, 115);
            this.SearchGridView.Name = "SearchGridView";
            this.SearchGridView.Size = new System.Drawing.Size(302, 150);
            this.SearchGridView.TabIndex = 54;
            // 
            // lblSearchType
            // 
            this.lblSearchType.AutoSize = true;
            this.lblSearchType.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSearchType.Location = new System.Drawing.Point(186, 76);
            this.lblSearchType.Name = "lblSearchType";
            this.lblSearchType.Size = new System.Drawing.Size(160, 20);
            this.lblSearchType.TabIndex = 55;
            this.lblSearchType.Text = "Search Type Name";
            // 
            // TbSearch
            // 
            this.TbSearch.Location = new System.Drawing.Point(370, 78);
            this.TbSearch.Name = "TbSearch";
            this.TbSearch.Size = new System.Drawing.Size(161, 20);
            this.TbSearch.TabIndex = 96;
            // 
            // SearchForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(799, 395);
            this.Controls.Add(this.TbSearch);
            this.Controls.Add(this.lblSearchType);
            this.Controls.Add(this.SearchGridView);
            this.Controls.Add(this.lblSearch);
            this.Controls.Add(this.lblType);
            this.Controls.Add(this.cbType);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "SearchForm";
            this.Text = "Search";
            this.Load += new System.EventHandler(this.SearchForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.SearchGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbType;
        public System.Windows.Forms.Label lblType;
        public System.Windows.Forms.Label lblSearch;
        private System.Windows.Forms.DataGridView SearchGridView;
        public System.Windows.Forms.Label lblSearchType;
        private System.Windows.Forms.TextBox TbSearch;
    }
}