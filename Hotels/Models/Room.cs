namespace Hotels.Models
{
    public class Room
    {
        public int Id { get; set; }
        public int RoomNumber { get; set; }
        public required string RoomType { get; set; }
        public decimal PricePerNight { get; set; }
        public bool IsAvailable { get; set; }
        public Guid HotelId { get; set; }
        public Hotel Hotel { get; set; }

        public List<Reservation> Reservations { get; set; }
    }
}