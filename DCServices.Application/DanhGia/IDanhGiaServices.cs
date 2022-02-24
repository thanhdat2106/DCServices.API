using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace DCServices.Services.DanhGia
{
    public interface IDanhGiaServices
    {
        Task<IEnumerable<Data.Models.DanhGia>> GetAll();
        Task<ActionResult<Data.Models.DanhGia>> GetByID(int id);
        Task<ActionResult<Data.Models.DanhGia>> Post(Data.Models.DanhGia data);
        Task<ActionResult<Data.Models.DanhGia>> PutTho(Data.Models.DanhGia data);
        Task<ActionResult<Data.Models.DanhGia>> PutKhachHang(Data.Models.DanhGia data);
        Task<ActionResult<Data.Models.DanhGia>> Delete(int id);
    }
}
