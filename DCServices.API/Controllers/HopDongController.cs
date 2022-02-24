using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DCServices.Data.Models;
using DCServices.Services.HopDong;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace DCServices.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HopDongController : ControllerBase
    {
        private readonly IHopDongServices _api;
        public HopDongController(IHopDongServices api)
        {
            _api = api;
        }
        // GET: api/<DichVuController>
        [HttpGet]
        public async Task<IEnumerable<HopDong>> GetAll()
        {
            return await _api.GetAll();
        }

        // GET api/<DichVuController>/5
        [HttpGet("{id}")]
        public async Task<ActionResult<HopDong>> Get(int id)
        {
            return await _api.GetByID(id);
        }

        // POST api/<DichVuController>
        [HttpPost]
        public async Task<ActionResult<HopDong>> Post(HopDong data)
        {
            await _api.Post(data);
            return Ok(data);
        }


        [HttpPut("{id}")]
        public async Task<ActionResult<HopDong>> Put(HopDong data)
        {
            await _api.Put(data);
            return Ok(data);
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult<HopDong>> Delete(int id)
        {
            await _api.Delete(id);
            return Ok();
        }
    }
}
