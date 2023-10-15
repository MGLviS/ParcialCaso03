using DPA202302ParcialCaso0322101571.Entities;
using DPA202302ParcialCaso0322101571.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;

namespace DPA202302ParcialCaso0322101571.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class territoryController : ControllerBase
    {
        private readonly IterritoryRepository _territoryRepository;

        public territoryController(IterritoryRepository territoryRepository)
        {
            _territoryRepository = territoryRepository;
        }

        [HttpGet("GetAll")]
        public async Task<IActionResult> GetAll()
        {
            var territory = await _territoryRepository.GetAll();
            return Ok(territory);
        }

        [HttpPost("Insert")]
        public async Task<IActionResult> Insert(Territory territory)
        {
            var result = await _territoryRepository.Insert(territory);
            if (!result)
                return BadRequest();
            return Ok(result);
        }

        [HttpPut("Update")]
        public async Task<IActionResult> Update(int id, Territory territory)
        {
            var rows = await _territoryRepository.Update(id, territory);
            return Ok(rows);
        }

        [HttpDelete("Delete")]
        public async Task<IActionResult> Delete(int id)
        {
            var result = await _territoryRepository.Delete(id);
            if (!result)
                return NotFound(result);
            return Ok(result);
        }
    }
}
