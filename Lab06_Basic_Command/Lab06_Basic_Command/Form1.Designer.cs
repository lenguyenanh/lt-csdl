
namespace Lab06_Basic_Command
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.menuStripTableList = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStripAccoutList = new System.Windows.Forms.ToolStripMenuItem();
            this.danhSáchTàiKhoảnToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStripBills = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.tsmViewFood = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmDelete = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lvCategory = new System.Windows.Forms.ListView();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnLoad = new System.Windows.Forms.Button();
            this.txtType = new System.Windows.Forms.TextBox();
            this.txtCategoryName = new System.Windows.Forms.TextBox();
            this.txtCategoryID = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStripTableList
            // 
            this.menuStripTableList.Name = "menuStripTableList";
            this.menuStripTableList.Size = new System.Drawing.Size(225, 26);
            this.menuStripTableList.Text = "Danh sách bàn";
            this.menuStripTableList.Click += new System.EventHandler(this.menuStripTableList_Click);
            // 
            // menuStripAccoutList
            // 
            this.menuStripAccoutList.Name = "menuStripAccoutList";
            this.menuStripAccoutList.Size = new System.Drawing.Size(225, 26);
            this.menuStripAccoutList.Text = "Danh sách tài khoản";
            this.menuStripAccoutList.Click += new System.EventHandler(this.menuStripAccoutList_Click);
            // 
            // danhSáchTàiKhoảnToolStripMenuItem
            // 
            this.danhSáchTàiKhoảnToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuStripAccoutList,
            this.menuStripBills,
            this.menuStripTableList});
            this.danhSáchTàiKhoảnToolStripMenuItem.Name = "danhSáchTàiKhoảnToolStripMenuItem";
            this.danhSáchTàiKhoảnToolStripMenuItem.Size = new System.Drawing.Size(60, 24);
            this.danhSáchTàiKhoảnToolStripMenuItem.Text = "Menu";
            // 
            // menuStripBills
            // 
            this.menuStripBills.Name = "menuStripBills";
            this.menuStripBills.Size = new System.Drawing.Size(225, 26);
            this.menuStripBills.Text = "Hóa đơn";
            this.menuStripBills.Click += new System.EventHandler(this.menuStripBills_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.danhSáchTàiKhoảnToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 28);
            this.menuStrip1.TabIndex = 17;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // tsmViewFood
            // 
            this.tsmViewFood.Name = "tsmViewFood";
            this.tsmViewFood.Size = new System.Drawing.Size(232, 24);
            this.tsmViewFood.Text = "Xem danh sách món ăn";
            this.tsmViewFood.Click += new System.EventHandler(this.tsmViewFood_Click);
            // 
            // tsmDelete
            // 
            this.tsmDelete.Name = "tsmDelete";
            this.tsmDelete.Size = new System.Drawing.Size(232, 24);
            this.tsmDelete.Text = "Xóa nhóm sản phẩm";
            this.tsmDelete.Click += new System.EventHandler(this.tsmDelete_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmDelete,
            this.tsmViewFood});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(233, 52);
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Loại";
            this.columnHeader3.Width = 100;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Tên loại món ăn";
            this.columnHeader2.Width = 170;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Mã loại";
            this.columnHeader1.Width = 100;
            // 
            // lvCategory
            // 
            this.lvCategory.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
            this.lvCategory.ContextMenuStrip = this.contextMenuStrip1;
            this.lvCategory.FullRowSelect = true;
            this.lvCategory.HideSelection = false;
            this.lvCategory.Location = new System.Drawing.Point(15, 178);
            this.lvCategory.Name = "lvCategory";
            this.lvCategory.Size = new System.Drawing.Size(775, 319);
            this.lvCategory.TabIndex = 16;
            this.lvCategory.UseCompatibleStateImageBehavior = false;
            this.lvCategory.View = System.Windows.Forms.View.Details;
            this.lvCategory.Click += new System.EventHandler(this.lvCategory_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(481, 132);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(97, 35);
            this.btnDelete.TabIndex = 12;
            this.btnDelete.Text = "Xóa";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(361, 132);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(114, 35);
            this.btnUpdate.TabIndex = 13;
            this.btnUpdate.Text = "Cập nhật";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(245, 132);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(110, 35);
            this.btnAdd.TabIndex = 14;
            this.btnAdd.Text = "Thêm";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnLoad
            // 
            this.btnLoad.Location = new System.Drawing.Point(15, 132);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(124, 35);
            this.btnLoad.TabIndex = 15;
            this.btnLoad.Text = "Lấy danh sách";
            this.btnLoad.UseVisualStyleBackColor = true;
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // txtType
            // 
            this.txtType.Location = new System.Drawing.Point(172, 92);
            this.txtType.Name = "txtType";
            this.txtType.Size = new System.Drawing.Size(226, 22);
            this.txtType.TabIndex = 9;
            // 
            // txtCategoryName
            // 
            this.txtCategoryName.Location = new System.Drawing.Point(172, 62);
            this.txtCategoryName.Name = "txtCategoryName";
            this.txtCategoryName.Size = new System.Drawing.Size(226, 22);
            this.txtCategoryName.TabIndex = 10;
            // 
            // txtCategoryID
            // 
            this.txtCategoryID.Location = new System.Drawing.Point(172, 34);
            this.txtCategoryID.Name = "txtCategoryID";
            this.txtCategoryID.Size = new System.Drawing.Size(226, 22);
            this.txtCategoryID.TabIndex = 11;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 97);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 17);
            this.label3.TabIndex = 6;
            this.label3.Text = "Loại:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(127, 17);
            this.label2.TabIndex = 7;
            this.label2.Text = "Tên nhóm thức ăn:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 17);
            this.label1.TabIndex = 8;
            this.label1.Text = "Mã nhóm:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 515);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.lvCategory);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnLoad);
            this.Controls.Add(this.txtType);
            this.Controls.Add(this.txtCategoryName);
            this.Controls.Add(this.txtCategoryID);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStripMenuItem menuStripTableList;
        private System.Windows.Forms.ToolStripMenuItem menuStripAccoutList;
        private System.Windows.Forms.ToolStripMenuItem danhSáchTàiKhoảnToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem menuStripBills;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem tsmViewFood;
        private System.Windows.Forms.ToolStripMenuItem tsmDelete;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ListView lvCategory;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnLoad;
        private System.Windows.Forms.TextBox txtType;
        private System.Windows.Forms.TextBox txtCategoryName;
        private System.Windows.Forms.TextBox txtCategoryID;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}

