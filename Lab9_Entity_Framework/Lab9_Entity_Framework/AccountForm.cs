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

namespace Lab9_Entity_Framework
{
    public partial class AccountForm : Form
    {
        SqlConnection sqlConnection;
        SqlCommand sqlCommand;
        SqlDataAdapter sqlDataAdapter;

        public AccountForm()
        {
            InitializeComponent();
            LoadAccount();
        }

        public void LoadAccount()
        {
            string connectionString = "server=.; database = RestaurantManagement; Integrated Security = true; ";
            sqlConnection = new SqlConnection(connectionString);
            sqlCommand = sqlConnection.CreateCommand();

            sqlCommand.CommandText = "SELECT * FROM Account";

            sqlConnection.Open();
            sqlDataAdapter = new SqlDataAdapter(sqlCommand);
            DataTable dataTable = new DataTable();
            sqlDataAdapter.Fill(dataTable);

            dgvAccount.DataSource = dataTable;

            sqlConnection.Close();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (dgvAccount.CurrentRow != null)
            {
                DateTime thisDay = DateTime.Today;
                string connectionString = "server=.; database = RestaurantManagement; Integrated Security = true;";
                sqlConnection = new SqlConnection(connectionString);

                sqlConnection.Open();
                DataGridViewRow dgvRow = dgvAccount.CurrentRow;
                string accountName = dgvRow.Cells["AccountName"].Value.ToString();
                sqlCommand = new SqlCommand("AddAccount", sqlConnection);
                sqlCommand.CommandType = CommandType.StoredProcedure;
                sqlCommand.Parameters.AddWithValue("@AccountName", dgvRow.Cells["AccountName"].Value == DBNull.Value ? "abc" : dgvRow.Cells["AccountName"].Value.ToString());
                sqlCommand.Parameters.AddWithValue("@Password", dgvRow.Cells["Password"].Value == DBNull.Value ? "12345678" : dgvRow.Cells["Password"].Value.ToString());
                sqlCommand.Parameters.AddWithValue("@FullName", dgvRow.Cells["FullName"].Value == DBNull.Value ? "" : dgvRow.Cells["FullName"].Value.ToString());
                sqlCommand.Parameters.AddWithValue("Email", dgvRow.Cells["Email"].Value == DBNull.Value ? "" : dgvRow.Cells["Email"].Value.ToString());
                sqlCommand.Parameters.AddWithValue("@Tell", dgvRow.Cells["Tell"].Value == DBNull.Value ? "" : dgvRow.Cells["Tell"].Value.ToString());
                sqlCommand.Parameters.AddWithValue("@DateCreated", dgvRow.Cells["DateCreated"].Value == DBNull.Value ? thisDay.ToString() : thisDay.ToString());

                sqlCommand.ExecuteNonQuery();

                MessageBox.Show("Bạn đã thêm tài khoản thành công");
                AddAccountNameToRoleAccount();
                sqlConnection.Close();
                LoadAccount();
            }
        }

        public void AddAccountNameToRoleAccount()
        {
            string connectionString = "server=.; database = RestaurantManagement; Integrated Security = true; ";
            sqlConnection = new SqlConnection(connectionString);
            sqlCommand = sqlConnection.CreateCommand();

            DataGridViewRow dgvRow = dgvAccount.CurrentRow;
            string accountName = dgvRow.Cells["AccountName"].Value.ToString();

            sqlCommand.CommandText = "INSERT INTO RoleAccount(RoleID,AccountName,Actived,Notes) " +
                    "VALUES(4, N'" + accountName + "', 0, NULL)";

            sqlConnection.Open();
            sqlCommand.ExecuteNonQuery();
            sqlConnection.Close();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (dgvAccount.CurrentRow != null)
            {
                DateTime thisDay = DateTime.Today;
                string connectionString = "server=.; database = RestaurantManagement; Integrated Security = true;";
                sqlConnection = new SqlConnection(connectionString);

                sqlConnection.Open();
                DataGridViewRow dgvRow = dgvAccount.CurrentRow;
                sqlCommand = new SqlCommand("UpdateAccount", sqlConnection);
                sqlCommand.CommandType = CommandType.StoredProcedure;
                sqlCommand.Parameters.AddWithValue("@AccountName", dgvRow.Cells["AccountName"].Value.ToString());
                sqlCommand.Parameters.AddWithValue("@Password", dgvRow.Cells["Password"].Value == DBNull.Value ? "12345678" : dgvRow.Cells["Password"].Value.ToString());
                sqlCommand.Parameters.AddWithValue("@FullName", dgvRow.Cells["FullName"].Value == DBNull.Value ? "" : dgvRow.Cells["FullName"].Value.ToString());
                sqlCommand.Parameters.AddWithValue("Email", dgvRow.Cells["Email"].Value == DBNull.Value ? "" : dgvRow.Cells["Email"].Value.ToString());
                sqlCommand.Parameters.AddWithValue("@Tell", dgvRow.Cells["Tell"].Value == DBNull.Value ? "" : dgvRow.Cells["Tell"].Value.ToString());
                sqlCommand.Parameters.AddWithValue("@DateCreated", dgvRow.Cells["DateCreated"].Value.ToString());

                sqlCommand.ExecuteNonQuery();
                MessageBox.Show("Bạn đã cập nhật tài khoản thành công");
                sqlConnection.Close();
                LoadAccount();
            }
        }

        private void tsmiRoleAccount_Click(object sender, EventArgs e)
        {
            RoleAccount dialog = new RoleAccount();
            DataGridViewRow dgvRow = dgvAccount.CurrentRow;
            string accountName = dgvRow.Cells["AccountName"].Value.ToString();
            dialog.LoadRoleAccount(accountName);
            dialog.Show(this);
        }

        private void resetToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string connectionString = "server=.; database = RestaurantManagement; Integrated Security = true; ";
            sqlConnection = new SqlConnection(connectionString);
            sqlCommand = sqlConnection.CreateCommand();

            DataGridViewRow dgvRow = dgvAccount.CurrentRow;
            var accountName = dgvRow.Cells["AccountName"].Value.ToString();

            sqlCommand.CommandText = "UPDATE Account SET Password = '123456789' WHERE AccountName = '" + accountName + "'";

            sqlConnection.Open();
            if ((MessageBox.Show("Bạn có chắc chắn muốn reset mật khẩu cho tài khoản này?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question)) == DialogResult.Yes)
            {
                sqlCommand.ExecuteNonQuery();
                MessageBox.Show("Reset mật khẩu thành công");
            }
            else return;

            LoadAccount();
            sqlConnection.Close();
            sqlConnection.Dispose();
        }

        private void xóaTàiKhoảnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string connectionString = "server=.; database = RestaurantManagement; Integrated Security = true; ";
            sqlConnection = new SqlConnection(connectionString);
            sqlCommand = sqlConnection.CreateCommand();

            DataGridViewRow dgvRow = dgvAccount.CurrentRow;
            var accountName = dgvRow.Cells["AccountName"].Value.ToString();

            sqlCommand.CommandText = "UPDATE RoleAccount SET Actived = 0 WHERE AccountName = '" + accountName + "'";

            sqlConnection.Open();
            if ((MessageBox.Show("Bạn có chắc chắn muốn xóa tài khoản này?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question)) == DialogResult.Yes)
            {
                sqlCommand.ExecuteNonQuery();
                MessageBox.Show("Xóa tài khoản thành công");
            }
            else return;

            LoadAccount();
            sqlConnection.Close();
            sqlConnection.Dispose();
        }
    }
}
