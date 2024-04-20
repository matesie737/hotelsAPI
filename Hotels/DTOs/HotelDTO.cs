using AutoMapper;
using Hotels.Models;

namespace Hotels.DTOs
{
    public class HotelDTO
    {
        public Guid Id { get; set; }
        public string Name { get; set; } = "";
        public string Address { get; set; } = "";
        public string City { get; set; } = "";
        public string Country { get; set; } = "";
        public string Description { get; set; } = "";
        public int StarRating { get; set; }
    }
    public class HotelExDTO
    {
        public Guid Id { get; set; }
        public string Name { get; set; } = "";
        public string Address { get; set; } = "";
        public string City { get; set; } = "";
        public string Country { get; set; } = "";
        public string Description { get; set; } = "";
        public int StarRating { get; set; }
        public List<ReservationDTO>? Reservations { get; set; }
        public List<RoomDTO>? Rooms { get; set; }
    }

    public class CreateHotelDTO
    {
        public string Name { get; set; } = "";
        public string Address { get; set; } = "";
        public string City { get; set; } = "";
        public string Country { get; set; } = "";
        public string Description { get; set; } = "";
        public int StarRating { get; set; }
    }

    public class UpdateHotelDTO
    {
        public Guid Id { get; set; }
        public string Name { get; set; } = "";
        public string Address { get; set; } = "";
        public string City { get; set; } = "";
        public string Country { get; set; } = "";
        public string Description { get; set; } = "";
        public int StarRating { get; set; }
    }
}