using DCServices.Data.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DCServices.Services.GoiTho
{
   public  class GoiThoServices : IGoiThoServices
    {
        private readonly DCServicesContext _dbContext;
        public GoiThoServices(DCServicesContext dbcontext)
        {
            _dbContext = dbcontext;
        }
        public async Task<IEnumerable<Data.Models.GoiTho>> Delete(int id)
        {
            var empl = _dbContext.GoiTho.Find(id);
            return await _dbContext.GoiTho.FromSqlRaw("EXEC [dbo].[GoiTho_Delete] {0}", id).ToListAsync();
        }
        public async Task<IEnumerable<Data.Models.GoiThoKhachHang>> get()
        {
            return await _dbContext.GoiThoKhachHang.FromSqlRaw("EXEC [dbo].[GoiTho_Read]").ToListAsync();
        }
        public async Task<IEnumerable<Data.Models.GoiThoInfoKH>> getAll(int id)
        {
            return await _dbContext.GoiThoInfoKH.FromSqlRaw("EXEC [dbo].[GoiTho_ReadByMaTho] {0}",id).ToListAsync();
        }
        public async Task<IEnumerable<Data.Models.GoiTho_TT>> GetTTByID(int id)
        {
            var empl = await _dbContext.GoiTho_TT.FromSqlRaw("EXEC [dbo].[GoiTho_GetThongTin] {0}", id).ToListAsync();
            return empl;
        }
        public async Task<IEnumerable<Data.Models.ThoSua>> getByGT(int maGT)
        {
            return await _dbContext.ThoSua.FromSqlRaw($"EXEC [dbo].[GoiTho_GetTho] {maGT}").ToListAsync();
        }
        public async Task<IEnumerable<Data.Models.GoiTho_KH_DV>> GetByID(int id)
        {
            var empl = await _dbContext.GoiTho_KH_DV.FromSqlRaw("EXEC [dbo].[GoiTho_ReadByID] {0}",id).ToListAsync();
            return empl;
        }

        public async Task<ActionResult<Data.Models.GoiTho>> Put(Data.Models.GoiTho data)
        {
            Data.Models.GoiTho objEmp = new Data.Models.GoiTho();
            objEmp = _dbContext.GoiTho.Find(data.MaGT);
            if (objEmp != null)
            {
                objEmp.TrangThai = data.TrangThai;
            }
            this._dbContext.SaveChanges();
            return data;
        }
        public async Task<ActionResult<Data.Models.GoiTho>> Post(Data.Models.GoiTho data)
        {
            data.NgayGoi = DateTime.Now;
            await _dbContext.GoiTho.AddAsync(data);
            await _dbContext.SaveChangesAsync();
            return data;
        }
        public async Task<IEnumerable<Data.Models.GoiTho>> getByMaKH(int maKH, int trangThai)
        {
            return await _dbContext.GoiTho.FromSqlRaw($"EXEC [dbo].[GoiTho_ReadGoiThoByMaKH] {maKH},{trangThai}").ToListAsync();
        }
    }
}
