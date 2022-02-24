using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace DCServices.Services.HoaDon
{
    public interface IHoaDonServices
    {
        Task<IEnumerable<Data.Models.HoaDon>> GetAll();
        Task<IEnumerable<Data.Models.SalesChart>> chart();
        Task<IEnumerable<Data.Models.Chartmobile>> chartmobile(int id);
        Task<IEnumerable<Data.Models.HoaDonInfo>> GetAllBYID(int id);
        Task<IEnumerable<Data.Models.HoaDon>> GetAllBYMATHO(int id);
        Task<IEnumerable<Data.Models.HoaDon>> GetAllBYMATHO1(int id);
        Task<ActionResult<Data.Models.HoaDon>> GetByID(int id);
        Task<ActionResult<Data.Models.HoaDon>> Post(Data.Models.HoaDon data);
        Task<ActionResult<Data.Models.HoaDon>> Put(Data.Models.HoaDon data);
        Task<ActionResult<Data.Models.HoaDon>> Delete(int id);
        Task<IEnumerable<Data.Models.HoaDon>> getHDByTrangThai(int maKH, int trangThai);
    }
}
