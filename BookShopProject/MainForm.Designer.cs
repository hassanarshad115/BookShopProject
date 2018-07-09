namespace BookShopProject
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.label1 = new System.Windows.Forms.Label();
            this.clientnametextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.pricetextBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.itemnamecomboBox = new System.Windows.Forms.ComboBox();
            this.quantitycomboBox = new System.Windows.Forms.ComboBox();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.DVprintPreviewDialog = new System.Windows.Forms.PrintPreviewDialog();
            this.DVprintDocument = new System.Drawing.Printing.PrintDocument();
            this.totaltopaytextBox = new System.Windows.Forms.TextBox();
            this.exitapplicationbutton = new System.Windows.Forms.Button();
            this.printingbotton = new System.Windows.Forms.Button();
            this.printprivewbotton = new System.Windows.Forms.Button();
            this.addnewbutton = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.DashLabel = new System.Windows.Forms.Label();
            this.linkLabel2 = new System.Windows.Forms.LinkLabel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(81, 109);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "&Client Name:";
            // 
            // clientnametextBox
            // 
            this.clientnametextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clientnametextBox.Location = new System.Drawing.Point(212, 109);
            this.clientnametextBox.Name = "clientnametextBox";
            this.clientnametextBox.Size = new System.Drawing.Size(210, 26);
            this.clientnametextBox.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(81, 152);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "&Item Name:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(81, 193);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 20);
            this.label3.TabIndex = 1;
            this.label3.Text = "&Quantity:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(81, 236);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 20);
            this.label4.TabIndex = 1;
            this.label4.Text = "&Price:";
            // 
            // pricetextBox
            // 
            this.pricetextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pricetextBox.Location = new System.Drawing.Point(212, 236);
            this.pricetextBox.Name = "pricetextBox";
            this.pricetextBox.Size = new System.Drawing.Size(97, 26);
            this.pricetextBox.TabIndex = 3;
            this.pricetextBox.TextChanged += new System.EventHandler(this.pricetextBox_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(81, 294);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(96, 20);
            this.label5.TabIndex = 1;
            this.label5.Text = "&Total to Pay:";
            // 
            // itemnamecomboBox
            // 
            this.itemnamecomboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.itemnamecomboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.itemnamecomboBox.FormattingEnabled = true;
            this.itemnamecomboBox.Items.AddRange(new object[] {
            "",
            "C#",
            "C++",
            "DLD",
            "CSS",
            "PHP",
            "JAVA",
            "HTML5",
            "VB.NET",
            "ASP.NET",
            "DATA STRUCTURE",
            "DATABASE",
            "SOFTWARE ENGINEERING"});
            this.itemnamecomboBox.Location = new System.Drawing.Point(212, 153);
            this.itemnamecomboBox.Name = "itemnamecomboBox";
            this.itemnamecomboBox.Size = new System.Drawing.Size(210, 28);
            this.itemnamecomboBox.TabIndex = 1;
            this.itemnamecomboBox.SelectedIndexChanged += new System.EventHandler(this.itemnamecomboBox_SelectedIndexChanged);
            // 
            // quantitycomboBox
            // 
            this.quantitycomboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.quantitycomboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.quantitycomboBox.FormattingEnabled = true;
            this.quantitycomboBox.Items.AddRange(new object[] {
            "",
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10"});
            this.quantitycomboBox.Location = new System.Drawing.Point(212, 195);
            this.quantitycomboBox.Name = "quantitycomboBox";
            this.quantitycomboBox.Size = new System.Drawing.Size(97, 28);
            this.quantitycomboBox.TabIndex = 2;
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel1.Location = new System.Drawing.Point(221, 337);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(262, 20);
            this.linkLabel1.TabIndex = 8;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "https://www.hassanmalik.comyr.com";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // DVprintPreviewDialog
            // 
            this.DVprintPreviewDialog.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.DVprintPreviewDialog.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.DVprintPreviewDialog.ClientSize = new System.Drawing.Size(400, 300);
            this.DVprintPreviewDialog.Enabled = true;
            this.DVprintPreviewDialog.Icon = ((System.Drawing.Icon)(resources.GetObject("DVprintPreviewDialog.Icon")));
            this.DVprintPreviewDialog.Name = "DVprintPreviewDialog";
            this.DVprintPreviewDialog.Visible = false;
            // 
            // DVprintDocument
            // 
            this.DVprintDocument.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.DVprintDocument_PrintPage);
            // 
            // totaltopaytextBox
            // 
            this.totaltopaytextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totaltopaytextBox.Location = new System.Drawing.Point(212, 290);
            this.totaltopaytextBox.Multiline = true;
            this.totaltopaytextBox.Name = "totaltopaytextBox";
            this.totaltopaytextBox.ReadOnly = true;
            this.totaltopaytextBox.Size = new System.Drawing.Size(97, 32);
            this.totaltopaytextBox.TabIndex = 9;
            this.totaltopaytextBox.TextChanged += new System.EventHandler(this.totaltopaytextBox_TextChanged);
            // 
            // exitapplicationbutton
            // 
            this.exitapplicationbutton.BackColor = System.Drawing.Color.Transparent;
            this.exitapplicationbutton.Image = global::BookShopProject.Properties.Resources.exit;
            this.exitapplicationbutton.Location = new System.Drawing.Point(638, 3);
            this.exitapplicationbutton.Name = "exitapplicationbutton";
            this.exitapplicationbutton.Size = new System.Drawing.Size(39, 43);
            this.exitapplicationbutton.TabIndex = 7;
            this.exitapplicationbutton.UseVisualStyleBackColor = false;
            this.exitapplicationbutton.Click += new System.EventHandler(this.exitapplicationbutton_Click);
            // 
            // printingbotton
            // 
            this.printingbotton.Image = global::BookShopProject.Properties.Resources.printphpto;
            this.printingbotton.Location = new System.Drawing.Point(432, 216);
            this.printingbotton.Name = "printingbotton";
            this.printingbotton.Size = new System.Drawing.Size(122, 43);
            this.printingbotton.TabIndex = 6;
            this.printingbotton.Text = "Print";
            this.printingbotton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.printingbotton.UseVisualStyleBackColor = true;
            this.printingbotton.Click += new System.EventHandler(this.printingbotton_Click);
            // 
            // printprivewbotton
            // 
            this.printprivewbotton.Image = ((System.Drawing.Image)(resources.GetObject("printprivewbotton.Image")));
            this.printprivewbotton.Location = new System.Drawing.Point(432, 162);
            this.printprivewbotton.Name = "printprivewbotton";
            this.printprivewbotton.Size = new System.Drawing.Size(122, 43);
            this.printprivewbotton.TabIndex = 5;
            this.printprivewbotton.Text = "Print Preview";
            this.printprivewbotton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.printprivewbotton.UseVisualStyleBackColor = true;
            this.printprivewbotton.Click += new System.EventHandler(this.printprivewbotton_Click_1);
            // 
            // addnewbutton
            // 
            this.addnewbutton.Image = global::BookShopProject.Properties.Resources.add;
            this.addnewbutton.Location = new System.Drawing.Point(432, 108);
            this.addnewbutton.Name = "addnewbutton";
            this.addnewbutton.Size = new System.Drawing.Size(122, 43);
            this.addnewbutton.TabIndex = 4;
            this.addnewbutton.Text = "&Add New Items";
            this.addnewbutton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.addnewbutton.UseVisualStyleBackColor = true;
            this.addnewbutton.Click += new System.EventHandler(this.addnewbutton_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.ErrorImage = null;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(140, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(413, 100);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // DashLabel
            // 
            this.DashLabel.AutoSize = true;
            this.DashLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DashLabel.Location = new System.Drawing.Point(108, 377);
            this.DashLabel.Name = "DashLabel";
            this.DashLabel.Size = new System.Drawing.Size(793, 17);
            this.DashLabel.TabIndex = 10;
            this.DashLabel.Text = "................................................................................." +
    "............................................................................";
            // 
            // linkLabel2
            // 
            this.linkLabel2.AutoSize = true;
            this.linkLabel2.Location = new System.Drawing.Point(312, 361);
            this.linkLabel2.Name = "linkLabel2";
            this.linkLabel2.Size = new System.Drawing.Size(115, 13);
            this.linkLabel2.TabIndex = 11;
            this.linkLabel2.TabStop = true;
            this.linkLabel2.Text = "www.hassanmalik.com";
            this.linkLabel2.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel2_LinkClicked);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(683, 388);
            this.Controls.Add(this.linkLabel2);
            this.Controls.Add(this.DashLabel);
            this.Controls.Add(this.totaltopaytextBox);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.exitapplicationbutton);
            this.Controls.Add(this.printingbotton);
            this.Controls.Add(this.printprivewbotton);
            this.Controls.Add(this.addnewbutton);
            this.Controls.Add(this.quantitycomboBox);
            this.Controls.Add(this.itemnamecomboBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.pricetextBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.clientnametextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Book Shop Project by Hassan";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox clientnametextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox pricetextBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox itemnamecomboBox;
        private System.Windows.Forms.ComboBox quantitycomboBox;
        private System.Windows.Forms.Button addnewbutton;
        private System.Windows.Forms.Button printprivewbotton;
        private System.Windows.Forms.Button printingbotton;
        private System.Windows.Forms.Button exitapplicationbutton;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.PrintPreviewDialog DVprintPreviewDialog;
        private System.Drawing.Printing.PrintDocument DVprintDocument;
        private System.Windows.Forms.TextBox totaltopaytextBox;
        private System.Windows.Forms.Label DashLabel;
        private System.Windows.Forms.LinkLabel linkLabel2;
    }
}

