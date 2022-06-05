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
    public partial class DashboardForm : Form
    {
        private SqlConnection connection;
        private SqlDataAdapter dataAdapter;
        private SqlCommand command;
        private DataTable dataTable;

        public static int numBooks, numAuthors, numMembers;

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
            btnMembers.Image = Image.FromFile("../../Images/members.png");

            label_book.Text = ManageBooksForm.numberOfBooks.ToString();
            label_author.Text = ManageAuthorsForm.numberOfAuthors.ToString();
            label_member.Text = "0";
        }

        private void picture_close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnGenres_Click(object sender, EventArgs e)
        {
            selectedButton(btnGenres);
            ManageGenresForm manageGenresForm = new ManageGenresForm();
            manageGenresForm.Show();
        }

        private void btnAuthors_Click(object sender, EventArgs e)
        {
            selectedButton(btnAuthors);
            ManageAuthorsForm manageAuthorsForm = new ManageAuthorsForm();
            manageAuthorsForm.Show();
        }

        private void btnBooks_Click(object sender, EventArgs e)
        {
            selectedButton(btnBooks);
            ManageBooksForm manageBooksForm = new ManageBooksForm();
            manageBooksForm.Show();
        }

        private void btnMembers_Click(object sender, EventArgs e)
        {
            selectedButton(btnMembers);
            ManageMembersForm manageMembersForm = new ManageMembersForm();
            manageMembersForm.Show();
        }

        private void btnCirculation_Click(object sender, EventArgs e)
        {
            selectedButton(btnCirculation);
            ManageCirculationForm mngCirF = new ManageCirculationForm();
            mngCirF.Show();

        }

        private void btnUsers_Click(object sender, EventArgs e)
        {
            selectedButton(btnUsers);
            ManageUsers mngUsers = new ManageUsers();
            mngUsers.Show();

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void DashboardForm_Shown(object sender, EventArgs e)
        {
            try
            {
                connection = new SqlConnection("Server=" + Database.Database.connectionName + ";Database=LIBRARY_MANAGEMENT;Integrated Security=true");
                dataAdapter = new SqlDataAdapter("select * from AUTHORS", connection);
                SqlCommandBuilder sqlCommandBuilder = new SqlCommandBuilder(dataAdapter);

                numAuthors = 0;
                connection.Open();
                command = new SqlCommand("SELECT COUNT(*) FROM AUTHORS", connection);
                numAuthors = (int)command.ExecuteScalar();
                connection.Close();

                label_author.Text = numAuthors.ToString();

                numBooks = 0;
                connection.Open();
                command = new SqlCommand("SELECT COUNT(*) FROM BOOKS", connection);
                numBooks = (int)command.ExecuteScalar();
                connection.Close();

                label_book.Text = numBooks.ToString();

                numMembers = 0;
                connection.Open();
                command = new SqlCommand("SELECT COUNT(*) FROM MEMBERS", connection);
                numMembers = (int)command.ExecuteScalar();
                connection.Close();

                label_member.Text = numMembers.ToString();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            try
            {
                Database.Database.connection = "Server=" + Database.Database.connectionName + ";Database=LIBRARY_MANAGEMENT;Integrated Security=true";
                Database.Database database = new Database.Database("BOOKS", "select * from BOOKS");
                if (database.Rows.Count > 0)
                {
                    //byte[] cover1 = (byte[])database.Rows[0][10];
                    //MemoryStream memoryStream1 = new MemoryStream(cover1);
                    //panel_1stBook.BackgroundImage = Image.FromStream(memoryStream1);

                    //byte[] cover2 = (byte[])database.Rows[1][10];
                    //MemoryStream memoryStream2 = new MemoryStream(cover2);
                    //panel_2ndBook.BackgroundImage = Image.FromStream(memoryStream2);

                    //byte[] cover3 = (byte[])database.Rows[2][10];
                    //MemoryStream memoryStream3 = new MemoryStream(cover3);
                    //panel_3rdBook.BackgroundImage = Image.FromStream(memoryStream3);

                    //byte[] cover4 = (byte[])database.Rows[3][10];
                    //MemoryStream memoryStream4 = new MemoryStream(cover4);
                    //panel_4thBook.BackgroundImage = Image.FromStream(memoryStream4);

                    //byte[] cover5 = (byte[])database.Rows[4][10];
                    //MemoryStream memoryStream5 = new MemoryStream(cover5);
                    //panel_5thBook.BackgroundImage = Image.FromStream(memoryStream5);

                    byte[] bytesImage = (byte[])database.Rows[0][10];
                    MemoryStream memoryStream;
                    int i = 0;
                    foreach (var panelControl in panel_displayBooks.Controls)
                    {
                        if (panelControl.GetType() == typeof(Panel))
                        {
                            Panel panel = (Panel)panelControl;
                            bytesImage = (byte[])database.Rows[i][10];
                            memoryStream = new MemoryStream(bytesImage);
                            panel.BackgroundImage = Image.FromStream(memoryStream);
                            panel.BackgroundImageLayout = ImageLayout.Stretch;
                            i++;

                            foreach (var labelControl in panel.Controls)
                            {
                                if (labelControl.GetType() == typeof(Label))
                                {
                                    Label label = (Label)labelControl;

                                    // error
                                    //label.Text = database.Rows[i][6].ToString();
                                }
                            }
                        }
                    }
                    string unsuedPart = ".0000";
                    label_bookPrice1.Text = database.Rows[0][6].ToString().Replace(unsuedPart, "") + "đ";
                    label_bookPrice2.Text = database.Rows[1][6].ToString().Replace(unsuedPart, "") + "đ";
                    label_bookPrice3.Text = database.Rows[2][6].ToString().Replace(unsuedPart, "") + "đ";
                    label_bookPrice4.Text = database.Rows[3][6].ToString().Replace(unsuedPart, "") + "đ";
                    label_bookPrice5.Text = database.Rows[4][6].ToString().Replace(unsuedPart, "") + "đ";
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

        public void selectedButton(Button button)
        {
            foreach (Control control in panel_menu.Controls)
            {
                if (control.GetType() == typeof(Button))
                {
                    Button btn = (Button)control;
                    btn.BackColor = System.Drawing.Color.FromArgb(218, 165, 32);
                }
            }
            button.BackColor = System.Drawing.Color.FromArgb(255, 215, 0);
        }
    }
}
