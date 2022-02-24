using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace DCServices.Services.GoiTho
{
    public interface IGoiThoServices
    {
        Task<IEnumerable<Data.Models.GoiThoKhachHang>> get();
        Task<IEnumerable<Data.Models.GoiThoInfoKH>> getAll(int id);
        Task<IEnumerable<Data.Models.GoiTho_KH_DV>> GetByID(int id);
        Task<IEnumerable<Data.Models.GoiTho_TT>>GetTTByID(int id);
        //Task<ActionResult<Data.Models.GoiTho>> ReadByID(int id);
        Task<ActionResult<Data.Models.GoiTho>> Post(Data.Models.GoiTho data);
        Task<IEnumerable<Data.Models.ThoSua>> getByGT(int maGT);
        Task<IEnumerable<Data.Models.GoiTho>> Delete(int id);
        Task<IEnumerable<Data.Models.GoiTho>> getByMaKH(int maKH, int trangThai);
        Task<ActionResult<Data.Models.GoiTho>> Put(Data.Models.GoiTho data);
    }
}
