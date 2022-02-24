using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DCServices.Data.Models;
using DCServices.Services.TinTuc;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace DCServices.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TinTucController : ControllerBase
    {
        private readonly ITinTucServices _api;
        public TinTucController(ITinTucServices api)
        {
            _api = api;
        }
        // GET: api/<DichVuController>
        [HttpGet]
        public async Task<IEnumerable<TinTuc>> GetAll()
        {
            return await _api.GetAll();
        }
        [HttpGet("GetSix")]
        public async Task<IEnumerable<TinTuc>> GetSix()
        {
            return await _api.GetSix();
        }

        [HttpGet("GetAll")]
        public async Task<IEnumerable<TinTucLoaiDV>> Get()
        {
            return await _api.Get();
        }
        [HttpGet("GetAllByID/{id}")]
        public async Task<IEnumerable<TinTuc>> GetAllByID(int id)
        {
            return await _api.GetAllByID(id);
        }
        // GET api/<DichVuController>/5
        [HttpGet("{id}")]
        public async Task<ActionResult<TinTuc>> Get(int id)
        {
            return await _api.GetByID(id);
        }

        // POST api/<DichVuController>
        [HttpPost]
        public async Task<ActionResult<TinTuc>> Post(TinTuc data)
        {
            await _api.Post(data);
            return Ok(data);
        }


        [HttpPut("{id}")]
        public async Task<ActionResult<TinTuc>> Put(TinTuc data)
        {
            await _api.Put(data);
            return Ok(data);
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult<TinTuc>> Delete(int id)
        {
            await _api.Delete(id);
            return Ok();
        }
    }
}
