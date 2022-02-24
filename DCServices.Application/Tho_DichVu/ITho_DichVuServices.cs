using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace DCServices.Services.Tho_DichVu
{
    public interface ITho_DichVuServices
    {
        Task<IEnumerable<Data.Models.Tho_DichVu>> GetAll();
        Task<IEnumerable<Data.Models.Tho_DichVu>> GetByID(int id, int ma);
        Task<IEnumerable<Data.Models.ThoInfoDichVu>> GetAllByID(int id);
        Task<ActionResult<Data.Models.Tho_DichVu>> Post(Data.Models.Tho_DichVu data);
        //Task<ActionResult<Data.Models.Tho_DichVu>> Put(Data.Models.Tho_DichVu data);
        Task<ActionResult<Data.Models.Tho_DichVu>> Delete(int id);
    }
}
