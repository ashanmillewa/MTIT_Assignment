using Microsoft.AspNetCore.Mvc;
using Resturent.Models;
using Resturent.Services;

namespace Resturent.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ResturentController : ControllerBase
    {
        private readonly IResturentService _resturentService;

        public ResturentController(IResturentService resturentService)
        {
            _resturentService = resturentService ?? throw new ArgumentNullException(nameof(resturentService));
        }

        /// Get all Resturent
        [HttpGet]
        public IActionResult Get()
        {
            return Ok(_resturentService.GetResturents());
        }

        /// Get Resturent by ID
        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            return _resturentService.GetResturent(id) != null ? Ok(_resturentService.GetResturent(id)) : NoContent();
        }

        /// Add Resturents
        [HttpPost]
        public IActionResult Post([FromBody] Models.Resturent resturent)
        {
            return Ok(_resturentService.AddResturent(resturent));
        }

        /// Update the resturent
        [HttpPut]
        public IActionResult Put([FromBody] Models.Resturent resturent)
        {
            return Ok(_resturentService.UpdateResturent(resturent));
        }

        /// Delete the resturent with the passed ID
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            var result = _resturentService.DeleteResturent(id);

            return result.HasValue & result == true ? Ok($"resturent with ID:{id} got deleted successfully.")
                : BadRequest($"Unable to delete the resturent with ID:{id}.");
        }
    }
}
