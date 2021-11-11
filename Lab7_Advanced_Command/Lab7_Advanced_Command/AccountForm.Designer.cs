
namespace Lab7_Advanced_Command
{
    partial class AccountForm
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
            this.dgvAccount = new System.Windows.Forms.DataGridView();
            this.AccountName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Password = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FullName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tell = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DateCreated = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tsmiRoleAccount = new System.Windows.Forms.ToolStripMenuItem();
            this.xemNhậtKýHoạtĐộngToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAccount)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvAccount
            // 
            this.dgvAccount.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvAccount.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAccount.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.AccountName,
            this.Password,
            this.FullName,
            this.Email,
            this.Tell,
            this.DateCreated});
            this.dgvAccount.ContextMenuStrip = this.contextMenuStrip1;
            this.dgvAccount.Location = new System.Drawing.Point(12, 12);
            this.dgvAccount.Name = "dgvAccount";
            this.dgvAccount.RowHeadersWidth = 51;
            this.dgvAccount.RowTemplate.Height = 24;
            this.dgvAccount.Size = new System.Drawing.Size(1060, 393);
            this.dgvAccount.TabIndex = 1;
            // 
            // AccountName
            // 
            this.AccountName.DataPropertyName = "AccountName";
            this.AccountName.HeaderText = "Tên tài khoản";
            this.AccountName.MinimumWidth = 6;
            this.AccountName.Name = "AccountName";
            this.AccountName.Width = 125;
            // 
            // Password
            // 
            this.Password.DataPropertyName = "Password";
            this.Password.HeaderText = "Mật khẩu";
            this.Password.MinimumWidth = 6;
            this.Password.Name = "Password";
            this.Password.Width = 125;
            // 
            // FullName
            // 
            this.FullName.DataPropertyName = "FullName";
            this.FullName.HeaderText = "Họ và tên";
            this.FullName.MinimumWidth = 6;
            this.FullName.Name = "FullName";
            this.FullName.Width = 125;
            // 
            // Email
            // 
            this.Email.DataPropertyName = "Email";
            this.Email.HeaderText = "Email";
            this.Email.MinimumWidth = 6;
            this.Email.Name = "Email";
            this.Email.Width = 125;
            // 
            // Tell
            // 
            this.Tell.DataPropertyName = "Tell";
            this.Tell.HeaderText = "Số điện thoại";
            this.Tell.MinimumWidth = 6;
            this.Tell.Name = "Tell";
            this.Tell.Width = 125;
            // 
            // DateCreated
            // 
            this.DateCreated.DataPropertyName = "DateCreated";
            this.DateCreated.HeaderText = "Ngày tạo";
            this.DateCreated.MinimumWidth = 6;
            this.DateCreated.Name = "DateCreated";
            this.DateCreated.Width = 125;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiRoleAccount,
            this.xemNhậtKýHoạtĐộngToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(233, 80);
            // 
            // tsmiRoleAccount
            // 
            this.tsmiRoleAccount.Name = "tsmiRoleAccount";
            this.tsmiRoleAccount.Size = new System.Drawing.Size(232, 24);
            this.tsmiRoleAccount.Text = "Xem danh sách vai trò";
            this.tsmiRoleAccount.Click += new System.EventHandler(this.tsmiRoleAccount_Click);
            // 
            // xemNhậtKýHoạtĐộngToolStripMenuItem
            // 
            this.xemNhậtKýHoạtĐộngToolStripMenuItem.Name = "xemNhậtKýHoạtĐộngToolStripMenuItem";
            this.xemNhậtKýHoạtĐộngToolStripMenuItem.Size = new System.Drawing.Size(232, 24);
            this.xemNhậtKýHoạtĐộngToolStripMenuItem.Text = "Xem nhật ký hoạt động";
            this.xemNhậtKýHoạtĐộngToolStripMenuItem.Click += new System.EventHandler(this.xemNhậtKýHoạtĐộngToolStripMenuItem_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(886, 412);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(90, 30);
            this.btnAdd.TabIndex = 2;
            this.btnAdd.Text = "Thêm";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(982, 411);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(90, 30);
            this.btnUpdate.TabIndex = 2;
            this.btnUpdate.Text = "Cập nhật";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // AccountForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1084, 454);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.dgvAccount);
            this.Name = "AccountForm";
            this.Text = "AccountForm";
            ((System.ComponentModel.ISupportInitialize)(this.dgvAccount)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvAccount;
        private System.Windows.Forms.DataGridViewTextBoxColumn AccountName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Password;
        private System.Windows.Forms.DataGridViewTextBoxColumn FullName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Email;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tell;
        private System.Windows.Forms.DataGridViewTextBoxColumn DateCreated;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem tsmiRoleAccount;
        private System.Windows.Forms.ToolStripMenuItem xemNhậtKýHoạtĐộngToolStripMenuItem;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnUpdate;
    }
}