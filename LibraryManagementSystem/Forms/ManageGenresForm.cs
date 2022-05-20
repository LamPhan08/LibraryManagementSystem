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
        SqlConnection sqlConnection;
        SqlDataAdapter dataAdapter;
        DataTable dataTable;
        BindingManagerBase managerBase;
        bool isAdded = false;
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
            label_header.Image = Image.FromFile("../../Images/genres.png");
            btnAdd.Image = Image.FromFile("../../Images/add.png");
            btnEdit.Image = Image.FromFile("../../Images/edit.png");
            btnUpdate.Image = Image.FromFile("../../Images/update.png");
            btnDelete.Image = Image.FromFile("../../Images/trash.png");

            txtName.ReadOnly = true;
            txtID.ReadOnly = true;
            btnUpdate.Enabled = false;

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
                txtName.Text = row["NAME"].ToString();
                txtID.Text = row["ID"].ToString();
                txtName.ReadOnly = true;
                btnEdit.Enabled = true;
            }
            else
            {
                txtName.Text = "";
                txtID.Text = "";
                btnEdit.Enabled = false;
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            isAdded = true;

            txtName.ReadOnly = false;

            txtName.Text = "";

            txtID.Text = "";

            txtName.Focus();

            btnUpdate.Enabled = true;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (txtName.Text.Equals(""))
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
                    }
                    else {
                        row = dataTable.Rows[managerBase.Position];
                    }
                    row["NAME"] = txtName.Text;

                    if (isAdded)
                    {
                        dataTable.Rows.Add(row);
                        managerBase.Position = managerBase.Count;
                    }

                    dataAdapter.Update(dataTable);
                    dataTable.AcceptChanges();

                    isAdded = false;

                    txtName.ReadOnly = true;

                    MessageBox.Show("Update Successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    btnUpdate.Enabled = false;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error:\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);  

                    txtName.Clear();
                    txtID.Clear();
                }
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            txtName.ReadOnly = false;
            txtName.Focus();
            btnUpdate.Enabled = true;
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

                    txtName.Text = "";

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
