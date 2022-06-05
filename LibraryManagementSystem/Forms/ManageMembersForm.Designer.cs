namespace LibraryManagementSystem.Forms
{
    partial class ManageMembersForm
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
            this.label3 = new System.Windows.Forms.Label();
            this.txtMemberLastName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtMemberID = new System.Windows.Forms.TextBox();
            this.labelID = new System.Windows.Forms.Label();
            this.labeName = new System.Windows.Forms.Label();
            this.dataGridView_Members = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FIRSTNAME = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LASTNAME = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GENDER_MEMBER = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PHONE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EMAIL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel2 = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioButton_Female = new System.Windows.Forms.RadioButton();
            this.radioButton_Male = new System.Windows.Forms.RadioButton();
            this.textBox_Email = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox_Phone = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtMemberFirstName = new System.Windows.Forms.TextBox();
            this.label_membersCount = new System.Windows.Forms.Label();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnUpdateMember = new System.Windows.Forms.Button();
            this.btnAddMember = new System.Windows.Forms.Button();
            this.btnDeleteMember = new System.Windows.Forms.Button();
            this.btnEditMember = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label_close_members = new System.Windows.Forms.Label();
            this.label_header_members = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Members)).BeginInit();
            this.panel2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Mongolian Baiti", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(63, 180);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 23);
            this.label3.TabIndex = 17;
            this.label3.Text = "Gender:";
            // 
            // txtMemberLastName
            // 
            this.txtMemberLastName.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMemberLastName.Location = new System.Drawing.Point(154, 126);
            this.txtMemberLastName.Name = "txtMemberLastName";
            this.txtMemberLastName.Size = new System.Drawing.Size(253, 31);
            this.txtMemberLastName.TabIndex = 13;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Mongolian Baiti", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(32, 132);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 23);
            this.label1.TabIndex = 15;
            this.label1.Text = "Last Name:";
            // 
            // txtMemberID
            // 
            this.txtMemberID.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMemberID.Location = new System.Drawing.Point(154, 30);
            this.txtMemberID.Name = "txtMemberID";
            this.txtMemberID.Size = new System.Drawing.Size(80, 31);
            this.txtMemberID.TabIndex = 20;
            // 
            // labelID
            // 
            this.labelID.AutoSize = true;
            this.labelID.Font = new System.Drawing.Font("Mongolian Baiti", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelID.Location = new System.Drawing.Point(107, 35);
            this.labelID.Name = "labelID";
            this.labelID.Size = new System.Drawing.Size(41, 23);
            this.labelID.TabIndex = 13;
            this.labelID.Text = "ID:";
            // 
            // labeName
            // 
            this.labeName.AutoSize = true;
            this.labeName.Font = new System.Drawing.Font("Mongolian Baiti", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labeName.Location = new System.Drawing.Point(28, 84);
            this.labeName.Name = "labeName";
            this.labeName.Size = new System.Drawing.Size(120, 23);
            this.labeName.TabIndex = 11;
            this.labeName.Text = "First Name:";
            // 
            // dataGridView_Members
            // 
            this.dataGridView_Members.AllowUserToAddRows = false;
            this.dataGridView_Members.AllowUserToDeleteRows = false;
            this.dataGridView_Members.AllowUserToOrderColumns = true;
            this.dataGridView_Members.AllowUserToResizeRows = false;
            this.dataGridView_Members.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView_Members.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView_Members.BackgroundColor = System.Drawing.SystemColors.ControlDark;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Mongolian Baiti", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView_Members.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView_Members.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_Members.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.FIRSTNAME,
            this.LASTNAME,
            this.GENDER_MEMBER,
            this.PHONE,
            this.EMAIL});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Info;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Red;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView_Members.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView_Members.Location = new System.Drawing.Point(420, 30);
            this.dataGridView_Members.Name = "dataGridView_Members";
            this.dataGridView_Members.ReadOnly = true;
            this.dataGridView_Members.RowHeadersWidth = 51;
            this.dataGridView_Members.Size = new System.Drawing.Size(687, 359);
            this.dataGridView_Members.TabIndex = 23;
            this.dataGridView_Members.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_Members_CellContentClick);
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
            this.ID.Width = 56;
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
            this.FIRSTNAME.Width = 117;
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
            this.LASTNAME.Width = 114;
            // 
            // GENDER_MEMBER
            // 
            this.GENDER_MEMBER.HeaderText = "Gender";
            this.GENDER_MEMBER.Name = "GENDER_MEMBER";
            this.GENDER_MEMBER.ReadOnly = true;
            // 
            // PHONE
            // 
            this.PHONE.HeaderText = "Phone number";
            this.PHONE.Name = "PHONE";
            this.PHONE.ReadOnly = true;
            // 
            // EMAIL
            // 
            this.EMAIL.HeaderText = "Email";
            this.EMAIL.Name = "EMAIL";
            this.EMAIL.ReadOnly = true;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.groupBox1);
            this.panel2.Controls.Add(this.textBox_Email);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.textBox_Phone);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.dataGridView_Members);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.txtMemberLastName);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.txtMemberID);
            this.panel2.Controls.Add(this.labelID);
            this.panel2.Controls.Add(this.txtMemberFirstName);
            this.panel2.Controls.Add(this.labeName);
            this.panel2.Location = new System.Drawing.Point(147, 80);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1115, 396);
            this.panel2.TabIndex = 10;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioButton_Female);
            this.groupBox1.Controls.Add(this.radioButton_Male);
            this.groupBox1.Location = new System.Drawing.Point(155, 164);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(253, 53);
            this.groupBox1.TabIndex = 44;
            this.groupBox1.TabStop = false;
            // 
            // radioButton_Female
            // 
            this.radioButton_Female.AutoSize = true;
            this.radioButton_Female.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton_Female.Location = new System.Drawing.Point(95, 13);
            this.radioButton_Female.Name = "radioButton_Female";
            this.radioButton_Female.Size = new System.Drawing.Size(92, 28);
            this.radioButton_Female.TabIndex = 1;
            this.radioButton_Female.TabStop = true;
            this.radioButton_Female.Text = "Female";
            this.radioButton_Female.UseVisualStyleBackColor = true;
            // 
            // radioButton_Male
            // 
            this.radioButton_Male.AutoSize = true;
            this.radioButton_Male.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton_Male.Location = new System.Drawing.Point(6, 13);
            this.radioButton_Male.Name = "radioButton_Male";
            this.radioButton_Male.Size = new System.Drawing.Size(69, 28);
            this.radioButton_Male.TabIndex = 0;
            this.radioButton_Male.TabStop = true;
            this.radioButton_Male.Text = "Male";
            this.radioButton_Male.UseVisualStyleBackColor = true;
            // 
            // textBox_Email
            // 
            this.textBox_Email.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_Email.Location = new System.Drawing.Point(154, 271);
            this.textBox_Email.Name = "textBox_Email";
            this.textBox_Email.Size = new System.Drawing.Size(253, 31);
            this.textBox_Email.TabIndex = 26;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Mongolian Baiti", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(76, 275);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 23);
            this.label4.TabIndex = 27;
            this.label4.Text = "Email:";
            // 
            // textBox_Phone
            // 
            this.textBox_Phone.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_Phone.Location = new System.Drawing.Point(154, 223);
            this.textBox_Phone.Name = "textBox_Phone";
            this.textBox_Phone.Size = new System.Drawing.Size(253, 31);
            this.textBox_Phone.TabIndex = 24;
            this.textBox_Phone.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_Phone_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Mongolian Baiti", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(72, 228);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 23);
            this.label2.TabIndex = 25;
            this.label2.Text = "Phone:";
            // 
            // txtMemberFirstName
            // 
            this.txtMemberFirstName.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMemberFirstName.Location = new System.Drawing.Point(154, 78);
            this.txtMemberFirstName.Name = "txtMemberFirstName";
            this.txtMemberFirstName.Size = new System.Drawing.Size(253, 31);
            this.txtMemberFirstName.TabIndex = 12;
            // 
            // label_membersCount
            // 
            this.label_membersCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_membersCount.ForeColor = System.Drawing.Color.Gold;
            this.label_membersCount.Location = new System.Drawing.Point(9, 348);
            this.label_membersCount.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_membersCount.Name = "label_membersCount";
            this.label_membersCount.Size = new System.Drawing.Size(126, 45);
            this.label_membersCount.TabIndex = 51;
            this.label_membersCount.Text = "999 Members";
            this.label_membersCount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnClear
            // 
            this.btnClear.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClear.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClear.Location = new System.Drawing.Point(8, 246);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(127, 68);
            this.btnClear.TabIndex = 13;
            this.btnClear.Text = " Clear";
            this.btnClear.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnUpdateMember
            // 
            this.btnUpdateMember.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUpdateMember.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdateMember.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUpdateMember.Location = new System.Drawing.Point(8, 75);
            this.btnUpdateMember.Name = "btnUpdateMember";
            this.btnUpdateMember.Size = new System.Drawing.Size(127, 48);
            this.btnUpdateMember.TabIndex = 12;
            this.btnUpdateMember.Text = " Update";
            this.btnUpdateMember.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnUpdateMember.UseVisualStyleBackColor = true;
            this.btnUpdateMember.Click += new System.EventHandler(this.btnUpdateMember_Click);
            // 
            // btnAddMember
            // 
            this.btnAddMember.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddMember.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddMember.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAddMember.Location = new System.Drawing.Point(8, 18);
            this.btnAddMember.Name = "btnAddMember";
            this.btnAddMember.Size = new System.Drawing.Size(127, 48);
            this.btnAddMember.TabIndex = 9;
            this.btnAddMember.Text = " Add";
            this.btnAddMember.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAddMember.UseVisualStyleBackColor = true;
            this.btnAddMember.Click += new System.EventHandler(this.btnAddMember_Click);
            // 
            // btnDeleteMember
            // 
            this.btnDeleteMember.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDeleteMember.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteMember.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDeleteMember.Location = new System.Drawing.Point(8, 189);
            this.btnDeleteMember.Name = "btnDeleteMember";
            this.btnDeleteMember.Size = new System.Drawing.Size(127, 48);
            this.btnDeleteMember.TabIndex = 11;
            this.btnDeleteMember.Text = " Delete";
            this.btnDeleteMember.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnDeleteMember.UseVisualStyleBackColor = true;
            this.btnDeleteMember.Click += new System.EventHandler(this.btnDeleteMember_Click);
            // 
            // btnEditMember
            // 
            this.btnEditMember.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEditMember.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditMember.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEditMember.Location = new System.Drawing.Point(8, 132);
            this.btnEditMember.Name = "btnEditMember";
            this.btnEditMember.Size = new System.Drawing.Size(127, 48);
            this.btnEditMember.TabIndex = 10;
            this.btnEditMember.Text = " Edit";
            this.btnEditMember.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnEditMember.UseVisualStyleBackColor = true;
            this.btnEditMember.Click += new System.EventHandler(this.btnEditMember_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(50)))), ((int)(((byte)(67)))));
            this.panel1.Controls.Add(this.label_membersCount);
            this.panel1.Controls.Add(this.btnClear);
            this.panel1.Controls.Add(this.btnUpdateMember);
            this.panel1.Controls.Add(this.btnAddMember);
            this.panel1.Controls.Add(this.btnDeleteMember);
            this.panel1.Controls.Add(this.btnEditMember);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 76);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(142, 406);
            this.panel1.TabIndex = 9;
            // 
            // label_close_members
            // 
            this.label_close_members.AutoSize = true;
            this.label_close_members.BackColor = System.Drawing.Color.Gold;
            this.label_close_members.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label_close_members.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_close_members.ForeColor = System.Drawing.Color.White;
            this.label_close_members.Location = new System.Drawing.Point(1240, 0);
            this.label_close_members.Name = "label_close_members";
            this.label_close_members.Size = new System.Drawing.Size(26, 25);
            this.label_close_members.TabIndex = 8;
            this.label_close_members.Text = "X";
            this.label_close_members.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label_close_members.Click += new System.EventHandler(this.label_close_members_Click);
            // 
            // label_header_members
            // 
            this.label_header_members.BackColor = System.Drawing.Color.Gold;
            this.label_header_members.Dock = System.Windows.Forms.DockStyle.Top;
            this.label_header_members.Font = new System.Drawing.Font("Comic Sans MS", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_header_members.ForeColor = System.Drawing.Color.Black;
            this.label_header_members.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label_header_members.Location = new System.Drawing.Point(0, 0);
            this.label_header_members.Name = "label_header_members";
            this.label_header_members.Size = new System.Drawing.Size(1266, 76);
            this.label_header_members.TabIndex = 7;
            this.label_header_members.Text = "      Members";
            this.label_header_members.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // ManageMembersForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1266, 482);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label_close_members);
            this.Controls.Add(this.label_header_members);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "ManageMembersForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ManageMembersForm";
            this.Load += new System.EventHandler(this.ManageMembersForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Members)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtMemberLastName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtMemberID;
        private System.Windows.Forms.Label labelID;
        private System.Windows.Forms.Label labeName;
        private System.Windows.Forms.DataGridView dataGridView_Members;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox textBox_Email;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox_Phone;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtMemberFirstName;
        public System.Windows.Forms.Label label_membersCount;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnUpdateMember;
        private System.Windows.Forms.Button btnAddMember;
        private System.Windows.Forms.Button btnDeleteMember;
        private System.Windows.Forms.Button btnEditMember;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label_close_members;
        private System.Windows.Forms.Label label_header_members;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radioButton_Female;
        private System.Windows.Forms.RadioButton radioButton_Male;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn FIRSTNAME;
        private System.Windows.Forms.DataGridViewTextBoxColumn LASTNAME;
        private System.Windows.Forms.DataGridViewTextBoxColumn GENDER_MEMBER;
        private System.Windows.Forms.DataGridViewTextBoxColumn PHONE;
        private System.Windows.Forms.DataGridViewTextBoxColumn EMAIL;
    }
}