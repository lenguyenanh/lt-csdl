
namespace Lab06_Basic_Command
{
    partial class FoodForm
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
            this.dgvFood = new System.Windows.Forms.DataGridView();
            this.btnSaveFood = new System.Windows.Forms.Button();
            this.btnDeleteFood = new System.Windows.Forms.Button();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FoodName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Unit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FoodCategoryID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Notes = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFood)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvFood
            // 
            this.dgvFood.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvFood.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFood.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.FoodName,
            this.Unit,
            this.FoodCategoryID,
            this.Price,
            this.Notes});
            this.dgvFood.Location = new System.Drawing.Point(12, 12);
            this.dgvFood.Name = "dgvFood";
            this.dgvFood.RowHeadersWidth = 51;
            this.dgvFood.RowTemplate.Height = 24;
            this.dgvFood.Size = new System.Drawing.Size(865, 410);
            this.dgvFood.TabIndex = 2;
            // 
            // btnSaveFood
            // 
            this.btnSaveFood.Location = new System.Drawing.Point(699, 429);
            this.btnSaveFood.Name = "btnSaveFood";
            this.btnSaveFood.Size = new System.Drawing.Size(82, 31);
            this.btnSaveFood.TabIndex = 3;
            this.btnSaveFood.Text = "Lưu";
            this.btnSaveFood.UseVisualStyleBackColor = true;
            this.btnSaveFood.Click += new System.EventHandler(this.btnSaveFood_Click);
            // 
            // btnDeleteFood
            // 
            this.btnDeleteFood.Location = new System.Drawing.Point(798, 429);
            this.btnDeleteFood.Name = "btnDeleteFood";
            this.btnDeleteFood.Size = new System.Drawing.Size(82, 31);
            this.btnDeleteFood.TabIndex = 4;
            this.btnDeleteFood.Text = "Xóa";
            this.btnDeleteFood.UseVisualStyleBackColor = true;
            this.btnDeleteFood.Click += new System.EventHandler(this.btnDeleteFood_Click);
            // 
            // ID
            // 
            this.ID.DataPropertyName = "ID";
            this.ID.HeaderText = "Mã món ăn";
            this.ID.MinimumWidth = 6;
            this.ID.Name = "ID";
            this.ID.Width = 120;
            // 
            // FoodName
            // 
            this.FoodName.DataPropertyName = "Name";
            this.FoodName.HeaderText = "Tên món ăn";
            this.FoodName.MinimumWidth = 6;
            this.FoodName.Name = "FoodName";
            this.FoodName.Width = 125;
            // 
            // Unit
            // 
            this.Unit.DataPropertyName = "Unit";
            this.Unit.HeaderText = "Đơn vị";
            this.Unit.MinimumWidth = 6;
            this.Unit.Name = "Unit";
            this.Unit.Width = 70;
            // 
            // FoodCategoryID
            // 
            this.FoodCategoryID.DataPropertyName = "FoodCategoryID";
            this.FoodCategoryID.HeaderText = "Mã loại món ăn";
            this.FoodCategoryID.MinimumWidth = 6;
            this.FoodCategoryID.Name = "FoodCategoryID";
            this.FoodCategoryID.Width = 140;
            // 
            // Price
            // 
            this.Price.DataPropertyName = "Price";
            this.Price.HeaderText = "Giá";
            this.Price.MinimumWidth = 6;
            this.Price.Name = "Price";
            this.Price.Width = 125;
            // 
            // Notes
            // 
            this.Notes.DataPropertyName = "Notes";
            this.Notes.HeaderText = "Ghi chú";
            this.Notes.MinimumWidth = 6;
            this.Notes.Name = "Notes";
            this.Notes.Width = 125;
            // 
            // FoodForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(911, 466);
            this.Controls.Add(this.dgvFood);
            this.Controls.Add(this.btnSaveFood);
            this.Controls.Add(this.btnDeleteFood);
            this.Name = "FoodForm";
            this.Text = "FoodForm";
            ((System.ComponentModel.ISupportInitialize)(this.dgvFood)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvFood;
        private System.Windows.Forms.Button btnSaveFood;
        private System.Windows.Forms.Button btnDeleteFood;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn FoodName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Unit;
        private System.Windows.Forms.DataGridViewTextBoxColumn FoodCategoryID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Price;
        private System.Windows.Forms.DataGridViewTextBoxColumn Notes;
    }
}