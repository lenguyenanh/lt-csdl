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

namespace Lab4_Demo
{
    public partial class FormPicture : Form
    {
        Point point = new Point();
        public FormPicture()
        {
            InitializeComponent();
        }

        public FormPicture(string name)
        {
            InitializeComponent();
            this.pbHinh.ImageLocation = name;
            this.statusStrip1.Text = name;
        }

        private void FormPicture_Load(object sender, EventArgs e)
        {
            point = this.pbHinh.Location;
            this.MouseWheel += FormPicture_MouseWheel;
        }

        private void FormPicture_MouseWheel(object sender, MouseEventArgs e)
        {  
            if (e.Delta > 0 && this.vScrollBar.Value > 10)
                this.vScrollBar.Value -= 10;

            if (!(e.Delta > 0) && this.vScrollBar.Value < this.vScrollBar.Maximum - 10)
                this.vScrollBar.Value += 10;
            
            pbHinh.Location = new Point(point.X, point.Y - this.vScrollBar.Value);
            
        }

        private void reloadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult dialog = this.openFileDialog1.ShowDialog();
            string title = "";

            if (dialog == DialogResult.OK)
            {
                title = openFileDialog1.FileName;
                this.Text = title;
                pbHinh.Image = Image.FromFile(openFileDialog1.FileName);
            }

        }

        private void zoomcongToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.pbHinh.Width += 50;
            this.pbHinh.Height += 50;
        }

        private void zoomtruToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.pbHinh.Width -= 50;
            this.pbHinh.Height -= 50;
        }


        private void vScrollBar_Scroll(object sender, ScrollEventArgs e)
        {
            this.pbHinh.Location = new Point(point.X, point.Y - e.NewValue);
        }

        private void hScrollBar_Scroll(object sender, ScrollEventArgs e)
        {
            this.pbHinh.Location = new Point(point.X - e.NewValue, point.Y);
        }

        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Process.Start("mspaint", this.pbHinh.ImageLocation);
        }
    }
}
