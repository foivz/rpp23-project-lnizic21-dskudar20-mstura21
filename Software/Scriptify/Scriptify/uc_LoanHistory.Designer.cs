using System.Drawing;
using System.Windows.Forms;

namespace Scriptify
{
    partial class uc_LoanHistory
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
            this.dgvLoanHistory = new System.Windows.Forms.DataGridView();
            this.btnEvidentiraj = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLoanHistory)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvLoanHistory
            // 
            this.dgvLoanHistory.AllowDrop = true;
            this.dgvLoanHistory.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvLoanHistory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLoanHistory.Location = new System.Drawing.Point(3, 43);
            this.dgvLoanHistory.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvLoanHistory.Name = "dgvLoanHistory";
            this.dgvLoanHistory.RowHeadersWidth = 51;
            this.dgvLoanHistory.RowTemplate.Height = 24;
            this.dgvLoanHistory.Size = new System.Drawing.Size(726, 282);
            this.dgvLoanHistory.TabIndex = 0;
            // 
            // btnEvidentiraj
            // 
            this.btnEvidentiraj.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEvidentiraj.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.btnEvidentiraj.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEvidentiraj.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.btnEvidentiraj.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEvidentiraj.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnEvidentiraj.ForeColor = System.Drawing.Color.White;
            this.btnEvidentiraj.Location = new System.Drawing.Point(516, 343);
            this.btnEvidentiraj.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnEvidentiraj.Name = "btnEvidentiraj";
            this.btnEvidentiraj.Size = new System.Drawing.Size(109, 23);
            this.btnEvidentiraj.TabIndex = 1;
            this.btnEvidentiraj.Text = "Evidentiraj";
            this.btnEvidentiraj.UseVisualStyleBackColor = true;
            this.btnEvidentiraj.Click += new System.EventHandler(this.btnEvidentiraj_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(260, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(234, 29);
            this.label1.TabIndex = 2;
            this.label1.Text = "Loans In Progress";
            // 
            // uc_LoanHistory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnEvidentiraj);
            this.Controls.Add(this.dgvLoanHistory);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "uc_LoanHistory";
            this.Size = new System.Drawing.Size(877, 534);
            this.Load += new System.EventHandler(this.uc_LoanHistory_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.dgvLoanHistory)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvLoanHistory;
        private System.Windows.Forms.Button btnEvidentiraj;
        private System.Windows.Forms.Label label1;
    }
}
