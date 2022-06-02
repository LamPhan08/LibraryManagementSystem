using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibraryManagementSystem.Forms
{
    public partial class BookInfoCard : Form
    {
        int idBook;
        public BookInfoCard(int id)
        {
            InitializeComponent();
            idBook = id;
        }

        private void label_close_books_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BookInfoCard_Load(object sender, EventArgs e)
        {
            try
            {
                MemoryStream memoryStream;
                Database.Database.connection = "Server=" + Database.Database.connectionName + ";Database=LIBRARY_MANAGEMENT;Integrated Security=true";
                Database.Database database = new Database.Database("Books", "select * from books where ID = '" + idBook + "'");
                
                int idAuthor = Convert.ToInt32(database.Rows[0][3]);
                int idGenre = Convert.ToInt32(database.Rows[0][4]);
                Database.Database database1 = new Database.Database("Authors", "select * from books where ID = '" + idAuthor + "'");
                Database.Database database2 = new Database.Database("Genres", "select * from genres where ID = '" + idGenre + "'");
                label_ISBN.Text = "ISBN: " + database.Rows[0][1].ToString();
                label_title.Text = "Title: " + database.Rows[0][2].ToString();
                label_author.Text = "Author: " + database1.Rows[0][1].ToString()+ " "+ database1.Rows[0][2].ToString();
                label_quantity.Text = "Quantity: " + database.Rows[0][5].ToString();
                label_genre.Text = "Genre: " + database2.Rows[0][1].ToString();
                label_price.Text = "Price: " + database.Rows[0][6].ToString();
                label_publisher.Text ="Publisher: " + database.Rows[0][7].ToString();
                label_dateAdded.Text = "Date Added: "+ database.Rows[0][8].ToString();
                richTextBox_decription.Text =database.Rows[0][9].ToString();
                byte[] bytesImage = (byte[])database.Rows[0][10];
                Panel panel = (Panel)panel_Book;
                bytesImage = (byte[])database.Rows[0][10];
                memoryStream = new MemoryStream(bytesImage);
                panel.BackgroundImage = Image.FromStream(memoryStream);
                panel.BackgroundImageLayout = ImageLayout.Stretch;

            }
          catch(Exception ex)
            {
                MessageBox.Show("No book to show!");
                this.Close();
            }
            
             
        }
    }
}
