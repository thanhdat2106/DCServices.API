using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace DCServices.Services.DichVu
{
    public interface IDichVuServices
    {
        Task<IEnumerable<Data.Models.DichVu>> getAll();
        Task<IEnumerable<Data.Models.DichVu>> get();
        Task<IEnumerable<Data.Models.DichVu>> GetByIDDV(int id);
        Task<ActionResult<Data.Models.DichVu>> GetByID(int id);
        Task<ActionResult<Data.Models.DichVu>> Post(Data.Models.DichVu data);
        Task<ActionResult<Data.Models.DichVu>> Put(Data.Models.DichVu data);
        Task<ActionResult<Data.Models.DichVu>> Delete(int id);
        Task<IEnumerable<Data.Models.DichVu>> getByMaDVs(string s);
    }
}
