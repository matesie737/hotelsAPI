
using Hotels.Models;

namespace Hotels.Interfaces
{
    public interface IHotelRepository
    {
        IQueryable<Hotel> GetHotels();
        Hotel GetHotel(Guid id);
        Hotel GetHotelByReservationId(Guid id);
        Hotel GetHotelByRoomId(Guid id);
        Hotel AddHotel(Hotel hotel);
        Hotel UpdateHotel(Hotel hotel);
        void DeleteHotel(Guid id);
    }
}