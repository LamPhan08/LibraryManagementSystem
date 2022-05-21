using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibraryManagementSystem.Forms
{
    public partial class ManageBooksForm : Form
    {
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
            AuthorsList authorsList = new AuthorsList();
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
    }
}
