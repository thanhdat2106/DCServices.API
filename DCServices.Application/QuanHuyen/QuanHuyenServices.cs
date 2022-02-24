using DCServices.Data.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DCServices.Services.QuanHuyen
{
    public class QuanHuyenServices : IQuanHuyenServices
    {
        private readonly DCServicesContext _dbContext;
        public QuanHuyenServices(DCServicesContext dbcontext)
        {
            _dbContext = dbcontext;
        }

        public async Task<IEnumerable<Data.Models.QuanHuyen>> GetAll()
        {
            return await _dbContext.QuanHuyen.ToListAsync();
        }
        public async Task<IEnumerable<Data.Models.QuanHuyen>> GetByID(int id)
        {
            var empl = await _dbContext.QuanHuyen.Where(e => e.MaTinh == id).ToListAsync();
            return empl;
        }
    }
}
