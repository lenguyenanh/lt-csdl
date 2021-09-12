﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab02_Bai1
{
    public partial class FormTrungTam : Form
    {
        public FormTrungTam()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnTinhTien_Click(object sender, EventArgs e)
        {
            int s = 0;
            if (chkTinHocA.Checked)
                s += int.Parse(this.lblTienTHA.Text.Split('.')[0]);

            if (chkTinHocB.Checked)
                s += int.Parse(this.lblTienTHB.Text.Split('.')[0]);

            if (chkTiengAnhA.Checked)
                s += int.Parse(this.lblTienTAA.Text.Split('.')[0]);

            if (chkTiengAnhB.Checked)
                s += int.Parse(this.lblTienTAB.Text.Split('.')[0]);

            this.txtTongTien.Text = s + ".000 đồng";
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Reset();
        }

        private void Reset()
        {
            this.cbbMaHV.Text = "";
            this.txtHoTen.Text = "";
            this.dtpNgayDangKy.Value = DateTime.Now;
            this.rdNam.Checked = true;
            this.chkTiengAnhA.Checked = false;
            this.chkTiengAnhB.Checked = false;
            this.chkTinHocA.Checked = false;
            this.chkTinHocB.Checked = false;
            this.txtTongTien.Text = "";
        }

        


    }
}
