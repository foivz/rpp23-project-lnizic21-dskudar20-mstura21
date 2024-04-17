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
            int SelectedLibraryId = (int)cmbLibrary.SelectedValue;
            if (txtUsername.Text == "" || txtPassword.Text == "" || txtComPassword.Text == "")
            {
                if(txtUsername.Text != "" && txtPassword.Text != "" && txtComPassword.Text == "")
                {
                    MessageBox.Show("Confirm Password field is required!", "Registration failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    MessageBox.Show("Username and Password fields are required!", "Registration failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            else
            {
                Random random = new Random();
                Librarian user = new Librarian()
                {
                    idLibrarians = random.Next(0,999999999),
                    username = txtUsername.Text,
                    email = txtEmail.Text,
                    password = txtPassword.Text,
                    first_name = txtIme.Text,
                    last_name = txtPrezime.Text,
                    Library_idLibrary = SelectedLibraryId
                };

                AuthenticationService service = new AuthenticationService();
                try
                {
                    service.CreateUser(user);
                    MessageBox.Show("Registration succeeded!");

                    var frm = new frmLogin();
                    frm.Show();
                    frm.FormClosed += (arg, s) => this.Close(); // Close current form when frmIndex is closed
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
           var frm =  new frmLogin();
            frm.Show();
            frm.FormClosed += (arg, s) => this.Close(); // Close current form when frmIndex is closed
            this.Hide();
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
         
        private void frmRegister_Load(object sender, EventArgs e)
        {
            cmbLibrary.DisplayMember = "name";
            cmbLibrary.ValueMember = "idLibrary";
            
            AuthenticationService service = new AuthenticationService();
            cmbLibrary.DataSource = service.GetAllLibrariesForRegistration();
        }

        private void labelClose_Click(object sender, EventArgs e)
        {

            this.Close();
        }
    }
}
