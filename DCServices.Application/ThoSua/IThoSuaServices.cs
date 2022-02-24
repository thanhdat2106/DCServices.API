using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace DCServices.Services.ThoSua
{
    public interface IThoSuaServices
    {
        Task<IEnumerable<Data.Models.ThoSua>> GetAll();
        Task<ActionResult<Data.Models.ThoSua>> GetByID(int id);
        Task<ActionResult<Data.Models.ThoSua>> GetEmail(string email);
        Task<ActionResult<Data.Models.ThoSua>> GetSDT(string sdt);
        Task<ActionResult<Data.Models.ThoSua>> Post(Data.Models.ThoSua data);
        Task<ActionResult<Data.Models.ThoSua>> Put(Data.Models.ThoSua data);
        Task<ActionResult<Data.Models.ThoSua>> Delete(int id);
        Task<IEnumerable<Data.Models.ThoSuaData>> getThoSuaByListDV(string listDV);
    }
}
