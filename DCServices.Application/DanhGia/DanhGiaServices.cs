using DCServices.Data.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DCServices.Services.DanhGia
{
    public class DanhGiaServices : IDanhGiaServices
    {
        private readonly DCServicesContext _dbContext;
        public DanhGiaServices(DCServicesContext dbcontext)
        {
            _dbContext = dbcontext;
        }
        public async Task<ActionResult<Data.Models.DanhGia>> Delete(int id)
        {
            var empl = _dbContext.DanhGia.Find(id);
            _dbContext.DanhGia.Remove(empl);
            _dbContext.SaveChanges();
            return empl;
        }

        public async Task<IEnumerable<Data.Models.DanhGia>> GetAll()
        {
            return await _dbContext.DanhGia.ToListAsync();
        }

        public async Task<ActionResult<Data.Models.DanhGia>> GetByID(int id)
        {
            var empl = await _dbContext.DanhGia.Where(e => e.MaHD == id).SingleOrDefaultAsync();
            return empl;
        }

        public async Task<ActionResult<Data.Models.DanhGia>> Post(Data.Models.DanhGia data)
        {
            await _dbContext.DanhGia.AddAsync(data);
            await _dbContext.SaveChangesAsync();
            return data;
        }
        public async Task<ActionResult<Data.Models.DanhGia>> PutTho(Data.Models.DanhGia data)
        {
            Data.Models.DanhGia objEmp = new Data.Models.DanhGia();
            objEmp = _dbContext.DanhGia.Where(e => e.MaHD == data.MaHD).SingleOrDefault();
            if (objEmp != null)
            {
                objEmp.MaHD = data.MaHD;
                objEmp.DiemDGTho = data.DiemDGTho;
                objEmp.NhanXetTho = data.NhanXetTho;
            }
            this._dbContext.SaveChanges();
            return data;
        }
        public async Task<ActionResult<Data.Models.DanhGia>> PutKhachHang(Data.Models.DanhGia data)
        {
            Data.Models.DanhGia objEmp = new Data.Models.DanhGia();
            objEmp = _dbContext.DanhGia.Where(e => e.MaHD == data.MaHD).SingleOrDefault();
            if (objEmp != null)
            {
                objEmp.MaHD = data.MaHD;
                objEmp.DiemDGKhachHang = data.DiemDGKhachHang;
                objEmp.NhanXetKhachHang = data.NhanXetKhachHang;
            }
            this._dbContext.SaveChanges();
            return data;
        }
    }
}
