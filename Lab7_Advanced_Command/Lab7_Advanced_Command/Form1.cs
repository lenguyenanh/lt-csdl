using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Lab7_Advanced_Command
{
    public partial class Form1 : Form
    {
        private DataTable foodTable;

        SqlConnection sqlConnection;
        SqlCommand sqlCommand;
        SqlDataAdapter sqlDataAdapter;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LoadCategory();
        }

        private void LoadCategory()
        {
            string connectionString = "server=.; database = RestaurantManagement; Integrated Security = true;";
            sqlConnection = new SqlConnection(connectionString);
            sqlCommand = sqlConnection.CreateCommand();
            sqlCommand.CommandText = "SELECT ID, Name FROM Category";
            sqlDataAdapter = new SqlDataAdapter(sqlCommand);
            DataTable dataTable = new DataTable();

            sqlConnection.Open();
            sqlDataAdapter.Fill(dataTable);

            cbbCategory.DataSource = dataTable;
            sqlConnection.Close();
            sqlConnection.Dispose();
            
            cbbCategory.DisplayMember = "Name";
            cbbCategory.ValueMember = "ID";

            dgvFoodList.Columns[0].ReadOnly = true;
        }

        private void cbbCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbbCategory.SelectedIndex == -1) return;

            string connectionString = "server=.; database = RestaurantManagement; Integrated Security = true;";
            sqlConnection = new SqlConnection(connectionString);
            sqlCommand = sqlConnection.CreateCommand();
            sqlCommand.CommandText = "SELECT * FROM Food WHERE FoodCategoryID = @categoryID";

            //Truyền tham số
            sqlCommand.Parameters.Add("@categoryID", SqlDbType.Int);

            if (cbbCategory.SelectedValue is DataRowView)
            {
                DataRowView dataRowView = cbbCategory.SelectedValue as DataRowView;
                sqlCommand.Parameters["@categoryID"].Value = dataRowView["ID"];
            }
            else
                sqlCommand.Parameters["@categoryID"].Value = cbbCategory.SelectedValue;

            sqlDataAdapter = new SqlDataAdapter(sqlCommand);
            foodTable = new DataTable();

            sqlConnection.Open();
            sqlDataAdapter.Fill(foodTable);
            sqlConnection.Close();
            sqlConnection.Dispose();

            dgvFoodList.DataSource = foodTable;

            TinhSoHang();       
        }

        private void TinhSoHang()
        {
            int soLuong = dgvFoodList.Rows.Count - 1;
            lblQuantity.Text = soLuong.ToString();
            lblCatName.Text = cbbCategory.Text;
        }

        private void tsmCalculateQuantity_Click(object sender, EventArgs e)
        {
            string connectionString = "server=.; database = RestaurantManagement; Integrated Security = true;";
            sqlConnection = new SqlConnection(connectionString);
            sqlCommand = sqlConnection.CreateCommand();
            sqlCommand.CommandText = "SELECT @numSaleFood = sum(Quantity) FROM BillDetails WHERE FoodID = @foodID";

            if(dgvFoodList.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dgvFoodList.SelectedRows[0];
                DataRowView dataRowView = selectedRow.DataBoundItem as DataRowView;

                //Truyền tham số
                sqlCommand.Parameters.Add("@foodID", SqlDbType.Int);
                sqlCommand.Parameters["@foodID"].Value = dataRowView["ID"];

                sqlCommand.Parameters.Add("@numSaleFood", SqlDbType.Int);
                sqlCommand.Parameters["@numSaleFood"].Direction = ParameterDirection.Output;

                sqlConnection.Open();
                sqlCommand.ExecuteNonQuery();

                string kq = sqlCommand.Parameters["@numSaleFood"].Value.ToString();

                if (string.IsNullOrWhiteSpace(kq))
                    MessageBox.Show("Tổng số lượng món " + dataRowView["Name"] + " đã bán là: " + "0" + " " + dataRowView["Unit"]);
                else
                    MessageBox.Show("Tổng số lượng món " + dataRowView["Name"] + " đã bán là: " + kq + " " + dataRowView["Unit"]);

                sqlConnection.Close();
            }
            sqlCommand.Dispose();
            sqlConnection.Dispose();
        }

        private void tsmAddFood_Click(object sender, EventArgs e)
        {
            FoodInfoForm dialog = new FoodInfoForm();
            dialog.FormClosed += Dialog_FormClosed;

            dialog.Show(this);
        }

        private void Dialog_FormClosed(object sender, FormClosedEventArgs e)
        {
            int index = cbbCategory.SelectedIndex;
            cbbCategory.SelectedIndex = -1;
            cbbCategory.SelectedIndex = index;
            LoadCategory();
        }

        private void tsmUpdateFood_Click(object sender, EventArgs e)
        {
            if(dgvFoodList.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dgvFoodList.SelectedRows[0];
                DataRowView rowView = selectedRow.DataBoundItem as DataRowView;

                FoodInfoForm dialog = new FoodInfoForm();
                dialog.FormClosed += Dialog_FormClosed;
                dialog.Show(this);
                dialog.DisplayFoodInfo(rowView);
            }
        }

        private void txtSearchByname_TextChanged(object sender, EventArgs e)
        {
            if (foodTable == null) return;

            string filterExpression = "Name like '%" + txtSearchByName.Text + "%'";
            string sortExpression = "Price DESC";
            DataViewRowState rowStateFilter = DataViewRowState.OriginalRows;

            DataView foodView = new DataView(foodTable, filterExpression, sortExpression, rowStateFilter);

            dgvFoodList.DataSource = foodView;
            TinhSoHang();
        }

        private void menuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OrdersForm dialog = new OrdersForm();
            dialog.Show(this);
        }

        private void danhSáchTàiKhoảnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AccountForm dialog = new AccountForm();
            dialog.Show(this);
        }
    }
}
