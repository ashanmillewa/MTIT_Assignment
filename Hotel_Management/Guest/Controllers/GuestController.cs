using Microsoft.AspNetCore.Mvc;
using Guest.Data;
using Guest.Services;
using Guest.Models;

namespace Guest.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GuestController : ControllerBase
    {
        private readonly IGuestService _guestService;

        public GuestController(IGuestService guestService)
        {
            _guestService = guestService ?? throw new ArgumentNullException(nameof(guestService));
        }

        /// Get all Guests
        [HttpGet]
        public IActionResult Get()
        {
            return Ok(_guestService.GetGuests());
        }

        /// Get Guest by ID
        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            return _guestService.GetGuest(id) != null ? Ok(_guestService.GetGuest(id)) : NoContent();
        }
        /// Add guest
        [HttpPost]
        public IActionResult Post([FromBody] Models.Guest guest)
        {
            return Ok(_guestService.AddGuest(guest));
        }

        /// Update the guest
        [HttpPut]
        public IActionResult Put([FromBody] Models.Guest guest)
        {
            return Ok(_guestService.UpdateGuest(guest));
        }

        /// Delete the guest with the passed ID
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            var result = _guestService.DeleteGuest(id);

            return result.HasValue & result == true ? Ok($"guest with ID:{id} got deleted successfully.")
                : BadRequest($"Unable to delete the guest with ID:{id}.");
        }
    }
}
