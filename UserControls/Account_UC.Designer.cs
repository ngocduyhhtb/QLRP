
namespace QuanLyRapPhim.UserControls
{
    partial class Account_UC
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
            this.grbInformation = new System.Windows.Forms.GroupBox();
            this.lblUserName = new System.Windows.Forms.Label();
            this.lblStaffId = new System.Windows.Forms.Label();
            this.lblAccountType = new System.Windows.Forms.Label();
            this.lblCustomerName = new System.Windows.Forms.Label();
            this.txbUserName = new System.Windows.Forms.TextBox();
            this.txbCustomerID = new System.Windows.Forms.TextBox();
            this.txbAccountType = new System.Windows.Forms.TextBox();
            this.txbCustomerName = new System.Windows.Forms.TextBox();
            this.btnShow = new System.Windows.Forms.Button();
            this.btnAAccountAdd = new System.Windows.Forms.Button();
            this.btnAccountEdit = new System.Windows.Forms.Button();
            this.btnAccountDelete = new System.Windows.Forms.Button();
            this.btnAccountReset = new System.Windows.Forms.Button();
            this.txbAccountSearch = new System.Windows.Forms.TextBox();
            this.btnAccountSearch = new System.Windows.Forms.Button();
            this.dtgvAccount = new System.Windows.Forms.DataGridView();
            this.grbInformation.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvAccount)).BeginInit();
            this.SuspendLayout();
            // 
            // grbInformation
            // 
            this.grbInformation.Controls.Add(this.txbCustomerName);
            this.grbInformation.Controls.Add(this.txbAccountType);
            this.grbInformation.Controls.Add(this.txbCustomerID);
            this.grbInformation.Controls.Add(this.txbUserName);
            this.grbInformation.Controls.Add(this.lblCustomerName);
            this.grbInformation.Controls.Add(this.lblAccountType);
            this.grbInformation.Controls.Add(this.lblStaffId);
            this.grbInformation.Controls.Add(this.lblUserName);
            this.grbInformation.Location = new System.Drawing.Point(129, 7);
            this.grbInformation.Name = "grbInformation";
            this.grbInformation.Size = new System.Drawing.Size(609, 156);
            this.grbInformation.TabIndex = 0;
            this.grbInformation.TabStop = false;
            this.grbInformation.Text = "Thông tin tài khoản:";
            // 
            // lblUserName
            // 
            this.lblUserName.AutoSize = true;
            this.lblUserName.Location = new System.Drawing.Point(43, 41);
            this.lblUserName.Name = "lblUserName";
            this.lblUserName.Size = new System.Drawing.Size(114, 20);
            this.lblUserName.TabIndex = 0;
            this.lblUserName.Text = "Tên tài khoản:";
            // 
            // lblStaffId
            // 
            this.lblStaffId.AutoSize = true;
            this.lblStaffId.Location = new System.Drawing.Point(43, 101);
            this.lblStaffId.Name = "lblStaffId";
            this.lblStaffId.Size = new System.Drawing.Size(65, 20);
            this.lblStaffId.TabIndex = 1;
            this.lblStaffId.Text = "Mã NV:";
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
            // lblCustomerName
            // 
            this.lblCustomerName.AutoSize = true;
            this.lblCustomerName.Location = new System.Drawing.Point(339, 101);
            this.lblCustomerName.Name = "lblCustomerName";
            this.lblCustomerName.Size = new System.Drawing.Size(70, 20);
            this.lblCustomerName.TabIndex = 3;
            this.lblCustomerName.Text = "Tên NV:";
            // 
            // txbUserName
            // 
            this.txbUserName.Location = new System.Drawing.Point(163, 38);
            this.txbUserName.Name = "txbUserName";
            this.txbUserName.Size = new System.Drawing.Size(118, 27);
            this.txbUserName.TabIndex = 4;
            // 
            // txbCustomerID
            // 
            this.txbCustomerID.Location = new System.Drawing.Point(163, 98);
            this.txbCustomerID.Name = "txbCustomerID";
            this.txbCustomerID.Size = new System.Drawing.Size(118, 27);
            this.txbCustomerID.TabIndex = 5;
            // 
            // txbAccountType
            // 
            this.txbAccountType.Location = new System.Drawing.Point(463, 38);
            this.txbAccountType.Name = "txbAccountType";
            this.txbAccountType.Size = new System.Drawing.Size(117, 27);
            this.txbAccountType.TabIndex = 6;
            // 
            // txbCustomerName
            // 
            this.txbCustomerName.Location = new System.Drawing.Point(463, 98);
            this.txbCustomerName.Name = "txbCustomerName";
            this.txbCustomerName.Size = new System.Drawing.Size(117, 27);
            this.txbCustomerName.TabIndex = 7;
            // 
            // btnShow
            // 
            this.btnShow.Location = new System.Drawing.Point(129, 169);
            this.btnShow.Name = "btnShow";
            this.btnShow.Size = new System.Drawing.Size(75, 37);
            this.btnShow.TabIndex = 1;
            this.btnShow.Text = "Xem";
            this.btnShow.UseVisualStyleBackColor = true;
            // 
            // btnAAccountAdd
            // 
            this.btnAAccountAdd.Location = new System.Drawing.Point(366, 169);
            this.btnAAccountAdd.Name = "btnAAccountAdd";
            this.btnAAccountAdd.Size = new System.Drawing.Size(75, 37);
            this.btnAAccountAdd.TabIndex = 2;
            this.btnAAccountAdd.Text = "Thêm";
            this.btnAAccountAdd.UseVisualStyleBackColor = true;
            // 
            // btnAccountEdit
            // 
            this.btnAccountEdit.Location = new System.Drawing.Point(463, 169);
            this.btnAccountEdit.Name = "btnAccountEdit";
            this.btnAccountEdit.Size = new System.Drawing.Size(75, 37);
            this.btnAccountEdit.TabIndex = 3;
            this.btnAccountEdit.Text = "Sửa";
            this.btnAccountEdit.UseVisualStyleBackColor = true;
            // 
            // btnAccountDelete
            // 
            this.btnAccountDelete.Location = new System.Drawing.Point(561, 169);
            this.btnAccountDelete.Name = "btnAccountDelete";
            this.btnAccountDelete.Size = new System.Drawing.Size(75, 37);
            this.btnAccountDelete.TabIndex = 4;
            this.btnAccountDelete.Text = "Xoá";
            this.btnAccountDelete.UseVisualStyleBackColor = true;
            // 
            // btnAccountReset
            // 
            this.btnAccountReset.Location = new System.Drawing.Point(663, 169);
            this.btnAccountReset.Name = "btnAccountReset";
            this.btnAccountReset.Size = new System.Drawing.Size(75, 37);
            this.btnAccountReset.TabIndex = 5;
            this.btnAccountReset.Text = "Reset";
            this.btnAccountReset.UseVisualStyleBackColor = true;
            // 
            // txbAccountSearch
            // 
            this.txbAccountSearch.Location = new System.Drawing.Point(782, 174);
            this.txbAccountSearch.Name = "txbAccountSearch";
            this.txbAccountSearch.Size = new System.Drawing.Size(117, 27);
            this.txbAccountSearch.TabIndex = 8;
            // 
            // btnAccountSearch
            // 
            this.btnAccountSearch.Location = new System.Drawing.Point(905, 169);
            this.btnAccountSearch.Name = "btnAccountSearch";
            this.btnAccountSearch.Size = new System.Drawing.Size(75, 37);
            this.btnAccountSearch.TabIndex = 9;
            this.btnAccountSearch.Text = "Tìm";
            this.btnAccountSearch.UseVisualStyleBackColor = true;
            // 
            // dtgvAccount
            // 
            this.dtgvAccount.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvAccount.Location = new System.Drawing.Point(129, 212);
            this.dtgvAccount.Name = "dtgvAccount";
            this.dtgvAccount.Size = new System.Drawing.Size(851, 361);
            this.dtgvAccount.TabIndex = 10;
            // 
            // Account_UC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dtgvAccount);
            this.Controls.Add(this.btnAccountSearch);
            this.Controls.Add(this.txbAccountSearch);
            this.Controls.Add(this.btnAccountReset);
            this.Controls.Add(this.btnAccountDelete);
            this.Controls.Add(this.btnAccountEdit);
            this.Controls.Add(this.btnAAccountAdd);
            this.Controls.Add(this.btnShow);
            this.Controls.Add(this.grbInformation);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.Name = "Account_UC";
            this.Size = new System.Drawing.Size(1086, 614);
            this.grbInformation.ResumeLayout(false);
            this.grbInformation.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvAccount)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grbInformation;
        private System.Windows.Forms.TextBox txbCustomerName;
        private System.Windows.Forms.TextBox txbAccountType;
        private System.Windows.Forms.TextBox txbCustomerID;
        private System.Windows.Forms.TextBox txbUserName;
        private System.Windows.Forms.Label lblCustomerName;
        private System.Windows.Forms.Label lblAccountType;
        private System.Windows.Forms.Label lblStaffId;
        private System.Windows.Forms.Label lblUserName;
        private System.Windows.Forms.Button btnShow;
        private System.Windows.Forms.Button btnAAccountAdd;
        private System.Windows.Forms.Button btnAccountEdit;
        private System.Windows.Forms.Button btnAccountDelete;
        private System.Windows.Forms.Button btnAccountReset;
        private System.Windows.Forms.TextBox txbAccountSearch;
        private System.Windows.Forms.Button btnAccountSearch;
        private System.Windows.Forms.DataGridView dtgvAccount;
    }
}
