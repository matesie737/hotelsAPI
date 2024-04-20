using Hotels.Database;
using Hotels.Interfaces;
using Hotels.Models;
using Microsoft.EntityFrameworkCore;

namespace Hotels.Repositories
{
    public class HotelRepository : IHotelRepository
    {
        private readonly AppDbContext _context;

        public HotelRepository(AppDbContext context)
        {
            _context = context;
        }

        public Hotel? AddHotel(Hotel hotel)
        {
            _context.Hotels.Add(hotel);
            _context.SaveChanges();

            var HotelData = _context.Hotels.FirstOrDefault(h => h.Id == hotel.Id);

            return HotelData;

        }

        public void DeleteHotel(Guid id)
        {
            var hotel = _context.Hotels.FirstOrDefault(h => h.Id == id);
            if (hotel is not null)
            {
                _context.Hotels.Remove(hotel);
                _context.SaveChanges();
            }
        }

        public Hotel? GetHotel(Guid id)
        {
            var hotel = _context.Hotels.Include(h => h.Rooms).Include(h =>h.Reservations).FirstOrDefault(h => h.Id == id);
            return hotel;
        }

        public Hotel? GetHotelByReservationId(Guid id)
        {
            var reservation = _context.Reservations.FirstOrDefault(r => r.Id == id);
            if (reservation is null)
                return null;

            var hotel = _context.Hotels.Include(h => h.Rooms).Include(h => h.Reservations).FirstOrDefault(h => h.Id == reservation.HotelId);
            return hotel;

        }

        public Hotel? GetHotelByRoomId(Guid id)
        {
            var room = _context.Rooms.FirstOrDefault(r => r.Id == id);
            if (room is null)
                return null;

            var hotel = _context.Hotels.Include(h => h.Rooms).Include(h => h.Reservations).FirstOrDefault(h => h.Id == room.HotelId);
            return hotel;

        }

        public IQueryable<Hotel> GetHotels()
        {
            var hotels = _context.Hotels;
            return hotels;
        }

        public Hotel? UpdateHotel(Hotel hotel)
        {
            var dbHotel = _context.Hotels.FirstOrDefault(h => h.Id == hotel.Id);
            if (dbHotel is null) return null;

            _context.Entry(dbHotel).CurrentValues.SetValues(hotel);
            _context.SaveChanges();

            var hotelData = _context.Hotels.FirstOrDefault(h => h.Id == dbHotel.Id);
            return hotelData;

        }
    }
}