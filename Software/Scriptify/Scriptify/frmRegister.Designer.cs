using static System.Net.Mime.MediaTypeNames;
using System.Drawing.Printing;
using System.Drawing;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Scriptify
{
    partial class frmRegister
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            txtUserame = new TextBox();
            txtPassword = new TextBox();
            label3 = new Label();
            txtComPassword = new TextBox();
            label4 = new Label();
            checkbxShowPass = new CheckBox();
            btnRegister = new Button();
            button1 = new Button();
            label5 = new Label();
            label6 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("MS UI Gothic", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.FromArgb(116, 86, 174);
            label1.Location = new Point(28, 68);
            label1.Name = "label1";
            label1.Size = new Size(194, 34);
            label1.TabIndex = 0;
            label1.Text = "Get Started";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(28, 120);
            label2.Name = "label2";
            label2.Size = new Size(89, 23);
            label2.TabIndex = 1;
            label2.Text = "Username";
            // 
            // txtUserame
            // 
            txtUserame.BackColor = Color.FromArgb(230, 231, 233);
            txtUserame.BorderStyle = BorderStyle.None;
            txtUserame.Font = new Font("MS UI Gothic", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            txtUserame.Location = new Point(28, 146);
            txtUserame.Multiline = true;
            txtUserame.Name = "txtUserame";
            txtUserame.Size = new Size(216, 28);
            txtUserame.TabIndex = 2;
            // 
            // txtPassword
            // 
            txtPassword.BackColor = Color.FromArgb(230, 231, 233);
            txtPassword.BorderStyle = BorderStyle.None;
            txtPassword.Font = new Font("MS UI Gothic", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            txtPassword.Location = new Point(28, 212);
            txtPassword.Multiline = true;
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '•';
            txtPassword.Size = new Size(216, 28);
            txtPassword.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(28, 186);
            label3.Name = "label3";
            label3.Size = new Size(84, 23);
            label3.TabIndex = 3;
            label3.Text = "Password";
            // 
            // txtComPassword
            // 
            txtComPassword.BackColor = Color.FromArgb(230, 231, 233);
            txtComPassword.BorderStyle = BorderStyle.None;
            txtComPassword.Font = new Font("MS UI Gothic", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            txtComPassword.Location = new Point(28, 285);
            txtComPassword.Multiline = true;
            txtComPassword.Name = "txtComPassword";
            txtComPassword.PasswordChar = '•';
            txtComPassword.Size = new Size(216, 28);
            txtComPassword.TabIndex = 6;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(28, 259);
            label4.Name = "label4";
            label4.Size = new Size(155, 23);
            label4.TabIndex = 5;
            label4.Text = "Confirm Password";
            // 
            // checkbxShowPass
            // 
            checkbxShowPass.AutoSize = true;
            checkbxShowPass.Cursor = Cursors.Hand;
            checkbxShowPass.FlatStyle = FlatStyle.Flat;
            checkbxShowPass.Location = new Point(93, 319);
            checkbxShowPass.Name = "checkbxShowPass";
            checkbxShowPass.Size = new Size(151, 27);
            checkbxShowPass.TabIndex = 7;
            checkbxShowPass.Text = "Show Password";
            checkbxShowPass.UseVisualStyleBackColor = true;
   
            // 
            // btnRegister
            // 
            btnRegister.BackColor = Color.FromArgb(116, 86, 174);
            btnRegister.Cursor = Cursors.Hand;
            btnRegister.FlatAppearance.BorderSize = 0;
            btnRegister.FlatStyle = FlatStyle.Flat;
            btnRegister.ForeColor = Color.White;
            btnRegister.Location = new Point(28, 352);
            btnRegister.Name = "btnRegister";
            btnRegister.Size = new Size(216, 35);
            btnRegister.TabIndex = 8;
            btnRegister.Text = "REGISTER";
            btnRegister.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            button1.BackColor = Color.White;
            button1.Cursor = Cursors.Hand;
            button1.FlatStyle = FlatStyle.Flat;
            button1.ForeColor = Color.FromArgb(116, 86, 174);
            button1.Location = new Point(28, 393);
            button1.Name = "button1";
            button1.Size = new Size(216, 35);
            button1.TabIndex = 9;
            button1.Text = "CLEAR";
            button1.UseVisualStyleBackColor = false;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(28, 449);
            label5.Name = "label5";
            label5.Size = new Size(214, 23);
            label5.TabIndex = 10;
            label5.Text = "Already Have An Account";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Cursor = Cursors.Hand;
            label6.ForeColor = Color.FromArgb(116, 86, 174);
            label6.Location = new Point(69, 481);
            label6.Name = "label6";
            label6.Size = new Size(126, 23);
            label6.TabIndex = 11;
            label6.Text = "Back to LOGIN";
            // 
            // frmRegister
            // 
            AutoScaleDimensions = new SizeF(10F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(278, 544);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(button1);
            Controls.Add(btnRegister);
            Controls.Add(checkbxShowPass);
            Controls.Add(txtComPassword);
            Controls.Add(label4);
            Controls.Add(txtPassword);
            Controls.Add(label3);
            Controls.Add(txtUserame);
            Controls.Add(label2);
            Controls.Add(label1);
            Font = new Font("Nirmala UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            ForeColor = Color.FromArgb(164, 165, 169);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4, 3, 4, 3);
            Name = "frmRegister";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmRegister";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox txtUserame;
        private TextBox txtPassword;
        private Label label3;
        private TextBox txtComPassword;
        private Label label4;
        private CheckBox checkbxShowPass;
        private Button btnRegister;
        private Button button1;
        private Label label5;
        private Label label6;
    }
}