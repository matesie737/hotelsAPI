using AutoMapper;
using Hotels.DTOs;
using Hotels.Interfaces;
using Hotels.Models;

namespace Hotels.Services
{
    public class RoomService : IRoomService
    {
        private readonly IMapper _mapper;
        private readonly IRoomRepository _roomRepository;


        public RoomService(IRoomRepository roomRepository, IMapper mapper)
        {
            _roomRepository = roomRepository;
            _mapper = mapper;
        }

        public List<RoomDTO>? GetRooms()
        {
            var rooms = _roomRepository.GetRooms();

            if (rooms is null)
                return null;

            return _mapper.Map<List<RoomDTO>>(rooms);

        }

        public RoomExDTO? GetRoom(Guid id)
        {
            var room = _roomRepository.GetRoom(id);

            if (room is null)
                return null;

            return _mapper.Map<RoomExDTO>(room);
        }

        public RoomExDTO? GetRoomByReservationId(Guid reservationId)
        {
            var room = _roomRepository.GetRoomByReservationId(reservationId);

            if (room is null)
                return null;

            return _mapper.Map<RoomExDTO>(room);
        }

        public List<RoomDTO>? GetRoomsByHotelId(Guid hotelId)
        {
            var room = _roomRepository.GetRoomsByHotelId(hotelId);

            if (room is null)
                return null;

            return _mapper.Map<List<RoomDTO>>(room);
        }

        public RoomDTO? AddRoom(CreateRoomDTO room)
        {
            var roomEntity = _mapper.Map<Room>(room);
            var roomData = _roomRepository.AddRoom(roomEntity);

            if (roomData is null)
                return null;

            return _mapper.Map<RoomDTO>(roomData);
        }

        public RoomDTO? UpdateRoom(UpdateRoomDTO room)
        {
            var roomCheck = _roomRepository.GetRoom(room.Id);
            if (roomCheck is null)
                return new RoomDTO() { };

            var roomEntity = _mapper.Map<Room>(room);
            var roomData = _roomRepository.UpdateRoom(roomEntity);

            if (roomData is null)
                return null;

            return _mapper.Map<RoomDTO>(roomData);
        }

        public void DeleteRoom(Guid id)
        {
            _roomRepository.DeleteRoom(id);
        }
    }
}