using DCServices.Data.Data;
using DCServices.Data.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DCServices.Services.PhuongXa
{
    public class PhuongXaServices : IPhuongXaServices
    {
        private readonly DCServicesContext _dbContext;
        public PhuongXaServices(DCServicesContext dbcontext)
        {
            _dbContext = dbcontext;
        }

        public async Task<IEnumerable<Data.Models.PhuongXa>> GetAll()
        {
            return await _dbContext.PhuongXa.ToListAsync();
        }
        public async Task<IEnumerable<Data.Models.DiaChi>> GetAllByID(int id)
        {
            var empl = await _dbContext.DiaChi.FromSqlRaw("EXEC [dbo].[PhuongXa_Read] {0}",id).ToListAsync();
            return (IEnumerable<DiaChi>)empl;
        }
        public async Task<IEnumerable<Data.Models.PhuongXa>> GetByID(int id)
        {
            var empl = await _dbContext.PhuongXa.Where(e => e.MaQH == id).ToListAsync();
            return empl;
        }
    }
}
