using Hotels.Database;
using Hotels.DTOs;
using Hotels.Interfaces;
using Hotels.Models;

namespace Hotels.Repositories
{
    public class RoomRepository : IRoomRepository
    {
        private readonly AppDbContext _context;
        public RoomRepository(AppDbContext context)
        {
            _context = context;
        }
        public Guid AddRoom(Room room)
        {
            _context.Rooms.Add(room);
            return room.Id;
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