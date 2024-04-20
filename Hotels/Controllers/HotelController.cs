using Hotels.DTOs;
using Hotels.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace Hotels.Controller
{
    [Route("api/hotel")]
    [ApiController]
    public class HotelController : ControllerBase
    {
        private readonly IHotelService _hotelService;

        public HotelController(IHotelService hotelService)
        {
            _hotelService = hotelService;
        }

        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        public ActionResult<IEnumerable<HotelDTO>> Gethotels()
        {
            var data = _hotelService.GetHotels();
            if (data is null || data.Count is 0) return NoContent();

            return Ok(data);
        }

        [HttpGet("{id:guid}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public ActionResult<HotelDTO> GetHotelById(Guid id)
        {
            if (id.Equals("0") || id.Equals("")) return BadRequest();
            var data = _hotelService.GetHotel(id);
            if (data is null) return NotFound();

            return Ok(data);
        }

        [HttpGet("reservation/{id:guid}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public ActionResult<HotelDTO> GetHotelByReservationId(Guid id)
        {
            if (id.Equals("0") || id.Equals("")) return BadRequest();
            var data = _hotelService.GetHotelByReservationId(id);
            if (data is null) return NotFound();

            return Ok(data);
        }

        [HttpGet("room/{id:guid}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public ActionResult<HotelDTO> GetHotelByRoomId(Guid id)
        {
            if (id.Equals("0") || id.Equals("")) return BadRequest();
            var data = _hotelService.GetHotelByRoomId(id);
            if (data is null) return NotFound();

            return Ok(data);
        }

        [HttpPost]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public ActionResult<HotelDTO> PostHotel([FromBody] CreateHotelDTO _data)
        {
            if (!ModelState.IsValid) return BadRequest();
            var data = _hotelService.AddHotel(_data);

            if (data is not null)
                return CreatedAtAction(nameof(GetHotelById), new { id = data.Id }, data);
            return StatusCode(500, "Internal Server Error");

        }

        [HttpPatch]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public ActionResult<HotelDTO> UpdateHotel([FromBody] UpdateHotelDTO _data)
        {
            if (!ModelState.IsValid) return BadRequest();
            var data = _hotelService.UpdateHotel(_data);

            if (data is not null)
                return Ok(data);

            return StatusCode(500, "Internal Server Error");
        }

        [HttpDelete("{id:guid}")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public IActionResult DeleteHotel(Guid id)
        {
            if (id.Equals("0") || id.Equals("")) return BadRequest();
            _hotelService.DeleteHotel(id);

            return NoContent();
        }

    }
}