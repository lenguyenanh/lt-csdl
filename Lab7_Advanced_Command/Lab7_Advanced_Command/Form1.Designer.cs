
namespace Lab7_Advanced_Command
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
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tsmCalculateQuantity = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmAddFood = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmUpdateFood = new System.Windows.Forms.ToolStripMenuItem();
            this.label2 = new System.Windows.Forms.Label();
            this.lblQuantity = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblCatName = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cbbCategory = new System.Windows.Forms.ComboBox();
            this.Notes = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FoodCategoryID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Unit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FoodName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvFoodList = new System.Windows.Forms.DataGridView();
            this.txtSearchByName = new System.Windows.Forms.TextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.danhSáchTàiKhoảnToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFoodList)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmCalculateQuantity,
            this.tsmAddFood,
            this.tsmUpdateFood});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(219, 76);
            // 
            // tsmCalculateQuantity
            // 
            this.tsmCalculateQuantity.Name = "tsmCalculateQuantity";
            this.tsmCalculateQuantity.Size = new System.Drawing.Size(218, 24);
            this.tsmCalculateQuantity.Text = "Tính số lượng đã bán";
            this.tsmCalculateQuantity.Click += new System.EventHandler(this.tsmCalculateQuantity_Click);
            // 
            // tsmAddFood
            // 
            this.tsmAddFood.Name = "tsmAddFood";
            this.tsmAddFood.Size = new System.Drawing.Size(218, 24);
            this.tsmAddFood.Text = "Thêm món ăn";
            this.tsmAddFood.Click += new System.EventHandler(this.tsmAddFood_Click);
            // 
            // tsmUpdateFood
            // 
            this.tsmUpdateFood.Name = "tsmUpdateFood";
            this.tsmUpdateFood.Size = new System.Drawing.Size(218, 24);
            this.tsmUpdateFood.Text = "Cập nhật món ăn";
            this.tsmUpdateFood.Click += new System.EventHandler(this.tsmUpdateFood_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(29, 489);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Có tất cả";
            // 
            // lblQuantity
            // 
            this.lblQuantity.AutoSize = true;
            this.lblQuantity.Location = new System.Drawing.Point(99, 489);
            this.lblQuantity.Name = "lblQuantity";
            this.lblQuantity.Size = new System.Drawing.Size(20, 17);
            this.lblQuantity.TabIndex = 3;
            this.lblQuantity.Text = "...";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(125, 489);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(133, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "món ăn thuộc nhóm";
            // 
            // lblCatName
            // 
            this.lblCatName.AutoSize = true;
            this.lblCatName.Location = new System.Drawing.Point(264, 490);
            this.lblCatName.Name = "lblCatName";
            this.lblCatName.Size = new System.Drawing.Size(20, 17);
            this.lblCatName.TabIndex = 3;
            this.lblCatName.Text = "...";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(135, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Chọn nhóm món ăn:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(357, 47);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(124, 17);
            this.label3.TabIndex = 0;
            this.label3.Text = "Tìm kiếm theo tên:";
            // 
            // cbbCategory
            // 
            this.cbbCategory.FormattingEnabled = true;
            this.cbbCategory.Location = new System.Drawing.Point(153, 40);
            this.cbbCategory.Name = "cbbCategory";
            this.cbbCategory.Size = new System.Drawing.Size(161, 24);
            this.cbbCategory.TabIndex = 1;
            this.cbbCategory.SelectedIndexChanged += new System.EventHandler(this.cbbCategory_SelectedIndexChanged);
            // 
            // Notes
            // 
            this.Notes.DataPropertyName = "Notes";
            this.Notes.HeaderText = "Ghi chú";
            this.Notes.MinimumWidth = 6;
            this.Notes.Name = "Notes";
            this.Notes.Width = 125;
            // 
            // Price
            // 
            this.Price.DataPropertyName = "Price";
            this.Price.HeaderText = "Giá";
            this.Price.MinimumWidth = 6;
            this.Price.Name = "Price";
            this.Price.Width = 125;
            // 
            // FoodCategoryID
            // 
            this.FoodCategoryID.DataPropertyName = "FoodCategoryID";
            this.FoodCategoryID.HeaderText = "Mã loại món ăn";
            this.FoodCategoryID.MinimumWidth = 6;
            this.FoodCategoryID.Name = "FoodCategoryID";
            this.FoodCategoryID.Width = 125;
            // 
            // Unit
            // 
            this.Unit.DataPropertyName = "Unit";
            this.Unit.HeaderText = "Đơn vị";
            this.Unit.MinimumWidth = 6;
            this.Unit.Name = "Unit";
            this.Unit.Width = 125;
            // 
            // FoodName
            // 
            this.FoodName.DataPropertyName = "Name";
            this.FoodName.HeaderText = "Tên món ăn";
            this.FoodName.MinimumWidth = 6;
            this.FoodName.Name = "FoodName";
            this.FoodName.Width = 125;
            // 
            // ID
            // 
            this.ID.DataPropertyName = "ID";
            this.ID.HeaderText = "Mã món ăn";
            this.ID.MinimumWidth = 6;
            this.ID.Name = "ID";
            this.ID.Width = 125;
            // 
            // dgvFoodList
            // 
            this.dgvFoodList.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvFoodList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFoodList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.FoodName,
            this.Unit,
            this.FoodCategoryID,
            this.Price,
            this.Notes});
            this.dgvFoodList.ContextMenuStrip = this.contextMenuStrip1;
            this.dgvFoodList.Location = new System.Drawing.Point(13, 77);
            this.dgvFoodList.MultiSelect = false;
            this.dgvFoodList.Name = "dgvFoodList";
            this.dgvFoodList.RowHeadersWidth = 51;
            this.dgvFoodList.RowTemplate.Height = 24;
            this.dgvFoodList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvFoodList.Size = new System.Drawing.Size(1018, 400);
            this.dgvFoodList.TabIndex = 2;
            // 
            // txtSearchByName
            // 
            this.txtSearchByName.Location = new System.Drawing.Point(488, 41);
            this.txtSearchByName.Name = "txtSearchByName";
            this.txtSearchByName.Size = new System.Drawing.Size(199, 22);
            this.txtSearchByName.TabIndex = 4;
            this.txtSearchByName.TextChanged += new System.EventHandler(this.txtSearchByname_TextChanged);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuToolStripMenuItem,
            this.danhSáchTàiKhoảnToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1043, 28);
            this.menuStrip1.TabIndex = 5;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuToolStripMenuItem
            // 
            this.menuToolStripMenuItem.Name = "menuToolStripMenuItem";
            this.menuToolStripMenuItem.Size = new System.Drawing.Size(150, 24);
            this.menuToolStripMenuItem.Text = "Danh sách hóa đơn";
            this.menuToolStripMenuItem.Click += new System.EventHandler(this.menuToolStripMenuItem_Click);
            // 
            // danhSáchTàiKhoảnToolStripMenuItem
            // 
            this.danhSáchTàiKhoảnToolStripMenuItem.Name = "danhSáchTàiKhoảnToolStripMenuItem";
            this.danhSáchTàiKhoảnToolStripMenuItem.Size = new System.Drawing.Size(156, 24);
            this.danhSáchTàiKhoảnToolStripMenuItem.Text = "Danh sách tài khoản";
            this.danhSáchTàiKhoảnToolStripMenuItem.Click += new System.EventHandler(this.danhSáchTàiKhoảnToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1043, 540);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.txtSearchByName);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblCatName);
            this.Controls.Add(this.lblQuantity);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dgvFoodList);
            this.Controls.Add(this.cbbCategory);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.contextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvFoodList)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblQuantity;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblCatName;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem tsmCalculateQuantity;
        private System.Windows.Forms.ToolStripMenuItem tsmAddFood;
        private System.Windows.Forms.ToolStripMenuItem tsmUpdateFood;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbbCategory;
        private System.Windows.Forms.DataGridViewTextBoxColumn Notes;
        private System.Windows.Forms.DataGridViewTextBoxColumn Price;
        private System.Windows.Forms.DataGridViewTextBoxColumn FoodCategoryID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Unit;
        private System.Windows.Forms.DataGridViewTextBoxColumn FoodName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridView dgvFoodList;
        private System.Windows.Forms.TextBox txtSearchByName;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem danhSáchTàiKhoảnToolStripMenuItem;
    }
}

