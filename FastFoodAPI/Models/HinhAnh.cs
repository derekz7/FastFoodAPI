//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace FastFoodAPI.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class HinhAnh
    {
        public int idAnh { get; set; }
        public string imgUrl { get; set; }
        public string IDSP { get; set; }
    
        public virtual SanPham SanPham { get; set; }
    }
}
