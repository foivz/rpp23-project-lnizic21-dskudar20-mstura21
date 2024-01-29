namespace Scriptify
{
    partial class UcReportsAndStatistics
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
            this.dgvStatistics = new System.Windows.Forms.DataGridView();
            this.labelTopBooks = new System.Windows.Forms.Label();
            this.labelTopUsers = new System.Windows.Forms.Label();
            this.dgvTopUsers = new System.Windows.Forms.DataGridView();
            this.btnTopBooks = new System.Windows.Forms.Button();
            this.btnTopUsers = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStatistics)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTopUsers)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(267, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(278, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Reports and statistics";
            // 
            // dgvStatistics
            // 
            this.dgvStatistics.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvStatistics.Location = new System.Drawing.Point(21, 119);
            this.dgvStatistics.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvStatistics.Name = "dgvStatistics";
            this.dgvStatistics.RowHeadersWidth = 51;
            this.dgvStatistics.RowTemplate.Height = 24;
            this.dgvStatistics.Size = new System.Drawing.Size(540, 149);
            this.dgvStatistics.TabIndex = 1;
            // 
            // labelTopBooks
            // 
            this.labelTopBooks.AutoSize = true;
            this.labelTopBooks.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelTopBooks.Location = new System.Drawing.Point(16, 91);
            this.labelTopBooks.Name = "labelTopBooks";
            this.labelTopBooks.Size = new System.Drawing.Size(144, 25);
            this.labelTopBooks.TabIndex = 2;
            this.labelTopBooks.Text = "Top 10 books";
            // 
            // labelTopUsers
            // 
            this.labelTopUsers.AutoSize = true;
            this.labelTopUsers.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelTopUsers.Location = new System.Drawing.Point(21, 91);
            this.labelTopUsers.Name = "labelTopUsers";
            this.labelTopUsers.Size = new System.Drawing.Size(139, 25);
            this.labelTopUsers.TabIndex = 3;
            this.labelTopUsers.Text = "Top 10 users";
            // 
            // dgvTopUsers
            // 
            this.dgvTopUsers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTopUsers.Location = new System.Drawing.Point(21, 117);
            this.dgvTopUsers.Name = "dgvTopUsers";
            this.dgvTopUsers.RowHeadersWidth = 51;
            this.dgvTopUsers.RowTemplate.Height = 24;
            this.dgvTopUsers.Size = new System.Drawing.Size(540, 151);
            this.dgvTopUsers.TabIndex = 4;
            // 
            // btnTopBooks
            // 
            this.btnTopBooks.FlatAppearance.BorderSize = 2;
            this.btnTopBooks.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnTopBooks.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTopBooks.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnTopBooks.Location = new System.Drawing.Point(26, 48);
            this.btnTopBooks.Name = "btnTopBooks";
            this.btnTopBooks.Size = new System.Drawing.Size(123, 30);
            this.btnTopBooks.TabIndex = 5;
            this.btnTopBooks.Text = "Top 10 books";
            this.btnTopBooks.UseVisualStyleBackColor = true;
            this.btnTopBooks.Click += new System.EventHandler(this.btnTopBooks_Click);
            // 
            // btnTopUsers
            // 
            this.btnTopUsers.FlatAppearance.BorderSize = 2;
            this.btnTopUsers.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnTopUsers.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTopUsers.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnTopUsers.Location = new System.Drawing.Point(166, 48);
            this.btnTopUsers.Name = "btnTopUsers";
            this.btnTopUsers.Size = new System.Drawing.Size(122, 30);
            this.btnTopUsers.TabIndex = 6;
            this.btnTopUsers.Text = "Top 10 users";
            this.btnTopUsers.UseVisualStyleBackColor = true;
            this.btnTopUsers.Click += new System.EventHandler(this.btnTopUsers_Click);
            // 
            // UcReportsAndStatistics
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnTopUsers);
            this.Controls.Add(this.btnTopBooks);
            this.Controls.Add(this.dgvTopUsers);
            this.Controls.Add(this.labelTopUsers);
            this.Controls.Add(this.labelTopBooks);
            this.Controls.Add(this.dgvStatistics);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "UcReportsAndStatistics";
            this.Size = new System.Drawing.Size(833, 520);
            this.Load += new System.EventHandler(this.UcReportsAndStatistics_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvStatistics)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTopUsers)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvStatistics;
        private System.Windows.Forms.Label labelTopBooks;
        private System.Windows.Forms.Label labelTopUsers;
        private System.Windows.Forms.DataGridView dgvTopUsers;
        private System.Windows.Forms.Button btnTopBooks;
        private System.Windows.Forms.Button btnTopUsers;
    }
}
