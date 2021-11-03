
namespace Lab06_Basic_Command
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
            this.RoleID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AccountName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Actived = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Notes = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRoleAccount)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvRoleAccount
            // 
            this.dgvRoleAccount.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRoleAccount.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.RoleID,
            this.AccountName,
            this.Actived,
            this.Notes});
            this.dgvRoleAccount.Location = new System.Drawing.Point(12, 12);
            this.dgvRoleAccount.Name = "dgvRoleAccount";
            this.dgvRoleAccount.RowHeadersWidth = 51;
            this.dgvRoleAccount.RowTemplate.Height = 24;
            this.dgvRoleAccount.Size = new System.Drawing.Size(776, 426);
            this.dgvRoleAccount.TabIndex = 0;
            // 
            // RoleID
            // 
            this.RoleID.DataPropertyName = "RoleID";
            this.RoleID.HeaderText = "Mã vai trò";
            this.RoleID.MinimumWidth = 6;
            this.RoleID.Name = "RoleID";
            this.RoleID.Width = 125;
            // 
            // AccountName
            // 
            this.AccountName.DataPropertyName = "AccountName";
            this.AccountName.HeaderText = "Tên tài khoản";
            this.AccountName.MinimumWidth = 6;
            this.AccountName.Name = "AccountName";
            this.AccountName.Width = 125;
            // 
            // Actived
            // 
            this.Actived.DataPropertyName = "Actived";
            this.Actived.HeaderText = "Đã kích hoạt";
            this.Actived.MinimumWidth = 6;
            this.Actived.Name = "Actived";
            this.Actived.Width = 125;
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
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dgvRoleAccount);
            this.Name = "RoleAccount";
            this.Text = "RoleAccount";
            ((System.ComponentModel.ISupportInitialize)(this.dgvRoleAccount)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvRoleAccount;
        private System.Windows.Forms.DataGridViewTextBoxColumn RoleID;
        private System.Windows.Forms.DataGridViewTextBoxColumn AccountName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Actived;
        private System.Windows.Forms.DataGridViewTextBoxColumn Notes;
    }
}