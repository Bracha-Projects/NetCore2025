using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace MishnatYosef.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DistributionStationController : Controller
    {
        static Services.DistributionStationService _Stations = new Services.DistributionStationService();
        // GET: api/<DistributionStationController>
        [HttpGet]
        public ActionResult Get()
        {
            List<Entities.DistibutionStation> stations = _Stations.GetService();
            return Ok(stations);
        }

        // GET api/<CustomerController>/5
        [HttpGet("{id}")]
        public ActionResult Get(int id)
        {
            if (id < 0) return BadRequest();
            var station = _Stations.GetByIdService(id);
            if (station == null) { return NotFound(); }
            return Ok(station);
        }

        // POST api/<CustomerController>
        [HttpPost]
        public ActionResult Post([FromBody] Entities.DistibutionStation value)
        {
            if (_Stations.AddStation(value))
                return Ok(true);
            return Ok(false);
        }

        // PUT api/<CustomerController>/5
        [HttpPut("{id}")]
        public ActionResult Put(int id, [FromBody] Entities.DistibutionStation s)
        {
            if (_Stations.UpdateStation(id, s))
                return Ok(true);
            return Ok(false);
        }

        // DELETE api/<CustomerController>/5
        [HttpDelete("{id}")]
        public ActionResult Delete(int id)
        {
            if (_Stations.DeleteByIdService(id))
                return Ok(true);
            return NotFound();
        }
    }
}
