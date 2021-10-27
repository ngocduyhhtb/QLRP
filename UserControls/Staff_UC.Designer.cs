
namespace QuanLyRapPhim.UserControls
{
    partial class Staff_UC
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
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.lbStaffID = new System.Windows.Forms.Label();
            this.lbStaffName = new System.Windows.Forms.Label();
            this.lblStaffDate = new System.Windows.Forms.Label();
            this.lblAddress = new System.Windows.Forms.Label();
            this.lblPhoneNumber = new System.Windows.Forms.Label();
            this.lblIdentìy = new System.Windows.Forms.Label();
            this.btnShow = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.maskedTextBox6 = new System.Windows.Forms.MaskedTextBox();
            this.dtgvStaff = new System.Windows.Forms.DataGridView();
            this.txbStaffId = new System.Windows.Forms.TextBox();
            this.txbName = new System.Windows.Forms.TextBox();
            this.txbDate = new System.Windows.Forms.TextBox();
            this.txbIdentify = new System.Windows.Forms.TextBox();
            this.txbPhonenNumber = new System.Windows.Forms.TextBox();
            this.txbAddress = new System.Windows.Forms.TextBox();
            this.grbInformation.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvStaff)).BeginInit();
            this.SuspendLayout();
            // 
            // grbInformation
            // 
            this.grbInformation.Controls.Add(this.txbIdentify);
            this.grbInformation.Controls.Add(this.txbPhonenNumber);
            this.grbInformation.Controls.Add(this.txbAddress);
            this.grbInformation.Controls.Add(this.txbDate);
            this.grbInformation.Controls.Add(this.txbName);
            this.grbInformation.Controls.Add(this.txbStaffId);
            this.grbInformation.Controls.Add(this.lblIdentìy);
            this.grbInformation.Controls.Add(this.lblPhoneNumber);
            this.grbInformation.Controls.Add(this.lblAddress);
            this.grbInformation.Controls.Add(this.lblStaffDate);
            this.grbInformation.Controls.Add(this.lbStaffName);
            this.grbInformation.Controls.Add(this.lbStaffID);
            this.grbInformation.Location = new System.Drawing.Point(115, 6);
            this.grbInformation.Name = "grbInformation";
            this.grbInformation.Size = new System.Drawing.Size(554, 143);
            this.grbInformation.TabIndex = 0;
            this.grbInformation.TabStop = false;
            this.grbInformation.Text = "Thông tin nhân viên:";
            // 
            // lbStaffID
            // 
            this.lbStaffID.AutoSize = true;
            this.lbStaffID.Location = new System.Drawing.Point(41, 36);
            this.lbStaffID.Name = "lbStaffID";
            this.lbStaffID.Size = new System.Drawing.Size(65, 20);
            this.lbStaffID.TabIndex = 0;
            this.lbStaffID.Text = "Mã NV:";
            // 
            // lbStaffName
            // 
            this.lbStaffName.AutoSize = true;
            this.lbStaffName.Location = new System.Drawing.Point(41, 68);
            this.lbStaffName.Name = "lbStaffName";
            this.lbStaffName.Size = new System.Drawing.Size(64, 20);
            this.lbStaffName.TabIndex = 1;
            this.lbStaffName.Text = "Họ tên:";
            // 
            // lblStaffDate
            // 
            this.lblStaffDate.AutoSize = true;
            this.lblStaffDate.Location = new System.Drawing.Point(41, 100);
            this.lblStaffDate.Name = "lblStaffDate";
            this.lblStaffDate.Size = new System.Drawing.Size(88, 20);
            this.lblStaffDate.TabIndex = 2;
            this.lblStaffDate.Text = "Ngày sinh:";
            // 
            // lblAddress
            // 
            this.lblAddress.AutoSize = true;
            this.lblAddress.Location = new System.Drawing.Point(299, 36);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(66, 20);
            this.lblAddress.TabIndex = 3;
            this.lblAddress.Text = "Địa chỉ:";
            // 
            // lblPhoneNumber
            // 
            this.lblPhoneNumber.AutoSize = true;
            this.lblPhoneNumber.Location = new System.Drawing.Point(299, 68);
            this.lblPhoneNumber.Name = "lblPhoneNumber";
            this.lblPhoneNumber.Size = new System.Drawing.Size(61, 20);
            this.lblPhoneNumber.TabIndex = 4;
            this.lblPhoneNumber.Text = "Số ĐT:";
            // 
            // lblIdentìy
            // 
            this.lblIdentìy.AutoSize = true;
            this.lblIdentìy.Location = new System.Drawing.Point(299, 100);
            this.lblIdentìy.Name = "lblIdentìy";
            this.lblIdentìy.Size = new System.Drawing.Size(88, 20);
            this.lblIdentìy.TabIndex = 5;
            this.lblIdentìy.Text = "Số CCCD:";
            // 
            // btnShow
            // 
            this.btnShow.Location = new System.Drawing.Point(115, 155);
            this.btnShow.Name = "btnShow";
            this.btnShow.Size = new System.Drawing.Size(83, 34);
            this.btnShow.TabIndex = 1;
            this.btnShow.Text = "Xem";
            this.btnShow.UseVisualStyleBackColor = true;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(379, 155);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(83, 34);
            this.btnAdd.TabIndex = 2;
            this.btnAdd.Text = "Thêm";
            this.btnAdd.UseVisualStyleBackColor = true;
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(484, 155);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(83, 34);
            this.btnEdit.TabIndex = 3;
            this.btnEdit.Text = "Sửa";
            this.btnEdit.UseVisualStyleBackColor = true;
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(586, 155);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(83, 34);
            this.btnDelete.TabIndex = 4;
            this.btnDelete.Text = "Xoá";
            this.btnDelete.UseVisualStyleBackColor = true;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(910, 155);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(83, 34);
            this.btnSearch.TabIndex = 5;
            this.btnSearch.Text = "Tìm";
            this.btnSearch.UseVisualStyleBackColor = true;
            // 
            // maskedTextBox6
            // 
            this.maskedTextBox6.Location = new System.Drawing.Point(760, 160);
            this.maskedTextBox6.Name = "maskedTextBox6";
            this.maskedTextBox6.Size = new System.Drawing.Size(143, 27);
            this.maskedTextBox6.TabIndex = 12;
            // 
            // dtgvStaff
            // 
            this.dtgvStaff.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvStaff.Location = new System.Drawing.Point(115, 195);
            this.dtgvStaff.Name = "dtgvStaff";
            this.dtgvStaff.Size = new System.Drawing.Size(878, 366);
            this.dtgvStaff.TabIndex = 13;
            // 
            // txbStaffId
            // 
            this.txbStaffId.Location = new System.Drawing.Point(136, 33);
            this.txbStaffId.Name = "txbStaffId";
            this.txbStaffId.Size = new System.Drawing.Size(140, 27);
            this.txbStaffId.TabIndex = 12;
            // 
            // txbName
            // 
            this.txbName.Location = new System.Drawing.Point(136, 65);
            this.txbName.Name = "txbName";
            this.txbName.Size = new System.Drawing.Size(140, 27);
            this.txbName.TabIndex = 13;
            // 
            // txbDate
            // 
            this.txbDate.Location = new System.Drawing.Point(136, 97);
            this.txbDate.Name = "txbDate";
            this.txbDate.Size = new System.Drawing.Size(140, 27);
            this.txbDate.TabIndex = 14;
            // 
            // txbIdentify
            // 
            this.txbIdentify.Location = new System.Drawing.Point(392, 97);
            this.txbIdentify.Name = "txbIdentify";
            this.txbIdentify.Size = new System.Drawing.Size(140, 27);
            this.txbIdentify.TabIndex = 17;
            // 
            // txbPhonenNumber
            // 
            this.txbPhonenNumber.Location = new System.Drawing.Point(392, 65);
            this.txbPhonenNumber.Name = "txbPhonenNumber";
            this.txbPhonenNumber.Size = new System.Drawing.Size(140, 27);
            this.txbPhonenNumber.TabIndex = 16;
            // 
            // txbAddress
            // 
            this.txbAddress.Location = new System.Drawing.Point(392, 33);
            this.txbAddress.Name = "txbAddress";
            this.txbAddress.Size = new System.Drawing.Size(140, 27);
            this.txbAddress.TabIndex = 15;
            // 
            // Staff_UC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dtgvStaff);
            this.Controls.Add(this.maskedTextBox6);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnShow);
            this.Controls.Add(this.grbInformation);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Staff_UC";
            this.Size = new System.Drawing.Size(1086, 614);
            this.grbInformation.ResumeLayout(false);
            this.grbInformation.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvStaff)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grbInformation;
        private System.Windows.Forms.Label lblIdentìy;
        private System.Windows.Forms.Label lblPhoneNumber;
        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.Label lblStaffDate;
        private System.Windows.Forms.Label lbStaffName;
        private System.Windows.Forms.Label lbStaffID;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Button btnShow;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.MaskedTextBox maskedTextBox6;
        private System.Windows.Forms.DataGridView dtgvStaff;
        private System.Windows.Forms.TextBox txbIdentify;
        private System.Windows.Forms.TextBox txbPhonenNumber;
        private System.Windows.Forms.TextBox txbAddress;
        private System.Windows.Forms.TextBox txbDate;
        private System.Windows.Forms.TextBox txbName;
        private System.Windows.Forms.TextBox txbStaffId;
    }
}
