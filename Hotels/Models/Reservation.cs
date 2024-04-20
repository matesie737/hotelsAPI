namespace Hotels.Models
{
    public class Reservation
    {
        public Guid Id { get; set; }
        public int GuestId { get; set; }
        public DateTime CheckInDate { get; set; }
        public DateTime CheckOutDate { get; set; }
        public decimal TotalPrice { get; set; }
        public bool IsConfirmed { get; set; }
        public Guid RoomId { get; set; }
        public required Room Room { get; set; }
        public Guid HotelId {get; set;}
        public required Hotel Hotel {get; set;}
    }
}