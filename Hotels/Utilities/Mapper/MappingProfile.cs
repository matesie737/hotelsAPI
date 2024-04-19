using AutoMapper;
using Hotels.DTOs;
using Hotels.Models;
using System.Reflection;

namespace Hotels.Mapping
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<Hotel, HotelDTO>();
            CreateMap<CreateHotelDTO, Hotel>()
                .ForMember(dest => dest.Reservations, opt => opt.MapFrom(src => src.Reservations ?? new List<CreateReservationDTO>()))
                .ForMember(dest => dest.Rooms, opt => opt.MapFrom(src => src.Rooms ?? new List<CreateRoomDTO>()))
                .ReverseMap();
            CreateMap<UpdateHotelDTO, Hotel>().ReverseMap();

            CreateMap<Reservation, ReservationDTO>();
            CreateMap<CreateReservationDTO, Reservation>();
            CreateMap<UpdateReservationDTO, Reservation>().ReverseMap();

            CreateMap<Room, RoomDTO>();
            CreateMap<CreateRoomDTO, Room>()
                .ForMember(dest => dest.Reservations, opt => opt.MapFrom(src => src.Reservations ?? new List<CreateReservationDTO>()));
            CreateMap<UpdateRoomDTO, Room>().ReverseMap();
        }
    }
}