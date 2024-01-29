namespace Scriptify {
    partial class ucSAP {
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
            this.lblSAP = new System.Windows.Forms.Label();
            this.dgvSAP = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSAP)).BeginInit();
            this.SuspendLayout();
            // 
            // lblSAP
            // 
            this.lblSAP.AutoSize = true;
            this.lblSAP.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblSAP.Location = new System.Drawing.Point(260, 0);
            this.lblSAP.Name = "lblSAP";
            this.lblSAP.Size = new System.Drawing.Size(349, 29);
            this.lblSAP.TabIndex = 3;
            this.lblSAP.Text = "Scriptify Aprooved Program";
            // 
            // dgvSAP
            // 
            this.dgvSAP.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvSAP.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSAP.Location = new System.Drawing.Point(4, 49);
            this.dgvSAP.Margin = new System.Windows.Forms.Padding(4);
            this.dgvSAP.Name = "dgvSAP";
            this.dgvSAP.RowHeadersWidth = 51;
            this.dgvSAP.Size = new System.Drawing.Size(612, 229);
            this.dgvSAP.TabIndex = 4;
            // 
            // ucSAP
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dgvSAP);
            this.Controls.Add(this.lblSAP);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "ucSAP";
            this.Size = new System.Drawing.Size(645, 402);
            this.Load += new System.EventHandler(this.ucSAP_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSAP)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblSAP;
        private System.Windows.Forms.DataGridView dgvSAP;
    }
}
