using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public class FoodDA
    {
        public List<Food> GetAll()
        {
            SqlConnection sqlConnection = new SqlConnection(Ultilities.ConnectionString);
            sqlConnection.Open();
            SqlCommand sqlCommand = sqlConnection.CreateCommand();
            sqlCommand.CommandType = CommandType.StoredProcedure;
            sqlCommand.CommandText = Ultilities.Food_GetAll;
            SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
            List<Food> list = new List<Food>();
            while (sqlDataReader.Read())
            {
                Food food = new Food();
                food.ID = Convert.ToInt32(sqlDataReader["ID"]);
                food.Name = sqlDataReader["Name"].ToString();
                food.Unit = sqlDataReader["Unit"].ToString();
                food.FoodCategoryID = Convert.ToInt32(sqlDataReader["FoodCategoryID"]);
                food.Price = Convert.ToInt32(sqlDataReader["Price"]);
                food.Notes = sqlDataReader["Notes"].ToString();
                list.Add(food);
            }
            sqlConnection.Close();
            return list;
        }

        public int Insert_Update_Delete(Food food, int action)
        {
            SqlConnection sqlConnection = new SqlConnection(Ultilities.ConnectionString);
            sqlConnection.Open();
            SqlCommand sqlCommand = sqlConnection.CreateCommand();
            sqlCommand.CommandType = CommandType.StoredProcedure;
            sqlCommand.CommandText = Ultilities.Food_InsertUpdateDelete;
            SqlParameter sqlParameter = new SqlParameter("@ID", SqlDbType.Int);
            sqlParameter.Direction = ParameterDirection.InputOutput;
            sqlCommand.Parameters.Add(sqlParameter).Value = food.ID;
            sqlCommand.Parameters.Add("@Name", SqlDbType.NVarChar, 1000).Value = food.Name;
            sqlCommand.Parameters.Add("@Unit", SqlDbType.NVarChar).Value = food.Unit;
            sqlCommand.Parameters.Add("@FoodCategoryID", SqlDbType.Int).Value = food.FoodCategoryID;
            sqlCommand.Parameters.Add("@Price", SqlDbType.Int).Value = food.Price;
            sqlCommand.Parameters.Add("@Notes", SqlDbType.NVarChar, 3000).Value = food.Notes;
            sqlCommand.Parameters.Add("@Action", SqlDbType.Int).Value = action;

            int result = sqlCommand.ExecuteNonQuery();
            if (result > 0)
            {
                return (int)sqlCommand.Parameters["@ID"].Value;
            }
            return 0;
        }
    }
}
