using Hotels.DTOs;
using Hotels.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace Hotels.Controller
{
    [Route("api/reservation")]
    [ApiController]
    public class ReservationController : ControllerBase
    {
        private readonly IReservationService _reservationService;
        public ReservationController(IReservationService reservationService)
        {
            _reservationService = reservationService;
        }

        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        public ActionResult<IEnumerable<ReservationDTO>> GetReservations()
        {
            var data = _reservationService.GetReservations();
            if (data is null || data.Count is 0) return NoContent();

            return Ok(data);
        }

        [HttpGet("{id:guid}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public ActionResult<HotelDTO> GetReservationById(Guid id)
        {
            if (id.Equals("0") || id.Equals("")) return BadRequest();
            
            var data = _reservationService.GetReservation(id);
            if (data is null) return NotFound("Reservation not found");

            return Ok(data);
        }

        [HttpGet("hotel/{id:guid}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public ActionResult<IEnumerable<ReservationDTO>> GetReservationsByHotelId(Guid id)
        {
            if (id.Equals("0") || id.Equals("")) return BadRequest();

            var data = _reservationService.GetReservationsByHotelId(id);
            if (data is null) return NotFound("Hotel not found");

            return Ok(data);
        }


        [HttpGet("room/{id:guid}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public ActionResult<IEnumerable<ReservationDTO>> GetReservationsByRoomId(Guid id)
        {
            if (id.Equals("0") || id.Equals("")) return BadRequest();

            var data = _reservationService.GetReservationsByRoomId(id);
            if (data is null) return NotFound("Room not found");

            return Ok(data);
        }


        [HttpPost]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public ActionResult<ReservationDTO> PostReservation([FromBody] CreateReservationDTO _data)
        {
            if (!ModelState.IsValid) return BadRequest();

            var data = _reservationService.AddReservation(_data);

            if (data is not null)
                return CreatedAtAction(nameof(GetReservationById), new { id = data.Id }, data);

            return StatusCode(500, "Internal Server Error");

        }

        [HttpPatch]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public ActionResult<ReservationDTO> UpdateReservation([FromBody] UpdateReservationDTO _data)
        {
            if (!ModelState.IsValid) return BadRequest();

            var data = _reservationService.UpdateReservation(_data);

            if(data is null)
                return StatusCode(500, "Internal Server Error");

            if (data.Id == Guid.Empty)
                return NotFound();

            return Ok(data);
        }

        [HttpDelete("{id:guid}")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public IActionResult DeleteHotel(Guid id)
        {
            if (id.Equals("0") || id.Equals("")) return BadRequest();

            _reservationService.DeleteReservation(id);

            return NoContent();
        }

    }
}