using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace DCServices.Services.HopDong
{
    public interface IHopDongServices
    {
        Task<IEnumerable<Data.Models.HopDong>> GetAll();
        Task<ActionResult<Data.Models.HopDong>> GetByID(int id);
        Task<ActionResult<Data.Models.HopDong>> Post(Data.Models.HopDong data);
        Task<ActionResult<Data.Models.HopDong>> Put(Data.Models.HopDong data);
        Task<ActionResult<Data.Models.HopDong>> Delete(int id);
    }
}
