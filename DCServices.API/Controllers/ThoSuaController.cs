using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DCServices.Data.Models;
using DCServices.Services.ThoSua;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace DCServices.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ThoSuaController : ControllerBase
    {
        private readonly IThoSuaServices _api;
        public ThoSuaController(IThoSuaServices api)
        {
            _api = api;
        }
        // GET: api/<DichVuController>
        [HttpGet]
        public async Task<IEnumerable<ThoSua>> GetAll()
        {
            return await _api.GetAll();
        }

        // GET api/<DichVuController>/5
        [HttpGet("{id}")]
        public async Task<ActionResult<ThoSua>> Get(int id)
        {
            return await _api.GetByID(id);
        }
        [HttpGet("GetEmail/{id}")]
        public async Task<ActionResult<ThoSua>> GetEmail(string id)
        {
            return await _api.GetEmail(id);
        }
        [HttpGet("GetSDT/{id}")]
        public async Task<ActionResult<ThoSua>> GetSDT(string id)
        {
            return await _api.GetSDT(id);
        }
        // POST api/<DichVuController>
        [HttpPost]
        public async Task<ActionResult<ThoSua>> Post(ThoSua data)
        {
            await _api.Post(data);
            return Ok(data);
        }


        [HttpPut]
        public async Task<ActionResult<ThoSua>> Put(ThoSua data)
        {
            await _api.Put(data);
            return Ok(data);
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult<ThoSua>> Delete(int id)
        {
            await _api.Delete(id);
            return Ok();
        }
        [HttpGet("getThoSuaByListDV/{listDV}")]
        public async Task<IEnumerable<ThoSuaData>> getThoSuaByListDV(string listDV)
        {
            return await _api.getThoSuaByListDV(listDV);
        }
    }
}
