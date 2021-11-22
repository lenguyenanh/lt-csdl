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

namespace Lab8_N_Tier
{
    public partial class RoleAccount : Form
    {
        string accountName;
        SqlConnection sqlConnection;
        SqlCommand sqlCommand;
        SqlDataAdapter sqlDataAdapter;

        public RoleAccount()
        {
            InitializeComponent();
        }

        public void LoadRoleName()
        {
            string connectionString = "server=.; database = RestaurantManagement; Integrated Security = true;";
            sqlConnection = new SqlConnection(connectionString);
            sqlCommand = sqlConnection.CreateCommand();
            sqlCommand.CommandText = "SELECT ID, RoleName FROM Role";
            sqlDataAdapter = new SqlDataAdapter(sqlCommand);
            DataTable dataTable = new DataTable();

            sqlConnection.Open();
            sqlDataAdapter.Fill(dataTable);

            cbbRoleName.DataSource = dataTable;
            cbbRoleName.DisplayMember = "RoleName";
            cbbRoleName.ValueMember = "ID";
            sqlConnection.Close();
            sqlConnection.Dispose();
        }

        public void LoadRoleAccount(string accountName)
        {
            this.accountName = accountName;
            string connectionString = "server=.; database = RestaurantManagement; Integrated Security = true; ";
            sqlConnection = new SqlConnection(connectionString);
            sqlCommand = sqlConnection.CreateCommand();

            sqlCommand.CommandText = "SELECT AccountName FROM Account WHERE AccountName = '" + accountName + "'";

            sqlConnection.Open();
            string titleName = sqlCommand.ExecuteScalar().ToString();
            this.Text = "Danh sách vai trò của tài khoản: " + titleName;

            sqlCommand.CommandText = "SELECT AccountName, ID, RoleName, Path, A.Notes FROM Role A, RoleAccount B " +
                "WHERE A.ID = B.RoleID and B.AccountName = '" + accountName + "'";

            sqlDataAdapter = new SqlDataAdapter(sqlCommand);
            DataTable dataTable = new DataTable();
            sqlDataAdapter.Fill(dataTable);

            dgvRoleAccount.DataSource = dataTable;

            dgvRoleAccount.Columns["AccountN"].ReadOnly = true;

            sqlConnection.Close();
            LoadRoleName();
        }

        private void dgvRoleAccount_Click(object sender, EventArgs e)
        {
            if (dgvRoleAccount.CurrentRow != null)
            {
                DataGridViewRow dgvRow = dgvRoleAccount.CurrentRow;
                cbbRoleName.Text = dgvRow.Cells["RoleName"].Value.ToString();
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (dgvRoleAccount.CurrentRow != null)
            {
                string connectionString = "server=.; database = RestaurantManagement; Integrated Security = true;";
                sqlConnection = new SqlConnection(connectionString);
                DataGridViewRow dgvRow = dgvRoleAccount.CurrentRow;

                sqlConnection.Open();

                sqlCommand = new SqlCommand("UpdateRoleAccount", sqlConnection);
                sqlCommand.CommandType = CommandType.StoredProcedure;

                sqlCommand.Parameters.AddWithValue("@RoleID", cbbRoleName.SelectedValue);
                sqlCommand.Parameters.AddWithValue("@AccountName", dgvRow.Cells["AccountN"].Value);

                int num = sqlCommand.ExecuteNonQuery();

                if (num > 0)
                {
                    MessageBox.Show("Bạn đã cập nhật vai trò thành công");
                }
                else
                    MessageBox.Show("Bad");
                sqlConnection.Close();
                LoadRoleAccount(accountName);
            }
        }
    }
}
