using DCServices.Data.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DCServices.Services.ChiTietHoaDon
{
    public class ChiTietHoaDonServices : IChiTietHoaDonServices
    {
        private readonly DCServicesContext _dbContext;
        public ChiTietHoaDonServices(DCServicesContext dbcontext)
        {
            _dbContext = dbcontext;
        }
        public async Task<ActionResult<Data.Models.ChiTietHoaDon>> Delete(int id)
        {
            var empl = _dbContext.ChiTietHoaDon.Find(id);
            _dbContext.ChiTietHoaDon.Remove(empl);
            _dbContext.SaveChanges();
            return empl;
        }

        public async Task<IEnumerable<Data.Models.ChiTietHoaDon>> GetAll()
        {
            return await _dbContext.ChiTietHoaDon.ToListAsync();
        }
        public async Task<IEnumerable<Data.Models.HoaDonInfoCTHD>> GetHoaDonInfoCTHD(int id)
        {
            return await _dbContext.HoaDonInfoCTHD.FromSqlRaw("EXEC [dbo].[GetHoaDonInfoCTHD] {0}", id).ToListAsync();
        }
        public async Task<IEnumerable<Data.Models.ChiTietHoaDon>> GetByID(int id)
        {
            var empl = await _dbContext.ChiTietHoaDon.Where(e => e.MaHD == id).ToListAsync();
            return empl;
        }

        public async Task<ActionResult<Data.Models.ChiTietHoaDon>> Post(Data.Models.ChiTietHoaDon data)
        {
            await _dbContext.ChiTietHoaDon.AddAsync(data);
            await _dbContext.SaveChangesAsync();
            return data;
        }
        public async Task<ActionResult<Data.Models.ChiTietHoaDon>> Put(Data.Models.ChiTietHoaDon data)
        {
            //Data.Models.ChiTietHoaDon objEmp = new Data.Models.ChiTietHoaDon();
            //objEmp = await _dbContext.ChiTietHoaDon.Where(e => e.MaHD == data.MaHD && e.MaDV == data.MaDV).SingleOrDefaultAsync();
            //if (objEmp != null)
            //{

            //    objEmp.ThanhTien = data.ThanhTien;
            //}
            var empt= await _dbContext.ChiTietHoaDon.FromSqlRaw("EXEC [dbo].[CTHOADON_Update] {0},{1},{2},{3}", data.MaHD, data.MaDV, data.ThanhTien,data.HanBaoHanh).ToListAsync();
            //this._dbContext.SaveChanges();
            return data;
        }
        public async Task<IEnumerable<Data.Models.ChiTietHDDATA>> getByMaHD(int maHD)
        {
            var a = await _dbContext.ChiTietHDDATA.FromSqlRaw($"EXEC [dbo].[ChiTietGoiTho_ReadByMaHD] {maHD}").ToListAsync();
            return a;
        }
        public async Task<IEnumerable<Data.Models.ChiTietHoaDon>> getByMaHD_MaDV(int maHD, int maDV)
        {
            var a = await _dbContext.ChiTietHoaDon.FromSqlRaw($"EXEC [dbo].[ChiTietHoaDon_ReadByMaHD_MaDV] {maHD},{maDV}").ToListAsync();
            return a;
        }

    }
}
