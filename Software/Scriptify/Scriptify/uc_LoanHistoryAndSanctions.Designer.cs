﻿namespace Scriptify {
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
            ((System.ComponentModel.ISupportInitialize)(this.dgvLoanHistoryAndSanctions)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(208, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(349, 29);
            this.label1.TabIndex = 2;
            this.label1.Text = "Loan History and Sanctions";
            // 
            // dgvLoanHistoryAndSanctions
            // 
            this.dgvLoanHistoryAndSanctions.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLoanHistoryAndSanctions.Location = new System.Drawing.Point(18, 68);
            this.dgvLoanHistoryAndSanctions.Name = "dgvLoanHistoryAndSanctions";
            this.dgvLoanHistoryAndSanctions.RowHeadersWidth = 51;
            this.dgvLoanHistoryAndSanctions.RowTemplate.Height = 24;
            this.dgvLoanHistoryAndSanctions.Size = new System.Drawing.Size(648, 310);
            this.dgvLoanHistoryAndSanctions.TabIndex = 3;
            // 
            // btnSanction
            // 
            this.btnSanction.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnSanction.ForeColor = System.Drawing.Color.Red;
            this.btnSanction.Location = new System.Drawing.Point(569, 384);
            this.btnSanction.Name = "btnSanction";
            this.btnSanction.Size = new System.Drawing.Size(97, 32);
            this.btnSanction.TabIndex = 4;
            this.btnSanction.Text = "Sanction";
            this.btnSanction.UseVisualStyleBackColor = true;
            this.btnSanction.Click += new System.EventHandler(this.btnSanction_Click);
            // 
            // uc_LoanHistoryAndSanctions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnSanction);
            this.Controls.Add(this.dgvLoanHistoryAndSanctions);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "uc_LoanHistoryAndSanctions";
            this.Size = new System.Drawing.Size(757, 478);
            this.Load += new System.EventHandler(this.uc_LoanHistoryAndSanctions_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvLoanHistoryAndSanctions)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvLoanHistoryAndSanctions;
        private System.Windows.Forms.Button btnSanction;
    }
}