namespace Scriptify {
    partial class uc_LoanHistoryAndSanctions {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.label1 = new System.Windows.Forms.Label();
            this.dgvLoanHistoryAndSanctions = new System.Windows.Forms.DataGridView();
            this.btnSanction = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtSearchLoans = new System.Windows.Forms.TextBox();
            this.btnLoanHistory = new System.Windows.Forms.Button();
            this.btnSanctions = new System.Windows.Forms.Button();
            this.dgvSanctions = new System.Windows.Forms.DataGridView();
            this.txtSearchSanctions = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLoanHistoryAndSanctions)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSanctions)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(260, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(349, 29);
            this.label1.TabIndex = 2;
            this.label1.Text = "Loan History and Sanctions";
            // 
            // dgvLoanHistoryAndSanctions
            // 
            this.dgvLoanHistoryAndSanctions.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLoanHistoryAndSanctions.Location = new System.Drawing.Point(2, 118);
            this.dgvLoanHistoryAndSanctions.Name = "dgvLoanHistoryAndSanctions";
            this.dgvLoanHistoryAndSanctions.RowHeadersWidth = 51;
            this.dgvLoanHistoryAndSanctions.RowTemplate.Height = 24;
            this.dgvLoanHistoryAndSanctions.Size = new System.Drawing.Size(743, 241);
            this.dgvLoanHistoryAndSanctions.TabIndex = 3;
            this.dgvLoanHistoryAndSanctions.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgvLoanHistoryAndSanctions_CellFormatting);
            // 
            // btnSanction
            // 
            this.btnSanction.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnSanction.ForeColor = System.Drawing.Color.Red;
            this.btnSanction.Location = new System.Drawing.Point(299, 379);
            this.btnSanction.Name = "btnSanction";
            this.btnSanction.Size = new System.Drawing.Size(215, 32);
            this.btnSanction.TabIndex = 4;
            this.btnSanction.Text = "Sanction and finish";
            this.btnSanction.UseVisualStyleBackColor = true;
            this.btnSanction.Click += new System.EventHandler(this.btnSanction_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(3, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(492, 25);
            this.label2.TabIndex = 5;
            this.label2.Text = "To issue a sanction, select a loan and press \"Sanction\".";
            // 
            // txtSearchLoans
            // 
            this.txtSearchLoans.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtSearchLoans.Location = new System.Drawing.Point(3, 61);
            this.txtSearchLoans.Name = "txtSearchLoans";
            this.txtSearchLoans.Size = new System.Drawing.Size(206, 26);
            this.txtSearchLoans.TabIndex = 6;
            this.txtSearchLoans.TextChanged += new System.EventHandler(this.txtSearchLoans_TextChanged);
            // 
            // btnLoanHistory
            // 
            this.btnLoanHistory.Location = new System.Drawing.Point(645, 61);
            this.btnLoanHistory.Name = "btnLoanHistory";
            this.btnLoanHistory.Size = new System.Drawing.Size(100, 34);
            this.btnLoanHistory.TabIndex = 7;
            this.btnLoanHistory.Text = "Loan history";
            this.btnLoanHistory.UseVisualStyleBackColor = true;
            this.btnLoanHistory.Click += new System.EventHandler(this.btnLoanHistory_Click);
            // 
            // btnSanctions
            // 
            this.btnSanctions.Location = new System.Drawing.Point(666, 61);
            this.btnSanctions.Name = "btnSanctions";
            this.btnSanctions.Size = new System.Drawing.Size(79, 34);
            this.btnSanctions.TabIndex = 8;
            this.btnSanctions.Text = "Sanctions";
            this.btnSanctions.UseVisualStyleBackColor = true;
            this.btnSanctions.Click += new System.EventHandler(this.button2_Click);
            // 
            // dgvSanctions
            // 
            this.dgvSanctions.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSanctions.Location = new System.Drawing.Point(3, 118);
            this.dgvSanctions.Name = "dgvSanctions";
            this.dgvSanctions.RowHeadersWidth = 51;
            this.dgvSanctions.RowTemplate.Height = 24;
            this.dgvSanctions.Size = new System.Drawing.Size(742, 241);
            this.dgvSanctions.TabIndex = 9;
            // 
            // txtSearchSanctions
            // 
            this.txtSearchSanctions.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtSearchSanctions.Location = new System.Drawing.Point(3, 61);
            this.txtSearchSanctions.Name = "txtSearchSanctions";
            this.txtSearchSanctions.Size = new System.Drawing.Size(206, 26);
            this.txtSearchSanctions.TabIndex = 10;
            this.txtSearchSanctions.TextChanged += new System.EventHandler(this.txtSearchSanctions_TextChanged);
            // 
            // uc_LoanHistoryAndSanctions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.txtSearchSanctions);
            this.Controls.Add(this.dgvSanctions);
            this.Controls.Add(this.btnSanctions);
            this.Controls.Add(this.btnLoanHistory);
            this.Controls.Add(this.txtSearchLoans);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnSanction);
            this.Controls.Add(this.dgvLoanHistoryAndSanctions);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "uc_LoanHistoryAndSanctions";
            this.Size = new System.Drawing.Size(757, 437);
            this.Load += new System.EventHandler(this.uc_LoanHistoryAndSanctions_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvLoanHistoryAndSanctions)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSanctions)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvLoanHistoryAndSanctions;
        private System.Windows.Forms.Button btnSanction;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtSearchLoans;
        private System.Windows.Forms.Button btnLoanHistory;
        private System.Windows.Forms.Button btnSanctions;
        private System.Windows.Forms.DataGridView dgvSanctions;
        private System.Windows.Forms.TextBox txtSearchSanctions;
    }
}
