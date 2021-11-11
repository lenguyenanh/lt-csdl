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
    public partial class OrdersForm : Form
    {
        SqlConnection sqlConnection;
        SqlCommand sqlCommand;
        SqlDataAdapter sqlDataAdapter;

        public OrdersForm()
        {
            InitializeComponent();
            LoadBills();
        }

        public void LoadBills()
        {
            string connectionString = "server=.; database = RestaurantManagement; Integrated Security = true;";
            sqlConnection = new SqlConnection(connectionString);
            sqlCommand = sqlConnection.CreateCommand();
            sqlCommand.CommandText = "SELECT * FROM Bills ";

            sqlConnection.Open();
            sqlCommand.ExecuteNonQuery();
            sqlDataAdapter = new SqlDataAdapter(sqlCommand);
            DataTable dataTable = new DataTable();
            sqlDataAdapter.Fill(dataTable);
            dgvBills.DataSource = dataTable;
            sqlConnection.Close();
            sqlConnection.Dispose();

            dgvBills.Columns[7].DefaultCellStyle.Format = "dd/MM/yyyy";
        }

        private void dtpCheckOut1_ValueChanged(object sender, EventArgs e)
        {
            //string connectionString = "server=.; database = RestaurantManagement; Integrated Security = true;";
            //sqlConnection = new SqlConnection(connectionString);
            //sqlCommand = sqlConnection.CreateCommand();
            //sqlCommand.CommandText = "SELECT * FROM Bills WHERE CheckoutDate Between '" + dtpCheckOut1.Value + "' and '" + dtpCheckOut2.Value + "'";

            //sqlConnection.Open();
            //sqlCommand.ExecuteNonQuery();
            //sqlDataAdapter = new SqlDataAdapter(sqlCommand);
            //DataTable dataTable = new DataTable();
            //sqlDataAdapter.Fill(dataTable);
            //dgvBills.DataSource = dataTable;
            //sqlConnection.Close();
        }

        private void dtpCheckOut2_ValueChanged(object sender, EventArgs e)
        {
            //string connectionString = "server=.; database = RestaurantManagement; Integrated Security = true;";
            //sqlConnection = new SqlConnection(connectionString);
            //sqlCommand = sqlConnection.CreateCommand();
            //sqlCommand.CommandText = "SELECT * FROM Bills WHERE CheckoutDate Between '" + dtpCheckOut1.Value + "' and '" + dtpCheckOut2.Value + "'";

            //sqlConnection.Open();
            //sqlCommand.ExecuteNonQuery();
            //sqlDataAdapter = new SqlDataAdapter(sqlCommand);
            //DataTable dataTable = new DataTable();
            //sqlDataAdapter.Fill(dataTable);
            //dgvBills.DataSource = dataTable;
            //sqlConnection.Close();
        }

        private void dgvBills_DoubleClick(object sender, EventArgs e)
        {
            OrderDetailsForm dialog = new OrderDetailsForm();
            DataGridViewRow dgvRow = dgvBills.CurrentRow;
            int billID = Convert.ToInt32(dgvRow.Cells["ID"].Value);
            dialog.Show(this);
            dialog.LoadBillDetails(billID);
        }

        private void btnThongKe_Click(object sender, EventArgs e)
        {
            string connectionString = "server=.; database = RestaurantManagement; Integrated Security = true;";
            sqlConnection = new SqlConnection(connectionString);
            sqlCommand = sqlConnection.CreateCommand();
            sqlCommand.CommandText = "SELECT * FROM Bills WHERE CheckoutDate Between '" + dtpCheckOut1.Value + "' and '" + dtpCheckOut2.Value + "'";

            sqlConnection.Open();
            sqlCommand.ExecuteNonQuery();
            sqlDataAdapter = new SqlDataAdapter(sqlCommand);
            DataTable dataTable = new DataTable();
            sqlDataAdapter.Fill(dataTable);
            dgvBills.DataSource = dataTable;
            sqlConnection.Close();
        }
    }
}
