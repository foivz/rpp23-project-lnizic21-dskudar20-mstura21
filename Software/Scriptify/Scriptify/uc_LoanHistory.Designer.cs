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
            this.label1 = new System.Windows.Forms.Label();
            this.btnEvidentiraj = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLoanHistory)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvLoanHistory
            // 
            this.dgvLoanHistory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLoanHistory.Location = new System.Drawing.Point(0, 79);
            this.dgvLoanHistory.Name = "dgvLoanHistory";
            this.dgvLoanHistory.RowHeadersWidth = 51;
            this.dgvLoanHistory.RowTemplate.Height = 24;
            this.dgvLoanHistory.Size = new System.Drawing.Size(809, 266);
            this.dgvLoanHistory.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(201, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(415, 39);
            this.label1.TabIndex = 1;
            this.label1.Text = "Evidentiraj povratak knjige";
            // 
            // btnEvidentiraj
            // 
            this.btnEvidentiraj.Location = new System.Drawing.Point(360, 382);
            this.btnEvidentiraj.Name = "btnEvidentiraj";
            this.btnEvidentiraj.Size = new System.Drawing.Size(108, 34);
            this.btnEvidentiraj.TabIndex = 2;
            this.btnEvidentiraj.Text = "Evidentiraj";
            this.btnEvidentiraj.UseVisualStyleBackColor = true;
            this.btnEvidentiraj.Click += new System.EventHandler(this.btnEvidentiraj_Click);
            // 
            // uc_LoanHistory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnEvidentiraj);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvLoanHistory);
            this.Name = "uc_LoanHistory";
            this.Size = new System.Drawing.Size(809, 445);
            this.Load += new System.EventHandler(this.uc_LoanHistory_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvLoanHistory)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvLoanHistory;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnEvidentiraj;
    }
}
