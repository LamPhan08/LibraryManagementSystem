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
    public partial class ManageGenresForm : Form
    {
        private SqlConnection sqlConnection;
        private SqlDataAdapter dataAdapter;
        private DataTable dataTable;
        private BindingManagerBase managerBase;
        private bool isAdded = false;

        
        public ManageGenresForm()
        {
            InitializeComponent();
        }

        private void label_close_genres_MouseEnter(object sender, EventArgs e)
        {
            label_close_genres.ForeColor = Color.Black;
        }

        private void label_close_genres_MouseLeave(object sender, EventArgs e)
        {
            label_close_genres.ForeColor = Color.White;
        }

        private void label_close_genres_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void ManageGenresForm_Load(object sender, EventArgs e)
        {
            label_header_genres.Image = Image.FromFile("../../Images/genres.png");
            btnAddGenre.Image = Image.FromFile("../../Images/add.png");
            btnEditGenre.Image = Image.FromFile("../../Images/edit.png");
            btnUpdateGenre.Image = Image.FromFile("../../Images/update.png");
            btnDeleteGenre.Image = Image.FromFile("../../Images/trash.png");

            txtGenreName.ReadOnly = true;
            txtGenreID.ReadOnly = true;
            btnUpdateGenre.Enabled = false;

            

            try
            {
                sqlConnection = new SqlConnection("Server=.;Database=LIBRARY_MANAGEMENT;Integrated Security=true");
                dataAdapter = new SqlDataAdapter("select * from GENRES", sqlConnection);
                SqlCommandBuilder sqlCommandBuilder = new SqlCommandBuilder(dataAdapter);
                dataTable = new DataTable();
                dataAdapter.FillSchema(dataTable, SchemaType.Mapped);
                dataAdapter.Fill(dataTable);
                dataGridView_Genres.DataSource = dataTable;
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
                txtGenreName.Text = row["NAME"].ToString();
                txtGenreID.Text = row["ID"].ToString();
                txtGenreName.ReadOnly = true;
                btnEditGenre.Enabled = true;
            }
            else
            {
                txtGenreName.Text = "";
                txtGenreID.Text = "";
                btnEditGenre.Enabled = false;
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            isAdded = true;

            txtGenreName.ReadOnly = false;

            txtGenreName.Text = "";

            txtGenreID.Text = "";

            txtGenreName.Focus();

            btnUpdateGenre.Enabled = true;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (txtGenreName.Text.Equals(""))
            {
                MessageBox.Show("Please enter name!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                try
                {
                    DataRow row;

                    if (isAdded) {
                        row = dataTable.NewRow();

                        Database.Database.connection = "Server=.;Database=LIBRARY_MANAGEMENT;Integrated Security=true";
                        Database.Database database = new Database.Database("GENRES", "select NAME from GENRES where NAME = '" + txtGenreName.Text + "'");

                        if (database.Rows.Count > 0)
                        {
                            MessageBox.Show("This genre already exists!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                            ManagerBase_PositionChanged(null, null);
                        }
                        else
                        {
                            row["NAME"] = txtGenreName.Text;

                            dataTable.Rows.Add(row);
                            managerBase.Position = managerBase.Count;

                            MessageBox.Show("Update Successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                    else {
                        row = dataTable.Rows[managerBase.Position];
                        row["NAME"] = txtGenreName.Text;

                        MessageBox.Show("Update Successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    }

                    dataAdapter.Update(dataTable);
                    dataTable.AcceptChanges();

                    isAdded = false;

                    txtGenreName.ReadOnly = true;

                    btnUpdateGenre.Enabled = false;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error:\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);  

                    txtGenreName.Clear();
                    txtGenreID.Clear();
                }
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            txtGenreName.ReadOnly = false;
            txtGenreName.Focus();
            btnUpdateGenre.Enabled = true;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Are you sure you want to delete it?", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    DataRow row = dataTable.Rows[managerBase.Position];
                    sqlConnection = new SqlConnection("Server=.;Database=LIBRARY_MANAGEMENT;Integrated Security=true");
                    sqlConnection.Open();
                    SqlCommand command = new SqlCommand("Delete from GENRES where ID = '" + row["ID"].ToString() + "'", sqlConnection);
                    command.ExecuteNonQuery();
                    sqlConnection.Close();
                    dataTable.Rows[managerBase.Position].Delete();

                    //dataAdapter.Update(dataTable);

                    dataTable.AcceptChanges();

                    ManagerBase_PositionChanged(null, null);

                    MessageBox.Show("Delete Successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                dataTable.RejectChanges();
                MessageBox.Show("Error:\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
