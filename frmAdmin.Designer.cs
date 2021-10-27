
namespace QuanLyRapPhim
{
    partial class frmAdmin
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.pnAdmin = new System.Windows.Forms.Panel();
            this.btnRevenue = new System.Windows.Forms.Button();
            this.btnData = new System.Windows.Forms.Button();
            this.btnGuest = new System.Windows.Forms.Button();
            this.btnStaff = new System.Windows.Forms.Button();
            this.btnAccount = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.panel1.Controls.Add(this.btnAccount);
            this.panel1.Controls.Add(this.btnGuest);
            this.panel1.Controls.Add(this.btnStaff);
            this.panel1.Controls.Add(this.btnData);
            this.panel1.Controls.Add(this.btnRevenue);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1091, 100);
            this.panel1.TabIndex = 0;
            // 
            // pnAdmin
            // 
            this.pnAdmin.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnAdmin.Location = new System.Drawing.Point(0, 100);
            this.pnAdmin.Name = "pnAdmin";
            this.pnAdmin.Size = new System.Drawing.Size(1091, 620);
            this.pnAdmin.TabIndex = 1;
            // 
            // btnRevenue
            // 
            this.btnRevenue.Location = new System.Drawing.Point(49, 29);
            this.btnRevenue.Name = "btnRevenue";
            this.btnRevenue.Size = new System.Drawing.Size(104, 39);
            this.btnRevenue.TabIndex = 0;
            this.btnRevenue.Text = "Doanh thu";
            this.btnRevenue.UseVisualStyleBackColor = true;
            this.btnRevenue.Click += new System.EventHandler(this.btnRevenue_Click);
            // 
            // btnData
            // 
            this.btnData.Location = new System.Drawing.Point(163, 29);
            this.btnData.Name = "btnData";
            this.btnData.Size = new System.Drawing.Size(104, 39);
            this.btnData.TabIndex = 1;
            this.btnData.Text = "Dữ liệu";
            this.btnData.UseVisualStyleBackColor = true;
            this.btnData.Click += new System.EventHandler(this.btnData_Click);
            // 
            // btnGuest
            // 
            this.btnGuest.Location = new System.Drawing.Point(394, 29);
            this.btnGuest.Name = "btnGuest";
            this.btnGuest.Size = new System.Drawing.Size(104, 39);
            this.btnGuest.TabIndex = 3;
            this.btnGuest.Text = "Khách hàng";
            this.btnGuest.UseVisualStyleBackColor = true;
            this.btnGuest.Click += new System.EventHandler(this.btnGuest_Click);
            // 
            // btnStaff
            // 
            this.btnStaff.Location = new System.Drawing.Point(280, 29);
            this.btnStaff.Name = "btnStaff";
            this.btnStaff.Size = new System.Drawing.Size(104, 39);
            this.btnStaff.TabIndex = 2;
            this.btnStaff.Text = "Nhân viên";
            this.btnStaff.UseVisualStyleBackColor = true;
            this.btnStaff.Click += new System.EventHandler(this.btnStaff_Click);
            // 
            // btnAccount
            // 
            this.btnAccount.Location = new System.Drawing.Point(509, 29);
            this.btnAccount.Name = "btnAccount";
            this.btnAccount.Size = new System.Drawing.Size(104, 39);
            this.btnAccount.TabIndex = 4;
            this.btnAccount.Text = "Tài khoản";
            this.btnAccount.UseVisualStyleBackColor = true;
            this.btnAccount.Click += new System.EventHandler(this.btnAccount_Click);
            // 
            // frmAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1091, 720);
            this.Controls.Add(this.pnAdmin);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmAdmin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Admin";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnAccount;
        private System.Windows.Forms.Button btnGuest;
        private System.Windows.Forms.Button btnStaff;
        private System.Windows.Forms.Button btnData;
        private System.Windows.Forms.Button btnRevenue;
        private System.Windows.Forms.Panel pnAdmin;
    }
}