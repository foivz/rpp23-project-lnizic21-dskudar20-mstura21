using BusinessLogicLayer;
using EntityLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Scriptify
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {

        }


        private void checkbxShowPass_CheckedChanged_1(object sender, EventArgs e)
        {
            if (checkbxShowPass.Checked)
            {
                txtPassword.PasswordChar = '\0';

            } else
            {
                txtPassword.PasswordChar = '•';

            }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            AuthenticationService _authenticationService = new AuthenticationService();

            if (txtUsername.Text == "" || txtPassword.Text == "")
            {
                MessageBox.Show("Username and Password fields are required!", "Login failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtUsername.Focus();
            }
            else

            {
                bool userIsExists = _authenticationService.AuthenticateUser(txtUsername.Text, txtPassword.Text);

                if (userIsExists)
                {
                    Librarian user = _authenticationService.GetUser(txtUsername.Text, txtPassword.Text);
                    frmIndex frm = new frmIndex(user);
                    this.Hide();
                    frm.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Invalid Username or Password, Please Try Again", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtUsername.Text = "";
                    txtPassword.Text = "";
                    txtUsername.Focus();
                }
            
            }


        }
        private void labelCreateAccount_Click(object sender, EventArgs e)
        {
            new frmRegister().Show(); 
            this.Hide();
        }

        private void btnClearLoginForm_Click(object sender, EventArgs e)
        {
            txtUsername.Text = "";
            txtPassword.Text = "";
            txtUsername.Focus();
        }

        private void labelClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
