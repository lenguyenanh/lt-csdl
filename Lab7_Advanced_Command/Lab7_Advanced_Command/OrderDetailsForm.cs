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

namespace Lab7_Advanced_Command
{
    public partial class OrderDetailsForm : Form
    {
        SqlConnection sqlConnection;
        SqlCommand sqlCommand;
        SqlDataAdapter sqlDataAdapter;

        public OrderDetailsForm()
        {
            InitializeComponent();
        }

        public void LoadBillDetails(int billID)
        {
            string connectionString = "server=.; database = RestaurantManagement; Integrated Security = true;";
            sqlConnection = new SqlConnection(connectionString);
            sqlCommand = sqlConnection.CreateCommand();
            sqlCommand.CommandText = "SELECT Name FROM Bills WHERE ID = " + billID;          

            sqlConnection.Open();
            string billName = sqlCommand.ExecuteScalar().ToString();
            this.Text = "Danh sách hóa đơn: " + billName;

            sqlCommand.CommandText = "SELECT A.Name As TenMonAn, A.Unit As DonVi, A.Price As Gia, Price * Quantity As TongTien "+
                "FROM Food A, BillDetails B WHERE A.ID = B.FoodID and B.InvoiceID = " + billID;
            sqlCommand.ExecuteNonQuery();
            sqlDataAdapter = new SqlDataAdapter(sqlCommand);
            DataTable dataTable = new DataTable();
            sqlDataAdapter.Fill(dataTable);

            dgvBillDetails.DataSource = dataTable;
            sqlConnection.Close();
            sqlConnection.Dispose();
        }
    }
}
