using Azure;
using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace Lab4_Demo_Editor
{
    public partial class FormEditor : Form
    {
        public System.Windows.Forms.HorizontalAlignment TextAlign { get; set; }
        public FormEditor()
        {
            InitializeComponent();
        }

        private void newtoolStripButton1_Click(object sender, EventArgs e)
        {
			
		}

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
			OpenFileDialog dialog = new OpenFileDialog();
			dialog.Title = "Open File";
			dialog.Filter = "Text Files (*.txt)|*.txt| All Files (*.*)|*.*";

            if (dialog.ShowDialog() == DialogResult.OK)
            {
				StreamReader read = new StreamReader(File.OpenRead(dialog.FileName));
                textBox1.Text = read.ReadToEnd();
				read.Dispose();
            }
        }

        private void opentoolStripButton2_Click(object sender, EventArgs e)
        {
			openToolStripMenuItem.PerformClick();
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
			SaveFileDialog dialog = new SaveFileDialog();
			dialog.Title = "Save File";
			dialog.Filter = "Text Files (*.txt)|*.txt| All Files (*.*)|*.*";

			if (dialog.ShowDialog() == DialogResult.OK)
            {
				StreamWriter writer = new StreamWriter(File.Create(dialog.FileName));
				writer.Write(textBox1.Text);
				writer.Dispose();
            }
        }

        private void savetoolStripButton3_Click(object sender, EventArgs e)
        {
			saveToolStripMenuItem.PerformClick();
        }

        private void copytoolStripButton5_Click(object sender, EventArgs e)
        {
            copyToolStripMenuItem.PerformClick();
        }

        private void cuttoolStripButton7_Click(object sender, EventArgs e)
        {
            cutToolStripMenuItem.PerformClick();
        }

        private void pastToolStripMenuItem_Click(object sender, EventArgs e)
        {
                textBox1.Text = Clipboard.GetText();
        }

        private void cutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(textBox1.Text);
            textBox1.Text = "";
        }

        private void copyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(textBox1.Text);
        }

        private void pastetoolStripButton6_Click(object sender, EventArgs e)
        {
            pastToolStripMenuItem.PerformClick();
        }

        private void fontToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FontDialog dialog = new FontDialog();

            if (dialog.ShowDialog() == DialogResult.OK)
                textBox1.Font = dialog.Font;
        }

        private void colorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ColorDialog dialog = new ColorDialog();

            if (dialog.ShowDialog() == DialogResult.OK)
                textBox1.ForeColor = dialog.Color;
        }

        private void indamtoolStripButton11_Click(object sender, EventArgs e)
        {
            if (!(textBox1.Font.Bold))
                textBox1.Font = new Font(textBox1.Font, FontStyle.Bold);

            else
                textBox1.Font = new Font(textBox1.Font, FontStyle.Regular);
        }

        private void innghiengtoolStripButton12_Click(object sender, EventArgs e)
        {
            if (!(textBox1.Font.Italic))
                textBox1.Font = new Font(textBox1.Font, FontStyle.Italic);

            else
                textBox1.Font = new Font(textBox1.Font, FontStyle.Regular);
        }

        private void gachduoitoolStripButton13_Click(object sender, EventArgs e)
        {
            if (!(textBox1.Font.Underline))
                textBox1.Font = new Font(textBox1.Font, FontStyle.Underline);

            else
                textBox1.Font = new Font(textBox1.Font, FontStyle.Regular);
        }

        private void legiuatoolStripButton9_Click(object sender, EventArgs e)
        {
            textBox1.TextAlign = HorizontalAlignment.Center;
        }

        private void letraitoolStripButton8_Click(object sender, EventArgs e)
        {
            textBox1.TextAlign = HorizontalAlignment.Left;
        }

        private void lephaitoolStripButton10_Click(object sender, EventArgs e)
        {
            textBox1.TextAlign = HorizontalAlignment.Right;
        }

        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void FormEditor_Load(object sender, EventArgs e)
        {
            foreach (FontFamily font in FontFamily.Families)
                cbbFont.Items.Add(font.Name.ToString());
        }

        private void cbbFont_TextChanged(object sender, EventArgs e)
        {
            try
            {
                textBox1.Font = new Font(cbbFont.Text, textBox1.Font.Size);
            }
            catch { }
        }
    }
}
