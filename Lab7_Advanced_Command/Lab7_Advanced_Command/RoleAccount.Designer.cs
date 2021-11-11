
namespace Lab7_Advanced_Command
{
    partial class RoleAccount
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
            this.dgvRoleAccount = new System.Windows.Forms.DataGridView();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.cbbRoleName = new System.Windows.Forms.ComboBox();
            this.AccountN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RoleName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Path = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Notes = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRoleAccount)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvRoleAccount
            // 
            this.dgvRoleAccount.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvRoleAccount.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRoleAccount.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.AccountN,
            this.ID,
            this.RoleName,
            this.Path,
            this.Notes});
            this.dgvRoleAccount.Location = new System.Drawing.Point(12, 59);
            this.dgvRoleAccount.Name = "dgvRoleAccount";
            this.dgvRoleAccount.RowHeadersWidth = 51;
            this.dgvRoleAccount.RowTemplate.Height = 24;
            this.dgvRoleAccount.Size = new System.Drawing.Size(1084, 338);
            this.dgvRoleAccount.TabIndex = 1;
            this.dgvRoleAccount.Click += new System.EventHandler(this.dgvRoleAccount_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(333, 22);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 32);
            this.btnAdd.TabIndex = 2;
            this.btnAdd.Text = "Thêm";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(414, 23);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(100, 31);
            this.btnUpdate.TabIndex = 2;
            this.btnUpdate.Text = "Cập nhật";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(520, 22);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 31);
            this.btnClose.TabIndex = 2;
            this.btnClose.Text = "Đóng";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // cbbRoleName
            // 
            this.cbbRoleName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbRoleName.FormattingEnabled = true;
            this.cbbRoleName.Location = new System.Drawing.Point(12, 27);
            this.cbbRoleName.Name = "cbbRoleName";
            this.cbbRoleName.Size = new System.Drawing.Size(293, 24);
            this.cbbRoleName.TabIndex = 3;
            // 
            // AccountN
            // 
            this.AccountN.DataPropertyName = "AccountName";
            this.AccountN.HeaderText = "Tên tài khoản";
            this.AccountN.MinimumWidth = 6;
            this.AccountN.Name = "AccountN";
            this.AccountN.Width = 125;
            // 
            // ID
            // 
            this.ID.DataPropertyName = "ID";
            this.ID.HeaderText = "Mã vai trò";
            this.ID.MinimumWidth = 6;
            this.ID.Name = "ID";
            this.ID.Width = 125;
            // 
            // RoleName
            // 
            this.RoleName.DataPropertyName = "RoleName";
            this.RoleName.HeaderText = "Tên vai trò";
            this.RoleName.MinimumWidth = 6;
            this.RoleName.Name = "RoleName";
            this.RoleName.Width = 125;
            // 
            // Path
            // 
            this.Path.DataPropertyName = "Path";
            this.Path.HeaderText = "Đường dẫn";
            this.Path.MinimumWidth = 6;
            this.Path.Name = "Path";
            this.Path.Width = 125;
            // 
            // Notes
            // 
            this.Notes.DataPropertyName = "Notes";
            this.Notes.HeaderText = "Ghi chú";
            this.Notes.MinimumWidth = 6;
            this.Notes.Name = "Notes";
            this.Notes.Width = 125;
            // 
            // RoleAccount
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1108, 409);
            this.Controls.Add(this.cbbRoleName);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.dgvRoleAccount);
            this.Name = "RoleAccount";
            this.Text = "RoleAccount";
            ((System.ComponentModel.ISupportInitialize)(this.dgvRoleAccount)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvRoleAccount;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.ComboBox cbbRoleName;
        private System.Windows.Forms.DataGridViewTextBoxColumn AccountN;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn RoleName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Path;
        private System.Windows.Forms.DataGridViewTextBoxColumn Notes;
    }
}