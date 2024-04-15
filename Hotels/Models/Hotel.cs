namespace Hotels.Models
{
    public class Hotel
    {
        public Guid Id { get; set; }
        public required string Name { get; set; }
        public required string Address { get; set; }
        public required string City { get; set; }
        public required string Country { get; set; }
        public required string Description { get; set; }
        public int StarRating { get; set; }
        public List<Reservation> Reservations { get; set; }
        public List<Room> Rooms { get; set; }

    }
}