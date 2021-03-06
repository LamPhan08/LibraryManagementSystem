using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibraryManagementSystem.Database
{
    public class Database : DataTable
    {
        public static SqlConnection sqlConnection;
        SqlDataAdapter dataAdapter;
        string tablename;
        string command;
        public static string connection;

        public static string connectionName = "DESKTOP-J5PVCK3\\SQLEXPRESS";

        //Tạo hàm kết nối đến CSDL thông qua chuỗi kết nối
        private void CreateConnection()
        {
            if (sqlConnection == null)
                sqlConnection = new SqlConnection(connection);
        }
        public Database() : base()
        {

        }
        public Database(string tablename, string command) : base(tablename, command)
        {
            this.tablename = tablename;
            this.command = command;
            ReadTable();
        }
        public void ReadTable()
        {
            try
            {
                CreateConnection();
                if (command == null || command == "")
                    command = "select * from " + tablename;
                dataAdapter = new SqlDataAdapter(command, connection);
                dataAdapter.FillSchema(this, SchemaType.Mapped);
                dataAdapter.Fill(this);
                dataAdapter.SelectCommand.CommandText = "select * from " + tablename;
                SqlCommandBuilder sqlCommandBuilder = new SqlCommandBuilder(dataAdapter);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi:\n" + ex.Message, "Thông báo lỗi!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public bool WriteTable()
        {
            try
            {
                dataAdapter.Update(this);
                this.AcceptChanges();
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi:\n" + ex.Message, "Thông báo lỗi!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.RejectChanges();
                return false;
            }
        }
        public void Rejecting()
        {
            this.RejectChanges();
        }
    }
}

