//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace VanilaBakery.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class BLOG
    {
        public int MaBlog { get; set; }
        public string HinhAnh1 { get; set; }
        public string HinhAnh2 { get; set; }
        public Nullable<int> SoLuotXem { get; set; }
        public Nullable<System.DateTime> NgayDangTin { get; set; }
        public string TieuDe { get; set; }
        public string TomTat { get; set; }
        public string NoiDung { get; set; }
        public Nullable<int> MaTag { get; set; }
        public string TacGia { get; set; }
    
        public virtual TAG TAG { get; set; }
    }
}
