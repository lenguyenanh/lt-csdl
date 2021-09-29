
namespace Lab4_Demo_Editor
{
    partial class FormEditor
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.closeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.printToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.copyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pastToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.formatToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fontToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.colorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.windowToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cascadeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.newtoolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.opentoolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.savetoolStripButton3 = new System.Windows.Forms.ToolStripButton();
            this.printtoolStripButton4 = new System.Windows.Forms.ToolStripButton();
            this.copytoolStripButton5 = new System.Windows.Forms.ToolStripButton();
            this.pastetoolStripButton6 = new System.Windows.Forms.ToolStripButton();
            this.cuttoolStripButton7 = new System.Windows.Forms.ToolStripButton();
            this.letraitoolStripButton8 = new System.Windows.Forms.ToolStripButton();
            this.legiuatoolStripButton9 = new System.Windows.Forms.ToolStripButton();
            this.lephaitoolStripButton10 = new System.Windows.Forms.ToolStripButton();
            this.indamtoolStripButton11 = new System.Windows.Forms.ToolStripButton();
            this.innghiengtoolStripButton12 = new System.Windows.Forms.ToolStripButton();
            this.gachduoitoolStripButton13 = new System.Windows.Forms.ToolStripButton();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.cbbFont = new System.Windows.Forms.ComboBox();
            this.cbbSize = new System.Windows.Forms.ComboBox();
            this.menuStrip1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.editToolStripMenuItem,
            this.formatToolStripMenuItem,
            this.windowToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newToolStripMenuItem,
            this.openToolStripMenuItem,
            this.saveToolStripMenuItem,
            this.closeToolStripMenuItem,
            this.printToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(46, 24);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // newToolStripMenuItem
            // 
            this.newToolStripMenuItem.Name = "newToolStripMenuItem";
            this.newToolStripMenuItem.Size = new System.Drawing.Size(140, 26);
            this.newToolStripMenuItem.Text = "New";
            this.newToolStripMenuItem.Click += new System.EventHandler(this.newToolStripMenuItem_Click);
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(140, 26);
            this.openToolStripMenuItem.Text = "Open";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(140, 26);
            this.saveToolStripMenuItem.Text = "Save";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // closeToolStripMenuItem
            // 
            this.closeToolStripMenuItem.Name = "closeToolStripMenuItem";
            this.closeToolStripMenuItem.Size = new System.Drawing.Size(140, 26);
            this.closeToolStripMenuItem.Text = "Close";
            this.closeToolStripMenuItem.Click += new System.EventHandler(this.closeToolStripMenuItem_Click);
            // 
            // printToolStripMenuItem
            // 
            this.printToolStripMenuItem.Name = "printToolStripMenuItem";
            this.printToolStripMenuItem.Size = new System.Drawing.Size(140, 26);
            this.printToolStripMenuItem.Text = "Print";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F4;
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(140, 26);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cutToolStripMenuItem,
            this.copyToolStripMenuItem,
            this.pastToolStripMenuItem});
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(49, 24);
            this.editToolStripMenuItem.Text = "Edit";
            // 
            // cutToolStripMenuItem
            // 
            this.cutToolStripMenuItem.Name = "cutToolStripMenuItem";
            this.cutToolStripMenuItem.Size = new System.Drawing.Size(126, 26);
            this.cutToolStripMenuItem.Text = "Cut";
            this.cutToolStripMenuItem.Click += new System.EventHandler(this.cutToolStripMenuItem_Click);
            // 
            // copyToolStripMenuItem
            // 
            this.copyToolStripMenuItem.Name = "copyToolStripMenuItem";
            this.copyToolStripMenuItem.Size = new System.Drawing.Size(126, 26);
            this.copyToolStripMenuItem.Text = "Copy";
            this.copyToolStripMenuItem.Click += new System.EventHandler(this.copyToolStripMenuItem_Click);
            // 
            // pastToolStripMenuItem
            // 
            this.pastToolStripMenuItem.Name = "pastToolStripMenuItem";
            this.pastToolStripMenuItem.Size = new System.Drawing.Size(126, 26);
            this.pastToolStripMenuItem.Text = "Paste";
            this.pastToolStripMenuItem.Click += new System.EventHandler(this.pastToolStripMenuItem_Click);
            // 
            // formatToolStripMenuItem
            // 
            this.formatToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fontToolStripMenuItem,
            this.colorToolStripMenuItem});
            this.formatToolStripMenuItem.Name = "formatToolStripMenuItem";
            this.formatToolStripMenuItem.Size = new System.Drawing.Size(70, 24);
            this.formatToolStripMenuItem.Text = "Format";
            // 
            // fontToolStripMenuItem
            // 
            this.fontToolStripMenuItem.Name = "fontToolStripMenuItem";
            this.fontToolStripMenuItem.Size = new System.Drawing.Size(128, 26);
            this.fontToolStripMenuItem.Text = "Font";
            this.fontToolStripMenuItem.Click += new System.EventHandler(this.fontToolStripMenuItem_Click);
            // 
            // colorToolStripMenuItem
            // 
            this.colorToolStripMenuItem.Name = "colorToolStripMenuItem";
            this.colorToolStripMenuItem.Size = new System.Drawing.Size(128, 26);
            this.colorToolStripMenuItem.Text = "Color";
            this.colorToolStripMenuItem.Click += new System.EventHandler(this.colorToolStripMenuItem_Click);
            // 
            // windowToolStripMenuItem
            // 
            this.windowToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cascadeToolStripMenuItem,
            this.tileToolStripMenuItem});
            this.windowToolStripMenuItem.Name = "windowToolStripMenuItem";
            this.windowToolStripMenuItem.Size = new System.Drawing.Size(84, 24);
            this.windowToolStripMenuItem.Text = "Windows";
            // 
            // cascadeToolStripMenuItem
            // 
            this.cascadeToolStripMenuItem.Name = "cascadeToolStripMenuItem";
            this.cascadeToolStripMenuItem.Size = new System.Drawing.Size(147, 26);
            this.cascadeToolStripMenuItem.Text = "Cascade";
            // 
            // tileToolStripMenuItem
            // 
            this.tileToolStripMenuItem.Name = "tileToolStripMenuItem";
            this.tileToolStripMenuItem.Size = new System.Drawing.Size(147, 26);
            this.tileToolStripMenuItem.Text = "Tile";
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newtoolStripButton1,
            this.opentoolStripButton2,
            this.savetoolStripButton3,
            this.printtoolStripButton4,
            this.copytoolStripButton5,
            this.pastetoolStripButton6,
            this.cuttoolStripButton7,
            this.letraitoolStripButton8,
            this.legiuatoolStripButton9,
            this.lephaitoolStripButton10,
            this.indamtoolStripButton11,
            this.innghiengtoolStripButton12,
            this.gachduoitoolStripButton13});
            this.toolStrip1.Location = new System.Drawing.Point(0, 28);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(800, 27);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // newtoolStripButton1
            // 
            this.newtoolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.newtoolStripButton1.Image = global::Lab4_Demo_Editor.Properties.Resources._new;
            this.newtoolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.newtoolStripButton1.Name = "newtoolStripButton1";
            this.newtoolStripButton1.Size = new System.Drawing.Size(29, 24);
            this.newtoolStripButton1.Text = "New";
            this.newtoolStripButton1.Click += new System.EventHandler(this.newtoolStripButton1_Click);
            // 
            // opentoolStripButton2
            // 
            this.opentoolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.opentoolStripButton2.Image = global::Lab4_Demo_Editor.Properties.Resources.open;
            this.opentoolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.opentoolStripButton2.Name = "opentoolStripButton2";
            this.opentoolStripButton2.Size = new System.Drawing.Size(29, 24);
            this.opentoolStripButton2.Text = "Open";
            this.opentoolStripButton2.Click += new System.EventHandler(this.opentoolStripButton2_Click);
            // 
            // savetoolStripButton3
            // 
            this.savetoolStripButton3.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.savetoolStripButton3.Image = global::Lab4_Demo_Editor.Properties.Resources.save;
            this.savetoolStripButton3.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.savetoolStripButton3.Name = "savetoolStripButton3";
            this.savetoolStripButton3.Size = new System.Drawing.Size(29, 24);
            this.savetoolStripButton3.Text = "Save";
            this.savetoolStripButton3.Click += new System.EventHandler(this.savetoolStripButton3_Click);
            // 
            // printtoolStripButton4
            // 
            this.printtoolStripButton4.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.printtoolStripButton4.Image = global::Lab4_Demo_Editor.Properties.Resources.print;
            this.printtoolStripButton4.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.printtoolStripButton4.Name = "printtoolStripButton4";
            this.printtoolStripButton4.Size = new System.Drawing.Size(29, 24);
            this.printtoolStripButton4.Text = "Print";
            // 
            // copytoolStripButton5
            // 
            this.copytoolStripButton5.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.copytoolStripButton5.Image = global::Lab4_Demo_Editor.Properties.Resources.copy;
            this.copytoolStripButton5.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.copytoolStripButton5.Name = "copytoolStripButton5";
            this.copytoolStripButton5.Size = new System.Drawing.Size(29, 24);
            this.copytoolStripButton5.Text = "Copy";
            this.copytoolStripButton5.Click += new System.EventHandler(this.copytoolStripButton5_Click);
            // 
            // pastetoolStripButton6
            // 
            this.pastetoolStripButton6.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.pastetoolStripButton6.Image = global::Lab4_Demo_Editor.Properties.Resources.paste;
            this.pastetoolStripButton6.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.pastetoolStripButton6.Name = "pastetoolStripButton6";
            this.pastetoolStripButton6.Size = new System.Drawing.Size(29, 24);
            this.pastetoolStripButton6.Text = "Paste";
            this.pastetoolStripButton6.Click += new System.EventHandler(this.pastetoolStripButton6_Click);
            // 
            // cuttoolStripButton7
            // 
            this.cuttoolStripButton7.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.cuttoolStripButton7.Image = global::Lab4_Demo_Editor.Properties.Resources.cut;
            this.cuttoolStripButton7.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.cuttoolStripButton7.Name = "cuttoolStripButton7";
            this.cuttoolStripButton7.Size = new System.Drawing.Size(29, 24);
            this.cuttoolStripButton7.Text = "Cut";
            this.cuttoolStripButton7.Click += new System.EventHandler(this.cuttoolStripButton7_Click);
            // 
            // letraitoolStripButton8
            // 
            this.letraitoolStripButton8.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.letraitoolStripButton8.Image = global::Lab4_Demo_Editor.Properties.Resources.left;
            this.letraitoolStripButton8.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.letraitoolStripButton8.Name = "letraitoolStripButton8";
            this.letraitoolStripButton8.Size = new System.Drawing.Size(29, 24);
            this.letraitoolStripButton8.Text = "Align Left";
            this.letraitoolStripButton8.Click += new System.EventHandler(this.letraitoolStripButton8_Click);
            // 
            // legiuatoolStripButton9
            // 
            this.legiuatoolStripButton9.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.legiuatoolStripButton9.Image = global::Lab4_Demo_Editor.Properties.Resources.center;
            this.legiuatoolStripButton9.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.legiuatoolStripButton9.Name = "legiuatoolStripButton9";
            this.legiuatoolStripButton9.Size = new System.Drawing.Size(29, 24);
            this.legiuatoolStripButton9.Text = "Align Center";
            this.legiuatoolStripButton9.Click += new System.EventHandler(this.legiuatoolStripButton9_Click);
            // 
            // lephaitoolStripButton10
            // 
            this.lephaitoolStripButton10.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.lephaitoolStripButton10.Image = global::Lab4_Demo_Editor.Properties.Resources.right;
            this.lephaitoolStripButton10.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.lephaitoolStripButton10.Name = "lephaitoolStripButton10";
            this.lephaitoolStripButton10.Size = new System.Drawing.Size(29, 24);
            this.lephaitoolStripButton10.Text = "Align Right";
            this.lephaitoolStripButton10.Click += new System.EventHandler(this.lephaitoolStripButton10_Click);
            // 
            // indamtoolStripButton11
            // 
            this.indamtoolStripButton11.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.indamtoolStripButton11.Image = global::Lab4_Demo_Editor.Properties.Resources.bold;
            this.indamtoolStripButton11.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.indamtoolStripButton11.Name = "indamtoolStripButton11";
            this.indamtoolStripButton11.Size = new System.Drawing.Size(29, 24);
            this.indamtoolStripButton11.Text = "Bold";
            this.indamtoolStripButton11.Click += new System.EventHandler(this.indamtoolStripButton11_Click);
            // 
            // innghiengtoolStripButton12
            // 
            this.innghiengtoolStripButton12.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.innghiengtoolStripButton12.Image = global::Lab4_Demo_Editor.Properties.Resources.italic;
            this.innghiengtoolStripButton12.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.innghiengtoolStripButton12.Name = "innghiengtoolStripButton12";
            this.innghiengtoolStripButton12.Size = new System.Drawing.Size(29, 24);
            this.innghiengtoolStripButton12.Text = "Italic";
            this.innghiengtoolStripButton12.Click += new System.EventHandler(this.innghiengtoolStripButton12_Click);
            // 
            // gachduoitoolStripButton13
            // 
            this.gachduoitoolStripButton13.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.gachduoitoolStripButton13.Image = global::Lab4_Demo_Editor.Properties.Resources.underline;
            this.gachduoitoolStripButton13.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.gachduoitoolStripButton13.Name = "gachduoitoolStripButton13";
            this.gachduoitoolStripButton13.Size = new System.Drawing.Size(29, 24);
            this.gachduoitoolStripButton13.Text = "Underline";
            this.gachduoitoolStripButton13.Click += new System.EventHandler(this.gachduoitoolStripButton13_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(13, 73);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(650, 246);
            this.textBox1.TabIndex = 2;
            // 
            // cbbFont
            // 
            this.cbbFont.FormattingEnabled = true;
            this.cbbFont.Location = new System.Drawing.Point(433, 28);
            this.cbbFont.Name = "cbbFont";
            this.cbbFont.Size = new System.Drawing.Size(102, 24);
            this.cbbFont.TabIndex = 3;
            this.cbbFont.TextChanged += new System.EventHandler(this.cbbFont_TextChanged);
            // 
            // cbbSize
            // 
            this.cbbSize.FormattingEnabled = true;
            this.cbbSize.Location = new System.Drawing.Point(541, 29);
            this.cbbSize.Name = "cbbSize";
            this.cbbSize.Size = new System.Drawing.Size(54, 24);
            this.cbbSize.TabIndex = 3;
            // 
            // FormEditor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.cbbSize);
            this.Controls.Add(this.cbbFont);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FormEditor";
            this.Text = "My Editor";
            this.Load += new System.EventHandler(this.FormEditor_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem closeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem printToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem copyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pastToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem formatToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fontToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem colorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem windowToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cascadeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tileToolStripMenuItem;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton newtoolStripButton1;
        private System.Windows.Forms.ToolStripButton opentoolStripButton2;
        private System.Windows.Forms.ToolStripButton savetoolStripButton3;
        private System.Windows.Forms.ToolStripButton printtoolStripButton4;
        private System.Windows.Forms.ToolStripButton copytoolStripButton5;
        private System.Windows.Forms.ToolStripButton pastetoolStripButton6;
        private System.Windows.Forms.ToolStripButton cuttoolStripButton7;
        private System.Windows.Forms.ToolStripButton letraitoolStripButton8;
        private System.Windows.Forms.ToolStripButton legiuatoolStripButton9;
        private System.Windows.Forms.ToolStripButton lephaitoolStripButton10;
        private System.Windows.Forms.ToolStripButton indamtoolStripButton11;
        private System.Windows.Forms.ToolStripButton innghiengtoolStripButton12;
        private System.Windows.Forms.ToolStripButton gachduoitoolStripButton13;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ComboBox cbbFont;
        private System.Windows.Forms.ComboBox cbbSize;
    }
}

