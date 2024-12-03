using Microsoft.AspNetCore.Mvc;
using MishnatYosef.Core.Entities;
using MishnatYosef.Core.Services;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace MishnatYosef.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        readonly IProductService _productsService;
        public ProductController(IProductService productService)
        {
            _productsService = productService;
        }

        // GET: api/<ProductController>
        [HttpGet]
        public ActionResult Get()
        {
            return Ok(_productsService.GetService());
        }

        // GET api/<CustomerController>/5
        [HttpGet("{id}")]
        public ActionResult Get(int id)
        {
            if (id < 0) return BadRequest();
            Product product = _productsService.GetByIdService(id);
            if (product == null) { return NotFound(); }
            return Ok(product);        }

        // POST api/<CustomerController>
        [HttpPost]
        public ActionResult Post([FromBody] Product value)
        {
            return Ok(_productsService.AddProduct(value));
        }

        // PUT api/<CustomerController>/5
        [HttpPut("{id}")]
        public ActionResult Put(int id, [FromBody] Product p)
        {
            return Ok(_productsService.UpdateProduct(id, p));
        }

        // DELETE api/<CustomerController>/5
        [HttpDelete("{id}")]
        public ActionResult Delete(int id)
        {
            if (_productsService.DeleteByIdService(id))
                return Ok(true);
            return NotFound();
        }
    }
}
