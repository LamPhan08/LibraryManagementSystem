using LibraryManagementSystem.Database;
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
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
            btnLogin.Enabled = false;
            pictureLock.Image = Image.FromFile("../../Images/lock.png");
            pictureUser.Image = Image.FromFile("../../Images/user.png");
        }

        private void label_close_MouseEnter(object sender, EventArgs e)
        {
            label_close.ForeColor = Color.Black;
        }

        private void label_close_MouseLeave(object sender, EventArgs e)
        {
            label_close.ForeColor = Color.White;
        }

        private void label_close_MouseClick(object sender, MouseEventArgs e)
        {
            Application.Exit(); 
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (txtUserPassword.Text == "")
            {
                MessageBox.Show("Please enter full information!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                try
                {
                    Database.Database.connection = "Server=" + Database.Database.connectionName + ";Database=LIBRARY_MANAGEMENT;Integrated Security=true";
                    Database.Database database = new Database.Database("USERS", "select USERTYPE from USERS where USERNAME = '" + txtUserName.Text
                        + "' and USERPASSWORD = '" + txtUserPassword.Text + "'");
                    if (database.Rows.Count > 0)
                    {
                        if (database.Rows[0][0].ToString().Equals("owner"))
                        {
                            MessageBox.Show("Login Successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            DashboardForm dashboard = new DashboardForm();
                            dashboard.ShowDialog();
                            Close();
                        }
                        if (database.Rows[0][0].ToString().Equals("admin"))
                        {
                            MessageBox.Show("Login Successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            DashboardForm dashboard = new DashboardForm();
                            dashboard.btnUsers.Enabled = false;
                            dashboard.ShowDialog();
                       
                            Close();
                        }
                        if (database.Rows[0][0].ToString().Equals("user"))
                        {
                            MessageBox.Show("Login Successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            DashboardForm dashboard = new DashboardForm();
                            dashboard.btnUsers.Enabled = false;
                            dashboard.btnCirculation.Enabled = false;
                            dashboard.ShowDialog();

                            Close();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Login Failed!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        txtUserName.Focus();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error:\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void txtUserName_TextChanged(object sender, EventArgs e)
        {
            if (txtUserName.Text != "")
            {
                btnLogin.Enabled = true;
            }
            else
            {
                btnLogin.Enabled = false;
            }
        }

        private void label_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
