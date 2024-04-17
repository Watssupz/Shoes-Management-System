namespace project
{
    partial class Profile
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
            lbUsername = new Label();
            lbEmail = new Label();
            lbFullname = new Label();
            lbAddress = new Label();
            lbProfile = new Label();
            txtUsername = new TextBox();
            txtEmail = new TextBox();
            txtFullname = new TextBox();
            txtAddress = new TextBox();
            btnSaveChange = new Button();
            btnClose = new Button();
            SuspendLayout();
            // 
            // lbUsername
            // 
            lbUsername.AutoSize = true;
            lbUsername.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            lbUsername.Location = new Point(78, 84);
            lbUsername.Name = "lbUsername";
            lbUsername.Size = new Size(97, 25);
            lbUsername.TabIndex = 0;
            lbUsername.Text = "Username";
            // 
            // lbEmail
            // 
            lbEmail.AutoSize = true;
            lbEmail.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            lbEmail.Location = new Point(78, 149);
            lbEmail.Name = "lbEmail";
            lbEmail.Size = new Size(58, 25);
            lbEmail.TabIndex = 1;
            lbEmail.Text = "Email";
            // 
            // lbFullname
            // 
            lbFullname.AutoSize = true;
            lbFullname.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            lbFullname.Location = new Point(78, 213);
            lbFullname.Name = "lbFullname";
            lbFullname.Size = new Size(89, 25);
            lbFullname.TabIndex = 2;
            lbFullname.Text = "Fullname";
            // 
            // lbAddress
            // 
            lbAddress.AutoSize = true;
            lbAddress.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            lbAddress.Location = new Point(78, 279);
            lbAddress.Name = "lbAddress";
            lbAddress.Size = new Size(79, 25);
            lbAddress.TabIndex = 3;
            lbAddress.Text = "Address";
            // 
            // lbProfile
            // 
            lbProfile.AutoSize = true;
            lbProfile.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            lbProfile.Location = new Point(267, 9);
            lbProfile.Name = "lbProfile";
            lbProfile.Size = new Size(72, 30);
            lbProfile.TabIndex = 6;
            lbProfile.Text = "Profile";
            // 
            // txtUsername
            // 
            txtUsername.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtUsername.Location = new Point(237, 81);
            txtUsername.Name = "txtUsername";
            txtUsername.ReadOnly = true;
            txtUsername.Size = new Size(330, 33);
            txtUsername.TabIndex = 7;
            txtUsername.TabStop = false;
            // 
            // txtEmail
            // 
            txtEmail.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtEmail.Location = new Point(237, 146);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(330, 33);
            txtEmail.TabIndex = 8;
            txtEmail.TabStop = false;
            txtEmail.TextChanged += txtEmail_TextChanged;
            // 
            // txtFullname
            // 
            txtFullname.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtFullname.Location = new Point(237, 210);
            txtFullname.Name = "txtFullname";
            txtFullname.Size = new Size(330, 33);
            txtFullname.TabIndex = 9;
            txtFullname.TabStop = false;
            txtFullname.TextChanged += txtFullname_TextChanged;
            // 
            // txtAddress
            // 
            txtAddress.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtAddress.Location = new Point(237, 271);
            txtAddress.Name = "txtAddress";
            txtAddress.Size = new Size(330, 33);
            txtAddress.TabIndex = 10;
            txtAddress.TabStop = false;
            txtAddress.TextChanged += txtAddress_TextChanged;
            // 
            // btnSaveChange
            // 
            btnSaveChange.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnSaveChange.Location = new Point(148, 336);
            btnSaveChange.Name = "btnSaveChange";
            btnSaveChange.Size = new Size(132, 41);
            btnSaveChange.TabIndex = 12;
            btnSaveChange.Text = "Save Change";
            btnSaveChange.UseVisualStyleBackColor = true;
            btnSaveChange.Click += btnSaveChange_Click;
            // 
            // btnClose
            // 
            btnClose.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnClose.Location = new Point(338, 336);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(132, 41);
            btnClose.TabIndex = 13;
            btnClose.Text = "Close";
            btnClose.UseVisualStyleBackColor = true;
            // 
            // Profile
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(626, 403);
            Controls.Add(btnClose);
            Controls.Add(btnSaveChange);
            Controls.Add(txtAddress);
            Controls.Add(txtFullname);
            Controls.Add(txtEmail);
            Controls.Add(txtUsername);
            Controls.Add(lbProfile);
            Controls.Add(lbAddress);
            Controls.Add(lbFullname);
            Controls.Add(lbEmail);
            Controls.Add(lbUsername);
            Name = "Profile";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Profile";
            Load += Profile_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbUsername;
        private Label lbEmail;
        private Label lbFullname;
        private Label lbAddress;
        private Label lbProfile;
        private TextBox txtUsername;
        private TextBox txtEmail;
        private TextBox txtFullname;
        private TextBox txtAddress;
        private Button btnSaveChange;
        private Button btnClose;
    }
}