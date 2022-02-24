using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace DCServices.Services.ChiTietHoaDon
{
    public interface IChiTietHoaDonServices
    {
        Task<IEnumerable<Data.Models.ChiTietHoaDon>> GetAll();
        Task<IEnumerable<Data.Models.HoaDonInfoCTHD>> GetHoaDonInfoCTHD(int id);
        //Task<IEnumerable<Data.Models.ChiTietHoaDon>> update();
        Task<IEnumerable<Data.Models.ChiTietHoaDon>> GetByID(int id);
        Task<ActionResult<Data.Models.ChiTietHoaDon>> Post(Data.Models.ChiTietHoaDon data);
        Task<ActionResult<Data.Models.ChiTietHoaDon>> Put(Data.Models.ChiTietHoaDon data);
        Task<ActionResult<Data.Models.ChiTietHoaDon>> Delete(int id);
        Task<IEnumerable<Data.Models.ChiTietHDDATA>> getByMaHD(int maHD);
        Task<IEnumerable<Data.Models.ChiTietHoaDon>> getByMaHD_MaDV(int maHD, int maDV);
    }
}
