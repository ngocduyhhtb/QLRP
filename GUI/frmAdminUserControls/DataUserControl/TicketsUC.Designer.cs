namespace GUI.frmAdminUserControls.DataUserControl
{
    partial class TicketsUC
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
            this.pnTitle = new System.Windows.Forms.Panel();
            this.btnShowShowTimeNotCreateTickets = new System.Windows.Forms.Button();
            this.btnShowAllTicketsBoughtByShowTime = new System.Windows.Forms.Button();
            this.btnShowAllTicketsByShowTime = new System.Windows.Forms.Button();
            this.btnAddTicketsByShowTime = new System.Windows.Forms.Button();
            this.btnAllListShowTimes = new System.Windows.Forms.Button();
            this.btnDeleteTicketsByShowTime = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lsvAllListShowTimes = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.dtgvTicket = new System.Windows.Forms.DataGridView();
            this.pnTitle.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvTicket)).BeginInit();
            this.SuspendLayout();
            // 
            // pnTitle
            // 
            this.pnTitle.Controls.Add(this.btnShowShowTimeNotCreateTickets);
            this.pnTitle.Controls.Add(this.btnShowAllTicketsBoughtByShowTime);
            this.pnTitle.Controls.Add(this.btnShowAllTicketsByShowTime);
            this.pnTitle.Controls.Add(this.btnAddTicketsByShowTime);
            this.pnTitle.Controls.Add(this.btnAllListShowTimes);
            this.pnTitle.Controls.Add(this.btnDeleteTicketsByShowTime);
            this.pnTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnTitle.Location = new System.Drawing.Point(0, 0);
            this.pnTitle.Name = "pnTitle";
            this.pnTitle.Size = new System.Drawing.Size(1136, 52);
            this.pnTitle.TabIndex = 12;
            // 
            // btnShowShowTimeNotCreateTickets
            // 
            this.btnShowShowTimeNotCreateTickets.Location = new System.Drawing.Point(715, 3);
            this.btnShowShowTimeNotCreateTickets.Name = "btnShowShowTimeNotCreateTickets";
            this.btnShowShowTimeNotCreateTickets.Size = new System.Drawing.Size(200, 46);
            this.btnShowShowTimeNotCreateTickets.TabIndex = 7;
            this.btnShowShowTimeNotCreateTickets.Text = "Xem lịch chiếu chưa tạo";
            this.btnShowShowTimeNotCreateTickets.UseVisualStyleBackColor = true;
            // 
            // btnShowAllTicketsBoughtByShowTime
            // 
            this.btnShowAllTicketsBoughtByShowTime.Location = new System.Drawing.Point(349, 3);
            this.btnShowAllTicketsBoughtByShowTime.Name = "btnShowAllTicketsBoughtByShowTime";
            this.btnShowAllTicketsBoughtByShowTime.Size = new System.Drawing.Size(156, 46);
            this.btnShowAllTicketsBoughtByShowTime.TabIndex = 6;
            this.btnShowAllTicketsBoughtByShowTime.Text = "Xem vé đã bán";
            this.btnShowAllTicketsBoughtByShowTime.UseVisualStyleBackColor = true;
            // 
            // btnShowAllTicketsByShowTime
            // 
            this.btnShowAllTicketsByShowTime.Location = new System.Drawing.Point(511, 3);
            this.btnShowAllTicketsByShowTime.Name = "btnShowAllTicketsByShowTime";
            this.btnShowAllTicketsByShowTime.Size = new System.Drawing.Size(198, 46);
            this.btnShowAllTicketsByShowTime.TabIndex = 5;
            this.btnShowAllTicketsByShowTime.Text = "Xem tất cả các vé";
            this.btnShowAllTicketsByShowTime.UseVisualStyleBackColor = true;
            // 
            // btnAddTicketsByShowTime
            // 
            this.btnAddTicketsByShowTime.Location = new System.Drawing.Point(20, 3);
            this.btnAddTicketsByShowTime.Name = "btnAddTicketsByShowTime";
            this.btnAddTicketsByShowTime.Size = new System.Drawing.Size(159, 46);
            this.btnAddTicketsByShowTime.TabIndex = 0;
            this.btnAddTicketsByShowTime.Text = " Tự động thêm vé";
            this.btnAddTicketsByShowTime.UseVisualStyleBackColor = true;
            // 
            // btnAllListShowTimes
            // 
            this.btnAllListShowTimes.Location = new System.Drawing.Point(921, 3);
            this.btnAllListShowTimes.Name = "btnAllListShowTimes";
            this.btnAllListShowTimes.Size = new System.Drawing.Size(192, 46);
            this.btnAllListShowTimes.TabIndex = 3;
            this.btnAllListShowTimes.Text = "Xem tất cả lịch chiếu";
            this.btnAllListShowTimes.UseVisualStyleBackColor = true;
            // 
            // btnDeleteTicketsByShowTime
            // 
            this.btnDeleteTicketsByShowTime.Location = new System.Drawing.Point(185, 3);
            this.btnDeleteTicketsByShowTime.Name = "btnDeleteTicketsByShowTime";
            this.btnDeleteTicketsByShowTime.Size = new System.Drawing.Size(158, 46);
            this.btnDeleteTicketsByShowTime.TabIndex = 1;
            this.btnDeleteTicketsByShowTime.Text = "Xoá vé theo lịch";
            this.btnDeleteTicketsByShowTime.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lsvAllListShowTimes);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(609, 52);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(527, 484);
            this.panel1.TabIndex = 13;
            // 
            // lsvAllListShowTimes
            // 
            this.lsvAllListShowTimes.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4});
            this.lsvAllListShowTimes.FullRowSelect = true;
            this.lsvAllListShowTimes.GridLines = true;
            this.lsvAllListShowTimes.HideSelection = false;
            this.lsvAllListShowTimes.Location = new System.Drawing.Point(2, 1);
            this.lsvAllListShowTimes.Margin = new System.Windows.Forms.Padding(2);
            this.lsvAllListShowTimes.Name = "lsvAllListShowTimes";
            this.lsvAllListShowTimes.Size = new System.Drawing.Size(523, 482);
            this.lsvAllListShowTimes.TabIndex = 10;
            this.lsvAllListShowTimes.UseCompatibleStateImageBehavior = false;
            this.lsvAllListShowTimes.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Tên Phòng Chiếu";
            this.columnHeader1.Width = 120;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Tên Phim";
            this.columnHeader2.Width = 150;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Thời Gian";
            this.columnHeader3.Width = 150;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Trạng Thái";
            this.columnHeader4.Width = 100;
            // 
            // dtgvTicket
            // 
            this.dtgvTicket.AllowUserToAddRows = false;
            this.dtgvTicket.AllowUserToDeleteRows = false;
            this.dtgvTicket.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgvTicket.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvTicket.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtgvTicket.Location = new System.Drawing.Point(0, 52);
            this.dtgvTicket.Name = "dtgvTicket";
            this.dtgvTicket.Size = new System.Drawing.Size(609, 484);
            this.dtgvTicket.TabIndex = 14;
            // 
            // TicketsUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dtgvTicket);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pnTitle);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "TicketsUC";
            this.Size = new System.Drawing.Size(1136, 536);
            this.pnTitle.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvTicket)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnTitle;
        private System.Windows.Forms.Button btnShowShowTimeNotCreateTickets;
        private System.Windows.Forms.Button btnShowAllTicketsBoughtByShowTime;
        private System.Windows.Forms.Button btnShowAllTicketsByShowTime;
        private System.Windows.Forms.Button btnAddTicketsByShowTime;
        private System.Windows.Forms.Button btnAllListShowTimes;
        private System.Windows.Forms.Button btnDeleteTicketsByShowTime;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ListView lsvAllListShowTimes;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.DataGridView dtgvTicket;
    }
}
