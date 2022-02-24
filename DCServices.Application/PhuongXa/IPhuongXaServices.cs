using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace DCServices.Services.PhuongXa
{
    public interface IPhuongXaServices
    {
        Task<IEnumerable<Data.Models.PhuongXa>> GetAll();
        Task<IEnumerable<Data.Models.DiaChi>> GetAllByID(int id);
        Task<IEnumerable<Data.Models.PhuongXa>> GetByID(int id);
    }  
}
