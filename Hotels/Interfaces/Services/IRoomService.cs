using Hotels.DTOs;
using Hotels.Models;

namespace Hotels.Interfaces
{
    public interface IRoomService
    {
        Guid AddRoom(CreateRoomDTO room);
        List<Room> GetRooms();
        List<Room> GetRoomsByHotelId(Guid hotelId);
        Hotel UpdateRoom(UpdateRoomDTO room);
        void DeleteRoom(Guid id);
    }
}