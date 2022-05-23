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
        private SqlConnection connection = new SqlConnection("Server=.;Database=LIBRARY_MANAGEMENT;Integrated Security=true");
        private SqlDataAdapter dataAdapter;
        private DataTable dataTable;
        private SqlCommand command;

        private int numberOfBooks;
        public ManageBooksForm()
        {
            InitializeComponent();
        }

        private void ManageBooksForm_Load(object sender, EventArgs e)
        {
            label_header_books.Image = Image.FromFile("../../Images/book.png");
            btnAddBook.Image = Image.FromFile("../../Images/add.png");
            btnDeleteBook.Image = Image.FromFile("../../Images/trash.png");
            btnEditBook.Image = Image.FromFile("../../Images/edit.png");
            btnSelectCover.Image = Image.FromFile("../../Images/upload.png");   // in add panel
            button_SelectCover_Edit.Image = Image.FromFile("../../Images/upload.png");

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

            comboBoxBookGenre.DataSource = dataTable;
            comboBoxBookGenre.DisplayMember = "Name";
            comboBoxBookGenre.ValueMember = "ID";

            comboBox_Genre_Edit.DataSource = dataTable;
            comboBox_Genre_Edit.DisplayMember = "Name";
            comboBox_Genre_Edit.ValueMember = "ID";

            numberOfBooks = 0;
            connection.Open();
            command = new SqlCommand("SELECT COUNT(*) FROM BOOKS", connection);
            numberOfBooks = (int)command.ExecuteScalar();
            connection.Close();

            label_booksCount.Text = numberOfBooks.ToString() + " books";

            panel_edit.BringToFront();
        }

        private void label_close_books_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnSelectCover_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();

            openFileDialog.Filter = "Choose Image (*.jpg;*.png;*.gif)|*.jpg;*.png;*.gif";

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


            if (txtBookISBN.Text.Equals("") 
                || txtBookTitle.Text.Equals("") 
                || txtBookAuthor.Equals("") 
                || comboBoxBookGenre.Text.Equals("") 
                || numericUpDown_BookQuantity.Text.Equals("") 
                || txtBookPrice.Text.Equals("") 
                || txtBookPublisher.Text.Equals("") 
                || richTextBox_BookDescription.Text.Equals("") || txtAuthorID.Text.Equals("ID:"))
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
                byte[] book_cover = memory.ToArray();

                try
                {
                    Database.Database.connection = "Server=.;Database=LIBRARY_MANAGEMENT;Integrated Security=true";
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
                                "'" + richTextBox_BookDescription.Text + "', " +
                                "'" + book_cover + "')", connection);

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
                byte[] book_cover = memory.ToArray();

                try
                {
                    Database.Database.connection = "Server=.;Database=LIBRARY_MANAGEMENT;Integrated Security=true";
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
                            // lỗi update tại đây
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
                                "COVER = '" + book_cover + "' WHERE ID = " + book_id, connection);

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
                Database.Database.connection = "Server=.;Database=LIBRARY_MANAGEMENT;Integrated Security=true";
                Database.Database database = new Database.Database("BOOKS", "select * from BOOKS where ID = '" + textBox_ID_Edit.Text + "'");
                Database.Database authorsDatabase = new Database.Database("AUTHORS", "select * from AUTHORS where ID = '" + int.Parse(database.Rows[0][3].ToString()) + "'");
                Database.Database gerneDatabase = new Database.Database("GENRES", "select NAME from GENRES where ID = '" + int.Parse(database.Rows[0][4].ToString()) + "'");
                if (database.Rows.Count > 0)
                {
                    textBox_ID_Edit.Text = database.Rows[0][0].ToString();
                    textBox_ISBN_Edit.Text = database.Rows[0][1].ToString();
                    textBox_Title_Edit.Text = database.Rows[0][2].ToString();
                    textBox_Author_Edit.Text = authorsDatabase.Rows[0][1].ToString() + " " + authorsDatabase.Rows[0][2].ToString();
                    label_AuthorId_Edit.Text = database.Rows[0][3].ToString();
                    comboBox_Genre_Edit.Text = gerneDatabase.Rows[0][0].ToString();
                    numericUpDown_Quantity_Edit.Value = Convert.ToInt32(database.Rows[0][5].ToString());
                    textBox_Price_Edit.Text = database.Rows[0][6].ToString();
                    textBox_Publisher_Edit.Text = database.Rows[0][7].ToString();
                    dateTimePicker_DateReceived_Edit.Text = database.Rows[0][8].ToString();
                    richTextBox_Description_Edit.Text = database.Rows[0][9].ToString();

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
                Database.Database.connection = "Server=.;Database=LIBRARY_MANAGEMENT;Integrated Security=true";
                Database.Database database = new Database.Database("BOOKS", "select * from BOOKS where ISBN = '" + textBox_ISBN_Edit.Text + "'");
                Database.Database authorsDatabase = new Database.Database("AUTHORS", "select * from AUTHORS where ID = '" + int.Parse(database.Rows[0][3].ToString()) + "'");
                Database.Database gerneDatabase = new Database.Database("GENRES", "select NAME from GENRES where ID = '" + int.Parse(database.Rows[0][4].ToString()) + "'");
                if (database.Rows.Count > 0)
                {
                    textBox_ID_Edit.Text = database.Rows[0][0].ToString();
                    textBox_ISBN_Edit.Text = database.Rows[0][1].ToString();
                    textBox_Title_Edit.Text = database.Rows[0][2].ToString();
                    textBox_Author_Edit.Text = authorsDatabase.Rows[0][1].ToString() + " " + authorsDatabase.Rows[0][2].ToString();
                    label_AuthorId_Edit.Text = database.Rows[0][3].ToString();
                    comboBox_Genre_Edit.Text = gerneDatabase.Rows[0][0].ToString();
                    numericUpDown_Quantity_Edit.Value = Convert.ToInt32(database.Rows[0][5].ToString());
                    textBox_Price_Edit.Text = database.Rows[0][6].ToString();
                    textBox_Publisher_Edit.Text = database.Rows[0][7].ToString();
                    dateTimePicker_DateReceived_Edit.Text = database.Rows[0][8].ToString();
                    richTextBox_Description_Edit.Text = database.Rows[0][9].ToString();

                    // specifically book cover
                    //byte[] cover = (byte[])database.Rows[0][10];
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

        //public void displayingData(Database.Database database)
        //{
        //    // lỗi ngay tên
        //}

        private void button_show_book_Click(object sender, EventArgs e)
        {

        }

        private void btnDeleteBook_Click(object sender, EventArgs e)
        {
            // vì đang có lỗi update nên tui chưa dám cài đặt xóa chỗ này
        }
    }
}
