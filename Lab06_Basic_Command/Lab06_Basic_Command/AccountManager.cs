using System;
using System.Data;
using System.Data.SqlClient;
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
            dialog.Show(this);
            dialog.LoadRoleAccount();
        }

    }
}
