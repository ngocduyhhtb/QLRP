//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace GUI
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using System.Data.Entity.Core.Objects;
    using System.Linq;
    
    public partial class QLRPEntities : DbContext
    {
        public QLRPEntities()
            : base("name=QLRPEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<DinhDangPhim> DinhDangPhims { get; set; }
        public virtual DbSet<KhachHang> KhachHangs { get; set; }
        public virtual DbSet<LichChieu> LichChieux { get; set; }
        public virtual DbSet<LoaiManHinh> LoaiManHinhs { get; set; }
        public virtual DbSet<NhanVien> NhanViens { get; set; }
        public virtual DbSet<Phim> Phims { get; set; }
        public virtual DbSet<PhongChieu> PhongChieux { get; set; }
        public virtual DbSet<TheLoai> TheLoais { get; set; }
        public virtual DbSet<Ve> Ves { get; set; }
        public virtual DbSet<TaiKhoan> TaiKhoans { get; set; }
    
        public virtual int USP_DeleteTicketsByShowTimes(string idlichChieu)
        {
            var idlichChieuParameter = idlichChieu != null ?
                new ObjectParameter("idlichChieu", idlichChieu) :
                new ObjectParameter("idlichChieu", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("USP_DeleteTicketsByShowTimes", idlichChieuParameter);
        }
    
        public virtual ObjectResult<USP_GetAccountList_Result> USP_GetAccountList()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<USP_GetAccountList_Result>("USP_GetAccountList");
        }
    
        public virtual ObjectResult<USP_GetAllListShowTimes_Result> USP_GetAllListShowTimes()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<USP_GetAllListShowTimes_Result>("USP_GetAllListShowTimes");
        }
    
        public virtual ObjectResult<USP_GetCinema_Result> USP_GetCinema()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<USP_GetCinema_Result>("USP_GetCinema");
        }
    
        public virtual ObjectResult<USP_GetCustomer_Result> USP_GetCustomer()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<USP_GetCustomer_Result>("USP_GetCustomer");
        }
    
        public virtual ObjectResult<USP_GetListFormatMovie_Result> USP_GetListFormatMovie()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<USP_GetListFormatMovie_Result>("USP_GetListFormatMovie");
        }
    
        public virtual ObjectResult<USP_GetListGenreByMovie_Result> USP_GetListGenreByMovie(string idPhim)
        {
            var idPhimParameter = idPhim != null ?
                new ObjectParameter("idPhim", idPhim) :
                new ObjectParameter("idPhim", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<USP_GetListGenreByMovie_Result>("USP_GetListGenreByMovie", idPhimParameter);
        }
    
        public virtual ObjectResult<USP_GetListShowTimesByFormatMovie_Result> USP_GetListShowTimesByFormatMovie(string iD, Nullable<System.DateTime> date)
        {
            var iDParameter = iD != null ?
                new ObjectParameter("ID", iD) :
                new ObjectParameter("ID", typeof(string));
    
            var dateParameter = date.HasValue ?
                new ObjectParameter("Date", date) :
                new ObjectParameter("Date", typeof(System.DateTime));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<USP_GetListShowTimesByFormatMovie_Result>("USP_GetListShowTimesByFormatMovie", iDParameter, dateParameter);
        }
    
        public virtual ObjectResult<USP_GetListShowTimesNotCreateTickets_Result> USP_GetListShowTimesNotCreateTickets()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<USP_GetListShowTimesNotCreateTickets_Result>("USP_GetListShowTimesNotCreateTickets");
        }
    
        public virtual ObjectResult<USP_GetMovie_Result> USP_GetMovie()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<USP_GetMovie_Result>("USP_GetMovie");
        }
    
        public virtual ObjectResult<USP_GetReportRevenueByMovieAndDate_Result> USP_GetReportRevenueByMovieAndDate(string idMovie, Nullable<System.DateTime> fromDate, Nullable<System.DateTime> toDate)
        {
            var idMovieParameter = idMovie != null ?
                new ObjectParameter("idMovie", idMovie) :
                new ObjectParameter("idMovie", typeof(string));
    
            var fromDateParameter = fromDate.HasValue ?
                new ObjectParameter("fromDate", fromDate) :
                new ObjectParameter("fromDate", typeof(System.DateTime));
    
            var toDateParameter = toDate.HasValue ?
                new ObjectParameter("toDate", toDate) :
                new ObjectParameter("toDate", typeof(System.DateTime));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<USP_GetReportRevenueByMovieAndDate_Result>("USP_GetReportRevenueByMovieAndDate", idMovieParameter, fromDateParameter, toDateParameter);
        }
    
        public virtual ObjectResult<USP_GetRevenueByMovieAndDate_Result> USP_GetRevenueByMovieAndDate(string idMovie, Nullable<System.DateTime> fromDate, Nullable<System.DateTime> toDate)
        {
            var idMovieParameter = idMovie != null ?
                new ObjectParameter("idMovie", idMovie) :
                new ObjectParameter("idMovie", typeof(string));
    
            var fromDateParameter = fromDate.HasValue ?
                new ObjectParameter("fromDate", fromDate) :
                new ObjectParameter("fromDate", typeof(System.DateTime));
    
            var toDateParameter = toDate.HasValue ?
                new ObjectParameter("toDate", toDate) :
                new ObjectParameter("toDate", typeof(System.DateTime));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<USP_GetRevenueByMovieAndDate_Result>("USP_GetRevenueByMovieAndDate", idMovieParameter, fromDateParameter, toDateParameter);
        }
    
        public virtual ObjectResult<USP_GetShowtime_Result> USP_GetShowtime()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<USP_GetShowtime_Result>("USP_GetShowtime");
        }
    
        public virtual ObjectResult<USP_GetStaff_Result> USP_GetStaff()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<USP_GetStaff_Result>("USP_GetStaff");
        }
    
        public virtual int USP_InsertAccount(string username, Nullable<int> loaiTK, string idnv)
        {
            var usernameParameter = username != null ?
                new ObjectParameter("username", username) :
                new ObjectParameter("username", typeof(string));
    
            var loaiTKParameter = loaiTK.HasValue ?
                new ObjectParameter("loaiTK", loaiTK) :
                new ObjectParameter("loaiTK", typeof(int));
    
            var idnvParameter = idnv != null ?
                new ObjectParameter("idnv", idnv) :
                new ObjectParameter("idnv", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("USP_InsertAccount", usernameParameter, loaiTKParameter, idnvParameter);
        }
    
        public virtual int USP_InsertCinema(string idCinema, string tenPhong, string idMH, Nullable<int> soChoNgoi, Nullable<int> tinhTrang, Nullable<int> soHangGhe, Nullable<int> soGheMotHang)
        {
            var idCinemaParameter = idCinema != null ?
                new ObjectParameter("idCinema", idCinema) :
                new ObjectParameter("idCinema", typeof(string));
    
            var tenPhongParameter = tenPhong != null ?
                new ObjectParameter("tenPhong", tenPhong) :
                new ObjectParameter("tenPhong", typeof(string));
    
            var idMHParameter = idMH != null ?
                new ObjectParameter("idMH", idMH) :
                new ObjectParameter("idMH", typeof(string));
    
            var soChoNgoiParameter = soChoNgoi.HasValue ?
                new ObjectParameter("soChoNgoi", soChoNgoi) :
                new ObjectParameter("soChoNgoi", typeof(int));
    
            var tinhTrangParameter = tinhTrang.HasValue ?
                new ObjectParameter("tinhTrang", tinhTrang) :
                new ObjectParameter("tinhTrang", typeof(int));
    
            var soHangGheParameter = soHangGhe.HasValue ?
                new ObjectParameter("soHangGhe", soHangGhe) :
                new ObjectParameter("soHangGhe", typeof(int));
    
            var soGheMotHangParameter = soGheMotHang.HasValue ?
                new ObjectParameter("soGheMotHang", soGheMotHang) :
                new ObjectParameter("soGheMotHang", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("USP_InsertCinema", idCinemaParameter, tenPhongParameter, idMHParameter, soChoNgoiParameter, tinhTrangParameter, soHangGheParameter, soGheMotHangParameter);
        }
    
        public virtual int USP_InsertCustomer(string idCus, string hoTen, Nullable<System.DateTime> ngaySinh, string diaChi, string sdt, Nullable<int> cmnd)
        {
            var idCusParameter = idCus != null ?
                new ObjectParameter("idCus", idCus) :
                new ObjectParameter("idCus", typeof(string));
    
            var hoTenParameter = hoTen != null ?
                new ObjectParameter("hoTen", hoTen) :
                new ObjectParameter("hoTen", typeof(string));
    
            var ngaySinhParameter = ngaySinh.HasValue ?
                new ObjectParameter("ngaySinh", ngaySinh) :
                new ObjectParameter("ngaySinh", typeof(System.DateTime));
    
            var diaChiParameter = diaChi != null ?
                new ObjectParameter("diaChi", diaChi) :
                new ObjectParameter("diaChi", typeof(string));
    
            var sdtParameter = sdt != null ?
                new ObjectParameter("sdt", sdt) :
                new ObjectParameter("sdt", typeof(string));
    
            var cmndParameter = cmnd.HasValue ?
                new ObjectParameter("cmnd", cmnd) :
                new ObjectParameter("cmnd", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("USP_InsertCustomer", idCusParameter, hoTenParameter, ngaySinhParameter, diaChiParameter, sdtParameter, cmndParameter);
        }
    
        public virtual int USP_InsertFormatMovie(string id, string idPhim, string idLoaiManHinh)
        {
            var idParameter = id != null ?
                new ObjectParameter("id", id) :
                new ObjectParameter("id", typeof(string));
    
            var idPhimParameter = idPhim != null ?
                new ObjectParameter("idPhim", idPhim) :
                new ObjectParameter("idPhim", typeof(string));
    
            var idLoaiManHinhParameter = idLoaiManHinh != null ?
                new ObjectParameter("idLoaiManHinh", idLoaiManHinh) :
                new ObjectParameter("idLoaiManHinh", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("USP_InsertFormatMovie", idParameter, idPhimParameter, idLoaiManHinhParameter);
        }
    
        public virtual int USP_InsertGenre(string idGenre, string ten, string moTa)
        {
            var idGenreParameter = idGenre != null ?
                new ObjectParameter("idGenre", idGenre) :
                new ObjectParameter("idGenre", typeof(string));
    
            var tenParameter = ten != null ?
                new ObjectParameter("ten", ten) :
                new ObjectParameter("ten", typeof(string));
    
            var moTaParameter = moTa != null ?
                new ObjectParameter("moTa", moTa) :
                new ObjectParameter("moTa", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("USP_InsertGenre", idGenreParameter, tenParameter, moTaParameter);
        }
    
        public virtual int USP_InsertMovie(string id, string tenPhim, string moTa, Nullable<double> thoiLuong, Nullable<System.DateTime> ngayKhoiChieu, Nullable<System.DateTime> ngayKetThuc, string sanXuat, string daoDien, Nullable<int> namSX, byte[] apPhich)
        {
            var idParameter = id != null ?
                new ObjectParameter("id", id) :
                new ObjectParameter("id", typeof(string));
    
            var tenPhimParameter = tenPhim != null ?
                new ObjectParameter("tenPhim", tenPhim) :
                new ObjectParameter("tenPhim", typeof(string));
    
            var moTaParameter = moTa != null ?
                new ObjectParameter("moTa", moTa) :
                new ObjectParameter("moTa", typeof(string));
    
            var thoiLuongParameter = thoiLuong.HasValue ?
                new ObjectParameter("thoiLuong", thoiLuong) :
                new ObjectParameter("thoiLuong", typeof(double));
    
            var ngayKhoiChieuParameter = ngayKhoiChieu.HasValue ?
                new ObjectParameter("ngayKhoiChieu", ngayKhoiChieu) :
                new ObjectParameter("ngayKhoiChieu", typeof(System.DateTime));
    
            var ngayKetThucParameter = ngayKetThuc.HasValue ?
                new ObjectParameter("ngayKetThuc", ngayKetThuc) :
                new ObjectParameter("ngayKetThuc", typeof(System.DateTime));
    
            var sanXuatParameter = sanXuat != null ?
                new ObjectParameter("sanXuat", sanXuat) :
                new ObjectParameter("sanXuat", typeof(string));
    
            var daoDienParameter = daoDien != null ?
                new ObjectParameter("daoDien", daoDien) :
                new ObjectParameter("daoDien", typeof(string));
    
            var namSXParameter = namSX.HasValue ?
                new ObjectParameter("namSX", namSX) :
                new ObjectParameter("namSX", typeof(int));
    
            var apPhichParameter = apPhich != null ?
                new ObjectParameter("apPhich", apPhich) :
                new ObjectParameter("apPhich", typeof(byte[]));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("USP_InsertMovie", idParameter, tenPhimParameter, moTaParameter, thoiLuongParameter, ngayKhoiChieuParameter, ngayKetThucParameter, sanXuatParameter, daoDienParameter, namSXParameter, apPhichParameter);
        }
    
        public virtual int USP_InsertScreenType(string idScreenType, string ten)
        {
            var idScreenTypeParameter = idScreenType != null ?
                new ObjectParameter("idScreenType", idScreenType) :
                new ObjectParameter("idScreenType", typeof(string));
    
            var tenParameter = ten != null ?
                new ObjectParameter("ten", ten) :
                new ObjectParameter("ten", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("USP_InsertScreenType", idScreenTypeParameter, tenParameter);
        }
    
        public virtual int USP_InsertShowtime(string id, string idPhong, string idDinhDang, Nullable<System.DateTime> thoiGianChieu, Nullable<double> giaVe)
        {
            var idParameter = id != null ?
                new ObjectParameter("id", id) :
                new ObjectParameter("id", typeof(string));
    
            var idPhongParameter = idPhong != null ?
                new ObjectParameter("idPhong", idPhong) :
                new ObjectParameter("idPhong", typeof(string));
    
            var idDinhDangParameter = idDinhDang != null ?
                new ObjectParameter("idDinhDang", idDinhDang) :
                new ObjectParameter("idDinhDang", typeof(string));
    
            var thoiGianChieuParameter = thoiGianChieu.HasValue ?
                new ObjectParameter("thoiGianChieu", thoiGianChieu) :
                new ObjectParameter("thoiGianChieu", typeof(System.DateTime));
    
            var giaVeParameter = giaVe.HasValue ?
                new ObjectParameter("giaVe", giaVe) :
                new ObjectParameter("giaVe", typeof(double));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("USP_InsertShowtime", idParameter, idPhongParameter, idDinhDangParameter, thoiGianChieuParameter, giaVeParameter);
        }
    
        public virtual int USP_InsertStaff(string idStaff, string hoTen, Nullable<System.DateTime> ngaySinh, string diaChi, string sdt, Nullable<int> cmnd)
        {
            var idStaffParameter = idStaff != null ?
                new ObjectParameter("idStaff", idStaff) :
                new ObjectParameter("idStaff", typeof(string));
    
            var hoTenParameter = hoTen != null ?
                new ObjectParameter("hoTen", hoTen) :
                new ObjectParameter("hoTen", typeof(string));
    
            var ngaySinhParameter = ngaySinh.HasValue ?
                new ObjectParameter("ngaySinh", ngaySinh) :
                new ObjectParameter("ngaySinh", typeof(System.DateTime));
    
            var diaChiParameter = diaChi != null ?
                new ObjectParameter("diaChi", diaChi) :
                new ObjectParameter("diaChi", typeof(string));
    
            var sdtParameter = sdt != null ?
                new ObjectParameter("sdt", sdt) :
                new ObjectParameter("sdt", typeof(string));
    
            var cmndParameter = cmnd.HasValue ?
                new ObjectParameter("cmnd", cmnd) :
                new ObjectParameter("cmnd", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("USP_InsertStaff", idStaffParameter, hoTenParameter, ngaySinhParameter, diaChiParameter, sdtParameter, cmndParameter);
        }
    
        public virtual int USP_InsertTicketByShowTimes(string idlichChieu, string maGheNgoi)
        {
            var idlichChieuParameter = idlichChieu != null ?
                new ObjectParameter("idlichChieu", idlichChieu) :
                new ObjectParameter("idlichChieu", typeof(string));
    
            var maGheNgoiParameter = maGheNgoi != null ?
                new ObjectParameter("maGheNgoi", maGheNgoi) :
                new ObjectParameter("maGheNgoi", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("USP_InsertTicketByShowTimes", idlichChieuParameter, maGheNgoiParameter);
        }
    
        public virtual ObjectResult<USP_Login_Result> USP_Login(string userName, string pass)
        {
            var userNameParameter = userName != null ?
                new ObjectParameter("userName", userName) :
                new ObjectParameter("userName", typeof(string));
    
            var passParameter = pass != null ?
                new ObjectParameter("pass", pass) :
                new ObjectParameter("pass", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<USP_Login_Result>("USP_Login", userNameParameter, passParameter);
        }
    
        public virtual int USP_ResetPasswordtAccount(string username)
        {
            var usernameParameter = username != null ?
                new ObjectParameter("username", username) :
                new ObjectParameter("username", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("USP_ResetPasswordtAccount", usernameParameter);
        }
    
        public virtual ObjectResult<USP_SearchAccount_Result> USP_SearchAccount(string hoTen)
        {
            var hoTenParameter = hoTen != null ?
                new ObjectParameter("hoTen", hoTen) :
                new ObjectParameter("hoTen", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<USP_SearchAccount_Result>("USP_SearchAccount", hoTenParameter);
        }
    
        public virtual ObjectResult<USP_SearchCustomer_Result> USP_SearchCustomer(string hoTen)
        {
            var hoTenParameter = hoTen != null ?
                new ObjectParameter("hoTen", hoTen) :
                new ObjectParameter("hoTen", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<USP_SearchCustomer_Result>("USP_SearchCustomer", hoTenParameter);
        }
    
        public virtual ObjectResult<USP_SearchShowtimeByMovieName_Result> USP_SearchShowtimeByMovieName(string tenPhim)
        {
            var tenPhimParameter = tenPhim != null ?
                new ObjectParameter("tenPhim", tenPhim) :
                new ObjectParameter("tenPhim", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<USP_SearchShowtimeByMovieName_Result>("USP_SearchShowtimeByMovieName", tenPhimParameter);
        }
    
        public virtual ObjectResult<USP_SearchStaff_Result> USP_SearchStaff(string hoTen)
        {
            var hoTenParameter = hoTen != null ?
                new ObjectParameter("hoTen", hoTen) :
                new ObjectParameter("hoTen", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<USP_SearchStaff_Result>("USP_SearchStaff", hoTenParameter);
        }
    
        public virtual int USP_UpdateAccount(string username, Nullable<int> loaiTK)
        {
            var usernameParameter = username != null ?
                new ObjectParameter("username", username) :
                new ObjectParameter("username", typeof(string));
    
            var loaiTKParameter = loaiTK.HasValue ?
                new ObjectParameter("loaiTK", loaiTK) :
                new ObjectParameter("loaiTK", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("USP_UpdateAccount", usernameParameter, loaiTKParameter);
        }
    
        public virtual int USP_UpdateMovie(string id, string tenPhim, string moTa, Nullable<double> thoiLuong, Nullable<System.DateTime> ngayKhoiChieu, Nullable<System.DateTime> ngayKetThuc, string sanXuat, string daoDien, Nullable<int> namSX, byte[] apPhich)
        {
            var idParameter = id != null ?
                new ObjectParameter("id", id) :
                new ObjectParameter("id", typeof(string));
    
            var tenPhimParameter = tenPhim != null ?
                new ObjectParameter("tenPhim", tenPhim) :
                new ObjectParameter("tenPhim", typeof(string));
    
            var moTaParameter = moTa != null ?
                new ObjectParameter("moTa", moTa) :
                new ObjectParameter("moTa", typeof(string));
    
            var thoiLuongParameter = thoiLuong.HasValue ?
                new ObjectParameter("thoiLuong", thoiLuong) :
                new ObjectParameter("thoiLuong", typeof(double));
    
            var ngayKhoiChieuParameter = ngayKhoiChieu.HasValue ?
                new ObjectParameter("ngayKhoiChieu", ngayKhoiChieu) :
                new ObjectParameter("ngayKhoiChieu", typeof(System.DateTime));
    
            var ngayKetThucParameter = ngayKetThuc.HasValue ?
                new ObjectParameter("ngayKetThuc", ngayKetThuc) :
                new ObjectParameter("ngayKetThuc", typeof(System.DateTime));
    
            var sanXuatParameter = sanXuat != null ?
                new ObjectParameter("sanXuat", sanXuat) :
                new ObjectParameter("sanXuat", typeof(string));
    
            var daoDienParameter = daoDien != null ?
                new ObjectParameter("daoDien", daoDien) :
                new ObjectParameter("daoDien", typeof(string));
    
            var namSXParameter = namSX.HasValue ?
                new ObjectParameter("namSX", namSX) :
                new ObjectParameter("namSX", typeof(int));
    
            var apPhichParameter = apPhich != null ?
                new ObjectParameter("apPhich", apPhich) :
                new ObjectParameter("apPhich", typeof(byte[]));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("USP_UpdateMovie", idParameter, tenPhimParameter, moTaParameter, thoiLuongParameter, ngayKhoiChieuParameter, ngayKetThucParameter, sanXuatParameter, daoDienParameter, namSXParameter, apPhichParameter);
        }
    
        public virtual int USP_UpdatePasswordForAccount(string username, string pass, string newPass)
        {
            var usernameParameter = username != null ?
                new ObjectParameter("username", username) :
                new ObjectParameter("username", typeof(string));
    
            var passParameter = pass != null ?
                new ObjectParameter("pass", pass) :
                new ObjectParameter("pass", typeof(string));
    
            var newPassParameter = newPass != null ?
                new ObjectParameter("newPass", newPass) :
                new ObjectParameter("newPass", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("USP_UpdatePasswordForAccount", usernameParameter, passParameter, newPassParameter);
        }
    
        public virtual int USP_UpdateShowtime(string id, string idPhong, string idDinhDang, Nullable<System.DateTime> thoiGianChieu, Nullable<double> giaVe)
        {
            var idParameter = id != null ?
                new ObjectParameter("id", id) :
                new ObjectParameter("id", typeof(string));
    
            var idPhongParameter = idPhong != null ?
                new ObjectParameter("idPhong", idPhong) :
                new ObjectParameter("idPhong", typeof(string));
    
            var idDinhDangParameter = idDinhDang != null ?
                new ObjectParameter("idDinhDang", idDinhDang) :
                new ObjectParameter("idDinhDang", typeof(string));
    
            var thoiGianChieuParameter = thoiGianChieu.HasValue ?
                new ObjectParameter("thoiGianChieu", thoiGianChieu) :
                new ObjectParameter("thoiGianChieu", typeof(System.DateTime));
    
            var giaVeParameter = giaVe.HasValue ?
                new ObjectParameter("giaVe", giaVe) :
                new ObjectParameter("giaVe", typeof(double));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("USP_UpdateShowtime", idParameter, idPhongParameter, idDinhDangParameter, thoiGianChieuParameter, giaVeParameter);
        }
    
        public virtual int USP_UpdateStatusShowTimes(string idLichChieu, Nullable<int> status)
        {
            var idLichChieuParameter = idLichChieu != null ?
                new ObjectParameter("idLichChieu", idLichChieu) :
                new ObjectParameter("idLichChieu", typeof(string));
    
            var statusParameter = status.HasValue ?
                new ObjectParameter("status", status) :
                new ObjectParameter("status", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("USP_UpdateStatusShowTimes", idLichChieuParameter, statusParameter);
        }
    }
}
