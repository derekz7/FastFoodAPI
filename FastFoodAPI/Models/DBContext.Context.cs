﻿//------------------------------------------------------------------------------
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
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using System.Data.Entity.Core.Objects;
    using System.Linq;
    
    public partial class FastFoodAppEntities1 : DbContext
    {
        public FastFoodAppEntities1()
            : base("name=FastFoodAppEntities1")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Banner> Banner { get; set; }
        public virtual DbSet<ChiTietDonDat> ChiTietDonDat { get; set; }
        public virtual DbSet<ChiTietDonHang> ChiTietDonHang { get; set; }
        public virtual DbSet<DanhMuc> DanhMuc { get; set; }
        public virtual DbSet<DonDatHang> DonDatHang { get; set; }
        public virtual DbSet<DonHang> DonHang { get; set; }
        public virtual DbSet<GioHang> GioHang { get; set; }
        public virtual DbSet<HinhAnh> HinhAnh { get; set; }
        public virtual DbSet<NguoiDung> NguoiDung { get; set; }
        public virtual DbSet<SanPham> SanPham { get; set; }
        public virtual DbSet<SHOP> SHOP { get; set; }
    
        public virtual int addDanhMuc(string ten, string img, string moTa)
        {
            var tenParameter = ten != null ?
                new ObjectParameter("ten", ten) :
                new ObjectParameter("ten", typeof(string));
    
            var imgParameter = img != null ?
                new ObjectParameter("img", img) :
                new ObjectParameter("img", typeof(string));
    
            var moTaParameter = moTa != null ?
                new ObjectParameter("moTa", moTa) :
                new ObjectParameter("moTa", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("addDanhMuc", tenParameter, imgParameter, moTaParameter);
        }
    
        public virtual int AddNguoiDung(string email, string hoTen, string sdt, string pass)
        {
            var emailParameter = email != null ?
                new ObjectParameter("email", email) :
                new ObjectParameter("email", typeof(string));
    
            var hoTenParameter = hoTen != null ?
                new ObjectParameter("hoTen", hoTen) :
                new ObjectParameter("hoTen", typeof(string));
    
            var sdtParameter = sdt != null ?
                new ObjectParameter("sdt", sdt) :
                new ObjectParameter("sdt", typeof(string));
    
            var passParameter = pass != null ?
                new ObjectParameter("pass", pass) :
                new ObjectParameter("pass", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("AddNguoiDung", emailParameter, hoTenParameter, sdtParameter, passParameter);
        }
    
        public virtual int addSanPham(string tenSP, string iDDanhMuc, string idShop, Nullable<int> gia, Nullable<int> sl, string img)
        {
            var tenSPParameter = tenSP != null ?
                new ObjectParameter("tenSP", tenSP) :
                new ObjectParameter("tenSP", typeof(string));
    
            var iDDanhMucParameter = iDDanhMuc != null ?
                new ObjectParameter("IDDanhMuc", iDDanhMuc) :
                new ObjectParameter("IDDanhMuc", typeof(string));
    
            var idShopParameter = idShop != null ?
                new ObjectParameter("idShop", idShop) :
                new ObjectParameter("idShop", typeof(string));
    
            var giaParameter = gia.HasValue ?
                new ObjectParameter("Gia", gia) :
                new ObjectParameter("Gia", typeof(int));
    
            var slParameter = sl.HasValue ?
                new ObjectParameter("sl", sl) :
                new ObjectParameter("sl", typeof(int));
    
            var imgParameter = img != null ?
                new ObjectParameter("img", img) :
                new ObjectParameter("img", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("addSanPham", tenSPParameter, iDDanhMucParameter, idShopParameter, giaParameter, slParameter, imgParameter);
        }
    
        public virtual int AddShop(string ten, string diachi, string img)
        {
            var tenParameter = ten != null ?
                new ObjectParameter("ten", ten) :
                new ObjectParameter("ten", typeof(string));
    
            var diachiParameter = diachi != null ?
                new ObjectParameter("diachi", diachi) :
                new ObjectParameter("diachi", typeof(string));
    
            var imgParameter = img != null ?
                new ObjectParameter("img", img) :
                new ObjectParameter("img", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("AddShop", tenParameter, diachiParameter, imgParameter);
        }
    
        public virtual int addShopforUser(string idND, string idshop)
        {
            var idNDParameter = idND != null ?
                new ObjectParameter("idND", idND) :
                new ObjectParameter("idND", typeof(string));
    
            var idshopParameter = idshop != null ?
                new ObjectParameter("idshop", idshop) :
                new ObjectParameter("idshop", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("addShopforUser", idNDParameter, idshopParameter);
        }
    
        public virtual int danhGiaSP(Nullable<int> danhgia, string maSP)
        {
            var danhgiaParameter = danhgia.HasValue ?
                new ObjectParameter("danhgia", danhgia) :
                new ObjectParameter("danhgia", typeof(int));
    
            var maSPParameter = maSP != null ?
                new ObjectParameter("maSP", maSP) :
                new ObjectParameter("maSP", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("danhGiaSP", danhgiaParameter, maSPParameter);
        }
    
        public virtual ObjectResult<GetSPbyDanhMuc_Result> GetSPbyDanhMuc(string maDM)
        {
            var maDMParameter = maDM != null ?
                new ObjectParameter("maDM", maDM) :
                new ObjectParameter("maDM", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<GetSPbyDanhMuc_Result>("GetSPbyDanhMuc", maDMParameter);
        }
    
        public virtual int updateDiaChiND(string id, string diachi)
        {
            var idParameter = id != null ?
                new ObjectParameter("id", id) :
                new ObjectParameter("id", typeof(string));
    
            var diachiParameter = diachi != null ?
                new ObjectParameter("diachi", diachi) :
                new ObjectParameter("diachi", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("updateDiaChiND", idParameter, diachiParameter);
        }
    
        public virtual int updateImgNguoiDung(string id, string img)
        {
            var idParameter = id != null ?
                new ObjectParameter("id", id) :
                new ObjectParameter("id", typeof(string));
    
            var imgParameter = img != null ?
                new ObjectParameter("img", img) :
                new ObjectParameter("img", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("updateImgNguoiDung", idParameter, imgParameter);
        }
    
        public virtual int updateImgSHOP(string id, string img)
        {
            var idParameter = id != null ?
                new ObjectParameter("id", id) :
                new ObjectParameter("id", typeof(string));
    
            var imgParameter = img != null ?
                new ObjectParameter("img", img) :
                new ObjectParameter("img", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("updateImgSHOP", idParameter, imgParameter);
        }
    }
}
