using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public class BillsDA
    {
        public List<Bills> GetAll()
        {
            SqlConnection sqlConnection = new SqlConnection(Ultilities.ConnectionString);
            sqlConnection.Open();
            SqlCommand sqlCommand = sqlConnection.CreateCommand();
            sqlCommand.CommandType = CommandType.StoredProcedure;
            sqlCommand.CommandText = Ultilities.Bills_GetAll;
            SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
            List<Bills> list = new List<Bills>();

            while (sqlDataReader.Read())
            {
                Bills bills = new Bills();
                bills.ID = Convert.ToInt32(sqlDataReader["ID"]);
                bills.Name = sqlDataReader["Name"].ToString();
                bills.TableID = Convert.ToInt32(sqlDataReader["TableID"]);
                bills.Amount = Convert.ToInt32(sqlDataReader["Amount"]);
                bills.Discount = Convert.ToInt32(sqlDataReader["Discount"]);
                bills.Tax = Convert.ToInt32(sqlDataReader["Tax"]);
                bills.Status = bool.Parse(sqlDataReader["Status"].ToString());
                if (sqlDataReader["CheckoutDate"] is DBNull)
                {
                    DateTime? myTime = null;
                }
                else
                    bills.CheckoutDate = Convert.ToDateTime(sqlDataReader["CheckoutDate"]);
                bills.Account = sqlDataReader["Account"].ToString();
                list.Add(bills);
            }
            sqlConnection.Close();
            return list;
        }
    }
}
