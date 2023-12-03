using static System.Net.Mime.MediaTypeNames;
using System.Drawing.Printing;
using System.Windows.Forms;
using System.Xml.Linq;
using System.Drawing;
using System;

namespace Scriptify
{
    partial class frmLogin
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
            label6 = new Label();
            label5 = new Label();
            button1 = new Button();
            btnRegister = new Button();
            checkbxShowPass = new CheckBox();
            txtPassword = new TextBox();
            label3 = new Label();
            txtUserame = new TextBox();
            label2 = new Label();
            label1 = new Label();
            SuspendLayout();
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Cursor = Cursors.Hand;
            label6.ForeColor = Color.FromArgb(116, 86, 174);
            label6.Location = new Point(74, 432);
            label6.Name = "label6";
            label6.Size = new Size(132, 23);
            label6.TabIndex = 23;
            label6.Text = "Create Account";
            // label6.Click += label6_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Nirmala UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(48, 398);
            label5.Name = "label5";
            label5.Size = new Size(196, 23);
            label5.TabIndex = 22;
            label5.Text = "Don't Have An Account";
            // label5.Click += label5_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.White;
            button1.Cursor = Cursors.Hand;
            button1.FlatStyle = FlatStyle.Flat;
            button1.ForeColor = Color.FromArgb(116, 86, 174);
            button1.Location = new Point(28, 344);
            button1.Name = "button1";
            button1.Size = new Size(216, 35);
            button1.TabIndex = 21;
            button1.Text = "CLEAR";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // btnRegister
            // 
            btnRegister.BackColor = Color.FromArgb(116, 86, 174);
            btnRegister.Cursor = Cursors.Hand;
            btnRegister.FlatAppearance.BorderSize = 0;
            btnRegister.FlatStyle = FlatStyle.Flat;
            btnRegister.ForeColor = Color.White;
            btnRegister.Location = new Point(28, 294);
            btnRegister.Name = "btnRegister";
            btnRegister.Size = new Size(216, 35);
            btnRegister.TabIndex = 20;
            btnRegister.Text = "LOGIN";
            btnRegister.UseVisualStyleBackColor = false;
            btnRegister.Click += btnRegister_Click;
            // 
            // checkbxShowPass
            // 
            checkbxShowPass.AutoSize = true;
            checkbxShowPass.Cursor = Cursors.Hand;
            checkbxShowPass.FlatStyle = FlatStyle.Flat;
            checkbxShowPass.Location = new Point(93, 247);
            checkbxShowPass.Name = "checkbxShowPass";
            checkbxShowPass.Size = new Size(151, 27);
            checkbxShowPass.TabIndex = 19;
            checkbxShowPass.Text = "Show Password";
            checkbxShowPass.UseVisualStyleBackColor = true;
            checkbxShowPass.CheckedChanged += checkbxShowPass_CheckedChanged;
            // 
            // txtPassword
            // 
            txtPassword.BackColor = Color.FromArgb(230, 231, 233);
            txtPassword.BorderStyle = BorderStyle.None;
            txtPassword.Font = new Font("MS UI Gothic", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            txtPassword.Location = new Point(28, 213);
            txtPassword.Multiline = true;
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '•';
            txtPassword.Size = new Size(216, 28);
            txtPassword.TabIndex = 16;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(28, 187);
            label3.Name = "label3";
            label3.Size = new Size(84, 23);
            label3.TabIndex = 15;
            label3.Text = "Password";
            // 
            // txtUserame
            // 
            txtUserame.BackColor = Color.FromArgb(230, 231, 233);
            txtUserame.BorderStyle = BorderStyle.None;
            txtUserame.Font = new Font("MS UI Gothic", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            txtUserame.Location = new Point(28, 147);
            txtUserame.Multiline = true;
            txtUserame.Name = "txtUserame";
            txtUserame.Size = new Size(216, 28);
            txtUserame.TabIndex = 14;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(28, 121);
            label2.Name = "label2";
            label2.Size = new Size(89, 23);
            label2.TabIndex = 13;
            label2.Text = "Username";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("MS UI Gothic", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.FromArgb(116, 86, 174);
            label1.Location = new Point(28, 68);
            label1.Name = "label1";
            label1.Size = new Size(194, 34);
            label1.TabIndex = 12;
            label1.Text = "Get Started";
            // 
            // frmLogin
            // 
            AutoScaleDimensions = new SizeF(10F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(289, 489);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(button1);
            Controls.Add(btnRegister);
            Controls.Add(checkbxShowPass);
            Controls.Add(txtPassword);
            Controls.Add(label3);
            Controls.Add(txtUserame);
            Controls.Add(label2);
            Controls.Add(label1);
            Font = new Font("Nirmala UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            ForeColor = Color.FromArgb(164, 165, 169);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4, 3, 4, 3);
            Name = "frmLogin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmLogin";
            ResumeLayout(false);
            PerformLayout();
        }

        private void checkbxShowPass_CheckedChanged(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion

        private Label label6;
        private Label label5;
        private Button button1;
        private Button btnRegister;
        private CheckBox checkbxShowPass;
        private TextBox txtPassword;
        private Label label3;
        private TextBox txtUserame;
        private Label label2;
        private Label label1;
    }
}