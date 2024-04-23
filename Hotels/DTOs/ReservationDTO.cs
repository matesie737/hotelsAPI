namespace Hotels.DTOs
{
    public class ReservationDTO
    {
        public Guid Id { get; set; }
        public int GuestId { get; set; }
        public DateTime CheckInDate { get; set; }
        public DateTime CheckOutDate { get; set; }
        public decimal TotalPrice { get; set; }
        public bool IsConfirmed { get; set; }
        public Guid RoomId { get; set; }
        public Guid HotelId { get; set; }
    }

    public class ReservationExDTO
    {
        public Guid Id { get; set; }
        public int GuestId { get; set; }
        public DateTime CheckInDate { get; set; }
        public DateTime CheckOutDate { get; set; }
        public decimal TotalPrice { get; set; }
        public bool IsConfirmed { get; set; }
        public Guid RoomId { get; set; }
        public required RoomDTO Room { get; set; }
        public Guid HotelId { get; set; }
        public required HotelDTO Hotel { get; set; }
    }

    public class CreateReservationDTO
    {
        public int GuestId { get; set; }
        public DateTime CheckInDate { get; set; }
        public DateTime CheckOutDate { get; set; }
        public decimal TotalPrice { get; set; }
        public bool IsConfirmed { get; set; }
        public Guid RoomId { get; set; }
    }

    public class UpdateReservationDTO
    {
        public Guid Id { get; set; }
        public int GuestId { get; set; }
        public DateTime CheckInDate { get; set; }
        public DateTime CheckOutDate { get; set; }
        public decimal TotalPrice { get; set; }
        public bool IsConfirmed { get; set; }
        public Guid RoomId { get; set; }
    }
}
