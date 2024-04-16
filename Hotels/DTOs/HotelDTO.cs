namespace Hotels.DTOs
{
    public record HotelDTO(
        Guid Id,
        string Name,
        string Address,
        string City,
        string Country,
        string Description,
        int StarRating
    );
    public record CreateHotelDTO(
        string Name,
        string Address,
        string City,
        string Country,
        string Description,
        int StarRating
    );
    public record UpdateHotelDTO(
        string Name,
        string Address,
        string City,
        string Country,
        string Description,
        int StarRating
    );
}