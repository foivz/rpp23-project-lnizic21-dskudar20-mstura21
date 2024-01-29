namespace Scriptify
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
            this.cmbFiltering = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBookManagment)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(260, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(219, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Catalog of books";
            // 
            // dgvBookManagment
            // 
            this.dgvBookManagment.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBookManagment.Location = new System.Drawing.Point(3, 71);
            this.dgvBookManagment.Margin = new System.Windows.Forms.Padding(4);
            this.dgvBookManagment.Name = "dgvBookManagment";
            this.dgvBookManagment.RowHeadersWidth = 51;
            this.dgvBookManagment.Size = new System.Drawing.Size(756, 296);
            this.dgvBookManagment.TabIndex = 2;
            // 
            // btnAddBook
            // 
            this.btnAddBook.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnAddBook.Location = new System.Drawing.Point(430, 375);
            this.btnAddBook.Margin = new System.Windows.Forms.Padding(4);
            this.btnAddBook.Name = "btnAddBook";
            this.btnAddBook.Size = new System.Drawing.Size(100, 28);
            this.btnAddBook.TabIndex = 3;
            this.btnAddBook.Text = "Add";
            this.btnAddBook.UseVisualStyleBackColor = false;
            this.btnAddBook.Click += new System.EventHandler(this.btnAddBook_Click);
            // 
            // btnDeleteBook
            // 
            this.btnDeleteBook.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnDeleteBook.Location = new System.Drawing.Point(659, 375);
            this.btnDeleteBook.Margin = new System.Windows.Forms.Padding(4);
            this.btnDeleteBook.Name = "btnDeleteBook";
            this.btnDeleteBook.Size = new System.Drawing.Size(100, 28);
            this.btnDeleteBook.TabIndex = 4;
            this.btnDeleteBook.Text = "Delete";
            this.btnDeleteBook.UseVisualStyleBackColor = false;
            this.btnDeleteBook.Click += new System.EventHandler(this.btnDeleteBook_Click);
            // 
            // btnEditBook
            // 
            this.btnEditBook.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnEditBook.Location = new System.Drawing.Point(551, 375);
            this.btnEditBook.Margin = new System.Windows.Forms.Padding(4);
            this.btnEditBook.Name = "btnEditBook";
            this.btnEditBook.Size = new System.Drawing.Size(100, 28);
            this.btnEditBook.TabIndex = 5;
            this.btnEditBook.Text = "Edit";
            this.btnEditBook.UseVisualStyleBackColor = false;
            this.btnEditBook.Click += new System.EventHandler(this.btnEditBook_Click);
            // 
            // txtSearchBooks
            // 
            this.txtSearchBooks.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtSearchBooks.Location = new System.Drawing.Point(3, 42);
            this.txtSearchBooks.Name = "txtSearchBooks";
            this.txtSearchBooks.Size = new System.Drawing.Size(154, 22);
            this.txtSearchBooks.TabIndex = 6;
            this.txtSearchBooks.TextChanged += new System.EventHandler(this.txtSearchBooks_TextChanged);
            // 
            // cmbFiltering
            // 
            this.cmbFiltering.BackColor = System.Drawing.Color.White;
            this.cmbFiltering.FormattingEnabled = true;
            this.cmbFiltering.Location = new System.Drawing.Point(620, 42);
            this.cmbFiltering.Name = "cmbFiltering";
            this.cmbFiltering.Size = new System.Drawing.Size(139, 24);
            this.cmbFiltering.TabIndex = 7;
            this.cmbFiltering.SelectedIndexChanged += new System.EventHandler(this.cmbFiltering_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(547, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 20);
            this.label2.TabIndex = 8;
            this.label2.Text = "Sort by:";
            // 
            // UcCatalogOfBooks
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cmbFiltering);
            this.Controls.Add(this.txtSearchBooks);
            this.Controls.Add(this.btnEditBook);
            this.Controls.Add(this.btnDeleteBook);
            this.Controls.Add(this.btnAddBook);
            this.Controls.Add(this.dgvBookManagment);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "UcCatalogOfBooks";
            this.Size = new System.Drawing.Size(805, 526);
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
        private System.Windows.Forms.ComboBox cmbFiltering;
        private System.Windows.Forms.Label label2;
    }
}
