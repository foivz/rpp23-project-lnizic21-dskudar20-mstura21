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
            ((System.ComponentModel.ISupportInitialize)(this.dgvLoanHistory)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvLoanHistory
            // 
            this.dgvLoanHistory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLoanHistory.Location = new System.Drawing.Point(3, 2);
            this.dgvLoanHistory.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvLoanHistory.Name = "dgvLoanHistory";
            this.dgvLoanHistory.RowHeadersWidth = 51;
            this.dgvLoanHistory.RowTemplate.Height = 24;
            this.dgvLoanHistory.Size = new System.Drawing.Size(620, 281);
            this.dgvLoanHistory.TabIndex = 0;
            // 
            // btnEvidentiraj
            // 
            this.btnEvidentiraj.Location = new System.Drawing.Point(513, 288);
            this.btnEvidentiraj.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnEvidentiraj.Name = "btnEvidentiraj";
            this.btnEvidentiraj.Size = new System.Drawing.Size(109, 23);
            this.btnEvidentiraj.TabIndex = 1;
            this.btnEvidentiraj.Text = "Evidentiraj";
            this.btnEvidentiraj.UseVisualStyleBackColor = true;
            this.btnEvidentiraj.Click += new System.EventHandler(this.btnEvidentiraj_Click);
            // 
            // uc_LoanHistory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnEvidentiraj);
            this.Controls.Add(this.dgvLoanHistory);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "uc_LoanHistory";
            this.Size = new System.Drawing.Size(877, 534);
            this.Load += new System.EventHandler(this.uc_LoanHistory_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.dgvLoanHistory)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvLoanHistory;
        private System.Windows.Forms.Button btnEvidentiraj;
    }
}
