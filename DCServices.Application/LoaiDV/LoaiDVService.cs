using DCServices.Services.LoaiDV;
using DCServices.Data.Data;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using System.Data.SqlClient;
using System.Linq;

namespace DCServices.Services.LoaiDV
{
    public class LoaiDVService : ILoaiDVService
    {
        private readonly DCServicesContext _dbContext;

        public LoaiDVService(DCServicesContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<ActionResult<Data.Models.LoaiDV>> Delete(int id)
        {
            var empl = _dbContext.LoaiDV.Find(id);
            _dbContext.LoaiDV.Remove(empl);
            _dbContext.SaveChanges();
            return empl;
        }

        public async Task<IEnumerable<Data.Models.LoaiDV>> GetAll()
        {
            return await _dbContext.LoaiDV.ToListAsync();
        }

        public async Task<ActionResult<Data.Models.LoaiDV>> GetByID(int id)
        {
            var empl = await _dbContext.LoaiDV.Where(e => e.MaLoaiDV == id).SingleOrDefaultAsync();
            return empl;
        }

        public async Task<ActionResult<Data.Models.LoaiDV>> Post(Data.Models.LoaiDV data)
        {
            await  _dbContext.LoaiDV.AddAsync(data);
            await _dbContext.SaveChangesAsync();
            return data;
        }

        public async Task<ActionResult<Data.Models.LoaiDV>> Put(Data.Models.LoaiDV data)
        {
            Data.Models.LoaiDV objEmp = new Data.Models.LoaiDV();
            objEmp = _dbContext.LoaiDV.Find(data.MaLoaiDV);
            if (objEmp != null)
            {
                objEmp.TenLoaiDV = data.TenLoaiDV;
              
            }
            this._dbContext.SaveChanges();
            return data;
        }
    }
}
