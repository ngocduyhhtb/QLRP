
namespace QuanLyRapPhim.UserControls.DataUserControls
{
    partial class FormatFilm
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.lblFilmName = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.txbFormatId = new System.Windows.Forms.TextBox();
            this.lblFormatId = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.dtgvGenre = new System.Windows.Forms.DataGridView();
            this.lblFilmId = new System.Windows.Forms.Label();
            this.txbFilmName = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbFilmName = new System.Windows.Forms.ComboBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvGenre)).BeginInit();
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
            this.panel1.TabIndex = 2;
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
            // panel2
            // 
            this.panel2.Controls.Add(this.panel6);
            this.panel2.Controls.Add(this.panel5);
            this.panel2.Controls.Add(this.panel4);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(550, 60);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(400, 488);
            this.panel2.TabIndex = 3;
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.comboBox2);
            this.panel6.Controls.Add(this.label3);
            this.panel6.Controls.Add(this.label2);
            this.panel6.Controls.Add(this.textBox2);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel6.Location = new System.Drawing.Point(0, 151);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(400, 96);
            this.panel6.TabIndex = 6;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.cmbFilmName);
            this.panel5.Controls.Add(this.txbFilmName);
            this.panel5.Controls.Add(this.lblFilmId);
            this.panel5.Controls.Add(this.lblFilmName);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel5.Location = new System.Drawing.Point(0, 52);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(400, 99);
            this.panel5.TabIndex = 5;
            // 
            // lblFilmName
            // 
            this.lblFilmName.AutoSize = true;
            this.lblFilmName.Location = new System.Drawing.Point(33, 51);
            this.lblFilmName.Name = "lblFilmName";
            this.lblFilmName.Size = new System.Drawing.Size(83, 20);
            this.lblFilmName.TabIndex = 1;
            this.lblFilmName.Text = "Tên phim:";
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.txbFormatId);
            this.panel4.Controls.Add(this.lblFormatId);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(400, 52);
            this.panel4.TabIndex = 3;
            // 
            // txbFormatId
            // 
            this.txbFormatId.Location = new System.Drawing.Point(175, 9);
            this.txbFormatId.Name = "txbFormatId";
            this.txbFormatId.Size = new System.Drawing.Size(190, 27);
            this.txbFormatId.TabIndex = 5;
            // 
            // lblFormatId
            // 
            this.lblFormatId.AutoSize = true;
            this.lblFormatId.Location = new System.Drawing.Point(28, 12);
            this.lblFormatId.Name = "lblFormatId";
            this.lblFormatId.Size = new System.Drawing.Size(114, 20);
            this.lblFormatId.TabIndex = 4;
            this.lblFormatId.Text = "Mã định dạng:";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.dtgvGenre);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel3.Location = new System.Drawing.Point(0, 60);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(547, 488);
            this.panel3.TabIndex = 4;
            // 
            // dtgvGenre
            // 
            this.dtgvGenre.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvGenre.Location = new System.Drawing.Point(11, 0);
            this.dtgvGenre.Name = "dtgvGenre";
            this.dtgvGenre.Size = new System.Drawing.Size(533, 486);
            this.dtgvGenre.TabIndex = 1;
            // 
            // lblFilmId
            // 
            this.lblFilmId.AutoSize = true;
            this.lblFilmId.Location = new System.Drawing.Point(33, 18);
            this.lblFilmId.Name = "lblFilmId";
            this.lblFilmId.Size = new System.Drawing.Size(78, 20);
            this.lblFilmId.TabIndex = 7;
            this.lblFilmId.Text = "Mã phim:";
            // 
            // txbFilmName
            // 
            this.txbFilmName.Location = new System.Drawing.Point(175, 44);
            this.txbFilmName.Name = "txbFilmName";
            this.txbFilmName.Size = new System.Drawing.Size(190, 27);
            this.txbFilmName.TabIndex = 8;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(175, 44);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(190, 27);
            this.textBox2.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(33, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 20);
            this.label2.TabIndex = 10;
            this.label2.Text = "Mã thể loại:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(33, 51);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(101, 20);
            this.label3.TabIndex = 11;
            this.label3.Text = "Tên thể loại:";
            // 
            // cmbFilmName
            // 
            this.cmbFilmName.FormattingEnabled = true;
            this.cmbFilmName.Location = new System.Drawing.Point(175, 10);
            this.cmbFilmName.Name = "cmbFilmName";
            this.cmbFilmName.Size = new System.Drawing.Size(190, 28);
            this.cmbFilmName.TabIndex = 9;
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(175, 10);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(190, 28);
            this.comboBox2.TabIndex = 12;
            // 
            // FormatFilm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.Name = "FormatFilm";
            this.Size = new System.Drawing.Size(950, 548);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvGenre)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnShow;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label lblFilmName;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.TextBox txbFormatId;
        private System.Windows.Forms.Label lblFormatId;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.DataGridView dtgvGenre;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox txbFilmName;
        private System.Windows.Forms.Label lblFilmId;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.ComboBox cmbFilmName;
    }
}
