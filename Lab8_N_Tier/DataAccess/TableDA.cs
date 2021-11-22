using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public class TableDA
    {
        public List<Table> GetAll()
        {
            SqlConnection sqlConnection = new SqlConnection(Ultilities.ConnectionString);
            sqlConnection.Open();
            SqlCommand sqlCommand = sqlConnection.CreateCommand();
            sqlCommand.CommandType = CommandType.StoredProcedure;
            sqlCommand.CommandText = Ultilities.Table_GetAll;
            SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
            List<Table> list = new List<Table>();

            while (sqlDataReader.Read())
            {
                Table table = new Table();
                table.ID = Convert.ToInt32(sqlDataReader["ID"]);
                table.Name = sqlDataReader["Name"].ToString();
                table.Status = Convert.ToBoolean(sqlDataReader["Status"]);
                table.Capacity = Convert.ToInt32(sqlDataReader["Capacity"]);               
                list.Add(table);
            }
            sqlConnection.Close();
            return list;
        }
    }
}
