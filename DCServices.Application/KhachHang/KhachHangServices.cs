using DCServices.Data.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DCServices.Services.KhachHang
{
    public class KhachHangServices : IKhachHangServices
    {
        private readonly DCServicesContext _dbContext;
        public KhachHangServices(DCServicesContext dbcontext)
        {
            _dbContext = dbcontext;
        }
        public async Task<ActionResult<Data.Models.KhachHang>> Delete(int id)
        {
            var empl = _dbContext.KhachHang.Find(id);
            _dbContext.KhachHang.Remove(empl);
            _dbContext.SaveChanges();
            return empl;
        }

        public async Task<IEnumerable<Data.Models.KhachHang>> GetAll()
        {
            return await _dbContext.KhachHang.ToListAsync();
        }

        public async Task<ActionResult<Data.Models.KhachHang>> GetByID(int id)
        {
            var empl = await _dbContext.KhachHang.Where(e => e.MaKH == id).SingleOrDefaultAsync();
            return empl;
        }

        public async Task<ActionResult<Data.Models.KhachHang>> Post(Data.Models.KhachHang data)
        {
            await _dbContext.KhachHang.AddAsync(data);
            await _dbContext.SaveChangesAsync();
            return data;
        }
        public async Task<ActionResult<Data.Models.KhachHang>> Put(Data.Models.KhachHang data)
        {
            Data.Models.KhachHang objEmp = new Data.Models.KhachHang();
            objEmp = _dbContext.KhachHang.Find(data.MaKH);
            if (objEmp != null)
            {
                objEmp.TenKH = data.TenKH;
                objEmp.SDT = data.SDT;
                objEmp.Password = data.Password;
                objEmp.Email = data.Email;
                objEmp.DiemTichLuy = data.DiemTichLuy;
                objEmp.DiemDanhGia = data.DiemDanhGia;
                objEmp.MaPX = data.MaPX;
                objEmp.SoNha = data.SoNha;
                objEmp.Anh = data.Anh;
            }
            this._dbContext.SaveChanges();
            return data;
        }
    }
}
