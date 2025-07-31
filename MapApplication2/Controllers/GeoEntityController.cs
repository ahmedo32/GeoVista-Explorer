using Microsoft.AspNetCore.Mvc;
using MapApplication2.Models;
using MapApplication2.Services;

namespace MapApplication2.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class GeoEntityController : ControllerBase
    {
        private readonly IGeoEntityService _geoEntityService;

        public GeoEntityController(IGeoEntityService geoEntityService)
        {
            _geoEntityService = geoEntityService;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var entities = await _geoEntityService.GetAllAsync();
            return Ok(entities);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            var entity = await _geoEntityService.GetByIdAsync(id);
            if (entity == null)
            {
                return NotFound();
            }
            return Ok(entity);
        }

        [HttpPost]
        public async Task<IActionResult> Create(GeoEntity entity)
        {
            await _geoEntityService.AddAsync(entity);
            return CreatedAtAction(nameof(GetById), new { id = entity.Id }, entity);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> Update(int id, GeoEntity entity)
        {
            if (id != entity.Id)
            {
                return BadRequest();
            }

            await _geoEntityService.UpdateAsync(entity);
            return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            await _geoEntityService.DeleteAsync(id);
            return NoContent();
        }
    }
}
