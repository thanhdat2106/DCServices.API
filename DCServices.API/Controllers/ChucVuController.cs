using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DCServices.Data.Models;
using DCServices.Services.ChucVu;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace DCServices.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ChucVuController : ControllerBase
    {
        private readonly IChucVuServices _api;
        public ChucVuController(IChucVuServices api)
        {
            _api = api;
        }

        [HttpGet]
        public async Task<IEnumerable<ChucVu>> Get()
        {
            return await _api.GetAll();
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<ChucVu>> Get(int id)
        {
            return await _api.GetByID(id);
        }


        [HttpPost]
        public async Task<ActionResult<ChucVu>> Post(ChucVu data)
        {
            await _api.Post(data);
            return Ok(data);
        }
        [HttpPut("{id}")]
        public async Task<ActionResult<ChucVu>> Put(ChucVu data)
        {
            await _api.Put(data);
            return Ok(data);
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult<ChucVu>> Delete(int id)
        {
            await _api.Delete(id);
            return Ok();
        }
    }
}
