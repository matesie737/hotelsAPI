using Hotels.DTOs;

namespace Hotels.Interfaces
{
    public interface IRoomService
    {
        List<RoomDTO>? GetRooms();
        RoomExDTO? GetRoom(Guid id);
        RoomExDTO? GetRoomByReservationId(Guid reservationId);
        List<RoomDTO>? GetRoomsByHotelId(Guid hotelId);
        RoomDTO? AddRoom(CreateRoomDTO room);
        RoomDTO? UpdateRoom(UpdateRoomDTO room);
        void DeleteRoom(Guid id);
    }
}