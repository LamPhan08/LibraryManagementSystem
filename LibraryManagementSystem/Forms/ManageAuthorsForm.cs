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
    public partial class ManageAuthorsForm : Form
    {
        private SqlConnection sqlConnection;
        private SqlDataAdapter dataAdapter;
        private SqlCommand command;
        private DataTable dataTable;
        private BindingManagerBase managerBase;
        private bool isAdded = false;

        public static int numberOfAuthors;

        public ManageAuthorsForm()
        {
            InitializeComponent();
        }

        private void label_close_authors_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void ManageAuthorsForm_Load(object sender, EventArgs e)
        {
            label_header_authors.Image = Image.FromFile("../../Images/author.png");
            btnAddAuthor.Image = Image.FromFile("../../Images/add.png");
            btnEditAuthor.Image = Image.FromFile("../../Images/edit.png");
            btnUpdateAuthor.Image = Image.FromFile("../../Images/update.png");
            btnDeleteAuthor.Image = Image.FromFile("../../Images/trash.png");
            btnShowAuthorBooks.Image = Image.FromFile("../../Images/books.png");

            txtAuthorID.ReadOnly = true;
            txtAuthorFirstName.ReadOnly = true;
            txtAuthorLastName.ReadOnly = true;
            txtAuthorEducation.ReadOnly = true;
            richTextBox_AuthorBio.ReadOnly = true;
            btnUpdateAuthor.Enabled = false;

            

            try
            {
                sqlConnection = new SqlConnection("Server=DESKTOP-G8ANP0F\\SQLEXPRESS;Database=LIBRARY_MANAGEMENT;Integrated Security=true");
                dataAdapter = new SqlDataAdapter("select * from AUTHORS", sqlConnection);
                SqlCommandBuilder sqlCommandBuilder = new SqlCommandBuilder(dataAdapter);

                numberOfAuthors = 0;
                sqlConnection.Open();
                command = new SqlCommand("SELECT COUNT(*) FROM AUTHORS", sqlConnection);
                numberOfAuthors = (int)command.ExecuteScalar();
                sqlConnection.Close();

                label_authorsCount.Text = numberOfAuthors.ToString() + " authors";

                dataTable = new DataTable();

                dataAdapter.FillSchema(dataTable, SchemaType.Mapped);
                dataAdapter.Fill(dataTable);

                dataGridView_Authors.DataSource = dataTable;

                managerBase = BindingContext[dataTable];

                managerBase.PositionChanged += ManagerBase_PositionChanged;
                ManagerBase_PositionChanged(null, null);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ManagerBase_PositionChanged(object sender, EventArgs e)
        {
            if (managerBase.Position >= 0)
            {
                DataRow row = dataTable.Rows[managerBase.Position];
                txtAuthorID.Text = row["ID"].ToString();
                txtAuthorFirstName.Text = row["FIRSTNAME"].ToString();
                txtAuthorLastName.Text = row["LASTNAME"].ToString();
                txtAuthorEducation.Text = row["EDUCATION"].ToString();
                richTextBox_AuthorBio.Text = row["BIO"].ToString();

                txtAuthorFirstName.ReadOnly = true;
                txtAuthorLastName.ReadOnly = true;
                txtAuthorEducation.ReadOnly = true;
                richTextBox_AuthorBio.ReadOnly = true;
                btnEditAuthor.Enabled = true;
            }
            else
            {
                txtAuthorID.Text = "";
                txtAuthorFirstName.Text = "";
                txtAuthorLastName.Text = "";
                txtAuthorEducation.Text = "";
                richTextBox_AuthorBio.Text = "";
                btnEditAuthor.Enabled = false;
            }
        }

        private void btnAddAuthor_Click(object sender, EventArgs e)
        {
            isAdded = true;

            txtAuthorFirstName.ReadOnly = false;
            txtAuthorLastName.ReadOnly = false;
            txtAuthorEducation.ReadOnly = false;
            richTextBox_AuthorBio.ReadOnly = false;

            txtAuthorID.Text = "";
            txtAuthorFirstName.Text = "";
            txtAuthorLastName.Text = "";
            txtAuthorEducation.Text = "";
            richTextBox_AuthorBio.Text = "";


            txtAuthorFirstName.Focus();

            btnUpdateAuthor.Enabled = true;
        }

        private void btnUpdateAuthor_Click(object sender, EventArgs e)
        {
            if (txtAuthorFirstName.Text.Equals("") || txtAuthorLastName.Text.Equals("") || txtAuthorEducation.Text.Equals("") || richTextBox_AuthorBio.Text.Equals(""))
            {
                MessageBox.Show("Please enter full information!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                try
                {
                    DataRow row;

                    if (isAdded)
                    {
                        row = dataTable.NewRow();
                       
                        row["FIRSTNAME"] = txtAuthorFirstName.Text;
                        row["LASTNAME"] = txtAuthorLastName.Text;
                        row["EDUCATION"] = txtAuthorEducation.Text;
                        row["BIO"] = richTextBox_AuthorBio.Text;

                        dataTable.Rows.Add(row);
                        managerBase.Position = managerBase.Count;

                        MessageBox.Show("Update Successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        numberOfAuthors++;
                        label_authorsCount.Text = numberOfAuthors.ToString() + " authors";

                    }
                    else
                    {
                        row = dataTable.Rows[managerBase.Position];
                        row["FIRSTNAME"] = txtAuthorFirstName.Text;
                        row["LASTNAME"] = txtAuthorLastName.Text;
                        row["EDUCATION"] = txtAuthorEducation.Text;
                        row["BIO"] = richTextBox_AuthorBio.Text;

                        MessageBox.Show("Update Successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    }

                    dataAdapter.Update(dataTable);
                    dataTable.AcceptChanges();

                    isAdded = false;

                    txtAuthorFirstName.ReadOnly = true;
                    txtAuthorLastName.ReadOnly = true;
                    txtAuthorEducation.ReadOnly = true;
                    richTextBox_AuthorBio.ReadOnly = true;

                    btnUpdateAuthor.Enabled = false;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error:\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    txtAuthorID.Clear();
                    txtAuthorFirstName.Clear();
                    txtAuthorLastName.Clear();
                    txtAuthorEducation.Clear();
                    richTextBox_AuthorBio.Clear();
                }
            }
        }

        private void btnEditAuthor_Click(object sender, EventArgs e)
        {
            txtAuthorFirstName.ReadOnly = false;
            txtAuthorLastName.ReadOnly = false;
            txtAuthorEducation.ReadOnly = false;
            richTextBox_AuthorBio.ReadOnly = false;

            txtAuthorFirstName.Focus();

            btnUpdateAuthor.Enabled = true;
        }

        private void btnDeleteAuthor_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Are you sure you want to delete it?", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    DataRow row = dataTable.Rows[managerBase.Position];
                    sqlConnection = new SqlConnection("Server=DESKTOP-G8ANP0F\\SQLEXPRESS;Database=LIBRARY_MANAGEMENT;Integrated Security=true");
                    sqlConnection.Open();
                    SqlCommand command = new SqlCommand("Delete from AUTHORS where ID = '" + row["ID"].ToString() + "'", sqlConnection);
                    command.ExecuteNonQuery();
                    sqlConnection.Close();
                    dataTable.Rows[managerBase.Position].Delete();

                    //dataAdapter.Update(dataTable);

                    dataTable.AcceptChanges();

                    ManagerBase_PositionChanged(null, null);

                    MessageBox.Show("Delete Successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    numberOfAuthors--;
                    label_authorsCount.Text = numberOfAuthors.ToString() + " authors";
                }
            }
            catch (Exception ex)
            {
                dataTable.RejectChanges();
                MessageBox.Show("Error:\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void label_close_authors_MouseEnter(object sender, EventArgs e)
        {
            label_close_authors.ForeColor = Color.Black;
        }

        private void label_close_authors_MouseLeave(object sender, EventArgs e)
        {
            label_close_authors.ForeColor = Color.White;
        }
    }
}
