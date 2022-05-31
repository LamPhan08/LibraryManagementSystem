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
    public partial class MemberInfoCard : Form
    {
        int memID;
        public MemberInfoCard(int id)
        {
            InitializeComponent();
            memID = id;
        }

        private void MemberInfoCard_Load(object sender, EventArgs e)
        {
            try
            {
                
                Database.Database.connection = "Server=" + Database.Database.connectionName + ";Database=LIBRARY_MANAGEMENT;Integrated Security=true";
                Database.Database database = new Database.Database("Members", "select * from members where ID = '" + memID + "'");
                label_ID.Text = "ID: " + database.Rows[0][0].ToString();
                label_fullName.Text = "Full name: " + database.Rows[0][1].ToString() + " " + database.Rows[0][2].ToString();
                label_gender.Text = "Gender: " + database.Rows[0][3].ToString();
                label_phone.Text = "Phone: " + database.Rows[0][4].ToString();
                label_email.Text = "Email: " + database.Rows[0][5].ToString();
            

            }
            catch (Exception ex)
            {
                MessageBox.Show("No member to show!");
                this.Close();
            }
        }

        private void label_close_books_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
