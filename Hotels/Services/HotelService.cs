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
        public List<HotelDTO> GetHotels()
        {
            var hotels = _hotelRepository.GetHotels();
            if(hotels is not null)
            {
                return _mapper.Map<List<HotelDTO>>(hotels);
            }
            return null;
        }
        public HotelDTO GetHotel(Guid id)
        {
            var hotel = _hotelRepository.GetHotel(id);
            if (hotel is not null)
            {
                return _mapper.Map<HotelDTO>(hotel);
            }
            return null;
        }
        public HotelDTO GetHotelByReservationId(Guid id)
        {

            var hotel = _hotelRepository.GetHotelByReservationId(id);
            if (hotel is not null)
            {
                return _mapper.Map<HotelDTO>(hotel);
            }
            return null;
        }
        public HotelDTO GetHotelByRoomId(Guid id)
        {

            var hotel = _hotelRepository.GetHotelByRoomId(id);
            if (hotel is not null)
            {
                return _mapper.Map<HotelDTO>(hotel);
            }
            return null;
        }
        public Guid AddHotel(CreateHotelDTO hotel)
        {
            var hotelEntity = _mapper.Map<Hotel>(hotel);
            return _hotelRepository.AddHotel(hotelEntity);
        }
        public HotelDTO UpdateHotel(UpdateHotelDTO hotel)
        {
            var hotelEntity = _mapper.Map<Hotel>(hotel);
            var hotelResponse = _hotelRepository.UpdateHotel(hotelEntity);
            if(hotelResponse is not null)
            {
                return _mapper.Map<HotelDTO>(hotelResponse);
            }
            return null;
        }
        public void DeleteHotel(Guid id)
        {
            _hotelRepository.DeleteHotel(id);
        }
    }
}