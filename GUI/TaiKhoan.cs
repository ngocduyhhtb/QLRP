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
    using System.Collections.Generic;
    
    public partial class TaiKhoan
    {
        public string UserName { get; set; }
        public string Pass { get; set; }
        public int LoaiTK { get; set; }
        public string idNV { get; set; }
    
        public virtual NhanVien NhanVien { get; set; }
    }
}
