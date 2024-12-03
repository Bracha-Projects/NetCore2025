using Microsoft.AspNetCore.Mvc;
using MishnatYosef.Core.Entities;
using MishnatYosef.Core.Services;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace MishnatYosef.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomerController : ControllerBase
    {
        readonly ICustomerService _customerSerice;
        public CustomerController(ICustomerService customerSerice)
        {
            _customerSerice = customerSerice;
        }
        // GET: api/<CustomerController>
        [HttpGet]
        public ActionResult Get()
        {
            return Ok(_customerSerice.GetService());
        }

        // GET api/<CustomerController>/5
        [HttpGet("{id}")]
        public ActionResult Get(int id)
        {
            if (id < 0) return BadRequest();
            var customer= _customerSerice.GetByIdService(id);
            if(customer == null) { return NotFound(); }
            return Ok(customer);
        }

        // POST api/<CustomerController>
        [HttpPost]
        public ActionResult Post([FromBody] Customer value)
        {
            return Ok(_customerSerice.AddCustomer(value));
        }

        // PUT api/<CustomerController>/5
        [HttpPut("{id}")]
        public ActionResult Put(int id, [FromBody] Customer c)
        {
            return Ok(_customerSerice.UpdateCustomer(id,c));
        }

        // DELETE api/<CustomerController>/5
        [HttpDelete("{id}")]
        public ActionResult Delete(int id)
        {
            if(_customerSerice.DeleteByIdService(id))
                return Ok(true);
            return NotFound();
        }
    }
}
