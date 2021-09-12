using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab02_Bai2_GiaoVien
{
    public partial class SearchGV : Form
    {
        QuanLyGiaoVien ql;
        public SearchGV()
        {
            InitializeComponent();
        }

        public SearchGV(QuanLyGiaoVien qL) : this()
        {
            ql = qL;
        }

        private void SearchGV_Load(object sender, EventArgs e)
        {

        }

        private void rdMaGV_CheckedChanged_1(object sender, EventArgs e)
        {
            if (rdMaGV.Checked)
            {
                lblSearch.Text = rdMaGV.Text;
                txtInput.Text = "";
            }
        }

        private void rdHoTen_CheckedChanged_1(object sender, EventArgs e)
        {
            if (rdHoTen.Checked)
            {
                lblSearch.Text = rdHoTen.Text;
                txtInput.Text = "";
            }
        }

        private void rdSDT_CheckedChanged(object sender, EventArgs e)
        {
            if (rdSDT.Checked)
            {
                lblSearch.Text = rdSDT.Text;
                txtInput.Text = "";
            }
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            var kt = KieuTim.TheoHoTen;

            if (rdMaGV.Checked)
                kt = KieuTim.TheoMa;

            else if (rdHoTen.Checked)
                kt = KieuTim.TheoHoTen;

            else if (rdSDT.Checked)
                kt = KieuTim.TheoSDT;

            var kq = ql.TimKiem(kt, txtInput.Text);

            if (kq is null)
                MessageBox.Show("Không có giáo viên trong danh sách", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);

            else
            {
                var dialog = new FormTBGiaoVien();
                dialog.SetText(kq.ToString());
                dialog.ShowDialog();
            }
        }
    }
}
