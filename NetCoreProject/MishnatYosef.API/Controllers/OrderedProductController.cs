using Microsoft.AspNetCore.Mvc;
using MishnatYosef.Core.Entities;
using MishnatYosef.Core.Services;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace MishnatYosef.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrderedProductController : ControllerBase
    {
        readonly IOrderedProductService _orderProducts;
        public OrderedProductController(IOrderedProductService orderedProductService)
        {
            _orderProducts = orderedProductService;
        }
        // GET: api/<OrderedProductController>
        [HttpGet]
        public ActionResult Get()
        {
            return Ok(_orderProducts.GetService());
        }

        // GET api/<CustomerController>/5
        [HttpGet("{id}")]
        public ActionResult Get(int id)
        {
            if (id < 0) return BadRequest();
            OrderedProduct orderedProduct = _orderProducts.GetByIdService(id);
            if (orderedProduct == null) { return NotFound(); }
            return Ok(orderedProduct);
        }

        // POST api/<CustomerController>
        [HttpPost]
        public ActionResult Post([FromBody] OrderedProduct value)
        {
            return Ok(_orderProducts.OrderProduct(value));
        }

        // PUT api/<CustomerController>/5
        [HttpPut("{id}")]
        public ActionResult Put(int id, [FromBody] OrderedProduct o)
        {
            return Ok(_orderProducts.UpdateOrderedProduct(id, o));
        }

        // DELETE api/<CustomerController>/5
        [HttpDelete("{id}")]
        public ActionResult Delete(int id)
        {
            if (_orderProducts.DeleteByIdService(id))
                return Ok(true);
            return NotFound();
        }

    }
}
