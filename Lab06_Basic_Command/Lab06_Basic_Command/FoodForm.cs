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
    public partial class FoodForm : Form
    {
        SqlConnection sqlConnection;
        SqlCommand sqlCommand;
        SqlDataAdapter sqlDataAdapter;

		int categoryID;

        public FoodForm()
        {
            InitializeComponent();
        }

		public void LoadFood(int categoryID)
		{
			this.categoryID = categoryID;
			string connectionString = "server=.; database = RestaurantManagement; Integrated Security = true; ";
			sqlConnection = new SqlConnection(connectionString);

			sqlCommand = sqlConnection.CreateCommand();

			sqlCommand.CommandText = "SELECT Name FROM Category WHERE ID = " + categoryID;

			sqlConnection.Open();

			string catName = sqlCommand.ExecuteScalar().ToString();
			this.Text = "Danh sách các món ăn thuộc nhóm: " + catName;

			sqlCommand.CommandText = "SELECT * FROM Food WHERE FoodCategoryID = " + categoryID;

			sqlDataAdapter = new SqlDataAdapter(sqlCommand);

			DataTable dataTable = new DataTable("Food");
			sqlDataAdapter.Fill(dataTable);

			dgvFood.DataSource = dataTable;

			//dgvFood.Columns[0].ReadOnly = true;
			//dgvFood.Columns[3].ReadOnly = true;

			sqlConnection.Close();
			sqlConnection.Dispose();
			sqlDataAdapter.Dispose();
		}

        private void btnDeleteFood_Click(object sender, EventArgs e)
        {
			string connectionString = "server=.; database = RestaurantManagement; Integrated Security = true; ";
			sqlConnection = new SqlConnection(connectionString);
			sqlCommand = sqlConnection.CreateCommand();

			int selectedrowindex = dgvFood.SelectedCells[0].RowIndex;
			DataGridViewRow selectedRow = dgvFood.Rows[selectedrowindex];
			int foodID = Convert.ToInt32(selectedRow.Cells["ID"].Value);

			string query = "DELETE FROM Food WHERE ID = " + foodID;
			sqlCommand.CommandText = query;

			sqlConnection.Open();
			int numOfRowsEffected = sqlCommand.ExecuteNonQuery();
			sqlConnection.Close();

			if ((MessageBox.Show("Bạn có chắc chắn muốn xóa món ăn này?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes))
			{
				if (numOfRowsEffected > 0)
                {
					dgvFood.Rows.Remove(selectedRow);
					MessageBox.Show("Bạn đã xóa thành công");
				}									
				else
					MessageBox.Show("Đã xảy ra lỗi. Vui lòng thử lại");
			}
			else
				return;
		}

        private void btnSaveFood_Click(object sender, EventArgs e)
        {
			try
			{
				if (dgvFood.CurrentRow != null)
				{
					string connectionString = "server=.; database = RestaurantManagement; Integrated Security = true; ";
					sqlConnection = new SqlConnection(connectionString);

					sqlConnection.Open();
					DataGridViewRow dgvRow = dgvFood.CurrentRow;
					sqlCommand = new SqlCommand("FoodAddOrEdit", sqlConnection);
					sqlCommand.CommandType = CommandType.StoredProcedure;

					//Thêm món ăn
					if (dgvRow.Cells["ID"].Value == DBNull.Value)
					{
						sqlCommand.Parameters.AddWithValue("@ID", 0);
						MessageBox.Show("Bạn đã THÊM thành công");
					}
					//Cập nhật món ăn
                    else
                    {
						sqlCommand.Parameters.AddWithValue("@ID", Convert.ToInt32(dgvRow.Cells["ID"].Value));						
						MessageBox.Show("Bạn đã CẬP NHẬT thành công");
					}

					sqlCommand.Parameters.AddWithValue("@Name", dgvRow.Cells["FoodName"].Value == DBNull.Value ? "" : dgvRow.Cells["FoodName"].Value.ToString());
					sqlCommand.Parameters.AddWithValue("@Unit", dgvRow.Cells["Unit"].Value == DBNull.Value ? "" : dgvRow.Cells["Unit"].Value.ToString());
					sqlCommand.Parameters.AddWithValue("@FoodCategoryID", categoryID);
					sqlCommand.Parameters.AddWithValue("@Price", dgvRow.Cells["Price"].Value == DBNull.Value ? "" : dgvRow.Cells["Price"].Value.ToString());
					sqlCommand.Parameters.AddWithValue("@Notes", dgvRow.Cells["Notes"].Value == DBNull.Value ? "" : dgvRow.Cells["Notes"].Value.ToString());

					sqlCommand.ExecuteNonQuery();

					LoadFood(categoryID);
				}
			}
			catch (SqlException ex)
			{
				MessageBox.Show("Bạn chưa nhập Mã loại món ăn. Vui lòng nhập vào", ex.Message);
			}	
		}
    }
}
