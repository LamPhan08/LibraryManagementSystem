using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibraryManagementSystem.Forms
{
    public partial class ManageMembersForm : Form
    {
        private SqlConnection sqlConnection;
        private SqlDataAdapter dataAdapter;
        private SqlCommand command;
        private DataTable dataTable;
        private BindingManagerBase managerBase;
        private bool isAdded = false;
        private String gender;

        public static int numberOfMembers;

        public ManageMembersForm()
        {
            InitializeComponent();
        }

        private void ManageMembersForm_Load(object sender, EventArgs e)
        {
            label_header_members.Image = Image.FromFile("../../Images/author.png");
            btnAddMember.Image = Image.FromFile("../../Images/add.png");
            btnEditMember.Image = Image.FromFile("../../Images/edit.png");
            btnUpdateMember.Image = Image.FromFile("../../Images/update.png");
            btnDeleteMember.Image = Image.FromFile("../../Images/trash.png");
            btnClear.Image = Image.FromFile("../../Images/broom.png");

            txtMemberID.ReadOnly = true;
            txtMemberFirstName.ReadOnly = true;
            txtMemberLastName.ReadOnly = true;
            btnUpdateMember.Enabled = false;



            try
            {
                sqlConnection = new SqlConnection("Server=DESKTOP-G8ANP0F\\SQLEXPRESS;Database=LIBRARY_MANAGEMENT;Integrated Security=true");
                dataAdapter = new SqlDataAdapter("select * from MEMBERS", sqlConnection);
                SqlCommandBuilder sqlCommandBuilder = new SqlCommandBuilder(dataAdapter);

                numberOfMembers = 0;
                sqlConnection.Open();
                command = new SqlCommand("SELECT COUNT(*) FROM MEMBERS", sqlConnection);
                numberOfMembers = (int)command.ExecuteScalar();
                sqlConnection.Close();

                label_membersCount.Text = numberOfMembers.ToString() + " members";

                dataTable = new DataTable();

                dataAdapter.FillSchema(dataTable, SchemaType.Mapped);
                dataAdapter.Fill(dataTable);

                dataGridView_Members.DataSource = dataTable;

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
                txtMemberID.Text = row["ID"].ToString();
                txtMemberFirstName.Text = row["FIRSTNAME"].ToString();
                txtMemberLastName.Text = row["LASTNAME"].ToString();

                if (row["GENDER_MEMBER"].ToString() == "Male")
                {
                    radioButton_Male.Checked = true;
                }
                if (row["GENDER_MEMBER"].ToString() == "Female")
                {
                    radioButton_Female.Checked = true;
                }

                textBox_Email.Text = row["EMAIL"].ToString();
                textBox_Phone.Text = row["PHONE"].ToString();

                txtMemberFirstName.ReadOnly = true;
                txtMemberLastName.ReadOnly = true;
                textBox_Email.ReadOnly = true;
                textBox_Phone.ReadOnly = true;
                btnEditMember.Enabled = true;
            }
            else
            {
                txtMemberID.Text = "";
                txtMemberFirstName.Text = "";
                txtMemberLastName.Text = "";
                textBox_Email.Text = "";
                textBox_Phone.Text = "";
                btnEditMember.Enabled = false;
            }
        }

        private void btnAddMember_Click(object sender, EventArgs e)
        {
            isAdded = true;

            txtMemberFirstName.ReadOnly = false;
            txtMemberLastName.ReadOnly = false;
            textBox_Email.ReadOnly = false;
            textBox_Phone.ReadOnly = false;

            txtMemberID.Text = "";
            txtMemberFirstName.Text = "";
            txtMemberLastName.Text = "";

            textBox_Email.Text = "";
            textBox_Phone.Text = "";

            txtMemberFirstName.Focus();

            btnUpdateMember.Enabled = true;
        }

        private void btnUpdateMember_Click(object sender, EventArgs e)
        {
            if (txtMemberFirstName.Text.Equals("") || txtMemberLastName.Text.Equals("") || textBox_Email.Text.Equals("") || textBox_Phone.Text.Equals("") || (!radioButton_Female.Checked && !radioButton_Male.Checked))
            {
                MessageBox.Show("Please enter full information!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                DataRow row;

                if (isAdded)
                {
                    row = dataTable.NewRow();

                    row["FIRSTNAME"] = txtMemberFirstName.Text;
                    row["LASTNAME"] = txtMemberLastName.Text;
                    if (radioButton_Male.Checked)
                    {
                        gender = "Male";
                    }
                    if (radioButton_Female.Checked)
                    {
                        gender = "Female";
                    }
                    row["GENDER_MEMBER"] = gender;
                    row["EMAIL"] = textBox_Email.Text;
                    row["PHONE"] = textBox_Phone.Text;

                    dataTable.Rows.Add(row);
                    managerBase.Position = managerBase.Count;

                    MessageBox.Show("Update Successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    numberOfMembers++;
                    label_membersCount.Text = numberOfMembers.ToString() + " members";

                }
                else
                {
                    row = dataTable.Rows[managerBase.Position];
                    row["FIRSTNAME"] = txtMemberFirstName.Text;
                    row["LASTNAME"] = txtMemberLastName.Text;
                    if (radioButton_Male.Checked)
                    {
                        gender = "Male";
                    }
                    if (radioButton_Female.Checked)
                    {
                        gender = "Female";
                    }
                    row["GENDER_MEMBER"] = gender;
                    row["EMAIL"] = textBox_Email.Text;
                    row["PHONE"] = textBox_Phone.Text;

                    MessageBox.Show("Update Successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }

                dataAdapter.Update(dataTable);
                dataTable.AcceptChanges();

                isAdded = false;

                txtMemberFirstName.ReadOnly = true;
                txtMemberLastName.ReadOnly = true;
                radioButton_Female.Checked = false;
                radioButton_Male.Checked = false;
                textBox_Email.ReadOnly = true;
                textBox_Phone.ReadOnly = true;

                btnUpdateMember.Enabled = false;
            }
        }

        private void btnEditMember_Click(object sender, EventArgs e)
        {
            txtMemberFirstName.ReadOnly = false;
            txtMemberLastName.ReadOnly = false;
            radioButton_Female.Checked = false;
            radioButton_Male.Checked = false;
            textBox_Email.ReadOnly = false;
            textBox_Phone.ReadOnly = false;

            txtMemberFirstName.Focus();

            btnUpdateMember.Enabled = true;
        }

        private void btnDeleteMember_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Are you sure you want to delete this member?", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    DataRow row = dataTable.Rows[managerBase.Position];
                    sqlConnection = new SqlConnection("Server=DESKTOP-G8ANP0F\\SQLEXPRESS;Database=LIBRARY_MANAGEMENT;Integrated Security=true");
                    sqlConnection.Open();
                    SqlCommand command = new SqlCommand("Delete from MEMBERS where ID = '" + row["ID"].ToString() + "'", sqlConnection);
                    command.ExecuteNonQuery();
                    sqlConnection.Close();
                    dataTable.Rows[managerBase.Position].Delete();

                    //dataAdapter.Update(dataTable);

                    dataTable.AcceptChanges();

                    ManagerBase_PositionChanged(null, null);

                    MessageBox.Show("Delete Successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    numberOfMembers--;
                    label_membersCount.Text = numberOfMembers.ToString() + " members";
                }
            }
            catch (Exception ex)
            {
                dataTable.RejectChanges();
                MessageBox.Show("Error:\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        

        private void label_close_members_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtMemberID.Text = "";
            txtMemberFirstName.Text = "";
            txtMemberLastName.Text = "";
            radioButton_Female.Checked = false;
            radioButton_Male.Checked = false;
            textBox_Email.Text = "";
            textBox_Phone.Text = "";

            txtMemberFirstName.ReadOnly = true;
            txtMemberLastName.ReadOnly = true;
            textBox_Email.ReadOnly = true;
            textBox_Phone.ReadOnly = true;
        }
    }
}
