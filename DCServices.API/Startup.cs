using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DCServices.Services.DichVu;
using DCServices.Services.LoaiDV;
using DCServices.Data.Data;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using DCServices.Data.Models;
using DCServices.Services.BangGiaThamKhao;
using DCServices.Services.Tho_DichVu;
using DCServices.Services.ChiTietHoaDon;
using DCServices.Services.ChucVu;
using DCServices.Services.DanhGia;
using DCServices.Services.HoaDon;
using DCServices.Services.HopDong;
using DCServices.Services.KhachHang;
using DCServices.Services.NhanVien;
using DCServices.Services.ThoSua;
using DCServices.Services.TinTuc;
using DCServices.Services.PhuongXa;
using DCServices.Services.QuanHuyen;
using DCServices.Services.TinhThanh;
using DCServices.Services.GoiTho;
using DCServices.Services.ChiTietGoiTho;

namespace DCServices.API
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddDbContext<DCServicesContext>(options => options.UseSqlServer(Configuration.GetConnectionString("MbkDbConstr")));
            services.AddAuthorization();
            services.AddCors(options =>
            {
                options.AddPolicy(name: "AllCors", builder =>
                {
                    builder.WithOrigins("http://localhost:4200")
                    .AllowAnyHeader()
                    .AllowAnyOrigin()
                    .AllowAnyMethod();
                });
            });
            services.AddTransient<ILoaiDVService, LoaiDVService>();
            services.AddTransient<IDichVuServices, DichVuServices>();
            services.AddTransient<IBangGiaThamKhaoServices, BangGiaThamKhaoServices>();
            services.AddTransient<ITho_DichVuServices, Tho_DichVuServices>();
            services.AddTransient<IChiTietHoaDonServices, ChiTietHoaDonServices>();
            services.AddTransient<IChucVuServices, ChucVuServices>();
            services.AddTransient<IDanhGiaServices, DanhGiaServices>();
            services.AddTransient<IHoaDonServices, HoaDonServices>();
            services.AddTransient<IHopDongServices, HopDongServices>();
            services.AddTransient<IKhachHangServices, KhachHangServices>();
            services.AddTransient<INhanVienServices, NhanVienServices>();
            services.AddTransient<IThoSuaServices, ThoSuaServices>();
            services.AddTransient<ITinTucServices, TinTucServices>();
            services.AddTransient<IPhuongXaServices, PhuongXaServices>();
            services.AddTransient<IQuanHuyenServices, QuanHuyenServices>();
            services.AddTransient<ITinhThanhServices, TinhThanhServices>();
            services.AddTransient<IGoiThoServices, GoiThoServices>();
            services.AddTransient<IChiTietGoiThoServices, ChiTietGoiThoServices>();
            services.AddControllersWithViews();

        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseHttpsRedirection();

            app.UseRouting();

            app.UseCors("AllCors");

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
