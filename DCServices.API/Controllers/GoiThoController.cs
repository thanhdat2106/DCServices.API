using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DCServices.Data.Models;
using DCServices.Services.GoiTho;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace DCServices.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GoiThoController : ControllerBase
    {
        private readonly IGoiThoServices _api;
        public GoiThoController(IGoiThoServices api)
        {
            _api = api;
        }
        [HttpGet()]
        public async Task<IEnumerable<GoiThoKhachHang>> Get()
        {
            return await _api.get();
        }
        [HttpGet("GetAll/{id}")]
        public async Task<IEnumerable<GoiThoInfoKH>> GetAll(int id)
        {
            return await _api.getAll(id);
        }
        [HttpGet("GetTT/{id}")]
        public async Task<IEnumerable<GoiTho_TT>> GetTTByID(int id)
        {
            return await _api.GetTTByID(id);
        }
        [HttpGet("GetByGT/{id}")]
        public async Task<IEnumerable<ThoSua>> GetByGT(int id)
        {
            return await _api.getByGT(id);
        }
        [HttpGet("{id}")]
        public async Task<IEnumerable<GoiTho_KH_DV>> Get(int id)
        {
            return await _api.GetByID(id);
        }
        [HttpGet("getByMaKH/{maKH}/{trangThai}")]
        public async Task<IEnumerable<GoiTho>> getByMaKH(int maKH, int trangThai)
        {
            return await _api.getByMaKH(maKH, trangThai);
        }

        [HttpPost]
        public async Task<ActionResult<GoiTho>> Post(GoiTho data)
        {
            await _api.Post(data);
            return Ok(data);
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult<GoiTho>> Delete(int id)
        {
            await _api.Delete(id);
            return Ok();
        }
        [HttpPut]
        public async Task<ActionResult<GoiTho>> Put(GoiTho data)
        {
            await _api.Put(data);
            return Ok(data);
        }
    }
}
