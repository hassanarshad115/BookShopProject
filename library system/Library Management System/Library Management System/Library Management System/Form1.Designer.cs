namespace Library_Management_System
{
    partial class frmLoginPage
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
            this.label1 = new System.Windows.Forms.Label();
            this.lblUserName = new System.Windows.Forms.Label();
            this.lblPassword = new System.Windows.Forms.Label();
            this.tbLogin = new System.Windows.Forms.Button();
            this.btAboutUs = new System.Windows.Forms.Button();
            this.btMemberSignUP = new System.Windows.Forms.Button();
            this.btExit = new System.Windows.Forms.Button();
            this.tbUserName = new System.Windows.Forms.TextBox();
            this.tbPassword = new System.Windows.Forms.TextBox();
            this.cbRoleSelect = new System.Windows.Forms.ComboBox();
            this.dgUserName = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgUserName)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(123, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(148, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Welcome To LMS";
            // 
            // lblUserName
            // 
            this.lblUserName.AutoSize = true;
            this.lblUserName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUserName.Location = new System.Drawing.Point(28, 112);
            this.lblUserName.Name = "lblUserName";
            this.lblUserName.Size = new System.Drawing.Size(93, 20);
            this.lblUserName.TabIndex = 1;
            this.lblUserName.Text = "UserName";
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPassword.Location = new System.Drawing.Point(28, 146);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(86, 20);
            this.lblPassword.TabIndex = 2;
            this.lblPassword.Text = "Password";
            // 
            // tbLogin
            // 
            this.tbLogin.Location = new System.Drawing.Point(159, 264);
            this.tbLogin.Name = "tbLogin";
            this.tbLogin.Size = new System.Drawing.Size(75, 23);
            this.tbLogin.TabIndex = 3;
            this.tbLogin.Text = "Login";
            this.tbLogin.UseVisualStyleBackColor = true;
            this.tbLogin.Click += new System.EventHandler(this.tbLogin_Click);
            // 
            // btAboutUs
            // 
            this.btAboutUs.Location = new System.Drawing.Point(32, 264);
            this.btAboutUs.Name = "btAboutUs";
            this.btAboutUs.Size = new System.Drawing.Size(75, 23);
            this.btAboutUs.TabIndex = 4;
            this.btAboutUs.Text = "About Us";
            this.btAboutUs.UseVisualStyleBackColor = true;
            // 
            // btMemberSignUP
            // 
            this.btMemberSignUP.Location = new System.Drawing.Point(135, 321);
            this.btMemberSignUP.Name = "btMemberSignUP";
            this.btMemberSignUP.Size = new System.Drawing.Size(113, 23);
            this.btMemberSignUP.TabIndex = 5;
            this.btMemberSignUP.Text = "Member Signup";
            this.btMemberSignUP.UseVisualStyleBackColor = true;
            this.btMemberSignUP.Click += new System.EventHandler(this.btMemberSignUP_Click);
            // 
            // btExit
            // 
            this.btExit.Location = new System.Drawing.Point(286, 264);
            this.btExit.Name = "btExit";
            this.btExit.Size = new System.Drawing.Size(75, 23);
            this.btExit.TabIndex = 6;
            this.btExit.Text = "Exit";
            this.btExit.UseVisualStyleBackColor = true;
            // 
            // tbUserName
            // 
            this.tbUserName.Location = new System.Drawing.Point(200, 112);
            this.tbUserName.Name = "tbUserName";
            this.tbUserName.Size = new System.Drawing.Size(161, 20);
            this.tbUserName.TabIndex = 7;
            // 
            // tbPassword
            // 
            this.tbPassword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbPassword.Location = new System.Drawing.Point(200, 148);
            this.tbPassword.Name = "tbPassword";
            this.tbPassword.Size = new System.Drawing.Size(161, 20);
            this.tbPassword.TabIndex = 8;
            // 
            // cbRoleSelect
            // 
            this.cbRoleSelect.FormattingEnabled = true;
            this.cbRoleSelect.Items.AddRange(new object[] {
            "Admin",
            "Member"});
            this.cbRoleSelect.Location = new System.Drawing.Point(127, 72);
            this.cbRoleSelect.Name = "cbRoleSelect";
            this.cbRoleSelect.Size = new System.Drawing.Size(121, 21);
            this.cbRoleSelect.TabIndex = 9;
            // 
            // dgUserName
            // 
            this.dgUserName.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgUserName.Location = new System.Drawing.Point(169, 184);
            this.dgUserName.Name = "dgUserName";
            this.dgUserName.Size = new System.Drawing.Size(79, 51);
            this.dgUserName.TabIndex = 10;
            this.dgUserName.Visible = false;
            // 
            // frmLoginPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(403, 422);
            this.Controls.Add(this.dgUserName);
            this.Controls.Add(this.cbRoleSelect);
            this.Controls.Add(this.tbPassword);
            this.Controls.Add(this.tbUserName);
            this.Controls.Add(this.btExit);
            this.Controls.Add(this.btMemberSignUP);
            this.Controls.Add(this.btAboutUs);
            this.Controls.Add(this.tbLogin);
            this.Controls.Add(this.lblPassword);
            this.Controls.Add(this.lblUserName);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "frmLoginPage";
            this.Text = "Library Management System";
            this.Load += new System.EventHandler(this.frmLoginPage_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgUserName)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblUserName;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.Button tbLogin;
        private System.Windows.Forms.Button btAboutUs;
        private System.Windows.Forms.Button btMemberSignUP;
        private System.Windows.Forms.Button btExit;
        private System.Windows.Forms.TextBox tbUserName;
        private System.Windows.Forms.TextBox tbPassword;
        private System.Windows.Forms.ComboBox cbRoleSelect;
        private System.Windows.Forms.DataGridView dgUserName;
    }
}

