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
    public partial class BillsForm : Form
    {
        SqlConnection sqlConnection;
        SqlCommand sqlCommand;
        SqlDataAdapter sqlDataAdapter;

        public BillsForm()
        {
            InitializeComponent();
        }

		public void LoadBills()
		{
			string connectionString = "server=.; database = RestaurantManagement; Integrated Security = true; ";
			sqlConnection = new SqlConnection(connectionString);
			sqlCommand = sqlConnection.CreateCommand();

			sqlCommand.CommandText = "SELECT * FROM Bills";

			sqlConnection.Open();
			this.Text = "Danh sách hóa đơn";

			sqlDataAdapter = new SqlDataAdapter(sqlCommand);

			DataTable dataTable = new DataTable("Food");
			sqlDataAdapter.Fill(dataTable);
			dgvBills.DataSource = dataTable;

			dgvBills.Columns[0].ReadOnly = true;

			sqlConnection.Close();
		}

        private void dgvBills_DoubleClick(object sender, EventArgs e)
        {
			BillDetailsForm billDetails = new BillDetailsForm();
			int selectedrowindex = dgvBills.SelectedCells[0].RowIndex;
			DataGridViewRow selectedrow = dgvBills.Rows[selectedrowindex];
			int billID = Convert.ToInt32(selectedrow.Cells["ID"].Value);
			billDetails.LoadBillDetails(billID);
			billDetails.Show();
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

	}
}
