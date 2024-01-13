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
            this.dgvCatalogOfBooks = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCatalogOfBooks)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(293, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(219, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Catalog of books";
            // 
            // dgvCatalogOfBooks
            // 
            this.dgvCatalogOfBooks.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCatalogOfBooks.Location = new System.Drawing.Point(36, 52);
            this.dgvCatalogOfBooks.Name = "dgvCatalogOfBooks";
            this.dgvCatalogOfBooks.RowHeadersWidth = 51;
            this.dgvCatalogOfBooks.RowTemplate.Height = 24;
            this.dgvCatalogOfBooks.Size = new System.Drawing.Size(732, 352);
            this.dgvCatalogOfBooks.TabIndex = 1;
            // 
            // UcCatalogOfBooks
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dgvCatalogOfBooks);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Name = "UcCatalogOfBooks";
            this.Size = new System.Drawing.Size(806, 525);
            this.Load += new System.EventHandler(this.UcCatalogOfBooks_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCatalogOfBooks)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvCatalogOfBooks;
    }
}
