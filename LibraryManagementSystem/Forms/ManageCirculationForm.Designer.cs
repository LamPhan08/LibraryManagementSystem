
namespace LibraryManagementSystem.Forms
{
    partial class ManageCirculationForm
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
            this.btn_issue = new System.Windows.Forms.Button();
            this.btn_return = new System.Windows.Forms.Button();
            this.panel_issue = new System.Windows.Forms.Panel();
            this.btn_SearchMember = new System.Windows.Forms.Button();
            this.btn_SearchBook = new System.Windows.Forms.Button();
            this.btn_IssueBook = new System.Windows.Forms.Button();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.dateTimePicker_Return = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker_Issue = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label_memberFullName = new System.Windows.Forms.Label();
            this.label_bookTitle = new System.Windows.Forms.Label();
            this.numericUpDown_memberID = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.numericUpDown_BookID = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.label_close_books = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel_issue.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_memberID)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_BookID)).BeginInit();
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
            this.label_header_books.Size = new System.Drawing.Size(982, 76);
            this.label_header_books.TabIndex = 4;
            this.label_header_books.Text = "      Circulation";
            this.label_header_books.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label_header_books.Click += new System.EventHandler(this.label_header_books_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(50)))), ((int)(((byte)(67)))));
            this.panel1.Controls.Add(this.btn_issue);
            this.panel1.Controls.Add(this.btn_return);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 76);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(142, 412);
            this.panel1.TabIndex = 7;
            // 
            // btn_issue
            // 
            this.btn_issue.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_issue.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_issue.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_issue.Location = new System.Drawing.Point(8, 18);
            this.btn_issue.Name = "btn_issue";
            this.btn_issue.Size = new System.Drawing.Size(127, 48);
            this.btn_issue.TabIndex = 9;
            this.btn_issue.Text = " Issue";
            this.btn_issue.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_issue.UseVisualStyleBackColor = true;
            // 
            // btn_return
            // 
            this.btn_return.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_return.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_return.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_return.Location = new System.Drawing.Point(8, 76);
            this.btn_return.Name = "btn_return";
            this.btn_return.Size = new System.Drawing.Size(127, 48);
            this.btn_return.TabIndex = 10;
            this.btn_return.Text = " Return";
            this.btn_return.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_return.UseVisualStyleBackColor = true;
            // 
            // panel_issue
            // 
            this.panel_issue.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel_issue.Controls.Add(this.btn_SearchMember);
            this.panel_issue.Controls.Add(this.btn_SearchBook);
            this.panel_issue.Controls.Add(this.btn_IssueBook);
            this.panel_issue.Controls.Add(this.richTextBox1);
            this.panel_issue.Controls.Add(this.dateTimePicker_Return);
            this.panel_issue.Controls.Add(this.dateTimePicker_Issue);
            this.panel_issue.Controls.Add(this.label7);
            this.panel_issue.Controls.Add(this.label6);
            this.panel_issue.Controls.Add(this.label4);
            this.panel_issue.Controls.Add(this.label3);
            this.panel_issue.Controls.Add(this.label2);
            this.panel_issue.Controls.Add(this.label_memberFullName);
            this.panel_issue.Controls.Add(this.label_bookTitle);
            this.panel_issue.Controls.Add(this.numericUpDown_memberID);
            this.panel_issue.Controls.Add(this.label1);
            this.panel_issue.Controls.Add(this.numericUpDown_BookID);
            this.panel_issue.Controls.Add(this.label5);
            this.panel_issue.Location = new System.Drawing.Point(148, 79);
            this.panel_issue.Name = "panel_issue";
            this.panel_issue.Size = new System.Drawing.Size(830, 409);
            this.panel_issue.TabIndex = 8;
            this.panel_issue.Paint += new System.Windows.Forms.PaintEventHandler(this.panel_issue_Paint);
            // 
            // btn_SearchMember
            // 
            this.btn_SearchMember.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_SearchMember.Font = new System.Drawing.Font("Mongolian Baiti", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_SearchMember.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_SearchMember.Location = new System.Drawing.Point(404, 82);
            this.btn_SearchMember.Name = "btn_SearchMember";
            this.btn_SearchMember.Size = new System.Drawing.Size(121, 32);
            this.btn_SearchMember.TabIndex = 61;
            this.btn_SearchMember.Text = "Search";
            this.btn_SearchMember.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_SearchMember.UseVisualStyleBackColor = true;
            this.btn_SearchMember.Click += new System.EventHandler(this.btn_SearchMember_Click);
            // 
            // btn_SearchBook
            // 
            this.btn_SearchBook.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_SearchBook.Font = new System.Drawing.Font("Mongolian Baiti", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_SearchBook.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_SearchBook.Location = new System.Drawing.Point(404, 14);
            this.btn_SearchBook.Name = "btn_SearchBook";
            this.btn_SearchBook.Size = new System.Drawing.Size(121, 32);
            this.btn_SearchBook.TabIndex = 60;
            this.btn_SearchBook.Text = "Search Book";
            this.btn_SearchBook.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_SearchBook.UseVisualStyleBackColor = true;
            this.btn_SearchBook.Click += new System.EventHandler(this.btn_SearchBook_Click);
            // 
            // btn_IssueBook
            // 
            this.btn_IssueBook.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(203)))), ((int)(((byte)(167)))));
            this.btn_IssueBook.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_IssueBook.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_IssueBook.Font = new System.Drawing.Font("Mongolian Baiti", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_IssueBook.ForeColor = System.Drawing.Color.White;
            this.btn_IssueBook.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_IssueBook.Location = new System.Drawing.Point(70, 357);
            this.btn_IssueBook.Name = "btn_IssueBook";
            this.btn_IssueBook.Size = new System.Drawing.Size(690, 40);
            this.btn_IssueBook.TabIndex = 59;
            this.btn_IssueBook.Text = "Issue Book";
            this.btn_IssueBook.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_IssueBook.UseVisualStyleBackColor = false;
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(219, 265);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(271, 86);
            this.richTextBox1.TabIndex = 58;
            this.richTextBox1.Text = "";
            // 
            // dateTimePicker_Return
            // 
            this.dateTimePicker_Return.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker_Return.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker_Return.Location = new System.Drawing.Point(259, 233);
            this.dateTimePicker_Return.Name = "dateTimePicker_Return";
            this.dateTimePicker_Return.Size = new System.Drawing.Size(139, 26);
            this.dateTimePicker_Return.TabIndex = 57;
            // 
            // dateTimePicker_Issue
            // 
            this.dateTimePicker_Issue.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker_Issue.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker_Issue.Location = new System.Drawing.Point(259, 188);
            this.dateTimePicker_Issue.Name = "dateTimePicker_Issue";
            this.dateTimePicker_Issue.Size = new System.Drawing.Size(139, 26);
            this.dateTimePicker_Issue.TabIndex = 56;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Mongolian Baiti", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(84, 291);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(62, 23);
            this.label7.TabIndex = 55;
            this.label7.Text = "Note:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Mongolian Baiti", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(123, 233);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(130, 23);
            this.label6.TabIndex = 54;
            this.label6.Text = "Return Date:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Mongolian Baiti", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(133, 185);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(120, 23);
            this.label4.TabIndex = 53;
            this.label4.Text = " Issue Date:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Mongolian Baiti", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.LightCoral;
            this.label3.Location = new System.Drawing.Point(255, 147);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(109, 23);
            this.label3.TabIndex = 52;
            this.label3.Text = "Yes Or No";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Mongolian Baiti", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(19, 147);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(236, 23);
            this.label2.TabIndex = 51;
            this.label2.Text = "Is This Book Available:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label_memberFullName
            // 
            this.label_memberFullName.AutoSize = true;
            this.label_memberFullName.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label_memberFullName.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_memberFullName.ForeColor = System.Drawing.Color.LightCoral;
            this.label_memberFullName.Location = new System.Drawing.Point(256, 117);
            this.label_memberFullName.Name = "label_memberFullName";
            this.label_memberFullName.Size = new System.Drawing.Size(132, 16);
            this.label_memberFullName.TabIndex = 50;
            this.label_memberFullName.Text = "Member Full Name";
            this.label_memberFullName.Click += new System.EventHandler(this.label_memberFullName_Click);
            this.label_memberFullName.MouseEnter += new System.EventHandler(this.label_memberFullName_MouseEnter);
            this.label_memberFullName.MouseLeave += new System.EventHandler(this.label_memberFullName_MouseLeave);
            // 
            // label_bookTitle
            // 
            this.label_bookTitle.AutoSize = true;
            this.label_bookTitle.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label_bookTitle.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_bookTitle.ForeColor = System.Drawing.Color.LightCoral;
            this.label_bookTitle.Location = new System.Drawing.Point(256, 50);
            this.label_bookTitle.Name = "label_bookTitle";
            this.label_bookTitle.Size = new System.Drawing.Size(76, 16);
            this.label_bookTitle.TabIndex = 49;
            this.label_bookTitle.Text = "Book Title";
            this.label_bookTitle.Click += new System.EventHandler(this.label_bookTitle_Click);
            this.label_bookTitle.MouseEnter += new System.EventHandler(this.label_bookTitle_MouseEnter);
            this.label_bookTitle.MouseLeave += new System.EventHandler(this.label_bookTitle_MouseLeave);
            // 
            // numericUpDown_memberID
            // 
            this.numericUpDown_memberID.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericUpDown_memberID.Location = new System.Drawing.Point(259, 82);
            this.numericUpDown_memberID.Name = "numericUpDown_memberID";
            this.numericUpDown_memberID.Size = new System.Drawing.Size(139, 32);
            this.numericUpDown_memberID.TabIndex = 48;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Mongolian Baiti", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(42, 82);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(213, 23);
            this.label1.TabIndex = 47;
            this.label1.Text = "Enter the member ID:";
            // 
            // numericUpDown_BookID
            // 
            this.numericUpDown_BookID.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericUpDown_BookID.Location = new System.Drawing.Point(259, 15);
            this.numericUpDown_BookID.Name = "numericUpDown_BookID";
            this.numericUpDown_BookID.Size = new System.Drawing.Size(139, 32);
            this.numericUpDown_BookID.TabIndex = 46;
            this.numericUpDown_BookID.ValueChanged += new System.EventHandler(this.numericUpDown_BookQuantity_ValueChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Mongolian Baiti", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(66, 17);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(187, 23);
            this.label5.TabIndex = 45;
            this.label5.Text = "Enter the book ID:";
            // 
            // label_close_books
            // 
            this.label_close_books.AutoSize = true;
            this.label_close_books.BackColor = System.Drawing.Color.SteelBlue;
            this.label_close_books.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label_close_books.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_close_books.ForeColor = System.Drawing.Color.White;
            this.label_close_books.Location = new System.Drawing.Point(935, 9);
            this.label_close_books.Name = "label_close_books";
            this.label_close_books.Size = new System.Drawing.Size(26, 25);
            this.label_close_books.TabIndex = 9;
            this.label_close_books.Text = "X";
            this.label_close_books.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label_close_books.Click += new System.EventHandler(this.label_close_books_Click);
            // 
            // ManageCirculationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.ClientSize = new System.Drawing.Size(982, 488);
            this.Controls.Add(this.label_close_books);
            this.Controls.Add(this.panel_issue);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label_header_books);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ManageCirculationForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ManageCirculationForm";
            this.Load += new System.EventHandler(this.ManageCirculationForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel_issue.ResumeLayout(false);
            this.panel_issue.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_memberID)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_BookID)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_header_books;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_issue;
        private System.Windows.Forms.Button btn_return;
        private System.Windows.Forms.Panel panel_issue;
        private System.Windows.Forms.Label label_close_books;
        private System.Windows.Forms.NumericUpDown numericUpDown_memberID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown numericUpDown_BookID;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label_memberFullName;
        private System.Windows.Forms.Label label_bookTitle;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.DateTimePicker dateTimePicker_Return;
        private System.Windows.Forms.DateTimePicker dateTimePicker_Issue;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_IssueBook;
        private System.Windows.Forms.Button btn_SearchMember;
        private System.Windows.Forms.Button btn_SearchBook;
    }
}