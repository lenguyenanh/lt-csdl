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
    public partial class NhatKyHoaDon : Form
    {
        string accountName;
        SqlConnection sqlConnection;
        SqlCommand sqlCommand;
        SqlDataAdapter sqlDataAdapter;

        public NhatKyHoaDon()
        {
            InitializeComponent();
        }

        public void LoadBills(int tableID)
        {
            string connectionString = "server=.; database = RestaurantManagement; Integrated Security = true; ";
            sqlConnection = new SqlConnection(connectionString);
            sqlCommand = sqlConnection.CreateCommand();

            sqlCommand.CommandText = "SELECT A.Name, B.Name, E.Name, (Price * Quantity) As TongTien, Discount, Tax, CheckoutDate, D.Account " +
                "FROM Category A, Food B, BillDetails C, Bills D, [Table] E " +
                "WHERE A.ID = B.FoodCategoryID and B.ID = C.FoodID and C.InvoiceID = D.ID and D.TableID = E.ID and E.ID = '" + tableID + "'";

            sqlConnection.Open();
            sqlDataAdapter = new SqlDataAdapter(sqlCommand);
            DataTable dataTable = new DataTable();
            sqlDataAdapter.Fill(dataTable);

            dgvBills.DataSource = dataTable;

            //Tiêu đề của bảng
            HeaderText();

            sqlConnection.Close();

            //Tổng số tiền của hóa đơn  
            Total();
        }

        public void HeaderText()
        {
            dgvBills.Columns[0].HeaderText = "Danh mục món ăn";
            dgvBills.Columns[1].HeaderText = "Tên món ăn";
            dgvBills.Columns[2].HeaderText = "Tên bàn";
            dgvBills.Columns[3].HeaderText = "Tổng tiền";
            dgvBills.Columns[4].HeaderText = "Giảm giá";
            dgvBills.Columns[5].HeaderText = "Thuế";
            dgvBills.Columns[6].HeaderText = "Ngày thanh toán";
            dgvBills.Columns[6].DefaultCellStyle.Format = "dd/MM/yyyy";
            dgvBills.Columns[7].HeaderText = "Tài khoản";
        }

        public void Total()
        {
            string connectionString = "server=.; database = RestaurantManagement; Integrated Security = true; ";
            sqlConnection = new SqlConnection(connectionString);
            sqlCommand = sqlConnection.CreateCommand();


            sqlCommand.CommandText = "SELECT sum(Price * Quantity) FROM Food A, BillDetails B WHERE A.ID = B.FoodID";
            sqlConnection.Open();
            string total = sqlCommand.ExecuteScalar().ToString() + " đ";
            if (dgvBills.Rows.Count - 1 > 0)
            {
                lblTotal.Text = total;
            }
            else
                lblTotal.Text = "0 đ";

            sqlConnection.Close();
            sqlConnection.Dispose();

            //Tổng số lượng hóa đơn
            int soLuong = dgvBills.RowCount - 1;
            lblSoLuong.Text = soLuong.ToString();

        }

        private void btnThongKe_Click(object sender, EventArgs e)
        {
            string connectionString = "server=.; database = RestaurantManagement; Integrated Security = true;";
            sqlConnection = new SqlConnection(connectionString);
            sqlCommand = sqlConnection.CreateCommand();
            sqlCommand.CommandText = "SELECT A.Name, B.Name, E.Name, (Price * Quantity) As TongTien, Discount, Tax, CheckoutDate, D.Account " +
                "FROM Category A, Food B, BillDetails C, Bills D, [Table] E " +
                "WHERE A.ID = B.FoodCategoryID and B.ID = C.FoodID and C.InvoiceID = D.ID and D.TableID = E.ID" +
                " and CheckoutDate Between '" + dtpDateCreated.Value + "' and '" + dtpCheckoutDate2.Value + "'";

            sqlConnection.Open();
            sqlCommand.ExecuteNonQuery();
            sqlDataAdapter = new SqlDataAdapter(sqlCommand);
            DataTable dataTable = new DataTable();
            sqlDataAdapter.Fill(dataTable);

            dgvBills.DataSource = dataTable;
            sqlConnection.Close();
            sqlConnection.Dispose();

            Total();
        }
    }
}
