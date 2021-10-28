namespace GUI.frmAdminUserControls
{
    partial class AccountUC
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.toolTipAccountType = new System.Windows.Forms.ToolTip(this.components);
            this.dtgvAccount = new System.Windows.Forms.DataGridView();
            this.btnSearchAccount = new System.Windows.Forms.Button();
            this.txtSearchAccount = new System.Windows.Forms.TextBox();
            this.btnResetPass = new System.Windows.Forms.Button();
            this.btnDeleteAccount = new System.Windows.Forms.Button();
            this.btnUpdateAccount = new System.Windows.Forms.Button();
            this.btnInsertAccount = new System.Windows.Forms.Button();
            this.btnShowAccount = new System.Windows.Forms.Button();
            this.grpAccount = new System.Windows.Forms.GroupBox();
            this.nudAccountType = new System.Windows.Forms.NumericUpDown();
            this.cboStaffID_Account = new System.Windows.Forms.ComboBox();
            this.txtStaffName_Account = new System.Windows.Forms.TextBox();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.lblStaffName_Account = new System.Windows.Forms.Label();
            this.lblAccountType = new System.Windows.Forms.Label();
            this.lblStaffID_Account = new System.Windows.Forms.Label();
            this.lblUsername = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvAccount)).BeginInit();
            this.grpAccount.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudAccountType)).BeginInit();
            this.SuspendLayout();
            // 
            // dtgvAccount
            // 
            this.dtgvAccount.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvAccount.Location = new System.Drawing.Point(133, 211);
            this.dtgvAccount.Name = "dtgvAccount";
            this.dtgvAccount.Size = new System.Drawing.Size(851, 361);
            this.dtgvAccount.TabIndex = 19;
            // 
            // btnSearchAccount
            // 
            this.btnSearchAccount.Location = new System.Drawing.Point(909, 168);
            this.btnSearchAccount.Name = "btnSearchAccount";
            this.btnSearchAccount.Size = new System.Drawing.Size(75, 37);
            this.btnSearchAccount.TabIndex = 18;
            this.btnSearchAccount.Text = "Tìm";
            this.btnSearchAccount.UseVisualStyleBackColor = true;
            this.btnSearchAccount.Click += new System.EventHandler(this.btnSearchAccount_Click);
            // 
            // txtSearchAccount
            // 
            this.txtSearchAccount.Location = new System.Drawing.Point(786, 173);
            this.txtSearchAccount.Name = "txtSearchAccount";
            this.txtSearchAccount.Size = new System.Drawing.Size(117, 27);
            this.txtSearchAccount.TabIndex = 17;
            this.txtSearchAccount.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtSearchAccount_KeyDown);
            // 
            // btnResetPass
            // 
            this.btnResetPass.Location = new System.Drawing.Point(667, 168);
            this.btnResetPass.Name = "btnResetPass";
            this.btnResetPass.Size = new System.Drawing.Size(75, 37);
            this.btnResetPass.TabIndex = 16;
            this.btnResetPass.Text = "Reset";
            this.btnResetPass.UseVisualStyleBackColor = true;
            this.btnResetPass.Click += new System.EventHandler(this.btnResetPass_Click);
            // 
            // btnDeleteAccount
            // 
            this.btnDeleteAccount.Location = new System.Drawing.Point(565, 168);
            this.btnDeleteAccount.Name = "btnDeleteAccount";
            this.btnDeleteAccount.Size = new System.Drawing.Size(75, 37);
            this.btnDeleteAccount.TabIndex = 15;
            this.btnDeleteAccount.Text = "Xoá";
            this.btnDeleteAccount.UseVisualStyleBackColor = true;
            this.btnDeleteAccount.CausesValidationChanged += new System.EventHandler(this.btnDeleteAccount_Click);
            // 
            // btnUpdateAccount
            // 
            this.btnUpdateAccount.Location = new System.Drawing.Point(467, 168);
            this.btnUpdateAccount.Name = "btnUpdateAccount";
            this.btnUpdateAccount.Size = new System.Drawing.Size(75, 37);
            this.btnUpdateAccount.TabIndex = 14;
            this.btnUpdateAccount.Text = "Sửa";
            this.btnUpdateAccount.UseVisualStyleBackColor = true;
            this.btnUpdateAccount.Click += new System.EventHandler(this.btnUpdateAccount_Click);
            // 
            // btnInsertAccount
            // 
            this.btnInsertAccount.Location = new System.Drawing.Point(370, 168);
            this.btnInsertAccount.Name = "btnInsertAccount";
            this.btnInsertAccount.Size = new System.Drawing.Size(75, 37);
            this.btnInsertAccount.TabIndex = 13;
            this.btnInsertAccount.Text = "Thêm";
            this.btnInsertAccount.UseVisualStyleBackColor = true;
            this.btnInsertAccount.Click += new System.EventHandler(this.btnInsertAccount_Click);
            // 
            // btnShowAccount
            // 
            this.btnShowAccount.Location = new System.Drawing.Point(133, 168);
            this.btnShowAccount.Name = "btnShowAccount";
            this.btnShowAccount.Size = new System.Drawing.Size(75, 37);
            this.btnShowAccount.TabIndex = 12;
            this.btnShowAccount.Text = "Xem";
            this.btnShowAccount.UseVisualStyleBackColor = true;
            this.btnShowAccount.Click += new System.EventHandler(this.btnShowAccount_Click);
            // 
            // grpAccount
            // 
            this.grpAccount.Controls.Add(this.nudAccountType);
            this.grpAccount.Controls.Add(this.cboStaffID_Account);
            this.grpAccount.Controls.Add(this.txtStaffName_Account);
            this.grpAccount.Controls.Add(this.txtUsername);
            this.grpAccount.Controls.Add(this.lblStaffName_Account);
            this.grpAccount.Controls.Add(this.lblAccountType);
            this.grpAccount.Controls.Add(this.lblStaffID_Account);
            this.grpAccount.Controls.Add(this.lblUsername);
            this.grpAccount.Location = new System.Drawing.Point(133, 6);
            this.grpAccount.Name = "grpAccount";
            this.grpAccount.Size = new System.Drawing.Size(609, 156);
            this.grpAccount.TabIndex = 11;
            this.grpAccount.TabStop = false;
            this.grpAccount.Text = "Thông tin tài khoản:";
            // 
            // nudAccountType
            // 
            this.nudAccountType.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudAccountType.Location = new System.Drawing.Point(463, 38);
            this.nudAccountType.Margin = new System.Windows.Forms.Padding(2);
            this.nudAccountType.Maximum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.nudAccountType.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudAccountType.Name = "nudAccountType";
            this.nudAccountType.Size = new System.Drawing.Size(117, 26);
            this.nudAccountType.TabIndex = 10;
            this.nudAccountType.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // cboStaffID_Account
            // 
            this.cboStaffID_Account.FormattingEnabled = true;
            this.cboStaffID_Account.Location = new System.Drawing.Point(160, 97);
            this.cboStaffID_Account.Name = "cboStaffID_Account";
            this.cboStaffID_Account.Size = new System.Drawing.Size(121, 28);
            this.cboStaffID_Account.TabIndex = 8;
            this.cboStaffID_Account.SelectedIndexChanged += new System.EventHandler(this.cboStaffID_Account_SelectedIndexChanged);
            // 
            // txtStaffName_Account
            // 
            this.txtStaffName_Account.Location = new System.Drawing.Point(463, 98);
            this.txtStaffName_Account.Name = "txtStaffName_Account";
            this.txtStaffName_Account.ReadOnly = true;
            this.txtStaffName_Account.Size = new System.Drawing.Size(117, 27);
            this.txtStaffName_Account.TabIndex = 7;
            // 
            // txtUsername
            // 
            this.txtUsername.Location = new System.Drawing.Point(163, 38);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(118, 27);
            this.txtUsername.TabIndex = 4;
            this.txtUsername.TextChanged += new System.EventHandler(this.txtUsername_TextChanged);
            // 
            // lblStaffName_Account
            // 
            this.lblStaffName_Account.AutoSize = true;
            this.lblStaffName_Account.Location = new System.Drawing.Point(339, 101);
            this.lblStaffName_Account.Name = "lblStaffName_Account";
            this.lblStaffName_Account.Size = new System.Drawing.Size(70, 20);
            this.lblStaffName_Account.TabIndex = 3;
            this.lblStaffName_Account.Text = "Tên NV:";
            // 
            // lblAccountType
            // 
            this.lblAccountType.AutoSize = true;
            this.lblAccountType.Location = new System.Drawing.Point(339, 41);
            this.lblAccountType.Name = "lblAccountType";
            this.lblAccountType.Size = new System.Drawing.Size(118, 20);
            this.lblAccountType.TabIndex = 2;
            this.lblAccountType.Text = "Loại tài khoản:";
            // 
            // lblStaffID_Account
            // 
            this.lblStaffID_Account.AutoSize = true;
            this.lblStaffID_Account.Location = new System.Drawing.Point(43, 101);
            this.lblStaffID_Account.Name = "lblStaffID_Account";
            this.lblStaffID_Account.Size = new System.Drawing.Size(65, 20);
            this.lblStaffID_Account.TabIndex = 1;
            this.lblStaffID_Account.Text = "Mã NV:";
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.Location = new System.Drawing.Point(43, 41);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(114, 20);
            this.lblUsername.TabIndex = 0;
            this.lblUsername.Text = "Tên tài khoản:";
            // 
            // AccountUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dtgvAccount);
            this.Controls.Add(this.btnSearchAccount);
            this.Controls.Add(this.txtSearchAccount);
            this.Controls.Add(this.btnResetPass);
            this.Controls.Add(this.btnDeleteAccount);
            this.Controls.Add(this.btnUpdateAccount);
            this.Controls.Add(this.btnInsertAccount);
            this.Controls.Add(this.btnShowAccount);
            this.Controls.Add(this.grpAccount);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "AccountUC";
            this.Size = new System.Drawing.Size(1086, 614);
            this.Load += new System.EventHandler(this.AccountUC_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvAccount)).EndInit();
            this.grpAccount.ResumeLayout(false);
            this.grpAccount.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudAccountType)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ToolTip toolTipAccountType;
        private System.Windows.Forms.DataGridView dtgvAccount;
        private System.Windows.Forms.Button btnSearchAccount;
        private System.Windows.Forms.TextBox txtSearchAccount;
        private System.Windows.Forms.Button btnResetPass;
        private System.Windows.Forms.Button btnDeleteAccount;
        private System.Windows.Forms.Button btnUpdateAccount;
        private System.Windows.Forms.Button btnInsertAccount;
        private System.Windows.Forms.Button btnShowAccount;
        private System.Windows.Forms.GroupBox grpAccount;
        private System.Windows.Forms.NumericUpDown nudAccountType;
        private System.Windows.Forms.ComboBox cboStaffID_Account;
        private System.Windows.Forms.TextBox txtStaffName_Account;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.Label lblStaffName_Account;
        private System.Windows.Forms.Label lblAccountType;
        private System.Windows.Forms.Label lblStaffID_Account;
        private System.Windows.Forms.Label lblUsername;
    }
}
