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
            btnSelectCover.Image = Image.FromFile("../../Images/upload.png");

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
                            SqlCommand command = new SqlCommand("INSERT INTO BOOKS VALUES ('" + txtBookISBN.Text + "', " +
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
    }
}
