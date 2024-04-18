using Hotels.DTOs;
using Hotels.Interfaces;

namespace Hotels.Services
{
    public class HotelService : IHotelService
    {
        private readonly IHotelRepository _hotelRepository;
        public HotelService(IHotelRepository hotelRepository){
            _hotelRepository = hotelRepository;
        }
        public List<HotelDTO> GetHotels()
        {
            throw new NotImplementedException();
        }
        public HotelDTO GetHotel(Guid id)
        {
            throw new NotImplementedException();
        }
        public HotelDTO GetHotelByReservationId(Guid id)
        {
            throw new NotImplementedException();
        }
        public HotelDTO GetHotelByRoomId(Guid id)
        {
            throw new NotImplementedException();
        }
        public HotelDTO AddHotel(CreateHotelDTO hotel)
        {
            throw new NotImplementedException();
        }
        public HotelDTO UpdateHotel(UpdateHotelDTO hotel)
        {
            throw new NotImplementedException();
        }
        public void DeleteHotel(Guid id)
        {
            throw new NotImplementedException();
        }
    }
}