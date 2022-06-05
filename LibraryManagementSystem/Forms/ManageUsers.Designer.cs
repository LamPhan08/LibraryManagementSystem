
namespace LibraryManagementSystem.Forms
{
    partial class ManageUsers
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
            this.label_close_books = new System.Windows.Forms.Label();
            this.dataGridView_User = new System.Windows.Forms.DataGridView();
            this.txt_username = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_userLastName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_userID = new System.Windows.Forms.TextBox();
            this.labelID = new System.Windows.Forms.Label();
            this.txt_userFirtstName = new System.Windows.Forms.TextBox();
            this.labeName = new System.Windows.Forms.Label();
            this.txt_password = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_repass = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.checkbox_setAdmin = new System.Windows.Forms.CheckBox();
            this.btnUpdateUser = new System.Windows.Forms.Button();
            this.btnAddUser = new System.Windows.Forms.Button();
            this.btnDeleteUser = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_User)).BeginInit();
            this.SuspendLayout();
            // 
            // label_header_books
            // 
            this.label_header_books.BackColor = System.Drawing.Color.SkyBlue;
            this.label_header_books.Dock = System.Windows.Forms.DockStyle.Top;
            this.label_header_books.Font = new System.Drawing.Font("Comic Sans MS", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_header_books.ForeColor = System.Drawing.Color.White;
            this.label_header_books.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label_header_books.Location = new System.Drawing.Point(0, 0);
            this.label_header_books.Name = "label_header_books";
            this.label_header_books.Size = new System.Drawing.Size(866, 76);
            this.label_header_books.TabIndex = 5;
            this.label_header_books.Text = "      Users";
            this.label_header_books.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label_close_books
            // 
            this.label_close_books.AutoSize = true;
            this.label_close_books.BackColor = System.Drawing.Color.SkyBlue;
            this.label_close_books.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label_close_books.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_close_books.ForeColor = System.Drawing.Color.White;
            this.label_close_books.Location = new System.Drawing.Point(828, 9);
            this.label_close_books.Name = "label_close_books";
            this.label_close_books.Size = new System.Drawing.Size(26, 25);
            this.label_close_books.TabIndex = 10;
            this.label_close_books.Text = "X";
            this.label_close_books.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label_close_books.Click += new System.EventHandler(this.label_close_books_Click);
            // 
            // dataGridView_User
            // 
            this.dataGridView_User.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_User.Location = new System.Drawing.Point(418, 95);
            this.dataGridView_User.Name = "dataGridView_User";
            this.dataGridView_User.Size = new System.Drawing.Size(436, 401);
            this.dataGridView_User.TabIndex = 11;
            this.dataGridView_User.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_User_CellClick);
            // 
            // txt_username
            // 
            this.txt_username.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_username.Location = new System.Drawing.Point(146, 239);
            this.txt_username.Name = "txt_username";
            this.txt_username.Size = new System.Drawing.Size(232, 31);
            this.txt_username.TabIndex = 25;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Mongolian Baiti", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(31, 244);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(109, 23);
            this.label3.TabIndex = 27;
            this.label3.Text = "Username:";
            // 
            // txt_userLastName
            // 
            this.txt_userLastName.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_userLastName.Location = new System.Drawing.Point(146, 191);
            this.txt_userLastName.Name = "txt_userLastName";
            this.txt_userLastName.Size = new System.Drawing.Size(232, 31);
            this.txt_userLastName.TabIndex = 23;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Mongolian Baiti", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(24, 196);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 23);
            this.label1.TabIndex = 26;
            this.label1.Text = "Last Name:";
            // 
            // txt_userID
            // 
            this.txt_userID.Enabled = false;
            this.txt_userID.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_userID.Location = new System.Drawing.Point(146, 95);
            this.txt_userID.Name = "txt_userID";
            this.txt_userID.Size = new System.Drawing.Size(80, 31);
            this.txt_userID.TabIndex = 28;
            // 
            // labelID
            // 
            this.labelID.AutoSize = true;
            this.labelID.Font = new System.Drawing.Font("Mongolian Baiti", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelID.Location = new System.Drawing.Point(91, 103);
            this.labelID.Name = "labelID";
            this.labelID.Size = new System.Drawing.Size(41, 23);
            this.labelID.TabIndex = 24;
            this.labelID.Text = "ID:";
            // 
            // txt_userFirtstName
            // 
            this.txt_userFirtstName.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_userFirtstName.Location = new System.Drawing.Point(146, 143);
            this.txt_userFirtstName.Name = "txt_userFirtstName";
            this.txt_userFirtstName.Size = new System.Drawing.Size(232, 31);
            this.txt_userFirtstName.TabIndex = 22;
            // 
            // labeName
            // 
            this.labeName.AutoSize = true;
            this.labeName.Font = new System.Drawing.Font("Mongolian Baiti", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labeName.Location = new System.Drawing.Point(12, 151);
            this.labeName.Name = "labeName";
            this.labeName.Size = new System.Drawing.Size(120, 23);
            this.labeName.TabIndex = 21;
            this.labeName.Text = "First Name:";
            // 
            // txt_password
            // 
            this.txt_password.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_password.Location = new System.Drawing.Point(146, 281);
            this.txt_password.Name = "txt_password";
            this.txt_password.Size = new System.Drawing.Size(232, 31);
            this.txt_password.TabIndex = 29;
            this.txt_password.UseSystemPasswordChar = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Mongolian Baiti", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(34, 281);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 23);
            this.label2.TabIndex = 30;
            this.label2.Text = "Password:";
            // 
            // txt_repass
            // 
            this.txt_repass.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_repass.Location = new System.Drawing.Point(146, 328);
            this.txt_repass.Name = "txt_repass";
            this.txt_repass.Size = new System.Drawing.Size(232, 31);
            this.txt_repass.TabIndex = 31;
            this.txt_repass.UseSystemPasswordChar = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Mongolian Baiti", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(6, 333);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(143, 23);
            this.label4.TabIndex = 32;
            this.label4.Text = "Re-enter pass:";
            // 
            // checkbox_setAdmin
            // 
            this.checkbox_setAdmin.AutoSize = true;
            this.checkbox_setAdmin.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkbox_setAdmin.Location = new System.Drawing.Point(146, 379);
            this.checkbox_setAdmin.Name = "checkbox_setAdmin";
            this.checkbox_setAdmin.Size = new System.Drawing.Size(234, 20);
            this.checkbox_setAdmin.TabIndex = 33;
            this.checkbox_setAdmin.Text = "Grant permission admin to this user";
            this.checkbox_setAdmin.UseVisualStyleBackColor = true;
            this.checkbox_setAdmin.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // btnUpdateUser
            // 
            this.btnUpdateUser.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUpdateUser.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdateUser.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUpdateUser.Location = new System.Drawing.Point(133, 448);
            this.btnUpdateUser.Name = "btnUpdateUser";
            this.btnUpdateUser.Size = new System.Drawing.Size(140, 48);
            this.btnUpdateUser.TabIndex = 36;
            this.btnUpdateUser.Text = " Update";
            this.btnUpdateUser.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnUpdateUser.UseVisualStyleBackColor = true;
            this.btnUpdateUser.Click += new System.EventHandler(this.btnUpdateUser_Click);
            // 
            // btnAddUser
            // 
            this.btnAddUser.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddUser.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddUser.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAddUser.Location = new System.Drawing.Point(5, 448);
            this.btnAddUser.Name = "btnAddUser";
            this.btnAddUser.Size = new System.Drawing.Size(122, 48);
            this.btnAddUser.TabIndex = 34;
            this.btnAddUser.Text = " Add";
            this.btnAddUser.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAddUser.UseVisualStyleBackColor = true;
            this.btnAddUser.Click += new System.EventHandler(this.btnAddUser_Click);
            // 
            // btnDeleteUser
            // 
            this.btnDeleteUser.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDeleteUser.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteUser.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDeleteUser.Location = new System.Drawing.Point(279, 448);
            this.btnDeleteUser.Name = "btnDeleteUser";
            this.btnDeleteUser.Size = new System.Drawing.Size(133, 48);
            this.btnDeleteUser.TabIndex = 35;
            this.btnDeleteUser.Text = " Delete";
            this.btnDeleteUser.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnDeleteUser.UseVisualStyleBackColor = true;
            this.btnDeleteUser.Click += new System.EventHandler(this.btnDeleteUser_Click);
            // 
            // ManageUsers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(866, 508);
            this.Controls.Add(this.btnUpdateUser);
            this.Controls.Add(this.btnAddUser);
            this.Controls.Add(this.btnDeleteUser);
            this.Controls.Add(this.checkbox_setAdmin);
            this.Controls.Add(this.txt_repass);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txt_password);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_username);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_userLastName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_userID);
            this.Controls.Add(this.labelID);
            this.Controls.Add(this.txt_userFirtstName);
            this.Controls.Add(this.labeName);
            this.Controls.Add(this.dataGridView_User);
            this.Controls.Add(this.label_close_books);
            this.Controls.Add(this.label_header_books);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ManageUsers";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ManageUsers";
            this.Load += new System.EventHandler(this.ManageUsers_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_User)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_header_books;
        private System.Windows.Forms.Label label_close_books;
        private System.Windows.Forms.DataGridView dataGridView_User;
        private System.Windows.Forms.TextBox txt_username;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_userLastName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_userID;
        private System.Windows.Forms.Label labelID;
        private System.Windows.Forms.TextBox txt_userFirtstName;
        private System.Windows.Forms.Label labeName;
        private System.Windows.Forms.TextBox txt_password;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_repass;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckBox checkbox_setAdmin;
        private System.Windows.Forms.Button btnUpdateUser;
        private System.Windows.Forms.Button btnAddUser;
        private System.Windows.Forms.Button btnDeleteUser;
    }
}