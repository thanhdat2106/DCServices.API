using DCServices.Data.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DCServices.Services.HopDong
{
    public class HopDongServices : IHopDongServices
    {
        private readonly DCServicesContext _dbContext;
        public HopDongServices(DCServicesContext dbcontext)
        {
            _dbContext = dbcontext;
        }
        public async Task<ActionResult<Data.Models.HopDong>> Delete(int id)
        {
            var empl = _dbContext.HopDong.Find(id);
            _dbContext.HopDong.Remove(empl);
            _dbContext.SaveChanges();
            return empl;
        }

        public async Task<IEnumerable<Data.Models.HopDong>> GetAll()
        {
            return await _dbContext.HopDong.ToListAsync();
        }

        public async Task<ActionResult<Data.Models.HopDong>> GetByID(int id)
        {
            var empl = await _dbContext.HopDong.Where(e => e.MaHopDong == id).SingleOrDefaultAsync();
            return empl;
        }

        public async Task<ActionResult<Data.Models.HopDong>> Post(Data.Models.HopDong data)
        {
            await _dbContext.HopDong.AddAsync(data);
            await _dbContext.SaveChangesAsync();
            return data;
        }
        public async Task<ActionResult<Data.Models.HopDong>> Put(Data.Models.HopDong data)
        {
            Data.Models.HopDong objEmp = new Data.Models.HopDong();
            objEmp = _dbContext.HopDong.Find(data.MaHopDong);
            if (objEmp != null)
            {
                objEmp.MaNV = data.MaNV;
                objEmp.MaTho = data.MaTho;
                objEmp.NgayKiKet = data.NgayKiKet;
                objEmp.NgayBD = data.NgayBD;
                objEmp.NgayKT = data.NgayKT;
            }
            this._dbContext.SaveChanges();
            return data;
        }
    }
}
