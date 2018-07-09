namespace Library_Management_System
{
    partial class MemberForm
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
            this.tbPhone = new System.Windows.Forms.TextBox();
            this.tbName = new System.Windows.Forms.TextBox();
            this.tbPassword = new System.Windows.Forms.TextBox();
            this.tbEmail = new System.Windows.Forms.TextBox();
            this.lblGender = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblPhone = new System.Windows.Forms.Label();
            this.tbRegisterID = new System.Windows.Forms.TextBox();
            this.tbUserName = new System.Windows.Forms.TextBox();
            this.lblName = new System.Windows.Forms.Label();
            this.lblEditBookCategory = new System.Windows.Forms.Label();
            this.lblUserName = new System.Windows.Forms.Label();
            this.lblRegistrationId = new System.Windows.Forms.Label();
            this.lblMember = new System.Windows.Forms.Label();
            this.cbGender = new System.Windows.Forms.ComboBox();
            this.btSignup = new System.Windows.Forms.Button();
            this.DGMember = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.DGMember)).BeginInit();
            this.SuspendLayout();
            // 
            // tbPhone
            // 
            this.tbPhone.Location = new System.Drawing.Point(397, 194);
            this.tbPhone.Name = "tbPhone";
            this.tbPhone.Size = new System.Drawing.Size(161, 20);
            this.tbPhone.TabIndex = 125;
            // 
            // tbName
            // 
            this.tbName.Location = new System.Drawing.Point(397, 158);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(161, 20);
            this.tbName.TabIndex = 124;
            // 
            // tbPassword
            // 
            this.tbPassword.Location = new System.Drawing.Point(397, 122);
            this.tbPassword.Name = "tbPassword";
            this.tbPassword.Size = new System.Drawing.Size(161, 20);
            this.tbPassword.TabIndex = 123;
            // 
            // tbEmail
            // 
            this.tbEmail.Location = new System.Drawing.Point(397, 230);
            this.tbEmail.Name = "tbEmail";
            this.tbEmail.Size = new System.Drawing.Size(161, 20);
            this.tbEmail.TabIndex = 119;
            // 
            // lblGender
            // 
            this.lblGender.AutoSize = true;
            this.lblGender.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGender.Location = new System.Drawing.Point(242, 264);
            this.lblGender.Name = "lblGender";
            this.lblGender.Size = new System.Drawing.Size(69, 20);
            this.lblGender.TabIndex = 118;
            this.lblGender.Text = "Gender";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmail.Location = new System.Drawing.Point(242, 228);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(53, 20);
            this.lblEmail.TabIndex = 117;
            this.lblEmail.Text = "Email";
            // 
            // lblPhone
            // 
            this.lblPhone.AutoSize = true;
            this.lblPhone.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPhone.Location = new System.Drawing.Point(242, 192);
            this.lblPhone.Name = "lblPhone";
            this.lblPhone.Size = new System.Drawing.Size(60, 20);
            this.lblPhone.TabIndex = 116;
            this.lblPhone.Text = "Phone";
            // 
            // tbRegisterID
            // 
            this.tbRegisterID.Location = new System.Drawing.Point(397, 52);
            this.tbRegisterID.Name = "tbRegisterID";
            this.tbRegisterID.Size = new System.Drawing.Size(161, 20);
            this.tbRegisterID.TabIndex = 115;
            // 
            // tbUserName
            // 
            this.tbUserName.Location = new System.Drawing.Point(397, 86);
            this.tbUserName.Name = "tbUserName";
            this.tbUserName.Size = new System.Drawing.Size(161, 20);
            this.tbUserName.TabIndex = 114;
            this.tbUserName.TextChanged += new System.EventHandler(this.tbUserName_TextChanged);
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.Location = new System.Drawing.Point(242, 155);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(55, 20);
            this.lblName.TabIndex = 113;
            this.lblName.Text = "Name";
            // 
            // lblEditBookCategory
            // 
            this.lblEditBookCategory.AutoSize = true;
            this.lblEditBookCategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEditBookCategory.Location = new System.Drawing.Point(242, 119);
            this.lblEditBookCategory.Name = "lblEditBookCategory";
            this.lblEditBookCategory.Size = new System.Drawing.Size(86, 20);
            this.lblEditBookCategory.TabIndex = 112;
            this.lblEditBookCategory.Text = "Password";
            // 
            // lblUserName
            // 
            this.lblUserName.AutoSize = true;
            this.lblUserName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUserName.Location = new System.Drawing.Point(242, 83);
            this.lblUserName.Name = "lblUserName";
            this.lblUserName.Size = new System.Drawing.Size(93, 20);
            this.lblUserName.TabIndex = 111;
            this.lblUserName.Text = "UserName";
            // 
            // lblRegistrationId
            // 
            this.lblRegistrationId.AutoSize = true;
            this.lblRegistrationId.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRegistrationId.Location = new System.Drawing.Point(242, 50);
            this.lblRegistrationId.Name = "lblRegistrationId";
            this.lblRegistrationId.Size = new System.Drawing.Size(131, 20);
            this.lblRegistrationId.TabIndex = 110;
            this.lblRegistrationId.Text = "Registration ID";
            // 
            // lblMember
            // 
            this.lblMember.AutoSize = true;
            this.lblMember.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMember.Location = new System.Drawing.Point(365, 9);
            this.lblMember.Name = "lblMember";
            this.lblMember.Size = new System.Drawing.Size(137, 20);
            this.lblMember.TabIndex = 126;
            this.lblMember.Text = "Member SignUp";
            // 
            // cbGender
            // 
            this.cbGender.FormattingEnabled = true;
            this.cbGender.Items.AddRange(new object[] {
            "Female",
            "Male"});
            this.cbGender.Location = new System.Drawing.Point(397, 263);
            this.cbGender.Name = "cbGender";
            this.cbGender.Size = new System.Drawing.Size(161, 21);
            this.cbGender.TabIndex = 127;
            // 
            // btSignup
            // 
            this.btSignup.Location = new System.Drawing.Point(352, 320);
            this.btSignup.Name = "btSignup";
            this.btSignup.Size = new System.Drawing.Size(106, 23);
            this.btSignup.TabIndex = 128;
            this.btSignup.Text = "Register";
            this.btSignup.UseVisualStyleBackColor = true;
            this.btSignup.Click += new System.EventHandler(this.btSignup_Click);
            // 
            // DGMember
            // 
            this.DGMember.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGMember.Location = new System.Drawing.Point(27, 100);
            this.DGMember.Name = "DGMember";
            this.DGMember.Size = new System.Drawing.Size(192, 150);
            this.DGMember.TabIndex = 129;
            // 
            // MemberForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(801, 397);
            this.Controls.Add(this.DGMember);
            this.Controls.Add(this.btSignup);
            this.Controls.Add(this.cbGender);
            this.Controls.Add(this.lblMember);
            this.Controls.Add(this.tbPhone);
            this.Controls.Add(this.tbName);
            this.Controls.Add(this.tbPassword);
            this.Controls.Add(this.tbEmail);
            this.Controls.Add(this.lblGender);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.lblPhone);
            this.Controls.Add(this.tbRegisterID);
            this.Controls.Add(this.tbUserName);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.lblEditBookCategory);
            this.Controls.Add(this.lblUserName);
            this.Controls.Add(this.lblRegistrationId);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "MemberForm";
            this.Text = "MemberSignup";
            this.Load += new System.EventHandler(this.MemberForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DGMember)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbPhone;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.TextBox tbPassword;
        private System.Windows.Forms.TextBox tbEmail;
        public System.Windows.Forms.Label lblGender;
        public System.Windows.Forms.Label lblEmail;
        public System.Windows.Forms.Label lblPhone;
        private System.Windows.Forms.TextBox tbRegisterID;
        private System.Windows.Forms.TextBox tbUserName;
        public System.Windows.Forms.Label lblName;
        public System.Windows.Forms.Label lblEditBookCategory;
        public System.Windows.Forms.Label lblUserName;
        public System.Windows.Forms.Label lblRegistrationId;
        public System.Windows.Forms.Label lblMember;
        private System.Windows.Forms.ComboBox cbGender;
        private System.Windows.Forms.Button btSignup;
        private System.Windows.Forms.DataGridView DGMember;
    }
}