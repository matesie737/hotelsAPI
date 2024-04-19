using AutoMapper;
using Hotels.DTOs;
using Hotels.Interfaces;

namespace Hotels.Services
{
    public class ReservationService : IReservationService
    {
        private readonly IMapper _mapper;
        private readonly IReservationRepository _reservationRepository;
        public ReservationService(IReservationRepository reservationRepository, IMapper mapper)
        {
            _reservationRepository = reservationRepository;
            _mapper = mapper;
        }
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