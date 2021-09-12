using System.Collections.Generic;
using System.Windows.Forms;

namespace Lab02_Bai2_GiaoVien
{
    public class QuanLyGiaoVien
    {
        List<GiaoVien> dsGiaoVien;

        public QuanLyGiaoVien()
        {
            dsGiaoVien = new List<GiaoVien>();
        }

        public GiaoVien this[int index]
        {
            get { return dsGiaoVien[index]; }
            set { dsGiaoVien[index] = value; }
        }

        public bool ThemGiaoVien(GiaoVien gv)
        {
            var check = dsGiaoVien.Exists(ms => ms.MaSo == gv.MaSo);
            if (check)
                return false;

            dsGiaoVien.Add(gv);

            return true;
        }

        public GiaoVien TimKiem(KieuTim kt, string s)
        {
            GiaoVien gv = null;

            switch (kt)
            {
                case KieuTim.TheoMa:
                    gv = dsGiaoVien.Find(ms => ms.MaSo == s);
                    break;

                case KieuTim.TheoHoTen:
                    gv = dsGiaoVien.Find(ht => ht.HoTen == s);
                    break;

                case KieuTim.TheoSDT:
                    gv = dsGiaoVien.Find(sdt => sdt.SoDT == s);
                    break;
            }

            return gv;
        }
    }
}
