
namespace LibraryManagementSystem.Forms
{
    partial class BookInfoCard
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
            this.label_ISBN = new System.Windows.Forms.Label();
            this.label_title = new System.Windows.Forms.Label();
            this.label_author = new System.Windows.Forms.Label();
            this.label_quantity = new System.Windows.Forms.Label();
            this.label_genre = new System.Windows.Forms.Label();
            this.label_price = new System.Windows.Forms.Label();
            this.label_publisher = new System.Windows.Forms.Label();
            this.label_dateAdded = new System.Windows.Forms.Label();
            this.panel_Book = new System.Windows.Forms.Panel();
            this.richTextBox_decription = new System.Windows.Forms.RichTextBox();
            this.label_close_books = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label_ISBN
            // 
            this.label_ISBN.AutoSize = true;
            this.label_ISBN.Font = new System.Drawing.Font("Mongolian Baiti", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_ISBN.Location = new System.Drawing.Point(318, 33);
            this.label_ISBN.Name = "label_ISBN";
            this.label_ISBN.Size = new System.Drawing.Size(69, 23);
            this.label_ISBN.TabIndex = 39;
            this.label_ISBN.Text = "ISBN:";
            // 
            // label_title
            // 
            this.label_title.AutoSize = true;
            this.label_title.Font = new System.Drawing.Font("Mongolian Baiti", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_title.Location = new System.Drawing.Point(318, 77);
            this.label_title.Name = "label_title";
            this.label_title.Size = new System.Drawing.Size(62, 23);
            this.label_title.TabIndex = 40;
            this.label_title.Text = "Title:";
            // 
            // label_author
            // 
            this.label_author.AutoSize = true;
            this.label_author.Font = new System.Drawing.Font("Mongolian Baiti", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_author.Location = new System.Drawing.Point(318, 113);
            this.label_author.Name = "label_author";
            this.label_author.Size = new System.Drawing.Size(84, 23);
            this.label_author.TabIndex = 41;
            this.label_author.Text = "Author:";
            // 
            // label_quantity
            // 
            this.label_quantity.AutoSize = true;
            this.label_quantity.Font = new System.Drawing.Font("Mongolian Baiti", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_quantity.Location = new System.Drawing.Point(318, 155);
            this.label_quantity.Name = "label_quantity";
            this.label_quantity.Size = new System.Drawing.Size(100, 23);
            this.label_quantity.TabIndex = 42;
            this.label_quantity.Text = "Quantity:";
            // 
            // label_genre
            // 
            this.label_genre.AutoSize = true;
            this.label_genre.Font = new System.Drawing.Font("Mongolian Baiti", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_genre.Location = new System.Drawing.Point(318, 196);
            this.label_genre.Name = "label_genre";
            this.label_genre.Size = new System.Drawing.Size(73, 23);
            this.label_genre.TabIndex = 43;
            this.label_genre.Text = "Genre:";
            // 
            // label_price
            // 
            this.label_price.AutoSize = true;
            this.label_price.Font = new System.Drawing.Font("Mongolian Baiti", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_price.Location = new System.Drawing.Point(318, 240);
            this.label_price.Name = "label_price";
            this.label_price.Size = new System.Drawing.Size(65, 23);
            this.label_price.TabIndex = 44;
            this.label_price.Text = "Price:";
            // 
            // label_publisher
            // 
            this.label_publisher.AutoSize = true;
            this.label_publisher.Font = new System.Drawing.Font("Mongolian Baiti", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_publisher.Location = new System.Drawing.Point(318, 273);
            this.label_publisher.Name = "label_publisher";
            this.label_publisher.Size = new System.Drawing.Size(107, 23);
            this.label_publisher.TabIndex = 45;
            this.label_publisher.Text = "Publisher:";
            // 
            // label_dateAdded
            // 
            this.label_dateAdded.AutoSize = true;
            this.label_dateAdded.Font = new System.Drawing.Font("Mongolian Baiti", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_dateAdded.Location = new System.Drawing.Point(318, 323);
            this.label_dateAdded.Name = "label_dateAdded";
            this.label_dateAdded.Size = new System.Drawing.Size(128, 23);
            this.label_dateAdded.TabIndex = 46;
            this.label_dateAdded.Text = "Date Added:";
            // 
            // panel_Book
            // 
            this.panel_Book.BackColor = System.Drawing.Color.RoyalBlue;
            this.panel_Book.Location = new System.Drawing.Point(12, 33);
            this.panel_Book.Name = "panel_Book";
            this.panel_Book.Size = new System.Drawing.Size(287, 263);
            this.panel_Book.TabIndex = 47;
            // 
            // richTextBox_decription
            // 
            this.richTextBox_decription.Enabled = false;
            this.richTextBox_decription.Location = new System.Drawing.Point(12, 302);
            this.richTextBox_decription.Name = "richTextBox_decription";
            this.richTextBox_decription.Size = new System.Drawing.Size(287, 136);
            this.richTextBox_decription.TabIndex = 48;
            this.richTextBox_decription.Text = "";
            // 
            // label_close_books
            // 
            this.label_close_books.AutoSize = true;
            this.label_close_books.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.label_close_books.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label_close_books.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_close_books.ForeColor = System.Drawing.Color.White;
            this.label_close_books.Location = new System.Drawing.Point(513, 9);
            this.label_close_books.Name = "label_close_books";
            this.label_close_books.Size = new System.Drawing.Size(26, 25);
            this.label_close_books.TabIndex = 49;
            this.label_close_books.Text = "X";
            this.label_close_books.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label_close_books.Click += new System.EventHandler(this.label_close_books_Click);
            // 
            // BookInfoCard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.ClientSize = new System.Drawing.Size(551, 462);
            this.Controls.Add(this.label_close_books);
            this.Controls.Add(this.richTextBox_decription);
            this.Controls.Add(this.panel_Book);
            this.Controls.Add(this.label_dateAdded);
            this.Controls.Add(this.label_publisher);
            this.Controls.Add(this.label_price);
            this.Controls.Add(this.label_genre);
            this.Controls.Add(this.label_quantity);
            this.Controls.Add(this.label_author);
            this.Controls.Add(this.label_title);
            this.Controls.Add(this.label_ISBN);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "BookInfoCard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BookInfoCard";
            this.Load += new System.EventHandler(this.BookInfoCard_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_ISBN;
        private System.Windows.Forms.Label label_title;
        private System.Windows.Forms.Label label_author;
        private System.Windows.Forms.Label label_quantity;
        private System.Windows.Forms.Label label_genre;
        private System.Windows.Forms.Label label_price;
        private System.Windows.Forms.Label label_publisher;
        private System.Windows.Forms.Label label_dateAdded;
        private System.Windows.Forms.Panel panel_Book;
        private System.Windows.Forms.RichTextBox richTextBox_decription;
        private System.Windows.Forms.Label label_close_books;
    }
}