using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DCServices.Data.Models;
using DCServices.Services.NhanVien;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace DCServices.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class NhanVienController : ControllerBase
    {
        private readonly INhanVienServices _api;
        public NhanVienController(INhanVienServices api)
        {
            _api = api;
        }
        // GET: api/<DichVuController>
        [HttpGet]
        public async Task<IEnumerable<NhanVien>> GetAll()
        {
            return await _api.GetAll();
        }

        // GET api/<DichVuController>/5
        [HttpGet("{id}")]
        public async Task<ActionResult<NhanVien>> Get(int id)
        {
            return await _api.GetByID(id);
        }

        // POST api/<DichVuController>
        [HttpPost]
        public async Task<ActionResult<NhanVien>> Post(NhanVien data)
        {
            await _api.Post(data);
            return Ok(data);
        }


        [HttpPut("{id}")]
        public async Task<ActionResult<NhanVien>> Put(NhanVien data)
        {
            await _api.Put(data);
            return Ok(data);
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult<NhanVien>> Delete(int id)
        {
            await _api.Delete(id);
            return Ok();
        }
    }
}
