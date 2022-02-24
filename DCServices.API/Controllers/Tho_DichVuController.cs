using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DCServices.Data.Models;
using DCServices.Services.Tho_DichVu;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace DCServices.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class Tho_DichVuController : ControllerBase
    {
        private readonly ITho_DichVuServices _api;
        public Tho_DichVuController(ITho_DichVuServices api)
        {
            _api = api;
        }
        // GET: api/<DichVuController>
        [HttpGet]
        public async Task<IEnumerable<Tho_DichVu>> GetAll()
        {
            return await _api.GetAll();
        }
        [HttpGet("Get")]
        public async Task<IEnumerable<Tho_DichVu>> Get(int matho, int madv)
        {
            return await _api.GetByID(matho, madv);
        }
        // GET api/<DichVuController>/5
        [HttpGet("GetAllByID/{id}")]
        public async Task<IEnumerable<ThoInfoDichVu>> GetAll(int id)
        {
            return await _api.GetAllByID(id);
        }

        // POST api/<DichVuController>
        [HttpPost]
        public async Task<ActionResult<Tho_DichVu>> Post(Tho_DichVu data)
        {
            await _api.Post(data);
            return Ok(data);
        }


        //[HttpPut("{id}")]
        //public async Task<ActionResult<Tho_DichVu>> Put(Tho_DichVu data)
        //{
        //    await _api.Put(data);
        //    return Ok(data);
        //}

        [HttpDelete("{id}")]
        public async Task<ActionResult<Tho_DichVu>> Delete(int id)
        {
            await _api.Delete(id);
            return Ok();
        }
    }
}
