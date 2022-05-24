using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibraryManagementSystem.Forms
{
    public partial class AuthorsList : Form
    {
        private SqlConnection connection = new SqlConnection("Server=DESKTOP-G8ANP0F\\SQLEXPRESS;Database=LIBRARY_MANAGEMENT;Integrated Security=true");
        private SqlDataAdapter dataAdapter;
        private DataTable dataTable;

        private ManageBooksForm manageBooks = null;
        public AuthorsList(ManageBooksForm sourceForm)
        {
            manageBooks = sourceForm as ManageBooksForm;
            InitializeComponent();
        }

        private void label_close_authors_list_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void label_close_authors_list_MouseEnter(object sender, EventArgs e)
        {
            label_close_authors_list.ForeColor = Color.Black;
        }

        private void label_close_authors_list_MouseLeave(object sender, EventArgs e)
        {
            label_close_authors_list.ForeColor = Color.White;
        }

        private void AuthorsList_Load(object sender, EventArgs e)
        {
            dataAdapter = new SqlDataAdapter("SELECT ID, CONCAT(FIRSTNAME, ' ', LASTNAME) as FULLNAME FROM AUTHORS", connection);
            dataTable = new DataTable();
            dataAdapter.Fill(dataTable);

            //listAuthors.DataSource = null;
            listAuthors.DataSource = dataTable;
            listAuthors.DisplayMember = "FULLNAME";
            listAuthors.ValueMember = "ID";
        }

        private void btnSelectAuthorList_Click(object sender, EventArgs e)
        {
            DataRowView dataRowView = (DataRowView)listAuthors.SelectedItem;

            String fullName = dataRowView["FULLNAME"].ToString();
            String id = dataRowView["ID"].ToString();

            manageBooks.txtBookAuthor.Text = fullName;
            manageBooks.txtAuthorID.Text = id;

            manageBooks.textBox_Author_Edit.Text = fullName;
            manageBooks.label_AuthorId_Edit.Text = id;

            //MessageBox.Show("ID = " + id + "| Fullname: " + fullName);

            Close();
        }
    }
}
