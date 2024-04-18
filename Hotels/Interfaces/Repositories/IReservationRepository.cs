using Hotels.Models;

namespace Hotels.Interfaces
{
    public interface IReservationRepository
    {
        IQueryable<Reservation> GetReservations();
        Reservation GetReservation(Guid id);
        IQueryable<Reservation> GetReservationsByHotelId(Guid hotelId);
        IQueryable<Reservation> GetReservationsByRoomId(Guid roomId);
        Guid AddReservation(Reservation reservation);
        Reservation UpdateReservation(Reservation reservation);
        void DeleteReservation(Guid id);
    }
}