
namespace LibraryManagementSystem.Forms
{
    partial class MemberInfoCard
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
            this.label_ID = new System.Windows.Forms.Label();
            this.label_fullName = new System.Windows.Forms.Label();
            this.label_gender = new System.Windows.Forms.Label();
            this.label_phone = new System.Windows.Forms.Label();
            this.label_email = new System.Windows.Forms.Label();
            this.label_close_books = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label_ID
            // 
            this.label_ID.AutoSize = true;
            this.label_ID.Font = new System.Drawing.Font("Mongolian Baiti", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_ID.Location = new System.Drawing.Point(12, 9);
            this.label_ID.Name = "label_ID";
            this.label_ID.Size = new System.Drawing.Size(41, 23);
            this.label_ID.TabIndex = 40;
            this.label_ID.Text = "ID:";
            // 
            // label_fullName
            // 
            this.label_fullName.AutoSize = true;
            this.label_fullName.Font = new System.Drawing.Font("Mongolian Baiti", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_fullName.Location = new System.Drawing.Point(12, 43);
            this.label_fullName.Name = "label_fullName";
            this.label_fullName.Size = new System.Drawing.Size(109, 23);
            this.label_fullName.TabIndex = 41;
            this.label_fullName.Text = "FullName:";
            // 
            // label_gender
            // 
            this.label_gender.AutoSize = true;
            this.label_gender.Font = new System.Drawing.Font("Mongolian Baiti", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_gender.Location = new System.Drawing.Point(12, 76);
            this.label_gender.Name = "label_gender";
            this.label_gender.Size = new System.Drawing.Size(85, 23);
            this.label_gender.TabIndex = 42;
            this.label_gender.Text = "Gender:";
            // 
            // label_phone
            // 
            this.label_phone.AutoSize = true;
            this.label_phone.Font = new System.Drawing.Font("Mongolian Baiti", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_phone.Location = new System.Drawing.Point(12, 114);
            this.label_phone.Name = "label_phone";
            this.label_phone.Size = new System.Drawing.Size(76, 23);
            this.label_phone.TabIndex = 43;
            this.label_phone.Text = "Phone:";
            // 
            // label_email
            // 
            this.label_email.AutoSize = true;
            this.label_email.Font = new System.Drawing.Font("Mongolian Baiti", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_email.Location = new System.Drawing.Point(12, 151);
            this.label_email.Name = "label_email";
            this.label_email.Size = new System.Drawing.Size(72, 23);
            this.label_email.TabIndex = 44;
            this.label_email.Text = "Email:";
            // 
            // label_close_books
            // 
            this.label_close_books.AutoSize = true;
            this.label_close_books.BackColor = System.Drawing.Color.LightSalmon;
            this.label_close_books.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label_close_books.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_close_books.ForeColor = System.Drawing.Color.White;
            this.label_close_books.Location = new System.Drawing.Point(374, 7);
            this.label_close_books.Name = "label_close_books";
            this.label_close_books.Size = new System.Drawing.Size(26, 25);
            this.label_close_books.TabIndex = 50;
            this.label_close_books.Text = "X";
            this.label_close_books.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label_close_books.Click += new System.EventHandler(this.label_close_books_Click);
            // 
            // MemberInfoCard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSalmon;
            this.ClientSize = new System.Drawing.Size(429, 217);
            this.Controls.Add(this.label_close_books);
            this.Controls.Add(this.label_email);
            this.Controls.Add(this.label_phone);
            this.Controls.Add(this.label_gender);
            this.Controls.Add(this.label_fullName);
            this.Controls.Add(this.label_ID);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MemberInfoCard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MemberInfoCard";
            this.Load += new System.EventHandler(this.MemberInfoCard_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_ID;
        private System.Windows.Forms.Label label_fullName;
        private System.Windows.Forms.Label label_gender;
        private System.Windows.Forms.Label label_phone;
        private System.Windows.Forms.Label label_email;
        private System.Windows.Forms.Label label_close_books;
    }
}