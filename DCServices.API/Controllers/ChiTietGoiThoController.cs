using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DCServices.Data.Models;
using DCServices.Services.ChiTietGoiTho;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace DCServices.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ChiTietGoiThoController : ControllerBase
    {
        private readonly IChiTietGoiThoServices _api;
        public ChiTietGoiThoController(IChiTietGoiThoServices api)
        {
            _api = api;
        }
        [HttpPost]
        public async Task<ActionResult<ChiTietGoiTho>> Post(ChiTietGoiTho data)
        {
            await _api.Post(data);
            return Ok(data);
        }

        [HttpGet("getByMaGT/{maGT}")]
        public async Task<IEnumerable<ChiTietGoiTho>> getByMaGT(int maGT)
        {
            return await _api.getByMaGT(maGT);
        }
        //[HttpGet("getByMaMaTho/{maGT}/{maTho}")]
        //public async Task<IEnumerable<ChiTietGoiTho>> getByMaTho(int maGT,int maTho)
        //{
        //    return await _api.getByMaTho(maGT, maTho);
        //}

    }
}
