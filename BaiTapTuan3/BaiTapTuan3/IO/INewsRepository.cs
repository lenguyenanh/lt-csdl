using BaiTapTuan3.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaiTapTuan3.IO
{
    public interface INewsRepository
    {
        List<Publisher> GetNews();

        void Save(List<Publisher> publishers);
    }
}
