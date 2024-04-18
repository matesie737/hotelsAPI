using Hotels.DTOs;
using Hotels.Interfaces;

namespace Hotels.Services
{
    public class RoomService : IRoomService
    {
        private readonly IRoomRepository _roomRepository;
        public RoomService(IRoomRepository roomRepository)
        {
            _roomRepository = roomRepository;
        }
        public List<RoomDTO> GetRooms()
        {
            throw new NotImplementedException();
        }
        public RoomDTO GetRoom(Guid id)
        {
            throw new NotImplementedException();
        }
        public RoomDTO GetRoomByReservationId(Guid id)
        {
            throw new NotImplementedException();
        }
        public List<RoomDTO> GetRoomsByHotelId(Guid hotelId)
        {
            throw new NotImplementedException();
        }
        public Guid AddRoom(CreateRoomDTO room)
        {
            throw new NotImplementedException();
        }
        public RoomDTO UpdateRoom(UpdateRoomDTO room)
        {
            throw new NotImplementedException();
        }
        public void DeleteRoom(Guid id)
        {
            throw new NotImplementedException();
        }
    }
}