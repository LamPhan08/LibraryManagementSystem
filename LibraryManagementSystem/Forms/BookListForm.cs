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
    public partial class BookListForm : Form
    {
        int authorId;
        String fullName;
        public BookListForm()
        {
            InitializeComponent();
        }

        public BookListForm(int authorId, String fullName)
        {
            InitializeComponent();
            this.authorId = authorId;
            this.fullName = fullName;
        }

        private void label_close_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void BookListForm_Load(object sender, EventArgs e)
        {
            // show the selected author's name
            label_author.Text = "Author: " + fullName;

            Database.Database.connection = "Server=DESKTOP-G8ANP0F\\SQLEXPRESS;Database=LIBRARY_MANAGEMENT;Integrated Security=true";
            Database.Database database = new Database.Database("BOOKS", "select * from BOOKS where AUTHOR_ID = " + authorId);

            ListViewItem[] items = new ListViewItem[database.Rows.Count];
            String[] titles = new String[database.Rows.Count];

            // populate the titles & images
            for (int i = 0; i < database.Rows.Count; i++)
            {
                byte[] image = (byte[])database.Rows[i][10];
                MemoryStream memoryStream = new MemoryStream(image);

                // add image to the image list
                imageList_BooksCovers.Images.Add(Image.FromStream(memoryStream));

                // add title to the titles array
                titles[i] = database.Rows[i][2].ToString();
            }

            listView_books.View = View.LargeIcon;
            imageList_BooksCovers.ImageSize = new Size(200, 250);
            listView_books.LargeImageList = imageList_BooksCovers;

            // display the data in the listView
            for (int j = 0; j < imageList_BooksCovers.Images.Count; j++)
            {
                listView_books.Items.Add(new ListViewItem() { Text = titles[j], ImageIndex = j });
            }
        }
    }
}
