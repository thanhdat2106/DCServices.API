using DCServices.Data.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace DCServices.Services.ChiTietGoiTho
{
    public class ChiTietGoiThoServices : IChiTietGoiThoServices
    {
        private readonly DCServicesContext _dbContext;
        public ChiTietGoiThoServices(DCServicesContext dbcontext)
        {
            _dbContext = dbcontext;
        }
        public async Task<ActionResult<Data.Models.ChiTietGoiTho>> Post(Data.Models.ChiTietGoiTho data)
        {
            await _dbContext.ChiTietGoiTho.AddAsync(data);
            await _dbContext.SaveChangesAsync();
            return data;
        }
        public async Task<IEnumerable<Data.Models.ChiTietGoiTho>> getByMaGT(int maGT)
        {
            return await _dbContext.ChiTietGoiTho.FromSqlRaw($"EXEC [dbo].[ChiTietGoiTho_ReadChiTietGoiThoByMaKH] {maGT}").ToListAsync();
        }
        //public async Task<IEnumerable<Data.Models.ChiTietGoiTho>> getByMaTho(int maGT, int maTho)
        //{
        //    return await _dbContext.ChiTietGoiTho.FromSqlRaw($"EXEC [dbo].[GoiTho_ReadByMaTho] {maTho},{maGT}").ToListAsync();
        //}
    }
}
