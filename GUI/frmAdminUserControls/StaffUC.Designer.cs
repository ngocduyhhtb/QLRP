namespace GUI.frmAdminUserControls
{
    partial class StaffUC
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
            this.txtSearchStaff = new System.Windows.Forms.TextBox();
            this.dtgvStaff = new System.Windows.Forms.DataGridView();
            this.btnSearchStaff = new System.Windows.Forms.Button();
            this.btnDeleteStaff = new System.Windows.Forms.Button();
            this.btnUpdateStaff = new System.Windows.Forms.Button();
            this.btnAddStaff = new System.Windows.Forms.Button();
            this.btnShowStaff = new System.Windows.Forms.Button();
            this.grpStaff = new System.Windows.Forms.GroupBox();
            this.txtStaffINumber = new System.Windows.Forms.TextBox();
            this.txtStaffPhone = new System.Windows.Forms.TextBox();
            this.txtStaffAddress = new System.Windows.Forms.TextBox();
            this.txtStaffBirth = new System.Windows.Forms.TextBox();
            this.txtStaffName = new System.Windows.Forms.TextBox();
            this.txtStaffId = new System.Windows.Forms.TextBox();
            this.lblStaffINumber = new System.Windows.Forms.Label();
            this.lblStaffPhone = new System.Windows.Forms.Label();
            this.lblStaffAddress = new System.Windows.Forms.Label();
            this.lblStaffBirth = new System.Windows.Forms.Label();
            this.lblStaffName = new System.Windows.Forms.Label();
            this.lblStaffID = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvStaff)).BeginInit();
            this.grpStaff.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtSearchStaff
            // 
            this.txtSearchStaff.Location = new System.Drawing.Point(781, 158);
            this.txtSearchStaff.Name = "txtSearchStaff";
            this.txtSearchStaff.Size = new System.Drawing.Size(139, 27);
            this.txtSearchStaff.TabIndex = 22;
            // 
            // dtgvStaff
            // 
            this.dtgvStaff.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvStaff.Location = new System.Drawing.Point(131, 194);
            this.dtgvStaff.Name = "dtgvStaff";
            this.dtgvStaff.Size = new System.Drawing.Size(878, 366);
            this.dtgvStaff.TabIndex = 21;
            // 
            // btnSearchStaff
            // 
            this.btnSearchStaff.Location = new System.Drawing.Point(926, 154);
            this.btnSearchStaff.Name = "btnSearchStaff";
            this.btnSearchStaff.Size = new System.Drawing.Size(83, 34);
            this.btnSearchStaff.TabIndex = 20;
            this.btnSearchStaff.Text = "Tìm";
            this.btnSearchStaff.UseVisualStyleBackColor = true;
            // 
            // btnDeleteStaff
            // 
            this.btnDeleteStaff.Location = new System.Drawing.Point(602, 154);
            this.btnDeleteStaff.Name = "btnDeleteStaff";
            this.btnDeleteStaff.Size = new System.Drawing.Size(83, 34);
            this.btnDeleteStaff.TabIndex = 19;
            this.btnDeleteStaff.Text = "Xoá";
            this.btnDeleteStaff.UseVisualStyleBackColor = true;
            // 
            // btnUpdateStaff
            // 
            this.btnUpdateStaff.Location = new System.Drawing.Point(500, 154);
            this.btnUpdateStaff.Name = "btnUpdateStaff";
            this.btnUpdateStaff.Size = new System.Drawing.Size(83, 34);
            this.btnUpdateStaff.TabIndex = 18;
            this.btnUpdateStaff.Text = "Sửa";
            this.btnUpdateStaff.UseVisualStyleBackColor = true;
            // 
            // btnAddStaff
            // 
            this.btnAddStaff.Location = new System.Drawing.Point(395, 154);
            this.btnAddStaff.Name = "btnAddStaff";
            this.btnAddStaff.Size = new System.Drawing.Size(83, 34);
            this.btnAddStaff.TabIndex = 17;
            this.btnAddStaff.Text = "Thêm";
            this.btnAddStaff.UseVisualStyleBackColor = true;
            // 
            // btnShowStaff
            // 
            this.btnShowStaff.Location = new System.Drawing.Point(131, 154);
            this.btnShowStaff.Name = "btnShowStaff";
            this.btnShowStaff.Size = new System.Drawing.Size(83, 34);
            this.btnShowStaff.TabIndex = 16;
            this.btnShowStaff.Text = "Xem";
            this.btnShowStaff.UseVisualStyleBackColor = true;
            // 
            // grpStaff
            // 
            this.grpStaff.Controls.Add(this.txtStaffINumber);
            this.grpStaff.Controls.Add(this.txtStaffPhone);
            this.grpStaff.Controls.Add(this.txtStaffAddress);
            this.grpStaff.Controls.Add(this.txtStaffBirth);
            this.grpStaff.Controls.Add(this.txtStaffName);
            this.grpStaff.Controls.Add(this.txtStaffId);
            this.grpStaff.Controls.Add(this.lblStaffINumber);
            this.grpStaff.Controls.Add(this.lblStaffPhone);
            this.grpStaff.Controls.Add(this.lblStaffAddress);
            this.grpStaff.Controls.Add(this.lblStaffBirth);
            this.grpStaff.Controls.Add(this.lblStaffName);
            this.grpStaff.Controls.Add(this.lblStaffID);
            this.grpStaff.Location = new System.Drawing.Point(131, 5);
            this.grpStaff.Name = "grpStaff";
            this.grpStaff.Size = new System.Drawing.Size(554, 143);
            this.grpStaff.TabIndex = 15;
            this.grpStaff.TabStop = false;
            this.grpStaff.Text = "Thông tin nhân viên:";
            // 
            // txtStaffINumber
            // 
            this.txtStaffINumber.Location = new System.Drawing.Point(392, 97);
            this.txtStaffINumber.Name = "txtStaffINumber";
            this.txtStaffINumber.Size = new System.Drawing.Size(140, 27);
            this.txtStaffINumber.TabIndex = 17;
            // 
            // txtStaffPhone
            // 
            this.txtStaffPhone.Location = new System.Drawing.Point(392, 65);
            this.txtStaffPhone.Name = "txtStaffPhone";
            this.txtStaffPhone.Size = new System.Drawing.Size(140, 27);
            this.txtStaffPhone.TabIndex = 16;
            // 
            // txtStaffAddress
            // 
            this.txtStaffAddress.Location = new System.Drawing.Point(392, 33);
            this.txtStaffAddress.Name = "txtStaffAddress";
            this.txtStaffAddress.Size = new System.Drawing.Size(140, 27);
            this.txtStaffAddress.TabIndex = 15;
            // 
            // txtStaffBirth
            // 
            this.txtStaffBirth.Location = new System.Drawing.Point(136, 97);
            this.txtStaffBirth.Name = "txtStaffBirth";
            this.txtStaffBirth.Size = new System.Drawing.Size(140, 27);
            this.txtStaffBirth.TabIndex = 14;
            // 
            // txtStaffName
            // 
            this.txtStaffName.Location = new System.Drawing.Point(136, 65);
            this.txtStaffName.Name = "txtStaffName";
            this.txtStaffName.Size = new System.Drawing.Size(140, 27);
            this.txtStaffName.TabIndex = 13;
            // 
            // txtStaffId
            // 
            this.txtStaffId.Location = new System.Drawing.Point(136, 33);
            this.txtStaffId.Name = "txtStaffId";
            this.txtStaffId.Size = new System.Drawing.Size(140, 27);
            this.txtStaffId.TabIndex = 12;
            // 
            // lblStaffINumber
            // 
            this.lblStaffINumber.AutoSize = true;
            this.lblStaffINumber.Location = new System.Drawing.Point(299, 100);
            this.lblStaffINumber.Name = "lblStaffINumber";
            this.lblStaffINumber.Size = new System.Drawing.Size(88, 20);
            this.lblStaffINumber.TabIndex = 5;
            this.lblStaffINumber.Text = "Số CCCD:";
            // 
            // lblStaffPhone
            // 
            this.lblStaffPhone.AutoSize = true;
            this.lblStaffPhone.Location = new System.Drawing.Point(299, 68);
            this.lblStaffPhone.Name = "lblStaffPhone";
            this.lblStaffPhone.Size = new System.Drawing.Size(61, 20);
            this.lblStaffPhone.TabIndex = 4;
            this.lblStaffPhone.Text = "Số ĐT:";
            // 
            // lblStaffAddress
            // 
            this.lblStaffAddress.AutoSize = true;
            this.lblStaffAddress.Location = new System.Drawing.Point(299, 36);
            this.lblStaffAddress.Name = "lblStaffAddress";
            this.lblStaffAddress.Size = new System.Drawing.Size(66, 20);
            this.lblStaffAddress.TabIndex = 3;
            this.lblStaffAddress.Text = "Địa chỉ:";
            // 
            // lblStaffBirth
            // 
            this.lblStaffBirth.AutoSize = true;
            this.lblStaffBirth.Location = new System.Drawing.Point(41, 100);
            this.lblStaffBirth.Name = "lblStaffBirth";
            this.lblStaffBirth.Size = new System.Drawing.Size(88, 20);
            this.lblStaffBirth.TabIndex = 2;
            this.lblStaffBirth.Text = "Ngày sinh:";
            // 
            // lblStaffName
            // 
            this.lblStaffName.AutoSize = true;
            this.lblStaffName.Location = new System.Drawing.Point(41, 68);
            this.lblStaffName.Name = "lblStaffName";
            this.lblStaffName.Size = new System.Drawing.Size(64, 20);
            this.lblStaffName.TabIndex = 1;
            this.lblStaffName.Text = "Họ tên:";
            // 
            // lblStaffID
            // 
            this.lblStaffID.AutoSize = true;
            this.lblStaffID.Location = new System.Drawing.Point(41, 36);
            this.lblStaffID.Name = "lblStaffID";
            this.lblStaffID.Size = new System.Drawing.Size(65, 20);
            this.lblStaffID.TabIndex = 0;
            this.lblStaffID.Text = "Mã NV:";
            // 
            // StaffUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.txtSearchStaff);
            this.Controls.Add(this.dtgvStaff);
            this.Controls.Add(this.btnSearchStaff);
            this.Controls.Add(this.btnDeleteStaff);
            this.Controls.Add(this.btnUpdateStaff);
            this.Controls.Add(this.btnAddStaff);
            this.Controls.Add(this.btnShowStaff);
            this.Controls.Add(this.grpStaff);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "StaffUC";
            this.Size = new System.Drawing.Size(1086, 614);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvStaff)).EndInit();
            this.grpStaff.ResumeLayout(false);
            this.grpStaff.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtSearchStaff;
        private System.Windows.Forms.DataGridView dtgvStaff;
        private System.Windows.Forms.Button btnSearchStaff;
        private System.Windows.Forms.Button btnDeleteStaff;
        private System.Windows.Forms.Button btnUpdateStaff;
        private System.Windows.Forms.Button btnAddStaff;
        private System.Windows.Forms.Button btnShowStaff;
        private System.Windows.Forms.GroupBox grpStaff;
        private System.Windows.Forms.TextBox txtStaffINumber;
        private System.Windows.Forms.TextBox txtStaffPhone;
        private System.Windows.Forms.TextBox txtStaffAddress;
        private System.Windows.Forms.TextBox txtStaffBirth;
        private System.Windows.Forms.TextBox txtStaffName;
        private System.Windows.Forms.TextBox txtStaffId;
        private System.Windows.Forms.Label lblStaffINumber;
        private System.Windows.Forms.Label lblStaffPhone;
        private System.Windows.Forms.Label lblStaffAddress;
        private System.Windows.Forms.Label lblStaffBirth;
        private System.Windows.Forms.Label lblStaffName;
        private System.Windows.Forms.Label lblStaffID;
    }
}
