using AutoMapper;
using Hotels.DTOs;
using Hotels.Interfaces;
using Hotels.Models;

namespace Hotels.Services
{
    public class HotelService : IHotelService
    {
        private readonly IMapper _mapper;
        private readonly IHotelRepository _hotelRepository;

        public HotelService(IHotelRepository hotelRepository, IMapper mapper)
        {
            _hotelRepository = hotelRepository;
            _mapper = mapper;
        }

        public List<HotelDTO>? GetHotels()
        {
            var hotels = _hotelRepository.GetHotels();

            if (hotels is null)
                return null;

            return _mapper.Map<List<HotelDTO>>(hotels);

        }

        public HotelExDTO? GetHotel(Guid id)
        {
            var hotel = _hotelRepository.GetHotel(id);

            if (hotel is null)
                return null;

            return _mapper.Map<HotelExDTO>(hotel);

        }

        public HotelExDTO? GetHotelByReservationId(Guid id)
        {

            var hotel = _hotelRepository.GetHotelByReservationId(id);

            if (hotel is null)
                return null;

            return  _mapper.Map<HotelExDTO>(hotel);

        }

        public HotelExDTO? GetHotelByRoomId(Guid id)
        {

            var hotel = _hotelRepository.GetHotelByRoomId(id);

            if (hotel is null)
                return null;

            return _mapper.Map<HotelExDTO>(hotel);
        }

        public HotelDTO? AddHotel(CreateHotelDTO hotel)
        {
            var hotelEntity = _mapper.Map<Hotel>(hotel);
            var hotelData = _hotelRepository.AddHotel(hotelEntity);

            if (hotelData is null)
                return null;

            return _mapper.Map<HotelDTO>(hotelData);
        }

        public HotelDTO? UpdateHotel(UpdateHotelDTO hotel)
        {
            var hotelCheck = _hotelRepository.GetHotel(hotel.Id);
            if (hotelCheck is null)
                return new HotelDTO(){};

            var hotelEntity = _mapper.Map<Hotel>(hotel);
            var hotelData = _hotelRepository.UpdateHotel(hotelEntity);

            if (hotelData is null)
                return null;

            return _mapper.Map<HotelDTO>(hotelData);

        }

        public void DeleteHotel(Guid id)
        {
            _hotelRepository.DeleteHotel(id);
        }
    }
}