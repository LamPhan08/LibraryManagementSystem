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
    public partial class DashboardForm : Form
    {
        public DashboardForm()
        {
            InitializeComponent();
        }

        private void DashboardForm_Load(object sender, EventArgs e)
        {
            pictureLogo.Image = Image.FromFile("../../Images/library_logo.png");
            picture_close.Image = Image.FromFile("../../Images/close.png");
            btnBooks.Image = Image.FromFile("../../Images/books.png");
            btnAuthors.Image = Image.FromFile("../../Images/authors.png");
            btnGenres.Image = Image.FromFile("../../Images/tag.png");
            btnCirculation.Image = Image.FromFile("../../Images/loop.png");
            btnUsers.Image = Image.FromFile("../../Images/users.png");
        }

        private void picture_close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnGenres_Click(object sender, EventArgs e)
        {
            ManageGenresForm manageGenresForm = new ManageGenresForm();
            manageGenresForm.Show();
        }
    }
}
