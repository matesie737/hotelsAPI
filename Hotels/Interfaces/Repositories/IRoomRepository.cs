using Hotels.Models;

namespace Hotels.Interfaces
{
    public interface IRoomRepository
    {
        IQueryable<Room> GetRooms();
        Room GetRoom(Guid id);
        Room GetRoomByReservationId(Guid id);
        IQueryable<Room> GetRoomsByHotelId(Guid hotelId);
        Guid AddRoom(Room room);
        Room UpdateRoom(Room room);
        void DeleteRoom(Guid id);
    }
}