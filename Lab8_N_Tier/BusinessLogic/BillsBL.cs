using DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic
{
    public class BillsBL
    {
        BillsDA billsDA = new BillsDA();

        public List<Bills> GetAll()
        {
            return billsDA.GetAll();
        }
    }
}
