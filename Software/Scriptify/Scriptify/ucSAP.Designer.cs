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
            this.btnScaling = new System.Windows.Forms.Button();
            this.btnAlltime = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSAP)).BeginInit();
            this.SuspendLayout();
            // 
            // lblSAP
            // 
            this.lblSAP.AutoSize = true;
            this.lblSAP.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblSAP.Location = new System.Drawing.Point(195, 0);
            this.lblSAP.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSAP.Name = "lblSAP";
            this.lblSAP.Size = new System.Drawing.Size(276, 25);
            this.lblSAP.TabIndex = 3;
            this.lblSAP.Text = "Scriptify Aprooved Program";
            // 
            // dgvSAP
            // 
            this.dgvSAP.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvSAP.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSAP.Location = new System.Drawing.Point(3, 40);
            this.dgvSAP.Name = "dgvSAP";
            this.dgvSAP.RowHeadersWidth = 51;
            this.dgvSAP.Size = new System.Drawing.Size(459, 186);
            this.dgvSAP.TabIndex = 4;
            // 
            // btnScaling
            // 
            this.btnScaling.Location = new System.Drawing.Point(334, 232);
            this.btnScaling.Name = "btnScaling";
            this.btnScaling.Size = new System.Drawing.Size(128, 23);
            this.btnScaling.TabIndex = 5;
            this.btnScaling.Text = "Scaled Leaderboard";
            this.btnScaling.UseVisualStyleBackColor = true;
            this.btnScaling.Click += new System.EventHandler(this.btnScaling_Click);
            // 
            // btnAlltime
            // 
            this.btnAlltime.Location = new System.Drawing.Point(200, 232);
            this.btnAlltime.Name = "btnAlltime";
            this.btnAlltime.Size = new System.Drawing.Size(128, 23);
            this.btnAlltime.TabIndex = 6;
            this.btnAlltime.Text = "All time leaderboard";
            this.btnAlltime.UseVisualStyleBackColor = true;
            this.btnAlltime.Click += new System.EventHandler(this.btnAlltime_Click);
            // 
            // ucSAP
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnAlltime);
            this.Controls.Add(this.btnScaling);
            this.Controls.Add(this.dgvSAP);
            this.Controls.Add(this.lblSAP);
            this.Name = "ucSAP";
            this.Size = new System.Drawing.Size(484, 327);
            this.Load += new System.EventHandler(this.ucSAP_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSAP)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblSAP;
        private System.Windows.Forms.DataGridView dgvSAP;
        private System.Windows.Forms.Button btnScaling;
        private System.Windows.Forms.Button btnAlltime;
    }
}
