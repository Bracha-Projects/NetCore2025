using Microsoft.AspNetCore.Mvc;
using MishnatYosef.Core.Entities;
using MishnatYosef.Core.Services;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace MishnatYosef.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DistributionStationController : Controller
    {
        readonly IDistributionStationService _stationsService;

        public DistributionStationController(IDistributionStationService stationService)
        {
            _stationsService = stationService;
        }

        // GET: api/<DistributionStationController>
        [HttpGet]
        public ActionResult Get()
        {
            return Ok(_stationsService.GetService());
        }

        // GET api/<CustomerController>/5
        [HttpGet("{id}")]
        public ActionResult Get(int id)
        {
            if (id < 0) return BadRequest();
            var station = _stationsService.GetByIdService(id);
            if (station == null) { return NotFound(); }
            return Ok(station);
        }

        // POST api/<CustomerController>
        [HttpPost]
        public ActionResult Post([FromBody] DistibutionStation value)
        {
            return Ok(_stationsService.AddStation(value));
        }

        // PUT api/<CustomerController>/5
        [HttpPut("{id}")]
        public ActionResult Put(int id, [FromBody] DistibutionStation s)
        {
            return Ok(_stationsService.UpdateStation(id, s));
        }

        // DELETE api/<CustomerController>/5
        [HttpDelete("{id}")]
        public ActionResult Delete(int id)
        {
            if (_stationsService.DeleteByIdService(id))
                return Ok(true);
            return NotFound();
        }
    }
}
