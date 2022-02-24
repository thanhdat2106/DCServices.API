using DCServices.Data.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DCServices.Services.TinTuc
{
    public class TinTucServices : ITinTucServices
    {
        private readonly DCServicesContext _dbContext;

        public TinTucServices(DCServicesContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<ActionResult<Data.Models.TinTuc>> Delete(int id)
        {
            var empl = _dbContext.TinTuc.Find(id);
            _dbContext.TinTuc.Remove(empl);
            _dbContext.SaveChanges();
            return empl;
        }

        public async Task<IEnumerable<Data.Models.TinTuc>> GetAll()
        {
            return await _dbContext.TinTuc.ToListAsync();
        }
        public async Task<IEnumerable<Data.Models.TinTuc>> GetSix()
        {
            return await _dbContext.TinTuc.FromSqlRaw("EXEC [dbo].[Post_Read]").ToListAsync();
        }
        public async Task<IEnumerable<Data.Models.TinTucLoaiDV>> Get()
        {
            return await _dbContext.TinTucLoaiDV.FromSqlRaw("EXEC [dbo].[TinTuc_Read]").ToListAsync();
        }
        public async Task<IEnumerable<Data.Models.TinTuc>> GetAllByID(int id)
        {
            var empl = await _dbContext.TinTuc.Where(e => e.MaLoaiDV == id).ToListAsync();
            return empl;
        }
        public async Task<ActionResult<Data.Models.TinTuc>> GetByID(int id)
        {
            var empl = await _dbContext.TinTuc.Where(e => e.MaTT == id).SingleOrDefaultAsync();
            return empl;
        }

        public async Task<ActionResult<Data.Models.TinTuc>> Post(Data.Models.TinTuc data)
        {
            await _dbContext.TinTuc.AddAsync(data);
            await _dbContext.SaveChangesAsync();
            return data;
        }

        public async Task<ActionResult<Data.Models.TinTuc>> Put(Data.Models.TinTuc data)
        {
            Data.Models.TinTuc objEmp = new Data.Models.TinTuc();
            objEmp = _dbContext.TinTuc.Find(data.MaTT);
            if (objEmp != null)
            {
                objEmp.TieuDe = data.TieuDe;
                objEmp.MoTa = data.MoTa;
                objEmp.HinhAnh = data.HinhAnh;
                objEmp.NgayDang = data.NgayDang;
                objEmp.TacGia = data.TacGia;
                objEmp.MaLoaiDV = data.MaLoaiDV;
            }
            this._dbContext.SaveChanges();
            return data;
        }
    }
}
