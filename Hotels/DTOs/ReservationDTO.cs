namespace Hotels.DTOs
{
    public record ReservationDTO(
        Guid Id,
        int GuestId,
        DateTime CheckInDate,
        DateTime CheckOutDate,
        decimal TotalPrice,
        bool IsConfirmed,
        Guid RoomId
    );
    public record CreateReservationDTO(
        int GuestId,
        DateTime CheckInDate,
        DateTime CheckOutDate,
        decimal TotalPrice,
        bool IsConfirmed,
        Guid RoomId
    );
    public record UpdateReservationDTO(
        int GuestId,
        DateTime CheckInDate,
        DateTime CheckOutDate,
        decimal TotalPrice,
        bool IsConfirmed,
        Guid RoomId
    );
}