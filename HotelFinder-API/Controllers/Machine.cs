using Mac.Business.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace HotelFinder_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MachineManager : ControllerBase
    {
        private IMachineService _machineService;

        public MachineManager(IMachineService machineService)
        {
            _machineService = machineService;
        }
        [HttpGet]
        public IActionResult Get()
        {
            var machine = _machineService.GetAllMac();
            return Ok(machine);
            
        }
     


        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            var machine = _machineService.GetMachineById(id);
            if (machine != null)
            {
                return Ok(machine);
            }
            return NotFound();
        }

        [HttpPost]
        public IActionResult Post([FromBody] Mac.Entities.Machines machine)
        {
            if (ModelState.IsValid)
            {
                var createdMac = _machineService.CreateMac(machine);
                return CreatedAtAction("Get", new { id = createdMac.ConnectionID }, createdMac);
            }
            return BadRequest(ModelState);
        }

        [HttpPut]
        public IActionResult Put([FromBody] Mac.Entities.Machines machine)
        {
            if (_machineService.GetMachineById(machine.ConnectionID) != null)
            {
                return Ok(_machineService.GetMachineById(machine.ConnectionID));
            }
            return NotFound();
        }

        [HttpDelete]
        public IActionResult Delete(int id)
        {
            if (_machineService.GetMachineById(id) != null)
            {
                _machineService.GetMachineById(id);
                return Ok();
            }
            return NotFound();
        }

    }
}
