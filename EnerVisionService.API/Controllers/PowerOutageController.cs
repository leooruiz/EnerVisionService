using EnerVisionService.Application.Services;
using EnerVisionService.Domain.Entities;
using Microsoft.AspNetCore.Mvc;

namespace EnerVisionService.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class PowerOutageController(PowerOutageService service) : ControllerBase
    {
        private readonly PowerOutageService _service = service;

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var outages = await _service.GetAllAsync();
            return Ok(outages);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            var outage = await _service.GetByIdAsync(id);
            return outage is not null ? Ok(outage) : NotFound();
        }

        [HttpPost]
        public async Task<IActionResult> Create([FromBody] PowerOutage outage)
        {
            await _service.AddAsync(outage);
            return CreatedAtAction(nameof(GetById), new { id = outage.Id }, outage);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> Update(int id, [FromBody] PowerOutage outage)
        {
            if (id != outage.Id)
                return BadRequest("ID mismatch.");

            await _service.UpdateAsync(outage);
            return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            await _service.DeleteAsync(id);
            return NoContent();
        }
    }
}