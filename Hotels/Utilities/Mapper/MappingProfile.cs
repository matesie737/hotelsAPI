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
                .ReverseMap();
            CreateMap<UpdateHotelDTO, Hotel>().ReverseMap();

            CreateMap<Reservation, ReservationDTO>();
            CreateMap<CreateReservationDTO, Reservation>();
            CreateMap<UpdateReservationDTO, Reservation>().ReverseMap();

            CreateMap<Room, RoomDTO>();
            CreateMap<CreateRoomDTO, Room>();
            CreateMap<UpdateRoomDTO, Room>().ReverseMap();
        }
    }
}