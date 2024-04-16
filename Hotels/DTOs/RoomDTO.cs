using Hotels.Enums;

namespace Hotels.DTOs
{
    public record RoomDTO(
        Guid Id,
        int RoomNumber,
        RoomType RoomType,
        decimal PricePerNight,
        bool IsAvailable,
        Guid HotelId
    );
    public record CreateRoomDTO(
        int RoomNumber,
        RoomType RoomType,
        decimal PricePerNight,
        bool IsAvailable,
        Guid HotelId
    );
    public record UpdateRoomDTO(
        int RoomNumber,
        RoomType RoomType,
        decimal PricePerNight,
        bool IsAvailable,
        Guid HotelId
    );
}