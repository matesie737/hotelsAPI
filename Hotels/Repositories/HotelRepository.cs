using Hotels.Interfaces;
using Hotels.Models;

namespace Hotels.Repositories
{
    public class HotelRepository : IHotelRepository
    {
        public Hotel AddHotel(Hotel hotel)
        {
            throw new NotImplementedException();
        }

        public void DeleteHotel(Guid id)
        {
            throw new NotImplementedException();
        }

        public Hotel GetHotel(Guid id)
        {
            throw new NotImplementedException();
        }

        public Hotel GetHotelByReservationId(Guid id)
        {
            throw new NotImplementedException();
        }

        public Hotel GetHotelByRoomId(Guid id)
        {
            throw new NotImplementedException();
        }

        public IQueryable<Hotel> GetHotels()
        {
            throw new NotImplementedException();
        }

        public Hotel UpdateHotel(Hotel hotel)
        {
            throw new NotImplementedException();
        }
    }
}