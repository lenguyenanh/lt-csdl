using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab02_Bai2_GiaoVien
{
    public partial class FormGiaoVien : Form
    {
        QuanLyGiaoVien ql;
        public FormGiaoVien()
        {
            InitializeComponent();
            ql = new QuanLyGiaoVien();
        }

        private void FormGiaoVien_Load(object sender, EventArgs e)
        {
            string lienhe = "http//it.dlu.edu.vn/e-learning/Default.aspx";
            this.linklbLienHe.Links.Add(0, lienhe.Length, lienhe);
            this.cbbMaSo.SelectedItem = this.cbbMaSo.Items[0];
        }

        private void btnChon_Click(object sender, EventArgs e)
        {
            int i = this.lbDanhSachMH.SelectedItems.Count - 1;
            while (i >= 0)
            {
                this.lbMonHocDay.Items.Add(lbDanhSachMH.SelectedItems[i]);
                this.lbDanhSachMH.Items.Remove(lbDanhSachMH.SelectedItems[i]);
                i--;
            }

        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            int i = this.lbMonHocDay.SelectedItems.Count - 1;
            while (i >= 0)
            {
                this.lbDanhSachMH.Items.Add(lbMonHocDay.SelectedItems[i]);
                this.lbMonHocDay.Items.Remove(lbMonHocDay.SelectedItems[i]);
                i--;
            }

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Reset();
        }

        private void Reset()
        {
            this.cbbMaSo.Text = "";
            this.txtHoTen.Text = "";
            this.txtMail.Text = "";
            this.mtbSoDT.Text = "";
            this.rdNam.Checked = true;
            for (int i = 0; i < chklbNgoaiNgu.Items.Count - 1; i++)
            {
                this.chklbNgoaiNgu.SetItemChecked(i, false);
            }
            foreach (object ob in this.lbMonHocDay.Items)
            {
                this.lbDanhSachMH.Items.Add(ob);
            }
            this.lbMonHocDay.Items.Clear();
        }

        private void linklbLienHe_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            string s = e.Link.LinkData.ToString();
            Process.Start(s);
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            FormTBGiaoVien frm = new FormTBGiaoVien();
            frm.SetText(GetGiaoVien().ToString());
            frm.ShowDialog();
        }
        public GiaoVien GetGiaoVien()
        {
            string gt = "Nam";
            if (rdNu.Checked)
                gt = "Nữ";
            GiaoVien gv = new GiaoVien();
            gv.MaSo = this.cbbMaSo.Text;
            gv.HoTen = this.txtHoTen.Text;
            gv.GioiTinh = gt;
            gv.NgaySinh = this.dtpNgaySinh.Value;
            gv.Mail = this.txtMail.Text;
            gv.SoDT = this.mtbSoDT.Text;
            string ngoaingu = "";
            for (int i = 0; i < chklbNgoaiNgu.Items.Count - 1; i++)
                if (chklbNgoaiNgu.GetItemChecked(i))
                    ngoaingu += chklbNgoaiNgu.Items[i] + ";";
            gv.NgoaiNgu = ngoaingu.Split(';');
            DanhMucMonHoc mh = new DanhMucMonHoc();
            foreach (object ob in lbMonHocDay.Items)
            {
                mh.Them(new MonHoc(ob.ToString()));
            }

            return gv;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnAddGV_Click(object sender, EventArgs e)
        {
            var gv = GetGiaoVien();

            var mess = ql.ThemGiaoVien(gv);
            if (mess)
                MessageBox.Show("Thêm giáo viên thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

            else
                MessageBox.Show("Mã giáo viên: " + gv.MaSo + " đã tồn tại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            var dialog = new SearchGV(ql);
            dialog.ShowDialog();
        }
    }
}
