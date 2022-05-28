namespace LibraryManagementSystem.Forms
{
    partial class ManageAuthorsForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label_header_authors = new System.Windows.Forms.Label();
            this.label_close_authors = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label_authorsCount = new System.Windows.Forms.Label();
            this.btnShowAuthorBooks = new System.Windows.Forms.Button();
            this.btnUpdateAuthor = new System.Windows.Forms.Button();
            this.btnAddAuthor = new System.Windows.Forms.Button();
            this.btnDeleteAuthor = new System.Windows.Forms.Button();
            this.btnEditAuthor = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dataGridView_Authors = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FIRSTNAME = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LASTNAME = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EDUCATION = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BIO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.richTextBox_AuthorBio = new System.Windows.Forms.RichTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtAuthorEducation = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtAuthorLastName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtAuthorID = new System.Windows.Forms.TextBox();
            this.labelID = new System.Windows.Forms.Label();
            this.txtAuthorFirstName = new System.Windows.Forms.TextBox();
            this.labeName = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Authors)).BeginInit();
            this.SuspendLayout();
            // 
            // label_header_authors
            // 
            this.label_header_authors.BackColor = System.Drawing.Color.Gold;
            this.label_header_authors.Dock = System.Windows.Forms.DockStyle.Top;
            this.label_header_authors.Font = new System.Drawing.Font("Comic Sans MS", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_header_authors.ForeColor = System.Drawing.Color.Black;
            this.label_header_authors.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label_header_authors.Location = new System.Drawing.Point(0, 0);
            this.label_header_authors.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_header_authors.Name = "label_header_authors";
            this.label_header_authors.Size = new System.Drawing.Size(1688, 94);
            this.label_header_authors.TabIndex = 2;
            this.label_header_authors.Text = "      Authors";
            this.label_header_authors.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label_close_authors
            // 
            this.label_close_authors.AutoSize = true;
            this.label_close_authors.BackColor = System.Drawing.Color.Gold;
            this.label_close_authors.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label_close_authors.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_close_authors.ForeColor = System.Drawing.Color.White;
            this.label_close_authors.Location = new System.Drawing.Point(1653, 0);
            this.label_close_authors.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_close_authors.Name = "label_close_authors";
            this.label_close_authors.Size = new System.Drawing.Size(32, 31);
            this.label_close_authors.TabIndex = 4;
            this.label_close_authors.Text = "X";
            this.label_close_authors.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label_close_authors.Click += new System.EventHandler(this.label_close_authors_Click);
            this.label_close_authors.MouseEnter += new System.EventHandler(this.label_close_authors_MouseEnter);
            this.label_close_authors.MouseLeave += new System.EventHandler(this.label_close_authors_MouseLeave);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(50)))), ((int)(((byte)(67)))));
            this.panel1.Controls.Add(this.label_authorsCount);
            this.panel1.Controls.Add(this.btnShowAuthorBooks);
            this.panel1.Controls.Add(this.btnUpdateAuthor);
            this.panel1.Controls.Add(this.btnAddAuthor);
            this.panel1.Controls.Add(this.btnDeleteAuthor);
            this.panel1.Controls.Add(this.btnEditAuthor);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 94);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(189, 512);
            this.panel1.TabIndex = 5;
            // 
            // label_authorsCount
            // 
            this.label_authorsCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_authorsCount.ForeColor = System.Drawing.Color.Gold;
            this.label_authorsCount.Location = new System.Drawing.Point(12, 439);
            this.label_authorsCount.Name = "label_authorsCount";
            this.label_authorsCount.Size = new System.Drawing.Size(168, 55);
            this.label_authorsCount.TabIndex = 51;
            this.label_authorsCount.Text = "999 Authors";
            this.label_authorsCount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnShowAuthorBooks
            // 
            this.btnShowAuthorBooks.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShowAuthorBooks.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnShowAuthorBooks.Location = new System.Drawing.Point(11, 303);
            this.btnShowAuthorBooks.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnShowAuthorBooks.Name = "btnShowAuthorBooks";
            this.btnShowAuthorBooks.Size = new System.Drawing.Size(169, 84);
            this.btnShowAuthorBooks.TabIndex = 13;
            this.btnShowAuthorBooks.Text = " Show   \r\nAuthor\r\nBooks";
            this.btnShowAuthorBooks.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnShowAuthorBooks.UseVisualStyleBackColor = true;
            this.btnShowAuthorBooks.Click += new System.EventHandler(this.btnShowAuthorBooks_Click);
            // 
            // btnUpdateAuthor
            // 
            this.btnUpdateAuthor.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdateAuthor.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUpdateAuthor.Location = new System.Drawing.Point(11, 92);
            this.btnUpdateAuthor.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnUpdateAuthor.Name = "btnUpdateAuthor";
            this.btnUpdateAuthor.Size = new System.Drawing.Size(169, 59);
            this.btnUpdateAuthor.TabIndex = 12;
            this.btnUpdateAuthor.Text = " Update";
            this.btnUpdateAuthor.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnUpdateAuthor.UseVisualStyleBackColor = true;
            this.btnUpdateAuthor.Click += new System.EventHandler(this.btnUpdateAuthor_Click);
            // 
            // btnAddAuthor
            // 
            this.btnAddAuthor.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddAuthor.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAddAuthor.Location = new System.Drawing.Point(11, 22);
            this.btnAddAuthor.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnAddAuthor.Name = "btnAddAuthor";
            this.btnAddAuthor.Size = new System.Drawing.Size(169, 59);
            this.btnAddAuthor.TabIndex = 9;
            this.btnAddAuthor.Text = " Add";
            this.btnAddAuthor.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAddAuthor.UseVisualStyleBackColor = true;
            this.btnAddAuthor.Click += new System.EventHandler(this.btnAddAuthor_Click);
            // 
            // btnDeleteAuthor
            // 
            this.btnDeleteAuthor.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteAuthor.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDeleteAuthor.Location = new System.Drawing.Point(11, 233);
            this.btnDeleteAuthor.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnDeleteAuthor.Name = "btnDeleteAuthor";
            this.btnDeleteAuthor.Size = new System.Drawing.Size(169, 59);
            this.btnDeleteAuthor.TabIndex = 11;
            this.btnDeleteAuthor.Text = " Delete";
            this.btnDeleteAuthor.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnDeleteAuthor.UseVisualStyleBackColor = true;
            this.btnDeleteAuthor.Click += new System.EventHandler(this.btnDeleteAuthor_Click);
            // 
            // btnEditAuthor
            // 
            this.btnEditAuthor.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditAuthor.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEditAuthor.Location = new System.Drawing.Point(11, 162);
            this.btnEditAuthor.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnEditAuthor.Name = "btnEditAuthor";
            this.btnEditAuthor.Size = new System.Drawing.Size(169, 59);
            this.btnEditAuthor.TabIndex = 10;
            this.btnEditAuthor.Text = " Edit";
            this.btnEditAuthor.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnEditAuthor.UseVisualStyleBackColor = true;
            this.btnEditAuthor.Click += new System.EventHandler(this.btnEditAuthor_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.dataGridView_Authors);
            this.panel2.Controls.Add(this.richTextBox_AuthorBio);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.txtAuthorEducation);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.txtAuthorLastName);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.txtAuthorID);
            this.panel2.Controls.Add(this.labelID);
            this.panel2.Controls.Add(this.txtAuthorFirstName);
            this.panel2.Controls.Add(this.labeName);
            this.panel2.Location = new System.Drawing.Point(196, 98);
            this.panel2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1487, 494);
            this.panel2.TabIndex = 6;
            // 
            // dataGridView_Authors
            // 
            this.dataGridView_Authors.AllowUserToAddRows = false;
            this.dataGridView_Authors.AllowUserToDeleteRows = false;
            this.dataGridView_Authors.AllowUserToOrderColumns = true;
            this.dataGridView_Authors.AllowUserToResizeRows = false;
            this.dataGridView_Authors.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView_Authors.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView_Authors.BackgroundColor = System.Drawing.SystemColors.ControlDark;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Mongolian Baiti", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView_Authors.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView_Authors.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_Authors.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.FIRSTNAME,
            this.LASTNAME,
            this.EDUCATION,
            this.BIO});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Info;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Red;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView_Authors.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView_Authors.Location = new System.Drawing.Point(560, 37);
            this.dataGridView_Authors.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dataGridView_Authors.Name = "dataGridView_Authors";
            this.dataGridView_Authors.ReadOnly = true;
            this.dataGridView_Authors.RowHeadersWidth = 51;
            this.dataGridView_Authors.Size = new System.Drawing.Size(916, 453);
            this.dataGridView_Authors.TabIndex = 23;
            // 
            // ID
            // 
            this.ID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.ID.DataPropertyName = "ID";
            this.ID.FillWeight = 40F;
            this.ID.HeaderText = "ID";
            this.ID.MinimumWidth = 6;
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            this.ID.Width = 68;
            // 
            // FIRSTNAME
            // 
            this.FIRSTNAME.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.FIRSTNAME.DataPropertyName = "FIRSTNAME";
            this.FIRSTNAME.FillWeight = 99.61929F;
            this.FIRSTNAME.HeaderText = "First Name";
            this.FIRSTNAME.MinimumWidth = 6;
            this.FIRSTNAME.Name = "FIRSTNAME";
            this.FIRSTNAME.ReadOnly = true;
            this.FIRSTNAME.Width = 144;
            // 
            // LASTNAME
            // 
            this.LASTNAME.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.LASTNAME.DataPropertyName = "LASTNAME";
            this.LASTNAME.FillWeight = 99.61929F;
            this.LASTNAME.HeaderText = "Last Name";
            this.LASTNAME.MinimumWidth = 6;
            this.LASTNAME.Name = "LASTNAME";
            this.LASTNAME.ReadOnly = true;
            this.LASTNAME.Width = 142;
            // 
            // EDUCATION
            // 
            this.EDUCATION.HeaderText = "Education";
            this.EDUCATION.MinimumWidth = 6;
            this.EDUCATION.Name = "EDUCATION";
            this.EDUCATION.ReadOnly = true;
            // 
            // BIO
            // 
            this.BIO.HeaderText = "Bio";
            this.BIO.MinimumWidth = 6;
            this.BIO.Name = "BIO";
            this.BIO.ReadOnly = true;
            // 
            // richTextBox_AuthorBio
            // 
            this.richTextBox_AuthorBio.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBox_AuthorBio.Location = new System.Drawing.Point(203, 273);
            this.richTextBox_AuthorBio.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.richTextBox_AuthorBio.Name = "richTextBox_AuthorBio";
            this.richTextBox_AuthorBio.Size = new System.Drawing.Size(336, 217);
            this.richTextBox_AuthorBio.TabIndex = 15;
            this.richTextBox_AuthorBio.Text = "";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Mongolian Baiti", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(127, 279);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 29);
            this.label2.TabIndex = 19;
            this.label2.Text = "Bio:";
            // 
            // txtAuthorEducation
            // 
            this.txtAuthorEducation.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAuthorEducation.Location = new System.Drawing.Point(203, 214);
            this.txtAuthorEducation.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtAuthorEducation.Name = "txtAuthorEducation";
            this.txtAuthorEducation.Size = new System.Drawing.Size(336, 37);
            this.txtAuthorEducation.TabIndex = 14;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Mongolian Baiti", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(44, 220);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(144, 29);
            this.label3.TabIndex = 17;
            this.label3.Text = "Education:";
            // 
            // txtAuthorLastName
            // 
            this.txtAuthorLastName.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAuthorLastName.Location = new System.Drawing.Point(203, 155);
            this.txtAuthorLastName.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtAuthorLastName.Name = "txtAuthorLastName";
            this.txtAuthorLastName.Size = new System.Drawing.Size(336, 37);
            this.txtAuthorLastName.TabIndex = 13;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Mongolian Baiti", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(40, 161);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(150, 29);
            this.label1.TabIndex = 15;
            this.label1.Text = "Last Name:";
            // 
            // txtAuthorID
            // 
            this.txtAuthorID.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAuthorID.Location = new System.Drawing.Point(203, 37);
            this.txtAuthorID.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtAuthorID.Name = "txtAuthorID";
            this.txtAuthorID.Size = new System.Drawing.Size(105, 37);
            this.txtAuthorID.TabIndex = 20;
            // 
            // labelID
            // 
            this.labelID.AutoSize = true;
            this.labelID.Font = new System.Drawing.Font("Mongolian Baiti", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelID.Location = new System.Drawing.Point(140, 43);
            this.labelID.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelID.Name = "labelID";
            this.labelID.Size = new System.Drawing.Size(53, 29);
            this.labelID.TabIndex = 13;
            this.labelID.Text = "ID:";
            // 
            // txtAuthorFirstName
            // 
            this.txtAuthorFirstName.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAuthorFirstName.Location = new System.Drawing.Point(203, 96);
            this.txtAuthorFirstName.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtAuthorFirstName.Name = "txtAuthorFirstName";
            this.txtAuthorFirstName.Size = new System.Drawing.Size(336, 37);
            this.txtAuthorFirstName.TabIndex = 12;
            // 
            // labeName
            // 
            this.labeName.AutoSize = true;
            this.labeName.Font = new System.Drawing.Font("Mongolian Baiti", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labeName.Location = new System.Drawing.Point(35, 102);
            this.labeName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labeName.Name = "labeName";
            this.labeName.Size = new System.Drawing.Size(154, 29);
            this.labeName.TabIndex = 11;
            this.labeName.Text = "First Name:";
            // 
            // ManageAuthorsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(197)))), ((int)(((byte)(239)))), ((int)(((byte)(247)))));
            this.ClientSize = new System.Drawing.Size(1688, 606);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label_close_authors);
            this.Controls.Add(this.label_header_authors);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "ManageAuthorsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ManageAuthorsForm";
            this.Load += new System.EventHandler(this.ManageAuthorsForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Authors)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_header_authors;
        private System.Windows.Forms.Label label_close_authors;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnUpdateAuthor;
        private System.Windows.Forms.Button btnAddAuthor;
        private System.Windows.Forms.Button btnDeleteAuthor;
        private System.Windows.Forms.Button btnEditAuthor;
        private System.Windows.Forms.RichTextBox richTextBox_AuthorBio;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtAuthorEducation;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtAuthorLastName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtAuthorID;
        private System.Windows.Forms.Label labelID;
        private System.Windows.Forms.TextBox txtAuthorFirstName;
        private System.Windows.Forms.Label labeName;
        private System.Windows.Forms.DataGridView dataGridView_Authors;
        private System.Windows.Forms.Button btnShowAuthorBooks;
        public System.Windows.Forms.Label label_authorsCount;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn FIRSTNAME;
        private System.Windows.Forms.DataGridViewTextBoxColumn LASTNAME;
        private System.Windows.Forms.DataGridViewTextBoxColumn EDUCATION;
        private System.Windows.Forms.DataGridViewTextBoxColumn BIO;
    }
}