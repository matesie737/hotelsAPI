using Hotels.DTOs;

namespace Hotels.Interfaces
{
    public interface IHotelService
    {
        List<HotelDTO>? GetHotels();
        HotelExDTO? GetHotel(Guid id);
        HotelExDTO? GetHotelByReservationId(Guid id);
        HotelExDTO? GetHotelByRoomId(Guid id);
        HotelDTO? AddHotel(CreateHotelDTO hotel);
        HotelDTO? UpdateHotel(UpdateHotelDTO hotel);
        void DeleteHotel(Guid id);
    }
}