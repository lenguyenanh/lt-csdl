using System;
using System.Data;
using System.Data.SqlClient;
using System.Globalization;
using System.Windows.Forms;

namespace Lab06_Basic_Command
{
    public partial class AccountManager : Form
    {
        SqlConnection sqlConnection;
        SqlCommand sqlCommand;
        SqlDataAdapter sqlDataAdapter;

        public AccountManager()
        {
            InitializeComponent();
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

        private void xóaTàiKhoảnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RoleAccount dialog = new RoleAccount();
            DataGridViewRow dgvRow = dgvAccount.CurrentRow;
            string accountName = dgvRow.Cells["AccountName"].Value.ToString(); 
            dialog.LoadRoleAccount(accountName);
            dialog.Show(this);
        }

        private void btnResetPass_Click(object sender, EventArgs e)
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

        private void xóaTàiKhoảnToolStripMenuItem1_Click(object sender, EventArgs e)
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
