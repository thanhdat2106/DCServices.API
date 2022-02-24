using DCServices.Data.Data;
using DCServices.Data.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DCServices.Services.ThoSua
{
    public class ThoSuaServices : IThoSuaServices
    {
        private readonly DCServicesContext _dbContext;

        public ThoSuaServices(DCServicesContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<ActionResult<Data.Models.ThoSua>> Delete(int id)
        {
            var empl = _dbContext.ThoSua.Find(id);
            _dbContext.ThoSua.Remove(empl);
            _dbContext.SaveChanges();
            return empl;
        }

        public async Task<IEnumerable<Data.Models.ThoSua>> GetAll()
        {
            return await _dbContext.ThoSua.ToListAsync();
        }

        public async Task<ActionResult<Data.Models.ThoSua>> GetByID(int id)
        {
            var empl = await _dbContext.ThoSua.Where(e => e.MaTho == id).SingleOrDefaultAsync();
            return empl;
        }
        public async Task<ActionResult<Data.Models.ThoSua>> GetEmail(string email)
        {
            var empl = await _dbContext.ThoSua.Where(e => e.Email == email).SingleOrDefaultAsync();
            return empl;
        }
        public async Task<ActionResult<Data.Models.ThoSua>> GetSDT(string sdt)
        {
            var empl = await _dbContext.ThoSua.Where(e => e.SDT == sdt).SingleOrDefaultAsync();
            return empl;
        }

        public async Task<ActionResult<Data.Models.ThoSua>> Post(Data.Models.ThoSua data)
        {
           
            await _dbContext.ThoSua.AddAsync(data);
            await _dbContext.SaveChangesAsync();
            return data;
        }

        public async Task<ActionResult<Data.Models.ThoSua>> Put(Data.Models.ThoSua data)
        {
            Data.Models.ThoSua objEmp = new Data.Models.ThoSua();
            objEmp = _dbContext.ThoSua.Find(data.MaTho);
            if (objEmp != null)
            {
                objEmp.TenTho = data.TenTho;
                objEmp.MaPX = data.MaPX;
                objEmp.SoNha = data.SoNha;
                objEmp.SDT = data.SDT;
                objEmp.NgaySinh = data.NgaySinh;
                objEmp.DiemDanhGia = data.DiemDanhGia;
                objEmp.Anh = data.Anh;
                objEmp.Email = data.Email;
                objEmp.Active = data.Active;
                objEmp.Password = data.Password;
                objEmp.SoTaiKhoan = data.SoTaiKhoan;
                objEmp.SoDu = data.SoDu;
                objEmp.LoaiTho = data.LoaiTho;
            }
            this._dbContext.SaveChanges();
            return data;
        }
        public async Task<IEnumerable<Data.Models.ThoSuaData>> getThoSuaByListDV(string listDV)
        {
            return await _dbContext.ThoSuaData.FromSqlRaw($"EXEC [dbo].[GetListTho] {listDV}").ToListAsync();
        }

    }
}
