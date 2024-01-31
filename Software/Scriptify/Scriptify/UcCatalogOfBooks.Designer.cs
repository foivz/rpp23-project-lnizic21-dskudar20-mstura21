﻿namespace Scriptify
{
    partial class UcCatalogOfBooks
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.dgvBookManagment = new System.Windows.Forms.DataGridView();
            this.btnAddBook = new System.Windows.Forms.Button();
            this.btnDeleteBook = new System.Windows.Forms.Button();
            this.btnEditBook = new System.Windows.Forms.Button();
            this.txtSearchBooks = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbFiltering = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBookManagment)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(195, 0);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(175, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Catalog of books";
            // 
            // dgvBookManagment
            // 
            this.dgvBookManagment.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBookManagment.Location = new System.Drawing.Point(2, 58);
            this.dgvBookManagment.Name = "dgvBookManagment";
            this.dgvBookManagment.RowHeadersWidth = 51;
            this.dgvBookManagment.Size = new System.Drawing.Size(567, 240);
            this.dgvBookManagment.TabIndex = 2;
            // 
            // btnAddBook
            // 
            this.btnAddBook.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnAddBook.Location = new System.Drawing.Point(322, 305);
            this.btnAddBook.Name = "btnAddBook";
            this.btnAddBook.Size = new System.Drawing.Size(75, 23);
            this.btnAddBook.TabIndex = 3;
            this.btnAddBook.Text = "Add";
            this.btnAddBook.UseVisualStyleBackColor = false;
            this.btnAddBook.Click += new System.EventHandler(this.btnAddBook_Click);
            // 
            // btnDeleteBook
            // 
            this.btnDeleteBook.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnDeleteBook.Location = new System.Drawing.Point(494, 305);
            this.btnDeleteBook.Name = "btnDeleteBook";
            this.btnDeleteBook.Size = new System.Drawing.Size(75, 23);
            this.btnDeleteBook.TabIndex = 4;
            this.btnDeleteBook.Text = "Delete";
            this.btnDeleteBook.UseVisualStyleBackColor = false;
            this.btnDeleteBook.Click += new System.EventHandler(this.btnDeleteBook_Click);
            // 
            // btnEditBook
            // 
            this.btnEditBook.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnEditBook.Location = new System.Drawing.Point(413, 305);
            this.btnEditBook.Name = "btnEditBook";
            this.btnEditBook.Size = new System.Drawing.Size(75, 23);
            this.btnEditBook.TabIndex = 5;
            this.btnEditBook.Text = "Edit";
            this.btnEditBook.UseVisualStyleBackColor = false;
            this.btnEditBook.Click += new System.EventHandler(this.btnEditBook_Click);
            // 
            // txtSearchBooks
            // 
            this.txtSearchBooks.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtSearchBooks.Location = new System.Drawing.Point(2, 34);
            this.txtSearchBooks.Margin = new System.Windows.Forms.Padding(2);
            this.txtSearchBooks.Name = "txtSearchBooks";
            this.txtSearchBooks.Size = new System.Drawing.Size(116, 19);
            this.txtSearchBooks.TabIndex = 6;
            this.txtSearchBooks.TextChanged += new System.EventHandler(this.txtSearchBooks_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(410, 36);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 17);
            this.label2.TabIndex = 8;
            this.label2.Text = "Sort by:";
            // 
            // cmbFiltering
            // 
            this.cmbFiltering.BackColor = System.Drawing.Color.White;
            this.cmbFiltering.FormattingEnabled = true;
            this.cmbFiltering.Location = new System.Drawing.Point(465, 34);
            this.cmbFiltering.Margin = new System.Windows.Forms.Padding(2);
            this.cmbFiltering.Name = "cmbFiltering";
            this.cmbFiltering.Size = new System.Drawing.Size(105, 21);
            this.cmbFiltering.TabIndex = 7;
            this.cmbFiltering.SelectedIndexChanged += new System.EventHandler(this.cmbFiltering_SelectedIndexChanged);
            // 
            // UcCatalogOfBooks
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cmbFiltering);
            this.Controls.Add(this.txtSearchBooks);
            this.Controls.Add(this.btnEditBook);
            this.Controls.Add(this.btnDeleteBook);
            this.Controls.Add(this.btnAddBook);
            this.Controls.Add(this.dgvBookManagment);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "UcCatalogOfBooks";
            this.Size = new System.Drawing.Size(604, 427);
            this.Load += new System.EventHandler(this.UcCatalogOfBooks_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvBookManagment)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvBookManagment;
        private System.Windows.Forms.Button btnAddBook;
        private System.Windows.Forms.Button btnDeleteBook;
        private System.Windows.Forms.Button btnEditBook;
        private System.Windows.Forms.TextBox txtSearchBooks;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbFiltering;
    }
}
