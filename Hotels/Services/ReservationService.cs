using Hotels.DTOs;
using Hotels.Interfaces;

namespace Hotels.Services
{
    public class ReservationService : IReservationService
    {
        public List<ReservationDTO> GetReservations()
        {
            throw new NotImplementedException();
        }
        public ReservationDTO GetReservation(Guid id)
        {
            throw new NotImplementedException();
        }
        public List<ReservationDTO> GetReservationsByHotelId(Guid hotelId)
        {
            throw new NotImplementedException();
        }
        public List<ReservationDTO> GetReservationsByRoomId(Guid roomId)
        {
            throw new NotImplementedException();
        }
        public Guid AddReservation(CreateReservationDTO reservation)
        {
            throw new NotImplementedException();
        }
        public ReservationDTO UpdateReservation(UpdateReservationDTO reservation)
        {
            throw new NotImplementedException();
        }
        public void DeleteReservation(Guid id)
        {
            throw new NotImplementedException();
        }
    }
}