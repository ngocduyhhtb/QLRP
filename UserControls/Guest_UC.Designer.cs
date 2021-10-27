
namespace QuanLyRapPhim.UserControls
{
    partial class Guest_UC
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
            this.grpInformation = new System.Windows.Forms.GroupBox();
            this.txbCCCDNumber = new System.Windows.Forms.TextBox();
            this.txbCustomerNumber = new System.Windows.Forms.TextBox();
            this.txbCustomerAddress = new System.Windows.Forms.TextBox();
            this.txbCustomerDate = new System.Windows.Forms.TextBox();
            this.nmScore = new System.Windows.Forms.NumericUpDown();
            this.lblScore = new System.Windows.Forms.Label();
            this.txbCustomerName = new System.Windows.Forms.TextBox();
            this.lblCustomerAddress = new System.Windows.Forms.Label();
            this.lblCustomerNumber = new System.Windows.Forms.Label();
            this.lblCCCDNumber = new System.Windows.Forms.Label();
            this.txbCustomerID = new System.Windows.Forms.TextBox();
            this.lblCustomerDate = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.lblCustomerID = new System.Windows.Forms.Label();
            this.btnCustomerShow = new System.Windows.Forms.Button();
            this.btnCustomerAdd = new System.Windows.Forms.Button();
            this.btnCustomerEdit = new System.Windows.Forms.Button();
            this.btnCustomerDelete = new System.Windows.Forms.Button();
            this.btnCustomerSearch = new System.Windows.Forms.Button();
            this.dtgvCustomer = new System.Windows.Forms.DataGridView();
            this.txtCustomerSearch = new System.Windows.Forms.TextBox();
            this.grpInformation.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmScore)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvCustomer)).BeginInit();
            this.SuspendLayout();
            // 
            // grpInformation
            // 
            this.grpInformation.Controls.Add(this.txbCCCDNumber);
            this.grpInformation.Controls.Add(this.txbCustomerNumber);
            this.grpInformation.Controls.Add(this.txbCustomerAddress);
            this.grpInformation.Controls.Add(this.txbCustomerDate);
            this.grpInformation.Controls.Add(this.nmScore);
            this.grpInformation.Controls.Add(this.lblScore);
            this.grpInformation.Controls.Add(this.txbCustomerName);
            this.grpInformation.Controls.Add(this.lblCustomerAddress);
            this.grpInformation.Controls.Add(this.lblCustomerNumber);
            this.grpInformation.Controls.Add(this.lblCCCDNumber);
            this.grpInformation.Controls.Add(this.txbCustomerID);
            this.grpInformation.Controls.Add(this.lblCustomerDate);
            this.grpInformation.Controls.Add(this.lblName);
            this.grpInformation.Controls.Add(this.lblCustomerID);
            this.grpInformation.Location = new System.Drawing.Point(118, 4);
            this.grpInformation.Name = "grpInformation";
            this.grpInformation.Size = new System.Drawing.Size(816, 156);
            this.grpInformation.TabIndex = 0;
            this.grpInformation.TabStop = false;
            this.grpInformation.Text = "Thông tin khách hàng";
            // 
            // txbCCCDNumber
            // 
            this.txbCCCDNumber.Location = new System.Drawing.Point(418, 100);
            this.txbCCCDNumber.Name = "txbCCCDNumber";
            this.txbCCCDNumber.Size = new System.Drawing.Size(151, 27);
            this.txbCCCDNumber.TabIndex = 18;
            // 
            // txbCustomerNumber
            // 
            this.txbCustomerNumber.Location = new System.Drawing.Point(418, 67);
            this.txbCustomerNumber.Name = "txbCustomerNumber";
            this.txbCustomerNumber.Size = new System.Drawing.Size(151, 27);
            this.txbCustomerNumber.TabIndex = 17;
            // 
            // txbCustomerAddress
            // 
            this.txbCustomerAddress.Location = new System.Drawing.Point(418, 34);
            this.txbCustomerAddress.Name = "txbCustomerAddress";
            this.txbCustomerAddress.Size = new System.Drawing.Size(151, 27);
            this.txbCustomerAddress.TabIndex = 16;
            // 
            // txbCustomerDate
            // 
            this.txbCustomerDate.Location = new System.Drawing.Point(132, 100);
            this.txbCustomerDate.Name = "txbCustomerDate";
            this.txbCustomerDate.Size = new System.Drawing.Size(151, 27);
            this.txbCustomerDate.TabIndex = 15;
            // 
            // nmScore
            // 
            this.nmScore.Location = new System.Drawing.Point(741, 39);
            this.nmScore.Name = "nmScore";
            this.nmScore.Size = new System.Drawing.Size(55, 27);
            this.nmScore.TabIndex = 14;
            // 
            // lblScore
            // 
            this.lblScore.AutoSize = true;
            this.lblScore.Location = new System.Drawing.Point(611, 42);
            this.lblScore.Name = "lblScore";
            this.lblScore.Size = new System.Drawing.Size(111, 20);
            this.lblScore.TabIndex = 12;
            this.lblScore.Text = "Điểm tích luỹ:";
            // 
            // txbCustomerName
            // 
            this.txbCustomerName.Location = new System.Drawing.Point(132, 67);
            this.txbCustomerName.Name = "txbCustomerName";
            this.txbCustomerName.Size = new System.Drawing.Size(151, 27);
            this.txbCustomerName.TabIndex = 9;
            // 
            // lblCustomerAddress
            // 
            this.lblCustomerAddress.AutoSize = true;
            this.lblCustomerAddress.Location = new System.Drawing.Point(339, 41);
            this.lblCustomerAddress.Name = "lblCustomerAddress";
            this.lblCustomerAddress.Size = new System.Drawing.Size(66, 20);
            this.lblCustomerAddress.TabIndex = 8;
            this.lblCustomerAddress.Text = "Địa chỉ:";
            // 
            // lblCustomerNumber
            // 
            this.lblCustomerNumber.AutoSize = true;
            this.lblCustomerNumber.Location = new System.Drawing.Point(339, 74);
            this.lblCustomerNumber.Name = "lblCustomerNumber";
            this.lblCustomerNumber.Size = new System.Drawing.Size(61, 20);
            this.lblCustomerNumber.TabIndex = 7;
            this.lblCustomerNumber.Text = "Số ĐT:";
            // 
            // lblCCCDNumber
            // 
            this.lblCCCDNumber.AutoSize = true;
            this.lblCCCDNumber.Location = new System.Drawing.Point(339, 107);
            this.lblCCCDNumber.Name = "lblCCCDNumber";
            this.lblCCCDNumber.Size = new System.Drawing.Size(63, 20);
            this.lblCCCDNumber.TabIndex = 6;
            this.lblCCCDNumber.Text = "CCCD:";
            // 
            // txbCustomerID
            // 
            this.txbCustomerID.Location = new System.Drawing.Point(132, 34);
            this.txbCustomerID.Name = "txbCustomerID";
            this.txbCustomerID.Size = new System.Drawing.Size(151, 27);
            this.txbCustomerID.TabIndex = 3;
            // 
            // lblCustomerDate
            // 
            this.lblCustomerDate.AutoSize = true;
            this.lblCustomerDate.Location = new System.Drawing.Point(41, 107);
            this.lblCustomerDate.Name = "lblCustomerDate";
            this.lblCustomerDate.Size = new System.Drawing.Size(88, 20);
            this.lblCustomerDate.TabIndex = 2;
            this.lblCustomerDate.Text = "Ngày sinh:";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(41, 74);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(64, 20);
            this.lblName.TabIndex = 1;
            this.lblName.Text = "Họ tên:";
            // 
            // lblCustomerID
            // 
            this.lblCustomerID.AutoSize = true;
            this.lblCustomerID.Location = new System.Drawing.Point(41, 41);
            this.lblCustomerID.Name = "lblCustomerID";
            this.lblCustomerID.Size = new System.Drawing.Size(66, 20);
            this.lblCustomerID.TabIndex = 0;
            this.lblCustomerID.Text = "Mã KH:";
            // 
            // btnCustomerShow
            // 
            this.btnCustomerShow.Location = new System.Drawing.Point(118, 166);
            this.btnCustomerShow.Name = "btnCustomerShow";
            this.btnCustomerShow.Size = new System.Drawing.Size(75, 33);
            this.btnCustomerShow.TabIndex = 1;
            this.btnCustomerShow.Text = "Xem";
            this.btnCustomerShow.UseVisualStyleBackColor = true;
            // 
            // btnCustomerAdd
            // 
            this.btnCustomerAdd.Location = new System.Drawing.Point(389, 163);
            this.btnCustomerAdd.Name = "btnCustomerAdd";
            this.btnCustomerAdd.Size = new System.Drawing.Size(75, 33);
            this.btnCustomerAdd.TabIndex = 2;
            this.btnCustomerAdd.Text = "Thêm";
            this.btnCustomerAdd.UseVisualStyleBackColor = true;
            // 
            // btnCustomerEdit
            // 
            this.btnCustomerEdit.Location = new System.Drawing.Point(490, 163);
            this.btnCustomerEdit.Name = "btnCustomerEdit";
            this.btnCustomerEdit.Size = new System.Drawing.Size(75, 33);
            this.btnCustomerEdit.TabIndex = 3;
            this.btnCustomerEdit.Text = "Sửa";
            this.btnCustomerEdit.UseVisualStyleBackColor = true;
            // 
            // btnCustomerDelete
            // 
            this.btnCustomerDelete.Location = new System.Drawing.Point(591, 163);
            this.btnCustomerDelete.Name = "btnCustomerDelete";
            this.btnCustomerDelete.Size = new System.Drawing.Size(75, 33);
            this.btnCustomerDelete.TabIndex = 4;
            this.btnCustomerDelete.Text = "Xoá";
            this.btnCustomerDelete.UseVisualStyleBackColor = true;
            // 
            // btnCustomerSearch
            // 
            this.btnCustomerSearch.Location = new System.Drawing.Point(859, 166);
            this.btnCustomerSearch.Name = "btnCustomerSearch";
            this.btnCustomerSearch.Size = new System.Drawing.Size(75, 33);
            this.btnCustomerSearch.TabIndex = 5;
            this.btnCustomerSearch.Text = "Tìm";
            this.btnCustomerSearch.UseVisualStyleBackColor = true;
            // 
            // dtgvCustomer
            // 
            this.dtgvCustomer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvCustomer.Location = new System.Drawing.Point(118, 205);
            this.dtgvCustomer.Name = "dtgvCustomer";
            this.dtgvCustomer.Size = new System.Drawing.Size(816, 356);
            this.dtgvCustomer.TabIndex = 7;
            // 
            // txtCustomerSearch
            // 
            this.txtCustomerSearch.Location = new System.Drawing.Point(733, 169);
            this.txtCustomerSearch.Name = "txtCustomerSearch";
            this.txtCustomerSearch.Size = new System.Drawing.Size(120, 27);
            this.txtCustomerSearch.TabIndex = 8;
            // 
            // Guest_UC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.txtCustomerSearch);
            this.Controls.Add(this.dtgvCustomer);
            this.Controls.Add(this.btnCustomerSearch);
            this.Controls.Add(this.btnCustomerDelete);
            this.Controls.Add(this.btnCustomerEdit);
            this.Controls.Add(this.btnCustomerAdd);
            this.Controls.Add(this.btnCustomerShow);
            this.Controls.Add(this.grpInformation);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "Guest_UC";
            this.Size = new System.Drawing.Size(1040, 596);
            this.grpInformation.ResumeLayout(false);
            this.grpInformation.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmScore)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvCustomer)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grpInformation;
        private System.Windows.Forms.NumericUpDown nmScore;
        private System.Windows.Forms.Label lblScore;
        private System.Windows.Forms.TextBox txbCustomerName;
        private System.Windows.Forms.Label lblCustomerAddress;
        private System.Windows.Forms.Label lblCustomerNumber;
        private System.Windows.Forms.Label lblCCCDNumber;
        private System.Windows.Forms.TextBox txbCustomerID;
        private System.Windows.Forms.Label lblCustomerDate;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblCustomerID;
        private System.Windows.Forms.Button btnCustomerShow;
        private System.Windows.Forms.Button btnCustomerAdd;
        private System.Windows.Forms.Button btnCustomerEdit;
        private System.Windows.Forms.Button btnCustomerDelete;
        private System.Windows.Forms.Button btnCustomerSearch;
        private System.Windows.Forms.DataGridView dtgvCustomer;
        private System.Windows.Forms.TextBox txbCCCDNumber;
        private System.Windows.Forms.TextBox txbCustomerNumber;
        private System.Windows.Forms.TextBox txbCustomerAddress;
        private System.Windows.Forms.TextBox txbCustomerDate;
        private System.Windows.Forms.TextBox txtCustomerSearch;
    }
}
