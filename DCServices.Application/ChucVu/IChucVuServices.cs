using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace DCServices.Services.ChucVu
{
    public interface IChucVuServices
    {
        Task<IEnumerable<Data.Models.ChucVu>> GetAll();
        Task<ActionResult<Data.Models.ChucVu>> GetByID(int id);
        Task<ActionResult<Data.Models.ChucVu>> Post(Data.Models.ChucVu data);
        Task<ActionResult<Data.Models.ChucVu>> Put(Data.Models.ChucVu data);
        Task<ActionResult<Data.Models.ChucVu>> Delete(int id);
    }
}
