using Hotels.DTOs;

namespace Hotels.Interfaces
{
    public interface IReservationService
    {
        List<ReservationDTO>? GetReservations();
        ReservationExDTO? GetReservation(Guid id);
        List<ReservationDTO>? GetReservationsByHotelId(Guid hotelId);
        List<ReservationDTO>? GetReservationsByRoomId(Guid roomId);
        ReservationDTO? AddReservation(CreateReservationDTO reservation);
        ReservationDTO? UpdateReservation(UpdateReservationDTO reservation);
        void DeleteReservation(Guid id);
    }
}