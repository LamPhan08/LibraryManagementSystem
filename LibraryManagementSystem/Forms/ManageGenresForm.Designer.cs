namespace LibraryManagementSystem.Forms
{
    partial class ManageGenresForm
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
            this.label_header_genres = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtGenreID = new System.Windows.Forms.TextBox();
            this.labelID = new System.Windows.Forms.Label();
            this.btnUpdateGenre = new System.Windows.Forms.Button();
            this.btnDeleteGenre = new System.Windows.Forms.Button();
            this.btnEditGenre = new System.Windows.Forms.Button();
            this.btnAddGenre = new System.Windows.Forms.Button();
            this.dataGridView_Genres = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NAME = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtGenreName = new System.Windows.Forms.TextBox();
            this.labeName = new System.Windows.Forms.Label();
            this.label_close_genres = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Genres)).BeginInit();
            this.SuspendLayout();
            // 
            // label_header_genres
            // 
            this.label_header_genres.BackColor = System.Drawing.Color.Peru;
            this.label_header_genres.Dock = System.Windows.Forms.DockStyle.Top;
            this.label_header_genres.Font = new System.Drawing.Font("Comic Sans MS", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_header_genres.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label_header_genres.Location = new System.Drawing.Point(0, 0);
            this.label_header_genres.Name = "label_header_genres";
            this.label_header_genres.Size = new System.Drawing.Size(740, 76);
            this.label_header_genres.TabIndex = 1;
            this.label_header_genres.Text = "      Genres";
            this.label_header_genres.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LemonChiffon;
            this.panel1.Controls.Add(this.txtGenreID);
            this.panel1.Controls.Add(this.labelID);
            this.panel1.Controls.Add(this.btnUpdateGenre);
            this.panel1.Controls.Add(this.btnDeleteGenre);
            this.panel1.Controls.Add(this.btnEditGenre);
            this.panel1.Controls.Add(this.btnAddGenre);
            this.panel1.Controls.Add(this.dataGridView_Genres);
            this.panel1.Controls.Add(this.txtGenreName);
            this.panel1.Controls.Add(this.labeName);
            this.panel1.Location = new System.Drawing.Point(6, 80);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(728, 277);
            this.panel1.TabIndex = 2;
            // 
            // txtGenreID
            // 
            this.txtGenreID.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGenreID.Location = new System.Drawing.Point(116, 48);
            this.txtGenreID.Name = "txtGenreID";
            this.txtGenreID.Size = new System.Drawing.Size(80, 31);
            this.txtGenreID.TabIndex = 10;
            // 
            // labelID
            // 
            this.labelID.AutoSize = true;
            this.labelID.Font = new System.Drawing.Font("Mongolian Baiti", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelID.Location = new System.Drawing.Point(69, 53);
            this.labelID.Name = "labelID";
            this.labelID.Size = new System.Drawing.Size(41, 23);
            this.labelID.TabIndex = 9;
            this.labelID.Text = "ID:";
            // 
            // btnUpdateGenre
            // 
            this.btnUpdateGenre.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdateGenre.Location = new System.Drawing.Point(212, 212);
            this.btnUpdateGenre.Name = "btnUpdateGenre";
            this.btnUpdateGenre.Size = new System.Drawing.Size(139, 48);
            this.btnUpdateGenre.TabIndex = 8;
            this.btnUpdateGenre.Text = " Update";
            this.btnUpdateGenre.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnUpdateGenre.UseVisualStyleBackColor = true;
            this.btnUpdateGenre.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnDeleteGenre
            // 
            this.btnDeleteGenre.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteGenre.Location = new System.Drawing.Point(212, 158);
            this.btnDeleteGenre.Name = "btnDeleteGenre";
            this.btnDeleteGenre.Size = new System.Drawing.Size(139, 48);
            this.btnDeleteGenre.TabIndex = 7;
            this.btnDeleteGenre.Text = " Delete";
            this.btnDeleteGenre.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnDeleteGenre.UseVisualStyleBackColor = true;
            this.btnDeleteGenre.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnEditGenre
            // 
            this.btnEditGenre.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditGenre.Location = new System.Drawing.Point(44, 212);
            this.btnEditGenre.Name = "btnEditGenre";
            this.btnEditGenre.Size = new System.Drawing.Size(139, 48);
            this.btnEditGenre.TabIndex = 6;
            this.btnEditGenre.Text = " Edit";
            this.btnEditGenre.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnEditGenre.UseVisualStyleBackColor = true;
            this.btnEditGenre.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnAddGenre
            // 
            this.btnAddGenre.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddGenre.Location = new System.Drawing.Point(44, 158);
            this.btnAddGenre.Name = "btnAddGenre";
            this.btnAddGenre.Size = new System.Drawing.Size(139, 48);
            this.btnAddGenre.TabIndex = 5;
            this.btnAddGenre.Text = " Add";
            this.btnAddGenre.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAddGenre.UseVisualStyleBackColor = true;
            this.btnAddGenre.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // dataGridView_Genres
            // 
            this.dataGridView_Genres.AllowUserToAddRows = false;
            this.dataGridView_Genres.AllowUserToDeleteRows = false;
            this.dataGridView_Genres.AllowUserToOrderColumns = true;
            this.dataGridView_Genres.AllowUserToResizeRows = false;
            this.dataGridView_Genres.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView_Genres.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView_Genres.BackgroundColor = System.Drawing.SystemColors.ControlDark;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Mongolian Baiti", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView_Genres.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView_Genres.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_Genres.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.NAME});
            this.dataGridView_Genres.Cursor = System.Windows.Forms.Cursors.Default;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Info;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Red;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView_Genres.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView_Genres.Location = new System.Drawing.Point(387, 43);
            this.dataGridView_Genres.Name = "dataGridView_Genres";
            this.dataGridView_Genres.ReadOnly = true;
            this.dataGridView_Genres.Size = new System.Drawing.Size(326, 217);
            this.dataGridView_Genres.TabIndex = 4;
            // 
            // ID
            // 
            this.ID.DataPropertyName = "ID";
            this.ID.FillWeight = 40.60914F;
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            // 
            // NAME
            // 
            this.NAME.DataPropertyName = "NAME";
            this.NAME.FillWeight = 159.3909F;
            this.NAME.HeaderText = "Genre Name";
            this.NAME.Name = "NAME";
            this.NAME.ReadOnly = true;
            // 
            // txtGenreName
            // 
            this.txtGenreName.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGenreName.Location = new System.Drawing.Point(116, 96);
            this.txtGenreName.Name = "txtGenreName";
            this.txtGenreName.Size = new System.Drawing.Size(253, 31);
            this.txtGenreName.TabIndex = 3;
            // 
            // labeName
            // 
            this.labeName.AutoSize = true;
            this.labeName.Font = new System.Drawing.Font("Mongolian Baiti", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labeName.Location = new System.Drawing.Point(40, 101);
            this.labeName.Name = "labeName";
            this.labeName.Size = new System.Drawing.Size(70, 23);
            this.labeName.TabIndex = 0;
            this.labeName.Text = "Name:";
            // 
            // label_close_genres
            // 
            this.label_close_genres.AutoSize = true;
            this.label_close_genres.BackColor = System.Drawing.Color.Peru;
            this.label_close_genres.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label_close_genres.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_close_genres.ForeColor = System.Drawing.Color.White;
            this.label_close_genres.Location = new System.Drawing.Point(714, -1);
            this.label_close_genres.Name = "label_close_genres";
            this.label_close_genres.Size = new System.Drawing.Size(26, 25);
            this.label_close_genres.TabIndex = 3;
            this.label_close_genres.Text = "X";
            this.label_close_genres.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label_close_genres.Click += new System.EventHandler(this.label_close_genres_Click);
            this.label_close_genres.MouseEnter += new System.EventHandler(this.label_close_genres_MouseEnter);
            this.label_close_genres.MouseLeave += new System.EventHandler(this.label_close_genres_MouseLeave);
            // 
            // ManageGenresForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(740, 360);
            this.Controls.Add(this.label_close_genres);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label_header_genres);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ManageGenresForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ManageGenresForm";
            this.Load += new System.EventHandler(this.ManageGenresForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Genres)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_header_genres;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label_close_genres;
        private System.Windows.Forms.Label labeName;
        private System.Windows.Forms.Button btnAddGenre;
        private System.Windows.Forms.DataGridView dataGridView_Genres;
        private System.Windows.Forms.TextBox txtGenreName;
        private System.Windows.Forms.Button btnDeleteGenre;
        private System.Windows.Forms.Button btnEditGenre;
        private System.Windows.Forms.Button btnUpdateGenre;
        private System.Windows.Forms.TextBox txtGenreID;
        private System.Windows.Forms.Label labelID;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn NAME;
    }
}