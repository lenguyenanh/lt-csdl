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
    public partial class BillsForm : Form
    {
        SqlConnection sqlConnection;
        SqlCommand sqlCommand;
        SqlDataAdapter sqlDataAdapter;

        public BillsForm()
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

        public void LoadTableBill(int tableID)
        {
            string connectionString = "server=.; database = RestaurantManagement; Integrated Security = true;";
            sqlConnection = new SqlConnection(connectionString);
            sqlCommand = sqlConnection.CreateCommand();
            sqlCommand.CommandText = "SELECT Name FROM [Table] WHERE ID = " + tableID;

            sqlConnection.Open();
            string tableName = sqlCommand.ExecuteScalar().ToString();
            this.Text = "Danh sách hóa đơn bàn: " + tableName;

            sqlCommand.CommandText = "SELECT * FROM Bills WHERE TableID = " + tableID;
            sqlDataAdapter = new SqlDataAdapter(sqlCommand);
            DataTable dataTable = new DataTable();
            sqlDataAdapter.Fill(dataTable);

            dgvBills.DataSource = dataTable;
            dgvBills.Columns[0].ReadOnly = true;
            sqlConnection.Close();
            sqlConnection.Dispose();
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

        private void dgvBills_DoubleClick(object sender, EventArgs e)
        {
            BillDetailsForm dialog = new BillDetailsForm();
            DataGridViewRow dgvRow = dgvBills.CurrentRow;
            int billID = Convert.ToInt32(dgvRow.Cells["ID"].Value);
            dialog.Show(this);
            dialog.LoadBillDetails(billID);
        }
    }
}
