using Hotels.Database;
using Hotels.Interfaces;
using Hotels.Models;
using Microsoft.EntityFrameworkCore;

namespace Hotels.Repositories
{
    public class ReservationRepository : IReservationRepository
    {
        private readonly AppDbContext _context;

        public ReservationRepository(AppDbContext context)
        {
            _context = context;
        }

        public Reservation? AddReservation(Reservation reservation)
        {
            _context.Reservations.Add(reservation);
            _context.SaveChanges();

            var reservationData = _context.Reservations.FirstOrDefault(r => r.Id == reservation.Id);

            return reservationData;
        }

        public void DeleteReservation(Guid id)
        {
            var reservation = _context.Reservations.FirstOrDefault(r => r.Id == id);
            if (reservation is not null)
            {
                _context.Reservations.Remove(reservation);
                _context.SaveChanges();
            }
        }

        public Reservation? GetReservation(Guid id)
        {
            var reservation = _context.Reservations.Include(r => r.Hotel).Include(r => r.Room).FirstOrDefault(r => r.Id == id);
            return reservation;
        }

        public IQueryable<Reservation> GetReservations()
        {
            var reservations = _context.Reservations;
            return reservations;
        }

        public IQueryable<Reservation>? GetReservationsByHotelId(Guid hotelId)
        {
            var hotel = _context.Hotels.FirstOrDefault(h => h.Id == hotelId);
            if (hotel is null) return null;

            var reservations = _context.Reservations.Where(r => r.HotelId == hotelId);
            return reservations;
        }

        public IQueryable<Reservation>? GetReservationsByRoomId(Guid roomId)
        {
            var room = _context.Rooms.FirstOrDefault(r => r.Id == roomId);
            if (room is null) return null;

            var reservations = _context.Reservations.Where(r => r.RoomId == roomId);
            return reservations;
        }

        public Reservation? UpdateReservation(Reservation reservation)
        {
            var dbReservation = _context.Reservations.FirstOrDefault(r => r.Id == reservation.Id);
            if (dbReservation is null) return null;

            _context.Entry(dbReservation).CurrentValues.SetValues(reservation);
            _context.SaveChanges();

            var reservationData = _context.Reservations.FirstOrDefault(r => r.Id == dbReservation.Id);
            return reservationData;
        }
    }
}