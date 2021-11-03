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

        public void LoadRoleAccount()
        {
            string connectionString = "server=.; database = RestaurantManagement; Integrated Security = true; ";
            sqlConnection = new SqlConnection(connectionString);
            sqlCommand = sqlConnection.CreateCommand();

            sqlCommand.CommandText = "SELECT * FROM RoleAccount" ;

            sqlConnection.Open();
            sqlDataAdapter = new SqlDataAdapter(sqlCommand);
            DataTable dataTable = new DataTable();
            sqlDataAdapter.Fill(dataTable);

            dgvRoleAccount.DataSource = dataTable;

            sqlConnection.Close();
        }
    }
}
