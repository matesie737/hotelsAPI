using AutoMapper;
using Hotels.Enums;
using Hotels.Models;

namespace Hotels.DTOs
{
    public class RoomDTO
    {
        public Guid Id { get; set; }
        public int RoomNumber { get; set; }
        public RoomType RoomType { get; set; }
        public decimal PricePerNight { get; set; }
        public bool IsAvailable { get; set; }
        public Guid HotelId { get; set; }
        public List<ReservationDTO>? Reservations { get; set; }
    }

    public class CreateRoomDTO
    {
        public int RoomNumber { get; set; }
        public RoomType RoomType { get; set; }
        public decimal PricePerNight { get; set; }
        public bool IsAvailable { get; set; }
        public Guid HotelId { get; set; }
        public List<CreateReservationDTO>? Reservations { get; set; }
    }

    public class UpdateRoomDTO
    {
        public Guid Id { get; set; }
        public int RoomNumber { get; set; }
        public RoomType RoomType { get; set; }
        public decimal PricePerNight { get; set; }
        public bool IsAvailable { get; set; }
        public Guid HotelId { get; set; }
        public List<ReservationDTO>? Reservations { get; set; }
    }
}
