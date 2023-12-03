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
            if (txtUserame.Text == "" && txtPassword.Text == "" && txtComPassword.Text == "")
            {
                MessageBox.Show("username and Password field are empty", "Registration failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }else
            {
                MessageBox.Show("Password does not math, Please re-enter", "Registration Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtUserame.Text = "";
                txtPassword.Text = "";
                txtComPassword.Text = "";
                txtIme.Text = "";
                txtPrezime.Text = "";
                txtEmail.Text = "";
                txtPassword.Focus();
            }

            }

        private void button1_Click(object sender, EventArgs e)
        {
            txtUserame.Text = "";
            txtPassword.Text = "";
            txtComPassword.Text = "";
            txtIme.Text = "";
            txtPrezime.Text = "";
            txtEmail.Text = "";
            txtUserame.Focus();

        }

        private void label6_Click(object sender, EventArgs e)
        {
            new frmLogin().Show();
            this.Hide();
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

   

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
