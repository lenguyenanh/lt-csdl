using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Lab06_Basic_Command
{
    public partial class BillDetailsForm : Form
    {
        SqlConnection sqlConnection;
        SqlCommand sqlCommand;
        SqlDataAdapter dataAdapter;

        public BillDetailsForm()
        {
            InitializeComponent();
        }

        public void LoadBillDetails(int billID)
        {
            string connectionString = "server=.; database = RestaurantManagement; Integrated Security = true;";
            sqlConnection = new SqlConnection(connectionString);
            sqlCommand = sqlConnection.CreateCommand();

            sqlCommand.CommandText = "SELECT Name FROM Bills";

            sqlConnection.Open();
            string billName = sqlCommand.ExecuteScalar().ToString();
            this.Text = billName;

            sqlCommand.CommandText = "SELECT Name, Unit, Price, Price * Quantity As TongTien FROM BillDetails A, Food B " +
                "WHERE A.FoodID = B.ID and A.InvoiceID = " + billID;

            dataAdapter = new SqlDataAdapter(sqlCommand);
            DataTable dataTable = new DataTable();
            dataAdapter.Fill(dataTable);

            dgvBillDetail.DataSource = dataTable;
            sqlConnection.Close();
            sqlConnection.Dispose();
            dataAdapter.Dispose();
        }
    }
}
