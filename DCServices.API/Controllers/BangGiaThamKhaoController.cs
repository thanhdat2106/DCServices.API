using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DCServices.Data.Models;
using DCServices.Services.BangGiaThamKhao;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace DCServices.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BangGiaThamKhaoController : ControllerBase
    {
        private readonly IBangGiaThamKhaoServices _BGTK;
        public BangGiaThamKhaoController (IBangGiaThamKhaoServices BGTK)
        {
            _BGTK = BGTK;
        }
        // GET: api/<BangGiaThamKhaoController>
        [HttpGet]
        public async  Task<IEnumerable<BangGiaThamKhao>> Get()
        {
            return await _BGTK.GetAll();
        }
        [HttpGet("GetAllByID/{id}")]
        public async Task<IEnumerable<BangGiaThamKhao>> GetAllByID(int id)
        {
            return await _BGTK.GetAllByID(id);
        }

        // GET api/<BangGiaThamKhaoController>/5
        [HttpGet("{id}")]
        public async Task<ActionResult<BangGiaThamKhao>> Get(int id)
        {
            return await _BGTK.GetByID(id);
        }


        // POST api/<BangGiaThamKhaoController>
        [HttpPost]
        public async Task<ActionResult<BangGiaThamKhao>> Post(BangGiaThamKhao data)
        {
            await _BGTK.Post(data);
            return Ok(data);
        }

        // PUT api/<BangGiaThamKhaoController>/5
        [HttpPut("{id}")]
        public async Task<ActionResult<BangGiaThamKhao>> Put(BangGiaThamKhao data)
        {
            await _BGTK.Put(data);
            return Ok(data);
        }

        // DELETE api/<BangGiaThamKhaoController>/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<BangGiaThamKhao>> Delete(int id)
        {
            await _BGTK.Delete(id);
            return Ok();
        }
    }
}
