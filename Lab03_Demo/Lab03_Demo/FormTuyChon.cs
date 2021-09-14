using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab03_Demo
{
    public partial class FormTuyChon : Form
    {
        QuanLySinhVien qlsv;
        ListView lvSinhVien;

        public FormTuyChon(QuanLySinhVien qlSV, ListView lvSV, string s)
        {
            InitializeComponent();
            qlsv = qlSV;
            lvSinhVien = lvSV;

            if(s == "sapxep")
            {
                label1.Enabled = false;
                txtNhap.Enabled = false;
                btnTim.Enabled = false;
            }

            else if(s == "tim")
                btnSapXep.Enabled = false;
        }

        public class SapXepTheoNgaySinh : IComparer<SinhVien>
        {
            public int Compare(SinhVien x, SinhVien y)
            {
                return x.NgaySinh.CompareTo(y.NgaySinh);
            }
        }

        public class SapXepTheoMaSo : IComparer<SinhVien>
        {
            public int Compare(SinhVien x, SinhVien y)
            {
                return int.Parse(x.MaSo) - int.Parse(y.MaSo);
            }
        }

        private void btnSapXep_Click(object sender, EventArgs e)
        {
            if (rdMaSV.Checked)
                qlsv.DanhSach.Sort(new SapXepTheoMaSo());

            else if(rdNgaySinh.Checked)
                qlsv.DanhSach.Sort(new SapXepTheoNgaySinh());

            

            lvSinhVien.Items.Clear();

            foreach (var sv in qlsv.DanhSach)
            {
                ListViewItem item = new ListViewItem(sv.MaSo);
                item.SubItems.Add(sv.HoTen);
                item.SubItems.Add(sv.NgaySinh.ToString("dd/MM/yyyy"));
                item.SubItems.Add(sv.DiaChi);
                item.SubItems.Add(sv.Lop);
                item.SubItems.Add(sv.GioiTinh ? "Nam" : "Nữ");
                item.SubItems.Add(String.Join(", ", sv.ChuyenNganh));
                item.SubItems.Add(sv.Hinh);

                lvSinhVien.Items.Add(item);
            }

            this.Close();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnTim_Click(object sender, EventArgs e)
        {
            var sv = new SinhVien();

            if (rdMaSV.Checked)
                sv = qlsv.DanhSach.Find(s => s.MaSo.Trim() == txtNhap.Text.Trim());

            else if (rdHoTen.Checked)
                sv = qlsv.DanhSach.Find(s => s.HoTen.Contains(txtNhap.Text.Trim()));

            else if (rdNgaySinh.Checked)
                sv = qlsv.DanhSach.Find(s => s.NgaySinh.Day == int.Parse(txtNhap.Text));

            if (sv is null)
            {
                MessageBox.Show("Không có sinh viên cần tìm trong danh sách", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            ListViewItem item = new ListViewItem(sv.MaSo);
            item.SubItems.Add(sv.HoTen);
            item.SubItems.Add(sv.NgaySinh.ToString("dd/MM/yyyy"));
            item.SubItems.Add(sv.DiaChi);
            item.SubItems.Add(sv.Lop);
            item.SubItems.Add(sv.GioiTinh ? "Nam" : "Nữ");
            item.SubItems.Add(String.Join(", ", sv.ChuyenNganh));
            item.SubItems.Add(sv.Hinh);

            lvSinhVien.Items.Clear();
            lvSinhVien.Items.Add(item);
        }
    }
}
