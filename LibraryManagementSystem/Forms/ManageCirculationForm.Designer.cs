
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
            this.label_header_circulation = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_issue = new System.Windows.Forms.Button();
            this.btn_return = new System.Windows.Forms.Button();
            this.panel_issue = new System.Windows.Forms.Panel();
            this.btn_SearchMember = new System.Windows.Forms.Button();
            this.btn_SearchBook = new System.Windows.Forms.Button();
            this.btn_IssueBook = new System.Windows.Forms.Button();
            this.richTextBox_note = new System.Windows.Forms.RichTextBox();
            this.dateTimePicker_Return = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker_Issue = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label_available = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label_memberFullName = new System.Windows.Forms.Label();
            this.label_bookTitle = new System.Windows.Forms.Label();
            this.numericUpDown_memberID = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.numericUpDown_BookID = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.panel_return = new System.Windows.Forms.Panel();
            this.button_showAll = new System.Windows.Forms.Button();
            this.button_showLost = new System.Windows.Forms.Button();
            this.button_showReturned = new System.Windows.Forms.Button();
            this.button_showIssued = new System.Windows.Forms.Button();
            this.button_booklost = new System.Windows.Forms.Button();
            this.button_return2 = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.button_delete = new System.Windows.Forms.Button();
            this.richTextBox_decription2 = new System.Windows.Forms.RichTextBox();
            this.dateTimePicker_return2 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker_Issue2 = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label_memberFullName2 = new System.Windows.Forms.Label();
            this.label_bookTitle2 = new System.Windows.Forms.Label();
            this.numericUpDown_memberId2 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown_BookId2 = new System.Windows.Forms.NumericUpDown();
            this.dataGridView_issue = new System.Windows.Forms.DataGridView();
            this.bookid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.memid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statut = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.issue_date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.return_date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.note = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label_close_books = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel_issue.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_memberID)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_BookID)).BeginInit();
            this.panel_return.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_memberId2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_BookId2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_issue)).BeginInit();
            this.SuspendLayout();
            // 
            // label_header_circulation
            // 
            this.label_header_circulation.BackColor = System.Drawing.Color.SteelBlue;
            this.label_header_circulation.Dock = System.Windows.Forms.DockStyle.Top;
            this.label_header_circulation.Font = new System.Drawing.Font("Comic Sans MS", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_header_circulation.ForeColor = System.Drawing.Color.White;
            this.label_header_circulation.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label_header_circulation.Location = new System.Drawing.Point(0, 0);
            this.label_header_circulation.Name = "label_header_circulation";
            this.label_header_circulation.Size = new System.Drawing.Size(982, 76);
            this.label_header_circulation.TabIndex = 4;
            this.label_header_circulation.Text = "      Circulation";
            this.label_header_circulation.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label_header_circulation.Click += new System.EventHandler(this.label_header_books_Click);
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
            this.btn_issue.Click += new System.EventHandler(this.btn_issue_Click);
            // 
            // btn_return
            // 
            this.btn_return.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_return.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_return.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btn_return.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_return.Location = new System.Drawing.Point(8, 76);
            this.btn_return.Name = "btn_return";
            this.btn_return.Size = new System.Drawing.Size(127, 48);
            this.btn_return.TabIndex = 10;
            this.btn_return.Text = " Return";
            this.btn_return.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_return.UseVisualStyleBackColor = true;
            this.btn_return.Click += new System.EventHandler(this.btn_return_Click);
            // 
            // panel_issue
            // 
            this.panel_issue.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel_issue.Controls.Add(this.btn_SearchMember);
            this.panel_issue.Controls.Add(this.btn_SearchBook);
            this.panel_issue.Controls.Add(this.btn_IssueBook);
            this.panel_issue.Controls.Add(this.richTextBox_note);
            this.panel_issue.Controls.Add(this.dateTimePicker_Return);
            this.panel_issue.Controls.Add(this.dateTimePicker_Issue);
            this.panel_issue.Controls.Add(this.label7);
            this.panel_issue.Controls.Add(this.label6);
            this.panel_issue.Controls.Add(this.label4);
            this.panel_issue.Controls.Add(this.label_available);
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
            this.btn_IssueBook.Click += new System.EventHandler(this.btn_IssueBook_Click);
            // 
            // richTextBox_note
            // 
            this.richTextBox_note.Location = new System.Drawing.Point(219, 265);
            this.richTextBox_note.Name = "richTextBox_note";
            this.richTextBox_note.Size = new System.Drawing.Size(271, 86);
            this.richTextBox_note.TabIndex = 58;
            this.richTextBox_note.Text = "";
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
            // label_available
            // 
            this.label_available.AutoSize = true;
            this.label_available.Font = new System.Drawing.Font("Mongolian Baiti", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_available.ForeColor = System.Drawing.Color.LightCoral;
            this.label_available.Location = new System.Drawing.Point(255, 147);
            this.label_available.Name = "label_available";
            this.label_available.Size = new System.Drawing.Size(109, 23);
            this.label_available.TabIndex = 52;
            this.label_available.Text = "Yes Or No";
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
            // panel_return
            // 
            this.panel_return.BackColor = System.Drawing.Color.SeaShell;
            this.panel_return.Controls.Add(this.button_showAll);
            this.panel_return.Controls.Add(this.button_showLost);
            this.panel_return.Controls.Add(this.button_showReturned);
            this.panel_return.Controls.Add(this.button_showIssued);
            this.panel_return.Controls.Add(this.button_booklost);
            this.panel_return.Controls.Add(this.button_return2);
            this.panel_return.Controls.Add(this.label11);
            this.panel_return.Controls.Add(this.label10);
            this.panel_return.Controls.Add(this.button_delete);
            this.panel_return.Controls.Add(this.richTextBox_decription2);
            this.panel_return.Controls.Add(this.dateTimePicker_return2);
            this.panel_return.Controls.Add(this.dateTimePicker_Issue2);
            this.panel_return.Controls.Add(this.label3);
            this.panel_return.Controls.Add(this.label8);
            this.panel_return.Controls.Add(this.label9);
            this.panel_return.Controls.Add(this.label_memberFullName2);
            this.panel_return.Controls.Add(this.label_bookTitle2);
            this.panel_return.Controls.Add(this.numericUpDown_memberId2);
            this.panel_return.Controls.Add(this.numericUpDown_BookId2);
            this.panel_return.Controls.Add(this.dataGridView_issue);
            this.panel_return.Location = new System.Drawing.Point(148, 79);
            this.panel_return.Name = "panel_return";
            this.panel_return.Size = new System.Drawing.Size(830, 409);
            this.panel_return.TabIndex = 62;
            // 
            // button_showAll
            // 
            this.button_showAll.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_showAll.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_showAll.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_showAll.Location = new System.Drawing.Point(688, 8);
            this.button_showAll.Name = "button_showAll";
            this.button_showAll.Size = new System.Drawing.Size(129, 34);
            this.button_showAll.TabIndex = 70;
            this.button_showAll.Text = " All";
            this.button_showAll.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button_showAll.UseVisualStyleBackColor = true;
            this.button_showAll.Click += new System.EventHandler(this.button_showAll_Click);
            // 
            // button_showLost
            // 
            this.button_showLost.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_showLost.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_showLost.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_showLost.Location = new System.Drawing.Point(559, 7);
            this.button_showLost.Name = "button_showLost";
            this.button_showLost.Size = new System.Drawing.Size(126, 34);
            this.button_showLost.TabIndex = 69;
            this.button_showLost.Text = " Lost";
            this.button_showLost.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button_showLost.UseVisualStyleBackColor = true;
            this.button_showLost.Click += new System.EventHandler(this.button_showLost_Click);
            // 
            // button_showReturned
            // 
            this.button_showReturned.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_showReturned.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_showReturned.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_showReturned.Location = new System.Drawing.Point(425, 7);
            this.button_showReturned.Name = "button_showReturned";
            this.button_showReturned.Size = new System.Drawing.Size(128, 34);
            this.button_showReturned.TabIndex = 68;
            this.button_showReturned.Text = " Returned";
            this.button_showReturned.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button_showReturned.UseVisualStyleBackColor = true;
            this.button_showReturned.Click += new System.EventHandler(this.button_showReturn);
            // 
            // button_showIssued
            // 
            this.button_showIssued.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_showIssued.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_showIssued.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_showIssued.Location = new System.Drawing.Point(300, 8);
            this.button_showIssued.Name = "button_showIssued";
            this.button_showIssued.Size = new System.Drawing.Size(119, 34);
            this.button_showIssued.TabIndex = 67;
            this.button_showIssued.Text = " Issued";
            this.button_showIssued.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button_showIssued.UseVisualStyleBackColor = true;
            this.button_showIssued.Click += new System.EventHandler(this.button_showIssued_Click);
            // 
            // button_booklost
            // 
            this.button_booklost.BackColor = System.Drawing.Color.Orange;
            this.button_booklost.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_booklost.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_booklost.Font = new System.Drawing.Font("Mongolian Baiti", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_booklost.ForeColor = System.Drawing.Color.White;
            this.button_booklost.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_booklost.Location = new System.Drawing.Point(425, 317);
            this.button_booklost.Name = "button_booklost";
            this.button_booklost.Size = new System.Drawing.Size(313, 40);
            this.button_booklost.TabIndex = 65;
            this.button_booklost.Text = "Book Lost";
            this.button_booklost.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button_booklost.UseVisualStyleBackColor = false;
            this.button_booklost.Click += new System.EventHandler(this.button_BookLost_Click);
            // 
            // button_return2
            // 
            this.button_return2.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.button_return2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_return2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_return2.Font = new System.Drawing.Font("Mongolian Baiti", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_return2.ForeColor = System.Drawing.Color.White;
            this.button_return2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_return2.Location = new System.Drawing.Point(101, 317);
            this.button_return2.Name = "button_return2";
            this.button_return2.Size = new System.Drawing.Size(318, 40);
            this.button_return2.TabIndex = 64;
            this.button_return2.Text = "Return Book";
            this.button_return2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button_return2.UseVisualStyleBackColor = false;
            this.button_return2.Click += new System.EventHandler(this.button_BookReturn);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Mongolian Baiti", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(3, 79);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(130, 23);
            this.label11.TabIndex = 63;
            this.label11.Text = "Memeber Id:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Mongolian Baiti", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(13, 14);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(94, 23);
            this.label10.TabIndex = 62;
            this.label10.Text = "Book Id:";
            // 
            // button_delete
            // 
            this.button_delete.BackColor = System.Drawing.Color.Firebrick;
            this.button_delete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_delete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_delete.Font = new System.Drawing.Font("Mongolian Baiti", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_delete.ForeColor = System.Drawing.Color.White;
            this.button_delete.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_delete.Location = new System.Drawing.Point(101, 363);
            this.button_delete.Name = "button_delete";
            this.button_delete.Size = new System.Drawing.Size(637, 40);
            this.button_delete.TabIndex = 59;
            this.button_delete.Text = "Delete";
            this.button_delete.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button_delete.UseVisualStyleBackColor = false;
            this.button_delete.Click += new System.EventHandler(this.button_delete_Click);
            // 
            // richTextBox_decription2
            // 
            this.richTextBox_decription2.Location = new System.Drawing.Point(84, 205);
            this.richTextBox_decription2.Name = "richTextBox_decription2";
            this.richTextBox_decription2.Size = new System.Drawing.Size(186, 79);
            this.richTextBox_decription2.TabIndex = 58;
            this.richTextBox_decription2.Text = "";
            // 
            // dateTimePicker_return2
            // 
            this.dateTimePicker_return2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker_return2.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker_return2.Location = new System.Drawing.Point(142, 170);
            this.dateTimePicker_return2.Name = "dateTimePicker_return2";
            this.dateTimePicker_return2.Size = new System.Drawing.Size(139, 26);
            this.dateTimePicker_return2.TabIndex = 57;
            // 
            // dateTimePicker_Issue2
            // 
            this.dateTimePicker_Issue2.Enabled = false;
            this.dateTimePicker_Issue2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker_Issue2.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker_Issue2.Location = new System.Drawing.Point(142, 136);
            this.dateTimePicker_Issue2.Name = "dateTimePicker_Issue2";
            this.dateTimePicker_Issue2.Size = new System.Drawing.Size(139, 26);
            this.dateTimePicker_Issue2.TabIndex = 56;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Mongolian Baiti", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(16, 205);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 23);
            this.label3.TabIndex = 55;
            this.label3.Text = "Note:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Mongolian Baiti", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(13, 170);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(130, 23);
            this.label8.TabIndex = 54;
            this.label8.Text = "Return Date:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Mongolian Baiti", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(16, 136);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(120, 23);
            this.label9.TabIndex = 53;
            this.label9.Text = " Issue Date:";
            // 
            // label_memberFullName2
            // 
            this.label_memberFullName2.AutoSize = true;
            this.label_memberFullName2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label_memberFullName2.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_memberFullName2.ForeColor = System.Drawing.Color.LightCoral;
            this.label_memberFullName2.Location = new System.Drawing.Point(139, 114);
            this.label_memberFullName2.Name = "label_memberFullName2";
            this.label_memberFullName2.Size = new System.Drawing.Size(132, 16);
            this.label_memberFullName2.TabIndex = 50;
            this.label_memberFullName2.Text = "Member Full Name";
            // 
            // label_bookTitle2
            // 
            this.label_bookTitle2.AutoSize = true;
            this.label_bookTitle2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label_bookTitle2.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_bookTitle2.ForeColor = System.Drawing.Color.LightCoral;
            this.label_bookTitle2.Location = new System.Drawing.Point(139, 47);
            this.label_bookTitle2.Name = "label_bookTitle2";
            this.label_bookTitle2.Size = new System.Drawing.Size(76, 16);
            this.label_bookTitle2.TabIndex = 49;
            this.label_bookTitle2.Text = "Book Title";
            // 
            // numericUpDown_memberId2
            // 
            this.numericUpDown_memberId2.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericUpDown_memberId2.Location = new System.Drawing.Point(142, 79);
            this.numericUpDown_memberId2.Name = "numericUpDown_memberId2";
            this.numericUpDown_memberId2.Size = new System.Drawing.Size(139, 32);
            this.numericUpDown_memberId2.TabIndex = 48;
            // 
            // numericUpDown_BookId2
            // 
            this.numericUpDown_BookId2.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericUpDown_BookId2.Location = new System.Drawing.Point(142, 10);
            this.numericUpDown_BookId2.Name = "numericUpDown_BookId2";
            this.numericUpDown_BookId2.Size = new System.Drawing.Size(139, 32);
            this.numericUpDown_BookId2.TabIndex = 46;
            // 
            // dataGridView_issue
            // 
            this.dataGridView_issue.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView_issue.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_issue.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.bookid,
            this.memid,
            this.statut,
            this.issue_date,
            this.return_date,
            this.note});
            this.dataGridView_issue.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dataGridView_issue.Location = new System.Drawing.Point(300, 47);
            this.dataGridView_issue.Name = "dataGridView_issue";
            this.dataGridView_issue.Size = new System.Drawing.Size(517, 264);
            this.dataGridView_issue.TabIndex = 66;
            this.dataGridView_issue.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_issue_CellClick);
            // 
            // bookid
            // 
            this.bookid.DataPropertyName = "bookid";
            this.bookid.HeaderText = "Book_Id";
            this.bookid.Name = "bookid";
            // 
            // memid
            // 
            this.memid.DataPropertyName = "memid";
            this.memid.HeaderText = "Member_Id";
            this.memid.Name = "memid";
            // 
            // statut
            // 
            this.statut.DataPropertyName = "statut";
            this.statut.HeaderText = "Status";
            this.statut.Name = "statut";
            // 
            // issue_date
            // 
            this.issue_date.DataPropertyName = "issue_date";
            this.issue_date.HeaderText = "Issue date";
            this.issue_date.Name = "issue_date";
            // 
            // return_date
            // 
            this.return_date.DataPropertyName = "return_date";
            this.return_date.HeaderText = "Return date";
            this.return_date.Name = "return_date";
            // 
            // note
            // 
            this.note.DataPropertyName = "note";
            this.note.HeaderText = "Note";
            this.note.Name = "note";
            // 
            // label_close_books
            // 
            this.label_close_books.AutoSize = true;
            this.label_close_books.BackColor = System.Drawing.Color.SteelBlue;
            this.label_close_books.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label_close_books.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_close_books.ForeColor = System.Drawing.Color.White;
            this.label_close_books.Location = new System.Drawing.Point(956, 0);
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
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label_header_circulation);
            this.Controls.Add(this.panel_return);
            this.Controls.Add(this.panel_issue);
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
            this.panel_return.ResumeLayout(false);
            this.panel_return.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_memberId2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_BookId2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_issue)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_header_circulation;
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
        private System.Windows.Forms.RichTextBox richTextBox_note;
        private System.Windows.Forms.DateTimePicker dateTimePicker_Return;
        private System.Windows.Forms.DateTimePicker dateTimePicker_Issue;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label_available;
        private System.Windows.Forms.Button btn_IssueBook;
        private System.Windows.Forms.Button btn_SearchBook;
        private System.Windows.Forms.Panel panel_return;
        private System.Windows.Forms.Button button_delete;
        private System.Windows.Forms.RichTextBox richTextBox_decription2;
        private System.Windows.Forms.DateTimePicker dateTimePicker_return2;
        private System.Windows.Forms.DateTimePicker dateTimePicker_Issue2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label_memberFullName2;
        private System.Windows.Forms.Label label_bookTitle2;
        private System.Windows.Forms.NumericUpDown numericUpDown_memberId2;
        private System.Windows.Forms.NumericUpDown numericUpDown_BookId2;
        private System.Windows.Forms.Button btn_SearchMember;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button button_booklost;
        private System.Windows.Forms.Button button_return2;
        private System.Windows.Forms.DataGridView dataGridView_issue;
        private System.Windows.Forms.Button button_showLost;
        private System.Windows.Forms.Button button_showReturned;
        private System.Windows.Forms.Button button_showIssued;
        private System.Windows.Forms.Button button_showAll;
        private System.Windows.Forms.DataGridViewTextBoxColumn bookid;
        private System.Windows.Forms.DataGridViewTextBoxColumn memid;
        private System.Windows.Forms.DataGridViewTextBoxColumn statut;
        private System.Windows.Forms.DataGridViewTextBoxColumn issue_date;
        private System.Windows.Forms.DataGridViewTextBoxColumn return_date;
        private System.Windows.Forms.DataGridViewTextBoxColumn note;
    }
}