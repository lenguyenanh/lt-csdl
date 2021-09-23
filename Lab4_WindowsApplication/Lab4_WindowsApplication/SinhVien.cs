using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4_WindowsApplication
{
    public class SinhVien
    {
        public string MaSo { get; set; }

        public string HoTen { get; set; }

        public bool GioiTinh { get; set; }

        public DateTime NgaySinh { get; set; }

        public string Lop { get; set; }

        public string SoDT { get; set; }

        public string Email { get; set; }

        public string DiaChi { get; set; }

        public string Hinh { get; set; }

        public SinhVien()
        {

        }

        public SinhVien(string ms, string ht, bool gt, DateTime ns, string lop, string sdt, string email, string dc, string hinh)
        {
            this.MaSo = ms;
            this.HoTen = ht;
            this.GioiTinh = gt;
            this.NgaySinh = ns;
            this.Lop = lop;
            this.SoDT = sdt;
            this.Email = email;
            this.DiaChi = dc;
            this.Hinh = hinh;
        }
    }
}
