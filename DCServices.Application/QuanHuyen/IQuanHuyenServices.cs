using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace DCServices.Services.QuanHuyen
{
    public interface IQuanHuyenServices
    {
        Task<IEnumerable<Data.Models.QuanHuyen>> GetAll();
        Task<IEnumerable<Data.Models.QuanHuyen>> GetByID(int id);
    }
}
