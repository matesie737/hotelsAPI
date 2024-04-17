using Hotels.DTOs;
using Hotels.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace Hotels.Controller
{
    [Route("api/room")]
    [ApiController]
    public class RoomController : ControllerBase
    {
        private readonly IRoomService _roomService;
        public RoomController(IRoomService roomService)
        {
            _roomService = roomService;
        }

        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        public ActionResult<IEnumerable<RoomDTO>> getRooms()
        {
            var data = _roomService.GetRooms();
            if (data is null || data.Count is 0) return NoContent();

            return Ok(data);
        }

        [HttpGet("{id:guid}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public ActionResult<RoomDTO> GetRoomById(Guid id)
        {
            if (id.Equals("0") || id.Equals("")) return BadRequest();
            var data = _roomService.GetRoom(id);
            if (data is null) return NotFound();

            return Ok(data);
        }

        [HttpGet("reservation/{id:guid}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public ActionResult<IEnumerable<RoomDTO>> GetRoomByReservationId(Guid id)
        {
            if (id.Equals("0") || id.Equals("")) return BadRequest();
            var data = _roomService.GetRoomByReservationId(id);
            if (data is null) return NotFound();

            return Ok(data);
        }


        [HttpGet("hotel/{id:guid}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public ActionResult<IEnumerable<RoomDTO>> GetRoomsByHotelId(Guid id)
        {
            if (id.Equals("0") || id.Equals("")) return BadRequest();
            var data = _roomService.GetRoomsByHotelId(id);
            if (data is null) return NotFound();

            return Ok(data);
        }


        [HttpPost]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public ActionResult<RoomDTO> PostRoom([FromBody] CreateRoomDTO data)
        {
            if (!ModelState.IsValid) return BadRequest();
            _roomService.AddRoom(data);

            return Created();
        }

        [HttpPatch]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public ActionResult<RoomDTO> UpdateRoom([FromBody] UpdateRoomDTO data)
        {
            if (!ModelState.IsValid) return BadRequest();
            _roomService.UpdateRoom(data);

            return Ok();
        }

        [HttpDelete("{id:guid}")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public IActionResult DeleteRoom(Guid id)
        {
            if (id.Equals("0") || id.Equals("")) return BadRequest();
            _roomService.DeleteRoom(id);

            return NoContent();
        }

    }
}