using DCServices.Data.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DCServices.Data.Data
{
    public class DCServicesContext: DbContext
    {
        public DCServicesContext() { }
        public DCServicesContext(DbContextOptions<DCServicesContext> options) : base(options)
        {

        }
        public DbSet<LoaiDV> LoaiDV { get; set; }
        public DbSet<DichVu> DichVu { get; set; }
        public DbSet<BangGiaThamKhao> BangGiaThamKhao { get; set; }
        public DbSet<ThoSua> ThoSua { get; set; }
        public DbSet<Tho_DichVu> Tho_DichVu { get; set; }
        public DbSet<ChiTietHoaDon> ChiTietHoaDon { get; set; }
        public DbSet<ChucVu> ChucVu { get; set; }
        public DbSet<DanhGia> DanhGia { get; set; }
        public DbSet<HoaDon> HoaDon { get; set; }
        public DbSet<HopDong> HopDong { get; set; }
        public DbSet<KhachHang> KhachHang { get; set; }
        public DbSet<NhanVien> NhanVien { get; set; }
        public DbSet<TinTuc> TinTuc { get; set; }
        public DbSet<TinTucLoaiDV> TinTucLoaiDV { get; set; }
        public DbSet<PhuongXa> PhuongXa { get; set; }
        public DbSet<QuanHuyen> QuanHuyen { get; set; }
        public DbSet<TinhThanh> TinhThanh { get; set; }
        public DbSet<DiaChi> DiaChi { get; set; }
        public DbSet<ThoInfoDichVu> ThoInfoDichVu { get; set; }
        public DbSet<GoiTho> GoiTho { get; set; }
        public DbSet<GoiTho_KH_DV> GoiTho_KH_DV { get; set; }
        public DbSet<HoaDonInfo> HoaDonInfo { get; set; }
        public DbSet<GoiThoInfoKH> GoiThoInfoKH { get; set; }
        public DbSet<HoaDonInfoThue> HoaDonInfoThue { get; set; }
        public DbSet<ChiTietGoiTho> ChiTietGoiTho { get; set; }
        public DbSet<SalesChart> SalesChart { get; set; }
        public DbSet<HoaDonInfoCTHD> HoaDonInfoCTHD { get; set; }
        public DbSet<Chartmobile> Chartmobile { get; set; }
        public DbSet<ThoSuaData> ThoSuaData { get; set; }
        public DbSet<ChiTietHDDATA> ChiTietHDDATA { get; set; }
        public DbSet<GoiThoKhachHang> GoiThoKhachHang { get; set; }
        public DbSet<GoiTho_TT> GoiTho_TT { get; set; }
    }
}
