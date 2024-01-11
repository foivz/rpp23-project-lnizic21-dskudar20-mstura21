﻿using BusinessLogicLayer;
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
        private AuthenticationService _authenticationService;
        public frmLogin(AuthenticationService authenticationService)
        {
            InitializeComponent();
            _authenticationService = authenticationService;
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
      
            bool userIsExists = _authenticationService.AuthenticateUser(txtUserame.Text, txtPassword.Text);

            if (userIsExists)
            {
                //ulaz u aplikaciju
            }
            else
            {
                MessageBox.Show("Invalid Username od Password, Please Try Again", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtUserame.Text = "";
                txtPassword.Text = "";
                txtUserame.Focus();  
            }
           
        }

        private void labelCreateAccount_Click(object sender, EventArgs e)
        {
            new frmRegister().Show();
            this.Hide();
        }

        private void btnClearLoginForm_Click(object sender, EventArgs e)
        {
            txtUserame.Text = "";
            txtPassword.Text = "";
            txtUserame.Focus();
        }
    }
}
