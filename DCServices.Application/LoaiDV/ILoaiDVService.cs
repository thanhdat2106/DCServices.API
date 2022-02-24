using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using DCServices.Data.Models;
using Microsoft.AspNetCore.Mvc;

namespace DCServices.Services.LoaiDV
{
    public interface ILoaiDVService
    {
        Task<IEnumerable<Data.Models.LoaiDV>> GetAll();
        Task<ActionResult<Data.Models.LoaiDV>> GetByID(int id);
        Task<ActionResult<Data.Models.LoaiDV>> Post(Data.Models.LoaiDV data);
        Task<ActionResult<Data.Models.LoaiDV>> Put(Data.Models.LoaiDV data);
        Task<ActionResult<Data.Models.LoaiDV>> Delete(int id);
    }
}
