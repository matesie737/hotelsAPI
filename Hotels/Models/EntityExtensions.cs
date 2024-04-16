using Hotels.DTOs;

namespace Hotels.Models
{

    public static class EntityExtensions
    {
        public static HotelDTO AsHotelDTO(this Hotel hotel)
        {
            return new HotelDTO(
                hotel.Id,
                hotel.Name,
                hotel.Address,
                hotel.City,
                hotel.Country,
                hotel.Description,
                hotel.StarRating
            );
        }
        public static RoomDTO AsRoomDTO(this Room room)
        {
            return new RoomDTO(
                room.Id,
                room.RoomNumber,
                room.RoomType,
                room.PricePerNight,
                room.IsAvailable,
                room.HotelId
            );
        }
        public static ReservationDTO AsReservationDTO(this Reservation reservation)
        {
            return new ReservationDTO(
                reservation.Id,
                reservation.GuestId,
                reservation.CheckInDate,
                reservation.CheckOutDate,
                reservation.TotalPrice,
                reservation.IsConfirmed,
                reservation.RoomId
            );
        }
    }


}