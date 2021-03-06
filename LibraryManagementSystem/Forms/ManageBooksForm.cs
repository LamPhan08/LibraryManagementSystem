using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibraryManagementSystem.Forms
{
    public partial class ManageBooksForm : Form
    {
        private SqlConnection connection = new SqlConnection("Server=" + Database.Database.connectionName + "; Database=LIBRARY_MANAGEMENT;Integrated Security=true");
        private SqlDataAdapter dataAdapter, dataAdapter1;
        private DataTable dataTable, dataTable1;
        private SqlCommand command;
        private BindingManagerBase bindingManagerBase_dataTable, bindingManagerBase_dataTable1;

        RemoveBookForm remove1;

        public static int numberOfBooks;
        public ManageBooksForm()
        {
            InitializeComponent();
        }

        public ManageBooksForm(RemoveBookForm remove)
        {
            InitializeComponent();
            this.remove1 = remove;
        }

        private void ManageBooksForm_Load(object sender, EventArgs e)
        {
            label_header_books.Image = Image.FromFile("../../Images/book.png");
            btnAddBook.Image = Image.FromFile("../../Images/add.png");
            btnEditBook.Image = Image.FromFile("../../Images/edit.png");
            btnSelectCover.Image = Image.FromFile("../../Images/upload.png");   // in add panel
            button_SelectCover_Edit.Image = Image.FromFile("../../Images/upload.png");
            button_show_book.Image = Image.FromFile("../../Images/details_list.png");
            btnExportBooks.Image = Image.FromFile("../../Images/text_file.png");

            txtBookID.Enabled = false;
            txtBookISBN.Enabled = false;
            txtBookTitle.Enabled = false;
            txtBookAuthor.Enabled = false;
            comboBoxBookGenre.Enabled = false;
            numericUpDown_BookQuantity.Enabled = false;
            txtBookPrice.Enabled = false;
            txtBookPublisher.Enabled = false;
            dateTimePicker_Books.Enabled = false;
            richTextBox_BookDescription.Enabled = false;
            btnAddNewBook.Enabled = false;
            btnSelectAuthor.Enabled = false;
            btnSelectCover.Enabled = false;

            dataAdapter = new SqlDataAdapter("SELECT ID, NAME FROM GENRES", connection);
            dataTable = new DataTable();
            dataAdapter.Fill(dataTable);

            loadDataGridView();


            comboBoxBookGenre.DataSource = dataTable;
            comboBoxBookGenre.DisplayMember = "Name";
            comboBoxBookGenre.ValueMember = "ID";

            comboBox_Genre_Edit.DataSource = dataTable;
            comboBox_Genre_Edit.DisplayMember = "Name";
            comboBox_Genre_Edit.ValueMember = "ID";

            bindingManagerBase_dataTable = BindingContext[dataTable];
            bindingManagerBase_dataTable1 = BindingContext[dataTable1];

            numberOfBooks = 0;
            connection.Open();
            command = new SqlCommand("SELECT COUNT(*) FROM BOOKS", connection);
            numberOfBooks = (int)command.ExecuteScalar();
            connection.Close();

            label_booksCount.Text = numberOfBooks.ToString() + " books";

            panel_add.BringToFront();
        }

        private void label_close_books_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnSelectCover_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();

            openFileDialog.Title = "Choose Image";

            openFileDialog.Filter = "(*.jpg;*.png;*.gif)|*.jpg;*.png;*.gif";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                pictureBookCover.Image = Image.FromFile(openFileDialog.FileName);
            }
        }

        private void btnSelectAuthor_Click(object sender, EventArgs e)
        {
            AuthorsList authorsList = new AuthorsList(this);
            authorsList.ShowDialog();
        }

        private void label_close_books_MouseEnter(object sender, EventArgs e)
        {
            label_close_books.ForeColor = Color.Black;
        }

        private void label_close_books_MouseLeave(object sender, EventArgs e)
        {
            label_close_books.ForeColor = Color.White;
        }

        private void btnAddNewBook_Click(object sender, EventArgs e)
        {


            if (txtBookISBN.Text.Trim().Equals("") 
                || txtBookTitle.Text.Trim().Equals("") 
                || txtBookAuthor.Equals("") 
                || comboBoxBookGenre.Text.Equals("") 
                || numericUpDown_BookQuantity.Text.Equals("") 
                || txtBookPrice.Text.Trim().Equals("") 
                || txtBookPublisher.Text.Trim().Equals("") 
                || richTextBox_BookDescription.Text.Trim().Equals("") || txtAuthorID.Text.Equals("ID:"))
            {
                MessageBox.Show("Please enter full information!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                int author_id = Convert.ToInt32(txtAuthorID.Text);
                int genre_id = Convert.ToInt32(comboBoxBookGenre.SelectedValue);
                int quantity = Convert.ToInt32(numericUpDown_BookQuantity.Value);
                double price = Convert.ToDouble(txtBookPrice.Text);
                DateTime date = dateTimePicker_Books.Value;

                MemoryStream memory = new MemoryStream();
                pictureBookCover.Image.Save(memory, pictureBookCover.Image.RawFormat);
              

                try
                {
                    Database.Database.connection = "Server=" + Database.Database.connectionName + ";Database=LIBRARY_MANAGEMENT;Integrated Security=true";
                    Database.Database database = new Database.Database("BOOKS", "select ISBN from BOOKS where ISBN = '" + txtBookISBN.Text + "'");

                    if (database.Rows.Count > 0)
                    {
                        MessageBox.Show("This ISBN already exists!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else
                    {
                        database = new Database.Database("BOOKS", "select TITLE from BOOKS where TITLE = '" + txtBookTitle.Text + "'");

                        if (database.Rows.Count > 0)
                        {
                            MessageBox.Show("This title already exists!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                        else
                        {
                            connection.Open();
                            command = new SqlCommand("INSERT INTO BOOKS VALUES ('" + txtBookISBN.Text + "', " +
                                "'" + txtBookTitle.Text + "', " +
                                "" + author_id + ", " +
                                "" + genre_id + ", " +
                                "" + quantity + ", " +
                                "" + price + ", " +
                                "'" + txtBookPublisher.Text + "', " +
                                "'" + date + "', " +
                                "'" + richTextBox_BookDescription.Text + "', @image)", connection);

                            command.Parameters.AddWithValue("image", memory.ToArray());

                            command.ExecuteNonQuery();
                            connection.Close();

                            MessageBox.Show("Add Successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            numberOfBooks++;
                            label_booksCount.Text = numberOfBooks.ToString() + " books";

                            ClearFields();
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error:\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            loadDataGridView();
        }

        private void btnAddBook_Click(object sender, EventArgs e)
        {
            txtBookISBN.Enabled = true;
            txtBookTitle.Enabled = true;
            comboBoxBookGenre.Enabled = true;
            numericUpDown_BookQuantity.Enabled = true;
            txtBookPrice.Enabled = true;
            txtBookPublisher.Enabled = true;
            dateTimePicker_Books.Enabled = true;
            richTextBox_BookDescription.Enabled = true;
            btnAddNewBook.Enabled = true;
            btnSelectAuthor.Enabled = true;
            btnSelectCover.Enabled = true;

            txtBookAuthor.Text = "";
            txtAuthorID.Text = "ID: ";

            panel_add.BringToFront();
        }

        private void btnClearFields_Click(object sender, EventArgs e)
        {
            ClearFields();
        }

        private void ClearFields()
        {
            txtBookISBN.Clear();
            txtBookTitle.Clear();
            txtBookAuthor.Clear();
            txtAuthorID.Text = "ID:";
            txtBookPrice.Clear();
            txtBookPublisher.Clear();
            richTextBox_BookDescription.Clear();
            comboBoxBookGenre.SelectedIndex = 0;
            numericUpDown_BookQuantity.Value = 0;
            dateTimePicker_Books.Value = DateTime.Now;
            pictureBookCover.Image = Image.FromFile("../../Resources/bookcover.png");
            txtBookISBN.Focus();
        }

        private void btnEditBook_Click(object sender, EventArgs e)
        {
            textBox_ISBN_Edit.Enabled = true;
            textBox_Title_Edit.Enabled = true;
            comboBox_Genre_Edit.Enabled = true;
            numericUpDown_Quantity_Edit.Enabled = true;
            textBox_Price_Edit.Enabled = true;
            textBox_Publisher_Edit.Enabled = true;
            dateTimePicker_DateReceived_Edit.Enabled = true;
            richTextBox_Description_Edit.Enabled = true;
            button_EditBook.Enabled = true;
            eButtonSelectAuthor.Enabled = true;
            button_SelectCover_Edit.Enabled = true;

            textBox_Author_Edit.Text = "";
            label_AuthorId_Edit.Text = "ID: ";

            panel_edit.BringToFront();
        }

        private void eButtonSelectAuthor_Click(object sender, EventArgs e)
        {
            AuthorsList authorsList = new AuthorsList(this);
            authorsList.ShowDialog();
        }

        private void button_EditBook_Click(object sender, EventArgs e)
        {
            if (textBox_ISBN_Edit.Text.Equals("")
                || textBox_Title_Edit.Text.Equals("")
                || textBox_Author_Edit.Equals("")
                || comboBox_Genre_Edit.Text.Equals("")
                || numericUpDown_Quantity_Edit.Text.Equals("")
                || textBox_Price_Edit.Text.Equals("")
                || textBox_Publisher_Edit.Text.Equals("")
                || richTextBox_Description_Edit.Text.Equals("") || label_AuthorId_Edit.Text.Equals("ID:"))
            {
                MessageBox.Show("Please enter full information!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                String isbn = textBox_ISBN_Edit.Text.ToString(),
                    title = textBox_Title_Edit.Text.ToString(),
                    publisher = textBox_Publisher_Edit.Text.ToString(),
                    description = richTextBox_Description_Edit.Text.ToString();

                int author_id = Convert.ToInt32(label_AuthorId_Edit.Text);
                int genre_id = Convert.ToInt32(comboBox_Genre_Edit.SelectedValue);
                int quantity = Convert.ToInt32(numericUpDown_Quantity_Edit.Value);
                int book_id = Convert.ToInt32(textBox_ID_Edit.Text);
                double price = Convert.ToDouble(textBox_Price_Edit.Text);
                DateTime date = dateTimePicker_DateReceived_Edit.Value;

                MemoryStream memory = new MemoryStream();
                pictureBox_Cover_Edit.Image.Save(memory, pictureBox_Cover_Edit.Image.RawFormat);

                try
                {
                    Database.Database.connection = "Server=" + Database.Database.connectionName + ";Database=LIBRARY_MANAGEMENT;Integrated Security=true";
                    Database.Database database = new Database.Database("BOOKS", "select * from BOOKS where ISBN = '" + txtBookISBN.Text + "'");

                    if (database.Rows.Count > 0)
                    {
                        MessageBox.Show("This ISBN already exists!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else
                    {
                        database = new Database.Database("BOOKS", "select TITLE from BOOKS where TITLE = '" + txtBookTitle.Text + "'");

                        if (database.Rows.Count > 0)
                        {
                            MessageBox.Show("This title already exists!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                        else
                        {
                            connection.Open();
                            //command = new SqlCommand
                            //   (
                            //    "UPDATE BOOKS " +
                            //    "SET " +
                            //        "ISBN = @isbn, " +
                            //        "TITLE = @title, " +
                            //        "AUTHOR_ID = @author_id, " +
                            //        "GENRE_ID = @genre_id, " +
                            //        "QUANTITY = @quantity, " +
                            //        "PRICE = @price, " +
                            //        "PUBLISHER = @publisher, " +
                            //        "DATE_RECEIVED = @date, " +
                            //        "DESCRIPTION = @description, " +
                            //        "COVER = @book_cover " +
                            //        "WHERE ISBN = " + int.Parse(textBox_ISBN_Edit.Text)
                            //    , connection
                            //    );

                            command = new SqlCommand("UPDATE BOOKS SET ISBN = '" + isbn + "', " +
                                "TITLE = '" + title + "', " +
                                "AUTHOR_ID = " + author_id + ", " +
                                "GENRE_ID = " + genre_id + ", " +
                                "QUANTITY = " + quantity + ", " +
                                "PRICE = " + price + ", " +
                                "PUBLISHER = '" + publisher + "', " +
                                "DATE_RECEIVED = '" + date + "', " +
                                "DESCRIPTION = '" + description + "', " +
                                "COVER = @image WHERE ID = " + book_id, connection);

                            command.Parameters.AddWithValue("image", memory.ToArray());

                            command.ExecuteNonQuery();
                            connection.Close();

                            MessageBox.Show("Edited Successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            label_booksCount.Text = numberOfBooks.ToString() + " books";

                            ClearFields();
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error:\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            loadDataGridView();
        }

        private void button_SelectCover_Edit_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();

            openFileDialog.Filter = "Choose Image (*.jpg;*.png;*.gif)|*.jpg;*.png;*.gif";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                pictureBox_Cover_Edit.Image = Image.FromFile(openFileDialog.FileName);
            }
        }

        private void button_searchById_Click(object sender, EventArgs e)
        {
            try
            {
                int id = Convert.ToInt32(textBox_ID_Edit.Text);
            }
            catch
            {
                MessageBox.Show("Please enter the ID", "ID not found!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            try
            {
                Database.Database.connection = "Server=" + Database.Database.connectionName + ";Database=LIBRARY_MANAGEMENT;Integrated Security=true";
                Database.Database database = new Database.Database("BOOKS", "select * from BOOKS where ID = '" + textBox_ID_Edit.Text + "'");
                Database.Database authorsDatabase = new Database.Database("AUTHORS", "select * from AUTHORS where ID = '" + int.Parse(database.Rows[0][3].ToString()) + "'");
                Database.Database gerneDatabase = new Database.Database("GENRES", "select NAME from GENRES where ID = '" + int.Parse(database.Rows[0][4].ToString()) + "'");
                if (database.Rows.Count > 0)
                {
                    displayingData(database, authorsDatabase, gerneDatabase);

                    ////specifically book cover
                    //byte[] cover = (byte[])database.Rows[0]["COVER"];
                    //MemoryStream memoryStream = new MemoryStream(cover);
                    //pictureBox_Cover_Edit.Image = Image.FromStream(memoryStream);
                }
                else
                {
                    MessageBox.Show("This ID doesn't exist! Select a diiferent ID.", "ID not found", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error:\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button_searchByIsbn_Click(object sender, EventArgs e)
        {
            try
            {
                int isbn = Convert.ToInt32(textBox_ISBN_Edit.Text);
            }
            catch
            {
                MessageBox.Show("Please enter the ISBN", "ISBN not found!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            try
            {
                Database.Database.connection = "Server=" + Database.Database.connectionName + ";Database=LIBRARY_MANAGEMENT;Integrated Security=true";
                Database.Database database = new Database.Database("BOOKS", "select * from BOOKS where ISBN = '" + textBox_ISBN_Edit.Text + "'");
                Database.Database authorsDatabase = new Database.Database("AUTHORS", "select * from AUTHORS where ID = '" + int.Parse(database.Rows[0][3].ToString()) + "'");
                Database.Database genreDatabase = new Database.Database("GENRES", "select NAME from GENRES where ID = '" + int.Parse(database.Rows[0][4].ToString()) + "'");
                if (database.Rows.Count > 0)
                {
                    displayingData(database, authorsDatabase, genreDatabase);
                }
                else
                {
                    MessageBox.Show("This ID doesn't exist! Select a diiferent ID.", "ID not found", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error:\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void displayingData(Database.Database database, Database.Database authorsDatabase, Database.Database genreDatabase)
        {
            textBox_ID_Edit.Text = database.Rows[0][0].ToString();
            textBox_ISBN_Edit.Text = database.Rows[0][1].ToString();
            textBox_Title_Edit.Text = database.Rows[0][2].ToString();
            textBox_Author_Edit.Text = authorsDatabase.Rows[0][1].ToString() + " " + authorsDatabase.Rows[0][2].ToString();
            label_AuthorId_Edit.Text = database.Rows[0][3].ToString();
            comboBox_Genre_Edit.Text = genreDatabase.Rows[0][0].ToString();
            numericUpDown_Quantity_Edit.Value = Convert.ToInt32(database.Rows[0][5].ToString());
            textBox_Price_Edit.Text = database.Rows[0][6].ToString();
            textBox_Publisher_Edit.Text = database.Rows[0][7].ToString();
            dateTimePicker_DateReceived_Edit.Text = database.Rows[0][8].ToString();
            richTextBox_Description_Edit.Text = database.Rows[0][9].ToString();

            // specifically book cover
            byte[] cover = (byte[])database.Rows[0][10];
            MemoryStream memoryStream = new MemoryStream(cover);
            pictureBox_Cover_Edit.Image = Image.FromStream(memoryStream);
        }

        private void button_show_book_Click(object sender, EventArgs e)
        {
            panel_ShowBooks.BringToFront();
            loadDataGridView();
        }

        public void loadDataGridView()
        {
            command = new SqlCommand("SELECT * FROM BOOKS", connection);
            //command = new SqlCommand("SELECT ID, ISBN, TITLE, AUTHOR_ID, GENRE_ID, QUANTITY, PRICE, PUBLISHER, DATE_RECEIVED, DESCRIPTION, COVER FROM BOOKS", connection);
            dataAdapter1 = new SqlDataAdapter();
            dataAdapter1.SelectCommand = command;
            dataTable1 = new DataTable();
            dataTable1.Clear();
            dataAdapter1.Fill(dataTable1);
            dataGridView_ShowBooks.RowTemplate.Height = 75;
            dataGridView_ShowBooks.DataSource = dataTable1;
            DataGridViewImageColumn dataGridViewImageColumn = new DataGridViewImageColumn();
            dataGridViewImageColumn = (DataGridViewImageColumn)dataGridView_ShowBooks.Columns[10];
            dataGridViewImageColumn.ImageLayout = DataGridViewImageCellLayout.Stretch;
        }

        private void button_editBook__Click(object sender, EventArgs e)
        {
            panel_edit.BringToFront();

            // stop here

            try
            {
                int id = Convert.ToInt32(dataGridView_ShowBooks.CurrentRow.Cells[0].Value);
            }
            catch
            {
                MessageBox.Show("Please enter the ID", "ID not found!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            try
            {
                Database.Database.connection = "Server=" + Database.Database.connectionName + ";Database=LIBRARY_MANAGEMENT;Integrated Security=true";
                Database.Database database = new Database.Database("BOOKS", "select * from BOOKS where ID = '" + dataGridView_ShowBooks.CurrentRow.Cells[0].Value.ToString() + "'");
                Database.Database authorsDatabase = new Database.Database("AUTHORS", "select * from AUTHORS where ID = '" + int.Parse(database.Rows[0][3].ToString()) + "'");
                Database.Database gerneDatabase = new Database.Database("GENRES", "select NAME from GENRES where ID = '" + int.Parse(database.Rows[0][4].ToString()) + "'");
                if (database.Rows.Count > 0)
                {
                    displayingData(database, authorsDatabase, gerneDatabase);

                    ////specifically book cover
                    //byte[] cover = (byte[])database.Rows[0]["COVER"];
                    //MemoryStream memoryStream = new MemoryStream(cover);
                    //pictureBox_Cover_Edit.Image = Image.FromStream(memoryStream);
                }
                else
                {
                    MessageBox.Show("This ID doesn't exist! Select a diiferent ID.", "ID not found", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error:\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button_RemoveBook_Click(object sender, EventArgs e)
        {
            
            int id = Convert.ToInt32(dataGridView_ShowBooks.CurrentRow.Cells[0].Value);

            DialogResult result = MessageBox.Show("Do you REALLY want to delete this book?", "Warning!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                try
                {
                    Database.Database.connection = "Server=" + Database.Database.connectionName + ";Database=LIBRARY_MANAGEMENT;Integrated Security=true";
                    Database.Database database = new Database.Database("BOOKS", "select * from BOOKS where ISBN = '" + id + "'");

                    connection.Open();
                    command = new SqlCommand("DELETE FROM BOOKS WHERE ID = " + id, connection);

                    command.ExecuteNonQuery();
                    connection.Close();

                    MessageBox.Show("Delete Successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    numberOfBooks--;
                    label_booksCount.Text = numberOfBooks.ToString() + " books";

                    loadDataGridView();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error:\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnExportBooks_Click(object sender, EventArgs e)
        {
            Database.Database.connection = "Server=" + Database.Database.connectionName + ";Database=LIBRARY_MANAGEMENT;Integrated Security=true";
            Database.Database database = new Database.Database("BOOKS", "select * from BOOKS");

            if (!Directory.Exists(@"C:\books"))
            {
                Directory.CreateDirectory(@"C:\books");
            }

            String filePath = @"C:\books\book list.txt";

            if (!File.Exists(filePath))
            {
                File.Create(filePath).Close();
                MessageBox.Show("File created successfully!", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            // populate the text file with the book's id, isbn & title
            TextWriter textWriter = new StreamWriter(filePath);

            String id, isbn, title;

            for (int i = 0; i < database.Rows.Count; i++)
            {
                //for (int j = 0; j < database.Columns.Count; j++)
                //{
                //    textWriter.Write(database.Rows[i][j].ToString() + " ");
                //}

                id = database.Rows[i][0].ToString();
                isbn = database.Rows[i][1].ToString();
                title = database.Rows[i][2].ToString();

                textWriter.Write
                    (
                    "---Book no." + (i + 1) + "---\n" +
                    "Book ID: " + id + "\n" +
                    "ISBN number: " + isbn + "\n" +
                    "Title: " + title
                    );

                textWriter.WriteLine("");
                textWriter.WriteLine("-----------------------------------");
            }
            textWriter.Close();

            MessageBox.Show("Data exported successfully!", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void panel_add_Paint(object sender, PaintEventArgs e)
        {

        }

        private void txtBookPrice_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtBookISBN_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void textBox_ISBN_Edit_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        // unused
        private void BindingManagerBase_dataTable1_PositionChanged(object sender, EventArgs e)
        {
            DataRow row1 = dataTable1.Rows[bindingManagerBase_dataTable1.Position];

            textBox_ID_Edit.Text = row1["ID"].ToString();
            textBox_ISBN_Edit.Text = row1["ISBN"].ToString();
            textBox_Title_Edit.Text = row1["TITLE"].ToString();
            textBox_Author_Edit.Text = row1["FIRSTNAME"].ToString() + " " + row1["LASTNAME"].ToString();
            label_AuthorId_Edit.Text = row1["AUTHOR_ID"].ToString();
            comboBox_Genre_Edit.Text = row1["NAME"].ToString();
            numericUpDown_Quantity_Edit.Value = int.Parse(row1["QUANTITY"].ToString());
            textBox_Price_Edit.Text = row1["PRICE"].ToString();
            textBox_Publisher_Edit.Text = row1["PUBLISHER"].ToString();
            dateTimePicker_DateReceived_Edit.Text = row1["DATE_RECEIVED"].ToString();
            richTextBox_Description_Edit.Text = row1["DESCRIPTION"].ToString();
        }

        private void btnDeleteBook_Click(object sender, EventArgs e)
        {
            RemoveBookForm removeBookForm = new RemoveBookForm();
            removeBookForm.Show();
        }

        // unused
        public void deleteBook(int id)
        {
            try
            {
                Database.Database.connection = "Server=" + Database.Database.connectionName + ";Database=LIBRARY_MANAGEMENT;Integrated Security=true";
                Database.Database database = new Database.Database("BOOKS", "select * from BOOKS where ISBN = '" + txtBookISBN.Text + "'");

                connection.Open();
                command = new SqlCommand("DELETE FROM BOOKS WHERE ID = " + id, connection);

                command.ExecuteNonQuery();
                connection.Close();

                MessageBox.Show("Delete Successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                numberOfBooks--;
                label_booksCount.Text = numberOfBooks.ToString() + " books";

                ClearFields();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error:\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            loadDataGridView();
        }
    }
}
