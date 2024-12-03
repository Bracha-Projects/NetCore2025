using Microsoft.AspNetCore.Mvc;
using MishnatYosef.Core.Entities;
using MishnatYosef.Core.Services;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace MishnatYosef.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductOnSellController : ControllerBase
    {
        readonly IProductOnSellService _productsOnSellService;
        public ProductOnSellController(IProductOnSellService productOnSellService)
        {
            _productsOnSellService = productOnSellService;
        }
        // GET: api/<ProductOnSellController>
        [HttpGet]
        public ActionResult Get()
        {
            List<ProductOnSell> products = _productsOnSellService.GetService();
            return Ok(products);
        }

        // GET api/<CustomerController>/5
        [HttpGet("{id}")]
        public ActionResult Get(int id)
        {
            if (id < 0) return BadRequest();
            ProductOnSell product = _productsOnSellService.GetByIdService(id);
            if (product == null) { return NotFound(); }
            return Ok(product);
        }

        // POST api/<CustomerController>
        [HttpPost]
        public ActionResult Post([FromBody] ProductOnSell value)
        {
            return Ok(_productsOnSellService.AddProductToSell(value));
        }

        // PUT api/<CustomerController>/5
        [HttpPut("{id}")]
        public ActionResult Put(int id, [FromBody] ProductOnSell p)
        {
            return Ok(_productsOnSellService.UpdateProductOnSell(id, p));
        }

        // DELETE api/<CustomerController>/5
        [HttpDelete("{id}")]
        public ActionResult Delete(int id)
        {
            if (_productsOnSellService.DeleteByIdService(id))
                return Ok(true);
            return NotFound();
        }
    }
}
