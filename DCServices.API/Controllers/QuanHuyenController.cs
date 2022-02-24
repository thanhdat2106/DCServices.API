using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DCServices.Data.Models;
using DCServices.Services.QuanHuyen;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace DCServices.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class QuanHuyenController : ControllerBase
    {
        private readonly IQuanHuyenServices _api;
        public QuanHuyenController(IQuanHuyenServices api)
        {
            _api = api;
        }
        // GET: api/<DichVuController>
        [HttpGet]
        public async Task<IEnumerable<QuanHuyen>> GetAll()
        {
            return await _api.GetAll();
        }

        // GET api/<DichVuController>/5
        [HttpGet("{id}")]
        public async Task<IEnumerable<QuanHuyen>> Get(int id)
        {
            return await _api.GetByID(id);
        }
    }
}
