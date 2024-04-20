using Hotels.Database;
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

        public Room? AddRoom(Room room)
        {
            _context.Rooms.Add(room);
            _context.SaveChanges();

            var roomData = _context.Rooms.FirstOrDefault(r => r.Id == room.Id);

            return roomData;
        }

        public void DeleteRoom(Guid id)
        {
            var room = _context.Rooms.FirstOrDefault(r => r.Id == id);
            if (room is not null)
            {
                _context.Rooms.Remove(room);
                _context.SaveChanges();
            }
        }

        public Room? GetRoom(Guid id)
        {
            var room = _context.Rooms.FirstOrDefault(r => r.Id == id);
            return room;
        }

        public Room? GetRoomByReservationId(Guid id)
        {
            var reservation = _context.Reservations.FirstOrDefault(r => r.Id == id);
            if (reservation is null)
                return null;

            var room = _context.Rooms.FirstOrDefault(r => r.Id == reservation.RoomId);
            return room;
        }

        public IQueryable<Room> GetRooms()
        {
            var rooms = _context.Rooms;
            return rooms;
        }

        public IQueryable<Room>? GetRoomsByHotelId(Guid hotelId)
        {

            var hotel = _context.Hotels.FirstOrDefault(h => h.Id == hotelId);
            if (hotel is null) return null;

            var rooms = _context.Rooms.Where(r => r.HotelId == hotelId);
            return rooms;
        }

        public Room? UpdateRoom(Room room)
        {
            var dbRoom = _context.Rooms.FirstOrDefault(r => r.Id == room.Id);
            if (dbRoom is null) return null;

            _context.Entry(dbRoom).CurrentValues.SetValues(room);
            _context.SaveChanges();

            var roomData = _context.Rooms.FirstOrDefault(r => r.Id == dbRoom.Id);
            return roomData;
        }
    }
}