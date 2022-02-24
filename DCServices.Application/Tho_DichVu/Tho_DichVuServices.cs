using DCServices.Data.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DCServices.Services.Tho_DichVu
{
    public class Tho_DichVuServices: ITho_DichVuServices
    {
        private readonly DCServicesContext _dbContext;
        public Tho_DichVuServices(DCServicesContext dbcontext)
        {
            _dbContext = dbcontext;
        }

        public async Task<IEnumerable<Data.Models.Tho_DichVu>> GetAll()
        {
            return await _dbContext.Tho_DichVu.ToListAsync();
        }
        public async Task<ActionResult<Data.Models.Tho_DichVu>> Delete(int id)
        {
            var empl = _dbContext.Tho_DichVu.Find(id);
            _dbContext.Tho_DichVu.Remove(empl);
            _dbContext.SaveChanges();
            return empl;
        }
        public async Task<IEnumerable<Data.Models.Tho_DichVu>> GetByID(int matho,int madv)
        {
            var empl = await _dbContext.Tho_DichVu.FromSqlRaw("EXEC Tho_DichVu_Read1 {0},{1}", matho,madv).ToListAsync(); ;
            return empl;
        }
        public async Task<IEnumerable<Data.Models.ThoInfoDichVu>> GetAllByID(int id)
        {
            var empl = await _dbContext.ThoInfoDichVu.FromSqlRaw("EXEC Tho_DichVu_Read {0}",id).ToListAsync();
            return empl;
        }

        public async Task<ActionResult<Data.Models.Tho_DichVu>> Post(Data.Models.Tho_DichVu data)
        {
            await _dbContext.Tho_DichVu.AddAsync(data);
            await _dbContext.SaveChangesAsync();
            return data;
        }

        //public async Task<ActionResult<Data.Models.NhanVien>> Put(Data.Models.NhanVien data)
        //{
        //    Data.Models.NhanVien objEmp = new Data.Models.NhanVien();
        //    objEmp = _dbContext.NhanVien.Find(data.MaNV);
        //    if (objEmp != null)
        //    {
        //        objEmp.TenNV = data.TenNV;
        //        objEmp.CMND = data.CMND;
        //        objEmp.SDT = data.SDT;
        //        objEmp.DiaChi = data.DiaChi;
        //        objEmp.Anh = data.Anh;
        //        objEmp.NgaySinh = data.NgaySinh;
        //        objEmp.GioiTinh = data.GioiTinh;
        //        objEmp.NgayVL = data.NgayVL;
        //        objEmp.Luong = data.Luong;
        //        objEmp.Email = data.Email;
        //        objEmp.Password = data.Password;

        //    }
        //    this._dbContext.SaveChanges();
        //    return data;
        //}
    }
}
