using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public class AccountDA
    {
        public List<Account> GetAll()
        {
            SqlConnection sqlConnection = new SqlConnection(Ultilities.ConnectionString);
            sqlConnection.Open();
            SqlCommand sqlCommand = sqlConnection.CreateCommand();
            sqlCommand.CommandType = CommandType.StoredProcedure;
            sqlCommand.CommandText = Ultilities.Account_GetAll;
            SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
            List<Account> list = new List<Account>();
            while (sqlDataReader.Read())
            {
                Account account = new Account();
                account.AccountName = sqlDataReader["AccountName"].ToString();
                account.Password = sqlDataReader["Password"].ToString();
                account.FullName = sqlDataReader["FullName"].ToString();
                account.Email = sqlDataReader["Email"].ToString();
                account.Tell = sqlDataReader["Tell"].ToString();
                if(sqlDataReader["DateCreated"] is DBNull)
                {
                    DateTime? myTime = null;
                }
                else
                    account.DateCreated = Convert.ToDateTime(sqlDataReader["DateCreated"]);
                list.Add(account);
            }
            sqlConnection.Close();
            return list;
        }
    }
}
