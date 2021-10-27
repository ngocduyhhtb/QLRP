
namespace QuanLyRapPhim.UserControls.DataUserControls
{
    partial class Movies_UC
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
            this.lblMoviesId = new System.Windows.Forms.Label();
            this.lblMoviesName = new System.Windows.Forms.Label();
            this.lblMoviesDescribe = new System.Windows.Forms.Label();
            this.lblMoviesGenre = new System.Windows.Forms.Label();
            this.lblFilmLength = new System.Windows.Forms.Label();
            this.lblStartDate = new System.Windows.Forms.Label();
            this.lblFinishDate = new System.Windows.Forms.Label();
            this.lblProducer = new System.Windows.Forms.Label();
            this.lblDirector = new System.Windows.Forms.Label();
            this.lblYearProducer = new System.Windows.Forms.Label();
            this.txbFilmId = new System.Windows.Forms.TextBox();
            this.txbFilmName = new System.Windows.Forms.TextBox();
            this.txbMoviesDescribe = new System.Windows.Forms.TextBox();
            this.clbMovieGenre = new System.Windows.Forms.CheckedListBox();
            this.txbFilmLength = new System.Windows.Forms.TextBox();
            this.txbProducer = new System.Windows.Forms.TextBox();
            this.dtpkStartDate = new System.Windows.Forms.DateTimePicker();
            this.dtpkFinishDate = new System.Windows.Forms.DateTimePicker();
            this.txbDirector = new System.Windows.Forms.TextBox();
            this.txbYearProducer = new System.Windows.Forms.TextBox();
            this.btnSelectPicture = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnFilmAdd = new System.Windows.Forms.Button();
            this.btnFilmDelete = new System.Windows.Forms.Button();
            this.btnFilmEdit = new System.Windows.Forms.Button();
            this.btnFilmShow = new System.Windows.Forms.Button();
            this.pbMovie = new System.Windows.Forms.PictureBox();
            this.dtgvMovies = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbMovie)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvMovies)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.pbMovie);
            this.panel1.Controls.Add(this.btnSelectPicture);
            this.panel1.Controls.Add(this.txbYearProducer);
            this.panel1.Controls.Add(this.txbDirector);
            this.panel1.Controls.Add(this.dtpkFinishDate);
            this.panel1.Controls.Add(this.dtpkStartDate);
            this.panel1.Controls.Add(this.txbProducer);
            this.panel1.Controls.Add(this.txbFilmLength);
            this.panel1.Controls.Add(this.clbMovieGenre);
            this.panel1.Controls.Add(this.txbMoviesDescribe);
            this.panel1.Controls.Add(this.txbFilmName);
            this.panel1.Controls.Add(this.txbFilmId);
            this.panel1.Controls.Add(this.lblYearProducer);
            this.panel1.Controls.Add(this.lblDirector);
            this.panel1.Controls.Add(this.lblProducer);
            this.panel1.Controls.Add(this.lblFinishDate);
            this.panel1.Controls.Add(this.lblStartDate);
            this.panel1.Controls.Add(this.lblFilmLength);
            this.panel1.Controls.Add(this.lblMoviesGenre);
            this.panel1.Controls.Add(this.lblMoviesDescribe);
            this.panel1.Controls.Add(this.lblMoviesName);
            this.panel1.Controls.Add(this.lblMoviesId);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(950, 241);
            this.panel1.TabIndex = 0;
            // 
            // lblMoviesId
            // 
            this.lblMoviesId.AutoSize = true;
            this.lblMoviesId.Location = new System.Drawing.Point(17, 13);
            this.lblMoviesId.Name = "lblMoviesId";
            this.lblMoviesId.Size = new System.Drawing.Size(78, 20);
            this.lblMoviesId.TabIndex = 0;
            this.lblMoviesId.Text = "Mã phim:";
            // 
            // lblMoviesName
            // 
            this.lblMoviesName.AutoSize = true;
            this.lblMoviesName.Location = new System.Drawing.Point(17, 46);
            this.lblMoviesName.Name = "lblMoviesName";
            this.lblMoviesName.Size = new System.Drawing.Size(83, 20);
            this.lblMoviesName.TabIndex = 1;
            this.lblMoviesName.Text = "Tên phim:";
            // 
            // lblMoviesDescribe
            // 
            this.lblMoviesDescribe.AutoSize = true;
            this.lblMoviesDescribe.Location = new System.Drawing.Point(17, 79);
            this.lblMoviesDescribe.Name = "lblMoviesDescribe";
            this.lblMoviesDescribe.Size = new System.Drawing.Size(56, 20);
            this.lblMoviesDescribe.TabIndex = 2;
            this.lblMoviesDescribe.Text = "Mô tả:";
            // 
            // lblMoviesGenre
            // 
            this.lblMoviesGenre.AutoSize = true;
            this.lblMoviesGenre.Location = new System.Drawing.Point(17, 112);
            this.lblMoviesGenre.Name = "lblMoviesGenre";
            this.lblMoviesGenre.Size = new System.Drawing.Size(73, 20);
            this.lblMoviesGenre.TabIndex = 3;
            this.lblMoviesGenre.Text = "Thể loại:";
            // 
            // lblFilmLength
            // 
            this.lblFilmLength.AutoSize = true;
            this.lblFilmLength.Location = new System.Drawing.Point(379, 13);
            this.lblFilmLength.Name = "lblFilmLength";
            this.lblFilmLength.Size = new System.Drawing.Size(86, 20);
            this.lblFilmLength.TabIndex = 4;
            this.lblFilmLength.Text = "Thời lượng";
            // 
            // lblStartDate
            // 
            this.lblStartDate.AutoSize = true;
            this.lblStartDate.Location = new System.Drawing.Point(379, 46);
            this.lblStartDate.Name = "lblStartDate";
            this.lblStartDate.Size = new System.Drawing.Size(80, 20);
            this.lblStartDate.TabIndex = 5;
            this.lblStartDate.Text = "Ngày KC:";
            // 
            // lblFinishDate
            // 
            this.lblFinishDate.AutoSize = true;
            this.lblFinishDate.Location = new System.Drawing.Point(379, 79);
            this.lblFinishDate.Name = "lblFinishDate";
            this.lblFinishDate.Size = new System.Drawing.Size(78, 20);
            this.lblFinishDate.TabIndex = 6;
            this.lblFinishDate.Text = "Ngày KT:";
            // 
            // lblProducer
            // 
            this.lblProducer.AutoSize = true;
            this.lblProducer.Location = new System.Drawing.Point(379, 112);
            this.lblProducer.Name = "lblProducer";
            this.lblProducer.Size = new System.Drawing.Size(79, 20);
            this.lblProducer.TabIndex = 7;
            this.lblProducer.Text = "Sản xuất:";
            // 
            // lblDirector
            // 
            this.lblDirector.AutoSize = true;
            this.lblDirector.Location = new System.Drawing.Point(379, 145);
            this.lblDirector.Name = "lblDirector";
            this.lblDirector.Size = new System.Drawing.Size(80, 20);
            this.lblDirector.TabIndex = 8;
            this.lblDirector.Text = "Đạo diễn:";
            // 
            // lblYearProducer
            // 
            this.lblYearProducer.AutoSize = true;
            this.lblYearProducer.Location = new System.Drawing.Point(379, 178);
            this.lblYearProducer.Name = "lblYearProducer";
            this.lblYearProducer.Size = new System.Drawing.Size(117, 20);
            this.lblYearProducer.TabIndex = 9;
            this.lblYearProducer.Text = "Năm sản xuất:";
            // 
            // txbFilmId
            // 
            this.txbFilmId.Location = new System.Drawing.Point(114, 6);
            this.txbFilmId.Name = "txbFilmId";
            this.txbFilmId.Size = new System.Drawing.Size(144, 27);
            this.txbFilmId.TabIndex = 10;
            // 
            // txbFilmName
            // 
            this.txbFilmName.Location = new System.Drawing.Point(114, 39);
            this.txbFilmName.Name = "txbFilmName";
            this.txbFilmName.Size = new System.Drawing.Size(144, 27);
            this.txbFilmName.TabIndex = 13;
            // 
            // txbMoviesDescribe
            // 
            this.txbMoviesDescribe.Location = new System.Drawing.Point(114, 72);
            this.txbMoviesDescribe.Name = "txbMoviesDescribe";
            this.txbMoviesDescribe.Size = new System.Drawing.Size(144, 27);
            this.txbMoviesDescribe.TabIndex = 14;
            // 
            // clbMovieGenre
            // 
            this.clbMovieGenre.FormattingEnabled = true;
            this.clbMovieGenre.Location = new System.Drawing.Point(21, 135);
            this.clbMovieGenre.Name = "clbMovieGenre";
            this.clbMovieGenre.Size = new System.Drawing.Size(210, 92);
            this.clbMovieGenre.TabIndex = 15;
            // 
            // txbFilmLength
            // 
            this.txbFilmLength.Location = new System.Drawing.Point(500, 6);
            this.txbFilmLength.Name = "txbFilmLength";
            this.txbFilmLength.Size = new System.Drawing.Size(169, 27);
            this.txbFilmLength.TabIndex = 16;
            // 
            // txbProducer
            // 
            this.txbProducer.Location = new System.Drawing.Point(500, 105);
            this.txbProducer.Name = "txbProducer";
            this.txbProducer.Size = new System.Drawing.Size(169, 27);
            this.txbProducer.TabIndex = 18;
            // 
            // dtpkStartDate
            // 
            this.dtpkStartDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpkStartDate.Location = new System.Drawing.Point(500, 39);
            this.dtpkStartDate.Name = "dtpkStartDate";
            this.dtpkStartDate.Size = new System.Drawing.Size(169, 27);
            this.dtpkStartDate.TabIndex = 19;
            // 
            // dtpkFinishDate
            // 
            this.dtpkFinishDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpkFinishDate.Location = new System.Drawing.Point(500, 72);
            this.dtpkFinishDate.Name = "dtpkFinishDate";
            this.dtpkFinishDate.Size = new System.Drawing.Size(169, 27);
            this.dtpkFinishDate.TabIndex = 20;
            // 
            // txbDirector
            // 
            this.txbDirector.Location = new System.Drawing.Point(500, 138);
            this.txbDirector.Name = "txbDirector";
            this.txbDirector.Size = new System.Drawing.Size(169, 27);
            this.txbDirector.TabIndex = 21;
            // 
            // txbYearProducer
            // 
            this.txbYearProducer.Location = new System.Drawing.Point(500, 171);
            this.txbYearProducer.Name = "txbYearProducer";
            this.txbYearProducer.Size = new System.Drawing.Size(169, 27);
            this.txbYearProducer.TabIndex = 22;
            // 
            // btnSelectPicture
            // 
            this.btnSelectPicture.Location = new System.Drawing.Point(739, 178);
            this.btnSelectPicture.Name = "btnSelectPicture";
            this.btnSelectPicture.Size = new System.Drawing.Size(146, 34);
            this.btnSelectPicture.TabIndex = 23;
            this.btnSelectPicture.Text = "Chọn hình ảnh";
            this.btnSelectPicture.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.CausesValidation = false;
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 241);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(950, 60);
            this.panel2.TabIndex = 1;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.dtgvMovies);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 301);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(950, 244);
            this.flowLayoutPanel1.TabIndex = 2;
            // 
            // panel3
            // 
            this.panel3.CausesValidation = false;
            this.panel3.Controls.Add(this.btnFilmShow);
            this.panel3.Controls.Add(this.btnFilmEdit);
            this.panel3.Controls.Add(this.btnFilmDelete);
            this.panel3.Controls.Add(this.btnFilmAdd);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(950, 60);
            this.panel3.TabIndex = 2;
            // 
            // btnFilmAdd
            // 
            this.btnFilmAdd.Location = new System.Drawing.Point(183, 6);
            this.btnFilmAdd.Name = "btnFilmAdd";
            this.btnFilmAdd.Size = new System.Drawing.Size(75, 34);
            this.btnFilmAdd.TabIndex = 24;
            this.btnFilmAdd.Text = "Thêm";
            this.btnFilmAdd.UseVisualStyleBackColor = true;
            // 
            // btnFilmDelete
            // 
            this.btnFilmDelete.Location = new System.Drawing.Point(357, 6);
            this.btnFilmDelete.Name = "btnFilmDelete";
            this.btnFilmDelete.Size = new System.Drawing.Size(75, 34);
            this.btnFilmDelete.TabIndex = 25;
            this.btnFilmDelete.Text = "Xoá";
            this.btnFilmDelete.UseVisualStyleBackColor = true;
            // 
            // btnFilmEdit
            // 
            this.btnFilmEdit.Location = new System.Drawing.Point(526, 6);
            this.btnFilmEdit.Name = "btnFilmEdit";
            this.btnFilmEdit.Size = new System.Drawing.Size(75, 34);
            this.btnFilmEdit.TabIndex = 26;
            this.btnFilmEdit.Text = "Sửa";
            this.btnFilmEdit.UseVisualStyleBackColor = true;
            // 
            // btnFilmShow
            // 
            this.btnFilmShow.Location = new System.Drawing.Point(690, 6);
            this.btnFilmShow.Name = "btnFilmShow";
            this.btnFilmShow.Size = new System.Drawing.Size(75, 34);
            this.btnFilmShow.TabIndex = 27;
            this.btnFilmShow.Text = "Xem";
            this.btnFilmShow.UseVisualStyleBackColor = true;
            // 
            // pbMovie
            // 
            this.pbMovie.Location = new System.Drawing.Point(739, 6);
            this.pbMovie.Name = "pbMovie";
            this.pbMovie.Size = new System.Drawing.Size(146, 166);
            this.pbMovie.TabIndex = 24;
            this.pbMovie.TabStop = false;
            // 
            // dtgvMovies
            // 
            this.dtgvMovies.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvMovies.Location = new System.Drawing.Point(3, 3);
            this.dtgvMovies.Name = "dtgvMovies";
            this.dtgvMovies.Size = new System.Drawing.Size(944, 241);
            this.dtgvMovies.TabIndex = 0;
            // 
            // Movies_UC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.Name = "Movies_UC";
            this.Size = new System.Drawing.Size(950, 548);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbMovie)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvMovies)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pbMovie;
        private System.Windows.Forms.Button btnSelectPicture;
        private System.Windows.Forms.TextBox txbYearProducer;
        private System.Windows.Forms.TextBox txbDirector;
        private System.Windows.Forms.DateTimePicker dtpkFinishDate;
        private System.Windows.Forms.DateTimePicker dtpkStartDate;
        private System.Windows.Forms.TextBox txbProducer;
        private System.Windows.Forms.TextBox txbFilmLength;
        private System.Windows.Forms.CheckedListBox clbMovieGenre;
        private System.Windows.Forms.TextBox txbMoviesDescribe;
        private System.Windows.Forms.TextBox txbFilmName;
        private System.Windows.Forms.TextBox txbFilmId;
        private System.Windows.Forms.Label lblYearProducer;
        private System.Windows.Forms.Label lblDirector;
        private System.Windows.Forms.Label lblProducer;
        private System.Windows.Forms.Label lblFinishDate;
        private System.Windows.Forms.Label lblStartDate;
        private System.Windows.Forms.Label lblFilmLength;
        private System.Windows.Forms.Label lblMoviesGenre;
        private System.Windows.Forms.Label lblMoviesDescribe;
        private System.Windows.Forms.Label lblMoviesName;
        private System.Windows.Forms.Label lblMoviesId;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnFilmShow;
        private System.Windows.Forms.Button btnFilmEdit;
        private System.Windows.Forms.Button btnFilmDelete;
        private System.Windows.Forms.Button btnFilmAdd;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.DataGridView dtgvMovies;
    }
}
