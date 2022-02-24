using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace DCServices.Services.TinhThanh
{
    public interface ITinhThanhServices
    {
        Task<IEnumerable<Data.Models.TinhThanh>> GetAll();
        Task<ActionResult<Data.Models.TinhThanh>> GetByID(int id);
    }
}
