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
    public partial class ManageCirculationForm : Form
    {
        private SqlConnection connection = new SqlConnection("Server=" + Database.Database.connectionName + "; Database=LIBRARY_MANAGEMENT;Integrated Security=true");
        private SqlCommand command;
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
            Database.Database database3 = new Database.Database("Issue", "select Count (*) from issue where bookid = '" + Convert.ToInt32(numericUpDown_BookID.Value) + "'");

            Database.Database database = new Database.Database("Books", "select * from BOOKS where ID = '" + Convert.ToInt32(numericUpDown_BookID.Value) + "'");
            if(database.Rows.Count>0)
            {
                label_bookTitle.Text = database.Rows[0][2].ToString();
                label_bookTitle.ForeColor = Color.LightGreen;
                if(database3.Rows.Count>0)
                {
                    int issue_book = Int32.Parse(database3.Rows[0][0].ToString());
                    int available_book = Int32.Parse(database.Rows[0][5].ToString());
                    if (issue_book < available_book)
                        {
                        label_available.Text = "Yes";
                        label_available.ForeColor = Color.LightGreen;
                    }
                    else
                    {
                        label_available.Text = "No";
                        label_available.ForeColor = Color.Red;
                    }
                }
            }
            else
            {
                label_bookTitle.Text = "This book does not exist";
                label_bookTitle.ForeColor = Color.Red;
                label_available.Text = "Yes Or No";
                label_available.ForeColor = Color.LightCoral;
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
                label_memberFullName.Text = database.Rows[0][1].ToString() + " "+database.Rows[0][2].ToString();
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

        private void btn_IssueBook_Click(object sender, EventArgs e)
        {
            DateTime issueDate = dateTimePicker_Issue.Value;
            DateTime returnDate = dateTimePicker_Return.Value;
                Database.Database.connection = "Server=" + Database.Database.connectionName + ";Database=LIBRARY_MANAGEMENT;Integrated Security=true";
                Database.Database database = new Database.Database("Books", "select * from books where ID = '" + Convert.ToInt32(numericUpDown_BookID.Value) + "'");
                Database.Database database1 = new Database.Database("Members", "select * from members where ID = '" + Convert.ToInt32(numericUpDown_memberID.Value) + "'");
                Database.Database database2 = new Database.Database("Issue", "select * from issue where memId = '" + Convert.ToInt32(numericUpDown_memberID.Value) + "'And bookId = '" + Convert.ToInt32(numericUpDown_BookID.Value) + "'");
          Database.Database database3 = new Database.Database("Issue", "select Count (*) from issue where bookid = '" + Convert.ToInt32(numericUpDown_BookID.Value) + "'");
            
            if(database.Rows.Count>0&& database3.Rows.Count > 0)
            {
                int issue_book = Int32.Parse(database3.Rows[0][0].ToString());
                int available_book = Int32.Parse(database.Rows[0][5].ToString());
                if(issue_book >= available_book)
                {
                    MessageBox.Show("This book is not available now!");
                    return;
                }
            }
            if (database.Rows.Count<=0)
            {
                MessageBox.Show("Please choose book!");
                return;
            }
          else  if(database1.Rows.Count<=0)
            {
                MessageBox.Show("Please choose member!");
                return;
            }
            else if(returnDate<issueDate)
            {
                MessageBox.Show("The return date cannot be before the issue date!");
                return;
            }
            else if(database2.Rows.Count>0)
             {
                MessageBox.Show("The member is borrowing this book!");
                return;
            }
            else
            {
                connection.Open();
                String s = "Insert Into Issue(BookId,MemID,Statut,Issue_date,Return_date,Note) Values( @bookid,  @memid,  @statut,  @issue,   @return,@note)";
                command = new SqlCommand(s, connection);
                   command.Parameters.AddWithValue("@bookid", Convert.ToInt32(numericUpDown_BookID.Value));
               command.Parameters.AddWithValue("@memid", Convert.ToInt32(numericUpDown_memberID.Value));
                command.Parameters.AddWithValue("@statut", "issued");
                command.Parameters.AddWithValue("@issue", dateTimePicker_Issue.Value);
                command.Parameters.AddWithValue("@return",dateTimePicker_Return.Value);
                command.Parameters.AddWithValue("@note", richTextBox_note.Text);
                command.ExecuteNonQuery();
                connection.Close();

                MessageBox.Show("Issue Successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            
            }

        private void btn_issue_Click(object sender, EventArgs e)
        {
            panel_issue.BringToFront();
        }

        private void btn_return_Click(object sender, EventArgs e)
        {
            panel_return.BringToFront();
        }
    }
    }

