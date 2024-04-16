using Hotels.DTOs;
using Hotels.Models;

namespace Hotels.Interfaces
{
    public interface IHotelService
    {
        Guid AddHotel(CreateHotelDTO hotel);
        List<Hotel> GetHotels();
        Hotel UpdateHotel(UpdateHotelDTO hotel);
        void DeleteHotel(Guid id);
    }
}