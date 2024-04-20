using AutoMapper;
using Hotels.DTOs;
using Hotels.Interfaces;
using Hotels.Models;
using Hotels.Repositories;

namespace Hotels.Services
{
    public class ReservationService : IReservationService
    {
        private readonly IMapper _mapper;
        private readonly IReservationRepository _reservationRepository;
        private readonly IRoomRepository _roomRepository;

        public ReservationService(IReservationRepository reservationRepository, IRoomRepository roomRepository, IMapper mapper)
        {
            _reservationRepository = reservationRepository;
            _roomRepository = roomRepository;
            _mapper = mapper;
        }

        public List<ReservationDTO>? GetReservations()
        {
            var reservations = _reservationRepository.GetReservations();

            if (reservations is null)
                return null;

            return _mapper.Map<List<ReservationDTO>>(reservations);
        }

        public ReservationExDTO? GetReservation(Guid id)
        {
            var reservation = _reservationRepository.GetReservation(id);

            if (reservation is null)
                return null;

            return _mapper.Map<ReservationExDTO>(reservation);
        }

        public List<ReservationDTO>? GetReservationsByHotelId(Guid hotelId)
        {
            var reservations = _reservationRepository.GetReservationsByHotelId(hotelId);

            if (reservations is null)
                return null;

            return _mapper.Map<List<ReservationDTO>>(reservations);
        }

        public List<ReservationDTO>? GetReservationsByRoomId(Guid roomId)
        {

            var reservations = _reservationRepository.GetReservationsByRoomId(roomId);

            if (reservations is null)
                return null;

            return _mapper.Map<List<ReservationDTO>>(reservations);
        }

        public ReservationDTO? AddReservation(CreateReservationDTO reservation)
        {
            var roomData = _roomRepository.GetRoom(reservation.RoomId);
            if (roomData is null)
                return null;

            var reservationEntity = _mapper.Map<Reservation>(reservation, opt => opt.Items["HotelId"] = roomData.HotelId);
            var reservationData = _reservationRepository.AddReservation(reservationEntity);

            if (reservationData is null)
                return null;

            return _mapper.Map<ReservationDTO>(reservationData);
        }

        public ReservationDTO? UpdateReservation(UpdateReservationDTO reservation)
        {
            var reservationCheck = _reservationRepository.GetReservation(reservation.Id);
            if (reservationCheck is null)
                return new ReservationDTO() { };

            var roomData = _roomRepository.GetRoom(reservation.RoomId);
            if (roomData is null)
                return null;

            var reservationEntity = _mapper.Map<Reservation>(reservation, opt => opt.Items["HotelId"] = roomData.HotelId);
            var reservationData = _reservationRepository.UpdateReservation(reservationEntity);

            if (reservationData is null)
                return null;

            return _mapper.Map<ReservationDTO>(reservationData);
        }

        public void DeleteReservation(Guid id)
        {
            _reservationRepository.DeleteReservation(id);
        }
    }
}