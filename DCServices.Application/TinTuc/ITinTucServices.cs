using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace DCServices.Services.TinTuc
{
    public interface ITinTucServices
    {
        Task<IEnumerable<Data.Models.TinTuc>> GetAll();
        Task<IEnumerable<Data.Models.TinTuc>> GetSix();
        Task<IEnumerable<Data.Models.TinTucLoaiDV>> Get();
        Task<IEnumerable<Data.Models.TinTuc>> GetAllByID(int id);
        Task<ActionResult<Data.Models.TinTuc>> GetByID(int id);
        Task<ActionResult<Data.Models.TinTuc>> Post(Data.Models.TinTuc data);
        Task<ActionResult<Data.Models.TinTuc>> Put(Data.Models.TinTuc data);
        Task<ActionResult<Data.Models.TinTuc>> Delete(int id);
    }
}
