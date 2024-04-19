using Hotels.Database;
using Hotels.Interfaces;
using Hotels.Models;

namespace Hotels.Repositories
{
    public class ReservationRepository : IReservationRepository
    {
        private readonly AppDbContext _context;
        public ReservationRepository(AppDbContext context)
        {
            _context = context;
        }
        public Guid AddReservation(Reservation reservation)
        {
            throw new NotImplementedException();
        }

        public void DeleteReservation(Guid id)
        {
            throw new NotImplementedException();
        }

        public Reservation GetReservation(Guid id)
        {
            throw new NotImplementedException();
        }

        public IQueryable<Reservation> GetReservations()
        {
            throw new NotImplementedException();
        }

        public IQueryable<Reservation> GetReservationsByHotelId(Guid hotelId)
        {
            throw new NotImplementedException();
        }

        public IQueryable<Reservation> GetReservationsByRoomId(Guid roomId)
        {
            throw new NotImplementedException();
        }

        public Reservation UpdateReservation(Reservation reservation)
        {
            throw new NotImplementedException();
        }
    }
}