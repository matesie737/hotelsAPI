using Hotels.Interfaces;
using Hotels.Models;

namespace Hotels.Repositories
{
    public class RoomRepository : IRoomRepository
    {
        public Guid AddRoom(Room room)
        {
            throw new NotImplementedException();
        }

        public void DeleteRoom(Guid id)
        {
            throw new NotImplementedException();
        }

        public Room GetRoom(Guid id)
        {
            throw new NotImplementedException();
        }

        public Room GetRoomByReservationId(Guid id)
        {
            throw new NotImplementedException();
        }

        public IQueryable<Room> GetRooms()
        {
            throw new NotImplementedException();
        }

        public IQueryable<Room> GetRoomsByHotelId(Guid hotelId)
        {
            throw new NotImplementedException();
        }

        public Room UpdateRoom(Room room)
        {
            throw new NotImplementedException();
        }
    }
}