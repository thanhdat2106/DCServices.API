using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DCServices.Services.DichVu;
using DCServices.Data.Models;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace DCServices.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DichVuController : ControllerBase
    {
        private readonly IDichVuServices _dichVuDVService;
        public DichVuController(IDichVuServices dichVuDVService)
        {
            _dichVuDVService = dichVuDVService;
        }
        // GET: api/<DichVuController>
        [HttpGet]
        public async Task<IEnumerable<DichVu>> GetAll()
        {
            return await _dichVuDVService.getAll();
        }
        #region getByListMaDV

        [HttpGet("GetByMaDVs/{s}")]
        public async Task<IEnumerable<DichVu>> GetByMaDVs(string s)
        {
            return await _dichVuDVService.getByMaDVs(s);
        }

        #endregion
        [HttpGet("get")]
        public async Task<IEnumerable<DichVu>> Get()
        {
            return await _dichVuDVService.get();
        }
        [HttpGet("GetByIDDV/{id}")]
        public async Task<IEnumerable<DichVu>> GetByID(int id)
        {
            return await _dichVuDVService.GetByIDDV(id);
        }

        // GET api/<DichVuController>/5
        [HttpGet("{id}")]
        public async Task<ActionResult<DichVu>> Get(int id)
        {
            return await _dichVuDVService.GetByID(id);
        }

        // POST api/<DichVuController>
        [HttpPost]
        public async Task<ActionResult<DichVu>> Post(DichVu data)
        {
            await _dichVuDVService.Post(data);
            return Ok(data);
        }

        // PUT api/<DichVuController>/5
        [HttpPut("{id}")]
        public async Task<ActionResult<DichVu>> Put(DichVu data)
        {
            await _dichVuDVService.Put(data);
            return Ok(data);
        }

        // DELETE api/<DichVuController>/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<DichVu>> Delete(int id)
        {
            await _dichVuDVService.Delete(id);
            return Ok();
        }
    }
}
