using DCServices.Data.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DCServices.Services.TinhThanh
{
    public class TinhThanhServices : ITinhThanhServices
    {
        private readonly DCServicesContext _dbContext;
        public TinhThanhServices(DCServicesContext dbcontext)
        {
            _dbContext = dbcontext;
        }

        public async Task<IEnumerable<Data.Models.TinhThanh>> GetAll()
        {
            return await _dbContext.TinhThanh.ToListAsync();
        }
        public async Task<ActionResult<Data.Models.TinhThanh>> GetByID(int id)
        {
            var empl = await _dbContext.TinhThanh.Where(e => e.MaTinh == id).SingleOrDefaultAsync();
            return empl;
        }
    }
}
