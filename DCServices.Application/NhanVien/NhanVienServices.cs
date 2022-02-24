using DCServices.Data.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DCServices.Services.NhanVien
{
    public class NhanVienServices: INhanVienServices
    {
        private readonly DCServicesContext _dbContext;

        public NhanVienServices(DCServicesContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<ActionResult<Data.Models.NhanVien>> Delete(int id)
        {
            var empl = _dbContext.NhanVien.Find(id);
            _dbContext.NhanVien.Remove(empl);
            _dbContext.SaveChanges();
            return empl;
        }

        public async Task<IEnumerable<Data.Models.NhanVien>> GetAll()
        {
            return await _dbContext.NhanVien.ToListAsync();
        }

        public async Task<ActionResult<Data.Models.NhanVien>> GetByID(int id)
        {
            var empl = await _dbContext.NhanVien.Where(e => e.MaNV == id).SingleOrDefaultAsync();
            return empl;
        }

        public async Task<ActionResult<Data.Models.NhanVien>> Post(Data.Models.NhanVien data)
        {
            await _dbContext.NhanVien.AddAsync(data);
            await _dbContext.SaveChangesAsync();
            return data;
        }

        public async Task<ActionResult<Data.Models.NhanVien>> Put(Data.Models.NhanVien data)
        {
            Data.Models.NhanVien objEmp = new Data.Models.NhanVien();
            objEmp = _dbContext.NhanVien.Find(data.MaNV);
            if (objEmp != null)
            {
                objEmp.MaCV = data.MaCV;
                objEmp.TenNV = data.TenNV;
                objEmp.CMND = data.CMND;
                objEmp.SDT = data.SDT;
                objEmp.MaPX = data.MaPX;
                objEmp.SoNha = data.SoNha;
                objEmp.Anh = data.Anh;
                objEmp.NgaySinh = data.NgaySinh;
                objEmp.GioiTinh = data.GioiTinh;
                objEmp.NgayVL = data.NgayVL;
                objEmp.Luong = data.Luong;
                objEmp.Email = data.Email;
                objEmp.Password = data.Password;

            }
            this._dbContext.SaveChanges();
            return data;
        }
    }
}
