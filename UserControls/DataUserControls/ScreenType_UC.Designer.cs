
namespace QuanLyRapPhim.UserControls.DataUserControls
{
    partial class ScreenType_UC
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnShow = new System.Windows.Forms.Button();
            this.dtgvScreenType = new System.Windows.Forms.DataGridView();
            this.lblScreenTypeName = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.lblScreenTypeId = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.txbScreenTypeId = new System.Windows.Forms.TextBox();
            this.txbScreenTypeName = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvScreenType)).BeginInit();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
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
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.panel5);
            this.panel2.Controls.Add(this.panel4);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(569, 60);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(381, 488);
            this.panel2.TabIndex = 1;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.dtgvScreenType);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel3.Location = new System.Drawing.Point(0, 60);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(563, 488);
            this.panel3.TabIndex = 2;
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
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(103, 10);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 44);
            this.btnDelete.TabIndex = 1;
            this.btnDelete.Text = "Xoá";
            this.btnDelete.UseVisualStyleBackColor = true;
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
            // dtgvScreenType
            // 
            this.dtgvScreenType.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvScreenType.Location = new System.Drawing.Point(11, 0);
            this.dtgvScreenType.Name = "dtgvScreenType";
            this.dtgvScreenType.Size = new System.Drawing.Size(552, 486);
            this.dtgvScreenType.TabIndex = 1;
            // 
            // lblScreenTypeName
            // 
            this.lblScreenTypeName.AutoSize = true;
            this.lblScreenTypeName.Location = new System.Drawing.Point(28, 18);
            this.lblScreenTypeName.Name = "lblScreenTypeName";
            this.lblScreenTypeName.Size = new System.Drawing.Size(115, 20);
            this.lblScreenTypeName.TabIndex = 1;
            this.lblScreenTypeName.Text = "Tên màn hình:";
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.txbScreenTypeId);
            this.panel4.Controls.Add(this.lblScreenTypeId);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(381, 52);
            this.panel4.TabIndex = 3;
            // 
            // lblScreenTypeId
            // 
            this.lblScreenTypeId.AutoSize = true;
            this.lblScreenTypeId.Location = new System.Drawing.Point(28, 12);
            this.lblScreenTypeId.Name = "lblScreenTypeId";
            this.lblScreenTypeId.Size = new System.Drawing.Size(141, 20);
            this.lblScreenTypeId.TabIndex = 4;
            this.lblScreenTypeId.Text = "Mã loại màn hình:";
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.txbScreenTypeName);
            this.panel5.Controls.Add(this.lblScreenTypeName);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel5.Location = new System.Drawing.Point(0, 52);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(381, 52);
            this.panel5.TabIndex = 5;
            // 
            // txbScreenTypeId
            // 
            this.txbScreenTypeId.Location = new System.Drawing.Point(175, 9);
            this.txbScreenTypeId.Name = "txbScreenTypeId";
            this.txbScreenTypeId.Size = new System.Drawing.Size(190, 27);
            this.txbScreenTypeId.TabIndex = 5;
            // 
            // txbScreenTypeName
            // 
            this.txbScreenTypeName.Location = new System.Drawing.Point(175, 11);
            this.txbScreenTypeName.Name = "txbScreenTypeName";
            this.txbScreenTypeName.Size = new System.Drawing.Size(190, 27);
            this.txbScreenTypeName.TabIndex = 6;
            // 
            // ScreenType_UC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.Name = "ScreenType_UC";
            this.Size = new System.Drawing.Size(950, 548);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvScreenType)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnShow;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label lblScreenTypeName;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.TextBox txbScreenTypeId;
        private System.Windows.Forms.Label lblScreenTypeId;
        private System.Windows.Forms.DataGridView dtgvScreenType;
        private System.Windows.Forms.TextBox txbScreenTypeName;
    }
}
