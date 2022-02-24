using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace DCServices.Services.NhanVien
{
    public interface INhanVienServices
    {
        Task<IEnumerable<Data.Models.NhanVien>> GetAll();
        Task<ActionResult<Data.Models.NhanVien>> GetByID(int id);
        Task<ActionResult<Data.Models.NhanVien>> Post(Data.Models.NhanVien data);
        Task<ActionResult<Data.Models.NhanVien>> Put(Data.Models.NhanVien data);
        Task<ActionResult<Data.Models.NhanVien>> Delete(int id);
    }
}
