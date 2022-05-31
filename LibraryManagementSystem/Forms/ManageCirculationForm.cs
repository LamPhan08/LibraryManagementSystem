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
    public partial class ManageCirculationForm : Form
    {
        public ManageCirculationForm()
        {
            InitializeComponent();
        }

        private void label_close_books_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ManageCirculationForm_Load(object sender, EventArgs e)
        {
            btn_issue.Image = Image.FromFile("../../Images/issue_book.png");
            btn_return.Image = Image.FromFile("../../Images/return_book.png");
        }

        private void label_header_books_Click(object sender, EventArgs e)
        {

        }

        private void numericUpDown_BookQuantity_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btn_SearchBook_Click(object sender, EventArgs e)
        {
            Database.Database.connection = "Server=" + Database.Database.connectionName + ";Database=LIBRARY_MANAGEMENT;Integrated Security=true";
            Database.Database database = new Database.Database("Books", "select * from BOOKS where ID = '" + Convert.ToInt32(numericUpDown_BookID.Value) + "'");
            if(database.Rows.Count>0)
            {
                label_bookTitle.Text = database.Rows[0][2].ToString();
                label_bookTitle.ForeColor = Color.LightGreen;
            }
            else
            {
                label_bookTitle.Text = "This book does not exits";
                label_bookTitle.ForeColor = Color.Red;
            }
        }

        private void panel_issue_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btn_SearchMember_Click(object sender, EventArgs e)
        {
            Database.Database.connection = "Server=" + Database.Database.connectionName + ";Database=LIBRARY_MANAGEMENT;Integrated Security=true";
            Database.Database database = new Database.Database("Members", "select * from Members where ID = '" + numericUpDown_memberID.Value + "'");
            if (database.Rows.Count > 0)
            {
                label_memberFullName.Text = database.Rows[0][2].ToString();
                label_memberFullName.ForeColor = Color.LightGreen;
            }
            else
            {
                label_memberFullName.Text = "This member does not exits";
                label_memberFullName.ForeColor = Color.Red;
            }
        }

        private void label_bookTitle_Click(object sender, EventArgs e)
        {
            BookInfoCard infoCard = new BookInfoCard(Convert.ToInt32(numericUpDown_BookID.Value));
            infoCard.ShowDialog();
        }

        private void label_bookTitle_MouseEnter(object sender, EventArgs e)
        {
            label_bookTitle.Font = new Font(label_bookTitle.Font.FontFamily, 14, FontStyle.Underline);
               
        }

        private void label_bookTitle_MouseLeave(object sender, EventArgs e)
        {
            label_bookTitle.Font = new Font(label_bookTitle.Font.FontFamily, 12, FontStyle.Regular);
        }

        private void label_memberFullName_MouseEnter(object sender, EventArgs e)
        {
            label_memberFullName.Font = new Font(label_memberFullName.Font.FontFamily, 14, FontStyle.Underline);
        }

        private void label_memberFullName_MouseLeave(object sender, EventArgs e)
        {
            label_memberFullName.Font = new Font(label_memberFullName.Font.FontFamily, 12, FontStyle.Regular);
        }

        private void label_memberFullName_Click(object sender, EventArgs e)
        {
            MemberInfoCard memberInfo = new MemberInfoCard(Convert.ToInt32(numericUpDown_memberID.Value));
            memberInfo.ShowDialog();
        }
    }
}
