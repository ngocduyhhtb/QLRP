
namespace QuanLyRapPhim.UserControls.DataUserControls
{
    partial class CinemaRoom_UC
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnShow = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.dtgvCinemaRoom = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.txbRoomName = new System.Windows.Forms.TextBox();
            this.lblRoomName = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.txbRoomId = new System.Windows.Forms.TextBox();
            this.lblRoomId = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.lblScreen = new System.Windows.Forms.Label();
            this.panel7 = new System.Windows.Forms.Panel();
            this.txbRoomSeats = new System.Windows.Forms.TextBox();
            this.lblRoomSeats = new System.Windows.Forms.Label();
            this.panel8 = new System.Windows.Forms.Panel();
            this.txbRoomStatus = new System.Windows.Forms.TextBox();
            this.lblRoomStatus = new System.Windows.Forms.Label();
            this.panel9 = new System.Windows.Forms.Panel();
            this.txbNumberOfRows = new System.Windows.Forms.TextBox();
            this.lblNumberOfRows = new System.Windows.Forms.Label();
            this.panel10 = new System.Windows.Forms.Panel();
            this.txbSeatsPerRow = new System.Windows.Forms.TextBox();
            this.lblSeatsPerRows = new System.Windows.Forms.Label();
            this.cmbScreen = new System.Windows.Forms.ComboBox();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvCinemaRoom)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel7.SuspendLayout();
            this.panel8.SuspendLayout();
            this.panel9.SuspendLayout();
            this.panel10.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnEdit);
            this.panel1.Controls.Add(this.btnShow);
            this.panel1.Controls.Add(this.btnDelete);
            this.panel1.Controls.Add(this.btnAdd);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(950, 60);
            this.panel1.TabIndex = 1;
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(194, 10);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(75, 44);
            this.btnEdit.TabIndex = 3;
            this.btnEdit.Text = "Sửa";
            this.btnEdit.UseVisualStyleBackColor = true;
            // 
            // btnShow
            // 
            this.btnShow.Location = new System.Drawing.Point(287, 10);
            this.btnShow.Name = "btnShow";
            this.btnShow.Size = new System.Drawing.Size(75, 44);
            this.btnShow.TabIndex = 2;
            this.btnShow.Text = "Xem";
            this.btnShow.UseVisualStyleBackColor = true;
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(103, 10);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 44);
            this.btnDelete.TabIndex = 1;
            this.btnDelete.Text = "Xoá";
            this.btnDelete.UseVisualStyleBackColor = true;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(12, 10);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 44);
            this.btnAdd.TabIndex = 0;
            this.btnAdd.Text = "Thêm";
            this.btnAdd.UseVisualStyleBackColor = true;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.dtgvCinemaRoom);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel3.Location = new System.Drawing.Point(0, 60);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(563, 488);
            this.panel3.TabIndex = 3;
            // 
            // dtgvCinemaRoom
            // 
            this.dtgvCinemaRoom.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvCinemaRoom.Location = new System.Drawing.Point(11, 0);
            this.dtgvCinemaRoom.Name = "dtgvCinemaRoom";
            this.dtgvCinemaRoom.Size = new System.Drawing.Size(552, 486);
            this.dtgvCinemaRoom.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.panel10);
            this.panel2.Controls.Add(this.panel9);
            this.panel2.Controls.Add(this.panel8);
            this.panel2.Controls.Add(this.panel7);
            this.panel2.Controls.Add(this.panel6);
            this.panel2.Controls.Add(this.panel5);
            this.panel2.Controls.Add(this.panel4);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(569, 60);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(381, 488);
            this.panel2.TabIndex = 4;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.txbRoomName);
            this.panel5.Controls.Add(this.lblRoomName);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel5.Location = new System.Drawing.Point(0, 52);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(381, 52);
            this.panel5.TabIndex = 5;
            // 
            // txbRoomName
            // 
            this.txbRoomName.Location = new System.Drawing.Point(175, 11);
            this.txbRoomName.Name = "txbRoomName";
            this.txbRoomName.Size = new System.Drawing.Size(190, 27);
            this.txbRoomName.TabIndex = 6;
            // 
            // lblRoomName
            // 
            this.lblRoomName.AutoSize = true;
            this.lblRoomName.Location = new System.Drawing.Point(28, 18);
            this.lblRoomName.Name = "lblRoomName";
            this.lblRoomName.Size = new System.Drawing.Size(115, 20);
            this.lblRoomName.TabIndex = 1;
            this.lblRoomName.Text = "Tên màn hình:";
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.txbRoomId);
            this.panel4.Controls.Add(this.lblRoomId);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(381, 52);
            this.panel4.TabIndex = 3;
            // 
            // txbRoomId
            // 
            this.txbRoomId.Location = new System.Drawing.Point(175, 9);
            this.txbRoomId.Name = "txbRoomId";
            this.txbRoomId.Size = new System.Drawing.Size(190, 27);
            this.txbRoomId.TabIndex = 5;
            // 
            // lblRoomId
            // 
            this.lblRoomId.AutoSize = true;
            this.lblRoomId.Location = new System.Drawing.Point(28, 12);
            this.lblRoomId.Name = "lblRoomId";
            this.lblRoomId.Size = new System.Drawing.Size(141, 20);
            this.lblRoomId.TabIndex = 4;
            this.lblRoomId.Text = "Mã loại màn hình:";
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.cmbScreen);
            this.panel6.Controls.Add(this.lblScreen);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel6.Location = new System.Drawing.Point(0, 104);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(381, 52);
            this.panel6.TabIndex = 6;
            // 
            // lblScreen
            // 
            this.lblScreen.AutoSize = true;
            this.lblScreen.Location = new System.Drawing.Point(28, 18);
            this.lblScreen.Name = "lblScreen";
            this.lblScreen.Size = new System.Drawing.Size(82, 20);
            this.lblScreen.TabIndex = 1;
            this.lblScreen.Text = "Màn hình:";
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.txbRoomSeats);
            this.panel7.Controls.Add(this.lblRoomSeats);
            this.panel7.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel7.Location = new System.Drawing.Point(0, 156);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(381, 52);
            this.panel7.TabIndex = 7;
            // 
            // txbRoomSeats
            // 
            this.txbRoomSeats.Location = new System.Drawing.Point(175, 11);
            this.txbRoomSeats.Name = "txbRoomSeats";
            this.txbRoomSeats.Size = new System.Drawing.Size(190, 27);
            this.txbRoomSeats.TabIndex = 6;
            // 
            // lblRoomSeats
            // 
            this.lblRoomSeats.AutoSize = true;
            this.lblRoomSeats.Location = new System.Drawing.Point(28, 18);
            this.lblRoomSeats.Name = "lblRoomSeats";
            this.lblRoomSeats.Size = new System.Drawing.Size(102, 20);
            this.lblRoomSeats.TabIndex = 1;
            this.lblRoomSeats.Text = "Số chỗ ngồi:";
            // 
            // panel8
            // 
            this.panel8.Controls.Add(this.txbRoomStatus);
            this.panel8.Controls.Add(this.lblRoomStatus);
            this.panel8.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel8.Location = new System.Drawing.Point(0, 208);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(381, 52);
            this.panel8.TabIndex = 8;
            // 
            // txbRoomStatus
            // 
            this.txbRoomStatus.Location = new System.Drawing.Point(175, 11);
            this.txbRoomStatus.Name = "txbRoomStatus";
            this.txbRoomStatus.Size = new System.Drawing.Size(190, 27);
            this.txbRoomStatus.TabIndex = 6;
            // 
            // lblRoomStatus
            // 
            this.lblRoomStatus.AutoSize = true;
            this.lblRoomStatus.Location = new System.Drawing.Point(28, 18);
            this.lblRoomStatus.Name = "lblRoomStatus";
            this.lblRoomStatus.Size = new System.Drawing.Size(89, 20);
            this.lblRoomStatus.TabIndex = 1;
            this.lblRoomStatus.Text = "Tình trạng:";
            // 
            // panel9
            // 
            this.panel9.Controls.Add(this.txbNumberOfRows);
            this.panel9.Controls.Add(this.lblNumberOfRows);
            this.panel9.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel9.Location = new System.Drawing.Point(0, 260);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(381, 52);
            this.panel9.TabIndex = 9;
            // 
            // txbNumberOfRows
            // 
            this.txbNumberOfRows.Location = new System.Drawing.Point(175, 11);
            this.txbNumberOfRows.Name = "txbNumberOfRows";
            this.txbNumberOfRows.Size = new System.Drawing.Size(190, 27);
            this.txbNumberOfRows.TabIndex = 6;
            // 
            // lblNumberOfRows
            // 
            this.lblNumberOfRows.AutoSize = true;
            this.lblNumberOfRows.Location = new System.Drawing.Point(28, 18);
            this.lblNumberOfRows.Name = "lblNumberOfRows";
            this.lblNumberOfRows.Size = new System.Drawing.Size(107, 20);
            this.lblNumberOfRows.TabIndex = 1;
            this.lblNumberOfRows.Text = "Số hàng ghế:";
            // 
            // panel10
            // 
            this.panel10.Controls.Add(this.txbSeatsPerRow);
            this.panel10.Controls.Add(this.lblSeatsPerRows);
            this.panel10.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel10.Location = new System.Drawing.Point(0, 312);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(381, 52);
            this.panel10.TabIndex = 10;
            // 
            // txbSeatsPerRow
            // 
            this.txbSeatsPerRow.Location = new System.Drawing.Point(175, 11);
            this.txbSeatsPerRow.Name = "txbSeatsPerRow";
            this.txbSeatsPerRow.Size = new System.Drawing.Size(190, 27);
            this.txbSeatsPerRow.TabIndex = 6;
            // 
            // lblSeatsPerRows
            // 
            this.lblSeatsPerRows.AutoSize = true;
            this.lblSeatsPerRows.Location = new System.Drawing.Point(28, 18);
            this.lblSeatsPerRows.Name = "lblSeatsPerRows";
            this.lblSeatsPerRows.Size = new System.Drawing.Size(118, 20);
            this.lblSeatsPerRows.TabIndex = 1;
            this.lblSeatsPerRows.Text = "Ghế mỗi hàng:";
            // 
            // cmbScreen
            // 
            this.cmbScreen.FormattingEnabled = true;
            this.cmbScreen.Location = new System.Drawing.Point(175, 15);
            this.cmbScreen.Name = "cmbScreen";
            this.cmbScreen.Size = new System.Drawing.Size(190, 28);
            this.cmbScreen.TabIndex = 2;
            // 
            // CinemaRoom_UC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.Name = "CinemaRoom_UC";
            this.Size = new System.Drawing.Size(950, 548);
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvCinemaRoom)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            this.panel8.ResumeLayout(false);
            this.panel8.PerformLayout();
            this.panel9.ResumeLayout(false);
            this.panel9.PerformLayout();
            this.panel10.ResumeLayout(false);
            this.panel10.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnShow;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.DataGridView dtgvCinemaRoom;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Label lblScreen;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.TextBox txbRoomName;
        private System.Windows.Forms.Label lblRoomName;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.TextBox txbRoomId;
        private System.Windows.Forms.Label lblRoomId;
        private System.Windows.Forms.Panel panel10;
        private System.Windows.Forms.TextBox txbSeatsPerRow;
        private System.Windows.Forms.Label lblSeatsPerRows;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.TextBox txbNumberOfRows;
        private System.Windows.Forms.Label lblNumberOfRows;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.TextBox txbRoomStatus;
        private System.Windows.Forms.Label lblRoomStatus;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.TextBox txbRoomSeats;
        private System.Windows.Forms.Label lblRoomSeats;
        private System.Windows.Forms.ComboBox cmbScreen;
    }
}
