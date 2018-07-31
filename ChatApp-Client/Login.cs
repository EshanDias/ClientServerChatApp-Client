using DataAccess;
using Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChatApp_Client
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void btn_signUp_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(tb_firstName.Text.Trim()) || String.IsNullOrEmpty(tb_lastName.Text.Trim()) ||
                String.IsNullOrEmpty(tb_email.Text.Trim()) || String.IsNullOrEmpty(tb_usernameSignUp.Text.Trim()) ||
                String.IsNullOrEmpty(tb_passwordSignUp.Text.Trim()) || String.IsNullOrEmpty(tb_confirmPassword.Text.Trim()))
            {
                lbl_error.Text = "Please fill all the fields";
            }
            else
            {
                if (!String.Equals(tb_passwordSignUp.Text.Trim(), tb_confirmPassword.Text.Trim()))
                {
                    lbl_error.Text = "Password does not match!";
                }
                else
                {
                    User user = new User();
                    user.FirstName = tb_firstName.Text.Trim();
                    user.LastName = tb_lastName.Text.Trim();
                    user.Email = tb_email.Text.Trim();
                    user.Username = tb_usernameSignUp.Text.Trim();
                    user.Password = tb_passwordSignUp.Text.Trim();

                    DatabaseHelper db = new DatabaseHelper();
                    lbl_error.ForeColor = Color.Green;
                    lbl_error.Text = db.InsertUser(user) ? "Sign Up Successfull! \n Please use Username & Password to login" : "Error occured while signup";

                }
            }
        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(tb_usernameLogin.Text.Trim()) || String.IsNullOrEmpty(tb_passwordLogin.Text.Trim()))
            {
                MessageBox.Show("Please enter login username and password");
            }
            else
            {
                bool isLoginValid = false;
                DatabaseHelper db = new DatabaseHelper();
                isLoginValid = db.ValidateLogin(tb_usernameLogin.Text.Trim(), tb_passwordLogin.Text.Trim());

                if (!isLoginValid)
                {
                    MessageBox.Show("Username / Password is incorrect!");
                }
                else
                {
                    this.Hide();
                    Form1 form = new Form1();
                    form.ShowDialog();
                    this.Close();
                }
            }
        }
    }
}
