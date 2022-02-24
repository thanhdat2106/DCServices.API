using DCServices.Data.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DCServices.Services.BangGiaThamKhao
{
    public class BangGiaThamKhaoServices : IBangGiaThamKhaoServices
    {
        private readonly DCServicesContext _dbContext;
        public BangGiaThamKhaoServices (DCServicesContext dbcontext)
        {
            _dbContext = dbcontext;
        }
        public async Task<ActionResult<Data.Models.BangGiaThamKhao>> Delete(int id)
        {
            var empl = _dbContext.BangGiaThamKhao.Find(id);
            _dbContext.BangGiaThamKhao.Remove(empl);
            _dbContext.SaveChanges();
            return empl;
        }

        public async Task<IEnumerable<Data.Models.BangGiaThamKhao>> GetAll()
        {
            return await _dbContext.BangGiaThamKhao.ToListAsync();
        }
        public async Task<IEnumerable<Data.Models.BangGiaThamKhao>> GetAllByID(int id)
        {
            var empl = await _dbContext.BangGiaThamKhao.Where(e => e.MaDV == id).ToListAsync();
            return empl;
        }

        public async Task<ActionResult<Data.Models.BangGiaThamKhao>> GetByID(int id)
        {
            var empl = await _dbContext.BangGiaThamKhao.Where(e => e.MaGiaThamKhao == id).SingleOrDefaultAsync();
            return empl;
        }

        public async Task<ActionResult<Data.Models.BangGiaThamKhao>> Post(Data.Models.BangGiaThamKhao data)
        {
            await _dbContext.BangGiaThamKhao.AddAsync(data);
            await _dbContext.SaveChangesAsync();
            return data;
        }

        public async Task<ActionResult<Data.Models.BangGiaThamKhao>> Put(Data.Models.BangGiaThamKhao data)
        {
            Data.Models.BangGiaThamKhao objEmp = new Data.Models.BangGiaThamKhao();
            objEmp = _dbContext.BangGiaThamKhao.Find(data.MaGiaThamKhao);
            if (objEmp != null)
            {
                objEmp.MaDV = data.MaDV;
                objEmp.MoTa = data.MoTa;
                objEmp.GiaCaoNhat = data.GiaCaoNhat;
                objEmp.GiaThapNhat = data.GiaThapNhat;
            }
            this._dbContext.SaveChanges();
            return data;
        }


    }
}
