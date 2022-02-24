using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace DCServices.Services.BangGiaThamKhao
{
    public interface IBangGiaThamKhaoServices 
    {
        Task<IEnumerable<Data.Models.BangGiaThamKhao>> GetAll();
        Task<IEnumerable<Data.Models.BangGiaThamKhao>> GetAllByID(int id);
        Task<ActionResult<Data.Models.BangGiaThamKhao>> GetByID(int id);
        Task<ActionResult<Data.Models.BangGiaThamKhao>> Post(Data.Models.BangGiaThamKhao data);
        Task<ActionResult<Data.Models.BangGiaThamKhao>> Put(Data.Models.BangGiaThamKhao data);
        Task<ActionResult<Data.Models.BangGiaThamKhao>> Delete(int id);
    }
}
