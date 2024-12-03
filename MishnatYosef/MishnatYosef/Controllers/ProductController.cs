using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace MishnatYosef.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        static Services.ProductService _Products = new Services.ProductService();

        // GET: api/<ProductController>
        [HttpGet]
        public ActionResult Get()
        {
            List<Entities.Product> products = _Products.GetService();
            return Ok(products);
        }

        // GET api/<CustomerController>/5
        [HttpGet("{id}")]
        public ActionResult Get(int id)
        {
            if (id < 0) return BadRequest();
            Entities.Product product = _Products.GetByIdService(id);
            if (product == null) { return NotFound(); }
            return Ok(product);        }

        // POST api/<CustomerController>
        [HttpPost]
        public ActionResult Post([FromBody] Entities.Product value)
        {
            if (_Products.AddProduct(value))
                return Ok(true);
            return Ok(false);
        }

        // PUT api/<CustomerController>/5
        [HttpPut("{id}")]
        public ActionResult Put(int id, [FromBody] Entities.Product p)
        {
            if (_Products.UpdateProduct(id, p))
                return Ok(true);
            return Ok(false);
        }

        // DELETE api/<CustomerController>/5
        [HttpDelete("{id}")]
        public ActionResult Delete(int id)
        {
            if (_Products.DeleteByIdService(id))
                return Ok(true);
            return NotFound();
        }
    }
}
