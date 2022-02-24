using DCServices.Data.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DCServices.Services.ChucVu
{
    public class ChucVuServices : IChucVuServices
    {
        private readonly DCServicesContext _dbContext;
        public ChucVuServices(DCServicesContext dbcontext)
        {
            _dbContext = dbcontext;
        }
        public async Task<ActionResult<Data.Models.ChucVu>> Delete(int id)
        {
            var empl = _dbContext.ChucVu.Find(id);
            _dbContext.ChucVu.Remove(empl);
            _dbContext.SaveChanges();
            return empl;
        }

        public async Task<IEnumerable<Data.Models.ChucVu>> GetAll()
        {
            return await _dbContext.ChucVu.ToListAsync();
        }

        public async Task<ActionResult<Data.Models.ChucVu>> GetByID(int id)
        {
            var empl = await _dbContext.ChucVu.Where(e => e.MaCV == id).SingleOrDefaultAsync();
            return empl;
        }

        public async Task<ActionResult<Data.Models.ChucVu>> Post(Data.Models.ChucVu data)
        {
            await _dbContext.ChucVu.AddAsync(data);
            await _dbContext.SaveChangesAsync();
            return data;
        }
        public async Task<ActionResult<Data.Models.ChucVu>> Put(Data.Models.ChucVu data)
        {
            Data.Models.ChucVu objEmp = new Data.Models.ChucVu();
            objEmp = _dbContext.ChucVu.Find(data.MaCV);
            if (objEmp != null)
            {
                objEmp.TenCV = data.TenCV;
            }
            this._dbContext.SaveChanges();
            return data;
        }
    }
    }
