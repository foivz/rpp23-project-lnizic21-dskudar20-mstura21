namespace Scriptify
{
    partial class frmInvoice
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.rtxtInvoice = new System.Windows.Forms.RichTextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.btnPaid = new System.Windows.Forms.Button();
            this.labelStatusPayed = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // rtxtInvoice
            // 
            this.rtxtInvoice.Location = new System.Drawing.Point(-2, -4);
            this.rtxtInvoice.Name = "rtxtInvoice";
            this.rtxtInvoice.Size = new System.Drawing.Size(478, 374);
            this.rtxtInvoice.TabIndex = 0;
            this.rtxtInvoice.Text = "";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(358, 548);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // btnPaid
            // 
            this.btnPaid.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnPaid.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnPaid.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnPaid.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnPaid.Location = new System.Drawing.Point(147, 305);
            this.btnPaid.Name = "btnPaid";
            this.btnPaid.Size = new System.Drawing.Size(183, 38);
            this.btnPaid.TabIndex = 2;
            this.btnPaid.Text = "Confirm payment";
            this.btnPaid.UseVisualStyleBackColor = true;
            this.btnPaid.Click += new System.EventHandler(this.btnPaid_Click);
            // 
            // labelStatusPayed
            // 
            this.labelStatusPayed.AutoSize = true;
            this.labelStatusPayed.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelStatusPayed.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.labelStatusPayed.Location = new System.Drawing.Point(209, 309);
            this.labelStatusPayed.Name = "labelStatusPayed";
            this.labelStatusPayed.Size = new System.Drawing.Size(55, 25);
            this.labelStatusPayed.TabIndex = 3;
            this.labelStatusPayed.Text = "Paid";
            // 
            // frmInvoice
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(477, 367);
            this.Controls.Add(this.labelStatusPayed);
            this.Controls.Add(this.btnPaid);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.rtxtInvoice);
            this.Name = "frmInvoice";
            this.Text = "frmInvoice";
            this.Load += new System.EventHandler(this.frmInvoice_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox rtxtInvoice;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnPaid;
        private System.Windows.Forms.Label labelStatusPayed;
    }
}