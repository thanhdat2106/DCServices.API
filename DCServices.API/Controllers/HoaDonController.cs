using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DCServices.Data.Models;
using DCServices.Services.HoaDon;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace DCServices.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HoaDonController : ControllerBase
    {
        private readonly IHoaDonServices _api;
        public HoaDonController(IHoaDonServices api)
        {
            _api = api;
        }
        // GET: api/<DichVuController>
        [HttpGet]
        public async Task<IEnumerable<HoaDon>> GetAll()
        {
            return await _api.GetAll();
        }
        [HttpGet("chart")]
        public async Task<IEnumerable<SalesChart>> chart()
        {
            return await _api.chart();
        }
        [HttpGet("chartmobile/{id}")]
        public async Task<IEnumerable<Chartmobile>> chartmobile(int id)
        {
            return await _api.chartmobile(id);
        }
        [HttpGet("GETALLBYID/{id}")]
        public async Task<IEnumerable<HoaDonInfo>> GetAllBYID(int id)
        {
            return await _api.GetAllBYID(id);
        }
        [HttpGet("GETALLBYMATHO/{id}")]
        public async Task<IEnumerable<HoaDon>> GetAllBYMATHO(int id)
        {
            return await _api.GetAllBYMATHO(id);
        }
        [HttpGet("GETALLBYMATHO1/{id}")]
        public async Task<IEnumerable<HoaDon>> GetAllBYMATHO1(int id)
        {
            return await _api.GetAllBYMATHO1(id);
        }
        // GET api/<DichVuController>/5
        [HttpGet("{id}")]
        public async Task<ActionResult<HoaDon>> Get(int id)
        {
            return await _api.GetByID(id);
        }

        // POST api/<DichVuController>
        [HttpPost]
        public async Task<ActionResult<HoaDon>> Post(HoaDon data)
        {
            await _api.Post(data);
            return Ok(data);
        }

        //PUT api/<DichVuController>/5
        [HttpPut]
        public async Task<ActionResult<HoaDon>> Put(HoaDon data)
        {
            await _api.Put(data);
            return Ok(data);
        }

        // DELETE api/<DichVuController>/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<HoaDon>> Delete(int id)
        {
            await _api.Delete(id);
            return Ok();
        }
        [HttpGet("getHDByTrangThai/{maKH}/{trangThai}")]
        public async Task<IEnumerable<HoaDon>> getHDByTrangThai(int maKH, int trangThai)
        {
            return await _api.getHDByTrangThai(maKH, trangThai);
        }
    }
}
