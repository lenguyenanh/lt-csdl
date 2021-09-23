using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab4_WindowsApplication
{
    public partial class Form1 : Form
    {
        QuanLySinhVien qlsv;
        public Form1()
        {
            InitializeComponent();
            qlsv = new QuanLySinhVien();
            qlsv.DocTuFile();
            LoadListView();
        }

        private SinhVien GetSinhVien()
        {
            SinhVien sv = new SinhVien();

            bool gt = true;              
            sv.MaSo = this.mtbMSSV.Text;
            sv.HoTen = this.txtHoTen.Text;
            if (rdNu.Checked)
                gt = false;
            sv.GioiTinh = gt;
            sv.NgaySinh = this.dtpNgaySinh.Value;
            sv.Lop = this.cbbLop.Text;
            sv.SoDT = this.mtbSDT.Text;
            sv.Email = this.txtEmail.Text;
            sv.DiaChi = this.txtDiaChi.Text;
            sv.Hinh = this.txtHinh.Text;

            return sv;
        }

        private void btnChonHinh_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Title = "Open File Image";

            dialog.InitialDirectory = Environment.CurrentDirectory;
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                var fileName = dialog.FileName;
                txtHinh.Text = fileName;
                pbHinh.Load(fileName);
            }
        }

        private SinhVien GetSinhVienLV(ListViewItem lvitem)
        {
            SinhVien sv = new SinhVien();

            sv.MaSo = lvitem.SubItems[0].Text;
            sv.HoTen = lvitem.SubItems[1].Text;
            sv.GioiTinh = false;
            if (lvitem.SubItems[2].Text == "Nam")
                sv.GioiTinh = true;
            sv.NgaySinh = DateTime.Parse(lvitem.SubItems[3].Text);
            sv.Lop = lvitem.SubItems[4].Text;
            sv.SoDT = lvitem.SubItems[5].Text;
            sv.Email = lvitem.SubItems[6].Text;
            sv.DiaChi = lvitem.SubItems[7].Text;          
            sv.Hinh = lvitem.SubItems[8].Text;

            return sv;
        }

        private void ThemSV(SinhVien sv)
        {
            ListViewItem lvitem = new ListViewItem(sv.MaSo);
            lvitem.SubItems.Add(sv.HoTen);
            string gt = "Nữ";

            if (sv.GioiTinh)
                gt = "Nam";
            lvitem.SubItems.Add(gt);
            lvitem.SubItems.Add(sv.NgaySinh.ToShortDateString());
            lvitem.SubItems.Add(sv.Lop);
            lvitem.SubItems.Add(sv.SoDT);
            lvitem.SubItems.Add(sv.Email);
            lvitem.SubItems.Add(sv.DiaChi);       
            lvitem.SubItems.Add(sv.Hinh);

            this.lvSinhVien.Items.Add(lvitem);
        }

        private void LoadListView()
        {
            this.lvSinhVien.Items.Clear();

            foreach (SinhVien sv in qlsv.DanhSachSinhVien)
            {
                ThemSV(sv);
            }
        }

        private void ThietLapThongTin(SinhVien sv)
        {
            this.mtbMSSV.Text = sv.MaSo;
            this.txtHoTen.Text = sv.HoTen;
            if (sv.GioiTinh)
                this.rdNam.Checked = true;
            else
                this.rdNu.Checked = true;
            this.dtpNgaySinh.Value = sv.NgaySinh;
            this.txtDiaChi.Text = sv.DiaChi;
            this.cbbLop.Text = sv.Lop;
            this.mtbSDT.Text = sv.SoDT;
            this.txtEmail.Text = sv.Email;
            this.txtHinh.Text = sv.Hinh;
            this.pbHinh.ImageLocation = sv.Hinh;

            
        }

        private void btnMacDinh_Click(object sender, EventArgs e)
        {
            this.mtbMSSV.Text = "";
            this.txtHoTen.Text = "";
            this.rdNam.Checked = true;
            this.dtpNgaySinh.Value = DateTime.Now;
            this.cbbLop.Text = this.cbbLop.Items[0].ToString();
            this.mtbSDT.Text = "";
            this.txtEmail.Text = "";
            this.txtDiaChi.Text = "";      
            this.txtHinh.Text = "";
            this.pbHinh.ImageLocation = "";
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            if((MessageBox.Show("Lưu thay đổi", "Thông báo", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question))==DialogResult.Yes)
                Application.Exit();
        }

        private void lvSinhVien_SelectedIndexChanged(object sender, EventArgs e)
        {
            int count = lvSinhVien.SelectedItems.Count;
            if (count > 0)
            {
                ListViewItem lvitem = this.lvSinhVien.SelectedItems[0];
                SinhVien sv = GetSinhVienLV(lvitem);
                ThietLapThongTin(sv);
            }
            else
            { }
                
            
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            SinhVien sv = GetSinhVien();

            SinhVien kq = qlsv.Tim(sv.MaSo, delegate (object obj1, object obj2)
            {
                return (obj2 as SinhVien).MaSo.CompareTo(obj1.ToString());
            });

            if (kq != null)
                MessageBox.Show("Mã sinh viên đã tồn tại!", "Lỗi thêm dữ liệu", MessageBoxButtons.OK, MessageBoxIcon.Error);

            else
            {
                this.qlsv.Them(sv);
                this.LoadListView();
            }

        }

        private void xóaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem item in lvSinhVien.SelectedItems)
                lvSinhVien.Items.Remove(item);
        }

        private void tảiLạiDanhSáchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LoadListView();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
