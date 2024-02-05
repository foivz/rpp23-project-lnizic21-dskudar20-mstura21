namespace Scriptify {
    partial class frmAdd_EditBooks {
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.txtTitle = new System.Windows.Forms.Label();
            this.txtBookName = new System.Windows.Forms.TextBox();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.txtAuthor = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btn_add = new System.Windows.Forms.Button();
            this.btn_save = new System.Windows.Forms.Button();
            this.cmbGenre = new System.Windows.Forms.ComboBox();
            this.cmbAuthors = new System.Windows.Forms.ComboBox();
            this.btnDeselect = new System.Windows.Forms.Button();
            this.txtAuthorSearch = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtGenreSearch = new System.Windows.Forms.TextBox();
            this.btnFC = new System.Windows.Forms.Button();
            this.txtFC = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txtTitle
            // 
            this.txtTitle.AutoSize = true;
            this.txtTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtTitle.Location = new System.Drawing.Point(321, 9);
            this.txtTitle.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.Size = new System.Drawing.Size(154, 25);
            this.txtTitle.TabIndex = 1;
            this.txtTitle.Text = "Add your Book";
            // 
            // txtBookName
            // 
            this.txtBookName.Location = new System.Drawing.Point(242, 69);
            this.txtBookName.Name = "txtBookName";
            this.txtBookName.Size = new System.Drawing.Size(305, 20);
            this.txtBookName.TabIndex = 2;
            // 
            // txtDescription
            // 
            this.txtDescription.Location = new System.Drawing.Point(242, 128);
            this.txtDescription.Multiline = true;
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(305, 177);
            this.txtDescription.TabIndex = 3;
            // 
            // txtAuthor
            // 
            this.txtAuthor.Location = new System.Drawing.Point(413, 341);
            this.txtAuthor.Name = "txtAuthor";
            this.txtAuthor.Size = new System.Drawing.Size(251, 20);
            this.txtAuthor.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(242, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Book Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(242, 112);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Book Description";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(242, 324);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Author";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(242, 370);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(36, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Genre";
            // 
            // btn_add
            // 
            this.btn_add.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btn_add.Location = new System.Drawing.Point(326, 430);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(135, 38);
            this.btn_add.TabIndex = 10;
            this.btn_add.Text = "Add";
            this.btn_add.UseVisualStyleBackColor = false;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // btn_save
            // 
            this.btn_save.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btn_save.Location = new System.Drawing.Point(326, 430);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(135, 38);
            this.btn_save.TabIndex = 11;
            this.btn_save.Text = "Save";
            this.btn_save.UseVisualStyleBackColor = false;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // cmbGenre
            // 
            this.cmbGenre.FormattingEnabled = true;
            this.cmbGenre.Location = new System.Drawing.Point(245, 386);
            this.cmbGenre.Name = "cmbGenre";
            this.cmbGenre.Size = new System.Drawing.Size(302, 21);
            this.cmbGenre.TabIndex = 12;
            this.cmbGenre.SelectedIndexChanged += new System.EventHandler(this.cmbGenre_SelectedIndexChanged);
            // 
            // cmbAuthors
            // 
            this.cmbAuthors.FormattingEnabled = true;
            this.cmbAuthors.Location = new System.Drawing.Point(157, 340);
            this.cmbAuthors.Name = "cmbAuthors";
            this.cmbAuthors.Size = new System.Drawing.Size(227, 21);
            this.cmbAuthors.TabIndex = 13;
            this.cmbAuthors.SelectedIndexChanged += new System.EventHandler(this.cmbAuthors_SelectedIndexChanged);
            // 
            // btnDeselect
            // 
            this.btnDeselect.Location = new System.Drawing.Point(690, 341);
            this.btnDeselect.Name = "btnDeselect";
            this.btnDeselect.Size = new System.Drawing.Size(75, 23);
            this.btnDeselect.TabIndex = 14;
            this.btnDeselect.Text = "Deselect";
            this.btnDeselect.UseVisualStyleBackColor = true;
            this.btnDeselect.Click += new System.EventHandler(this.btnDeselect_Click);
            // 
            // txtAuthorSearch
            // 
            this.txtAuthorSearch.Location = new System.Drawing.Point(12, 340);
            this.txtAuthorSearch.Name = "txtAuthorSearch";
            this.txtAuthorSearch.Size = new System.Drawing.Size(108, 20);
            this.txtAuthorSearch.TabIndex = 15;
            this.txtAuthorSearch.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 324);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(105, 13);
            this.label5.TabIndex = 16;
            this.label5.Text = "Search for an Author";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(15, 370);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(93, 13);
            this.label6.TabIndex = 17;
            this.label6.Text = "Search for Genres";
            // 
            // txtGenreSearch
            // 
            this.txtGenreSearch.Location = new System.Drawing.Point(18, 387);
            this.txtGenreSearch.Name = "txtGenreSearch";
            this.txtGenreSearch.Size = new System.Drawing.Size(108, 20);
            this.txtGenreSearch.TabIndex = 18;
            this.txtGenreSearch.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtGenreSearch_KeyPress);
            // 
            // btnFC
            // 
            this.btnFC.Location = new System.Drawing.Point(690, 9);
            this.btnFC.Name = "btnFC";
            this.btnFC.Size = new System.Drawing.Size(98, 23);
            this.btnFC.TabIndex = 19;
            this.btnFC.Text = "Fact check";
            this.btnFC.UseVisualStyleBackColor = true;
            this.btnFC.Click += new System.EventHandler(this.btnFC_Click);
            // 
            // txtFC
            // 
            this.txtFC.Location = new System.Drawing.Point(544, 11);
            this.txtFC.Name = "txtFC";
            this.txtFC.Size = new System.Drawing.Size(139, 20);
            this.txtFC.TabIndex = 20;
            // 
            // frmAdd_EditBooks
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(800, 490);
            this.Controls.Add(this.txtFC);
            this.Controls.Add(this.btnFC);
            this.Controls.Add(this.txtGenreSearch);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtAuthorSearch);
            this.Controls.Add(this.btnDeselect);
            this.Controls.Add(this.cmbAuthors);
            this.Controls.Add(this.cmbGenre);
            this.Controls.Add(this.btn_save);
            this.Controls.Add(this.btn_add);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtAuthor);
            this.Controls.Add(this.txtDescription);
            this.Controls.Add(this.txtBookName);
            this.Controls.Add(this.txtTitle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmAdd_EditBooks";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.Load += new System.EventHandler(this.frmAdd_EditBooks_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label txtTitle;
        private System.Windows.Forms.TextBox txtBookName;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.TextBox txtAuthor;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.Button btn_save;
        private System.Windows.Forms.ComboBox cmbGenre;
        private System.Windows.Forms.ComboBox cmbAuthors;
        private System.Windows.Forms.Button btnDeselect;
        private System.Windows.Forms.TextBox txtAuthorSearch;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtGenreSearch;
        private System.Windows.Forms.Button btnFC;
        private System.Windows.Forms.TextBox txtFC;
    }
}