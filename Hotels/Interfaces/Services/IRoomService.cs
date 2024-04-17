using Hotels.DTOs;

namespace Hotels.Interfaces
{
    public interface IRoomService
    {
        List<RoomDTO> GetRooms();
        RoomDTO GetRoom(Guid id);
        RoomDTO GetRoomByReservationId(Guid id);
        List<RoomDTO> GetRoomsByHotelId(Guid hotelId);
        Guid AddRoom(CreateRoomDTO room);
        RoomDTO UpdateRoom(UpdateRoomDTO room);
        void DeleteRoom(Guid id);
    }
}