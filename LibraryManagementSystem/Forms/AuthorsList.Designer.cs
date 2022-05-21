namespace LibraryManagementSystem.Forms
{
    partial class AuthorsList
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
            this.label1 = new System.Windows.Forms.Label();
            this.label_close_authors_list = new System.Windows.Forms.Label();
            this.listAuthors = new System.Windows.Forms.ListBox();
            this.btnSelectAuthorList = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(183)))), ((int)(((byte)(19)))));
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(284, 73);
            this.label1.TabIndex = 1;
            this.label1.Text = "Authors List";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label_close_authors_list
            // 
            this.label_close_authors_list.AutoSize = true;
            this.label_close_authors_list.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(183)))), ((int)(((byte)(19)))));
            this.label_close_authors_list.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label_close_authors_list.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_close_authors_list.ForeColor = System.Drawing.Color.White;
            this.label_close_authors_list.Location = new System.Drawing.Point(258, 0);
            this.label_close_authors_list.Name = "label_close_authors_list";
            this.label_close_authors_list.Size = new System.Drawing.Size(26, 25);
            this.label_close_authors_list.TabIndex = 2;
            this.label_close_authors_list.Text = "X";
            this.label_close_authors_list.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label_close_authors_list.Click += new System.EventHandler(this.label_close_authors_list_Click);
            this.label_close_authors_list.MouseEnter += new System.EventHandler(this.label_close_authors_list_MouseEnter);
            this.label_close_authors_list.MouseLeave += new System.EventHandler(this.label_close_authors_list_MouseLeave);
            // 
            // listAuthors
            // 
            this.listAuthors.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listAuthors.FormattingEnabled = true;
            this.listAuthors.ItemHeight = 21;
            this.listAuthors.Location = new System.Drawing.Point(4, 77);
            this.listAuthors.Name = "listAuthors";
            this.listAuthors.Size = new System.Drawing.Size(277, 277);
            this.listAuthors.TabIndex = 3;
            // 
            // btnSelectAuthorList
            // 
            this.btnSelectAuthorList.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnSelectAuthorList.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSelectAuthorList.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSelectAuthorList.Font = new System.Drawing.Font("Mongolian Baiti", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSelectAuthorList.ForeColor = System.Drawing.Color.White;
            this.btnSelectAuthorList.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSelectAuthorList.Location = new System.Drawing.Point(17, 361);
            this.btnSelectAuthorList.Name = "btnSelectAuthorList";
            this.btnSelectAuthorList.Size = new System.Drawing.Size(253, 40);
            this.btnSelectAuthorList.TabIndex = 13;
            this.btnSelectAuthorList.Text = "Select Author";
            this.btnSelectAuthorList.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSelectAuthorList.UseVisualStyleBackColor = false;
            this.btnSelectAuthorList.Click += new System.EventHandler(this.btnSelectAuthorList_Click);
            // 
            // AuthorsList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Teal;
            this.ClientSize = new System.Drawing.Size(284, 412);
            this.Controls.Add(this.btnSelectAuthorList);
            this.Controls.Add(this.listAuthors);
            this.Controls.Add(this.label_close_authors_list);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AuthorsList";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AuthorsList";
            this.Load += new System.EventHandler(this.AuthorsList_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label_close_authors_list;
        private System.Windows.Forms.ListBox listAuthors;
        private System.Windows.Forms.Button btnSelectAuthorList;
    }
}