﻿namespace Scriptify
{
    partial class frmIndex
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
            this.label1 = new System.Windows.Forms.Label();
            this.panelControls = new System.Windows.Forms.Panel();
            this.btnLoans = new System.Windows.Forms.Button();
            this.btnCatalogOfBooks = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.ForeColor = System.Drawing.Color.Purple;
            this.label1.Location = new System.Drawing.Point(392, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(322, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Welcome to Scriptify App";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // panelControls
            // 
            this.panelControls.Location = new System.Drawing.Point(228, 61);
            this.panelControls.Name = "panelControls";
            this.panelControls.Size = new System.Drawing.Size(806, 525);
            this.panelControls.TabIndex = 1;
            // 
            // btnLoans
            // 
            this.btnLoans.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnLoans.Location = new System.Drawing.Point(12, 91);
            this.btnLoans.Name = "btnLoans";
            this.btnLoans.Size = new System.Drawing.Size(189, 36);
            this.btnLoans.TabIndex = 2;
            this.btnLoans.Text = "Loans";
            this.btnLoans.UseVisualStyleBackColor = true;
            this.btnLoans.Click += new System.EventHandler(this.btnLoans_Click);
            // 
            // btnCatalogOfBooks
            // 
            this.btnCatalogOfBooks.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnCatalogOfBooks.Location = new System.Drawing.Point(12, 133);
            this.btnCatalogOfBooks.Name = "btnCatalogOfBooks";
            this.btnCatalogOfBooks.Size = new System.Drawing.Size(189, 37);
            this.btnCatalogOfBooks.TabIndex = 3;
            this.btnCatalogOfBooks.Text = "Catalog of books";
            this.btnCatalogOfBooks.UseVisualStyleBackColor = true;
            this.btnCatalogOfBooks.Click += new System.EventHandler(this.btnCatalogOfBooks_Click);
            // 
            // frmIndex
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(15F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1074, 623);
            this.Controls.Add(this.btnCatalogOfBooks);
            this.Controls.Add(this.btnLoans);
            this.Controls.Add(this.panelControls);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.Name = "frmIndex";
            this.Text = "Scriptify";
            this.Load += new System.EventHandler(this.frmIndex_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panelControls;
        private System.Windows.Forms.Button btnLoans;
        private System.Windows.Forms.Button btnCatalogOfBooks;
    }
}