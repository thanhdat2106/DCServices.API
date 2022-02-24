using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DCServices.Data.Models;
using DCServices.Services.ChiTietHoaDon;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace DCServices.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ChiTietHoaDonController : ControllerBase
    {
        private readonly IChiTietHoaDonServices _api;
        public ChiTietHoaDonController(IChiTietHoaDonServices api)
        {
            _api = api;
        }

        [HttpGet]
        public async Task<IEnumerable<ChiTietHoaDon>> Get()
        {
            return await _api.GetAll();
        }
        [HttpGet("GetCTHD/{id}")]
        public async Task<IEnumerable<HoaDonInfoCTHD>> Getalll(int id)
        {
            return await _api.GetHoaDonInfoCTHD(id);
        }
        [HttpGet("{id}")]
        public async Task<IEnumerable<ChiTietHoaDon>> Get(int id)
        {
            return await _api.GetByID(id);
        }
        [HttpGet("getByMaHD/{maHD}")]
        public async Task<IEnumerable<ChiTietHDDATA>> getByMaHD(int maHD)
        {
            return await _api.getByMaHD(maHD);
        }

        [HttpGet("getByMaHD_MaDV/{maHD}/{maDV}")]
        public async Task<IEnumerable<ChiTietHoaDon>> getByMaHD_MaDV(int maHD, int maDV)
        {
            return await _api.getByMaHD_MaDV(maHD, maDV);
        }

        [HttpPost]
        public async Task<ActionResult<ChiTietHoaDon>> Post(ChiTietHoaDon data)
        { 
            return await _api.Post(data); 
        }
        [HttpPut]
        public async Task<ActionResult<ChiTietHoaDon>> Put(ChiTietHoaDon data)
        {

             await _api.Put(data);
            return Ok(data);
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult<ChiTietHoaDon>> Delete(int id)
        {
            await _api.Delete(id);
            return Ok();
        }
    }
}
