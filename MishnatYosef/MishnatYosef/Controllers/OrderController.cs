using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace MishnatYosef.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrderController : ControllerBase
    {
        static Services.OrderService _Orders = new Services.OrderService();
        // GET: api/<OrderController>
        [HttpGet]
        public ActionResult Get()
        {
            var orders = _Orders.GetService();
            return Ok(orders);
        }

        // GET api/<CustomerController>/5
        [HttpGet("{id}")]
        public ActionResult Get(int id)
        {
            if (id < 0) return BadRequest();
            Entities.Order order = _Orders.GetByIdService(id);
            if (order == null) { return NotFound(); }
            return Ok(order);
        }

        // POST api/<CustomerController>
        [HttpPost]
        public ActionResult Post([FromBody] Entities.Order value)
        {
            if (_Orders.AddOrder(value))
                return Ok(true);    
            return Ok(false);
        }

        // PUT api/<CustomerController>/5
        [HttpPut("{id}")]
        public ActionResult Put(int id, [FromBody] Entities.Order o)
        {
            if (_Orders.UpdateOrder(id, o))
                return Ok(true);
            return Ok(false);
        }

        // DELETE api/<CustomerController>/5
        [HttpDelete("{id}")]
        public ActionResult Delete(int id)
        {
            if (_Orders.DeleteByIdService(id))
                return Ok(true);
            return NotFound();
        }
    }
}
