using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DCServices.Data.Models;
using DCServices.Services.DanhGia;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace DCServices.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DanhGiaController : ControllerBase
    {
        private readonly IDanhGiaServices _api;
        public DanhGiaController(IDanhGiaServices api)
        {
            _api = api;
        }

        [HttpGet]
        public async Task<IEnumerable<DanhGia>> Get()
        {
            return await _api.GetAll();
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<DanhGia>> Get(int id)
        {
            return await _api.GetByID(id);
        }


        [HttpPost]
        public async Task<ActionResult<DanhGia>> Post(DanhGia data)
        {
            await _api.Post(data);
            return Ok(data);
        }
        [HttpPut("PutTho")]
        public async Task<ActionResult<DanhGia>> PutTho(DanhGia data)
        {
            await _api.PutTho(data);
            return Ok(data);
        }
        [HttpPut("PutKhachHang")]
        public async Task<ActionResult<DanhGia>> PutKhachHang(DanhGia data)
        {
            await _api.PutKhachHang(data);
            return Ok(data);
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult<DanhGia>> Delete(int id)
        {
            await _api.Delete(id);
            return Ok();
        }
    }
}
