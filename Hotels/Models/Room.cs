using Hotels.Enums;

namespace Hotels.Models
{
    public class Room
    {
        public Guid Id { get; set; }
        public int RoomNumber { get; set; }
        public RoomType RoomType { get; set; }
        public decimal PricePerNight { get; set; }
        public bool IsAvailable { get; set; }
        public Guid HotelId { get; set; }
        public required Hotel Hotel { get; set; }
        public List<Reservation>? Reservations { get; set; }
    }
}