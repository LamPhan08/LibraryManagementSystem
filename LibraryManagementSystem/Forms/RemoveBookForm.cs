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
    public partial class RemoveBookForm : Form
    {
        private SqlConnection connection = new SqlConnection("Server=" + Database.Database.connectionName + "; Database=LIBRARY_MANAGEMENT;Integrated Security=true");
        private SqlDataAdapter dataAdapter;
        private DataTable dataTable;
        private SqlCommand command;
        
        public RemoveBookForm()
        {
            InitializeComponent();
        }

        private void label_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button_deleteBook_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(numericUpDown_BookId.Value);
            DialogResult result = MessageBox.Show("Do you REALLY want to delete this book?", "Warning!", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                try
                {
                    Database.Database.connection = "Server=" + Database.Database.connectionName + ";Database=LIBRARY_MANAGEMENT;Integrated Security=true";
                    Database.Database database = new Database.Database("BOOKS", "select * from BOOKS where ISBN = '" + id + "'");

                    connection.Open();
                    command = new SqlCommand("DELETE FROM BOOKS WHERE ID = " + id, connection);

                    command.ExecuteNonQuery();
                    connection.Close();

                    MessageBox.Show("Delete Successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    ManageBooksForm.numberOfBooks--;

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error:\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                Close();
            }
        }
    }
}
