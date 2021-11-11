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
    public partial class AddCategory : Form
    {
        SqlConnection sqlConnection;
        SqlCommand sqlCommand;
        SqlDataAdapter dataAdapter;
        public AddCategory()
        {
            InitializeComponent();
            LoadCategoryType();
        }

        public void LoadCategoryType()
        {
            string connectionString = "server=.; database = RestaurantManagement; Integrated Security = true;";
            sqlConnection = new SqlConnection(connectionString);
            sqlCommand = sqlConnection.CreateCommand();
            sqlCommand.CommandText = "SELECT Distinct Type FROM Category";

            
            sqlConnection.Open();
            sqlCommand.ExecuteNonQuery();
            dataAdapter = new SqlDataAdapter(sqlCommand);
            DataTable dataTable = new DataTable();
            dataAdapter.Fill(dataTable);

            cbbType.DataSource = dataTable;
            cbbType.DisplayMember = cbbType.Text == "0" ? "Đồ uống" : "Thức ";
            cbbType.ValueMember = "Type";
            sqlConnection.Close();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                string connectionString = "server=.; database = RestaurantManagement; Integrated Security = true;";
                sqlConnection = new SqlConnection(connectionString);
                sqlCommand = sqlConnection.CreateCommand();
                sqlCommand.CommandText = "EXECUTE InsertCategory @ID OUTPUT, @Name, @Type";

                sqlCommand.Parameters.Add("@ID", SqlDbType.Int);
                sqlCommand.Parameters.Add("@Name", SqlDbType.NVarChar, 1000);
                sqlCommand.Parameters.Add("@Type", SqlDbType.Int);

                sqlCommand.Parameters["@ID"].Direction = ParameterDirection.Output;

                sqlCommand.Parameters["@Name"].Value = txtCategoryName.Text;
                sqlCommand.Parameters["@Type"].Value = cbbType.SelectedValue;

                sqlConnection.Open();
                int numOfRowAffected = sqlCommand.ExecuteNonQuery();
                if(numOfRowAffected > 0)
                {
                    string catName = sqlCommand.Parameters["@Name"].Value.ToString();
                    MessageBox.Show("Thêm nhóm món ăn " + catName + " thành công", "Thông báo");
                }
                else
                {
                    MessageBox.Show("Thêm thất bại", "Thông báo");
                }
                sqlConnection.Close();
                sqlConnection.Dispose();
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
