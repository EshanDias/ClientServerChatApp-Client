namespace ChatApp_Client
{
    partial class Login
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
            this.btn_login = new System.Windows.Forms.Button();
            this.btn_signUp = new System.Windows.Forms.Button();
            this.lbl_username = new System.Windows.Forms.Label();
            this.lbl_password = new System.Windows.Forms.Label();
            this.tb_usernameLogin = new System.Windows.Forms.TextBox();
            this.tb_passwordLogin = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.tb_firstName = new System.Windows.Forms.TextBox();
            this.tb_lastName = new System.Windows.Forms.TextBox();
            this.tb_email = new System.Windows.Forms.TextBox();
            this.tb_usernameSignUp = new System.Windows.Forms.TextBox();
            this.tb_passwordSignUp = new System.Windows.Forms.TextBox();
            this.tb_confirmPassword = new System.Windows.Forms.TextBox();
            this.lbl_firstName = new System.Windows.Forms.Label();
            this.lbl_lastName = new System.Windows.Forms.Label();
            this.lbl_email = new System.Windows.Forms.Label();
            this.lbl_usernameSignUp = new System.Windows.Forms.Label();
            this.lbl_passwordSignUp = new System.Windows.Forms.Label();
            this.lbl_confirmPassword = new System.Windows.Forms.Label();
            this.lbl_error = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_login
            // 
            this.btn_login.Location = new System.Drawing.Point(519, 25);
            this.btn_login.Name = "btn_login";
            this.btn_login.Size = new System.Drawing.Size(75, 23);
            this.btn_login.TabIndex = 0;
            this.btn_login.Text = "Login";
            this.btn_login.UseVisualStyleBackColor = true;
            this.btn_login.Click += new System.EventHandler(this.btn_login_Click);
            // 
            // btn_signUp
            // 
            this.btn_signUp.Location = new System.Drawing.Point(244, 245);
            this.btn_signUp.Name = "btn_signUp";
            this.btn_signUp.Size = new System.Drawing.Size(75, 23);
            this.btn_signUp.TabIndex = 1;
            this.btn_signUp.Text = "Sign Up";
            this.btn_signUp.UseVisualStyleBackColor = true;
            this.btn_signUp.Click += new System.EventHandler(this.btn_signUp_Click);
            // 
            // lbl_username
            // 
            this.lbl_username.AutoSize = true;
            this.lbl_username.Location = new System.Drawing.Point(10, 31);
            this.lbl_username.Name = "lbl_username";
            this.lbl_username.Size = new System.Drawing.Size(64, 13);
            this.lbl_username.TabIndex = 2;
            this.lbl_username.Text = "Username : ";
            // 
            // lbl_password
            // 
            this.lbl_password.AutoSize = true;
            this.lbl_password.Location = new System.Drawing.Point(269, 31);
            this.lbl_password.Name = "lbl_password";
            this.lbl_password.Size = new System.Drawing.Size(62, 13);
            this.lbl_password.TabIndex = 3;
            this.lbl_password.Text = "Password : ";
            // 
            // tb_usernameLogin
            // 
            this.tb_usernameLogin.Location = new System.Drawing.Point(82, 28);
            this.tb_usernameLogin.Name = "tb_usernameLogin";
            this.tb_usernameLogin.Size = new System.Drawing.Size(168, 20);
            this.tb_usernameLogin.TabIndex = 4;
            // 
            // tb_passwordLogin
            // 
            this.tb_passwordLogin.Location = new System.Drawing.Point(331, 28);
            this.tb_passwordLogin.Name = "tb_passwordLogin";
            this.tb_passwordLogin.Size = new System.Drawing.Size(168, 20);
            this.tb_passwordLogin.TabIndex = 5;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btn_login);
            this.groupBox1.Controls.Add(this.tb_passwordLogin);
            this.groupBox1.Controls.Add(this.lbl_username);
            this.groupBox1.Controls.Add(this.tb_usernameLogin);
            this.groupBox1.Controls.Add(this.lbl_password);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(600, 65);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Login";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lbl_error);
            this.groupBox2.Controls.Add(this.lbl_confirmPassword);
            this.groupBox2.Controls.Add(this.lbl_passwordSignUp);
            this.groupBox2.Controls.Add(this.lbl_usernameSignUp);
            this.groupBox2.Controls.Add(this.lbl_email);
            this.groupBox2.Controls.Add(this.lbl_lastName);
            this.groupBox2.Controls.Add(this.lbl_firstName);
            this.groupBox2.Controls.Add(this.tb_confirmPassword);
            this.groupBox2.Controls.Add(this.tb_passwordSignUp);
            this.groupBox2.Controls.Add(this.tb_usernameSignUp);
            this.groupBox2.Controls.Add(this.tb_email);
            this.groupBox2.Controls.Add(this.tb_lastName);
            this.groupBox2.Controls.Add(this.tb_firstName);
            this.groupBox2.Controls.Add(this.btn_signUp);
            this.groupBox2.Location = new System.Drawing.Point(12, 83);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(600, 304);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Register";
            // 
            // tb_firstName
            // 
            this.tb_firstName.Location = new System.Drawing.Point(272, 46);
            this.tb_firstName.Name = "tb_firstName";
            this.tb_firstName.Size = new System.Drawing.Size(168, 20);
            this.tb_firstName.TabIndex = 6;
            // 
            // tb_lastName
            // 
            this.tb_lastName.Location = new System.Drawing.Point(272, 72);
            this.tb_lastName.Name = "tb_lastName";
            this.tb_lastName.Size = new System.Drawing.Size(168, 20);
            this.tb_lastName.TabIndex = 7;
            // 
            // tb_email
            // 
            this.tb_email.Location = new System.Drawing.Point(272, 98);
            this.tb_email.Name = "tb_email";
            this.tb_email.Size = new System.Drawing.Size(168, 20);
            this.tb_email.TabIndex = 8;
            // 
            // tb_usernameSignUp
            // 
            this.tb_usernameSignUp.Location = new System.Drawing.Point(272, 124);
            this.tb_usernameSignUp.Name = "tb_usernameSignUp";
            this.tb_usernameSignUp.Size = new System.Drawing.Size(168, 20);
            this.tb_usernameSignUp.TabIndex = 9;
            // 
            // tb_passwordSignUp
            // 
            this.tb_passwordSignUp.Location = new System.Drawing.Point(272, 150);
            this.tb_passwordSignUp.Name = "tb_passwordSignUp";
            this.tb_passwordSignUp.Size = new System.Drawing.Size(168, 20);
            this.tb_passwordSignUp.TabIndex = 10;
            // 
            // tb_confirmPassword
            // 
            this.tb_confirmPassword.Location = new System.Drawing.Point(272, 176);
            this.tb_confirmPassword.Name = "tb_confirmPassword";
            this.tb_confirmPassword.Size = new System.Drawing.Size(168, 20);
            this.tb_confirmPassword.TabIndex = 11;
            // 
            // lbl_firstName
            // 
            this.lbl_firstName.AutoSize = true;
            this.lbl_firstName.Location = new System.Drawing.Point(162, 49);
            this.lbl_firstName.Name = "lbl_firstName";
            this.lbl_firstName.Size = new System.Drawing.Size(57, 13);
            this.lbl_firstName.TabIndex = 12;
            this.lbl_firstName.Text = "First Name";
            // 
            // lbl_lastName
            // 
            this.lbl_lastName.AutoSize = true;
            this.lbl_lastName.Location = new System.Drawing.Point(162, 75);
            this.lbl_lastName.Name = "lbl_lastName";
            this.lbl_lastName.Size = new System.Drawing.Size(58, 13);
            this.lbl_lastName.TabIndex = 13;
            this.lbl_lastName.Text = "Last Name";
            // 
            // lbl_email
            // 
            this.lbl_email.AutoSize = true;
            this.lbl_email.Location = new System.Drawing.Point(162, 105);
            this.lbl_email.Name = "lbl_email";
            this.lbl_email.Size = new System.Drawing.Size(42, 13);
            this.lbl_email.TabIndex = 14;
            this.lbl_email.Text = "E - Mail";
            // 
            // lbl_usernameSignUp
            // 
            this.lbl_usernameSignUp.AutoSize = true;
            this.lbl_usernameSignUp.Location = new System.Drawing.Point(162, 127);
            this.lbl_usernameSignUp.Name = "lbl_usernameSignUp";
            this.lbl_usernameSignUp.Size = new System.Drawing.Size(55, 13);
            this.lbl_usernameSignUp.TabIndex = 15;
            this.lbl_usernameSignUp.Text = "Username";
            // 
            // lbl_passwordSignUp
            // 
            this.lbl_passwordSignUp.AutoSize = true;
            this.lbl_passwordSignUp.Location = new System.Drawing.Point(162, 153);
            this.lbl_passwordSignUp.Name = "lbl_passwordSignUp";
            this.lbl_passwordSignUp.Size = new System.Drawing.Size(53, 13);
            this.lbl_passwordSignUp.TabIndex = 16;
            this.lbl_passwordSignUp.Text = "Password";
            // 
            // lbl_confirmPassword
            // 
            this.lbl_confirmPassword.AutoSize = true;
            this.lbl_confirmPassword.Location = new System.Drawing.Point(162, 179);
            this.lbl_confirmPassword.Name = "lbl_confirmPassword";
            this.lbl_confirmPassword.Size = new System.Drawing.Size(91, 13);
            this.lbl_confirmPassword.TabIndex = 17;
            this.lbl_confirmPassword.Text = "Confirm Password";
            // 
            // lbl_error
            // 
            this.lbl_error.AutoSize = true;
            this.lbl_error.ForeColor = System.Drawing.Color.Red;
            this.lbl_error.Location = new System.Drawing.Point(56, 209);
            this.lbl_error.MinimumSize = new System.Drawing.Size(500, 30);
            this.lbl_error.Name = "lbl_error";
            this.lbl_error.Size = new System.Drawing.Size(500, 30);
            this.lbl_error.TabIndex = 18;
            this.lbl_error.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(628, 399);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Login";
            this.Text = "Login";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_login;
        private System.Windows.Forms.Button btn_signUp;
        private System.Windows.Forms.Label lbl_username;
        private System.Windows.Forms.Label lbl_password;
        private System.Windows.Forms.TextBox tb_usernameLogin;
        private System.Windows.Forms.TextBox tb_passwordLogin;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lbl_confirmPassword;
        private System.Windows.Forms.Label lbl_passwordSignUp;
        private System.Windows.Forms.Label lbl_usernameSignUp;
        private System.Windows.Forms.Label lbl_email;
        private System.Windows.Forms.Label lbl_lastName;
        private System.Windows.Forms.Label lbl_firstName;
        private System.Windows.Forms.TextBox tb_confirmPassword;
        private System.Windows.Forms.TextBox tb_passwordSignUp;
        private System.Windows.Forms.TextBox tb_usernameSignUp;
        private System.Windows.Forms.TextBox tb_email;
        private System.Windows.Forms.TextBox tb_lastName;
        private System.Windows.Forms.TextBox tb_firstName;
        private System.Windows.Forms.Label lbl_error;
    }
}