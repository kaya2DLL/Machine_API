using HotelFinder.Business.Abstract;
using Mac.Business.Abstract;
using Mac.Entities;
using Microsoft.AspNetCore.Mvc;

namespace HotelFinder_API.Controllers
{  
    [Route("api/[controller]")] 
   [ApiController]

    
        public class DatasManager : ControllerBase
        {

            private IDatasService _datasService;

            public DatasManager(IDatasService datasService)
            {
                _datasService = datasService;
            }

            [HttpGet]
            public IActionResult Get()
            {
                
                var macs = _datasService.GetAllMac();
                return Ok(macs);
            }

            [HttpGet("{id}")]
            public IActionResult Get(int id)
            {
                var mac = _datasService.GetMachineById(id);
                if (mac != null)
                {
                    return Ok(mac);
                }
                return NotFound();
            }


            [HttpPost]
            public IActionResult Post([FromBody] Mac.Entities.PLCQualityCriterionDatas datas)
            {
                if (ModelState.IsValid)
                {
                    var createdMac = _datasService.CreateMac(datas);
                    return CreatedAtAction("Get", new { id = createdMac.OID }, createdMac);
                }
                return BadRequest(ModelState);
            }

            [HttpPut]
            public IActionResult Put([FromBody] Mac.Entities.PLCQualityCriterionDatas datas)
            {
                if (_datasService.GetMachineById(datas.OID) != null)
                {
                    return Ok(_datasService.UpdateMac(datas));
                }
                return NotFound();
            }

            [HttpDelete]
            public IActionResult Delete(int id)
            {
                if (_datasService.GetMachineById(id) != null)
                {
                    _datasService.GetMachineById(id);
                    return Ok();
                }
                return NotFound();
            }
        }
    }



