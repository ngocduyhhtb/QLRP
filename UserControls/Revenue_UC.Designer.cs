
namespace QuanLyRapPhim.UserControls
{
    partial class Revenue_UC
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
            this.lblFilmSelect = new System.Windows.Forms.Label();
            this.lblDateFrom = new System.Windows.Forms.Label();
            this.lblDateTo = new System.Windows.Forms.Label();
            this.lblRevenueSum = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.btnShowRevenue = new System.Windows.Forms.Button();
            this.btnReport = new System.Windows.Forms.Button();
            this.dtgvRevenue = new System.Windows.Forms.DataGridView();
            this.txbRevenueSum = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvRevenue)).BeginInit();
            this.SuspendLayout();
            // 
            // lblFilmSelect
            // 
            this.lblFilmSelect.AutoSize = true;
            this.lblFilmSelect.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFilmSelect.Location = new System.Drawing.Point(122, 11);
            this.lblFilmSelect.Name = "lblFilmSelect";
            this.lblFilmSelect.Size = new System.Drawing.Size(136, 20);
            this.lblFilmSelect.TabIndex = 0;
            this.lblFilmSelect.Text = "Chọn tên phim:";
            // 
            // lblDateFrom
            // 
            this.lblDateFrom.AutoSize = true;
            this.lblDateFrom.Location = new System.Drawing.Point(122, 83);
            this.lblDateFrom.Name = "lblDateFrom";
            this.lblDateFrom.Size = new System.Drawing.Size(73, 20);
            this.lblDateFrom.TabIndex = 1;
            this.lblDateFrom.Text = "Từ ngày:";
            // 
            // lblDateTo
            // 
            this.lblDateTo.AutoSize = true;
            this.lblDateTo.Location = new System.Drawing.Point(470, 83);
            this.lblDateTo.Name = "lblDateTo";
            this.lblDateTo.Size = new System.Drawing.Size(79, 20);
            this.lblDateTo.TabIndex = 2;
            this.lblDateTo.Text = "Đến ngày";
            // 
            // lblRevenueSum
            // 
            this.lblRevenueSum.AutoSize = true;
            this.lblRevenueSum.Location = new System.Drawing.Point(680, 536);
            this.lblRevenueSum.Name = "lblRevenueSum";
            this.lblRevenueSum.Size = new System.Drawing.Size(129, 20);
            this.lblRevenueSum.TabIndex = 3;
            this.lblRevenueSum.Text = "Tổng doanh thu:";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(264, 8);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(314, 28);
            this.comboBox1.TabIndex = 4;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(209, 78);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 27);
            this.dateTimePicker1.TabIndex = 5;
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker2.Location = new System.Drawing.Point(568, 78);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(200, 27);
            this.dateTimePicker2.TabIndex = 6;
            // 
            // btnShowRevenue
            // 
            this.btnShowRevenue.Location = new System.Drawing.Point(798, 76);
            this.btnShowRevenue.Name = "btnShowRevenue";
            this.btnShowRevenue.Size = new System.Drawing.Size(88, 34);
            this.btnShowRevenue.TabIndex = 7;
            this.btnShowRevenue.Text = "Thống kê";
            this.btnShowRevenue.UseVisualStyleBackColor = true;
            // 
            // btnReport
            // 
            this.btnReport.Location = new System.Drawing.Point(914, 76);
            this.btnReport.Name = "btnReport";
            this.btnReport.Size = new System.Drawing.Size(88, 34);
            this.btnReport.TabIndex = 8;
            this.btnReport.Text = "Báo cáo";
            this.btnReport.UseVisualStyleBackColor = true;
            // 
            // dtgvRevenue
            // 
            this.dtgvRevenue.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvRevenue.Location = new System.Drawing.Point(126, 127);
            this.dtgvRevenue.Name = "dtgvRevenue";
            this.dtgvRevenue.Size = new System.Drawing.Size(876, 385);
            this.dtgvRevenue.TabIndex = 9;
            // 
            // txbRevenueSum
            // 
            this.txbRevenueSum.Location = new System.Drawing.Point(816, 533);
            this.txbRevenueSum.Name = "txbRevenueSum";
            this.txbRevenueSum.Size = new System.Drawing.Size(186, 27);
            this.txbRevenueSum.TabIndex = 10;
            // 
            // Revenue_UC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.txbRevenueSum);
            this.Controls.Add(this.dtgvRevenue);
            this.Controls.Add(this.btnReport);
            this.Controls.Add(this.btnShowRevenue);
            this.Controls.Add(this.dateTimePicker2);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.lblRevenueSum);
            this.Controls.Add(this.lblDateTo);
            this.Controls.Add(this.lblDateFrom);
            this.Controls.Add(this.lblFilmSelect);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Revenue_UC";
            this.Size = new System.Drawing.Size(1086, 592);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvRevenue)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblFilmSelect;
        private System.Windows.Forms.Label lblDateFrom;
        private System.Windows.Forms.Label lblDateTo;
        private System.Windows.Forms.Label lblRevenueSum;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.Button btnShowRevenue;
        private System.Windows.Forms.Button btnReport;
        private System.Windows.Forms.DataGridView dtgvRevenue;
        private System.Windows.Forms.TextBox txbRevenueSum;
    }
}
