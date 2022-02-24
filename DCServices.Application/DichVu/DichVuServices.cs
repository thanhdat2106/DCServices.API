using DCServices.Data.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DCServices.Services.DichVu
{
    public class DichVuServices: IDichVuServices
    {
        private readonly DCServicesContext _dbContext;
        public DichVuServices(DCServicesContext dbcontext)
        {
            _dbContext = dbcontext;
        }

        public async Task<ActionResult<Data.Models.DichVu>> Delete(int id)
        {
            var empl = _dbContext.DichVu.Find(id);
            _dbContext.DichVu.Remove(empl);
            _dbContext.SaveChanges();
            return empl;
        }
        public async Task<IEnumerable<Data.Models.DichVu>> getByMaDVs(string s)
        {
            return await _dbContext.DichVu.FromSqlRaw($"EXEC [dbo].[DichVu_ReadByMaDVs] {s}").ToListAsync(); ;
        }

        public async Task<IEnumerable<Data.Models.DichVu>> getAll()
        {
            return await _dbContext.DichVu.ToListAsync();
        }
        public async Task<IEnumerable<Data.Models.DichVu>> get()
        {
            return await _dbContext.DichVu.FromSqlRaw("EXEC [dbo].[DichVu_BangGia_Read]").ToListAsync(); ;
        }

        public async Task<IEnumerable<Data.Models.DichVu>> GetByIDDV(int id)
        {
            var empl = await _dbContext.DichVu.Where(e => e.MaLoaiDV == id).ToListAsync();
            return empl;
        }
        public async Task<ActionResult<Data.Models.DichVu>> GetByID(int id)
        {
            var empl = await _dbContext.DichVu.Where(e => e.MaDV == id).SingleOrDefaultAsync();
            return empl;
        }

        public async Task<ActionResult<Data.Models.DichVu>> Post(Data.Models.DichVu data)
        {
            await _dbContext.DichVu.AddAsync(data);
            await _dbContext.SaveChangesAsync();
            return data;
        }

        public async Task<ActionResult<Data.Models.DichVu>> Put(Data.Models.DichVu data)
        {
            Data.Models.DichVu objEmp = new Data.Models.DichVu();
            objEmp = _dbContext.DichVu.Find(data.MaDV);
            if (objEmp != null)
            {
                objEmp.TenDV = data.TenDV;
                objEmp.MaLoaiDV = data.MaLoaiDV;
            }
            this._dbContext.SaveChanges();
            return data;
        }


    }
}
