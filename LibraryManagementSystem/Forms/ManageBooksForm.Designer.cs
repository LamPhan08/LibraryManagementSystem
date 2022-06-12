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
            this.btnExportBooks = new System.Windows.Forms.Button();
            this.button_show_book = new System.Windows.Forms.Button();
            this.label_booksCount = new System.Windows.Forms.Label();
            this.btnAddBook = new System.Windows.Forms.Button();
            this.btnDeleteBook = new System.Windows.Forms.Button();
            this.btnEditBook = new System.Windows.Forms.Button();
            this.panel_add = new System.Windows.Forms.Panel();
            this.btnClearFields = new System.Windows.Forms.Button();
            this.txtAuthorID = new System.Windows.Forms.Label();
            this.btnAddNewBook = new System.Windows.Forms.Button();
            this.btnSelectAuthor = new System.Windows.Forms.Button();
            this.txtBookAuthor = new System.Windows.Forms.TextBox();
            this.comboBoxBookGenre = new System.Windows.Forms.ComboBox();
            this.numericUpDown_BookQuantity = new System.Windows.Forms.NumericUpDown();
            this.btnSelectCover = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.txtBookPublisher = new System.Windows.Forms.TextBox();
            this.pictureBookCover = new System.Windows.Forms.PictureBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.dateTimePicker_Books = new System.Windows.Forms.DateTimePicker();
            this.txtBookPrice = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.richTextBox_BookDescription = new System.Windows.Forms.RichTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtBookTitle = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtBookID = new System.Windows.Forms.TextBox();
            this.labelID = new System.Windows.Forms.Label();
            this.txtBookISBN = new System.Windows.Forms.TextBox();
            this.labeName = new System.Windows.Forms.Label();
            this.panel_ShowBooks = new System.Windows.Forms.Panel();
            this.button_RemoveBook = new System.Windows.Forms.Button();
            this.button_editBook_ = new System.Windows.Forms.Button();
            this.dataGridView_ShowBooks = new System.Windows.Forms.DataGridView();
            this.panel_edit = new System.Windows.Forms.Panel();
            this.button_searchByIsbn = new System.Windows.Forms.Button();
            this.button_searchById = new System.Windows.Forms.Button();
            this.label_AuthorId_Edit = new System.Windows.Forms.Label();
            this.button_EditBook = new System.Windows.Forms.Button();
            this.eButtonSelectAuthor = new System.Windows.Forms.Button();
            this.textBox_Author_Edit = new System.Windows.Forms.TextBox();
            this.comboBox_Genre_Edit = new System.Windows.Forms.ComboBox();
            this.numericUpDown_Quantity_Edit = new System.Windows.Forms.NumericUpDown();
            this.button_SelectCover_Edit = new System.Windows.Forms.Button();
            this.label13 = new System.Windows.Forms.Label();
            this.textBox_Publisher_Edit = new System.Windows.Forms.TextBox();
            this.pictureBox_Cover_Edit = new System.Windows.Forms.PictureBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.dateTimePicker_DateReceived_Edit = new System.Windows.Forms.DateTimePicker();
            this.textBox_Price_Edit = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.richTextBox_Description_Edit = new System.Windows.Forms.RichTextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.textBox_Title_Edit = new System.Windows.Forms.TextBox();
            this.label21 = new System.Windows.Forms.Label();
            this.textBox_ID_Edit = new System.Windows.Forms.TextBox();
            this.label22 = new System.Windows.Forms.Label();
            this.textBox_ISBN_Edit = new System.Windows.Forms.TextBox();
            this.label23 = new System.Windows.Forms.Label();
            this.label_close_books = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.panel1.SuspendLayout();
            this.panel_add.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_BookQuantity)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBookCover)).BeginInit();
            this.panel_ShowBooks.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_ShowBooks)).BeginInit();
            this.panel_edit.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_Quantity_Edit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Cover_Edit)).BeginInit();
            this.SuspendLayout();
            // 
            // label_header_books
            // 
            this.label_header_books.BackColor = System.Drawing.Color.SteelBlue;
            this.label_header_books.Dock = System.Windows.Forms.DockStyle.Top;
            this.label_header_books.Font = new System.Drawing.Font("Comic Sans MS", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_header_books.ForeColor = System.Drawing.Color.White;
            this.label_header_books.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label_header_books.Location = new System.Drawing.Point(0, 0);
            this.label_header_books.Name = "label_header_books";
            this.label_header_books.Size = new System.Drawing.Size(1263, 76);
            this.label_header_books.TabIndex = 3;
            this.label_header_books.Text = "      Books";
            this.label_header_books.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(50)))), ((int)(((byte)(67)))));
            this.panel1.Controls.Add(this.btnExportBooks);
            this.panel1.Controls.Add(this.button_show_book);
            this.panel1.Controls.Add(this.label_booksCount);
            this.panel1.Controls.Add(this.btnAddBook);
            this.panel1.Controls.Add(this.btnDeleteBook);
            this.panel1.Controls.Add(this.btnEditBook);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 76);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(142, 417);
            this.panel1.TabIndex = 6;
            // 
            // btnExportBooks
            // 
            this.btnExportBooks.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExportBooks.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExportBooks.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnExportBooks.Location = new System.Drawing.Point(8, 241);
            this.btnExportBooks.Name = "btnExportBooks";
            this.btnExportBooks.Size = new System.Drawing.Size(127, 68);
            this.btnExportBooks.TabIndex = 53;
            this.btnExportBooks.Text = "Export to .txt file";
            this.btnExportBooks.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnExportBooks.UseVisualStyleBackColor = true;
            this.btnExportBooks.Click += new System.EventHandler(this.btnExportBooks_Click);
            // 
            // button_show_book
            // 
            this.button_show_book.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_show_book.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_show_book.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_show_book.Location = new System.Drawing.Point(8, 132);
            this.button_show_book.Name = "button_show_book";
            this.button_show_book.Size = new System.Drawing.Size(127, 48);
            this.button_show_book.TabIndex = 51;
            this.button_show_book.Text = "Show books";
            this.button_show_book.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button_show_book.UseVisualStyleBackColor = true;
            this.button_show_book.Click += new System.EventHandler(this.button_show_book_Click);
            // 
            // label_booksCount
            // 
            this.label_booksCount.Font = new System.Drawing.Font("Times New Roman", 17.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_booksCount.ForeColor = System.Drawing.Color.Gold;
            this.label_booksCount.Location = new System.Drawing.Point(9, 365);
            this.label_booksCount.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_booksCount.Name = "label_booksCount";
            this.label_booksCount.Size = new System.Drawing.Size(126, 45);
            this.label_booksCount.TabIndex = 50;
            this.label_booksCount.Text = "999 Books";
            this.label_booksCount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnAddBook
            // 
            this.btnAddBook.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddBook.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddBook.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAddBook.Location = new System.Drawing.Point(8, 18);
            this.btnAddBook.Name = "btnAddBook";
            this.btnAddBook.Size = new System.Drawing.Size(127, 48);
            this.btnAddBook.TabIndex = 9;
            this.btnAddBook.Text = " Add";
            this.btnAddBook.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAddBook.UseVisualStyleBackColor = true;
            this.btnAddBook.Click += new System.EventHandler(this.btnAddBook_Click);
            // 
            // btnDeleteBook
            // 
            this.btnDeleteBook.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDeleteBook.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteBook.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDeleteBook.Location = new System.Drawing.Point(8, 187);
            this.btnDeleteBook.Name = "btnDeleteBook";
            this.btnDeleteBook.Size = new System.Drawing.Size(127, 48);
            this.btnDeleteBook.TabIndex = 11;
            this.btnDeleteBook.Text = " Delete";
            this.btnDeleteBook.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnDeleteBook.UseVisualStyleBackColor = true;
            this.btnDeleteBook.Click += new System.EventHandler(this.btnDeleteBook_Click);
            // 
            // btnEditBook
            // 
            this.btnEditBook.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEditBook.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditBook.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEditBook.Location = new System.Drawing.Point(8, 76);
            this.btnEditBook.Name = "btnEditBook";
            this.btnEditBook.Size = new System.Drawing.Size(127, 48);
            this.btnEditBook.TabIndex = 10;
            this.btnEditBook.Text = " Edit";
            this.btnEditBook.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnEditBook.UseVisualStyleBackColor = true;
            this.btnEditBook.Click += new System.EventHandler(this.btnEditBook_Click);
            // 
            // panel_add
            // 
            this.panel_add.BackColor = System.Drawing.Color.Peru;
            this.panel_add.Controls.Add(this.btnClearFields);
            this.panel_add.Controls.Add(this.txtAuthorID);
            this.panel_add.Controls.Add(this.btnAddNewBook);
            this.panel_add.Controls.Add(this.btnSelectAuthor);
            this.panel_add.Controls.Add(this.txtBookAuthor);
            this.panel_add.Controls.Add(this.comboBoxBookGenre);
            this.panel_add.Controls.Add(this.numericUpDown_BookQuantity);
            this.panel_add.Controls.Add(this.btnSelectCover);
            this.panel_add.Controls.Add(this.label9);
            this.panel_add.Controls.Add(this.txtBookPublisher);
            this.panel_add.Controls.Add(this.pictureBookCover);
            this.panel_add.Controls.Add(this.label8);
            this.panel_add.Controls.Add(this.label7);
            this.panel_add.Controls.Add(this.dateTimePicker_Books);
            this.panel_add.Controls.Add(this.txtBookPrice);
            this.panel_add.Controls.Add(this.label4);
            this.panel_add.Controls.Add(this.label5);
            this.panel_add.Controls.Add(this.label6);
            this.panel_add.Controls.Add(this.richTextBox_BookDescription);
            this.panel_add.Controls.Add(this.label2);
            this.panel_add.Controls.Add(this.label3);
            this.panel_add.Controls.Add(this.txtBookTitle);
            this.panel_add.Controls.Add(this.label1);
            this.panel_add.Controls.Add(this.txtBookID);
            this.panel_add.Controls.Add(this.labelID);
            this.panel_add.Controls.Add(this.txtBookISBN);
            this.panel_add.Controls.Add(this.labeName);
            this.panel_add.Location = new System.Drawing.Point(148, 81);
            this.panel_add.Name = "panel_add";
            this.panel_add.Size = new System.Drawing.Size(1110, 405);
            this.panel_add.TabIndex = 7;
            this.panel_add.Paint += new System.Windows.Forms.PaintEventHandler(this.panel_add_Paint);
            // 
            // btnClearFields
            // 
            this.btnClearFields.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnClearFields.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClearFields.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClearFields.Font = new System.Drawing.Font("Mongolian Baiti", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClearFields.ForeColor = System.Drawing.Color.White;
            this.btnClearFields.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClearFields.Location = new System.Drawing.Point(544, 358);
            this.btnClearFields.Name = "btnClearFields";
            this.btnClearFields.Size = new System.Drawing.Size(253, 40);
            this.btnClearFields.TabIndex = 49;
            this.btnClearFields.Text = "Clear Fields";
            this.btnClearFields.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnClearFields.UseVisualStyleBackColor = false;
            this.btnClearFields.Click += new System.EventHandler(this.btnClearFields_Click);
            // 
            // txtAuthorID
            // 
            this.txtAuthorID.AutoSize = true;
            this.txtAuthorID.Font = new System.Drawing.Font("Mongolian Baiti", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAuthorID.Location = new System.Drawing.Point(287, 173);
            this.txtAuthorID.Name = "txtAuthorID";
            this.txtAuthorID.Size = new System.Drawing.Size(41, 23);
            this.txtAuthorID.TabIndex = 48;
            this.txtAuthorID.Text = "ID:";
            // 
            // btnAddNewBook
            // 
            this.btnAddNewBook.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(203)))), ((int)(((byte)(167)))));
            this.btnAddNewBook.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddNewBook.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddNewBook.Font = new System.Drawing.Font("Mongolian Baiti", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddNewBook.ForeColor = System.Drawing.Color.White;
            this.btnAddNewBook.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAddNewBook.Location = new System.Drawing.Point(110, 358);
            this.btnAddNewBook.Name = "btnAddNewBook";
            this.btnAddNewBook.Size = new System.Drawing.Size(253, 40);
            this.btnAddNewBook.TabIndex = 12;
            this.btnAddNewBook.Text = "Add Book";
            this.btnAddNewBook.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAddNewBook.UseVisualStyleBackColor = false;
            this.btnAddNewBook.Click += new System.EventHandler(this.btnAddNewBook_Click);
            // 
            // btnSelectAuthor
            // 
            this.btnSelectAuthor.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSelectAuthor.Font = new System.Drawing.Font("Mongolian Baiti", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSelectAuthor.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSelectAuthor.Location = new System.Drawing.Point(369, 170);
            this.btnSelectAuthor.Name = "btnSelectAuthor";
            this.btnSelectAuthor.Size = new System.Drawing.Size(121, 32);
            this.btnSelectAuthor.TabIndex = 13;
            this.btnSelectAuthor.Text = "Select Author";
            this.btnSelectAuthor.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSelectAuthor.UseVisualStyleBackColor = true;
            this.btnSelectAuthor.Click += new System.EventHandler(this.btnSelectAuthor_Click);
            // 
            // txtBookAuthor
            // 
            this.txtBookAuthor.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBookAuthor.Location = new System.Drawing.Point(110, 170);
            this.txtBookAuthor.Name = "txtBookAuthor";
            this.txtBookAuthor.Size = new System.Drawing.Size(171, 32);
            this.txtBookAuthor.TabIndex = 47;
            // 
            // comboBoxBookGenre
            // 
            this.comboBoxBookGenre.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxBookGenre.FormattingEnabled = true;
            this.comboBoxBookGenre.Location = new System.Drawing.Point(110, 217);
            this.comboBoxBookGenre.Name = "comboBoxBookGenre";
            this.comboBoxBookGenre.Size = new System.Drawing.Size(253, 31);
            this.comboBoxBookGenre.TabIndex = 46;
            // 
            // numericUpDown_BookQuantity
            // 
            this.numericUpDown_BookQuantity.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericUpDown_BookQuantity.Location = new System.Drawing.Point(110, 265);
            this.numericUpDown_BookQuantity.Name = "numericUpDown_BookQuantity";
            this.numericUpDown_BookQuantity.Size = new System.Drawing.Size(139, 32);
            this.numericUpDown_BookQuantity.TabIndex = 44;
            // 
            // btnSelectCover
            // 
            this.btnSelectCover.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSelectCover.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSelectCover.Location = new System.Drawing.Point(826, 323);
            this.btnSelectCover.Name = "btnSelectCover";
            this.btnSelectCover.Size = new System.Drawing.Size(234, 34);
            this.btnSelectCover.TabIndex = 13;
            this.btnSelectCover.Text = "Select Cover";
            this.btnSelectCover.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSelectCover.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSelectCover.UseVisualStyleBackColor = true;
            this.btnSelectCover.Click += new System.EventHandler(this.btnSelectCover_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Mongolian Baiti", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(909, 20);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(67, 23);
            this.label9.TabIndex = 43;
            this.label9.Text = "Cover";
            // 
            // txtBookPublisher
            // 
            this.txtBookPublisher.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBookPublisher.Location = new System.Drawing.Point(544, 26);
            this.txtBookPublisher.Name = "txtBookPublisher";
            this.txtBookPublisher.Size = new System.Drawing.Size(253, 32);
            this.txtBookPublisher.TabIndex = 42;
            // 
            // pictureBookCover
            // 
            this.pictureBookCover.BackColor = System.Drawing.Color.Gray;
            this.pictureBookCover.Image = global::LibraryManagementSystem.Properties.Resources.bookcover;
            this.pictureBookCover.InitialImage = null;
            this.pictureBookCover.Location = new System.Drawing.Point(826, 54);
            this.pictureBookCover.Name = "pictureBookCover";
            this.pictureBookCover.Size = new System.Drawing.Size(234, 263);
            this.pictureBookCover.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBookCover.TabIndex = 41;
            this.pictureBookCover.TabStop = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Mongolian Baiti", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(386, 77);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(152, 23);
            this.label8.TabIndex = 40;
            this.label8.Text = "Date Received:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Mongolian Baiti", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(431, 32);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(107, 23);
            this.label7.TabIndex = 38;
            this.label7.Text = "Publisher:";
            // 
            // dateTimePicker_Books
            // 
            this.dateTimePicker_Books.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker_Books.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker_Books.Location = new System.Drawing.Point(544, 76);
            this.dateTimePicker_Books.Name = "dateTimePicker_Books";
            this.dateTimePicker_Books.Size = new System.Drawing.Size(253, 26);
            this.dateTimePicker_Books.TabIndex = 37;
            // 
            // txtBookPrice
            // 
            this.txtBookPrice.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBookPrice.Location = new System.Drawing.Point(110, 311);
            this.txtBookPrice.Name = "txtBookPrice";
            this.txtBookPrice.Size = new System.Drawing.Size(253, 32);
            this.txtBookPrice.TabIndex = 34;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Mongolian Baiti", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(39, 314);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 23);
            this.label4.TabIndex = 36;
            this.label4.Text = "Price:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Mongolian Baiti", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(4, 267);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(100, 23);
            this.label5.TabIndex = 35;
            this.label5.Text = "Quantity:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Mongolian Baiti", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(31, 220);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(73, 23);
            this.label6.TabIndex = 31;
            this.label6.Text = "Genre:";
            // 
            // richTextBox_BookDescription
            // 
            this.richTextBox_BookDescription.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBox_BookDescription.Location = new System.Drawing.Point(544, 120);
            this.richTextBox_BookDescription.Name = "richTextBox_BookDescription";
            this.richTextBox_BookDescription.Size = new System.Drawing.Size(253, 216);
            this.richTextBox_BookDescription.TabIndex = 26;
            this.richTextBox_BookDescription.Text = "";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Mongolian Baiti", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(411, 126);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(127, 23);
            this.label2.TabIndex = 29;
            this.label2.Text = "Description:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Mongolian Baiti", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(20, 173);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 23);
            this.label3.TabIndex = 28;
            this.label3.Text = "Author:";
            // 
            // txtBookTitle
            // 
            this.txtBookTitle.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBookTitle.Location = new System.Drawing.Point(110, 120);
            this.txtBookTitle.Name = "txtBookTitle";
            this.txtBookTitle.Size = new System.Drawing.Size(253, 32);
            this.txtBookTitle.TabIndex = 23;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Mongolian Baiti", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(42, 126);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 23);
            this.label1.TabIndex = 27;
            this.label1.Text = "Title:";
            // 
            // txtBookID
            // 
            this.txtBookID.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBookID.Location = new System.Drawing.Point(110, 29);
            this.txtBookID.Name = "txtBookID";
            this.txtBookID.Size = new System.Drawing.Size(80, 32);
            this.txtBookID.TabIndex = 30;
            // 
            // labelID
            // 
            this.labelID.AutoSize = true;
            this.labelID.Font = new System.Drawing.Font("Mongolian Baiti", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelID.Location = new System.Drawing.Point(63, 32);
            this.labelID.Name = "labelID";
            this.labelID.Size = new System.Drawing.Size(41, 23);
            this.labelID.TabIndex = 24;
            this.labelID.Text = "ID:";
            // 
            // txtBookISBN
            // 
            this.txtBookISBN.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBookISBN.Location = new System.Drawing.Point(110, 74);
            this.txtBookISBN.Name = "txtBookISBN";
            this.txtBookISBN.Size = new System.Drawing.Size(253, 32);
            this.txtBookISBN.TabIndex = 22;
            // 
            // labeName
            // 
            this.labeName.AutoSize = true;
            this.labeName.Font = new System.Drawing.Font("Mongolian Baiti", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labeName.Location = new System.Drawing.Point(35, 79);
            this.labeName.Name = "labeName";
            this.labeName.Size = new System.Drawing.Size(69, 23);
            this.labeName.TabIndex = 21;
            this.labeName.Text = "ISBN:";
            // 
            // panel_ShowBooks
            // 
            this.panel_ShowBooks.BackColor = System.Drawing.Color.Tan;
            this.panel_ShowBooks.Controls.Add(this.button_RemoveBook);
            this.panel_ShowBooks.Controls.Add(this.button_editBook_);
            this.panel_ShowBooks.Controls.Add(this.dataGridView_ShowBooks);
            this.panel_ShowBooks.Location = new System.Drawing.Point(149, 83);
            this.panel_ShowBooks.Name = "panel_ShowBooks";
            this.panel_ShowBooks.Size = new System.Drawing.Size(1110, 405);
            this.panel_ShowBooks.TabIndex = 51;
            // 
            // button_RemoveBook
            // 
            this.button_RemoveBook.BackColor = System.Drawing.Color.Red;
            this.button_RemoveBook.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_RemoveBook.Font = new System.Drawing.Font("Mongolian Baiti", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_RemoveBook.ForeColor = System.Drawing.Color.White;
            this.button_RemoveBook.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_RemoveBook.Location = new System.Drawing.Point(542, 339);
            this.button_RemoveBook.Name = "button_RemoveBook";
            this.button_RemoveBook.Size = new System.Drawing.Size(516, 48);
            this.button_RemoveBook.TabIndex = 55;
            this.button_RemoveBook.Text = "Remove this book";
            this.button_RemoveBook.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button_RemoveBook.UseVisualStyleBackColor = false;
            this.button_RemoveBook.Click += new System.EventHandler(this.button_RemoveBook_Click);
            // 
            // button_editBook_
            // 
            this.button_editBook_.BackColor = System.Drawing.Color.DodgerBlue;
            this.button_editBook_.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_editBook_.Font = new System.Drawing.Font("Mongolian Baiti", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_editBook_.ForeColor = System.Drawing.Color.White;
            this.button_editBook_.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_editBook_.Location = new System.Drawing.Point(22, 339);
            this.button_editBook_.Name = "button_editBook_";
            this.button_editBook_.Size = new System.Drawing.Size(509, 48);
            this.button_editBook_.TabIndex = 54;
            this.button_editBook_.Text = "Edit this book";
            this.button_editBook_.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button_editBook_.UseVisualStyleBackColor = false;
            this.button_editBook_.Click += new System.EventHandler(this.button_editBook__Click);
            // 
            // dataGridView_ShowBooks
            // 
            this.dataGridView_ShowBooks.AllowUserToAddRows = false;
            this.dataGridView_ShowBooks.AllowUserToDeleteRows = false;
            this.dataGridView_ShowBooks.AllowUserToResizeRows = false;
            this.dataGridView_ShowBooks.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView_ShowBooks.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_ShowBooks.Location = new System.Drawing.Point(0, 0);
            this.dataGridView_ShowBooks.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridView_ShowBooks.Name = "dataGridView_ShowBooks";
            this.dataGridView_ShowBooks.ReadOnly = true;
            this.dataGridView_ShowBooks.RowHeadersWidth = 51;
            this.dataGridView_ShowBooks.RowTemplate.Height = 24;
            this.dataGridView_ShowBooks.Size = new System.Drawing.Size(1078, 325);
            this.dataGridView_ShowBooks.TabIndex = 0;
            // 
            // panel_edit
            // 
            this.panel_edit.BackColor = System.Drawing.Color.RosyBrown;
            this.panel_edit.Controls.Add(this.button_searchByIsbn);
            this.panel_edit.Controls.Add(this.button_searchById);
            this.panel_edit.Controls.Add(this.label_AuthorId_Edit);
            this.panel_edit.Controls.Add(this.button_EditBook);
            this.panel_edit.Controls.Add(this.eButtonSelectAuthor);
            this.panel_edit.Controls.Add(this.textBox_Author_Edit);
            this.panel_edit.Controls.Add(this.comboBox_Genre_Edit);
            this.panel_edit.Controls.Add(this.numericUpDown_Quantity_Edit);
            this.panel_edit.Controls.Add(this.button_SelectCover_Edit);
            this.panel_edit.Controls.Add(this.label13);
            this.panel_edit.Controls.Add(this.textBox_Publisher_Edit);
            this.panel_edit.Controls.Add(this.pictureBox_Cover_Edit);
            this.panel_edit.Controls.Add(this.label14);
            this.panel_edit.Controls.Add(this.label15);
            this.panel_edit.Controls.Add(this.dateTimePicker_DateReceived_Edit);
            this.panel_edit.Controls.Add(this.textBox_Price_Edit);
            this.panel_edit.Controls.Add(this.label16);
            this.panel_edit.Controls.Add(this.label17);
            this.panel_edit.Controls.Add(this.label18);
            this.panel_edit.Controls.Add(this.richTextBox_Description_Edit);
            this.panel_edit.Controls.Add(this.label19);
            this.panel_edit.Controls.Add(this.label20);
            this.panel_edit.Controls.Add(this.textBox_Title_Edit);
            this.panel_edit.Controls.Add(this.label21);
            this.panel_edit.Controls.Add(this.textBox_ID_Edit);
            this.panel_edit.Controls.Add(this.label22);
            this.panel_edit.Controls.Add(this.textBox_ISBN_Edit);
            this.panel_edit.Controls.Add(this.label23);
            this.panel_edit.Location = new System.Drawing.Point(148, 81);
            this.panel_edit.Name = "panel_edit";
            this.panel_edit.Size = new System.Drawing.Size(1110, 405);
            this.panel_edit.TabIndex = 51;
            // 
            // button_searchByIsbn
            // 
            this.button_searchByIsbn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_searchByIsbn.Font = new System.Drawing.Font("Mongolian Baiti", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_searchByIsbn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_searchByIsbn.Location = new System.Drawing.Point(205, 75);
            this.button_searchByIsbn.Name = "button_searchByIsbn";
            this.button_searchByIsbn.Size = new System.Drawing.Size(176, 32);
            this.button_searchByIsbn.TabIndex = 51;
            this.button_searchByIsbn.Text = "Select Book By ISBN";
            this.button_searchByIsbn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button_searchByIsbn.UseVisualStyleBackColor = true;
            this.button_searchByIsbn.Click += new System.EventHandler(this.button_searchByIsbn_Click);
            // 
            // button_searchById
            // 
            this.button_searchById.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_searchById.Font = new System.Drawing.Font("Mongolian Baiti", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_searchById.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_searchById.Location = new System.Drawing.Point(242, 28);
            this.button_searchById.Name = "button_searchById";
            this.button_searchById.Size = new System.Drawing.Size(139, 32);
            this.button_searchById.TabIndex = 50;
            this.button_searchById.Text = "Select Book By";
            this.button_searchById.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button_searchById.UseVisualStyleBackColor = true;
            this.button_searchById.Click += new System.EventHandler(this.button_searchById_Click);
            // 
            // label_AuthorId_Edit
            // 
            this.label_AuthorId_Edit.AutoSize = true;
            this.label_AuthorId_Edit.Font = new System.Drawing.Font("Mongolian Baiti", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_AuthorId_Edit.Location = new System.Drawing.Point(307, 172);
            this.label_AuthorId_Edit.Name = "label_AuthorId_Edit";
            this.label_AuthorId_Edit.Size = new System.Drawing.Size(41, 23);
            this.label_AuthorId_Edit.TabIndex = 48;
            this.label_AuthorId_Edit.Text = "ID:";
            // 
            // button_EditBook
            // 
            this.button_EditBook.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(203)))), ((int)(((byte)(167)))));
            this.button_EditBook.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_EditBook.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_EditBook.Font = new System.Drawing.Font("Mongolian Baiti", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_EditBook.ForeColor = System.Drawing.Color.White;
            this.button_EditBook.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_EditBook.Location = new System.Drawing.Point(110, 358);
            this.button_EditBook.Name = "button_EditBook";
            this.button_EditBook.Size = new System.Drawing.Size(950, 40);
            this.button_EditBook.TabIndex = 12;
            this.button_EditBook.Text = "Edit Book";
            this.button_EditBook.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button_EditBook.UseVisualStyleBackColor = false;
            this.button_EditBook.Click += new System.EventHandler(this.button_EditBook_Click);
            // 
            // eButtonSelectAuthor
            // 
            this.eButtonSelectAuthor.Cursor = System.Windows.Forms.Cursors.Hand;
            this.eButtonSelectAuthor.Font = new System.Drawing.Font("Mongolian Baiti", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.eButtonSelectAuthor.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.eButtonSelectAuthor.Location = new System.Drawing.Point(390, 170);
            this.eButtonSelectAuthor.Name = "eButtonSelectAuthor";
            this.eButtonSelectAuthor.Size = new System.Drawing.Size(121, 32);
            this.eButtonSelectAuthor.TabIndex = 13;
            this.eButtonSelectAuthor.Text = "Select Author";
            this.eButtonSelectAuthor.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.eButtonSelectAuthor.UseVisualStyleBackColor = true;
            this.eButtonSelectAuthor.Click += new System.EventHandler(this.eButtonSelectAuthor_Click);
            // 
            // textBox_Author_Edit
            // 
            this.textBox_Author_Edit.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_Author_Edit.Location = new System.Drawing.Point(110, 170);
            this.textBox_Author_Edit.Name = "textBox_Author_Edit";
            this.textBox_Author_Edit.Size = new System.Drawing.Size(192, 32);
            this.textBox_Author_Edit.TabIndex = 47;
            // 
            // comboBox_Genre_Edit
            // 
            this.comboBox_Genre_Edit.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox_Genre_Edit.FormattingEnabled = true;
            this.comboBox_Genre_Edit.Location = new System.Drawing.Point(110, 217);
            this.comboBox_Genre_Edit.Name = "comboBox_Genre_Edit";
            this.comboBox_Genre_Edit.Size = new System.Drawing.Size(271, 31);
            this.comboBox_Genre_Edit.TabIndex = 46;
            // 
            // numericUpDown_Quantity_Edit
            // 
            this.numericUpDown_Quantity_Edit.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericUpDown_Quantity_Edit.Location = new System.Drawing.Point(110, 265);
            this.numericUpDown_Quantity_Edit.Name = "numericUpDown_Quantity_Edit";
            this.numericUpDown_Quantity_Edit.Size = new System.Drawing.Size(270, 32);
            this.numericUpDown_Quantity_Edit.TabIndex = 44;
            // 
            // button_SelectCover_Edit
            // 
            this.button_SelectCover_Edit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_SelectCover_Edit.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_SelectCover_Edit.Location = new System.Drawing.Point(826, 308);
            this.button_SelectCover_Edit.Name = "button_SelectCover_Edit";
            this.button_SelectCover_Edit.Size = new System.Drawing.Size(234, 34);
            this.button_SelectCover_Edit.TabIndex = 13;
            this.button_SelectCover_Edit.Text = "Select Cover";
            this.button_SelectCover_Edit.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button_SelectCover_Edit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button_SelectCover_Edit.UseVisualStyleBackColor = true;
            this.button_SelectCover_Edit.Click += new System.EventHandler(this.button_SelectCover_Edit_Click);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Mongolian Baiti", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(909, 20);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(67, 23);
            this.label13.TabIndex = 43;
            this.label13.Text = "Cover";
            // 
            // textBox_Publisher_Edit
            // 
            this.textBox_Publisher_Edit.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_Publisher_Edit.Location = new System.Drawing.Point(544, 26);
            this.textBox_Publisher_Edit.Name = "textBox_Publisher_Edit";
            this.textBox_Publisher_Edit.Size = new System.Drawing.Size(253, 32);
            this.textBox_Publisher_Edit.TabIndex = 42;
            // 
            // pictureBox_Cover_Edit
            // 
            this.pictureBox_Cover_Edit.BackColor = System.Drawing.Color.Gray;
            this.pictureBox_Cover_Edit.Image = global::LibraryManagementSystem.Properties.Resources.bookcover;
            this.pictureBox_Cover_Edit.InitialImage = null;
            this.pictureBox_Cover_Edit.Location = new System.Drawing.Point(826, 54);
            this.pictureBox_Cover_Edit.Name = "pictureBox_Cover_Edit";
            this.pictureBox_Cover_Edit.Size = new System.Drawing.Size(234, 248);
            this.pictureBox_Cover_Edit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox_Cover_Edit.TabIndex = 41;
            this.pictureBox_Cover_Edit.TabStop = false;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Mongolian Baiti", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(386, 77);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(152, 23);
            this.label14.TabIndex = 40;
            this.label14.Text = "Date Received:";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Mongolian Baiti", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(431, 32);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(107, 23);
            this.label15.TabIndex = 38;
            this.label15.Text = "Publisher:";
            // 
            // dateTimePicker_DateReceived_Edit
            // 
            this.dateTimePicker_DateReceived_Edit.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker_DateReceived_Edit.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker_DateReceived_Edit.Location = new System.Drawing.Point(544, 76);
            this.dateTimePicker_DateReceived_Edit.Name = "dateTimePicker_DateReceived_Edit";
            this.dateTimePicker_DateReceived_Edit.Size = new System.Drawing.Size(253, 26);
            this.dateTimePicker_DateReceived_Edit.TabIndex = 37;
            // 
            // textBox_Price_Edit
            // 
            this.textBox_Price_Edit.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_Price_Edit.Location = new System.Drawing.Point(110, 311);
            this.textBox_Price_Edit.Name = "textBox_Price_Edit";
            this.textBox_Price_Edit.Size = new System.Drawing.Size(271, 32);
            this.textBox_Price_Edit.TabIndex = 34;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Mongolian Baiti", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(39, 314);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(65, 23);
            this.label16.TabIndex = 36;
            this.label16.Text = "Price:";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Mongolian Baiti", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(4, 267);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(100, 23);
            this.label17.TabIndex = 35;
            this.label17.Text = "Quantity:";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Mongolian Baiti", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.Location = new System.Drawing.Point(31, 220);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(73, 23);
            this.label18.TabIndex = 31;
            this.label18.Text = "Genre:";
            // 
            // richTextBox_Description_Edit
            // 
            this.richTextBox_Description_Edit.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBox_Description_Edit.Location = new System.Drawing.Point(544, 120);
            this.richTextBox_Description_Edit.Name = "richTextBox_Description_Edit";
            this.richTextBox_Description_Edit.Size = new System.Drawing.Size(253, 223);
            this.richTextBox_Description_Edit.TabIndex = 26;
            this.richTextBox_Description_Edit.Text = "";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Mongolian Baiti", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.Location = new System.Drawing.Point(411, 126);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(127, 23);
            this.label19.TabIndex = 29;
            this.label19.Text = "Description:";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Mongolian Baiti", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.Location = new System.Drawing.Point(20, 173);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(84, 23);
            this.label20.TabIndex = 28;
            this.label20.Text = "Author:";
            // 
            // textBox_Title_Edit
            // 
            this.textBox_Title_Edit.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_Title_Edit.Location = new System.Drawing.Point(110, 120);
            this.textBox_Title_Edit.Name = "textBox_Title_Edit";
            this.textBox_Title_Edit.Size = new System.Drawing.Size(271, 32);
            this.textBox_Title_Edit.TabIndex = 23;
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Mongolian Baiti", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label21.Location = new System.Drawing.Point(42, 126);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(62, 23);
            this.label21.TabIndex = 27;
            this.label21.Text = "Title:";
            // 
            // textBox_ID_Edit
            // 
            this.textBox_ID_Edit.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_ID_Edit.Location = new System.Drawing.Point(110, 29);
            this.textBox_ID_Edit.Name = "textBox_ID_Edit";
            this.textBox_ID_Edit.Size = new System.Drawing.Size(126, 32);
            this.textBox_ID_Edit.TabIndex = 30;
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Font = new System.Drawing.Font("Mongolian Baiti", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label22.Location = new System.Drawing.Point(63, 32);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(41, 23);
            this.label22.TabIndex = 24;
            this.label22.Text = "ID:";
            // 
            // textBox_ISBN_Edit
            // 
            this.textBox_ISBN_Edit.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_ISBN_Edit.Location = new System.Drawing.Point(110, 74);
            this.textBox_ISBN_Edit.Name = "textBox_ISBN_Edit";
            this.textBox_ISBN_Edit.Size = new System.Drawing.Size(90, 32);
            this.textBox_ISBN_Edit.TabIndex = 22;
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Font = new System.Drawing.Font("Mongolian Baiti", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label23.Location = new System.Drawing.Point(35, 79);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(69, 23);
            this.label23.TabIndex = 21;
            this.label23.Text = "ISBN:";
            // 
            // label_close_books
            // 
            this.label_close_books.AutoSize = true;
            this.label_close_books.BackColor = System.Drawing.Color.SteelBlue;
            this.label_close_books.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label_close_books.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_close_books.ForeColor = System.Drawing.Color.White;
            this.label_close_books.Location = new System.Drawing.Point(1237, 0);
            this.label_close_books.Name = "label_close_books";
            this.label_close_books.Size = new System.Drawing.Size(26, 25);
            this.label_close_books.TabIndex = 8;
            this.label_close_books.Text = "X";
            this.label_close_books.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label_close_books.Click += new System.EventHandler(this.label_close_books_Click);
            this.label_close_books.MouseEnter += new System.EventHandler(this.label_close_books_MouseEnter);
            this.label_close_books.MouseLeave += new System.EventHandler(this.label_close_books_MouseLeave);
            // 
            // ManageBooksForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkGreen;
            this.ClientSize = new System.Drawing.Size(1263, 493);
            this.Controls.Add(this.label_close_books);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label_header_books);
            this.Controls.Add(this.panel_add);
            this.Controls.Add(this.panel_edit);
            this.Controls.Add(this.panel_ShowBooks);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ManageBooksForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ManageBooksForm";
            this.Load += new System.EventHandler(this.ManageBooksForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel_add.ResumeLayout(false);
            this.panel_add.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_BookQuantity)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBookCover)).EndInit();
            this.panel_ShowBooks.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_ShowBooks)).EndInit();
            this.panel_edit.ResumeLayout(false);
            this.panel_edit.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_Quantity_Edit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Cover_Edit)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_header_books;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnAddBook;
        private System.Windows.Forms.Button btnDeleteBook;
        private System.Windows.Forms.Button btnEditBook;
        private System.Windows.Forms.Panel panel_add;
        private System.Windows.Forms.Label label_close_books;
        private System.Windows.Forms.RichTextBox richTextBox_BookDescription;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtBookTitle;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtBookID;
        private System.Windows.Forms.Label labelID;
        private System.Windows.Forms.TextBox txtBookISBN;
        private System.Windows.Forms.Label labeName;
        private System.Windows.Forms.Button btnSelectCover;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtBookPublisher;
        private System.Windows.Forms.PictureBox pictureBookCover;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DateTimePicker dateTimePicker_Books;
        private System.Windows.Forms.TextBox txtBookPrice;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnSelectAuthor;
        private System.Windows.Forms.ComboBox comboBoxBookGenre;
        private System.Windows.Forms.NumericUpDown numericUpDown_BookQuantity;
        private System.Windows.Forms.Button btnAddNewBook;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        public System.Windows.Forms.TextBox txtBookAuthor;
        public System.Windows.Forms.Label txtAuthorID;
        private System.Windows.Forms.Button btnClearFields;
        private System.Windows.Forms.Panel panel_edit;
        public System.Windows.Forms.Label label_AuthorId_Edit;
        private System.Windows.Forms.Button button_EditBook;
        private System.Windows.Forms.Button eButtonSelectAuthor;
        public System.Windows.Forms.TextBox textBox_Author_Edit;
        private System.Windows.Forms.ComboBox comboBox_Genre_Edit;
        private System.Windows.Forms.NumericUpDown numericUpDown_Quantity_Edit;
        private System.Windows.Forms.Button button_SelectCover_Edit;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox textBox_Publisher_Edit;
        private System.Windows.Forms.PictureBox pictureBox_Cover_Edit;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.DateTimePicker dateTimePicker_DateReceived_Edit;
        private System.Windows.Forms.TextBox textBox_Price_Edit;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.RichTextBox richTextBox_Description_Edit;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.TextBox textBox_Title_Edit;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.TextBox textBox_ID_Edit;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.TextBox textBox_ISBN_Edit;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Button button_searchByIsbn;
        private System.Windows.Forms.Button button_searchById;
        private System.Windows.Forms.Button button_show_book;
        public System.Windows.Forms.Label label_booksCount;
        private System.Windows.Forms.Panel panel_ShowBooks;
        private System.Windows.Forms.DataGridView dataGridView_ShowBooks;
        private System.Windows.Forms.Button button_RemoveBook;
        private System.Windows.Forms.Button button_editBook_;
        private System.Windows.Forms.Button btnExportBooks;
    }
}