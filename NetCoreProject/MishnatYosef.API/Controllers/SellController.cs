using Microsoft.AspNetCore.Mvc;
using MishnatYosef.Core.Entities;
using MishnatYosef.Core.Services;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace MishnatYosef.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SellController : ControllerBase
    {
        readonly ISellService _sellService;
        public SellController(ISellService sellService)
        {
            _sellService = sellService; 
        }
        // GET: api/<SellController>
        [HttpGet]
        public ActionResult Get()
        {
            return Ok(_sellService.GetService());
        }

        // GET api/<CustomerController>/5
        [HttpGet("{id}")]
        public ActionResult Get(int id)
        {
            if (id < 0) return BadRequest();
            Sell sell = _sellService.GetByIdService(id);
            if (sell == null) { return NotFound(); }
            return Ok(sell);
        }

        // POST api/<CustomerController>
        [HttpPost]
        public ActionResult Post([FromBody] Sell value)
        {
            return Ok(_sellService.AddSell(value));
        }

        // PUT api/<CustomerController>/5
        [HttpPut("{id}")]
        public ActionResult Put(int id, [FromBody] Sell s)
        {
            return Ok(_sellService.UpdateCustomer(id, s));
        }

        // DELETE api/<CustomerController>/5
        [HttpDelete("{id}")]
        public ActionResult<bool> Delete(int id)
        {
            if (_sellService.DeleteByIdService(id))
                return Ok(true);
            return NotFound();
        }
    }
}
