using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Lab7_Advanced_Command
{
    public partial class FoodInfoForm : Form
    {
        SqlConnection sqlConnection;
        SqlCommand sqlCommand;
        SqlDataAdapter dataAdapter;
        public FoodInfoForm()
        {
            InitializeComponent();
        }

        private void FoodInfoForm_Load(object sender, EventArgs e)
        {
            InitValues();
        }

        private void InitValues()
        {
            string connectionString = "server=.; database = RestaurantManagement; Integrated Security = true;";
            sqlConnection = new SqlConnection(connectionString);
            sqlCommand = sqlConnection.CreateCommand();
            sqlCommand.CommandText = "SELECT ID, Name, Type FROM Category";
            dataAdapter = new SqlDataAdapter(sqlCommand);
            DataSet ds = new DataSet();

            sqlConnection.Open();
            dataAdapter.Fill(ds, "Category");

            cbbCatName.DataSource = ds.Tables["Category"];
            cbbCatName.DisplayMember = "Name";
            cbbCatName.ValueMember = "ID";

            sqlConnection.Close();
            sqlConnection.Dispose();
        }

        private void ResetText()
        {
            txtFoodID.ResetText();
            txtName.ResetText();
            txtUnit.ResetText();
            txtNotes.ResetText();
            nudPrice.ResetText();
            cbbCatName.ResetText();
        }

        private void btnAddFood_Click(object sender, EventArgs e)
        {
            try
            {
                string connectionString = "server=.; database = RestaurantManagement; Integrated Security = true;";
                sqlConnection = new SqlConnection(connectionString);
                sqlCommand = sqlConnection.CreateCommand();
                sqlCommand.CommandText = "EXECUTE InsertFood @ID OUTPUT, @Name, @Unit, @FoodCategoryID, @Price, @Notes";

                //Thêm tham số vào đối tượng Command
                sqlCommand.Parameters.Add("@ID", SqlDbType.Int);
                sqlCommand.Parameters.Add("@Name", SqlDbType.NVarChar, 1000);
                sqlCommand.Parameters.Add("@Unit", SqlDbType.NVarChar, 100);
                sqlCommand.Parameters.Add("@FoodCategoryID", SqlDbType.Int);
                sqlCommand.Parameters.Add("@Price", SqlDbType.Int);
                sqlCommand.Parameters.Add("@Notes", SqlDbType.NVarChar, 3000);

                sqlCommand.Parameters["@ID"].Direction = ParameterDirection.Output;

                //Truyền giá trị vào thủ tục qua tham số
                sqlCommand.Parameters["@Name"].Value = txtName.Text;
                sqlCommand.Parameters["@Unit"].Value = txtUnit.Text;
                sqlCommand.Parameters["@FoodCategoryID"].Value = cbbCatName.SelectedValue;
                sqlCommand.Parameters["@Price"].Value = nudPrice.Value;
                sqlCommand.Parameters["@Notes"].Value = txtNotes.Text;

                sqlConnection.Open();
                int numRowAffected = sqlCommand.ExecuteNonQuery();
                if (numRowAffected > 0)
                {
                    string foodID = sqlCommand.Parameters["@ID"].Value.ToString();
                    MessageBox.Show("Thêm món ăn thành công. Food ID = " + foodID, "Thông báo");
                    this.ResetText();
                }
                else
                    MessageBox.Show("Thêm món ăn thất bại", "Thông báo");
                sqlConnection.Close();
                sqlConnection.Dispose();
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message, "SQL Error");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }         
        }

        public void DisplayFoodInfo(DataRowView dataRowView)
        {
            try
            {
                txtFoodID.Text = dataRowView["ID"].ToString();
                txtName.Text = dataRowView["Name"].ToString();
                txtUnit.Text = dataRowView["Unit"].ToString();
                txtNotes.Text = dataRowView["Notes"].ToString();
                nudPrice.Text = dataRowView["Price"].ToString();
                cbbCatName.SelectedIndex = -1;

                for (int i = 0; i < cbbCatName.Items.Count; i++)
                {
                    DataRowView cat = cbbCatName.Items[i] as DataRowView;
                    if(cat["ID"].ToString() == dataRowView["FoodCategoryID"].ToString())
                    {
                        cbbCatName.SelectedIndex = i;
                        break;
                    }
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
                this.Close();
            }
        }


        private void btnUpdateFood_Click(object sender, EventArgs e)
        {
            try
            {
                string connectionString = "server=.; database = RestaurantManagement; Integrated Security = true;";
                sqlConnection = new SqlConnection(connectionString);
                sqlCommand = sqlConnection.CreateCommand();
                sqlCommand.CommandText = "EXECUTE UpdateFood @id, @name, @unit, @foodCategoryID, @price, @notes";

                sqlCommand.Parameters.Add("@id", SqlDbType.Int);
                sqlCommand.Parameters.Add("@name", SqlDbType.NVarChar, 1000);
                sqlCommand.Parameters.Add("@unit", SqlDbType.NVarChar, 100);
                sqlCommand.Parameters.Add("@foodCategoryID", SqlDbType.Int);
                sqlCommand.Parameters.Add("@price", SqlDbType.Int);
                sqlCommand.Parameters.Add("@notes", SqlDbType.NVarChar, 3000);

                sqlCommand.Parameters["@id"].Value = int.Parse(txtFoodID.Text);
                sqlCommand.Parameters["@name"].Value = txtName.Text;
                sqlCommand.Parameters["@unit"].Value = txtUnit.Text;
                sqlCommand.Parameters["@foodCategoryID"].Value = cbbCatName.SelectedValue;
                sqlCommand.Parameters["@price"].Value = nudPrice.Value;
                sqlCommand.Parameters["@notes"].Value = txtNotes.Text;

                sqlConnection.Open();
                int numRowAffected = sqlCommand.ExecuteNonQuery();

                if (numRowAffected > 0)
                {
                    MessageBox.Show("Cập nhật món ăn thành công", "Thông báo");
                    this.ResetText();
                }
                else
                    MessageBox.Show("Cập nhật món ăn thất bại");
                sqlConnection.Close();
                sqlConnection.Dispose();
            }
            catch(SqlException ex)
            {
                MessageBox.Show(ex.Message, "SQL Error");
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAddNew_Click(object sender, EventArgs e)
        {
            AddCategory dialog = new AddCategory();
            dialog.FormClosed += Dialog_FormClosed;
            dialog.Show(this);
        }

        private void Dialog_FormClosed(object sender, FormClosedEventArgs e)
        {
            int index = cbbCatName.SelectedIndex;
            cbbCatName.SelectedIndex = -1;
            cbbCatName.SelectedIndex = index;
            InitValues();
        }
    }
}
