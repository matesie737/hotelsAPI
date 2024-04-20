using AutoMapper;
using Hotels.DTOs;
using Hotels.Models;

namespace Hotels.Mapping
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<Hotel, HotelDTO>();
            CreateMap<Hotel, HotelExDTO>();
            CreateMap<CreateHotelDTO, Hotel>()
                .ReverseMap();
            CreateMap<UpdateHotelDTO, Hotel>().ReverseMap();

            CreateMap<Reservation, ReservationDTO>();
            CreateMap<Reservation, ReservationExDTO>();
            CreateMap<CreateReservationDTO, Reservation>()
                .ForMember(dest => dest.HotelId, opts => opts.MapFrom((src, dest, _, context) => context.Items["HotelId"]));
            CreateMap<UpdateReservationDTO, Reservation>()
                .ForMember(dest => dest.HotelId, opts => opts.MapFrom((src, dest, _, context) => context.Items["HotelId"]))
                .ReverseMap();

            CreateMap<Room, RoomDTO>();
            CreateMap<Room, RoomExDTO>();
            CreateMap<CreateRoomDTO, Room>();
            CreateMap<UpdateRoomDTO, Room>().ReverseMap();
        }
    }
}