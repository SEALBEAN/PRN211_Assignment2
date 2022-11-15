namespace SalesWinApp
{
    partial class frmMainMember
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
            this.txtCountry = new System.Windows.Forms.TextBox();
            this.txtCity = new System.Windows.Forms.TextBox();
            this.txtCompany = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.lbCountry = new System.Windows.Forms.Label();
            this.lbCity = new System.Windows.Forms.Label();
            this.lbCompany = new System.Windows.Forms.Label();
            this.lbEmail = new System.Windows.Forms.Label();
            this.lbInfo = new System.Windows.Forms.Label();
            this.lbWelcome = new System.Windows.Forms.Label();
            this.btnLogOut = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.lbPermission = new System.Windows.Forms.Label();
            this.btnViewOrderDetail = new System.Windows.Forms.Button();
            this.btnViewAndOrder = new System.Windows.Forms.Button();
            this.btnUpdateProfile = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtCountry
            // 
            this.txtCountry.Location = new System.Drawing.Point(166, 277);
            this.txtCountry.Name = "txtCountry";
            this.txtCountry.ReadOnly = true;
            this.txtCountry.Size = new System.Drawing.Size(165, 27);
            this.txtCountry.TabIndex = 19;
            // 
            // txtCity
            // 
            this.txtCity.Location = new System.Drawing.Point(166, 236);
            this.txtCity.Name = "txtCity";
            this.txtCity.ReadOnly = true;
            this.txtCity.Size = new System.Drawing.Size(165, 27);
            this.txtCity.TabIndex = 18;
            // 
            // txtCompany
            // 
            this.txtCompany.Location = new System.Drawing.Point(166, 195);
            this.txtCompany.Name = "txtCompany";
            this.txtCompany.ReadOnly = true;
            this.txtCompany.Size = new System.Drawing.Size(165, 27);
            this.txtCompany.TabIndex = 17;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(166, 153);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.ReadOnly = true;
            this.txtEmail.Size = new System.Drawing.Size(165, 27);
            this.txtEmail.TabIndex = 16;
            // 
            // lbCountry
            // 
            this.lbCountry.AutoSize = true;
            this.lbCountry.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbCountry.Location = new System.Drawing.Point(47, 273);
            this.lbCountry.Name = "lbCountry";
            this.lbCountry.Size = new System.Drawing.Size(86, 28);
            this.lbCountry.TabIndex = 15;
            this.lbCountry.Text = "Country:";
            // 
            // lbCity
            // 
            this.lbCity.AutoSize = true;
            this.lbCity.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbCity.Location = new System.Drawing.Point(47, 232);
            this.lbCity.Name = "lbCity";
            this.lbCity.Size = new System.Drawing.Size(50, 28);
            this.lbCity.TabIndex = 14;
            this.lbCity.Text = "City:";
            // 
            // lbCompany
            // 
            this.lbCompany.AutoSize = true;
            this.lbCompany.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbCompany.Location = new System.Drawing.Point(47, 191);
            this.lbCompany.Name = "lbCompany";
            this.lbCompany.Size = new System.Drawing.Size(100, 28);
            this.lbCompany.TabIndex = 13;
            this.lbCompany.Text = "Company:";
            // 
            // lbEmail
            // 
            this.lbEmail.AutoSize = true;
            this.lbEmail.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbEmail.Location = new System.Drawing.Point(47, 149);
            this.lbEmail.Name = "lbEmail";
            this.lbEmail.Size = new System.Drawing.Size(63, 28);
            this.lbEmail.TabIndex = 12;
            this.lbEmail.Text = "Email:";
            // 
            // lbInfo
            // 
            this.lbInfo.AutoSize = true;
            this.lbInfo.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbInfo.Location = new System.Drawing.Point(47, 102);
            this.lbInfo.Name = "lbInfo";
            this.lbInfo.Size = new System.Drawing.Size(129, 31);
            this.lbInfo.TabIndex = 11;
            this.lbInfo.Text = "Profile Info:";
            // 
            // lbWelcome
            // 
            this.lbWelcome.AutoSize = true;
            this.lbWelcome.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbWelcome.Location = new System.Drawing.Point(47, 47);
            this.lbWelcome.Name = "lbWelcome";
            this.lbWelcome.Size = new System.Drawing.Size(86, 38);
            this.lbWelcome.TabIndex = 10;
            this.lbWelcome.Text = "Hello";
            // 
            // btnLogOut
            // 
            this.btnLogOut.Location = new System.Drawing.Point(613, 366);
            this.btnLogOut.Name = "btnLogOut";
            this.btnLogOut.Size = new System.Drawing.Size(91, 33);
            this.btnLogOut.TabIndex = 21;
            this.btnLogOut.Text = "Log Out";
            this.btnLogOut.UseVisualStyleBackColor = true;
            this.btnLogOut.Click += new System.EventHandler(this.btnLogOut_Click);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(322, 366);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(113, 33);
            this.btnClose.TabIndex = 20;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // lbPermission
            // 
            this.lbPermission.AutoSize = true;
            this.lbPermission.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbPermission.Location = new System.Drawing.Point(464, 64);
            this.lbPermission.Name = "lbPermission";
            this.lbPermission.Size = new System.Drawing.Size(182, 31);
            this.lbPermission.TabIndex = 24;
            this.lbPermission.Text = "Your permission:";
            // 
            // btnViewOrderDetail
            // 
            this.btnViewOrderDetail.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnViewOrderDetail.Location = new System.Drawing.Point(464, 192);
            this.btnViewOrderDetail.Name = "btnViewOrderDetail";
            this.btnViewOrderDetail.Size = new System.Drawing.Size(240, 58);
            this.btnViewOrderDetail.TabIndex = 23;
            this.btnViewOrderDetail.Text = "View your Order Detail";
            this.btnViewOrderDetail.UseVisualStyleBackColor = true;
            // 
            // btnViewAndOrder
            // 
            this.btnViewAndOrder.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnViewAndOrder.Location = new System.Drawing.Point(464, 119);
            this.btnViewAndOrder.Name = "btnViewAndOrder";
            this.btnViewAndOrder.Size = new System.Drawing.Size(240, 58);
            this.btnViewAndOrder.TabIndex = 22;
            this.btnViewAndOrder.Text = "View and Order Product";
            this.btnViewAndOrder.UseVisualStyleBackColor = true;
            // 
            // btnUpdateProfile
            // 
            this.btnUpdateProfile.Location = new System.Drawing.Point(120, 326);
            this.btnUpdateProfile.Name = "btnUpdateProfile";
            this.btnUpdateProfile.Size = new System.Drawing.Size(134, 33);
            this.btnUpdateProfile.TabIndex = 25;
            this.btnUpdateProfile.Text = "Update Profile";
            this.btnUpdateProfile.UseVisualStyleBackColor = true;
            this.btnUpdateProfile.Click += new System.EventHandler(this.btnUpdateProfile_Click);
            // 
            // frmMainMember
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(780, 450);
            this.Controls.Add(this.btnUpdateProfile);
            this.Controls.Add(this.lbPermission);
            this.Controls.Add(this.btnViewOrderDetail);
            this.Controls.Add(this.btnViewAndOrder);
            this.Controls.Add(this.btnLogOut);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.txtCountry);
            this.Controls.Add(this.txtCity);
            this.Controls.Add(this.txtCompany);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.lbCountry);
            this.Controls.Add(this.lbCity);
            this.Controls.Add(this.lbCompany);
            this.Controls.Add(this.lbEmail);
            this.Controls.Add(this.lbInfo);
            this.Controls.Add(this.lbWelcome);
            this.Name = "frmMainMember";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Member Main Screen";
            this.Load += new System.EventHandler(this.frmMainMember_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox txtCountry;
        private TextBox txtCity;
        private TextBox txtCompany;
        private TextBox txtEmail;
        private Label lbCountry;
        private Label lbCity;
        private Label lbCompany;
        private Label lbEmail;
        private Label lbInfo;
        private Label lbWelcome;
        private Button btnLogOut;
        private Button btnClose;
        private Label lbPermission;
        private Button btnViewOrderDetail;
        private Button btnViewAndOrder;
        private Button btnUpdateProfile;
    }
}