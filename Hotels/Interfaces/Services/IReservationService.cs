using Hotels.DTOs;
using Hotels.Models;

namespace Hotels.Interfaces
{
    public interface IReservationService
    {
        List<ReservationDTO> GetReservations();
        ReservationDTO GetReservation(Guid id);
        List<ReservationDTO> GetReservationsByHotelId(Guid hotelId);
        List<ReservationDTO> GetReservationsByRoomId(Guid roomId);
        Guid AddReservation(CreateReservationDTO reservation);
        ReservationDTO UpdateReservation(UpdateReservationDTO reservation);
        void DeleteReservation(Guid id);
    }
}