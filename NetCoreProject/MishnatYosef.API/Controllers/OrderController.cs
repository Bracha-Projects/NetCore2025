using Microsoft.AspNetCore.Mvc;
using MishnatYosef.Core.Entities;
using MishnatYosef.Core.Services;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace MishnatYosef.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrderController : ControllerBase
    {
        readonly IOrderService _orderService;
        public OrderController(IOrderService orderService)
        {
            _orderService = orderService;
        }
        // GET: api/<OrderController>
        [HttpGet]
        public ActionResult Get()
        {
            return Ok(_orderService.GetService());
        }

        // GET api/<CustomerController>/5
        [HttpGet("{id}")]
        public ActionResult Get(int id)
        {
            if (id < 0) return BadRequest();
            Order order = _orderService.GetByIdService(id);
            if (order == null) { return NotFound(); }
            return Ok(order);
        }

        // POST api/<CustomerController>
        [HttpPost]
        public ActionResult Post([FromBody] Order value)
        { 
            return Ok(_orderService.AddOrder(value));
        }

        // PUT api/<CustomerController>/5
        [HttpPut("{id}")]
        public ActionResult Put(int id, [FromBody] Order o)
        {
            return Ok(_orderService.UpdateOrder(id, o));
        }

        // DELETE api/<CustomerController>/5
        [HttpDelete("{id}")]
        public ActionResult Delete(int id)
        {
            if (_orderService.DeleteByIdService(id))
                return Ok(true);
            return NotFound();
        }
    }
}
