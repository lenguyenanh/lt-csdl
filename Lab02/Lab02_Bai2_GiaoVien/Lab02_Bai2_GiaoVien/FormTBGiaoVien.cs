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
    public partial class FormTBGiaoVien : Form
    {
        public FormTBGiaoVien()
        {
            InitializeComponent();
        }

        public void SetText(string s)
        {
            this.lblThongBao.Text = s;
        }

        private void FormTBGiaoVien_Load(object sender, EventArgs e)
        {

        }
    }
}
