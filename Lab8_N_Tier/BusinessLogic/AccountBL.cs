using DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic
{
    public class AccountBL
    {
        AccountDA accountDA = new AccountDA();

        public List<Account> GetAll()
        {
            return accountDA.GetAll();
        }
    }
}
