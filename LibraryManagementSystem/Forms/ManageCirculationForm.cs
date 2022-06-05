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
            try
            {
                connection = new SqlConnection("Server=" + Database.Database.connectionName + ";Database=LIBRARY_MANAGEMENT;Integrated Security=true");
                connection.Open();
               SqlDataAdapter dataAdapter = new SqlDataAdapter("select * from Issue", connection);
                DataSet ds = new DataSet();
                dataAdapter.Fill(ds);
                dataGridView_issue.DataSource = ds.Tables[0];
                dataGridView_issue.Refresh();
                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
           
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
            Database.Database database3 = new Database.Database("Issue", "select Count (*) from issue where bookid = '" + Convert.ToInt32(numericUpDown_BookID.Value) + "'And statut ='issued'");

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
                Database.Database database2 = new Database.Database("Issue", "select * from issue where memId = '" + Convert.ToInt32(numericUpDown_memberID.Value) + "'And bookId = '" + Convert.ToInt32(numericUpDown_BookID.Value) + "'And statut = '" + "issued" + "'");
          Database.Database database3 = new Database.Database("Issue", "select Count (*) from issue where bookid = '" + Convert.ToInt32(numericUpDown_BookID.Value) + "'And statut = '" + "issued" + "'");

            if (database.Rows.Count>0&& database3.Rows.Count > 0)
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

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView_issue_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            numericUpDown_BookId2.Value = (int)dataGridView_issue.CurrentRow.Cells[0].Value;
            numericUpDown_memberId2.Value = (int)dataGridView_issue.CurrentRow.Cells[1].Value;
           dateTimePicker_Issue2.Value = (DateTime)dataGridView_issue.CurrentRow.Cells[3].Value;
            dateTimePicker_return2.Value = (DateTime)dataGridView_issue.CurrentRow.Cells[4].Value;
            richTextBox_decription2.Text = dataGridView_issue.CurrentRow.Cells[5].Value.ToString();
            Database.Database database = new Database.Database("Books", "select * from books where ID = '" + Convert.ToInt32(numericUpDown_BookId2.Value) + "'");
            Database.Database database1 = new Database.Database("Members", "select * from members where ID = '" + Convert.ToInt32(numericUpDown_memberId2.Value) + "'");
            label_bookTitle2.Text =  database.Rows[0][2].ToString();
            label_memberFullName2.Text = database1.Rows[0][1].ToString()+"  "+ database1.Rows[0][2].ToString();
        }

       


       

        private void button_showIssued_Click(object sender, EventArgs e)
        {
            try
            {
                connection = new SqlConnection("Server=" + Database.Database.connectionName + ";Database=LIBRARY_MANAGEMENT;Integrated Security=true");
                connection.Open();
                SqlDataAdapter dataAdapter = new SqlDataAdapter("select * from Issue where Statut ='" + "issued"  +"'", connection);
                DataSet ds = new DataSet();
                dataAdapter.Fill(ds);
                dataGridView_issue.DataSource = ds.Tables[0];
                dataGridView_issue.Refresh();
                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button_showReturn(object sender, EventArgs e)
        {
            try
            {
                connection = new SqlConnection("Server=" + Database.Database.connectionName + ";Database=LIBRARY_MANAGEMENT;Integrated Security=true");
                connection.Open();
                SqlDataAdapter dataAdapter = new SqlDataAdapter("select * from Issue where Statut ='" + "returned" + "'", connection);
                DataSet ds = new DataSet();
                dataAdapter.Fill(ds);
                dataGridView_issue.DataSource = ds.Tables[0];
                dataGridView_issue.Refresh();
                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button_showLost_Click(object sender, EventArgs e)
        {
            try
            {
                connection = new SqlConnection("Server=" + Database.Database.connectionName + ";Database=LIBRARY_MANAGEMENT;Integrated Security=true");
                connection.Open();
                SqlDataAdapter dataAdapter = new SqlDataAdapter("select * from Issue where Statut ='" + "lost" + "'", connection);
                DataSet ds = new DataSet();
                dataAdapter.Fill(ds);
                dataGridView_issue.DataSource = ds.Tables[0];
                dataGridView_issue.Refresh();
                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button_showAll_Click(object sender, EventArgs e)
        {
            try
            {
                connection = new SqlConnection("Server=" + Database.Database.connectionName + ";Database=LIBRARY_MANAGEMENT;Integrated Security=true");
                connection.Open();
                SqlDataAdapter dataAdapter = new SqlDataAdapter("select * from Issue ", connection);
                DataSet ds = new DataSet();
                dataAdapter.Fill(ds);
                dataGridView_issue.DataSource = ds.Tables[0];
                dataGridView_issue.Refresh();
                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button_BookReturn(object sender, EventArgs e)
        {
            Database.Database database2 = new Database.Database("Issue", "select * from issue where memId = '" + Convert.ToInt32(numericUpDown_memberId2.Value) + "'And bookId = '" + Convert.ToInt32(numericUpDown_BookId2.Value) + "'");
            if(database2.Rows.Count<=0)
            {
                return;
            }
            if (database2.Rows[0][2].ToString().Equals("returned"))
            {
                MessageBox.Show("This book has already returned");
                return;
            }
            if (database2.Rows[0][2].ToString().Equals("lost"))
            {
                MessageBox.Show("This book has already lost!");
                return;
            }
            int bookId = Convert.ToInt32(numericUpDown_BookId2.Value);
            int memId = Convert.ToInt32(numericUpDown_memberId2.Value);
            DateTime issueDate = dateTimePicker_Issue2.Value;
            DateTime returnDate = dateTimePicker_return2.Value;
            String note = richTextBox_decription2.Text;
            if (issueDate < returnDate)
            {
                Database.Database.connection = "Server=" + Database.Database.connectionName + ";Database=LIBRARY_MANAGEMENT;Integrated Security=true";
                connection.Open();
                command = new SqlCommand("UPDATE issue SET statut = '" + "returned" + "' where bookid =" + bookId, connection);
                SqlCommand command2 = new SqlCommand("UPDATE issue SET return_date = '" + returnDate + "' where bookid =" + bookId, connection);
                SqlCommand command3 = new SqlCommand("UPDATE issue SET note = '" + note + "' where bookid =" + bookId, connection);
                command2.ExecuteNonQuery();
                command2.ExecuteNonQuery();
                command3.ExecuteNonQuery();
                command.ExecuteNonQuery();
                connection.Close();
                try
                {
                    connection = new SqlConnection("Server=" + Database.Database.connectionName + ";Database=LIBRARY_MANAGEMENT;Integrated Security=true");
                    connection.Open();
                    SqlDataAdapter dataAdapter = new SqlDataAdapter("select * from Issue", connection);
                    DataSet ds = new DataSet();
                    dataAdapter.Fill(ds);
                    dataGridView_issue.DataSource = ds.Tables[0];
                    dataGridView_issue.Refresh();
                    connection.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                MessageBox.Show("Book returned ", "Statut", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            else
            {
                MessageBox.Show("The return date should not before the issue date");
                return;
            }

        }

        private void button_BookLost_Click(object sender, EventArgs e)
        {
            Database.Database database2 = new Database.Database("Issue", "select * from issue where memId = '" + Convert.ToInt32(numericUpDown_memberId2.Value) + "'And bookId = '" + Convert.ToInt32(numericUpDown_BookId2.Value) + "'");
            if(database2.Rows.Count<=0)
            {
                return;
            }
            if (database2.Rows[0][2].ToString().Equals("lost"))
            {
                MessageBox.Show("This book has already lost");
                return;
            }
            int bookId = Convert.ToInt32(numericUpDown_BookId2.Value);
            int memId = Convert.ToInt32(numericUpDown_memberId2.Value);
            DateTime issueDate = dateTimePicker_Issue2.Value;
            DateTime returnDate = dateTimePicker_return2.Value;
                Database.Database.connection = "Server=" + Database.Database.connectionName + ";Database=LIBRARY_MANAGEMENT;Integrated Security=true";
                connection.Open();
             SqlCommand  command2=new SqlCommand("UPDATE Books SET Quantity = Quantity -1 where id =" + bookId , connection);
            command = new SqlCommand("UPDATE issue SET statut = '" + "lost" + "' where bookid =" + bookId, connection);
            command2.ExecuteNonQuery();
                command.ExecuteNonQuery();
            connection.Close();
                try
                {
                    connection = new SqlConnection("Server=" + Database.Database.connectionName + ";Database=LIBRARY_MANAGEMENT;Integrated Security=true");
                    connection.Open();
                    SqlDataAdapter dataAdapter = new SqlDataAdapter("select * from Issue", connection);
                    DataSet ds = new DataSet();
                    dataAdapter.Fill(ds);
                    dataGridView_issue.DataSource = ds.Tables[0];
                    dataGridView_issue.Refresh();
                    connection.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                MessageBox.Show("Book lost ", "Statut", MessageBoxButtons.OK, MessageBoxIcon.Information);
        
        }

        private void button_delete_Click(object sender, EventArgs e)
        {
            
            Database.Database database2 = new Database.Database("Issue", "select * from issue where memId = '" + Convert.ToInt32(numericUpDown_memberId2.Value) + "'And bookId = '" + Convert.ToInt32(numericUpDown_BookId2.Value) + "'");
            if (database2.Rows.Count <= 0)
            {
                return;
            }
            if (MessageBox.Show("Are you sure you want to delete this data?", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Database.Database.connection = "Server=" + Database.Database.connectionName + ";Database=LIBRARY_MANAGEMENT;Integrated Security=true";
                connection.Open();
                SqlCommand command = new SqlCommand("Delete from Issue where memId = '" + Convert.ToInt32(numericUpDown_memberId2.Value) + "'And bookId = '" + Convert.ToInt32(numericUpDown_BookId2.Value) + "'", connection);
                command.ExecuteNonQuery();
                connection.Close();
                MessageBox.Show("Delete data successfully");
            }
               
            try
            {
                connection = new SqlConnection("Server=" + Database.Database.connectionName + ";Database=LIBRARY_MANAGEMENT;Integrated Security=true");
                connection.Open();
                SqlDataAdapter dataAdapter = new SqlDataAdapter("select * from Issue", connection);
                DataSet ds = new DataSet();
                dataAdapter.Fill(ds);
                dataGridView_issue.DataSource = ds.Tables[0];
                dataGridView_issue.Refresh();
                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        }
    }

