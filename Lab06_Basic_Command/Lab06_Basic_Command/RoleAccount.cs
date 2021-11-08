using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Lab06_Basic_Command
{
    public partial class RoleAccount : Form
    {
        SqlConnection sqlConnection;
        SqlCommand sqlCommand;
        SqlDataAdapter sqlDataAdapter;

        public RoleAccount()
        {
            InitializeComponent();
        }

        public void LoadRoleAccount(string accountName)
        {
            string connectionString = "server=.; database = RestaurantManagement; Integrated Security = true; ";
            sqlConnection = new SqlConnection(connectionString);
            sqlCommand = sqlConnection.CreateCommand();

            sqlCommand.CommandText = "SELECT FullName, A.AccountName, RoleName , Actived FROM RoleAccount A, Role B, Account C " +
                "WHERE A.RoleID = B.ID and A.AccountName = C.AccountName and A.AccountName = '" + accountName + "'";

            sqlConnection.Open();
            sqlDataAdapter = new SqlDataAdapter(sqlCommand);
            DataTable dataTable = new DataTable();
            sqlDataAdapter.Fill(dataTable);

            dgvRoleAccount.DataSource = dataTable;

            sqlConnection.Close();
        }
    }
}
