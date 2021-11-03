
namespace Lab06_Basic_Command
{
    partial class BillsForm
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
            this.dgvBills = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BillName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TableID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Amount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Discount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tax = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CheckoutDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Account = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBills)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvBills
            // 
            this.dgvBills.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvBills.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBills.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.BillName,
            this.TableID,
            this.Amount,
            this.Discount,
            this.Tax,
            this.Status,
            this.CheckoutDate,
            this.Account});
            this.dgvBills.Location = new System.Drawing.Point(12, 35);
            this.dgvBills.Name = "dgvBills";
            this.dgvBills.RowHeadersWidth = 51;
            this.dgvBills.RowTemplate.Height = 24;
            this.dgvBills.Size = new System.Drawing.Size(1248, 365);
            this.dgvBills.TabIndex = 1;
            this.dgvBills.DoubleClick += new System.EventHandler(this.dgvBills_DoubleClick);
            // 
            // ID
            // 
            this.ID.DataPropertyName = "ID";
            this.ID.HeaderText = "Mã hóa đơn";
            this.ID.MinimumWidth = 6;
            this.ID.Name = "ID";
            this.ID.Width = 125;
            // 
            // BillName
            // 
            this.BillName.DataPropertyName = "Name";
            this.BillName.HeaderText = "Tên hóa đơn";
            this.BillName.MinimumWidth = 6;
            this.BillName.Name = "BillName";
            this.BillName.Width = 125;
            // 
            // TableID
            // 
            this.TableID.DataPropertyName = "TableID";
            this.TableID.HeaderText = "Mã bàn";
            this.TableID.MinimumWidth = 6;
            this.TableID.Name = "TableID";
            this.TableID.Width = 125;
            // 
            // Amount
            // 
            this.Amount.DataPropertyName = "Amount";
            this.Amount.HeaderText = "Tổng tiền";
            this.Amount.MinimumWidth = 6;
            this.Amount.Name = "Amount";
            this.Amount.Width = 125;
            // 
            // Discount
            // 
            this.Discount.DataPropertyName = "Discount";
            this.Discount.HeaderText = "Giảm giá";
            this.Discount.MinimumWidth = 6;
            this.Discount.Name = "Discount";
            this.Discount.Width = 125;
            // 
            // Tax
            // 
            this.Tax.DataPropertyName = "Tax";
            this.Tax.HeaderText = "Thuế";
            this.Tax.MinimumWidth = 6;
            this.Tax.Name = "Tax";
            this.Tax.Width = 125;
            // 
            // Status
            // 
            this.Status.DataPropertyName = "Status";
            this.Status.HeaderText = "Trạng thái";
            this.Status.MinimumWidth = 6;
            this.Status.Name = "Status";
            this.Status.Width = 125;
            // 
            // CheckoutDate
            // 
            this.CheckoutDate.DataPropertyName = "CheckoutDate";
            this.CheckoutDate.HeaderText = "Ngày thanh toán";
            this.CheckoutDate.MinimumWidth = 6;
            this.CheckoutDate.Name = "CheckoutDate";
            this.CheckoutDate.Width = 125;
            // 
            // Account
            // 
            this.Account.DataPropertyName = "Account";
            this.Account.HeaderText = "Tài khoản";
            this.Account.MinimumWidth = 6;
            this.Account.Name = "Account";
            this.Account.Width = 125;
            // 
            // BillsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1272, 425);
            this.Controls.Add(this.dgvBills);
            this.Name = "BillsForm";
            this.Text = "BillsForm";
            ((System.ComponentModel.ISupportInitialize)(this.dgvBills)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvBills;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn BillName;
        private System.Windows.Forms.DataGridViewTextBoxColumn TableID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Amount;
        private System.Windows.Forms.DataGridViewTextBoxColumn Discount;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tax;
        private System.Windows.Forms.DataGridViewTextBoxColumn Status;
        private System.Windows.Forms.DataGridViewTextBoxColumn CheckoutDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn Account;
    }
}