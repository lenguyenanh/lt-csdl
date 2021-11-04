using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Lab06_Basic_Command
{
    public partial class TableForm : Form
    {
        SqlConnection sqlConnection;
        SqlCommand sqlCommand;
        SqlDataAdapter sqlDataAdapter;

        public TableForm()
        {
            InitializeComponent();
        }

        public void LoadTable()
        {
            string connectionString = "server=.; database = RestaurantManagement; Integrated Security = true; ";
            sqlConnection = new SqlConnection(connectionString);

            sqlCommand = sqlConnection.CreateCommand();

            sqlCommand.CommandText = "SELECT * FROM [Table]";

            sqlConnection.Open();
            this.Text = "Danh sách bàn";
            sqlDataAdapter = new SqlDataAdapter(sqlCommand);
            DataTable dataTable = new DataTable();
            sqlDataAdapter.Fill(dataTable);

            dgvTable.DataSource = dataTable;

            dgvTable.Columns[0].ReadOnly = true;
            sqlConnection.Close();
            sqlConnection.Dispose();
        }

        private void xemDanhMụcHóaĐơnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BillsForm dialog = new BillsForm();
            int selectedrowindex = dgvTable.SelectedCells[0].RowIndex;
            DataGridViewRow selectedRow = dgvTable.Rows[selectedrowindex];
            int tableID = Convert.ToInt32(selectedRow.Cells["ID"].Value);
            dialog.Show(this);
            dialog.LoadTableBill(tableID);
        }

        private void xóaBànToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                string connectionString = "server=.; database = RestaurantManagement; Integrated Security = true; ";
                sqlConnection = new SqlConnection(connectionString);

                sqlCommand = sqlConnection.CreateCommand();
                DataGridViewRow currentRow = dgvTable.CurrentRow;
                int tableID = Convert.ToInt32(currentRow.Cells["ID"].Value);
                sqlCommand.CommandText = "DELETE FROM [Table] WHERE ID = " + tableID;

                sqlConnection.Open();
                int numRowOfAffected = sqlCommand.ExecuteNonQuery();
                sqlConnection.Close();

                if ((MessageBox.Show("Bạn có chắc chắn muốn xóa?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question)) == DialogResult.Yes)
                {
                    if (numRowOfAffected > 0)
                    {
                        dgvTable.Rows.Remove(currentRow);
                        MessageBox.Show("Bạn đã xóa bàn thành công");
                    }
                        
                    else
                        MessageBox.Show("Đã xảy ra lỗi. Vui lòng thử lại");
                }
            }
            catch(SqlException ex)
            {
                MessageBox.Show("Không thể xóa bàn đã có trong danh sách hóa đơn", ex.Message);
            }            
        }

        private void dgvTable_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvTable.CurrentRow != null)
            {
                string connectionString = "server=.; database = RestaurantManagement; Integrated Security = true; ";
                sqlConnection = new SqlConnection(connectionString);

                sqlConnection.Open();
                DataGridViewRow dgvRow = dgvTable.CurrentRow;
                sqlCommand = new SqlCommand("TableAddOrEdit", sqlConnection);
                sqlCommand.CommandType = CommandType.StoredProcedure;
                if (dgvRow.Cells["ID"].Value == DBNull.Value)
                {
                    sqlCommand.Parameters.AddWithValue("@ID", 0);
                }
                else
                {
                    sqlCommand.Parameters.AddWithValue("@ID", Convert.ToInt32(dgvRow.Cells["ID"].Value));
                }
                sqlCommand.Parameters.AddWithValue("@Name", dgvRow.Cells["TableName"].Value == DBNull.Value ? "" : dgvRow.Cells["TableName"].Value.ToString());
                sqlCommand.Parameters.AddWithValue("@Status", Convert.ToInt32(dgvRow.Cells["Status"].Value == DBNull.Value ? "0" : dgvRow.Cells["Status"].Value));
                sqlCommand.Parameters.AddWithValue("@Capacity", Convert.ToInt32(dgvRow.Cells["Capacity"].Value == DBNull.Value ? "0" : dgvRow.Cells["Capacity"].Value));

                sqlCommand.ExecuteNonQuery();
                sqlConnection.Close();

                LoadTable();
            }
        }
    }
}
