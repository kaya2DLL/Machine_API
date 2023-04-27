
using HotelFinder.Business.Abstract;
using Mac.Business.Abstract;
using Microsoft.AspNetCore.Mvc;
namespace HotelFinder_API.Controllers
{

    [Route("api/[controller]")]
    [ApiController]
    public class MacManager : ControllerBase
    {

        private IMacService _macService;

        public MacManager (IMacService macService)
        {
            _macService = macService;
        }

        [HttpGet]
        public IActionResult Get()
        {
            var macs= _macService.GetAllMacs();
            return Ok(macs);
        }

        [HttpGet("{id}")]
        public IActionResult Get(int id) 
        {
                var mac= _macService.GetMacById(id);
            if (mac!=null)
            {
                return Ok(mac);
            }
            return NotFound();
        }


        [HttpPost]
        public IActionResult Post([FromBody] HotelFinder.Entities.Connection mac)
        {
            if (ModelState.IsValid)
            {
                var createdMac= _macService.CreateMac(mac);
                return CreatedAtAction("Get", new { id = createdMac.ID }, createdMac); 
            }
            return BadRequest(ModelState);
        }

        [HttpPut]
        public IActionResult Put ([FromBody] HotelFinder.Entities.Connection mac)
        {
            if (_macService.GetMacById(mac.ID)!=null)
            {
                return Ok(_macService.UpdateMac(mac));
            }
            return NotFound();
        }

        [HttpDelete]
        public IActionResult Delete(int id)
        {
            if (_macService.GetMacById(id) != null)
            {
                _macService.GetMacById(id);
                return Ok();
            }
            return NotFound();
        }
    }
}
