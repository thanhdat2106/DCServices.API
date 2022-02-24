using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DCServices.Data.Models;
using DCServices.Services.KhachHang;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace DCServices.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class KhachHangController : ControllerBase
    {
        private readonly IKhachHangServices _api;
        public KhachHangController(IKhachHangServices api)
        {
            _api = api;
        }
        // GET: api/<DichVuController>
        [HttpGet]
        public async Task<IEnumerable<KhachHang>> GetAll()
        {
            return await _api.GetAll();
        }

        // GET api/<DichVuController>/5
        [HttpGet("{id}")]
        public async Task<ActionResult<KhachHang>> Get(int id)
        {
            return await _api.GetByID(id);
        }

        // POST api/<DichVuController>
        [HttpPost]
        public async Task<ActionResult<KhachHang>> Post(KhachHang data)
        {
            await _api.Post(data);
            return Ok(data);
        }


        [HttpPut]
        public async Task<ActionResult<KhachHang>> Put(KhachHang data)
        {
            await _api.Put(data);
            return Ok(data);
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult<KhachHang>> Delete(int id)
        {
            await _api.Delete(id);
            return Ok();
        }
    }
}
