using Hotels.DTOs;

namespace Hotels.Interfaces
{
    public interface IHotelService
    {
        List<HotelDTO> GetHotels();
        HotelDTO GetHotel(Guid id);
        HotelDTO GetHotelByReservationId(Guid id);
        HotelDTO GetHotelByRoomId(Guid id);
        Guid AddHotel(CreateHotelDTO hotel);
        HotelDTO UpdateHotel(UpdateHotelDTO hotel);
        void DeleteHotel(Guid id);
    }
}