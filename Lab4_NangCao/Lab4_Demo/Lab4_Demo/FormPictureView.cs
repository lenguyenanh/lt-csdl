using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab4_Demo
{
    public partial class FormPictureView : Form
    {
        int count = 0;
        public FormPictureView()
        {
            InitializeComponent();
        }

        private void statusToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bool check = this.statusToolStripMenuItem.Checked;
            if (check)
                this.toolStripStatusLabel1.Visible = true;
            else
                this.toolStripStatusLabel1.Visible = false;
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult dialog = this.openFileDialog1.ShowDialog();
            if(dialog == DialogResult.OK)
            {
                FormPicture frm = new FormPicture(openFileDialog1.FileName);
                frm.MdiParent = this;
                count++;
                frm.Text = "Picture - " + count + "-" + openFileDialog1.FileName;
                this.menuStrip1.AllowMerge = false;
                frm.Show();
            }
            this.toolStrip1.Text = "Tổng số Form con: " + count.ToString();
        }

        private void saveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult dialog = this.saveFileDialog1.ShowDialog();
            if (dialog == DialogResult.OK)
            {
                FormPicture frm = this.ActiveMdiChild as FormPicture;

                try
                {
                    Image img = frm.pbHinh.Image;
                    img.Save(saveFileDialog1.FileName, ImageFormat.Bmp);
                }
                catch
                {
                    MessageBox.Show("Lỗi lưu file!");
                }
            }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void toolStripToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bool check = this.toolStripToolStripMenuItem.Checked;
            if (check)
                this.toolStrip1.Visible = true;
            else
                this.toolStrip1.Visible = false;
        }

        private void arrangeIconsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.ArrangeIcons);
        }

        private void cascadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.Cascade);
        }

        private void arrangeHozirantolToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void arrangeVerticalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.TileVertical);
        }

        private void maximizeAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form frm in MdiChildren)
            {
                frm.WindowState = FormWindowState.Maximized;
            }
        }

        private void minimizeAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach(Form frm in MdiChildren)
            {
                this.WindowState = FormWindowState.Minimized;
            }
        }

        private void toolStripButtonZoomIn_Click(object sender, EventArgs e)
        {
            FormPicture frm = this.ActiveMdiChild as FormPicture;
            frm.pbHinh.Width += 50;
            frm.pbHinh.Height += 50;
        }

        private void toolStripButtonZoomOut_Click(object sender, EventArgs e)
        {
            FormPicture frm = this.ActiveMdiChild as FormPicture;
            frm.pbHinh.Width -= 50;
            frm.pbHinh.Height -= 50;
        }

        private void toolStripButtonPaint_Click(object sender, EventArgs e)
        {
            FormPicture frm = this.ActiveMdiChild as FormPicture;
            Process.Start("mspaint", frm.pbHinh.ImageLocation);
        }
    }
}
