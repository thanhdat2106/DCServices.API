using DCServices.Data.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DCServices.Services.HoaDon
{
    public class HoaDonServices : IHoaDonServices
    {
        private readonly DCServicesContext _dbContext;
        public HoaDonServices(DCServicesContext dbcontext)
        {
            _dbContext = dbcontext;
        }
        public async Task<ActionResult<Data.Models.HoaDon>> Delete(int id)
        {
            var empl = _dbContext.HoaDon.Find(id);
            _dbContext.HoaDon.Remove(empl);
            _dbContext.SaveChanges();
            return empl;
        }

        public async Task<IEnumerable<Data.Models.HoaDon>> GetAll()
        {
            return await _dbContext.HoaDon.ToListAsync();
        }
        public async Task<IEnumerable<Data.Models.SalesChart>> chart()
        {
            return await _dbContext.SalesChart.FromSqlRaw("EXEC [dbo].[HoaDon_Month]").ToListAsync();
        }
        public async Task<IEnumerable<Data.Models.Chartmobile>> chartmobile(int id)
        {
            return await _dbContext.Chartmobile.FromSqlRaw("EXEC [dbo].[HoaDonMonth_GetBYMATHO] {0}", id).ToListAsync();
        }
        public async Task<IEnumerable<Data.Models.HoaDonInfo>> GetAllBYID(int id)
        {
            return await _dbContext.HoaDonInfo.FromSqlRaw("EXEC [dbo].[HoaDon_ReadByID] {0}", id).ToListAsync();
        }
        public async Task<IEnumerable<Data.Models.HoaDon>> GetAllBYMATHO(int id)
        {
            return await _dbContext.HoaDon.FromSqlRaw("EXEC [dbo].[HoaDon_ReadByMATHO] {0}", id).ToListAsync();
        }
        public async Task<IEnumerable<Data.Models.HoaDon>> GetAllBYMATHO1(int id)
        {
            return await _dbContext.HoaDon.FromSqlRaw("EXEC [dbo].[HoaDon_ReadByMATHO1] {0}", id).ToListAsync();
        }
        public async Task<ActionResult<Data.Models.HoaDon>> GetByID(int id)
        {
            var empl = await _dbContext.HoaDon.Where(e => e.MaHD == id).SingleOrDefaultAsync();
            return empl;
        }
     
        public async Task<ActionResult<Data.Models.HoaDon>> Post(Data.Models.HoaDon data)
        {
            data.NgayLap = DateTime.Now;
            await _dbContext.HoaDon.AddAsync(data);
            await _dbContext.SaveChangesAsync();
            return data;
        }
        public async Task<ActionResult<Data.Models.HoaDon>> Put(Data.Models.HoaDon data)
        {
            Data.Models.HoaDon objEmp = new Data.Models.HoaDon();
            objEmp = _dbContext.HoaDon.Find(data.MaHD);
            if (objEmp != null)
            {
                //objEmp.MaKH = data.MaKH;
                objEmp.TrangThai= data.TrangThai;
                objEmp.PhiDichVu = data.PhiDichVu;
            }
            this._dbContext.SaveChanges();
            return data;
        }
        public async Task<IEnumerable<Data.Models.HoaDon>> getHDByTrangThai(int maKH, int trangThai)
        {
            return await _dbContext.HoaDon.FromSqlRaw($"EXEC [dbo].[HoaDon_ReadHoaDonByMaKH] {maKH},{trangThai}").ToListAsync();
        }
    }
}
