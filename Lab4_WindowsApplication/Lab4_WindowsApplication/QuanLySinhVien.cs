using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4_WindowsApplication
{
    public class QuanLySinhVien
    {
        public delegate int SoSanh(object sv1, object sv2);

        public List<SinhVien> DanhSachSinhVien;

        public QuanLySinhVien()
        {
            DanhSachSinhVien = new List<SinhVien>();
        }

        public void Them(SinhVien sv)
        {
            this.DanhSachSinhVien.Add(sv);
        }

        public SinhVien this[int index]
        {
            get { return DanhSachSinhVien[index]; }
            set { DanhSachSinhVien[index] = value; }
        }

        public void Xoa(SinhVien sv)
        {
            this.DanhSachSinhVien.Remove(sv);
        }

        public SinhVien Tim(object obj, SoSanh ss)
        {
            SinhVien result = null;
            foreach (SinhVien sv in DanhSachSinhVien)
            {
                if(ss(obj, sv) ==0)
                {
                    result = sv;
                    break;
                }    
            }
            return result;
        }

        public bool Sua(SinhVien sv, object obj, SoSanh ss)
        {
            int i, count;
            bool result = false;
            count = this.DanhSachSinhVien.Count - 1;
            for (i = 0; i < count; i++)
                if (ss(obj, this[i]) == 0)
                {
                    this[i] = sv;
                    result = true;
                    break;
                }
            return result;
        }

        public void DocTuFile()
        {
            string filename = "sinhvien.txt", t;
            string[] s;
            SinhVien sv;

            StreamReader sr = new StreamReader(new FileStream(filename, FileMode.Open));

            while((t = sr.ReadLine()) != null)
            {
                s = t.Split('^');
                sv = new SinhVien();
                sv.MaSo = s[0];
                sv.HoTen = s[1];
                sv.GioiTinh = false;
                if (s[2] == "1")
                    sv.GioiTinh = true;

                sv.NgaySinh = DateTime.Parse(s[3]);
                sv.Lop = s[4];
                sv.SoDT = s[5];
                sv.Email = s[6];
                sv.DiaChi = s[7];
                sv.Hinh = s[8];

                this.Them(sv);
            }
        }
    }
}
