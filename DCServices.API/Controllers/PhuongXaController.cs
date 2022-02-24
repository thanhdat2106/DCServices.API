using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DCServices.Data.Models;
using DCServices.Services.PhuongXa;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace DCServices.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PhuongXaController : ControllerBase
    {
        private readonly IPhuongXaServices _api;
        public PhuongXaController(IPhuongXaServices api)
        {
            _api = api;
        }
        // GET: api/<DichVuController>
        [HttpGet]
        public async Task<IEnumerable<PhuongXa>> GetAll()
        {
            return await _api.GetAll();
        }

        // GET api/<DichVuController>/5
        [HttpGet("{id}")]
        public async Task<IEnumerable<PhuongXa>> Get(int id)
        {
            return await _api.GetByID(id);
        }
        [HttpGet("GetAllByID/{id}")]
        public async Task<IEnumerable<Data.Models.DiaChi>> GetAllByID(int id)
        {
            return await _api.GetAllByID(id);
        }
    }
}
