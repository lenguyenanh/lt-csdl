using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public class CategoryDA
    {
        public List<Category> GetAll()
        {
            SqlConnection sqlConnection = new SqlConnection(Ultilities.ConnectionString);
            sqlConnection.Open();
            SqlCommand sqlCommand = sqlConnection.CreateCommand();
            sqlCommand.CommandType = CommandType.StoredProcedure;
            sqlCommand.CommandText = Ultilities.Category_GetAll;
            SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();

            List<Category> list = new List<Category>();
            while (sqlDataReader.Read())
            {
                Category category = new Category();
                category.ID = Convert.ToInt32(sqlDataReader["ID"]);
                category.Name = sqlDataReader["Name"].ToString();
                category.Type = Convert.ToInt32(sqlDataReader["Type"]);
                list.Add(category);
            }
            return list;
        }

        public int Insert_Update_Delete(Category category, int action)
        {
            SqlConnection sqlConnection = new SqlConnection(Ultilities.ConnectionString);
            sqlConnection.Open();
            SqlCommand sqlCommand = sqlConnection.CreateCommand();
            sqlCommand.CommandType = CommandType.StoredProcedure;
            sqlCommand.CommandText = Ultilities.Food_InsertUpdateDelete;
            SqlParameter sqlParameter = new SqlParameter("@ID", SqlDbType.Int);
            sqlParameter.Direction = ParameterDirection.Output;
            sqlCommand.Parameters.Add(sqlParameter).Value = category.ID;
            sqlCommand.Parameters.Add("@Name", SqlDbType.NVarChar, 200).Value = category.Name;
            sqlCommand.Parameters.Add("@Type", SqlDbType.Int).Value = category.Type;
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
