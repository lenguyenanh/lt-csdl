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
    public partial class Form1 : Form
    {
        SqlConnection sqlConnection;
        SqlCommand sqlCommand;
        SqlDataReader sqlDataReader;

        public Form1()
        {
            InitializeComponent();
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            string connectionString = "server=.; database= RestaurantManagement; Integrated Security = true; ";

            sqlConnection = new SqlConnection(connectionString);

            //Tạo đối tượng thực thi lệnh
            sqlCommand = sqlConnection.CreateCommand();

            //Thiết lập truy vấn cho đối tượng Command
            sqlCommand.CommandText = "SELECT ID, Name, Type FROM Category";


            //Mở kết nối tới cơ sở dữ liệu
            sqlConnection.Open();
            sqlDataReader = sqlCommand.ExecuteReader();

            //Gọi hàm hiển thị dữ liệu lên màn hình
            DisplayCategory(sqlDataReader);

            //Đóng kết nối
            sqlConnection.Close();
        }

        private void DisplayCategory(SqlDataReader reader)
        {
            //Xóa tất cả các dòng hiện tại
            lvCategory.Items.Clear();

            while (reader.Read())
            {
                ListViewItem item = new ListViewItem(reader["ID"].ToString());
                lvCategory.Items.Add(item);
                item.SubItems.Add(reader["Name"].ToString());
                item.SubItems.Add(reader["Type"].ToString());

                txtCategoryID.Text = "";
                txtCategoryName.Text = "";
                txtType.Text = "";
                btnUpdate.Enabled = false;
                btnDelete.Enabled = false;
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string connectionString = "server=.; database= RestaurantManagement; Integrated Security= true;";
            sqlConnection = new SqlConnection(connectionString);

            sqlCommand = sqlConnection.CreateCommand();

            sqlCommand.CommandText = "INSERT INTO Category(Name, Type)" +
                "VALUES (N'" + txtCategoryName.Text + "'," + txtType.Text + ")";

            sqlConnection.Open();
            int numOfRowsEffected = sqlCommand.ExecuteNonQuery();
            sqlConnection.Close();

            if (numOfRowsEffected == 1)
            {
                MessageBox.Show("Thêm nhóm món ăn thành công");
                btnLoad.PerformClick();
                txtCategoryName.Text = "";
                txtType.Text = "";
            }
            else
                MessageBox.Show("Đã có lỗi xảy ra. Vui lòng thử lại");
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                string connectionString = "server=.; database = RestaurantManagement; Integrated Security = true;";
                sqlConnection = new SqlConnection(connectionString);
                sqlCommand = sqlConnection.CreateCommand();
                sqlCommand.CommandText = "UPDATE Category SET Name = N'" + txtCategoryName.Text + "',Type = " + txtType.Text +
                    " WHERE ID = " + txtCategoryID.Text;
                sqlConnection.Open();
                int numOfRowsEffected = sqlCommand.ExecuteNonQuery();
                sqlConnection.Close();

                if (numOfRowsEffected == 1)
                {
                    ListViewItem lvItem = lvCategory.SelectedItems[0];
                    lvItem.SubItems[1].Text = txtCategoryName.Text;
                    lvItem.SubItems[2].Text = txtType.Text;

                    txtCategoryID.Text = "";
                    txtCategoryName.Text = "";
                    txtType.Text = "";

                    btnUpdate.Enabled = false;
                    btnDelete.Enabled = false;

                    MessageBox.Show("Cập nhật nhóm món ăn thành công");
                }
                else
                    MessageBox.Show("Đã xảy ra lỗi. Vui lòng thử lại");
            }
            catch(SqlException ex)
            {
                MessageBox.Show("Chỉ được nhập Loại là 0 hoặc 1", ex.Message);
            }          
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            string connectionString = "server=.; database = RestaurantManagement; Integrated Security = true;";
            sqlConnection = new SqlConnection(connectionString);
            sqlCommand = sqlConnection.CreateCommand();
            sqlCommand.CommandText = "DELETE FROM Category" + " WHERE ID = " + txtCategoryID.Text;
            sqlConnection.Open();
            int numOfRowsEffected = sqlCommand.ExecuteNonQuery();


            if ((MessageBox.Show("Bạn có chắc chắn muốn xóa món ăn này?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes))
            {
                if (numOfRowsEffected == 1)
                {
                    ListViewItem lvItem = lvCategory.SelectedItems[0];
                    lvCategory.Items.Remove(lvItem);

                    txtCategoryID.Text = "";
                    txtCategoryName.Text = "";
                    txtType.Text = "";

                    btnDelete.Enabled = false;
                    btnDelete.Enabled = false;
                    MessageBox.Show("Bạn đã xóa loại món ăn thành công");
                }
                else
                    MessageBox.Show("Đã xảy ra lỗi. Vui lòng thử lại");
            }
            else
                return;
            sqlConnection.Close();
        }

        private void tsmDelete_Click(object sender, EventArgs e)
        {
            if (lvCategory.SelectedItems.Count > 0)
                btnDelete.PerformClick();
        }

        private void tsmViewFood_Click(object sender, EventArgs e)
        {
            if (txtCategoryID.Text != null)
            {
                FoodForm ff = new FoodForm();
                ff.Show();
                ff.LoadFood(Convert.ToInt32(txtCategoryID.Text));
            }
        }

        private void menuStripAccoutList_Click(object sender, EventArgs e)
        {
            AccountManager dialog = new AccountManager();
            dialog.Show(this);
            dialog.LoadAccount();
        }

        private void menuStripBills_Click(object sender, EventArgs e)
        {
            BillsForm dialog = new BillsForm();
            dialog.Show(this);
            dialog.LoadBills();
        }

        private void menuStripTableList_Click(object sender, EventArgs e)
        {
            TableForm dialog = new TableForm();
            dialog.Show(this);
            dialog.LoadTable();
        }

        private void lvCategory_Click(object sender, EventArgs e)
        {
            ListViewItem lvItem = lvCategory.SelectedItems[0];
            txtCategoryID.Text = lvItem.Text;
            txtCategoryName.Text = lvItem.SubItems[1].Text;
            txtType.Text = lvItem.SubItems[2].Text == "0" ? "Thức uống" : "Đồ ăn";

            btnUpdate.Enabled = true;
            btnDelete.Enabled = true;
        }
    }
}
