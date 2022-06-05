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
    public partial class ManageUsers : Form
    {
        private SqlConnection connection = new SqlConnection("Server=" + Database.Database.connectionName + "; Database=LIBRARY_MANAGEMENT;Integrated Security=true");
        private SqlCommand command;
        public ManageUsers()
        {
            InitializeComponent();
        }

        private void label_close_books_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void ManageUsers_Load(object sender, EventArgs e)
        {
            btnAddUser.Image = Image.FromFile("../../Images/add.png");
            btnDeleteUser.Image = Image.FromFile("../../Images/edit.png");
            btnUpdateUser.Image = Image.FromFile("../../Images/update.png");
            try
            {
                
                connection = new SqlConnection("Server=" + Database.Database.connectionName + ";Database=LIBRARY_MANAGEMENT;Integrated Security=true");
                connection.Open();
                SqlDataAdapter dataAdapter = new SqlDataAdapter("select * from Users where usertype != 'owner'", connection);
                DataSet ds = new DataSet();
                dataAdapter.Fill(ds);
                dataGridView_User.DataSource = ds.Tables[0];
                dataGridView_User.Refresh();
                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public Boolean isUsernameExist(string userName)
        {
            String username = userName;
            Database.Database database = new Database.Database("Users", "select * from users where username = '" + username + "'");
            if (database.Rows.Count>0)
            {
                MessageBox.Show("This username has already existed", "Caution", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return true;
            }
            return false;
        }
        public Boolean isUsernameExistUpdate(string userName)
        {
            int id = Convert.ToInt32(txt_userID.Text);
            String username = userName;
            Database.Database database = new Database.Database("Users", "select * from users where username = '" + username + "'and id != " + id + "");
            if (database.Rows.Count > 0)
            {
                MessageBox.Show("This username has already existed", "Caution", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return true;
            }
            return false;
        }
        public Boolean verify()
        {
            String fname = txt_userFirtstName.Text.Trim();
            String lname = txt_userLastName.Text.Trim();
            String username = txt_username.Text.Trim();
            String password = txt_password.Text.Trim();
            String repass = txt_repass.Text.Trim();
            if(fname.Equals("")||lname.Equals("")||username.Equals("")||password.Equals("")||repass.Equals(""))
            {
                MessageBox.Show("Please fill information that you missed!");
                return false;
            }
            else if(!repass.Equals(password))
            {
                MessageBox.Show("The password you re-enter is not correct!");
                return false;
            }
            return true;
        }

        private void btnAddUser_Click(object sender, EventArgs e)
        {
            String fname = txt_userFirtstName.Text;
            String lname = txt_userLastName.Text;
            String username = txt_username.Text;
            String password = txt_password.Text;
            String userType = "user";
            if(checkbox_setAdmin.Checked)
            {
                userType = "admin";
            }
            if(verify())
            {
                if(isUsernameExist(username))
                {
                    return;
                }
                try
                {
                    connection.Open();
                    String s = "Insert Into Users(FirstName,LastName,UserName,UserPassword,UserType) Values( @firstname,  @lastname,  @username,  @password,@usertype)";
                    command = new SqlCommand(s, connection);
                    command.Parameters.AddWithValue("@firstname", fname);
                    command.Parameters.AddWithValue("@lastname", lname);
                    command.Parameters.AddWithValue("@username", username);
                    command.Parameters.AddWithValue("@password", password);
                    command.Parameters.AddWithValue("@usertype", userType);
                    command.ExecuteNonQuery();
                    connection.Close();
                    MessageBox.Show("Add user Successfully!", "New user", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            else
            {
                MessageBox.Show("Make sure to enter the correct data", "Add-error", MessageBoxButtons.OK);
            }
            try
            {
                connection = new SqlConnection("Server=" + Database.Database.connectionName + ";Database=LIBRARY_MANAGEMENT;Integrated Security=true");
                connection.Open();
                SqlDataAdapter dataAdapter = new SqlDataAdapter("select * from Users where usertype !='owner'", connection);
                DataSet ds = new DataSet();
                dataAdapter.Fill(ds);
                dataGridView_User.DataSource = ds.Tables[0];
                dataGridView_User.Refresh();
                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dataGridView_User_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txt_userID.Text = dataGridView_User.CurrentRow.Cells[0].Value.ToString();
            txt_userFirtstName.Text = dataGridView_User.CurrentRow.Cells[1].Value.ToString();
            txt_userLastName.Text = dataGridView_User.CurrentRow.Cells[2].Value.ToString();
            txt_username.Text = dataGridView_User.CurrentRow.Cells[3].Value.ToString();
            txt_password.Text = dataGridView_User.CurrentRow.Cells[4].Value.ToString();
            String userType= dataGridView_User.CurrentRow.Cells[5].Value.ToString();
            if(userType.Equals("admin"))
            {
                checkbox_setAdmin.Checked = true;
            }
            else
            {
                checkbox_setAdmin.Checked = false;
            }
        }

        private void btnUpdateUser_Click(object sender, EventArgs e)
        {
            int id;
            if(!int.TryParse(txt_userID.Text,out id))
            {
                return;
            }
             id = Convert.ToInt32(txt_userID.Text);
            Database.Database database = new Database.Database("Users", "select * from users where Id = " + id+ "");
            if (database.Rows.Count <= 0)
            { 
                return;
            }
           else
            {
                String fname = txt_userFirtstName.Text;
                String lname = txt_userLastName.Text;
                String username = txt_username.Text;
                String password = txt_password.Text;
                String userType = "user";
                if (checkbox_setAdmin.Checked)
                {
                    userType = "admin";
                }
                if (verify())
                    {
                        if (isUsernameExistUpdate(username))
                        {
                            return;
                        }
                        try
                        {
                            connection.Open();
                            String s = ("Update users set FirstName=@firstname,LastName=@lastname,UserName=@username,UserPassword=@password,UserType=@usertype where Id= '" + id + "'");
                            command = new SqlCommand(s, connection);
                            command.Parameters.AddWithValue("@firstname", fname);
                            command.Parameters.AddWithValue("@lastname", lname);
                            command.Parameters.AddWithValue("@username", username);
                            command.Parameters.AddWithValue("@password", password);
                            command.Parameters.AddWithValue("@usertype", userType);
                            command.ExecuteNonQuery();
                            connection.Close();
                            MessageBox.Show("Update user Successfully!", "New user", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }

                    }
                    else
                    {
                        MessageBox.Show("Make sure to enter the correct data", "Add-error", MessageBoxButtons.OK);
                    }
                try
                {
                    connection = new SqlConnection("Server=" + Database.Database.connectionName + ";Database=LIBRARY_MANAGEMENT;Integrated Security=true");
                    connection.Open();
                    SqlDataAdapter dataAdapter = new SqlDataAdapter("select * from Users where usertype !='owner'", connection);
                    DataSet ds = new DataSet();
                    dataAdapter.Fill(ds);
                    dataGridView_User.DataSource = ds.Tables[0];
                    dataGridView_User.Refresh();
                    connection.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }


        }

        

        private void btnDeleteUser_Click(object sender, EventArgs e)
        {
            int id;
            if (!int.TryParse(txt_userID.Text, out id))
            {
                return;
            }
            id = Convert.ToInt32(txt_userID.Text);
            Database.Database database = new Database.Database("Users", "select * from users where Id = " + id + "");
            if (database.Rows.Count <= 0)
            {
                return;
            }
            if (MessageBox.Show("Are you sure you want to delete this data?", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Database.Database.connection = "Server=" + Database.Database.connectionName + ";Database=LIBRARY_MANAGEMENT;Integrated Security=true";
                connection.Open();
                SqlCommand command = new SqlCommand("Delete from Users where Id = "+id+ "", connection);
                command.ExecuteNonQuery();
                connection.Close();
                MessageBox.Show("Delete user successfully");
            }

            try
            {
                connection = new SqlConnection("Server=" + Database.Database.connectionName + ";Database=LIBRARY_MANAGEMENT;Integrated Security=true");
                connection.Open();
                SqlDataAdapter dataAdapter = new SqlDataAdapter("select * from Users where usertype!= 'owner'", connection);
                DataSet ds = new DataSet();
                dataAdapter.Fill(ds);
                dataGridView_User.DataSource = ds.Tables[0];
                dataGridView_User.Refresh();
                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
