using BusinessLogicLayer;
using DataAccessLayer.Iznimke;
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
    public partial class frmRegister : Form
    {
        public frmRegister()
        {
            InitializeComponent();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            
            if (txtUsername.Text == "" || txtPassword.Text == "" || txtComPassword.Text == "")
            {
                if(txtUsername.Text != "" && txtPassword.Text != "" && txtComPassword.Text == "")
                {
                    MessageBox.Show("Confirm Password field is required", "Registration failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    MessageBox.Show("Username and Password fields are required", "Registration failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            else
            {
                User user = new User()
                {
                    username = txtUsername.Text,
                    email = txtEmail.Text,
                    password = txtPassword.Text,
                    create_time = DateTime.Now,
                    First_Name = txtIme.Text,
                    Last_Name = txtPrezime.Text,
                };

                AuthenticationService service = new AuthenticationService();
                try
                {
                    service.CreateUser(user);
                    MessageBox.Show("Registration succeeded!");

                    new frmLogin().Show();
                    this.Hide();
                }
                catch (RegistrationException ex)
                {
                    MessageBox.Show(ex.Message);
                }
                
            }

        }

        private void checkbxShowPass_CheckedChanged(object sender, EventArgs e)
        {
            if (checkbxShowPass.Checked)
            {
                txtPassword.PasswordChar = '\0';
                txtComPassword.PasswordChar = '\0';

            } else
            {
                txtPassword.PasswordChar = '•';
                txtComPassword.PasswordChar = '•';

            }
        }
        private void btnClear_Click(object sender, EventArgs e)
        {
            txtUsername.Text = "";
            txtPassword.Text = "";
            txtComPassword.Text = "";
            txtIme.Text = "";
            txtPrezime.Text = "";
            txtEmail.Text = "";
            txtUsername.Focus();
        }
        private void labelBackToLogin_Click(object sender, EventArgs e)
        {
            new frmLogin().Show();
            this.Hide();
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void frmRegister_Load(object sender, EventArgs e)
        {

        }

        private void labelClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
