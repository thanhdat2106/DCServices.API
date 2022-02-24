using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace DCServices.Services.KhachHang
{
    public interface IKhachHangServices
    {
        Task<IEnumerable<Data.Models.KhachHang>> GetAll();
        Task<ActionResult<Data.Models.KhachHang>> GetByID(int id);
        Task<ActionResult<Data.Models.KhachHang>> Post(Data.Models.KhachHang data);
        Task<ActionResult<Data.Models.KhachHang>> Put(Data.Models.KhachHang data);
        Task<ActionResult<Data.Models.KhachHang>> Delete(int id);
    }
}
