using Hotels.DTOs;
using Hotels.Models;

namespace Hotels.Interfaces
{
    public interface IReservationService
    {
        Guid AddReservation(CreateReservationDTO reservation);
        List<Reservation> GetReservations();
        List<Reservation> GetReservationsByHotelId(Guid hotelId);
        List<Reservation> GetReservationsByRoomId(Guid roomId);
        Reservation UpdateReservation(UpdateReservationDTO reservation);
        void DeleteReservation(Guid id);
    }
}