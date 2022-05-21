namespace LibraryManagementSystem.Forms
{
    partial class ManageBooksForm
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
            this.label_header_books = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnUpdateBook = new System.Windows.Forms.Button();
            this.btnAddBook = new System.Windows.Forms.Button();
            this.btnDeleteBook = new System.Windows.Forms.Button();
            this.btnEditBook = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label_header_books
            // 
            this.label_header_books.BackColor = System.Drawing.Color.Gold;
            this.label_header_books.Dock = System.Windows.Forms.DockStyle.Top;
            this.label_header_books.Font = new System.Drawing.Font("Comic Sans MS", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_header_books.ForeColor = System.Drawing.Color.Black;
            this.label_header_books.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label_header_books.Location = new System.Drawing.Point(0, 0);
            this.label_header_books.Name = "label_header_books";
            this.label_header_books.Size = new System.Drawing.Size(996, 76);
            this.label_header_books.TabIndex = 3;
            this.label_header_books.Text = "      Books";
            this.label_header_books.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(50)))), ((int)(((byte)(67)))));
            this.panel1.Controls.Add(this.btnUpdateBook);
            this.panel1.Controls.Add(this.btnAddBook);
            this.panel1.Controls.Add(this.btnDeleteBook);
            this.panel1.Controls.Add(this.btnEditBook);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 76);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(142, 402);
            this.panel1.TabIndex = 6;
            // 
            // btnUpdateBook
            // 
            this.btnUpdateBook.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdateBook.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUpdateBook.Location = new System.Drawing.Point(8, 75);
            this.btnUpdateBook.Name = "btnUpdateBook";
            this.btnUpdateBook.Size = new System.Drawing.Size(127, 48);
            this.btnUpdateBook.TabIndex = 12;
            this.btnUpdateBook.Text = " Update";
            this.btnUpdateBook.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnUpdateBook.UseVisualStyleBackColor = true;
            // 
            // btnAddBook
            // 
            this.btnAddBook.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddBook.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAddBook.Location = new System.Drawing.Point(8, 18);
            this.btnAddBook.Name = "btnAddBook";
            this.btnAddBook.Size = new System.Drawing.Size(127, 48);
            this.btnAddBook.TabIndex = 9;
            this.btnAddBook.Text = " Add";
            this.btnAddBook.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAddBook.UseVisualStyleBackColor = true;
            // 
            // btnDeleteBook
            // 
            this.btnDeleteBook.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteBook.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDeleteBook.Location = new System.Drawing.Point(8, 189);
            this.btnDeleteBook.Name = "btnDeleteBook";
            this.btnDeleteBook.Size = new System.Drawing.Size(127, 48);
            this.btnDeleteBook.TabIndex = 11;
            this.btnDeleteBook.Text = " Delete";
            this.btnDeleteBook.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnDeleteBook.UseVisualStyleBackColor = true;
            // 
            // btnEditBook
            // 
            this.btnEditBook.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditBook.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEditBook.Location = new System.Drawing.Point(8, 132);
            this.btnEditBook.Name = "btnEditBook";
            this.btnEditBook.Size = new System.Drawing.Size(127, 48);
            this.btnEditBook.TabIndex = 10;
            this.btnEditBook.Text = " Edit";
            this.btnEditBook.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnEditBook.UseVisualStyleBackColor = true;
            // 
            // ManageBooksForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(996, 478);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label_header_books);
            this.Name = "ManageBooksForm";
            this.Text = "ManageBooksForm";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label_header_books;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnUpdateBook;
        private System.Windows.Forms.Button btnAddBook;
        private System.Windows.Forms.Button btnDeleteBook;
        private System.Windows.Forms.Button btnEditBook;
    }
}