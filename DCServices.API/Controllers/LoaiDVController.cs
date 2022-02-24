using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DCServices.Services.LoaiDV;
using DCServices.Data.Data;
using DCServices.Data.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace DCServices.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LoaiDVController : ControllerBase
    {
        private readonly ILoaiDVService _loaiDVService;
        public LoaiDVController(ILoaiDVService loaiDVService)
        {
            _loaiDVService = loaiDVService;
        }
        [HttpGet]
        public async Task<IEnumerable<LoaiDV>> GetAll()
        {
            return await _loaiDVService.GetAll();
        }
        // GET api/<LoaiDVController>/5
        [HttpGet("{id}")]
        public async Task<ActionResult<LoaiDV>> Get(int id)
        {
            return await _loaiDVService.GetByID(id);
        }

        // POST api/<LoaiDVController>
        [HttpPost]
        public async Task<ActionResult<LoaiDV>> Post(LoaiDV data)
        {
            await _loaiDVService.Post(data);
            return Ok(data);
        }

        // PUT api/<LoaiDVController>/5
        [HttpPut("{id}")]
        public async Task<ActionResult<LoaiDV>> Put(LoaiDV data)
        {
            await _loaiDVService.Put(data);
            return Ok(data);
        }

        // DELETE api/<LoaiDVController>/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<LoaiDV>> Delete(int id)
        {
            await _loaiDVService.Delete(id);
            return Ok();
        }
    }
}
